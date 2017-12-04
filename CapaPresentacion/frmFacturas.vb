
Imports System.Drawing.Printing

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
    Dim text_factura As String = ""



    Private Sub btnCalcularPrecioAlquiler_Click(sender As Object, e As EventArgs) Handles btnCalcularPrecioAlquiler.Click

        If IsNumeric(txtIdPersona.Text) = False Then
            MsgBox("Falta el numero de persona")
            Exit Sub
        End If

        nroPersona = CInt(txtIdPersona.Text)

        Dim DPersona As New CapaDatos.DPersonas()
        DPersona.IdPersona = nroPersona
        Dim NFacturas As New CapaNegocio.NFacturas()

        txtPrecioAlquiler.Text = NFacturas.PrecioAlquiler(DPersona)
        txtPrecioAlquiler.Enabled = False

    End Sub

    Private Sub btnCalcularExpensas_Click(sender As Object, e As EventArgs) Handles btnCalcularExpensas.Click

        If IsNumeric(txtIdPersona.Text) = False Then
            MsgBox("Falta el numero de persona")
            Exit Sub
        End If

        nroPersona = CInt(txtIdPersona.Text)
        fechaContratacion = CDate(DTFechaFactura.Text)
        Dim DServicios As New CapaDatos.DServicios()
        Dim NFacturas As New CapaNegocio.NFacturas()

        DServicios.FechaContratacion = fechaContratacion
        DServicios.IdPersona = nroPersona
        txtPrecioExpensas.Text = NFacturas.Expensas(DServicios).ToString
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click

        If IsNumeric(txtIdPersona.Text) = False Then
            MsgBox("Falta el numero de persona")
            Exit Sub
        End If

        nroPersona = CInt(txtIdPersona.Text)
        Dim verifica As Integer
        Dim DPersona As New CapaDatos.DPersonas
        DPersona.IdPersona = nroPersona
        Dim NFacturas As New CapaNegocio.NFacturas

        verifica = NFacturas.verificarBonificacion(DPersona)

        If verifica <> 0 Then
            lblBonificacion.Text = "APLICA"
        Else
            lblBonificacion.Text = "NO APLICA"
        End If

    End Sub

    Private Sub btnCalcularTotal_Click(sender As Object, e As EventArgs) Handles btnCalcularTotal.Click

        If IsNumeric(txtPrecioAlquiler.Text) = False Or IsNumeric(txtPrecioExpensas.Text) = False Then
            MsgBox("Falta calcular el precio de la expensa o del alquiler ")
            Exit Sub
        End If

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

        txtIdPersona.Clear()

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

    Private Sub btnIdPersona_Click(sender As Object, e As EventArgs) Handles btnIdPersona.Click
        frmSearchHabitantes.Show()
    End Sub

    Private Sub DGListaFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListaFacturas.CellDoubleClick
        txtIdFactura.Text = Convert.ToString(DGListaFacturas.CurrentRow.Cells(0).Value)
        txtIdPersona.Text = Convert.ToString(DGListaFacturas.CurrentRow.Cells(1).Value)
        txtPrecioAlquiler.Text = Convert.ToString(DGListaFacturas.CurrentRow.Cells(2).Value)
        txtPrecioExpensas.Text = Convert.ToString(DGListaFacturas.CurrentRow.Cells(3).Value)
        txtTotalFactura.Text = Convert.ToString(DGListaFacturas.CurrentRow.Cells(4).Value)
        DTFechaFactura.Text = Convert.ToString(DGListaFacturas.CurrentRow.Cells(5).Value)
        DTFechaVencimiento.Text = Convert.ToString(DGListaFacturas.CurrentRow.Cells(7).Value)

    End Sub


    Private Sub btnPrinter_Click_1(sender As Object, e As EventArgs) Handles btnPrinter.Click

        If (IsNumeric(txtIdFactura.Text) = False Or IsNumeric(txtIdPersona.Text) = False Or
            IsNumeric(txtPrecioAlquiler.Text) = False Or IsNumeric(txtPrecioExpensas.Text) = False Or
            isEmptyCadena(CBCondicion.Text) = False) Then
            MsgBox("Faltan datos para poder imprimir la factura")
            Exit Sub
        End If

        Dim id = CInt(txtIdFactura.Text)
        Dim verifico As Integer
        Dim DFactura As New CapaDatos.DFacturas
        DFactura.IdPersona = id
        Dim NFactura As New CapaNegocio.NFacturas

        verifico = NFactura.verificoFactura(DFactura)

        If verifico <> 0 Then
            Dim nroFactura, nroPersona, fechaCon, fechaVen, precioAlq, precioExp, total, boni, condicion As String


            nroFactura = txtIdFactura.Text
            nroPersona = txtIdPersona.Text
            fechaCon = DTFechaFactura.Text
            fechaVen = DTFechaVencimiento.Text
            precioAlq = txtPrecioAlquiler.Text
            precioExp = txtPrecioExpensas.Text
            total = txtTotalFactura.Text
            boni = lblBonificacion.Text
            condicion = CBCondicion.Text



            text_factura = text_factura + ("FACTURA NRO: " + nroFactura + vbCrLf)
            text_factura = text_factura + ("---------------------------" + vbCrLf)
            text_factura = text_factura + ("Fecha Contratacion : " + fechaCon + vbCrLf)
            text_factura = text_factura + ("Fecha Vencimiento : " + fechaVen + vbCrLf)
            text_factura = text_factura + ("---------------------------" + vbCrLf)
            text_factura = text_factura + ("         DETALLES          " + vbCrLf)
            text_factura = text_factura + ("---------------------------" + vbCrLf)
            text_factura = text_factura + ("Precio Alquiler : $" + precioAlq + vbCrLf)
            text_factura = text_factura + ("Precio Expensas : $" + precioExp + vbCrLf)
            text_factura = text_factura + ("" + vbCrLf)
            text_factura = text_factura + ("Bonificacion : " + boni + vbCrLf)
            text_factura = text_factura + ("---------------------------" + vbCrLf)
            text_factura = text_factura + ("TOTAL : $" + total + vbCrLf)

            selectPrinterAndPrint()


        Else
            MsgBox("Guarde la factura antes de imprimirla.")
        End If
    End Sub

    ' funcion para indicar al print el dato que deseamos imprimir
    Public Sub print_PrintPage(ByVal sender As Object,
                            ByVal e As PrintPageEventArgs)

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 18, FontStyle.Bold)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        ' imprimimos la cadena
        e.Graphics.DrawString(text_factura, prFont, Brushes.Black, xPos, yPos)
        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub

    ' funcion para elegir una impresora y imprimir la factura
    Private Function selectPrinterAndPrint() As Boolean
        Dim prtDialog As New PrintDialog

        With prtDialog
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = False
            .PrintToFile = False
            .ShowHelp = False
            .ShowNetwork = True

            If .ShowDialog() = DialogResult.OK Then
                AddHandler PrintDocument1.PrintPage, AddressOf print_PrintPage
                PrintDocument1.Print()
            Else
                Return False
            End If

        End With

        Return True
    End Function




End Class