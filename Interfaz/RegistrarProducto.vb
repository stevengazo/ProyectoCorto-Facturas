Imports Entities
Imports System.Linq
Imports System.Threading.Tasks.Dataflow

Public Class RegistrarProducto
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Throw New NotImplementedException()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try
            If Not String.IsNullOrEmpty(txtId.Text) Then
                If Not String.IsNullOrEmpty(txtName.Text) Then
                    If Not String.IsNullOrEmpty(txtDescription.Text) Then
                        If Not Nvalue.Value <= 0 Then
                            Dim productTmp As New Product()
                            productTmp.Id = txtId.Text
                            productTmp.Name = txtName.Text
                            productTmp.Description = txtDescription.Text
                            productTmp.Price = Nvalue.Value

                            addProduct(productTmp)
                        Else
                            MessageBox.Show("Verifica el precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Verifica la descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Verifica el Nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Verifica el código de producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error interno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub addProduct(product As Product)
        Try
            Dim productsResults = (From _product In GENERALS.listOfProducts
                                   Where _product.Id = product.Id
                                   Select _product)
            If productsResults.Count > 0 Then
                MessageBox.Show("Producto existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                GENERALS.listOfProducts.Add(product)
                MessageBox.Show("Producto añadido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error interno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class