Imports System.IO
Imports System.Security.Cryptography.Xml
Imports System.Xml
Imports Entities

Public Class listaClientes

    Private Sub listaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCustomers()
    End Sub

    Private Sub loadCustomers()
        Try
            Dim table As New DataTable

            table.Columns.Add("Identificación")
            table.Columns.Add("Apellidos")
            table.Columns.Add("Nombre")

            If GENERALS.listOfCustomers.Count > 0 Then
                For Each objCustomer As Customer In GENERALS.listOfCustomers
                    table.Rows.Add(objCustomer.id, objCustomer.LastName, objCustomer.Name)
                Next
                dgvCustomers.Columns.Clear()
                ' add button to select
                Dim btn As New DataGridViewButtonColumn
                btn.HeaderText = "Seleccionar"
                btn.Text = "Seleccionar"
                btn.Name = "btnSelectCustomer"
                btn.UseColumnTextForButtonValue = True
                dgvCustomers.Columns.Add(btn)
                dgvCustomers.DataSource = table
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportCustomers_Click(sender As Object, e As EventArgs) Handles btnExportCustomers.Click
        Try
            If GENERALS.listOfCustomers.Count > 0 Then
                SaveFileDialogCustomers.Title = "Exportar Clientes"
                SaveFileDialogCustomers.Filter = "Archivo de XML|*.xml"

                If SaveFileDialogCustomers.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim urlFile = SaveFileDialogCustomers.FileName
                    Dim config As New XmlWriterSettings()
                    config.Indent = True
                    Using _writer As XmlWriter = XmlWriter.Create(urlFile, config)
                        _writer.WriteStartDocument()
                        _writer.WriteStartElement("ListOfCustomers")
                        For Each cust As Customer In GENERALS.listOfCustomers
                            _writer.WriteStartElement("Customer")
                            _writer.WriteElementString("Id", cust.id)
                            _writer.WriteElementString("TypeId", cust.typeId)
                            _writer.WriteElementString("Name", cust.Name)
                            _writer.WriteElementString("LastName", cust.LastName)
                            _writer.WriteEndElement()
                        Next
                        _writer.WriteEndElement()
                        _writer.WriteEndDocument()
                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImportCustomers_Click(sender As Object, e As EventArgs) Handles btnImportCustomers.Click
        Try
            OpenFileDialogCustomers.Title = "Importar Clientes"
            OpenFileDialogCustomers.Filter = "Archivo de XML|*.xml"
            If OpenFileDialogCustomers.ShowDialog() = Windows.Forms.DialogResult.OK Then
                GENERALS.listOfCustomers.Clear()
                Dim urlFile = OpenFileDialogCustomers.FileName
                Dim data As New FileStream(urlFile, FileMode.Open, FileAccess.Read)
                Dim xmlDocument As New XmlDataDocument()
                xmlDocument.Load(data)
                Dim xmlNodelist As XmlNodeList
                xmlNodelist = xmlDocument.GetElementsByTagName("Customer")
                For Each nodo As XmlNode In xmlNodelist
                    Dim tmp As New Customer
                    tmp.id = Integer.Parse(nodo.SelectSingleNode("Id").InnerText)
                    tmp.Name = nodo.SelectSingleNode("Name").InnerText
                    tmp.LastName = nodo.SelectSingleNode("LastName").InnerText
                    tmp.typeId = nodo.SelectSingleNode("TypeId").InnerText
                    GENERALS.listOfCustomers.Add(tmp)
                Next
                loadCustomers()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class