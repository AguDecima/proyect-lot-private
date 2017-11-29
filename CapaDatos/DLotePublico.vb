Public Class DLotePublico
    Private _idLotePublico As Integer
    Private _nombre As String
    Private _disponible As Boolean

    Public Sub New()
    End Sub

    Public Sub New(_idLotePublico As Integer, _nombre As String, _disponible As Boolean)
        Me.IdLotePublico = _idLotePublico
        Me.Nombre = _nombre
        Me.Disponible = _disponible
    End Sub

    Public Property IdLotePublico As Integer
        Get
            Return _idLotePublico
        End Get
        Set(value As Integer)
            _idLotePublico = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Disponible As Boolean
        Get
            Return _disponible
        End Get
        Set(value As Boolean)
            _disponible = value
        End Set
    End Property


End Class
