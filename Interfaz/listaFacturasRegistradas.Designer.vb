<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaFacturasRegistradas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoSeleCliente = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.TextBox()
        Me.btnIVA = New System.Windows.Forms.TextBox()
        Me.btnSubTotal = New System.Windows.Forms.TextBox()
        Me.btnGuardarFactura = New System.Windows.Forms.Button()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVProductosSelecionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(381, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 323)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas Registradas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(395, 295)
        Me.DataGridView1.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(381, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 165)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(26, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(356, 23)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Identificación del Cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 23)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Id de Factura"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(130, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Importar Facturas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(268, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Exportar Facturas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtCodigoSeleCliente)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.btnTotal)
        Me.GroupBox3.Controls.Add(Me.btnIVA)
        Me.GroupBox3.Controls.Add(Me.btnSubTotal)
        Me.GroupBox3.Controls.Add(Me.btnGuardarFactura)
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 494)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Factura"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(163, 43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(171, 23)
        Me.TextBox3.TabIndex = 36
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
        'txtCodigoSeleCliente
        '
        Me.txtCodigoSeleCliente.Location = New System.Drawing.Point(163, 72)
        Me.txtCodigoSeleCliente.Name = "txtCodigoSeleCliente"
        Me.txtCodigoSeleCliente.ReadOnly = True
        Me.txtCodigoSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtCodigoSeleCliente.TabIndex = 34
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
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(163, 429)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.ReadOnly = True
        Me.btnTotal.Size = New System.Drawing.Size(171, 23)
        Me.btnTotal.TabIndex = 31
        '
        'btnIVA
        '
        Me.btnIVA.Location = New System.Drawing.Point(163, 400)
        Me.btnIVA.Name = "btnIVA"
        Me.btnIVA.ReadOnly = True
        Me.btnIVA.Size = New System.Drawing.Size(171, 23)
        Me.btnIVA.TabIndex = 30
        '
        'btnSubTotal
        '
        Me.btnSubTotal.Location = New System.Drawing.Point(163, 371)
        Me.btnSubTotal.Name = "btnSubTotal"
        Me.btnSubTotal.ReadOnly = True
        Me.btnSubTotal.Size = New System.Drawing.Size(171, 23)
        Me.btnSubTotal.TabIndex = 29
        '
        'btnGuardarFactura
        '
        Me.btnGuardarFactura.Location = New System.Drawing.Point(119, 465)
        Me.btnGuardarFactura.Name = "btnGuardarFactura"
        Me.btnGuardarFactura.Size = New System.Drawing.Size(87, 23)
        Me.btnGuardarFactura.TabIndex = 25
        Me.btnGuardarFactura.Text = "Generar"
        Me.btnGuardarFactura.UseVisualStyleBackColor = True
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
        'listaFacturasRegistradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 518)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "listaFacturasRegistradas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Facturas Registradas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVProductosSelecionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoSeleCliente As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnTotal As TextBox
    Friend WithEvents btnIVA As TextBox
    Friend WithEvents btnSubTotal As TextBox
    Friend WithEvents btnGuardarFactura As Button
    Friend WithEvents txtNombreSeleCliente As TextBox
    Friend WithEvents txtIdentiSeleCliente As TextBox
    Friend WithEvents txtIdentificacionSeleCliente As TextBox
    Friend WithEvents txtApellidoSeleCliente As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DGVProductosSelecionados As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
