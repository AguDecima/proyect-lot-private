Imports MySql.Data.MySqlClient
Public Class NLotePrivado
    'metodo para crear un lote privado
    Public Function insert(lotePrivado As CapaDatos.DLotePrivado)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "INSERT INTO lote_privado (id_lote_privado,area,precio_alquiler) VALUES (@id,@area,@precio_alquiler)"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", lotePrivado.IdLotePrivado)
            comando.Parameters.AddWithValue("@area", lotePrivado.Area)
            comando.Parameters.AddWithValue("@precio_alquiler", lotePrivado.PrecioAlquiler)
            comando.ExecuteNonQuery()
            MsgBox("Datos creados")
        Catch ex As Exception
            MsgBox("No se pudieron guardar los datos")
        End Try
    End Function


    'metodo para modificar un lote privado
    Public Function update(lotePrivado As CapaDatos.DLotePrivado)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_update = "UPDATE lote_privado SET area = @area , precio_alquiler = @precio WHERE id_lote_privado = @id"

        Try
            Dim comando As New MySqlCommand(cadena_update, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", lotePrivado.IdLotePrivado)
            comando.Parameters.AddWithValue("@area", lotePrivado.Area)
            comando.Parameters.AddWithValue("@precio", lotePrivado.PrecioAlquiler)
            comando.ExecuteNonQuery()
            MsgBox("Datos  actualizados")
        Catch ex As Exception
            MsgBox("No se pudieron actualizar los datos")
        End Try
    End Function


    'metodo para eliminar un lote privado
    Public Function delete(lotePrivado As CapaDatos.DLotePrivado)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_delete As String = "DELETE FROM lote_privado WHERE id_lote_privado = @id"

        Try
            Dim comando As New MySqlCommand(cadena_delete, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", lotePrivado.IdLotePrivado)
            comando.ExecuteNonQuery()
            MsgBox("Lote Eliminado")
        Catch ex As Exception
            MsgBox("No se pudo eliminar el Lote")
        End Try

    End Function


    'metodo para mostrar todos los lotes privados
    Public Function find() As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_lote_privado AS 'Nro de Lote', area AS 'Area del Lote' , precio_alquiler AS Precio FROM lote_privado"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable

    End Function


    'metodo para mostrar un solo lote privado
    Public Function findById(lotePrivado As CapaDatos.DLotePrivado) As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_lote_privado AS 'Nro de Lote', area AS 'Area del Lote' , precio_alquiler AS Precio FROM lote_privado WHERE id_lote_privado = @id"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("@id", lotePrivado.IdLotePrivado)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function
End Class
