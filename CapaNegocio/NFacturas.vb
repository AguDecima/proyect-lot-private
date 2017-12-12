Imports MySql.Data.MySqlClient
Public Class NFacturas
    'metodo para calcular las expensas
    Public Function Expensas(servicio As CapaDatos.DServicios) As Double
        Dim cn As New Conexion
        Dim total As Double
        cn.conectar()
        Dim consulta = "SELECT SUM(monto) As total FROM servicio WHERE fecha_contratacion = @fecha AND id_persona = @id"

        Try
            Dim comando As New MySqlCommand(consulta, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", servicio.IdPersona)
            comando.Parameters.AddWithValue("@fecha", servicio.FechaContratacion)
            total = comando.ExecuteScalar()

            Return total
        Catch ex As Exception
            Return 0
        End Try

    End Function

    'calcular el precio del alquiler
    Public Function PrecioAlquiler(persona As CapaDatos.DPersonas) As Double
        Dim cn As New Conexion
        Dim precioLote As Double
        cn.conectar()

        Try
            Dim loteHabitante = "SELECT precio_alquiler FROM lote_privado WHERE id_lote_privado IN " +
            " (SELECT id_lote_privado FROM personas WHERE id_persona = @id_persona AND is_propietario <> 1)"
            Dim comando As New MySqlCommand(loteHabitante, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id_persona", persona.IdPersona)
            precioLote = comando.ExecuteScalar()

            Return precioLote
        Catch ex As Exception
            Return 0
        End Try


    End Function

    'verificar si aplica la bonificacion para las personas
    Public Function verificarBonificacion(persona As CapaDatos.DPersonas) As Integer
        Dim cn As New Conexion
        Dim idPersona As Integer
        cn.conectar()

        Try
            Dim bonificacion = "SELECT id_persona FROM reserva WHERE id_persona = @id_persona"
            Dim comando As New MySqlCommand(bonificacion, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id_persona", persona.IdPersona)
            idPersona = comando.ExecuteScalar()

            Return idPersona
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try

    End Function

    'verifico si existe la factura
    Public Function verificoFactura(factura As CapaDatos.DFacturas) As Integer
        Dim cn As New Conexion
        Dim isFactura As Integer
        cn.conectar()

        Try
            Dim existe_factura = "SELECT id_facturas FROM facturas WHERE id_facturas = @id "
            Dim comando As New MySqlCommand(existe_factura, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id", factura.IdPersona)
            isFactura = comando.ExecuteScalar
            Return isFactura
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try

    End Function

    'calculo del total que debe pagar
    Public Function calcularTotal(factura As CapaDatos.DFacturas) As Double
        Dim total As Double = 0
        Dim bonificacion As Double = 0

        If factura.Bonificacion = True Then
            bonificacion = 0.5
        End If

        total = factura.PrecioExpensas + factura.PrecioAlquiler - (factura.PrecioExpensas * bonificacion)

        Return total
    End Function

    'metodo para insertar una factura
    Public Function insert(factura As CapaDatos.DFacturas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "INSERT INTO facturas (id_facturas,id_persona,precio_alquiler,precio_expensas," +
            "fecha_expensa,fecha_vencimiento,bonificacion,expensa_pagada,total_pagar) VALUES ( @id_factura," +
            "@id_persona,@precioAlq, @precioExp, @fechaExp , @fechaVen , @bonificacion , @expensaPagada, @total)"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id_factura", factura.IdFacturas)
            comando.Parameters.AddWithValue("@id_persona", factura.IdPersona)
            comando.Parameters.AddWithValue("@precioAlq", factura.PrecioAlquiler)
            comando.Parameters.AddWithValue("@precioExp", factura.PrecioExpensas)
            comando.Parameters.AddWithValue("@fechaExp", factura.Fecha)
            comando.Parameters.AddWithValue("@fechaVen", factura.FechaVencimiento)
            comando.Parameters.AddWithValue("@bonificacion", factura.Bonificacion)
            comando.Parameters.AddWithValue("@expensaPagada", factura.ExpensaPagada)
            comando.Parameters.AddWithValue("@total", factura.TotalPagar)

            comando.ExecuteNonQuery()
            MsgBox("Factura creada")
        Catch ex As Exception
            MsgBox("No se pudo realizar la factura")
        End Try
    End Function
    'metodo para modificar una factura
    Public Function update(factura As CapaDatos.DFacturas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "UPDATE facturas SET id_persona = @id_persona , precio_alquiler = @precioAlq," +
            "precio_expensas = @fechaExp, fecha_expensa = @fechaExp, fecha_vencimiento = @fechaVen, bonificacion = @bonificacion," +
            "expensa_pagada = @expensaPagada, total_pagar = @total WHERE id_facturas = @id_factura"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id_factura", factura.IdFacturas)
            comando.Parameters.AddWithValue("@id_persona", factura.IdPersona)
            comando.Parameters.AddWithValue("@precioAlq", factura.PrecioAlquiler)
            comando.Parameters.AddWithValue("@precioExp", factura.PrecioExpensas)
            comando.Parameters.AddWithValue("@fechaExp", factura.Fecha)
            comando.Parameters.AddWithValue("@fechaVen", factura.FechaVencimiento)
            comando.Parameters.AddWithValue("@bonificacion", factura.Bonificacion)
            comando.Parameters.AddWithValue("@expensaPagada", factura.ExpensaPagada)
            comando.Parameters.AddWithValue("@total", factura.TotalPagar)

            comando.ExecuteNonQuery()
            MsgBox("Factura modificada")
        Catch ex As Exception
            MsgBox("No se pudo modifica la factura")
        End Try
    End Function
    'metodo para eliminar una factura
    Public Function delete(factura As CapaDatos.DFacturas)
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_insert = "DELETE FROM facturas WHERE id_factura = @id_factura"

        Try
            Dim comando As New MySqlCommand(cadena_insert, cn.MySqlConexion)
            comando.Parameters.AddWithValue("@id_factura", factura.IdFacturas)

            comando.ExecuteNonQuery()
            MsgBox("Factura creada")
        Catch ex As Exception
            MsgBox("No se pudo realizar la factura")
        End Try

    End Function
    'metodo para buscar todas las facturas
    Public Function findAll() As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_facturas AS 'Nro Factura', id_persona AS 'Nro Persona', precio_alquiler AS 'Precio Alquiler'," +
            "precio_expensas AS 'Precio Expensas', total_pagar AS 'Monto Total', fecha_expensa AS 'Fecha Contratacion', bonificacion AS Bonificacion," +
            "fecha_vencimiento AS 'Fecha Vencimiento', expensa_pagada AS 'Condicion de Pago' FROM facturas"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable


    End Function

    'metodo para buscar una factura por su numero
    Public Function findById(factura As CapaDatos.DFacturas) As DataTable
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_facturas AS 'Nro Factura', id_persona AS 'Nro Persona', total_pagar AS 'Monto Total'," +
            "fecha_vencimiento AS 'Fecha Vencimiento', expensa_pagada AS 'Condicion de Pago' FROM facturas WHERE id_facturas = @id_factura"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("@id_factura", factura.IdFacturas)

        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Return dataTable
    End Function

    'metodo para los reportes
    Public Function findByIdReportes(factura As CapaDatos.DFacturas) As DataSet
        Dim cn As New Conexion
        cn.conectar()
        Dim cadena_find As String = "SELECT id_persona AS 'Nro Persona', precio_alquiler AS 'Precio Alquiler'," +
            "precio_expensas AS 'Precio Expensas', total_pagar AS 'Monto Total', fecha_vencimiento AS 'Fecha Vencimiento' FROM facturas WHERE id_facturas = @id_factura"

        Dim comando As New MySqlCommand(cadena_find, cn.MySqlConexion)
        comando.Parameters.AddWithValue("@id_factura", factura.IdFacturas)

        Dim dataAdapter As New MySqlDataAdapter(comando)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet)

        Return dataSet
    End Function

End Class
