Imports System.Dynamic
Imports System.Linq.Expressions
Imports System.Xml
Imports Entities
Imports Interfaz.GENERALS


Public Class listaFacturasRegistradas

    Private Sub btnGuardarFactura_Click(sender As Object, e As EventArgs) Handles btnGuardarFactura.Click

    End Sub

    Private Sub listaFacturasRegistradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInvoices()
    End Sub


    Private Sub loadInvoices()
        Try
            Dim table As New DataTable()
            table.Columns.Add("Código")
            table.Columns.Add("Fecha")
            table.Columns.Add("Cliente")
            table.Columns.Add("Identificación")
            table.Columns.Add("Sub Total")
            If listOfInvoices.Count > 0 Then
                For Each objInvoice As invoice In listOfInvoices
                    Dim fullName As String = objInvoice.customer.Name + "" + objInvoice.customer.LastName
                    table.Rows.Add(objInvoice.idInvoice, objInvoice.dateInvoice, fullName, objInvoice.customer.id, objInvoice.subtotal)
                    dgvInvoices.Columns.Clear()

                    dgvInvoices.DataSource = table
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnImportInvoices_Click(sender As Object, e As EventArgs) Handles btnImportInvoices.Click

    End Sub

    Private Sub btnExportInvoices_Click(sender As Object, e As EventArgs) Handles btnExportInvoices.Click
        Try
            If listOfInvoices.Count >= 1 Then
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
                            _writer.WriteEndElement()
                            'Finish customer
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