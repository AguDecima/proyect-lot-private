Public Class frmLotePrivado
    Dim id As Integer
    Dim area As Double
    Dim precio As Double

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If IsNumeric(txtIdLote.Text) = False Or IsNumeric(txtAreaLote.Text) = False Or IsNumeric(txtPrecio.Text) = False Then
            MsgBox("Faltan datos para poder crear el lote")
            Exit Sub
        End If

        id = CInt(txtIdLote.Text)
        area = CDbl(txtAreaLote.Text)
        precio = CDbl(txtPrecio.Text)

        Dim lotePrivado As New CapaDatos.DLotePrivado(id, area, precio)
        Dim Nlote As New CapaNegocio.NLotePrivado

        Nlote.insert(lotePrivado)

        'limpio los controles
        txtIdLote.Clear()
        txtAreaLote.Clear()
        txtPrecio.Clear()
        txtIdLote.Focus()
    End Sub

    Sub ConfigurarDGV()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If IsNumeric(txtIdLote.Text) = False Or IsNumeric(txtAreaLote.Text) = False Or IsNumeric(txtPrecio.Text) = False Then
            MsgBox("Faltan datos para poder crear el lote")
            Exit Sub
        End If

        id = CInt(txtIdLote.Text)
        area = CDbl(txtAreaLote.Text)
        precio = CDbl(txtPrecio.Text)


        Dim lotePrivado As New CapaDatos.DLotePrivado(id, area, precio)
        Dim Nlote As New CapaNegocio.NLotePrivado

        Nlote.update(lotePrivado)

        'limpio los controles
        txtIdLote.Clear()
        txtAreaLote.Clear()
        txtPrecio.Clear()
        txtIdLote.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If IsNumeric(txtIdLote.Text) = False Then
            MsgBox("Falta especificar el numero de lote que desea eliminar")
            Exit Sub
        End If

        id = CInt(txtIdLote.Text)

        Dim lotePrivado As New CapaDatos.DLotePrivado()
        lotePrivado.IdLotePrivado = id
        Dim Nlote As New CapaNegocio.NLotePrivado

        Nlote.delete(lotePrivado)

        'limpio los controles
        txtIdLote.Clear()
        txtAreaLote.Clear()
        txtPrecio.Clear()
        txtIdLote.Focus()
    End Sub

    Private Sub frmLotePrivado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Nlote As New CapaNegocio.NLotePrivado
        Dim datosLotes As DataTable

        datosLotes = Nlote.find()

        DGListaLotesPrivados.DataSource = datosLotes

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtIdLote.Clear()
        txtAreaLote.Clear()
        txtPrecio.Clear()
        txtIdLote.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If IsNumeric(txtBuscar.Text) = False Then
            MsgBox("Falta especificar el numero de lote que desea buscar")
            Exit Sub
        End If

        id = CInt(txtBuscar.Text)
        Dim DLote As New CapaDatos.DLotePrivado()
        DLote.IdLotePrivado = id
        Dim NLote As New CapaNegocio.NLotePrivado()
        Dim datosLotes As DataTable

        datosLotes = NLote.findById(DLote)
        DGListaLotesPrivados.DataSource = datosLotes

    End Sub



    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim Nlote As New CapaNegocio.NLotePrivado
        Dim datosLotes As DataTable

        datosLotes = Nlote.find()

        DGListaLotesPrivados.DataSource = datosLotes
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

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAreaLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAreaLote.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DGListaLotesPrivados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListaLotesPrivados.CellDoubleClick
        txtIdLote.Text = Convert.ToString(DGListaLotesPrivados.CurrentRow.Cells(0).Value)
        txtAreaLote.Text = Convert.ToString(DGListaLotesPrivados.CurrentRow.Cells(1).Value)
        txtPrecio.Text = Convert.ToString(DGListaLotesPrivados.CurrentRow.Cells(2).Value)
    End Sub
End Class