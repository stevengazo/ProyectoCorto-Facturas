Imports System.ComponentModel.Design
Imports Entities
Imports System.Linq
Imports Interfaz.GENERALS
Imports System.Runtime.CompilerServices

Public Class Form1

    Private Sub RegistrarNuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarNuevoClienteToolStripMenuItem.Click
        Dim RegisterCustomerForm As New RegistrarCliente
        RegisterCustomerForm.ShowDialog()

    End Sub

    Private Sub ProductosRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosRegistradosToolStripMenuItem.Click
        Dim listOfProductsForm As New listaProductos
        listOfProductsForm.ShowDialog()
        loadProducts()
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
        loadClients()
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

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim customerId As String = dgvCustomers.Item(1, e.RowIndex).Value
            If Not String.IsNullOrEmpty(customerId) Then
                Dim custTMP As Customer = (From cust In GENERALS.listOfCustomers
                                           Where cust.id = customerId
                                           Select cust).FirstOrDefault()
                GENERALS.InvoiceTemporal.customer = custTMP
                GENERALS.InvoiceTemporal.idInvoice = Guid.NewGuid().ToString()
                GENERALS.InvoiceTemporal.dateInvoice = DateTime.Now
                txtIdentiSeleCliente.Text = custTMP.id
                txtNombreSeleCliente.Text = custTMP.Name
                txtApellidoSeleCliente.Text = custTMP.LastName
                txtIdentificacionSeleCliente.Text = custTMP.typeId
                txtCodInvoice.Text = GENERALS.InvoiceTemporal.idInvoice
                txtDate.Text = GENERALS.InvoiceTemporal.dateInvoice.ToShortDateString()

            End If
        End If
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
                ' add button to the row
                Dim btn As New DataGridViewButtonColumn
                btn.HeaderText = "Agregar"
                btn.Text = "Agregar"
                btn.Name = "btnAddProduct"
                btn.UseColumnTextForButtonValue = True
                DGVProductosBuscados.Columns.Add(btn)
                ' assign products to the table
                DGVProductosBuscados.DataSource = table
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DGVProductosBuscados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProductosBuscados.CellContentClick
        Try
            If e.ColumnIndex = 0 Then
                'declare the form
                Dim QuantityProductForm As New CantidadProducto()
                'id of the product
                QuantityProductForm.idProduct = DGVProductosBuscados.Item(1, e.RowIndex).Value
                QuantityProductForm.ShowDialog()
                loadInvoiceProducts()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub loadInvoiceProducts()
        Try
            Dim table As New DataTable()
            table.Columns.Add("Código")
            table.Columns.Add("Nombre")
            table.Columns.Add("Precio")
            table.Columns.Add("Cantidad")
            table.Columns.Add("Total")
            If InvoiceTemporal.listOfProducts.Count > 0 Then
                Dim subtotal As Double = 0
                For Each objProduct As ProductSelected In InvoiceTemporal.listOfProducts
                    subtotal = (objProduct.Quantity * objProduct.Price) + subtotal
                    table.Rows.Add(objProduct.Id, objProduct.Name, objProduct.Price, objProduct.Quantity, (objProduct.Quantity * objProduct.Price))
                Next
                DGVProductosSelecionados.Columns.Clear()
                ' add button to the row
                Dim btn As New DataGridViewButtonColumn
                btn.HeaderText = "Quitar"
                btn.Text = "Quitar"
                btn.Name = "btnDeleteProduct"
                btn.UseColumnTextForButtonValue = True
                DGVProductosSelecionados.Columns.Add(btn)
                ' assign products to the table
                DGVProductosSelecionados.DataSource = table
                txtSubTotal.Text = subtotal.ToString()
                txtIVA.Text = (subtotal * 0.13)
                txtTotal.Text = (subtotal + (subtotal * 0.13)).ToString()

                ' change the data in the invoice
                InvoiceTemporal.subtotal = subtotal
                InvoiceTemporal.totalPrice = (subtotal + (subtotal * 0.13))
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardarFactura_Click(sender As Object, e As EventArgs) Handles btnGuardarFactura.Click
        Try
            If InvoiceTemporal.customer IsNot Nothing Then
                If Not InvoiceTemporal.listOfProducts.Count = 0 Then
                    Dim consult As invoice = (From inv In listOfInvoices
                                              Where inv.idInvoice = InvoiceTemporal.idInvoice
                                              Select inv).FirstOrDefault
                    If consult Is Nothing Then
                        listOfInvoices.Add(InvoiceTemporal)
                        MessageBox.Show("Factura Registrada Exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        InvoiceTemporal = New invoice()
                        cleanInputs()
                    Else
                        MessageBox.Show("Factura ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else
                    MessageBox.Show("No hay productos asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No hay un cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cleanInputs()
        txtCodInvoice.Text = String.Empty
        txtDate.Text = String.Empty
        txtNombreSeleCliente.Text = String.Empty
        txtApellidoSeleCliente.Text = String.Empty
        txtIdentiSeleCliente.Text = String.Empty
        txtIdentificacionSeleCliente.Text = String.Empty
        DGVProductosSelecionados.Columns.Clear()
        txtSubTotal.Text = String.Empty
        txtIVA.Text = String.Empty
        txtTotal.Text = String.Empty

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cleanInputs()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Try
            Dim idCustomer As String = txtIdBusCliente.Text
            If Not String.IsNullOrEmpty(idCustomer) Then
                dgvCustomers.Columns.Clear()
                Dim QueryOfCustomers = (From cust In listOfCustomers
                                        Where cust.id.Contains(idCustomer)
                                        Select cust).ToList()
                Dim table As New DataTable
                table.Columns.Add("Identificación")
                table.Columns.Add("Apellidos")
                table.Columns.Add("Nombre")
                If QueryOfCustomers.Count > 0 Then
                    For Each objCustomer As Customer In QueryOfCustomers
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
                    MessageBox.Show("No hay coincidencias ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                loadClients()
                MessageBox.Show("No hay información para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Try
            Dim idProduct As String = txtBusCodProducto.Text
            If Not String.IsNullOrEmpty(idProduct) Then
                DGVProductosBuscados.Columns.Clear()
                Dim queryConsult = (From prod In listOfProducts
                                    Where prod.Id.Contains(idProduct)
                                    Select prod).ToList()
                Dim table As New DataTable()
                table.Columns.Add("Código")
                table.Columns.Add("Nombre")
                table.Columns.Add("Precio")
                If queryConsult.Count > 0 Then
                    For Each objProduct As Product In queryConsult
                        table.Rows.Add(objProduct.Id, objProduct.Name, objProduct.Price)
                    Next
                    DGVProductosBuscados.Columns.Clear()
                    ' add button to the row
                    Dim btn As New DataGridViewButtonColumn
                    btn.HeaderText = "Agregar"
                    btn.Text = "Agregar"
                    btn.Name = "btnAddProduct"
                    btn.UseColumnTextForButtonValue = True
                    DGVProductosBuscados.Columns.Add(btn)
                    ' assign products to the table
                    DGVProductosBuscados.DataSource = table
                Else
                    loadProducts()
                    MessageBox.Show("No hay coincidencias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                loadProducts()
                MessageBox.Show("No hay información para buscar ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class
