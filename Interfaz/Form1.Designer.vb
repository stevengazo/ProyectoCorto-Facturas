<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeFacturasRegistradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarNuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarClientesRegistradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosRegistradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtBusCodProducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVProductosBuscados = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCodInvoice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.btnGuardarFactura = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtNombreSeleCliente = New System.Windows.Forms.TextBox()
        Me.txtIdentiSeleCliente = New System.Windows.Forms.TextBox()
        Me.txtIdentificacionSeleCliente = New System.Windows.Forms.TextBox()
        Me.txtApellidoSeleCliente = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DGVProductosSelecionados = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtIdBusCliente = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVProductosBuscados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVProductosSelecionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(827, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeFacturasRegistradasToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ListaDeFacturasRegistradasToolStripMenuItem
        '
        Me.ListaDeFacturasRegistradasToolStripMenuItem.Name = "ListaDeFacturasRegistradasToolStripMenuItem"
        Me.ListaDeFacturasRegistradasToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ListaDeFacturasRegistradasToolStripMenuItem.Text = "Lista de Facturas Registradas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarNuevoClienteToolStripMenuItem, Me.ListarClientesRegistradosToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'RegistrarNuevoClienteToolStripMenuItem
        '
        Me.RegistrarNuevoClienteToolStripMenuItem.Name = "RegistrarNuevoClienteToolStripMenuItem"
        Me.RegistrarNuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RegistrarNuevoClienteToolStripMenuItem.Text = "Registrar Nuevo Cliente"
        '
        'ListarClientesRegistradosToolStripMenuItem
        '
        Me.ListarClientesRegistradosToolStripMenuItem.Name = "ListarClientesRegistradosToolStripMenuItem"
        Me.ListarClientesRegistradosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ListarClientesRegistradosToolStripMenuItem.Text = "Listar Clientes Registrados"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosRegistradosToolStripMenuItem, Me.RegistrarProductoToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProductosRegistradosToolStripMenuItem
        '
        Me.ProductosRegistradosToolStripMenuItem.Name = "ProductosRegistradosToolStripMenuItem"
        Me.ProductosRegistradosToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ProductosRegistradosToolStripMenuItem.Text = "Productos Registrados"
        '
        'RegistrarProductoToolStripMenuItem
        '
        Me.RegistrarProductoToolStripMenuItem.Name = "RegistrarProductoToolStripMenuItem"
        Me.RegistrarProductoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RegistrarProductoToolStripMenuItem.Text = "Registrar Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscarProducto)
        Me.GroupBox2.Controls.Add(Me.txtBusCodProducto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DGVProductosBuscados)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 289)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(341, 22)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarProducto.TabIndex = 19
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'txtBusCodProducto
        '
        Me.txtBusCodProducto.Location = New System.Drawing.Point(72, 23)
        Me.txtBusCodProducto.Name = "txtBusCodProducto"
        Me.txtBusCodProducto.Size = New System.Drawing.Size(263, 23)
        Me.txtBusCodProducto.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Codigo"
        '
        'DGVProductosBuscados
        '
        Me.DGVProductosBuscados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductosBuscados.Location = New System.Drawing.Point(16, 51)
        Me.DGVProductosBuscados.Name = "DGVProductosBuscados"
        Me.DGVProductosBuscados.RowTemplate.Height = 25
        Me.DGVProductosBuscados.Size = New System.Drawing.Size(400, 232)
        Me.DGVProductosBuscados.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCodInvoice)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtDate)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.txtIVA)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.btnGuardarFactura)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.txtNombreSeleCliente)
        Me.GroupBox3.Controls.Add(Me.txtIdentiSeleCliente)
        Me.GroupBox3.Controls.Add(Me.txtIdentificacionSeleCliente)
        Me.GroupBox3.Controls.Add(Me.txtApellidoSeleCliente)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.DGVProductosSelecionados)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(452, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 494)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Factura"
        '
        'txtCodInvoice
        '
        Me.txtCodInvoice.Location = New System.Drawing.Point(163, 43)
        Me.txtCodInvoice.Name = "txtCodInvoice"
        Me.txtCodInvoice.ReadOnly = True
        Me.txtCodInvoice.Size = New System.Drawing.Size(171, 23)
        Me.txtCodInvoice.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Código"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(163, 72)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(171, 23)
        Me.txtDate.TabIndex = 34
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 15)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Fecha"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(133, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 21)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Nombre"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(163, 429)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(171, 23)
        Me.txtTotal.TabIndex = 31
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(163, 400)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(171, 23)
        Me.txtIVA.TabIndex = 30
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(163, 371)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(171, 23)
        Me.txtSubTotal.TabIndex = 29
        '
        'btnGuardarFactura
        '
        Me.btnGuardarFactura.Location = New System.Drawing.Point(6, 468)
        Me.btnGuardarFactura.Name = "btnGuardarFactura"
        Me.btnGuardarFactura.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarFactura.TabIndex = 25
        Me.btnGuardarFactura.Text = "Generar"
        Me.btnGuardarFactura.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(82, 468)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 26
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtNombreSeleCliente
        '
        Me.txtNombreSeleCliente.Location = New System.Drawing.Point(163, 101)
        Me.txtNombreSeleCliente.Name = "txtNombreSeleCliente"
        Me.txtNombreSeleCliente.ReadOnly = True
        Me.txtNombreSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtNombreSeleCliente.TabIndex = 28
        '
        'txtIdentiSeleCliente
        '
        Me.txtIdentiSeleCliente.Location = New System.Drawing.Point(163, 186)
        Me.txtIdentiSeleCliente.Name = "txtIdentiSeleCliente"
        Me.txtIdentiSeleCliente.ReadOnly = True
        Me.txtIdentiSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtIdentiSeleCliente.TabIndex = 26
        '
        'txtIdentificacionSeleCliente
        '
        Me.txtIdentificacionSeleCliente.Location = New System.Drawing.Point(163, 157)
        Me.txtIdentificacionSeleCliente.Name = "txtIdentificacionSeleCliente"
        Me.txtIdentificacionSeleCliente.ReadOnly = True
        Me.txtIdentificacionSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtIdentificacionSeleCliente.TabIndex = 25
        '
        'txtApellidoSeleCliente
        '
        Me.txtApellidoSeleCliente.Location = New System.Drawing.Point(163, 128)
        Me.txtApellidoSeleCliente.Name = "txtApellidoSeleCliente"
        Me.txtApellidoSeleCliente.ReadOnly = True
        Me.txtApellidoSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtApellidoSeleCliente.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(119, 210)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 21)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Productos"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 432)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 15)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 403)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 15)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "IVA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 15)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Sub Total"
        '
        'DGVProductosSelecionados
        '
        Me.DGVProductosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductosSelecionados.Location = New System.Drawing.Point(20, 234)
        Me.DGVProductosSelecionados.Name = "DGVProductosSelecionados"
        Me.DGVProductosSelecionados.RowTemplate.Height = 25
        Me.DGVProductosSelecionados.Size = New System.Drawing.Size(314, 129)
        Me.DGVProductosSelecionados.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Identificacion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tipo Identificacion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Apellidos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvCustomers)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtIdBusCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 191)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Identificación"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Location = New System.Drawing.Point(16, 46)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowTemplate.Height = 25
        Me.dgvCustomers.Size = New System.Drawing.Size(408, 130)
        Me.dgvCustomers.TabIndex = 20
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(366, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 23)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(300, 16)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(60, 23)
        Me.btnBuscarCliente.TabIndex = 20
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtIdBusCliente
        '
        Me.txtIdBusCliente.Location = New System.Drawing.Point(101, 17)
        Me.txtIdBusCliente.Name = "txtIdBusCliente"
        Me.txtIdBusCliente.Size = New System.Drawing.Size(191, 23)
        Me.txtIdBusCliente.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 533)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVProductosBuscados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVProductosSelecionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeFacturasRegistradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarNuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosRegistradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBusCodProducto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVProductosBuscados As DataGridView
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DGVProductosSelecionados As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnGuardarFactura As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNombreSeleCliente As TextBox
    Friend WithEvents txtIdentiSeleCliente As TextBox
    Friend WithEvents txtIdentificacionSeleCliente As TextBox
    Friend WithEvents txtApellidoSeleCliente As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtIdBusCliente As TextBox
    Friend WithEvents ListarClientesRegistradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtCodInvoice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
