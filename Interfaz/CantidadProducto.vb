Imports Entities
Imports System.Linq
Imports Interfaz.GENERALS
Imports System.Runtime.CompilerServices

Public Class CantidadProducto
    Public idProduct As String

    Private objProduct As Product

    Private Sub CantidadProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInfo()
    End Sub

    Private Sub loadInfo()
        Try
            If Not String.IsNullOrEmpty(idProduct) Then
                Dim tmpObject As Product = (From tmp In GENERALS.listOfProducts
                                            Where tmp.Id = idProduct
                                            Select tmp).FirstOrDefault()
                txtCod.Text = tmpObject.Id
                txtName.Text = tmpObject.Name
                objProduct = tmpObject
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If NQuantity.Value > 0 Then
                Dim _Product As New ProductSelected()
                _Product.Id = objProduct.Id
                _Product.Name = objProduct.Name
                _Product.Description = objProduct.Description
                _Product.Quantity = NQuantity.Value
                _Product.Price = objProduct.Price

                Dim productQuery = (From product In InvoiceTemporal.listOfProducts
                                    Where product.Id.Contains(_Product.Id)
                                    Select product).ToList()
                If productQuery.Count > 0 Then
                    For Each prod In productQuery
                        prod.Quantity = prod.Quantity + _Product.Quantity
                        InvoiceTemporal.listOfProducts.Remove(prod)
                        InvoiceTemporal.listOfProducts.Add(prod)
                    Next
                Else
                    InvoiceTemporal.listOfProducts.Add(_Product)
                End If
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class