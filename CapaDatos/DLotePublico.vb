Public Class DLotePublico
    Private _idLotePublico As Integer
    Private _nombre As String

    Public Sub New()
    End Sub

    Public Sub New(_idLotePublico As Integer, _nombre As String)
        Me.IdLotePublico = _idLotePublico
        Me.Nombre = _nombre
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

End Class
