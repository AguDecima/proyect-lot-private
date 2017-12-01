<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonas))
        Me.TabPersonas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdPersona = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnNroLote = New System.Windows.Forms.Button()
        Me.txtNroLote = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.DTFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbHabitante = New System.Windows.Forms.CheckBox()
        Me.cbPropietario = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.ListaHabitantes = New System.Windows.Forms.DataGridView()
        Me.btnBuscarHabitantes = New System.Windows.Forms.Button()
        Me.txtBuscarHabitantes = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.ListaPropietarios = New System.Windows.Forms.DataGridView()
        Me.btnBuscarPropietarios = New System.Windows.Forms.Button()
        Me.txtBuscarPropietarios = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.HabitantesLotes = New System.Windows.Forms.DataGridView()
        Me.btnHabitanteForLote = New System.Windows.Forms.Button()
        Me.txtBuscarHabForLote = New System.Windows.Forms.TextBox()
        Me.TabPersonas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ListaHabitantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ListaPropietarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.HabitantesLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPersonas
        '
        Me.TabPersonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPersonas.Controls.Add(Me.TabPage1)
        Me.TabPersonas.Controls.Add(Me.TabPage2)
        Me.TabPersonas.Controls.Add(Me.TabPage3)
        Me.TabPersonas.Controls.Add(Me.TabPage4)
        Me.TabPersonas.Location = New System.Drawing.Point(13, 13)
        Me.TabPersonas.Name = "TabPersonas"
        Me.TabPersonas.SelectedIndex = 0
        Me.TabPersonas.Size = New System.Drawing.Size(376, 298)
        Me.TabPersonas.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtTelefono)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtIdPersona)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.btnModificar)
        Me.TabPage1.Controls.Add(Me.btnCrear)
        Me.TabPage1.Controls.Add(Me.btnNroLote)
        Me.TabPage1.Controls.Add(Me.txtNroLote)
        Me.TabPage1.Controls.Add(Me.txtDni)
        Me.TabPage1.Controls.Add(Me.DTFechaNacimiento)
        Me.TabPage1.Controls.Add(Me.txtApellido)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.cbHabitante)
        Me.TabPage1.Controls.Add(Me.cbPropietario)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(368, 272)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(112, 95)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(250, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Telefono :"
        '
        'txtIdPersona
        '
        Me.txtIdPersona.Location = New System.Drawing.Point(307, 9)
        Me.txtIdPersona.MaxLength = 5
        Me.txtIdPersona.Name = "txtIdPersona"
        Me.txtIdPersona.Size = New System.Drawing.Size(55, 20)
        Me.txtIdPersona.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nro. :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(279, 236)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 14
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(198, 236)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(90, 236)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(9, 236)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 11
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnNroLote
        '
        Me.btnNroLote.Location = New System.Drawing.Point(279, 161)
        Me.btnNroLote.Name = "btnNroLote"
        Me.btnNroLote.Size = New System.Drawing.Size(83, 23)
        Me.btnNroLote.TabIndex = 8
        Me.btnNroLote.Text = "..."
        Me.btnNroLote.UseVisualStyleBackColor = True
        '
        'txtNroLote
        '
        Me.txtNroLote.Location = New System.Drawing.Point(112, 164)
        Me.txtNroLote.MaxLength = 7
        Me.txtNroLote.Name = "txtNroLote"
        Me.txtNroLote.Size = New System.Drawing.Size(161, 20)
        Me.txtNroLote.TabIndex = 11
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(112, 130)
        Me.txtDni.MaxLength = 12
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(250, 20)
        Me.txtDni.TabIndex = 6
        '
        'DTFechaNacimiento
        '
        Me.DTFechaNacimiento.Location = New System.Drawing.Point(112, 63)
        Me.DTFechaNacimiento.MaxDate = New Date(2017, 12, 31, 0, 0, 0, 0)
        Me.DTFechaNacimiento.MinDate = New Date(1917, 1, 1, 0, 0, 0, 0)
        Me.DTFechaNacimiento.Name = "DTFechaNacimiento"
        Me.DTFechaNacimiento.Size = New System.Drawing.Size(250, 20)
        Me.DTFechaNacimiento.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(112, 36)
        Me.txtApellido.MaxLength = 45
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(250, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(112, 6)
        Me.txtNombre.MaxLength = 45
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(161, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cbHabitante
        '
        Me.cbHabitante.AutoSize = True
        Me.cbHabitante.Location = New System.Drawing.Point(201, 202)
        Me.cbHabitante.Name = "cbHabitante"
        Me.cbHabitante.Size = New System.Drawing.Size(72, 17)
        Me.cbHabitante.TabIndex = 10
        Me.cbHabitante.Text = "Habitante"
        Me.cbHabitante.UseVisualStyleBackColor = True
        '
        'cbPropietario
        '
        Me.cbPropietario.AutoSize = True
        Me.cbPropietario.Location = New System.Drawing.Point(112, 202)
        Me.cbPropietario.Name = "cbPropietario"
        Me.cbPropietario.Size = New System.Drawing.Size(76, 17)
        Me.cbPropietario.TabIndex = 9
        Me.cbPropietario.Text = "Propietario"
        Me.cbPropietario.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nro. Lote :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Nacimiento :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Controls.Add(Me.ListaHabitantes)
        Me.TabPage2.Controls.Add(Me.btnBuscarHabitantes)
        Me.TabPage2.Controls.Add(Me.txtBuscarHabitantes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(368, 272)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista Habitantes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnActualizar.Location = New System.Drawing.Point(204, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'ListaHabitantes
        '
        Me.ListaHabitantes.AllowUserToAddRows = False
        Me.ListaHabitantes.AllowUserToDeleteRows = False
        Me.ListaHabitantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaHabitantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListaHabitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaHabitantes.Location = New System.Drawing.Point(7, 33)
        Me.ListaHabitantes.MultiSelect = False
        Me.ListaHabitantes.Name = "ListaHabitantes"
        Me.ListaHabitantes.ReadOnly = True
        Me.ListaHabitantes.Size = New System.Drawing.Size(353, 233)
        Me.ListaHabitantes.TabIndex = 14
        '
        'btnBuscarHabitantes
        '
        Me.btnBuscarHabitantes.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscarHabitantes.Location = New System.Drawing.Point(285, 4)
        Me.btnBuscarHabitantes.Name = "btnBuscarHabitantes"
        Me.btnBuscarHabitantes.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarHabitantes.TabIndex = 13
        Me.btnBuscarHabitantes.Text = "Buscar"
        Me.btnBuscarHabitantes.UseVisualStyleBackColor = True
        '
        'txtBuscarHabitantes
        '
        Me.txtBuscarHabitantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarHabitantes.Location = New System.Drawing.Point(7, 7)
        Me.txtBuscarHabitantes.MaxLength = 5
        Me.txtBuscarHabitantes.Name = "txtBuscarHabitantes"
        Me.txtBuscarHabitantes.Size = New System.Drawing.Size(191, 20)
        Me.txtBuscarHabitantes.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnMostrar)
        Me.TabPage3.Controls.Add(Me.ListaPropietarios)
        Me.TabPage3.Controls.Add(Me.btnBuscarPropietarios)
        Me.TabPage3.Controls.Add(Me.txtBuscarPropietarios)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(368, 272)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Lista Propietarios"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMostrar.Location = New System.Drawing.Point(200, 9)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 17
        Me.btnMostrar.Text = "Actualizar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'ListaPropietarios
        '
        Me.ListaPropietarios.AllowUserToAddRows = False
        Me.ListaPropietarios.AllowUserToDeleteRows = False
        Me.ListaPropietarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPropietarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListaPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaPropietarios.Location = New System.Drawing.Point(4, 39)
        Me.ListaPropietarios.MultiSelect = False
        Me.ListaPropietarios.Name = "ListaPropietarios"
        Me.ListaPropietarios.ReadOnly = True
        Me.ListaPropietarios.Size = New System.Drawing.Size(352, 230)
        Me.ListaPropietarios.TabIndex = 16
        '
        'btnBuscarPropietarios
        '
        Me.btnBuscarPropietarios.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscarPropietarios.Location = New System.Drawing.Point(281, 10)
        Me.btnBuscarPropietarios.Name = "btnBuscarPropietarios"
        Me.btnBuscarPropietarios.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarPropietarios.TabIndex = 15
        Me.btnBuscarPropietarios.Text = "Buscar"
        Me.btnBuscarPropietarios.UseVisualStyleBackColor = True
        '
        'txtBuscarPropietarios
        '
        Me.txtBuscarPropietarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarPropietarios.Location = New System.Drawing.Point(4, 11)
        Me.txtBuscarPropietarios.MaxLength = 5
        Me.txtBuscarPropietarios.Name = "txtBuscarPropietarios"
        Me.txtBuscarPropietarios.Size = New System.Drawing.Size(191, 20)
        Me.txtBuscarPropietarios.TabIndex = 14
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.HabitantesLotes)
        Me.TabPage4.Controls.Add(Me.btnHabitanteForLote)
        Me.TabPage4.Controls.Add(Me.txtBuscarHabForLote)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(368, 272)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Habitantes Por Lotes"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'HabitantesLotes
        '
        Me.HabitantesLotes.AllowUserToAddRows = False
        Me.HabitantesLotes.AllowUserToDeleteRows = False
        Me.HabitantesLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HabitantesLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HabitantesLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HabitantesLotes.Location = New System.Drawing.Point(9, 36)
        Me.HabitantesLotes.MultiSelect = False
        Me.HabitantesLotes.Name = "HabitantesLotes"
        Me.HabitantesLotes.ReadOnly = True
        Me.HabitantesLotes.Size = New System.Drawing.Size(352, 230)
        Me.HabitantesLotes.TabIndex = 19
        '
        'btnHabitanteForLote
        '
        Me.btnHabitanteForLote.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnHabitanteForLote.Location = New System.Drawing.Point(286, 6)
        Me.btnHabitanteForLote.Name = "btnHabitanteForLote"
        Me.btnHabitanteForLote.Size = New System.Drawing.Size(75, 23)
        Me.btnHabitanteForLote.TabIndex = 18
        Me.btnHabitanteForLote.Text = "Buscar"
        Me.btnHabitanteForLote.UseVisualStyleBackColor = True
        '
        'txtBuscarHabForLote
        '
        Me.txtBuscarHabForLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarHabForLote.Location = New System.Drawing.Point(8, 9)
        Me.txtBuscarHabForLote.MaxLength = 5
        Me.txtBuscarHabForLote.Name = "txtBuscarHabForLote"
        Me.txtBuscarHabForLote.Size = New System.Drawing.Size(272, 20)
        Me.txtBuscarHabForLote.TabIndex = 17
        '
        'frmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 326)
        Me.Controls.Add(Me.TabPersonas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPersonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personas"
        Me.TabPersonas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ListaHabitantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ListaPropietarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.HabitantesLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPersonas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtIdPersona As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnNroLote As Button
    Friend WithEvents txtNroLote As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents DTFechaNacimiento As DateTimePicker
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cbHabitante As CheckBox
    Friend WithEvents cbPropietario As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListaHabitantes As DataGridView
    Friend WithEvents btnBuscarHabitantes As Button
    Friend WithEvents txtBuscarHabitantes As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ListaPropietarios As DataGridView
    Friend WithEvents btnBuscarPropietarios As Button
    Friend WithEvents txtBuscarPropietarios As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents HabitantesLotes As DataGridView
    Friend WithEvents btnHabitanteForLote As Button
    Friend WithEvents txtBuscarHabForLote As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnMostrar As Button
End Class
