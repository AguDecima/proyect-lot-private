﻿Public Class frmLotePublico
    Dim id As Integer
    Dim nombre As String
    Dim disponible As Boolean

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If (IsNumeric(txtIdLote.Text) = False Or isEmptyCadena(txtNombreLote.Text) = False Or
            isEmptyCadena(CBDisponible.Text) = False) Then
            MsgBox("Faltan datos para crear un Lote Publico")
            Exit Sub
        End If


        id = CInt(txtIdLote.Text)
        nombre = txtNombreLote.Text
        If CBDisponible.Text = "Disponible" Then
            disponible = True
        Else
            disponible = False
        End If

        Dim CLote As New CapaDatos.DLotePublico(id, nombre, disponible)
        Dim NLote As New CapaNegocio.NLotePublico()

        NLote.insert(CLote)

        'limpio los controlea
        txtIdLote.Clear()
        txtNombreLote.Clear()
        CBDisponible.ResetText()
        txtIdLote.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If (IsNumeric(txtIdLote.Text) = False Or isEmptyCadena(txtNombreLote.Text) = False Or
            isEmptyCadena(CBDisponible.Text) = False) Then
            MsgBox("Faltan datos para modificar un Lote Publico")
            Exit Sub
        End If

        id = CInt(txtIdLote.Text)
        nombre = txtNombreLote.Text
        If CBDisponible.Text = "Disponible" Then
            disponible = True
        Else
            disponible = False
        End If

        Dim CLote As New CapaDatos.DLotePublico(id, nombre, disponible)
        Dim NLote As New CapaNegocio.NLotePublico()

        NLote.update(CLote)

        'limpio los controlea
        txtIdLote.Clear()
        txtNombreLote.Clear()
        CBDisponible.ResetText()
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

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtIdLote.Clear()
        txtNombreLote.Clear()
        CBDisponible.ResetText()
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
        CBDisponible.ResetText()
        txtIdLote.Focus()

    End Sub
End Class