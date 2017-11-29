Imports MySql.Data.MySqlClient

Public Class Conexion
    'creamos la cadena de conecxion y la variable que hara la conexion con la base de datos
    Public MysqlConnString As String = "Server=localhost; Database=barrio_privado; Uid=root; Pwd="
    Public MySqlConexion As New MySqlConnection(MysqlConnString)

    'creamos un subproceso para llamar desde otras clases y hacer la conexion
    Public Sub conectar()
        Try
            MySqlConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
