Public Class frmFacturas
    Dim nroFactura As Integer
    Dim nroPersona As Integer
    Dim fechaContratacion As Date
    Dim fechaVencimiento As Date
    Dim precioAlquiler As Double
    Dim precioExpensa As Double
    Dim bonificacion As Boolean
    Dim total As Double
    Dim condicion As Boolean

    Private Sub btnCalcularPrecioAlquiler_Click(sender As Object, e As EventArgs) Handles btnCalcularPrecioAlquiler.Click
        nroPersona = CInt(txtIdPersona.Text)

        Dim DPersona As New CapaDatos.DPersonas()
        DPersona.IdPersona = nroPersona
        Dim NFacturas As New CapaNegocio.NFacturas()

        txtPrecioAlquiler.Text = NFacturas.PrecioAlquiler(DPersona)
        txtPrecioAlquiler.Enabled = False

    End Sub

    Private Sub btnCalcularExpensas_Click(sender As Object, e As EventArgs) Handles btnCalcularExpensas.Click
        fechaContratacion = CDate(DTFechaFactura.Text)
        Dim DServicios As New CapaDatos.DServicios()
        Dim NFacturas As New CapaNegocio.NFacturas()

        DServicios.FechaContratacion = fechaContratacion
        txtPrecioExpensas.Text = NFacturas.Expensas(DServicios).ToString
        txtPrecioExpensas.Enabled = False
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        nroPersona = CInt(txtIdPersona.Text)
        Dim verifica As Integer
        Dim DPersona As New CapaDatos.DPersonas
        DPersona.IdPersona = nroPersona
        Dim NFacturas As New CapaNegocio.NFacturas

        verifica = NFacturas.verificarBonificacion(DPersona)

        If verifica <> 0 Then
            lblBonificacion.Text = "APLICA"
        End If

    End Sub

    Private Sub btnCalcularTotal_Click(sender As Object, e As EventArgs) Handles btnCalcularTotal.Click

        precioExpensa = CDbl(txtPrecioExpensas.Text)
        precioAlquiler = CDbl(txtPrecioAlquiler.Text)

        If lblBonificacion.Text = "APLICA" Then
            condicion = True
        Else
            condicion = False
        End If

        Dim DFactura As New CapaDatos.DFacturas
        DFactura.PrecioExpensas = precioExpensa
        DFactura.PrecioAlquiler = precioAlquiler
        DFactura.Bonificacion = condicion
        Dim NFacturas As New CapaNegocio.NFacturas

        txtTotalFactura.Text = NFacturas.calcularTotal(DFactura)
        txtTotalFactura.Enabled = False
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If (IsNumeric(txtIdFactura.Text) = False Or IsNumeric(txtIdPersona.Text) = False Or
            IsNumeric(txtPrecioAlquiler.Text) = False Or IsNumeric(txtPrecioExpensas.Text) = False Or
            isEmptyCadena(CBCondicion.Text) = False) Then
            MsgBox("Faltan datos para poder guardar la factura")
            Exit Sub
        End If


        nroFactura = CInt(txtIdFactura.Text)
        nroPersona = CInt(txtIdPersona.Text)
        fechaContratacion = CDate(DTFechaFactura.Text)
        fechaVencimiento = CDate(DTFechaVencimiento.Text)
        precioAlquiler = CDbl(txtPrecioAlquiler.Text)
        precioExpensa = CDbl(txtPrecioExpensas.Text)

        If lblBonificacion.Text = "APLICA" Then
            bonificacion = True
        Else
            bonificacion = False
        End If
        If CBCondicion.Text = "Pagado" Then
            condicion = True
        Else
            condicion = False
        End If

        total = CDbl(txtTotalFactura.Text)

        Dim DFactura As New CapaDatos.DFacturas(nroFactura, nroPersona, precioAlquiler, precioExpensa, fechaContratacion,
                                                fechaVencimiento, bonificacion, condicion, total)
        Dim NFactura As New CapaNegocio.NFacturas

        NFactura.insert(DFactura)

        'borrar los controles
        txtIdFactura.Clear()
        txtIdPersona.Clear()
        DTFechaFactura.ResetText()
        DTFechaVencimiento.ResetText()
        lblBonificacion.Text = "NO APLICA"
        txtPrecioAlquiler.Clear()
        txtPrecioExpensas.Clear()
        txtTotalFactura.Clear()
        CBCondicion.ResetText()
        txtIdFactura.Focus()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If (IsNumeric(txtIdFactura.Text) = False Or IsNumeric(txtIdPersona.Text) = False Or
            IsNumeric(txtPrecioAlquiler.Text) = False Or IsNumeric(txtPrecioExpensas.Text) = False Or
            isEmptyCadena(CBCondicion.Text) = False) Then
            MsgBox("Faltan datos para poder modificar la factura")
            Exit Sub
        End If

        nroFactura = CInt(txtIdFactura.Text)
        nroPersona = CInt(txtIdPersona.Text)
        fechaContratacion = CDate(DTFechaFactura.Text)
        fechaVencimiento = CDate(DTFechaVencimiento.Text)
        precioAlquiler = CDbl(txtPrecioAlquiler.Text)
        precioExpensa = CDbl(txtPrecioExpensas.Text)

        If lblBonificacion.Text = "APLICA" Then
            bonificacion = True
        Else
            bonificacion = False
        End If
        If CBCondicion.Text = "Pagado" Then
            condicion = True
        Else
            condicion = False
        End If

        total = CDbl(txtTotalFactura.Text)

        Dim DFactura As New CapaDatos.DFacturas(nroFactura, nroPersona, precioAlquiler, precioExpensa, fechaContratacion,
                                                fechaVencimiento, bonificacion, condicion, total)
        Dim NFactura As New CapaNegocio.NFacturas

        NFactura.update(DFactura)

        'limpio todos los controles
        txtIdFactura.Clear()
        txtIdPersona.Clear()
        DTFechaFactura.ResetText()
        DTFechaVencimiento.ResetText()
        lblBonificacion.Text = "NO APLICA"
        txtPrecioAlquiler.Clear()
        txtPrecioExpensas.Clear()
        txtTotalFactura.Clear()
        CBCondicion.ResetText()
        txtIdFactura.Focus()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If IsNumeric(txtIdFactura.Text) = False Then
            MsgBox("Faltan especificar el numero de factura que desea eliminar")
            Exit Sub
        End If

        nroFactura = CInt(txtIdFactura.Text)

        Dim DFactura As New CapaDatos.DFacturas
        DFactura.IdFacturas = nroFactura
        Dim NFactura As New CapaNegocio.NFacturas

        NFactura.delete(DFactura)

        'limpio todos los controles
        txtIdFactura.Clear()
        txtIdPersona.Clear()
        DTFechaFactura.ResetText()
        DTFechaVencimiento.ResetText()
        lblBonificacion.Text = "NO APLICA"
        txtPrecioAlquiler.Clear()
        txtPrecioExpensas.Clear()
        txtTotalFactura.Clear()
        CBCondicion.ResetText()
        txtIdFactura.Focus()

    End Sub

    Private Sub frmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NFactura As New CapaNegocio.NFacturas
        Dim dataFactura As DataTable
        dataFactura = NFactura.findAll()

        DGListaFacturas.DataSource = dataFactura
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim NFactura As New CapaNegocio.NFacturas
        Dim dataFactura As DataTable
        dataFactura = NFactura.findAll()

        DGListaFacturas.DataSource = dataFactura
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If (IsNumeric(txtBuscar.Text) = False) Then
            MsgBox("Falta especificar el numero de factura que desea buscar")
            Exit Sub
        End If

        nroFactura = CInt(txtBuscar.Text)
        Dim DFactura As New CapaDatos.DFacturas
        DFactura.IdFacturas = nroFactura
        Dim NFactura As New CapaNegocio.NFacturas
        Dim dataFactura As DataTable
        dataFactura = NFactura.findById(DFactura)

        DGListaFacturas.DataSource = dataFactura
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtIdFactura.Clear()
        txtIdPersona.Clear()
        DTFechaFactura.ResetText()
        DTFechaVencimiento.ResetText()
        lblBonificacion.Text = "NO APLICA"
        txtPrecioAlquiler.Clear()
        txtPrecioExpensas.Clear()
        txtTotalFactura.Clear()
        CBCondicion.ResetText()
        txtIdFactura.Focus()
    End Sub

    Private Sub txtIdFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdFactura.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIdPersona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdPersona.KeyPress
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
End Class