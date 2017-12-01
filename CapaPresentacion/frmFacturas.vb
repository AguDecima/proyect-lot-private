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
        DTFechaFactura.Text = Convert.ToString(DGListaFacturas.CurrentRow.Cells(3).Value)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Variable a nivel de clase para recordar en qué punto nos hemos quedado 
        ' la inicializamos a -1 para imprimir también las cabeceras de las columnasprivate 
        Dim i As Integer = -1
        ' La fuente que vamos a usar para imprimir.
        Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim linesPerPage As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim row As System.Windows.Forms.DataGridViewRow

        ' Calculamos el número de líneas que caben en cada página. 
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid. 
        While count < linesPerPage AndAlso i < DGListaFacturas.Rows.Count
            row = DGListaFacturas.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                texto += vbCrLf + celda.Value.ToString()
            Next
            ' Calculamos la posición en la que se escribe la línea 
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
            ' Escribimos la línea con el objeto Graphics 
            e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            count += 1
            i += 1
        End While
        ' Una vez fuera del bucle comprobamos si nos quedan más filas 
        ' por imprimir, si quedan saldrán en la siguente página 
        If i < DGListaFacturas.Rows.Count Then
            e.HasMorePages = True
        Else
            ' si llegamos al final, se establece HasMorePages a 
            ' false para que se acabe la impresión 
            e.HasMorePages = False
            ' Es necesario poner el contador a 0 porque, por ejemplo si se hace 
            ' una impresión desde PrintPreviewDialog, se vuelve disparar este 
            ' evento como si fuese la primera vez, y si i está con el valor de la 
            ' última fila del grid no se imprime nada 
            i = 0
        End If
    End Sub

End Class