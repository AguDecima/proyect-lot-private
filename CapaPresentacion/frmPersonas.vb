Public Class frmPersonas
    Dim id As Integer
    Dim nombre As String
    Dim apellido As String
    Dim telefono As String
    Dim fecha_nacimineto As Date
    Dim dni As String
    Dim id_lote As Integer
    Dim is_propietario As Boolean
    Dim is_habitante As Boolean

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        If (IsNumeric(txtIdPersona.Text) = False Or isEmptyCadena(txtNombre.Text) = False Or
            isEmptyCadena(txtApellido.Text) = False Or IsNumeric(txtTelefono.Text) = False Or
            IsNumeric(txtDni.Text) = False Or IsNumeric(txtNroLote.Text) = False) Then
            MsgBox("Faltan datos para poder crear una persona")
            Exit Sub
        End If

        id = CInt(txtIdPersona.Text)
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        telefono = txtTelefono.Text
        fecha_nacimineto = CDate(DTFechaNacimiento.Text)
        dni = txtDni.Text
        id_lote = CInt(txtNroLote.Text)

        If cbHabitante.Checked Then
            is_habitante = True
        End If
        If cbPropietario.Checked Then
            is_propietario = True
        End If

        Dim DPersonas As New CapaDatos.DPersonas(id, nombre, apellido, fecha_nacimineto, dni, telefono,
                                                 id_lote, is_propietario, is_habitante)
        Dim NPersonas As New CapaNegocio.NPersonas

        NPersonas.insert(DPersonas)

        'borro los controles despues de guardar los datos
        txtNombre.Clear()
        txtApellido.Clear()
        DTFechaNacimiento.ResetText()
        txtTelefono.Clear()
        txtDni.Clear()
        txtNroLote.Clear()
        cbHabitante.ResetText()
        cbPropietario.ResetText()
        txtNroLote.Focus()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If (IsNumeric(txtIdPersona.Text) = False Or isEmptyCadena(txtNombre.Text) = False Or
            isEmptyCadena(txtApellido.Text) = False Or IsNumeric(txtTelefono.Text) = False Or
            IsNumeric(txtDni.Text) = False Or IsNumeric(txtNroLote.Text) = False) Then
            MsgBox("Faltan datos para poder modificar una persona")
            Exit Sub
        End If

        id = CInt(txtIdPersona.Text)
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        telefono = txtTelefono.Text
        fecha_nacimineto = CDate(DTFechaNacimiento.Text)
        dni = txtDni.Text
        id_lote = CInt(txtNroLote.Text)

        If cbHabitante.Checked Then
            is_habitante = True
        End If
        If cbPropietario.Checked Then
            is_propietario = True
        End If

        Dim DPersonas As New CapaDatos.DPersonas(id, nombre, apellido, fecha_nacimineto, dni, telefono,
                                                 id_lote, is_propietario, is_habitante)
        Dim NPersonas As New CapaNegocio.NPersonas

        NPersonas.update(DPersonas)

        'borro los controles despues de guardar los datos
        txtNombre.Clear()
        txtApellido.Clear()
        DTFechaNacimiento.ResetText()
        txtTelefono.Clear()
        txtDni.Clear()
        txtNroLote.Clear()
        cbHabitante.ResetText()
        cbPropietario.ResetText()
        txtNroLote.Focus()
    End Sub

    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NPersonas As New CapaNegocio.NPersonas()
        Dim datosPersonas As DataTable
        Dim datosPropietarios As DataTable

        datosPersonas = NPersonas.findHabitantes()
        ListaHabitantes.DataSource = datosPersonas

        datosPropietarios = NPersonas.findPropietarios()
        ListaPropietarios.DataSource = datosPropietarios

        txtNombre.Focus()
        DTFechaNacimiento.MaxDate = Today

        txtNroLote.Clear()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim NPersonas As New CapaNegocio.NPersonas()
        Dim datosHabitantes, datosPropietarios As DataTable

        datosHabitantes = NPersonas.findHabitantes()
        ListaHabitantes.DataSource = datosHabitantes

        datosPropietarios = NPersonas.findPropietarios()
        ListaPropietarios.DataSource = datosPropietarios


    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim NPersonas As New CapaNegocio.NPersonas()
        Dim datosPropietarios As DataTable

        datosPropietarios = NPersonas.findPropietarios()
        ListaPropietarios.DataSource = datosPropietarios
    End Sub

    Private Sub btnHabitanteForLote_Click(sender As Object, e As EventArgs) Handles btnHabitanteForLote.Click

        If (IsNumeric(txtBuscarHabForLote.Text) = False) Then
            MsgBox("Faltan especificar el numero de lote que desea buscar")
            Exit Sub
        End If

        id = CInt(txtBuscarHabForLote.Text)
        Dim CPersona As New CapaDatos.DPersonas()
        Dim NPersonas As New CapaNegocio.NPersonas()
        Dim datosHabLotes As DataTable

        CPersona.IdLotePrivado = id

        datosHabLotes = NPersonas.findByIdHabitantesForLotes(CPersona)
        HabitantesLotes.DataSource = datosHabLotes
    End Sub

    Private Sub btnBuscarHabitantes_Click(sender As Object, e As EventArgs) Handles btnBuscarHabitantes.Click

        If (IsNumeric(txtBuscarHabitantes.Text) = False) Then
            MsgBox("Faltan especificar el numero de habitante que desea buscar")
            Exit Sub
        End If

        id = CInt(txtBuscarHabitantes.Text)

        Dim CPersona As New CapaDatos.DPersonas()
        Dim NPersonas As New CapaNegocio.NPersonas()
        Dim datosHabLotes As DataTable

        CPersona.IdPersona = id

        datosHabLotes = NPersonas.findByIdHabitantes(CPersona)
        ListaHabitantes.DataSource = datosHabLotes

    End Sub

    Private Sub btnBuscarPropietarios_Click(sender As Object, e As EventArgs) Handles btnBuscarPropietarios.Click

        If (IsNumeric(txtBuscarPropietarios.Text) = False) Then
            MsgBox("Faltan especificar el numero de propietario que desea buscar")
            Exit Sub
        End If

        id = CInt(txtBuscarPropietarios.Text)

        Dim CPersona As New CapaDatos.DPersonas()
        Dim NPersonas As New CapaNegocio.NPersonas()
        Dim datosHabLotes As DataTable

        CPersona.IdPersona = id

        datosHabLotes = NPersonas.findByIdPropietarios(CPersona)
        ListaPropietarios.DataSource = datosHabLotes
    End Sub



    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
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

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
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

    Private Sub txtIdPersona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdPersona.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
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

    Private Sub txtBuscarHabitantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarHabitantes.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscarPropietarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarPropietarios.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscarHabForLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarHabForLote.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNombre.Clear()
        txtApellido.Clear()
        DTFechaNacimiento.ResetText()
        txtTelefono.Clear()
        txtDni.Clear()
        txtNroLote.Clear()
        cbHabitante.Checked = False
        cbPropietario.Checked = False
        txtIdPersona.Clear()
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If (IsNumeric(txtIdPersona.Text) = False) Then
            MsgBox("Faltan especificar el numero de persona que desea eliminar")
            Exit Sub
        End If

        id = CInt(txtIdPersona.Text)
        Dim DPersona As New CapaDatos.DPersonas
        DPersona.IdPersona = id
        Dim NPersona As New CapaNegocio.NPersonas

        NPersona.delete(DPersona)

        'borro los controles despues de guardar los datos
        txtNombre.Clear()
        txtApellido.Clear()
        DTFechaNacimiento.ResetText()
        txtTelefono.Clear()
        txtDni.Clear()
        txtNroLote.Clear()
        cbHabitante.ResetText()
        cbPropietario.ResetText()
        txtNroLote.Focus()

    End Sub

    Private Sub ListaHabitantes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaHabitantes.CellDoubleClick
        txtIdPersona.Text = Convert.ToString(ListaHabitantes.CurrentRow.Cells(0).Value)
        txtNombre.Text = Convert.ToString(ListaHabitantes.CurrentRow.Cells(1).Value)
        txtApellido.Text = Convert.ToString(ListaHabitantes.CurrentRow.Cells(2).Value)
        txtTelefono.Text = Convert.ToString(ListaHabitantes.CurrentRow.Cells(3).Value)
        txtNroLote.Text = Convert.ToString(ListaHabitantes.CurrentRow.Cells(4).Value)
    End Sub

    Private Sub btnNroLote_Click(sender As Object, e As EventArgs) Handles btnNroLote.Click
        frmSearchLote.Show()
    End Sub
End Class