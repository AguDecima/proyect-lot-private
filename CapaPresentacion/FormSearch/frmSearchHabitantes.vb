Public Class frmSearchHabitantes
    Dim idHabitante As Integer

    Private Sub frmSearchHabitantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NPersonas As New CapaNegocio.NPersonas
        Dim dataHabitantes As DataTable

        dataHabitantes = NPersonas.findHabitantes()
        DGListaHabitantes.DataSource = dataHabitantes

    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim NPersonas As New CapaNegocio.NPersonas
        Dim dataHabitantes As DataTable

        dataHabitantes = NPersonas.findHabitantes()
        DGListaHabitantes.DataSource = dataHabitantes
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        idHabitante = CInt(txtBuscar.Text)

        Dim DPersona As New CapaDatos.DPersonas
        Dim dataHabitantes As DataTable
        Dim NPersona As New CapaNegocio.NPersonas

        DPersona.IdPersona = idHabitante
        dataHabitantes = NPersona.findByIdHabitantes(DPersona)
        DGListaHabitantes.DataSource = dataHabitantes

    End Sub

    Private Sub DGListaHabitantes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListaHabitantes.CellDoubleClick
        frmFacturas.txtIdPersona.Text = Convert.ToString(DGListaHabitantes.CurrentRow.Cells(0).Value)
        frmReservas.txtIdHabitante.Text = Convert.ToString(DGListaHabitantes.CurrentRow.Cells(0).Value)
        frmServicios.txtNroLote.Text = Convert.ToString(DGListaHabitantes.CurrentRow.Cells(0).Value)
        Me.Close()
    End Sub
End Class