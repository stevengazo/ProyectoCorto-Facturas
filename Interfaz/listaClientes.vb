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
End Class