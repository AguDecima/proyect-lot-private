Public Class frmServicios
    Dim NroServicio As Integer
    Dim NroLote As Integer
    Dim nombre As String
    Dim empresa As String
    Dim fechaContratacion As Date
    Dim precio As Double

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If (IsNumeric(txtNroLote.Text) = False Or IsNumeric(txtNroServicio.Text) = False Or
            isEmptyCadena(CBNombres.Text) = False Or isEmptyCadena(CBEmpresas.Text) = False Or
            IsNumeric(txtPrecio.Text) = False) Then
            MsgBox("Faltan datos para crear un servicio")
            Exit Sub
        End If


        NroServicio = CInt(txtNroServicio.Text)
        NroLote = CInt(txtNroLote.Text)
        nombre = CBNombres.Text
        empresa = CBEmpresas.Text
        fechaContratacion = CDate(DTFechaContratacion.Text)
        precio = CDbl(txtPrecio.Text)

        Dim DServicio As New CapaDatos.DServicios(NroServicio, NroLote, nombre, empresa, fechaContratacion, precio)
        Dim NServicio As New CapaNegocio.NServicios()

        NServicio.insert(DServicio)

        'limpio los controles
        txtNroLote.Clear()
        txtNroServicio.Clear()
        CBNombres.ResetText()
        CBEmpresas.ResetText()
        txtPrecio.Clear()
        txtNroServicio.Focus()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If (IsNumeric(txtNroLote.Text) = False Or IsNumeric(txtNroServicio.Text) = False Or
            isEmptyCadena(CBNombres.Text) = False Or isEmptyCadena(CBEmpresas.Text) = False Or
            IsNumeric(txtPrecio.Text) = False) Then
            MsgBox("Faltan datos para modificar un servicio")
            Exit Sub
        End If

        NroServicio = CInt(txtNroServicio.Text)
        NroLote = CInt(txtNroLote.Text)
        nombre = CBNombres.Text
        empresa = CBEmpresas.Text
        fechaContratacion = CDate(DTFechaContratacion.Text)
        precio = CDbl(txtPrecio.Text)

        Dim DServicio As New CapaDatos.DServicios(NroServicio, NroLote, nombre, empresa, fechaContratacion, precio)
        Dim NServicio As New CapaNegocio.NServicios()

        NServicio.update(DServicio)

        'limpio los controles 
        txtNroLote.Clear()
        txtNroServicio.Clear()
        CBNombres.ResetText()
        CBEmpresas.ResetText()
        txtPrecio.Clear()
        txtNroServicio.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If (IsNumeric(txtNroServicio.Text) = False) Then
            MsgBox("Falta especificar el numero de servicio que desea eliminar")
            Exit Sub
        End If

        NroServicio = CInt(txtNroServicio.Text)

        Dim DServicio As New CapaDatos.DServicios()
        DServicio.IdServicios = NroServicio

        Dim NServicio As New CapaNegocio.NServicios()

        NServicio.delete(DServicio)

        'limpio los controles
        txtNroLote.Clear()
        txtNroServicio.Clear()
        CBNombres.ResetText()
        CBEmpresas.ResetText()
        txtPrecio.Clear()
        txtNroServicio.Focus()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNroLote.Clear()
        txtNroServicio.Clear()
        CBNombres.ResetText()
        CBEmpresas.ResetText()
        txtPrecio.Clear()
        txtNroServicio.Focus()
    End Sub

    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NServicio As New CapaNegocio.NServicios
        Dim datosReserva As DataTable

        datosReserva = NServicio.find()
        DGListaServicios.DataSource = datosReserva

        txtNroLote.Focus()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim NServicio As New CapaNegocio.NServicios
        Dim datosReserva As DataTable

        datosReserva = NServicio.find()
        DGListaServicios.DataSource = datosReserva
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If (IsNumeric(txtBuscar.Text) = False) Then
            MsgBox("Falta especificar el numero de servicio que desea buscar")
            Exit Sub
        End If

        NroServicio = CInt(txtBuscar.Text)
        Dim DServicio As New CapaDatos.DServicios
        DServicio.IdServicios = NroServicio

        Dim NServicio As New CapaNegocio.NServicios
        Dim datosReserva As DataTable

        datosReserva = NServicio.findById(DServicio)
        DGListaServicios.DataSource = datosReserva
    End Sub

    Private Sub txtNroServicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroServicio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNroLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroLote.KeyPress
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

    Private Sub DGListaServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListaServicios.CellDoubleClick
        txtNroServicio.Text = Convert.ToString(DGListaServicios.CurrentRow.Cells(0).Value)
        txtNroLote.Text = Convert.ToString(DGListaServicios.CurrentRow.Cells(1).Value)
        CBNombres.Text = Convert.ToString(DGListaServicios.CurrentRow.Cells(2).Value)
        DTFechaContratacion.Text = Convert.ToString(DGListaServicios.CurrentRow.Cells(3).Value)
        txtPrecio.Text = Convert.ToString(DGListaServicios.CurrentRow.Cells(4).Value)
    End Sub

    Private Sub btnNroLote_Click(sender As Object, e As EventArgs) Handles btnNroLote.Click
        frmSearchHabitantes.Show()
    End Sub
End Class