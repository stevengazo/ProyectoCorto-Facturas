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
        Me.dgvInvoices = New System.Windows.Forms.DataGridView()
        Me.btnImportInvoices = New System.Windows.Forms.Button()
        Me.btnExportInvoices = New System.Windows.Forms.Button()
        Me.OpenFileDialogInvoice = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialogInvoice = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExportInvoices)
        Me.GroupBox1.Controls.Add(Me.dgvInvoices)
        Me.GroupBox1.Controls.Add(Me.btnImportInvoices)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 360)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas Registradas"
        '
        'dgvInvoices
        '
        Me.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoices.Location = New System.Drawing.Point(6, 51)
        Me.dgvInvoices.Name = "dgvInvoices"
        Me.dgvInvoices.RowTemplate.Height = 25
        Me.dgvInvoices.Size = New System.Drawing.Size(486, 303)
        Me.dgvInvoices.TabIndex = 35
        '
        'btnImportInvoices
        '
        Me.btnImportInvoices.Location = New System.Drawing.Point(6, 22)
        Me.btnImportInvoices.Name = "btnImportInvoices"
        Me.btnImportInvoices.Size = New System.Drawing.Size(115, 23)
        Me.btnImportInvoices.TabIndex = 2
        Me.btnImportInvoices.Text = "Importar Facturas"
        Me.btnImportInvoices.UseVisualStyleBackColor = True
        '
        'btnExportInvoices
        '
        Me.btnExportInvoices.Location = New System.Drawing.Point(127, 22)
        Me.btnExportInvoices.Name = "btnExportInvoices"
        Me.btnExportInvoices.Size = New System.Drawing.Size(114, 23)
        Me.btnExportInvoices.TabIndex = 1
        Me.btnExportInvoices.Text = "Exportar Facturas"
        Me.btnExportInvoices.UseVisualStyleBackColor = True
        '
        'OpenFileDialogInvoice
        '
        Me.OpenFileDialogInvoice.FileName = "OpenFileDialog1"
        '
        'listaFacturasRegistradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 384)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "listaFacturasRegistradas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas Registradas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnImportInvoices As Button
    Friend WithEvents btnExportInvoices As Button
    Friend WithEvents dgvInvoices As DataGridView
    Friend WithEvents OpenFileDialogInvoice As OpenFileDialog
    Friend WithEvents SaveFileDialogInvoice As SaveFileDialog
End Class
