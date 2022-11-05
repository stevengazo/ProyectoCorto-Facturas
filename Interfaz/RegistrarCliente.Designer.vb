<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdentification = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnCleanInputs = New System.Windows.Forms.Button()
        Me.cbListIdentificactions = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificación"
        '
        'txtIdentification
        '
        Me.txtIdentification.Location = New System.Drawing.Point(127, 43)
        Me.txtIdentification.Name = "txtIdentification"
        Me.txtIdentification.Size = New System.Drawing.Size(133, 23)
        Me.txtIdentification.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo Identificación"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(133, 23)
        Me.txtName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(127, 101)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(133, 23)
        Me.txtLastName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellidos"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(35, 137)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCustomer.TabIndex = 8
        Me.btnAddCustomer.Text = "Registrar"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'btnCleanInputs
        '
        Me.btnCleanInputs.Location = New System.Drawing.Point(142, 137)
        Me.btnCleanInputs.Name = "btnCleanInputs"
        Me.btnCleanInputs.Size = New System.Drawing.Size(75, 23)
        Me.btnCleanInputs.TabIndex = 9
        Me.btnCleanInputs.Text = "Limpiar"
        Me.btnCleanInputs.UseVisualStyleBackColor = True
        '
        'cbListIdentificactions
        '
        Me.cbListIdentificactions.FormattingEnabled = True
        Me.cbListIdentificactions.Items.AddRange(New Object() {"Cédula identidad", "DIMEX", "Internacional"})
        Me.cbListIdentificactions.Location = New System.Drawing.Point(127, 12)
        Me.cbListIdentificactions.Name = "cbListIdentificactions"
        Me.cbListIdentificactions.Size = New System.Drawing.Size(133, 23)
        Me.cbListIdentificactions.TabIndex = 10
        '
        'RegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 172)
        Me.Controls.Add(Me.cbListIdentificactions)
        Me.Controls.Add(Me.btnCleanInputs)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdentification)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrarCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdentification As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnCleanInputs As Button
    Friend WithEvents cbListIdentificactions As ComboBox
End Class
