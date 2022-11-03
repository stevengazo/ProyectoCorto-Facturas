Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub RegistrarNuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarNuevoClienteToolStripMenuItem.Click
        Dim RegisterCustomerForm As New RegistrarCliente
        RegisterCustomerForm.Show()

    End Sub

    Private Sub btnRegisterCustomer_Click(sender As Object, e As EventArgs) Handles btnRegisterCustomer.Click
        Dim RegisterCustomerForm As New RegistrarCliente
        RegisterCustomerForm.Show()
    End Sub

    Private Sub ProductosRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosRegistradosToolStripMenuItem.Click
        Dim listOfProductsForm As New listaProductos
        listOfProductsForm.Show()
    End Sub

    Private Sub ListaDeFacturasRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeFacturasRegistradasToolStripMenuItem.Click
        Dim listOfBillsForm As New listaFacturasRegistradas
        listOfBillsForm.Show()
    End Sub
End Class
