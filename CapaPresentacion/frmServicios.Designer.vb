<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicios))
        Me.TabServicios = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtNroServicio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNroLote = New System.Windows.Forms.Button()
        Me.CBEmpresas = New System.Windows.Forms.ComboBox()
        Me.CBNombres = New System.Windows.Forms.ComboBox()
        Me.DTFechaContratacion = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNroLote = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.DGListaServicios = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.TabServicios.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGListaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabServicios
        '
        Me.TabServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabServicios.Controls.Add(Me.TabPage1)
        Me.TabServicios.Controls.Add(Me.TabPage2)
        Me.TabServicios.Location = New System.Drawing.Point(12, 12)
        Me.TabServicios.Name = "TabServicios"
        Me.TabServicios.SelectedIndex = 0
        Me.TabServicios.Size = New System.Drawing.Size(424, 288)
        Me.TabServicios.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtNroServicio)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.btnNroLote)
        Me.TabPage1.Controls.Add(Me.CBEmpresas)
        Me.TabPage1.Controls.Add(Me.CBNombres)
        Me.TabPage1.Controls.Add(Me.DTFechaContratacion)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.btnModificar)
        Me.TabPage1.Controls.Add(Me.btnCrear)
        Me.TabPage1.Controls.Add(Me.txtPrecio)
        Me.TabPage1.Controls.Add(Me.txtNroLote)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(416, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtNroServicio
        '
        Me.txtNroServicio.Location = New System.Drawing.Point(87, 17)
        Me.txtNroServicio.MaxLength = 5
        Me.txtNroServicio.Name = "txtNroServicio"
        Me.txtNroServicio.Size = New System.Drawing.Size(99, 20)
        Me.txtNroServicio.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Nro. Servicio :"
        '
        'btnNroLote
        '
        Me.btnNroLote.Location = New System.Drawing.Point(356, 15)
        Me.btnNroLote.Name = "btnNroLote"
        Me.btnNroLote.Size = New System.Drawing.Size(54, 23)
        Me.btnNroLote.TabIndex = 31
        Me.btnNroLote.Text = "..."
        Me.btnNroLote.UseVisualStyleBackColor = True
        '
        'CBEmpresas
        '
        Me.CBEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEmpresas.FormattingEnabled = True
        Me.CBEmpresas.Items.AddRange(New Object() {"DirecTV", "Arnet", "Telefonica", "Basurero Municipal", "Basurero Privado", "CCC", "Super Canal", "EDET", "SAT", "GASNOR"})
        Me.CBEmpresas.Location = New System.Drawing.Point(87, 69)
        Me.CBEmpresas.Name = "CBEmpresas"
        Me.CBEmpresas.Size = New System.Drawing.Size(323, 21)
        Me.CBEmpresas.TabIndex = 26
        '
        'CBNombres
        '
        Me.CBNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNombres.FormattingEnabled = True
        Me.CBNombres.Items.AddRange(New Object() {"Basura", "Agua", "Television", "Internet", "Telefono", "Electricidad"})
        Me.CBNombres.Location = New System.Drawing.Point(87, 43)
        Me.CBNombres.Name = "CBNombres"
        Me.CBNombres.Size = New System.Drawing.Size(323, 21)
        Me.CBNombres.TabIndex = 25
        '
        'DTFechaContratacion
        '
        Me.DTFechaContratacion.Location = New System.Drawing.Point(87, 100)
        Me.DTFechaContratacion.Name = "DTFechaContratacion"
        Me.DTFechaContratacion.Size = New System.Drawing.Size(323, 20)
        Me.DTFechaContratacion.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha :"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(335, 174)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 22
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(226, 174)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(111, 174)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(10, 174)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 19
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(87, 133)
        Me.txtPrecio.MaxLength = 10
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(323, 20)
        Me.txtPrecio.TabIndex = 12
        '
        'txtNroLote
        '
        Me.txtNroLote.Location = New System.Drawing.Point(295, 18)
        Me.txtNroLote.MaxLength = 5
        Me.txtNroLote.Name = "txtNroLote"
        Me.txtNroLote.Size = New System.Drawing.Size(55, 20)
        Me.txtNroLote.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Empresa :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Persona :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Controls.Add(Me.DGListaServicios)
        Me.TabPage2.Controls.Add(Me.btnBuscar)
        Me.TabPage2.Controls.Add(Me.txtBuscar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(416, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnActualizar.Location = New System.Drawing.Point(254, 10)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'DGListaServicios
        '
        Me.DGListaServicios.AllowUserToAddRows = False
        Me.DGListaServicios.AllowUserToDeleteRows = False
        Me.DGListaServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGListaServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGListaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListaServicios.Location = New System.Drawing.Point(6, 39)
        Me.DGListaServicios.MultiSelect = False
        Me.DGListaServicios.Name = "DGListaServicios"
        Me.DGListaServicios.ReadOnly = True
        Me.DGListaServicios.Size = New System.Drawing.Size(404, 213)
        Me.DGListaServicios.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscar.Location = New System.Drawing.Point(335, 10)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(6, 10)
        Me.txtBuscar.MaxLength = 5
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(242, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 312)
        Me.Controls.Add(Me.TabServicios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios"
        Me.TabServicios.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGListaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabServicios As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CBEmpresas As ComboBox
    Friend WithEvents CBNombres As ComboBox
    Friend WithEvents DTFechaContratacion As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNroLote As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGListaServicios As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnNroLote As Button
    Friend WithEvents txtNroServicio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnActualizar As Button
End Class
