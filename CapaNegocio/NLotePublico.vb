Imports MySql.Data.MySqlClient

Public Class NLotePublico
    'metodo para crear un lote publico
    Public Function insert(lotePublico As CapaDatos.DLotePublico)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "INSERT INTO lote_publico (id_lote_publico,nombre,disponible) VALUES (@id,@area,@disponible)"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", lotePublico.IdLotePublico)
            comando.Parameters.AddWithValue("@area", lotePublico.Nombre)
            comando.Parameters.AddWithValue("@disponible", lotePublico.Disponible)
            comando.ExecuteNonQuery()
            MsgBox("Lote publico creado")
        Catch ex As Exception
            MsgBox("No se pudo crear el lote")
        End Try
    End Function


    'metodo para modificar un lote publico
    Public Function update(lotePublico As CapaDatos.DLotePublico)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_update = "UPDATE lote_publico SET nombre = @nombre , disponible = @disponible WHERE id_lote_publico = @id"

        Try
            Dim comando As New MySqlCommand(cadena_update, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", lotePublico.IdLotePublico)
            comando.Parameters.AddWithValue("@nombre", lotePublico.Nombre)
            comando.Parameters.AddWithValue("@disponible", lotePublico.Disponible)
            comando.ExecuteNonQuery()
            MsgBox("Lote Publico modificado")
        Catch ex As Exception
            MsgBox("No se pudo modificar el lote")
        End Try
    End Function


    'metodo para eliminar un lote publico
    Public Function delete(lotePublico As CapaDatos.DLotePublico)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_delete As String = "DELETE FROM lote_publico WHERE id_lote_publico = @id"

        Try
            Dim comando As New MySqlCommand(cadena_delete, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", lotePublico.IdLotePublico)
            comando.ExecuteNonQuery()
            MsgBox("Lote Eliminado")
        Catch ex As Exception
            MsgBox("No se pudo eliminar el Lote")
        End Try
    End Function


    'metodo para mostrar todos los lotes publico
    Public Function Find() As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_lote_publico AS 'Nro. de Lote' , nombre AS Nombre , disponible AS Disponibilidad FROM lote_publico"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function


    'metodo para mostrar un solo lote publico
    Public Function FindById(lotePublico As CapaDatos.DLotePublico) As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_lote_publico AS 'Nro. de Lote' , nombre AS Nombre , disponible AS Disponibilidad FROM lote_publico WHERE id_lote_publico = @id"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("@id", lotePublico.IdLotePublico)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function
End Class
