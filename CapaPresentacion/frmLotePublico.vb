Public Class frmLotePublico
    Dim id As Integer
    Dim nombre As String
    Dim disponible As Boolean

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If isEmptyCadena(txtNombreLote.Text) = False Then
            MsgBox("Faltan datos para crear un Lote Publico")
            Exit Sub
        End If

        nombre = txtNombreLote.Text

        Dim CLote As New CapaDatos.DLotePublico()
        CLote.Nombre = nombre
        Dim NLote As New CapaNegocio.NLotePublico()

        NLote.insert(CLote)

        'limpio los controlea
        txtIdLote.Clear()
        txtNombreLote.Clear()
        txtIdLote.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If IsNumeric(txtIdLote.Text) = False Or isEmptyCadena(txtNombreLote.Text) = False Then
            MsgBox("Faltan datos para crear un Lote Publico")
            Exit Sub
        End If

        id = CInt(txtIdLote.Text)
        nombre = txtNombreLote.Text

        Dim CLote As New CapaDatos.DLotePublico()
        CLote.IdLotePublico = id
        CLote.Nombre = nombre
        Dim NLote As New CapaNegocio.NLotePublico()

        NLote.update(CLote)

        'limpio los controlea
        txtIdLote.Clear()
        txtNombreLote.Clear()
        txtIdLote.Focus()
    End Sub

    Private Sub frmLotePublico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NLote As New CapaNegocio.NLotePublico()
        Dim DatosLote As DataTable

        DatosLote = NLote.Find()
        DGListaLotesPublicos.DataSource = DatosLote

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim NLote As New CapaNegocio.NLotePublico()
        Dim DatosLote As DataTable

        DatosLote = NLote.Find()
        DGListaLotesPublicos.DataSource = DatosLote
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        id = CInt(txtBuscar.Text)
        Dim CLote As New CapaDatos.DLotePublico()
        Dim NLote As New CapaNegocio.NLotePublico
        Dim datosLote As DataTable
        CLote.IdLotePublico = id
        datosLote = NLote.FindById(CLote)

        DGListaLotesPublicos.DataSource = datosLote

        txtBuscar.Clear()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtIdLote.Clear()
        txtNombreLote.Clear()
        txtIdLote.Focus()
    End Sub

    Private Sub txtNombreLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreLote.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIdLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdLote.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (IsNumeric(txtIdLote.Text) = False) Then
            MsgBox("Falta especificar el numero de Lote que desea eliminar")
            Exit Sub
        End If


        id = CInt(txtIdLote.Text)
        Dim DLote As New CapaDatos.DLotePublico
        DLote.IdLotePublico = id
        Dim NLote As New CapaNegocio.NLotePublico

        NLote.delete(DLote)

        'limpio los controlea
        txtIdLote.Clear()
        txtNombreLote.Clear()
        txtIdLote.Focus()

    End Sub

    Private Sub DGListaLotesPublicos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListaLotesPublicos.CellDoubleClick
        txtIdLote.Text = Convert.ToString(DGListaLotesPublicos.CurrentRow.Cells(0).Value)
        txtNombreLote.Text = Convert.ToString(DGListaLotesPublicos.CurrentRow.Cells(1).Value)
    End Sub

End Class