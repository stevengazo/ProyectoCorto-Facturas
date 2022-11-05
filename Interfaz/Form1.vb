Imports Entities
Public Class Form1

    Private Sub RegistrarNuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarNuevoClienteToolStripMenuItem.Click
        Dim RegisterCustomerForm As New RegistrarCliente
        RegisterCustomerForm.ShowDialog()

    End Sub

    Private Sub ProductosRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosRegistradosToolStripMenuItem.Click
        Dim listOfProductsForm As New listaProductos
        listOfProductsForm.ShowDialog()
    End Sub

    Private Sub ListaDeFacturasRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeFacturasRegistradasToolStripMenuItem.Click
        Dim listOfBillsForm As New listaFacturasRegistradas
        listOfBillsForm.ShowDialog()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim RegisterCustomerForm As New RegistrarCliente
        RegisterCustomerForm.ShowDialog()
        loadClients()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListarClientesRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarClientesRegistradosToolStripMenuItem.Click
        Dim listCustomersForm As New listaClientes()
        listCustomersForm.ShowDialog()
    End Sub

    Private Sub RegistrarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarProductoToolStripMenuItem.Click
        Dim registerProductsForm As New RegistrarProducto()
        registerProductsForm.ShowDialog()
        loadProducts()
    End Sub


    Private Sub loadClients()
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

                dgvCustomers.DataSource = table

                ' add button to select
                Dim btn As New DataGridViewButtonColumn
                btn.HeaderText = "Seleccionar"
                btn.Text = "Seleccionar"
                btn.Name = "btnSelectCustomer"
                btn.UseColumnTextForButtonValue = True
                dgvCustomers.Columns.Add(btn)
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick

    End Sub

    Private Sub loadProducts()
        Try
            Dim table As New DataTable()
            table.Columns.Add("Código")
            table.Columns.Add("Nombre")
            table.Columns.Add("Precio")

            If GENERALS.listOfProducts.Count > 0 Then
                For Each objProduct As Product In GENERALS.listOfProducts
                    table.Rows.Add(objProduct.Id, objProduct.Name, objProduct.Price)
                Next
                DGVProductosBuscados.Columns.Clear()

                ' assign products to the table
                DGVProductosBuscados.DataSource = table

                ' add button to the row
                Dim btn As New DataGridViewButtonColumn
                btn.HeaderText = "Agregar"
                btn.Text = "Agregar"
                btn.Name = "btnAddProduct"
                btn.UseColumnTextForButtonValue = True
                DGVProductosBuscados.Columns.Add(btn)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
