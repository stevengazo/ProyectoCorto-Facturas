﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExportProducts = New System.Windows.Forms.Button()
        Me.btnImportProducts = New System.Windows.Forms.Button()
        Me.btnDeleteList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nvalue = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Nvalue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Nvalue)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(252, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 426)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDeleteList)
        Me.GroupBox3.Controls.Add(Me.btnImportProducts)
        Me.GroupBox3.Controls.Add(Me.btnExportProducts)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 165)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones Generales"
        '
        'btnExportProducts
        '
        Me.btnExportProducts.Location = New System.Drawing.Point(43, 33)
        Me.btnExportProducts.Name = "btnExportProducts"
        Me.btnExportProducts.Size = New System.Drawing.Size(141, 23)
        Me.btnExportProducts.TabIndex = 0
        Me.btnExportProducts.Text = "Exportar Productos"
        Me.btnExportProducts.UseVisualStyleBackColor = True
        '
        'btnImportProducts
        '
        Me.btnImportProducts.Location = New System.Drawing.Point(43, 62)
        Me.btnImportProducts.Name = "btnImportProducts"
        Me.btnImportProducts.Size = New System.Drawing.Size(141, 23)
        Me.btnImportProducts.TabIndex = 1
        Me.btnImportProducts.Text = "Importar Productos"
        Me.btnImportProducts.UseVisualStyleBackColor = True
        '
        'btnDeleteList
        '
        Me.btnDeleteList.Location = New System.Drawing.Point(43, 91)
        Me.btnDeleteList.Name = "btnDeleteList"
        Me.btnDeleteList.Size = New System.Drawing.Size(141, 41)
        Me.btnDeleteList.TabIndex = 2
        Me.btnDeleteList.Text = "Borrar Productos Existentes"
        Me.btnDeleteList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Producto"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(128, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 23)
        Me.txtId.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(128, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 23)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(128, 77)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 23)
        Me.txtDescription.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Código Producto"
        '
        'Nvalue
        '
        Me.Nvalue.Location = New System.Drawing.Point(128, 109)
        Me.Nvalue.Name = "Nvalue"
        Me.Nvalue.Size = New System.Drawing.Size(100, 23)
        Me.Nvalue.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Buscar Producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(43, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Actualizar Producto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(43, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Borrar Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(43, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Limpiar Valores"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(524, 357)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Código"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(251, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nombre"
        '
        'listaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "listaProductos"
        Me.ShowIcon = False
        Me.Text = "Lista de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Nvalue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Nvalue As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDeleteList As Button
    Friend WithEvents btnImportProducts As Button
    Friend WithEvents btnExportProducts As Button
End Class
