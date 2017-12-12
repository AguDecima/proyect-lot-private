<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Personas = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoHabitanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaHabitantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaPropietariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LotesPrivadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LotesPublicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListaDeLotesPrivadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeLotesPublicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeHabitantesPorLotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Personas, Me.LotesToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.ReservasToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Personas
        '
        Me.Personas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoHabitanteToolStripMenuItem, Me.ListaHabitantesToolStripMenuItem, Me.ListaPropietariosToolStripMenuItem1})
        Me.Personas.Name = "Personas"
        Me.Personas.Size = New System.Drawing.Size(66, 20)
        Me.Personas.Text = "Personas"
        '
        'NuevoHabitanteToolStripMenuItem
        '
        Me.NuevoHabitanteToolStripMenuItem.Name = "NuevoHabitanteToolStripMenuItem"
        Me.NuevoHabitanteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NuevoHabitanteToolStripMenuItem.Text = "Crear Persona"
        '
        'ListaHabitantesToolStripMenuItem
        '
        Me.ListaHabitantesToolStripMenuItem.Name = "ListaHabitantesToolStripMenuItem"
        Me.ListaHabitantesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ListaHabitantesToolStripMenuItem.Text = "Lista Habitantes"
        '
        'ListaPropietariosToolStripMenuItem1
        '
        Me.ListaPropietariosToolStripMenuItem1.Name = "ListaPropietariosToolStripMenuItem1"
        Me.ListaPropietariosToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ListaPropietariosToolStripMenuItem1.Text = "Lista Propietarios"
        '
        'LotesToolStripMenuItem
        '
        Me.LotesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LotesPrivadosToolStripMenuItem, Me.LotesPublicosToolStripMenuItem, Me.ToolStripSeparator1, Me.ListaDeLotesPrivadosToolStripMenuItem, Me.ListaDeLotesPublicosToolStripMenuItem, Me.ListaDeHabitantesPorLotesToolStripMenuItem})
        Me.LotesToolStripMenuItem.Name = "LotesToolStripMenuItem"
        Me.LotesToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.LotesToolStripMenuItem.Text = "Lotes"
        '
        'LotesPrivadosToolStripMenuItem
        '
        Me.LotesPrivadosToolStripMenuItem.Name = "LotesPrivadosToolStripMenuItem"
        Me.LotesPrivadosToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.LotesPrivadosToolStripMenuItem.Text = "Nuevo Lote Privado"
        '
        'LotesPublicosToolStripMenuItem
        '
        Me.LotesPublicosToolStripMenuItem.Name = "LotesPublicosToolStripMenuItem"
        Me.LotesPublicosToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.LotesPublicosToolStripMenuItem.Text = "Nuevo Lote Publico"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(223, 6)
        '
        'ListaDeLotesPrivadosToolStripMenuItem
        '
        Me.ListaDeLotesPrivadosToolStripMenuItem.Name = "ListaDeLotesPrivadosToolStripMenuItem"
        Me.ListaDeLotesPrivadosToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ListaDeLotesPrivadosToolStripMenuItem.Text = "Lista de Lotes Privados"
        '
        'ListaDeLotesPublicosToolStripMenuItem
        '
        Me.ListaDeLotesPublicosToolStripMenuItem.Name = "ListaDeLotesPublicosToolStripMenuItem"
        Me.ListaDeLotesPublicosToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ListaDeLotesPublicosToolStripMenuItem.Text = "Lista de Lotes Publicos"
        '
        'ListaDeHabitantesPorLotesToolStripMenuItem
        '
        Me.ListaDeHabitantesPorLotesToolStripMenuItem.Name = "ListaDeHabitantesPorLotesToolStripMenuItem"
        Me.ListaDeHabitantesPorLotesToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ListaDeHabitantesPorLotesToolStripMenuItem.Text = "Lista de Habitantes por Lotes"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoServicioToolStripMenuItem, Me.ListaServiciosToolStripMenuItem})
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'NuevoServicioToolStripMenuItem
        '
        Me.NuevoServicioToolStripMenuItem.Name = "NuevoServicioToolStripMenuItem"
        Me.NuevoServicioToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NuevoServicioToolStripMenuItem.Text = "Nuevo Servicio"
        '
        'ListaServiciosToolStripMenuItem
        '
        Me.ListaServiciosToolStripMenuItem.Name = "ListaServiciosToolStripMenuItem"
        Me.ListaServiciosToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ListaServiciosToolStripMenuItem.Text = "Lista Servicios"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaReservaToolStripMenuItem, Me.ListaReservasToolStripMenuItem})
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'NuevaReservaToolStripMenuItem
        '
        Me.NuevaReservaToolStripMenuItem.Name = "NuevaReservaToolStripMenuItem"
        Me.NuevaReservaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NuevaReservaToolStripMenuItem.Text = "Nueva Reserva"
        '
        'ListaReservasToolStripMenuItem
        '
        Me.ListaReservasToolStripMenuItem.Name = "ListaReservasToolStripMenuItem"
        Me.ListaReservasToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ListaReservasToolStripMenuItem.Text = "Lista Reservas"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasToolStripMenuItem1, Me.ListaFacturasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'FacturasToolStripMenuItem1
        '
        Me.FacturasToolStripMenuItem1.Name = "FacturasToolStripMenuItem1"
        Me.FacturasToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.FacturasToolStripMenuItem1.Text = "Crear Factura"
        '
        'ListaFacturasToolStripMenuItem
        '
        Me.ListaFacturasToolStripMenuItem.Name = "ListaFacturasToolStripMenuItem"
        Me.ListaFacturasToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ListaFacturasToolStripMenuItem.Text = "Lista Facturas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SalirToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 480)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(693, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(693, 502)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barrio Privado - Las Rosas"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Personas As ToolStripMenuItem
    Friend WithEvents NuevoHabitanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LotesPrivadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LotesPublicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoServicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListaHabitantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaPropietariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ListaDeLotesPrivadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeLotesPublicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeHabitantesPorLotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListaFacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
End Class
