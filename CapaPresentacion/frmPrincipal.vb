Imports System.Windows.Forms

Public Class frmPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub


    Private Sub ListaHabitantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaHabitantesToolStripMenuItem.Click
        Dim tb As TabPage = frmPersonas.TabPersonas.TabPages(1)
        frmPersonas.TabPersonas.SelectedTab = tb
        frmPersonas.MdiParent = Me
        frmPersonas.Show()
    End Sub

    Private Sub ListaPropietariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListaPropietariosToolStripMenuItem1.Click
        Dim tb As TabPage = frmPersonas.TabPersonas.TabPages(2)
        frmPersonas.TabPersonas.SelectedTab = tb
        frmPersonas.MdiParent = Me
        frmPersonas.Show()
    End Sub

    Private Sub NuevoHabitanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoHabitanteToolStripMenuItem.Click
        Dim tb As TabPage = frmPersonas.TabPersonas.TabPages(0)
        frmPersonas.TabPersonas.SelectedTab = tb
        frmPersonas.MdiParent = Me
        frmPersonas.Show()
    End Sub

    Private Sub LotesPrivadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesPrivadosToolStripMenuItem.Click
        Dim tb As TabPage = frmLotePrivado.TabLotePrivado.TabPages(0)
        frmLotePrivado.TabLotePrivado.SelectedTab = tb
        frmLotePrivado.MdiParent = Me
        frmLotePrivado.Show()
    End Sub

    Private Sub LotesPublicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesPublicosToolStripMenuItem.Click
        Dim tb As TabPage = frmLotePublico.TabLotePublico.TabPages(0)
        frmLotePublico.TabLotePublico.SelectedTab = tb
        frmLotePublico.MdiParent = Me
        frmLotePublico.Show()
    End Sub

    Private Sub ListaDeLotesPrivadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeLotesPrivadosToolStripMenuItem.Click
        Dim tb As TabPage = frmLotePrivado.TabLotePrivado.TabPages(1)
        frmLotePrivado.TabLotePrivado.SelectedTab = tb
        frmLotePrivado.MdiParent = Me
        frmLotePrivado.Show()
    End Sub

    Private Sub ListaDeLotesPublicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeLotesPublicosToolStripMenuItem.Click
        Dim tb As TabPage = frmLotePublico.TabLotePublico.TabPages(1)
        frmLotePublico.TabLotePublico.SelectedTab = tb
        frmLotePublico.MdiParent = Me
        frmLotePublico.Show()
    End Sub

    Private Sub ListaDeHabitantesPorLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeHabitantesPorLotesToolStripMenuItem.Click
        Dim tb As TabPage = frmPersonas.TabPersonas.TabPages(3)
        frmPersonas.TabPersonas.SelectedTab = tb
        frmPersonas.MdiParent = Me
        frmPersonas.Show()
    End Sub

    Private Sub NuevaReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaReservaToolStripMenuItem.Click
        Dim tb As TabPage = frmReservas.TabReservas.TabPages(0)
        frmReservas.TabReservas.SelectedTab = tb
        frmReservas.MdiParent = Me
        frmReservas.Show()
    End Sub

    Private Sub ListaReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaReservasToolStripMenuItem.Click
        Dim tb As TabPage = frmReservas.TabReservas.TabPages(1)
        frmReservas.TabReservas.SelectedTab = tb
        frmReservas.MdiParent = Me
        frmReservas.Show()
    End Sub

    Private Sub NuevoServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoServicioToolStripMenuItem.Click
        Dim tb As TabPage = frmServicios.TabServicios.TabPages(0)
        frmServicios.TabServicios.SelectedTab = tb
        frmServicios.MdiParent = Me
        frmServicios.Show()
    End Sub

    Private Sub ListaServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaServiciosToolStripMenuItem.Click
        Dim tb As TabPage = frmServicios.TabServicios.TabPages(1)
        frmServicios.TabServicios.SelectedTab = tb
        frmServicios.MdiParent = Me
        frmServicios.Show()
    End Sub

    Private Sub FacturasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem1.Click
        Dim tb As TabPage = frmFacturas.TabFacturas.TabPages(0)
        frmFacturas.TabFacturas.SelectedTab = tb
        frmFacturas.MdiParent = Me
        frmFacturas.Show()
    End Sub

    Private Sub ListaFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaFacturasToolStripMenuItem.Click
        Dim tb As TabPage = frmFacturas.TabFacturas.TabPages(1)
        frmFacturas.TabFacturas.SelectedTab = tb
        frmFacturas.MdiParent = Me
        frmFacturas.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("file:///F:/Taller%20de%20Lenguaje%20II/Trabajo%20Final/app%20con%20git/startbootstrap-grayscale-gh-pages/index.html")
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Dim tb As TabPage = frmFacturas.TabFacturas.TabPages(2)
        frmFacturas.TabFacturas.SelectedTab = tb
        frmFacturas.MdiParent = Me
        frmFacturas.Show()
    End Sub
End Class
