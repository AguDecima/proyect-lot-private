Public Class DPersonas
    Private _idPersona As Integer
    Private _nombre As String
    Private _apellido As String
    Private _fechaNacimiento As Date
    Private _dni As String
    Private _telefono As String
    Private _idLotePrivado As Integer
    Private _isPropietario As Boolean
    Private _isHabitante As Boolean

    Public Sub New()
    End Sub

    Public Sub New(_idPersona As Integer, _nombre As String, _apellido As String, _fechaNacimiento As Date,
                   _dni As String, _telefono As String, _idLotePrivado As Integer, _isPropietario As Boolean,
                   _isHabitante As Boolean)
        Me.IdPersona = _idPersona
        Me.Nombre = _nombre
        Me.Apellido = _apellido
        Me.FechaNacimiento = _fechaNacimiento
        Me.Dni = _dni
        Me.Telefono = _telefono
        Me.IdLotePrivado = _idLotePrivado
        Me.IsPropietario = _isPropietario
        Me.IsHabitante = _isHabitante
    End Sub

    Public Property IdPersona As Integer
        Get
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
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

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property IdLotePrivado As Integer
        Get
            Return _idLotePrivado
        End Get
        Set(value As Integer)
            _idLotePrivado = value
        End Set
    End Property

    Public Property IsPropietario As Boolean
        Get
            Return _isPropietario
        End Get
        Set(value As Boolean)
            _isPropietario = value
        End Set
    End Property

    Public Property IsHabitante As Boolean
        Get
            Return _isHabitante
        End Get
        Set(value As Boolean)
            _isHabitante = value
        End Set
    End Property

End Class
