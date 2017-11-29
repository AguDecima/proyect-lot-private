Imports MySql.Data.MySqlClient

Public Class NServicios
    'metodo para crear un servicio
    Public Function insert(servicio As CapaDatos.DServicios)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "INSERT INTO servicio (id_servicio,id_persona,nombre,empresa,fecha_contratacion,monto)" +
                        " VALUES (@id_servicio,@id_persona,@nombre,@empresa,@fechaCon,@precio)"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("id_servicio", servicio.IdServicios)
            comando.Parameters.AddWithValue("@id_persona", servicio.IdPersona)
            comando.Parameters.AddWithValue("@nombre", servicio.Nombre)
            comando.Parameters.AddWithValue("@empresa", servicio.Empresa)
            comando.Parameters.AddWithValue("@fechaCon", servicio.FechaContratacion)
            comando.Parameters.AddWithValue("@precio", servicio.Precio)

            comando.ExecuteNonQuery()
            MsgBox("Servicio creado")
        Catch ex As Exception
            MsgBox("No se pudo realizar el servicio")
        End Try
    End Function


    'metodo para modificar un servicio
    Public Function update(servicio As CapaDatos.DServicios)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "UPDATE servicio SET id_persona = @id_persona ,nombre = @nombre ,empresa = @empresa," +
            "fecha_contratacion = @fechaCon ,monto = @precio WHERE id_servicio = @id_servicio"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("id_servicio", servicio.IdServicios)
            comando.Parameters.AddWithValue("@id_persona", servicio.IdPersona)
            comando.Parameters.AddWithValue("@nombre", servicio.Nombre)
            comando.Parameters.AddWithValue("@empresa", servicio.Empresa)
            comando.Parameters.AddWithValue("@fechaCon", servicio.FechaContratacion)
            comando.Parameters.AddWithValue("@precio", servicio.Precio)

            comando.ExecuteNonQuery()
            MsgBox("Servicio modificado")
        Catch ex As Exception
            MsgBox("No se pudo modificar el servicio")
        End Try
    End Function


    'metodo para eliminar un servicio
    Public Function delete(servicio As CapaDatos.DServicios)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_delete As String = "DELETE FROM servicio WHERE id_servicio = @id"

        Try
            Dim comando As New MySqlCommand(cadena_delete, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", servicio.IdServicios)
            comando.ExecuteNonQuery()
            MsgBox("Servicio eliminado")
        Catch ex As Exception
            MsgBox("No se pudo eliminar el servicio")
        End Try
    End Function


    'metodo para mostrar todos los servicios
    Public Function find() As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_servicio AS 'Nro de Servicio', id_persona AS 'Nro de Persona', nombre AS 'Servicio'," +
            " fecha_contratacion AS 'Fecha Contratacion', monto AS Precio FROM servicio"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function


    'metodo para mostrar todos los servicios
    Public Function findById(servicio As CapaDatos.DServicios) As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_servicio AS 'Nro de Servicio', id_persona AS 'Nro de Persona', nombre AS 'Servicio'," +
            " fecha_contratacion AS 'Fecha Contratacion', monto AS Precio FROM servicio WHERE id_servicio = @id_servicio"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("id_servicio", servicio.IdServicios)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function


End Class
