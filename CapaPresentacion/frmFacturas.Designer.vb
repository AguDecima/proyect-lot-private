<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturas))
        Me.TabFacturas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnFechaServicios = New System.Windows.Forms.Button()
        Me.btnPrinter = New System.Windows.Forms.Button()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnCalcularTotal = New System.Windows.Forms.Button()
        Me.btnCalcularPrecioAlquiler = New System.Windows.Forms.Button()
        Me.DTFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcularExpensas = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnIdPersona = New System.Windows.Forms.Button()
        Me.lblBonificacion = New System.Windows.Forms.Label()
        Me.CBCondicion = New System.Windows.Forms.ComboBox()
        Me.txtTotalFactura = New System.Windows.Forms.TextBox()
        Me.txtPrecioExpensas = New System.Windows.Forms.TextBox()
        Me.txtPrecioAlquiler = New System.Windows.Forms.TextBox()
        Me.txtIdPersona = New System.Windows.Forms.TextBox()
        Me.txtIdFactura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.DGListaFacturas = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TabFacturas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGListaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabFacturas
        '
        Me.TabFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabFacturas.Controls.Add(Me.TabPage1)
        Me.TabFacturas.Controls.Add(Me.TabPage2)
        Me.TabFacturas.Controls.Add(Me.TabPage3)
        Me.TabFacturas.Location = New System.Drawing.Point(13, 13)
        Me.TabFacturas.Name = "TabFacturas"
        Me.TabFacturas.SelectedIndex = 0
        Me.TabFacturas.Size = New System.Drawing.Size(566, 369)
        Me.TabFacturas.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnFechaServicios)
        Me.TabPage1.Controls.Add(Me.btnPrinter)
        Me.TabPage1.Controls.Add(Me.btnVerificar)
        Me.TabPage1.Controls.Add(Me.btnCalcularTotal)
        Me.TabPage1.Controls.Add(Me.btnCalcularPrecioAlquiler)
        Me.TabPage1.Controls.Add(Me.DTFechaVencimiento)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.DTFechaFactura)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnCalcularExpensas)
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.btnModificar)
        Me.TabPage1.Controls.Add(Me.btnCrear)
        Me.TabPage1.Controls.Add(Me.btnIdPersona)
        Me.TabPage1.Controls.Add(Me.lblBonificacion)
        Me.TabPage1.Controls.Add(Me.CBCondicion)
        Me.TabPage1.Controls.Add(Me.txtTotalFactura)
        Me.TabPage1.Controls.Add(Me.txtPrecioExpensas)
        Me.TabPage1.Controls.Add(Me.txtPrecioAlquiler)
        Me.TabPage1.Controls.Add(Me.txtIdPersona)
        Me.TabPage1.Controls.Add(Me.txtIdFactura)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(558, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnFechaServicios
        '
        Me.btnFechaServicios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFechaServicios.Location = New System.Drawing.Point(474, 36)
        Me.btnFechaServicios.Name = "btnFechaServicios"
        Me.btnFechaServicios.Size = New System.Drawing.Size(68, 23)
        Me.btnFechaServicios.TabIndex = 5
        Me.btnFechaServicios.Text = "..."
        Me.btnFechaServicios.UseVisualStyleBackColor = True
        '
        'btnPrinter
        '
        Me.btnPrinter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrinter.Location = New System.Drawing.Point(474, 304)
        Me.btnPrinter.Name = "btnPrinter"
        Me.btnPrinter.Size = New System.Drawing.Size(68, 23)
        Me.btnPrinter.TabIndex = 17
        Me.btnPrinter.Text = "Imprimir"
        Me.btnPrinter.UseVisualStyleBackColor = True
        '
        'btnVerificar
        '
        Me.btnVerificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerificar.Location = New System.Drawing.Point(17, 246)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(65, 42)
        Me.btnVerificar.TabIndex = 12
        Me.btnVerificar.Text = "Verificar Bonificacion"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnCalcularTotal
        '
        Me.btnCalcularTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalcularTotal.Location = New System.Drawing.Point(392, 171)
        Me.btnCalcularTotal.Name = "btnCalcularTotal"
        Me.btnCalcularTotal.Size = New System.Drawing.Size(65, 23)
        Me.btnCalcularTotal.TabIndex = 10
        Me.btnCalcularTotal.Text = "Calcular"
        Me.btnCalcularTotal.UseVisualStyleBackColor = True
        '
        'btnCalcularPrecioAlquiler
        '
        Me.btnCalcularPrecioAlquiler.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalcularPrecioAlquiler.Location = New System.Drawing.Point(392, 106)
        Me.btnCalcularPrecioAlquiler.Name = "btnCalcularPrecioAlquiler"
        Me.btnCalcularPrecioAlquiler.Size = New System.Drawing.Size(65, 23)
        Me.btnCalcularPrecioAlquiler.TabIndex = 8
        Me.btnCalcularPrecioAlquiler.Text = "Calcular"
        Me.btnCalcularPrecioAlquiler.UseVisualStyleBackColor = True
        '
        'DTFechaVencimiento
        '
        Me.DTFechaVencimiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTFechaVencimiento.Enabled = False
        Me.DTFechaVencimiento.Location = New System.Drawing.Point(127, 72)
        Me.DTFechaVencimiento.Name = "DTFechaVencimiento"
        Me.DTFechaVencimiento.Size = New System.Drawing.Size(330, 20)
        Me.DTFechaVencimiento.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Fecha  Vencimiento :"
        '
        'DTFechaFactura
        '
        Me.DTFechaFactura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTFechaFactura.Enabled = False
        Me.DTFechaFactura.Location = New System.Drawing.Point(127, 39)
        Me.DTFechaFactura.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTFechaFactura.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DTFechaFactura.Name = "DTFechaFactura"
        Me.DTFechaFactura.Size = New System.Drawing.Size(334, 20)
        Me.DTFechaFactura.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Fecha  Contratacion :"
        '
        'btnCalcularExpensas
        '
        Me.btnCalcularExpensas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalcularExpensas.Location = New System.Drawing.Point(392, 142)
        Me.btnCalcularExpensas.Name = "btnCalcularExpensas"
        Me.btnCalcularExpensas.Size = New System.Drawing.Size(65, 23)
        Me.btnCalcularExpensas.TabIndex = 9
        Me.btnCalcularExpensas.Text = "Calcular"
        Me.btnCalcularExpensas.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBorrar.Location = New System.Drawing.Point(371, 304)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(68, 23)
        Me.btnBorrar.TabIndex = 16
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.Location = New System.Drawing.Point(250, 304)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 23)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModificar.Location = New System.Drawing.Point(127, 304)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(68, 23)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrear.Location = New System.Drawing.Point(17, 304)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(68, 23)
        Me.btnCrear.TabIndex = 13
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnIdPersona
        '
        Me.btnIdPersona.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIdPersona.Location = New System.Drawing.Point(474, 6)
        Me.btnIdPersona.Name = "btnIdPersona"
        Me.btnIdPersona.Size = New System.Drawing.Size(68, 23)
        Me.btnIdPersona.TabIndex = 3
        Me.btnIdPersona.Text = "..."
        Me.btnIdPersona.UseVisualStyleBackColor = True
        '
        'lblBonificacion
        '
        Me.lblBonificacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBonificacion.AutoSize = True
        Me.lblBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonificacion.Location = New System.Drawing.Point(124, 257)
        Me.lblBonificacion.Name = "lblBonificacion"
        Me.lblBonificacion.Size = New System.Drawing.Size(94, 18)
        Me.lblBonificacion.TabIndex = 14
        Me.lblBonificacion.Text = "NO APLICA"
        '
        'CBCondicion
        '
        Me.CBCondicion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCondicion.FormattingEnabled = True
        Me.CBCondicion.ItemHeight = 13
        Me.CBCondicion.Items.AddRange(New Object() {"Adeuda", "Pagado"})
        Me.CBCondicion.Location = New System.Drawing.Point(127, 212)
        Me.CBCondicion.Name = "CBCondicion"
        Me.CBCondicion.Size = New System.Drawing.Size(252, 21)
        Me.CBCondicion.TabIndex = 11
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalFactura.Enabled = False
        Me.txtTotalFactura.Location = New System.Drawing.Point(127, 176)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.Size = New System.Drawing.Size(252, 20)
        Me.txtTotalFactura.TabIndex = 12
        '
        'txtPrecioExpensas
        '
        Me.txtPrecioExpensas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecioExpensas.Enabled = False
        Me.txtPrecioExpensas.Location = New System.Drawing.Point(127, 145)
        Me.txtPrecioExpensas.Name = "txtPrecioExpensas"
        Me.txtPrecioExpensas.Size = New System.Drawing.Size(252, 20)
        Me.txtPrecioExpensas.TabIndex = 11
        '
        'txtPrecioAlquiler
        '
        Me.txtPrecioAlquiler.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrecioAlquiler.Enabled = False
        Me.txtPrecioAlquiler.Location = New System.Drawing.Point(127, 108)
        Me.txtPrecioAlquiler.Name = "txtPrecioAlquiler"
        Me.txtPrecioAlquiler.Size = New System.Drawing.Size(252, 20)
        Me.txtPrecioAlquiler.TabIndex = 10
        '
        'txtIdPersona
        '
        Me.txtIdPersona.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIdPersona.Location = New System.Drawing.Point(407, 8)
        Me.txtIdPersona.MaxLength = 5
        Me.txtIdPersona.Name = "txtIdPersona"
        Me.txtIdPersona.Size = New System.Drawing.Size(54, 20)
        Me.txtIdPersona.TabIndex = 2
        '
        'txtIdFactura
        '
        Me.txtIdFactura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIdFactura.Location = New System.Drawing.Point(127, 10)
        Me.txtIdFactura.MaxLength = 5
        Me.txtIdFactura.Name = "txtIdFactura"
        Me.txtIdFactura.Size = New System.Drawing.Size(63, 20)
        Me.txtIdFactura.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Condicion :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Expensas :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Alquiler :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro. Persona :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Factura :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Controls.Add(Me.DGListaFacturas)
        Me.TabPage2.Controls.Add(Me.txtBuscar)
        Me.TabPage2.Controls.Add(Me.btnBuscar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(558, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnActualizar.Location = New System.Drawing.Point(391, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'DGListaFacturas
        '
        Me.DGListaFacturas.AllowUserToAddRows = False
        Me.DGListaFacturas.AllowUserToDeleteRows = False
        Me.DGListaFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGListaFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListaFacturas.Location = New System.Drawing.Point(6, 42)
        Me.DGListaFacturas.MultiSelect = False
        Me.DGListaFacturas.Name = "DGListaFacturas"
        Me.DGListaFacturas.ReadOnly = True
        Me.DGListaFacturas.Size = New System.Drawing.Size(541, 295)
        Me.DGListaFacturas.TabIndex = 2
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(6, 16)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(364, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscar.Location = New System.Drawing.Point(472, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(558, 343)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Reportes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportFacturas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(552, 337)
        Me.ReportViewer1.TabIndex = 0
        '
        'frmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 394)
        Me.Controls.Add(Me.TabFacturas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.TabFacturas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGListaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabFacturas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnCalcularExpensas As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnIdPersona As Button
    Friend WithEvents lblBonificacion As Label
    Friend WithEvents CBCondicion As ComboBox
    Friend WithEvents txtTotalFactura As TextBox
    Friend WithEvents txtPrecioExpensas As TextBox
    Friend WithEvents txtPrecioAlquiler As TextBox
    Friend WithEvents txtIdPersona As TextBox
    Friend WithEvents txtIdFactura As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnActualizar As Button
    Friend WithEvents DGListaFacturas As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DTFechaFactura As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DTFechaVencimiento As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCalcularPrecioAlquiler As Button
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnCalcularTotal As Button
    Friend WithEvents btnPrinter As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnFechaServicios As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
