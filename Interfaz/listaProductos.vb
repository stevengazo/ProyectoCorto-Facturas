Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Xml
Imports Entities

Public Class listaProductos
    Private Sub Label6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnExportProducts_Click(sender As Object, e As EventArgs) Handles btnExportProducts.Click
        Try
            SaveFileDialogProducts.Title = "Exportar Productos"
            SaveFileDialogProducts.Filter = "Archivo XML|*.xml"
            If SaveFileDialogProducts.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim urlFile = SaveFileDialogProducts.FileName
                Dim config As New XmlWriterSettings()
                config.Indent = True
                Using writer As XmlWriter = XmlWriter.Create(urlFile, config)
                    writer.WriteStartDocument()
                    writer.WriteStartElement("ProductList")
                    For Each obj As Product In GENERALS.listOfProducts
                        writer.WriteStartElement("Product")
                        writer.WriteElementString("Id", obj.Id)
                        writer.WriteElementString("Name", obj.Name)
                        writer.WriteElementString("Description", obj.Description)
                        writer.WriteElementString("Price", obj.Price)
                        writer.WriteEndElement()
                    Next
                    writer.WriteEndElement()
                    writer.WriteEndDocument()
                End Using
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnImportProducts_Click(sender As Object, e As EventArgs) Handles btnImportProducts.Click
        Try
            OpenFileDialogProducts.Title = "Cargar Productos"
            OpenFileDialogProducts.Filter = "Archivo XML|*.xml"
            If OpenFileDialogProducts.ShowDialog() = Windows.Forms.DialogResult.OK Then
                GENERALS.listOfProducts.Clear()
                Dim urlFile = OpenFileDialogProducts.FileName
                Dim data As New FileStream(urlFile, FileMode.Open, FileAccess.Read)
                Dim documentXML As New XmlDataDocument()
                documentXML.Load(data)

                Dim xmlNodeList As XmlNodeList = documentXML.GetElementsByTagName("Product")

                For Each node As XmlNode In xmlNodeList
                    Dim tmpObject As New Product
                    tmpObject.Id = node.SelectSingleNode("Id").InnerText
                    tmpObject.Name = node.SelectSingleNode("Name").InnerText
                    tmpObject.Description = node.SelectSingleNode("Description").InnerText
                    tmpObject.Price = Double.Parse(node.SelectSingleNode("Price").InnerText)
                    GENERALS.listOfProducts.Add(tmpObject)
                Next

            End If
            loadProducts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteList_Click(sender As Object, e As EventArgs) Handles btnDeleteList.Click
        Try
            Dim response = MessageBox.Show("Borrar lista?", "Advetencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If response = Windows.Forms.DialogResult.Yes Then
                GENERALS.listOfProducts.Clear()
                MessageBox.Show("Datos eliminados", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgvProducts.Columns.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub listaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProducts()
    End Sub

    Private Sub loadProducts()
        Try
            Dim table As New DataTable()
            table.Columns.Add("Código")
            table.Columns.Add("Nombre")
            table.Columns.Add("Precio")
            table.Columns.Add("Descripción")
            If GENERALS.listOfProducts.Count > 0 Then
                For Each objProduct As Product In GENERALS.listOfProducts
                    table.Rows.Add(objProduct.Id, objProduct.Name, objProduct.Price, objProduct.Description)
                Next
                dgvProducts.Columns.Clear()
                ' add button to the row
                Dim btn As New DataGridViewButtonColumn
                btn.HeaderText = "Seleccionar"
                btn.Text = "Seleccionar"
                btn.Name = "btnSelectProduct"
                btn.UseColumnTextForButtonValue = True
                dgvProducts.Columns.Add(btn)
                ' assign products to the table
                dgvProducts.DataSource = table
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class