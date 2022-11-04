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

    End Sub
End Class
