<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaProductos
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
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.btnDeleteList = New System.Windows.Forms.Button()
        Me.btnImportProducts = New System.Windows.Forms.Button()
        Me.btnExportProducts = New System.Windows.Forms.Button()
        Me.SaveFileDialogProducts = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialogProducts = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDeleteList)
        Me.GroupBox2.Controls.Add(Me.dgvProducts)
        Me.GroupBox2.Controls.Add(Me.btnImportProducts)
        Me.GroupBox2.Controls.Add(Me.btnExportProducts)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 426)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(6, 63)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowTemplate.Height = 25
        Me.dgvProducts.Size = New System.Drawing.Size(524, 357)
        Me.dgvProducts.TabIndex = 0
        '
        'btnDeleteList
        '
        Me.btnDeleteList.Location = New System.Drawing.Point(300, 22)
        Me.btnDeleteList.Name = "btnDeleteList"
        Me.btnDeleteList.Size = New System.Drawing.Size(201, 23)
        Me.btnDeleteList.TabIndex = 2
        Me.btnDeleteList.Text = "Borrar Productos Existentes"
        Me.btnDeleteList.UseVisualStyleBackColor = True
        '
        'btnImportProducts
        '
        Me.btnImportProducts.Location = New System.Drawing.Point(153, 22)
        Me.btnImportProducts.Name = "btnImportProducts"
        Me.btnImportProducts.Size = New System.Drawing.Size(141, 23)
        Me.btnImportProducts.TabIndex = 1
        Me.btnImportProducts.Text = "Importar Productos"
        Me.btnImportProducts.UseVisualStyleBackColor = True
        '
        'btnExportProducts
        '
        Me.btnExportProducts.Location = New System.Drawing.Point(6, 22)
        Me.btnExportProducts.Name = "btnExportProducts"
        Me.btnExportProducts.Size = New System.Drawing.Size(141, 23)
        Me.btnExportProducts.TabIndex = 0
        Me.btnExportProducts.Text = "Exportar Productos"
        Me.btnExportProducts.UseVisualStyleBackColor = True
        '
        'OpenFileDialogProducts
        '
        Me.OpenFileDialogProducts.FileName = "OpenFileDialog1"
        '
        'listaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "listaProductos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnDeleteList As Button
    Friend WithEvents btnImportProducts As Button
    Friend WithEvents btnExportProducts As Button
    Friend WithEvents SaveFileDialogProducts As SaveFileDialog
    Friend WithEvents OpenFileDialogProducts As OpenFileDialog
End Class
