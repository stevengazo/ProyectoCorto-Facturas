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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnExportCustomers = New System.Windows.Forms.Button()
        Me.btnImportCustomers = New System.Windows.Forms.Button()
        Me.SaveFileDialogCustomers = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialogCustomers = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.dgvCustomers)
        Me.GroupBox2.Controls.Add(Me.btnExportCustomers)
        Me.GroupBox2.Controls.Add(Me.btnImportCustomers)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 384)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clientes Registrados"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Location = New System.Drawing.Point(6, 51)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowTemplate.Height = 25
        Me.dgvCustomers.Size = New System.Drawing.Size(506, 327)
        Me.dgvCustomers.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(272, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Limpiar Lista"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnExportCustomers
        '
        Me.btnExportCustomers.Location = New System.Drawing.Point(139, 22)
        Me.btnExportCustomers.Name = "btnExportCustomers"
        Me.btnExportCustomers.Size = New System.Drawing.Size(127, 23)
        Me.btnExportCustomers.TabIndex = 1
        Me.btnExportCustomers.Text = "Exportar Clientes"
        Me.btnExportCustomers.UseVisualStyleBackColor = True
        '
        'btnImportCustomers
        '
        Me.btnImportCustomers.Location = New System.Drawing.Point(6, 22)
        Me.btnImportCustomers.Name = "btnImportCustomers"
        Me.btnImportCustomers.Size = New System.Drawing.Size(127, 23)
        Me.btnImportCustomers.TabIndex = 0
        Me.btnImportCustomers.Text = "Importar Clientes"
        Me.btnImportCustomers.UseVisualStyleBackColor = True
        '
        'OpenFileDialogCustomers
        '
        Me.OpenFileDialogCustomers.FileName = "OpenFileDialog1"
        '
        'listaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 410)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "listaClientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes Registrados"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents btnExportCustomers As Button
    Friend WithEvents btnImportCustomers As Button
    Friend WithEvents SaveFileDialogCustomers As SaveFileDialog
    Friend WithEvents OpenFileDialogCustomers As OpenFileDialog
End Class
