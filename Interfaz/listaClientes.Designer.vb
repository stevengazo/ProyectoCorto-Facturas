<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaClientes
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
        Me.txtNombreSeleCliente = New System.Windows.Forms.TextBox()
        Me.txtIdentiSeleCliente = New System.Windows.Forms.TextBox()
        Me.txtIdentificacionSeleCliente = New System.Windows.Forms.TextBox()
        Me.txtApellidoSeleCliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombreSeleCliente)
        Me.GroupBox1.Controls.Add(Me.txtIdentiSeleCliente)
        Me.GroupBox1.Controls.Add(Me.txtIdentificacionSeleCliente)
        Me.GroupBox1.Controls.Add(Me.txtApellidoSeleCliente)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contacto"
        '
        'txtNombreSeleCliente
        '
        Me.txtNombreSeleCliente.Location = New System.Drawing.Point(163, 39)
        Me.txtNombreSeleCliente.Name = "txtNombreSeleCliente"
        Me.txtNombreSeleCliente.ReadOnly = True
        Me.txtNombreSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtNombreSeleCliente.TabIndex = 36
        '
        'txtIdentiSeleCliente
        '
        Me.txtIdentiSeleCliente.Location = New System.Drawing.Point(163, 124)
        Me.txtIdentiSeleCliente.Name = "txtIdentiSeleCliente"
        Me.txtIdentiSeleCliente.ReadOnly = True
        Me.txtIdentiSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtIdentiSeleCliente.TabIndex = 35
        '
        'txtIdentificacionSeleCliente
        '
        Me.txtIdentificacionSeleCliente.Location = New System.Drawing.Point(163, 95)
        Me.txtIdentificacionSeleCliente.Name = "txtIdentificacionSeleCliente"
        Me.txtIdentificacionSeleCliente.ReadOnly = True
        Me.txtIdentificacionSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtIdentificacionSeleCliente.TabIndex = 34
        '
        'txtApellidoSeleCliente
        '
        Me.txtApellidoSeleCliente.Location = New System.Drawing.Point(163, 66)
        Me.txtApellidoSeleCliente.Name = "txtApellidoSeleCliente"
        Me.txtApellidoSeleCliente.ReadOnly = True
        Me.txtApellidoSeleCliente.Size = New System.Drawing.Size(171, 23)
        Me.txtApellidoSeleCliente.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Identificacion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Tipo Identificacion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Apellidos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 15)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgvCustomers)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 305)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clientes Registrados"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(246, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identificacion"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Location = New System.Drawing.Point(6, 51)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowTemplate.Height = 25
        Me.dgvCustomers.Size = New System.Drawing.Size(421, 241)
        Me.dgvCustomers.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(212, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 125)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones Generales"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Limpiar Lista"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Exportar Clientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Importar Clientes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(194, 122)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acciones Básicas"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(30, 77)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(127, 23)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Eliminar Cliente"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(30, 48)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Actualizar Cliente"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(30, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 23)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Agregar Cliente"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'listaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 331)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "listaClientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes Registrados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents txtNombreSeleCliente As TextBox
    Friend WithEvents txtIdentiSeleCliente As TextBox
    Friend WithEvents txtIdentificacionSeleCliente As TextBox
    Friend WithEvents txtApellidoSeleCliente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
End Class
