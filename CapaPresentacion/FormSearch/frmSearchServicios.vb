Public Class frmSearchServicios
    Dim id As Integer

    Private Sub frmSearchServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NServicios As New CapaNegocio.NServicios
        Dim dataServicios As DataTable

        dataServicios = NServicios.find()
        DGListaServicios.DataSource = dataServicios

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim NServicios As New CapaNegocio.NServicios
        Dim dataServicios As DataTable

        dataServicios = NServicios.find()
        DGListaServicios.DataSource = dataServicios
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If IsNumeric(txtBuscar.Text) = False Then
            MsgBox("Falta numero de servicio que desea buscar")
            Exit Sub
        End If

        id = CInt(txtBuscar.Text)
        Dim DServicio As New CapaDatos.DServicios
        DServicio.IdServicios = id
        Dim NServicios As New CapaNegocio.NServicios
        Dim dataServicios As DataTable

        dataServicios = NServicios.findById(DServicio)
        DGListaServicios.DataSource = dataServicios
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

    Private Sub DGListaServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGListaServicios.CellDoubleClick
        frmFacturas.DTFechaFactura.Text = Convert.ToString(DGListaServicios.CurrentRow.Cells(4).Value)
        Me.Close()
    End Sub
End Class