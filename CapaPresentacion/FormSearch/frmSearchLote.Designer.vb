<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchLote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchLote))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DGListaLotePrivados = New System.Windows.Forms.DataGridView()
        CType(Me.DGListaLotePrivados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(13, 13)
        Me.txtBuscar.MaxLength = 5
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(256, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnActualizar.Location = New System.Drawing.Point(275, 10)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscar.Location = New System.Drawing.Point(357, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DGListaLotePrivados
        '
        Me.DGListaLotePrivados.AllowUserToAddRows = False
        Me.DGListaLotePrivados.AllowUserToDeleteRows = False
        Me.DGListaLotePrivados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGListaLotePrivados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGListaLotePrivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListaLotePrivados.Location = New System.Drawing.Point(13, 40)
        Me.DGListaLotePrivados.MultiSelect = False
        Me.DGListaLotePrivados.Name = "DGListaLotePrivados"
        Me.DGListaLotePrivados.ReadOnly = True
        Me.DGListaLotePrivados.Size = New System.Drawing.Size(419, 210)
        Me.DGListaLotePrivados.TabIndex = 3
        '
        'frmSearchLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 262)
        Me.Controls.Add(Me.DGListaLotePrivados)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSearchLote"
        Me.Text = "Buscar Lote"
        CType(Me.DGListaLotePrivados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DGListaLotePrivados As DataGridView
End Class
