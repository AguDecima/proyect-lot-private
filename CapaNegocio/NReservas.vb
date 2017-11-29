Imports MySql.Data.MySqlClient

Public Class NReservas
    'metodo para crear una reserva
    Public Function insert(reservas As CapaDatos.DReservas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "INSERT INTO reserva (id_persona,fecha_reserva,fecha_fin,precio,id_lote_publico)" +
                        " VALUES (@id_persona,@fechaRe,@fechaFin,@precio,@id_lote)"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id_persona", reservas.IdPersona)
            comando.Parameters.AddWithValue("@fechaRe", reservas.FechaReserva)
            comando.Parameters.AddWithValue("@fechaFin", reservas.FechaVencimiento)
            comando.Parameters.AddWithValue("@precio", reservas.Precio)
            comando.Parameters.AddWithValue("@id_lote", reservas.IdLotePublico)

            comando.ExecuteNonQuery()
            MsgBox("Rerserva creada")
        Catch ex As Exception
            MsgBox("No se pudo realizar la reserva")
        End Try
    End Function


    'metodo para modificar una reserva
    Public Function update(reservas As CapaDatos.DReservas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "UPDATE reserva SET fecha_reserva = @fechaRe ,fecha_fin = @fechaFin " +
            ",precio = @precio ,id_lote_publico = @id_lote WHERE id_persona = @id_persona "

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id_persona", reservas.IdPersona)
            comando.Parameters.AddWithValue("@fechaRe", reservas.FechaReserva)
            comando.Parameters.AddWithValue("@fechaFin", reservas.FechaVencimiento)
            comando.Parameters.AddWithValue("@precio", reservas.Precio)
            comando.Parameters.AddWithValue("@id_lote", reservas.IdLotePublico)

            comando.ExecuteNonQuery()
            MsgBox("Rerserva modificada")
        Catch ex As Exception
            MsgBox("No se pudo modificar la reserva")
        End Try
    End Function


    'metodo para eliminar una reserva
    Public Function delete(reservas As CapaDatos.DReservas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_delete As String = "DELETE FROM reserva WHERE id_persona = @id"

        Try
            Dim comando As New MySqlCommand(cadena_delete, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", reservas.IdPersona)
            comando.ExecuteNonQuery()
            MsgBox("reserva eliminada")
        Catch ex As Exception
            MsgBox("No se pudo eliminar la reserva")
        End Try
    End Function


    'metodo para mostrar todas las reservas
    Public Function find() As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_reserva AS 'Nro de Reserva', id_persona AS 'Nro. de Persona' , fecha_reserva AS 'Fecha Inicio', " +
            "fecha_fin AS 'Fecha Fin' , precio AS Precio , id_lote_publico AS 'Lote Reservado' FROM reserva"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function


    'metodo para mostrar una sola reservas
    Public Function findById(reservas As CapaDatos.DReservas) As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_reserva AS 'Nro de Reserva', id_persona AS 'Nro. de Persona' , fecha_reserva AS 'Fecha Inicio', " +
            "fecha_fin AS 'Fecha Fin' , precio AS Precio , id_lote_publico AS 'Lote Reservado' FROM reserva WHERE id_persona = @id"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("@id", reservas.IdPersona)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function

    'metodo para saber si se encuentra disponible un lote a reservar

End Class
