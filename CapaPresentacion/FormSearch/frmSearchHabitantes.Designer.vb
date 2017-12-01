<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchHabitantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchHabitantes))
        Me.DGListaHabitantes = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.DGListaHabitantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGListaHabitantes
        '
        Me.DGListaHabitantes.AllowUserToAddRows = False
        Me.DGListaHabitantes.AllowUserToDeleteRows = False
        Me.DGListaHabitantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGListaHabitantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGListaHabitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListaHabitantes.Location = New System.Drawing.Point(12, 36)
        Me.DGListaHabitantes.MultiSelect = False
        Me.DGListaHabitantes.Name = "DGListaHabitantes"
        Me.DGListaHabitantes.ReadOnly = True
        Me.DGListaHabitantes.Size = New System.Drawing.Size(419, 210)
        Me.DGListaHabitantes.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscar.Location = New System.Drawing.Point(356, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnActualizar.Location = New System.Drawing.Point(274, 6)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(12, 9)
        Me.txtBuscar.MaxLength = 5
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(256, 20)
        Me.txtBuscar.TabIndex = 4
        '
        'frmSearchHabitantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 261)
        Me.Controls.Add(Me.DGListaHabitantes)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSearchHabitantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Habitantes"
        CType(Me.DGListaHabitantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGListaHabitantes As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtBuscar As TextBox
End Class
