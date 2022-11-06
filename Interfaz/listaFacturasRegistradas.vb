Imports System.Dynamic
Imports System.IO
Imports System.Linq.Expressions
Imports System.Xml
Imports Entities
Imports Interfaz.GENERALS


Public Class listaFacturasRegistradas

    Private Sub btnGuardarFactura_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub listaFacturasRegistradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInvoices()
    End Sub


    Private Sub loadInvoices()
        Try
            Dim table As New DataTable()
            table.Columns.Add("Código F")
            table.Columns.Add("Fecha")
            table.Columns.Add("Nombre")
            table.Columns.Add("Apellidos")
            table.Columns.Add("Identificación")
            table.Columns.Add("Sub Total")
            dgvInvoices.Columns.Clear()
            If listOfInvoices.Count > 0 Then
                For Each objInvoice As invoice In listOfInvoices
                    table.Rows.Add(objInvoice.idInvoice, objInvoice.dateInvoice, objInvoice.customer.Name, objInvoice.customer.LastName, objInvoice.customer.id, objInvoice.subtotal)
                    dgvInvoices.DataSource = table
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnImportInvoices_Click(sender As Object, e As EventArgs) Handles btnImportInvoices.Click
        Try
            OpenFileDialogInvoice.Title = "Importar Archivo XML"
            OpenFileDialogInvoice.Filter = "Archivo xml|*.xml"

            If OpenFileDialogInvoice.ShowDialog() = Windows.Forms.DialogResult.OK Then
                listOfInvoices.Clear()
                Dim urlFile As String = OpenFileDialogInvoice.FileName
                Dim data As New FileStream(urlFile, FileMode.Open, FileAccess.Read)
                Dim documentXML As New XmlDataDocument()

                documentXML.Load(data)

                Dim listNodeXML As XmlNodeList
                listNodeXML = documentXML.GetElementsByTagName("Invoice")
                For Each _node1 As XmlNode In listNodeXML
                    Dim tmpInvoice As New invoice()
                    tmpInvoice.idInvoice = _node1.SelectSingleNode("Id").InnerText
                    tmpInvoice.dateInvoice = _node1.SelectSingleNode("Date").InnerText
                    tmpInvoice.subtotal = Double.Parse(_node1.SelectSingleNode("SubTotal").InnerText)
                    tmpInvoice.totalPrice = Double.Parse(_node1.SelectSingleNode("TotalPrice").InnerText)

                    Dim customerNodes = _node1.SelectNodes("Customer")

                    For Each _node3 As XmlNode In customerNodes
                        tmpInvoice.customer = New Customer()
                        tmpInvoice.customer.id = _node3.SelectSingleNode("Id").InnerText
                        tmpInvoice.customer.typeId = _node3.SelectSingleNode("typeId").InnerText
                        tmpInvoice.customer.Name = _node3.SelectSingleNode("Name").InnerText
                        tmpInvoice.customer.LastName = _node3.SelectSingleNode("LastName").InnerText
                    Next


                    Dim listProductsXML = _node1.SelectNodes("ListProducts/Product")
                    For Each _node2 As XmlNode In listProductsXML
                        Dim tmpProduct As New ProductSelected()
                        tmpProduct.Id = _node2.SelectSingleNode("Id").InnerText
                        tmpProduct.Name = _node2.SelectSingleNode("Name").InnerText
                        tmpProduct.Price = Double.Parse(_node2.SelectSingleNode("Price").InnerText)
                        tmpProduct.Quantity = Integer.Parse(_node2.SelectSingleNode("Quantity").InnerText)
                        tmpInvoice.listOfProducts.Add(tmpProduct)
                    Next
                    listOfInvoices.Add(tmpInvoice)
                Next
                loadInvoices()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportInvoices_Click(sender As Object, e As EventArgs) Handles btnExportInvoices.Click
        Try
            If listOfInvoices.Count > 3 Then
                SaveFileDialogInvoice.Title = "Exportar Facturas"
                SaveFileDialogInvoice.Filter = "Archivo XML|*.xml"
                If SaveFileDialogInvoice.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim urlFile = SaveFileDialogInvoice.FileName
                    Dim config As New XmlWriterSettings()
                    config.Indent = True
                    Using _writer As XmlWriter = XmlWriter.Create(urlFile, config)
                        _writer.WriteStartDocument()
                        _writer.WriteStartElement("InvoicesList")
                        For Each objInvoice As invoice In listOfInvoices
                            ' Start the Invoice
                            _writer.WriteStartElement("Invoice")
                            _writer.WriteElementString("Id", objInvoice.idInvoice)
                            _writer.WriteElementString("Date", objInvoice.dateInvoice)
                            _writer.WriteElementString("SubTotal", objInvoice.subtotal)
                            _writer.WriteElementString("TotalPrice", objInvoice.totalPrice)
                            'Start Customer
                            _writer.WriteStartElement("Customer")
                            _writer.WriteElementString("Id", objInvoice.customer.id)
                            _writer.WriteElementString("typeId", objInvoice.customer.typeId)
                            _writer.WriteElementString("Name", objInvoice.customer.Name)
                            _writer.WriteElementString("LastName", objInvoice.customer.LastName)
                            'Finish customer
                            _writer.WriteEndElement()
                            'Start List Products
                            _writer.WriteStartElement("ListProducts")
                            For Each tmpProduct As ProductSelected In objInvoice.listOfProducts
                                'Start Product
                                _writer.WriteStartElement("Product")
                                _writer.WriteElementString("Id", tmpProduct.Id)
                                _writer.WriteElementString("Name", tmpProduct.Name)
                                _writer.WriteElementString("Description", tmpProduct.Description)
                                _writer.WriteElementString("Price", tmpProduct.Price)
                                _writer.WriteElementString("Quantity", tmpProduct.Quantity)
                                'End Product
                                _writer.WriteEndElement()
                            Next

                            'finish list products
                            _writer.WriteEndElement()
                            'Finish the Invoice
                            _writer.WriteEndElement()
                        Next
                        _writer.WriteEndElement()
                        _writer.WriteEndDocument()
                    End Using
                End If
            Else
                MessageBox.Show("Require un mínimo de 3 facturas", "No se puede exportar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class