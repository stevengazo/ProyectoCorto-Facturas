Imports Entities
Imports System.Linq

Public Class RegistrarCliente
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Try
            Dim typeIdentification As String = cbListIdentificactions.Text
            Dim identification As String = txtIdentification.Text
            Dim name As String = txtName.Text
            Dim lastName As String = txtLastName.Text

            If Not String.IsNullOrEmpty(typeIdentification) Then
                If Not String.IsNullOrEmpty(identification) Then
                    If Not String.IsNullOrEmpty(name) Then
                        If Not String.IsNullOrEmpty(lastName) Then
                            Dim customerTMP As New Customer()
                            customerTMP.id = identification
                            customerTMP.Name = name
                            customerTMP.LastName = lastName
                            customerTMP.typeId = typeIdentification
                            addCustomer(customerTMP)
                        Else
                            MessageBox.Show("No ingreso su apellido", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("No ingreso su nombre", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("La identificación se encuentra vacia", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("No Seleccionó una identificación", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Intenta de nuevo. Error interno: " + ex.Message, "Error del Programa", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub addCustomer(customer As Customer)
        Dim customerResults = (From _customer In GENERALS.listOfCustomers
                               Where _customer.id = customer.id
                               Select _customer)
        If customerResults.Count > 0 Then
            MessageBox.Show("La identificación esta registrada", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            GENERALS.listOfCustomers.Add(customer)
            MessageBox.Show("Cliente agregado", "Error del Programa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCleanInputs_Click(sender As Object, e As EventArgs) Handles btnCleanInputs.Click
        Throw New NotImplementedException()
    End Sub
End Class