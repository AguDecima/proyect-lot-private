Public Class frmReservas
    Dim habitante As Integer
    Dim fechaContratacion As Date
    Dim fechaVencimiento As Date
    Dim precio As Double
    Dim nroLote As Integer
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If (IsNumeric(txtIdHabitante.Text) = False Or IsNumeric(txtPrecio.Text) = False Or
            IsNumeric(txtLotePublico.Text) = False) Then
            MsgBox("Faltan datos para poder realizar una reserva")
            Exit Sub
        End If

        habitante = CInt(txtIdHabitante.Text)
        fechaContratacion = CDate(DTFechaContratacion.Text)
        fechaVencimiento = CDate(DTFechaVencimiento.Text)
        precio = CDbl(txtPrecio.Text)
        nroLote = CInt(txtLotePublico.Text)

        Dim CReserva As New CapaDatos.DReservas()
        CReserva.IdPersona = habitante
        CReserva.FechaReserva = fechaContratacion
        CReserva.FechaVencimiento = fechaVencimiento
        CReserva.Precio = precio
        CReserva.IdLotePublico = nroLote

        Dim NReserva As New CapaNegocio.NReservas()
        NReserva.insert(CReserva)

        'limpio los controles
        txtIdHabitante.Clear()
        DTFechaContratacion.ResetText()
        DTFechaVencimiento.ResetText()
        txtPrecio.Clear()
        txtLotePublico.Clear()
        txtIdHabitante.Focus()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If (IsNumeric(txtIdHabitante.Text) = False Or IsNumeric(txtPrecio.Text) = False Or
            IsNumeric(txtLotePublico.Text) = False) Then
            MsgBox("Faltan datos para poder modificar una reserva")
            Exit Sub
        End If

        habitante = CInt(txtIdHabitante.Text)
        fechaContratacion = CDate(DTFechaContratacion.Text)
        fechaVencimiento = CDate(DTFechaVencimiento.Text)
        precio = CDbl(txtPrecio.Text)
        nroLote = CInt(txtLotePublico.Text)

        Dim CReserva As New CapaDatos.DReservas()
        CReserva.IdPersona = habitante
        CReserva.FechaReserva = fechaContratacion
        CReserva.FechaVencimiento = fechaVencimiento
        CReserva.Precio = precio
        CReserva.IdLotePublico = nroLote

        Dim NReserva As New CapaNegocio.NReservas()
        NReserva.update(CReserva)

        'limpio los controles
        txtIdHabitante.Clear()
        DTFechaContratacion.ResetText()
        DTFechaVencimiento.ResetText()
        txtPrecio.Clear()
        txtLotePublico.Clear()
        txtIdHabitante.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If (IsNumeric(txtIdHabitante.Text) = False) Then
            MsgBox("Falta especificar el numero de habitante que desea eliminar")
            Exit Sub
        End If

        habitante = CInt(txtIdHabitante.Text)

        Dim CReserva As New CapaDatos.DReservas()
        CReserva.IdPersona = habitante

        Dim NReserva As New CapaNegocio.NReservas()
        NReserva.delete(CReserva)

        'limpio los controles
        txtIdHabitante.Clear()
        DTFechaContratacion.ResetText()
        DTFechaVencimiento.ResetText()
        txtPrecio.Clear()
        txtLotePublico.Clear()
        txtIdHabitante.Focus()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtIdHabitante.Clear()
        DTFechaContratacion.ResetText()
        DTFechaVencimiento.ResetText()
        txtPrecio.Clear()
        txtLotePublico.Clear()
        txtIdHabitante.Focus()
    End Sub

    Private Sub frmReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NReserva As New CapaNegocio.NReservas
        Dim datosReserva As DataTable

        datosReserva = NReserva.find()
        DGListaReservas.DataSource = datosReserva

        txtIdHabitante.Focus()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim NReserva As New CapaNegocio.NReservas
        Dim datosReserva As DataTable

        datosReserva = NReserva.find()
        DGListaReservas.DataSource = datosReserva
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If (IsNumeric(txtBuscar.Text) = False) Then
            MsgBox("Falta especificar en numero de reserva que desea buscar")
            Exit Sub
        End If

        habitante = CInt(txtBuscar.Text)

        Dim CReserva As New CapaDatos.DReservas
        CReserva.IdPersona = habitante

        Dim NReserva As New CapaNegocio.NReservas
        Dim datosReserva As DataTable

        datosReserva = NReserva.findById(CReserva)
        DGListaReservas.DataSource = datosReserva
    End Sub

    Private Sub txtIdHabitante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdHabitante.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtLotePublico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLotePublico.KeyPress
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
End Class