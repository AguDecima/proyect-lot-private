Public Class frmSearchLotePublico
    Dim idLote As Integer
    Private Sub frmSearchLotePublico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NLote As New CapaNegocio.NLotePublico
        Dim dataLote As DataTable

        dataLote = NLote.Find()
        DGListaLotePublicos.DataSource = dataLote
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
        Dim NLote As New CapaNegocio.NLotePublico
        Dim dataLote As DataTable

        dataLote = NLote.Find()
        DGListaLotePublicos.DataSource = dataLote
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        idLote = CInt(txtBuscar.Text)

        Dim DLote As New CapaDatos.DLotePublico
        Dim NLote As New CapaNegocio.NLotePublico
        Dim dataLote As DataTable

        DLote.IdLotePublico = idLote
        dataLote = NLote.FindById(DLote)
        DGListaLotePublicos.DataSource = dataLote

    End Sub

    Private Sub DGListaLotePublicos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListaLotePublicos.CellDoubleClick
        frmReservas.txtLotePublico.Text = Convert.ToString(DGListaLotePublicos.CurrentRow.Cells(0).Value)
        Me.Close()
    End Sub
End Class