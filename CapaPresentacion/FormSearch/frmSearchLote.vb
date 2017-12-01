Public Class frmSearchLote
    Dim idLote As Integer
    Private Sub frmSearchLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NLote As New CapaNegocio.NLotePrivado
        Dim dataLote As DataTable

        dataLote = NLote.find()
        DGListaLotePrivados.DataSource = dataLote
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
        Dim NLote As New CapaNegocio.NLotePrivado
        Dim dataLote As DataTable

        dataLote = NLote.find()
        DGListaLotePrivados.DataSource = dataLote
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        idLote = CInt(txtBuscar.Text)

        Dim DLote As New CapaDatos.DLotePrivado
        Dim NLote As New CapaNegocio.NLotePrivado
        Dim dataLote As DataTable

        DLote.IdLotePrivado = idLote
        dataLote = NLote.findById(DLote)

    End Sub

    Private Sub DGListaLotePrivados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListaLotePrivados.CellDoubleClick
        frmPersonas.txtNroLote.Text = Convert.ToString(DGListaLotePrivados.CurrentRow.Cells(0).Value)
        Me.Close()
    End Sub
End Class