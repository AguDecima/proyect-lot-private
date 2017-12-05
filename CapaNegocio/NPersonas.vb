Imports MySql.Data.MySqlClient

Public Class NPersonas
    'metodo para crear una persona
    Public Function insert(personas As CapaDatos.DPersonas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "INSERT INTO personas (nombre,apellido,fecha_nacimiento,telefono,dni," +
            "id_lote_privado,is_propietario,is_habitante) VALUES (@id,@nombre,@apellido,@fecha,@tel,@dni,@id_lote,@prop,@hab)"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@nombre", personas.Nombre)
            comando.Parameters.AddWithValue("@apellido", personas.Apellido)
            comando.Parameters.AddWithValue("@fecha", personas.FechaNacimiento)
            comando.Parameters.AddWithValue("@tel", personas.Telefono)
            comando.Parameters.AddWithValue("@dni", personas.Dni)
            comando.Parameters.AddWithValue("@id_lote", personas.IdLotePrivado)
            comando.Parameters.AddWithValue("@prop", personas.IsPropietario)
            comando.Parameters.AddWithValue("@hab", personas.IsHabitante)

            comando.ExecuteNonQuery()
            MsgBox("Persona creada")
        Catch ex As Exception
            MsgBox("No se pudo crear la persona")
        End Try
    End Function


    'metodo para modificar una persona
    Public Function update(personas As CapaDatos.DPersonas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_update = "UPDATE personas SET nombre = @nombre ,apellido = @apellido ,fecha_nacimiento = @fecha" +
            ",telefono = @tel ,dni = @dni ,id_lote_privado = @id_lote ,is_propietario = @prop,is_habitante = @hab WHERE id_persona = @id"

        Try
            Dim comando As New MySqlCommand(cadena_update, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", personas.IdPersona)
            comando.Parameters.AddWithValue("@nombre", personas.Nombre)
            comando.Parameters.AddWithValue("@apellido", personas.Apellido)
            comando.Parameters.AddWithValue("@fecha", personas.FechaNacimiento)
            comando.Parameters.AddWithValue("@tel", personas.Telefono)
            comando.Parameters.AddWithValue("@dni", personas.Dni)
            comando.Parameters.AddWithValue("@id_lote", personas.IdLotePrivado)
            comando.Parameters.AddWithValue("@prop", personas.IsPropietario)
            comando.Parameters.AddWithValue("@hab", personas.IsHabitante)

            comando.ExecuteNonQuery()
            MsgBox("Persona modificada")
        Catch ex As Exception
            MsgBox("No se pudo modificar la persona")
        End Try
    End Function


    'metodo para eliminar una persona
    Public Function delete(personas As CapaDatos.DPersonas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_delete As String = "DELETE FROM personas WHERE id_persona = @id"

        Try
            Dim comando As New MySqlCommand(cadena_delete, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", personas.IdPersona)
            comando.ExecuteNonQuery()
            MsgBox("Persona eliminada")
        Catch ex As Exception
            MsgBox("No se pudo eliminar la persona")
        End Try
    End Function

    'metodo para mostrar todos los habitantes
    Public Function findHabitantes() As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_persona AS 'Nro. de Persona' , nombre AS Nombres , apellido AS Apellidos, telefono AS Telefono, " +
            " id_lote_privado AS 'Nro de Lote' FROM personas WHERE is_habitante = 1"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function

    'metodo para mostrar todos los propietarios
    Public Function findPropietarios() As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_persona AS 'Nro. de Persona' , nombre AS Nombres , apellido AS Apellidos, telefono AS Telefono," +
            "id_lote_privado AS 'Nro de Lote' FROM personas WHERE is_propietario = 1"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function

    'metodo para mostrar un habitante
    Public Function findByIdHabitantes(personas As CapaDatos.DPersonas) As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_persona AS 'Nro. de Persona' , nombre AS Nombres , apellido AS Apellidos, telefono AS Telefono, " +
            " id_lote_privado AS 'Nro de Lote' FROM personas WHERE id_persona = @id"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("@id", personas.IdPersona)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function

    'metodo para mostrar un propietario
    Public Function findByIdPropietarios(personas As CapaDatos.DPersonas) As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_persona AS 'Nro. de Persona' , nombre AS Nombres , apellido AS Apellidos, telefono AS Telefono, " +
            " id_lote_privado AS 'Nro de Lote' FROM personas WHERE is_propietario = 1 AND id_persona = @id"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("@id", personas.IdPersona)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function

    'metodo para mostrar los habitantes que viven en un lote
    Public Function findByIdHabitantesForLotes(personas As CapaDatos.DPersonas) As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_persona AS 'Nro. de Persona' , nombre AS Nombres , apellido AS Apellidos, telefono AS Telefono, " +
            " id_lote_privado AS 'Nro de Lote' FROM personas WHERE id_lote_privado = @id_lote"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("@id_lote", personas.IdLotePrivado)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function
End Class
