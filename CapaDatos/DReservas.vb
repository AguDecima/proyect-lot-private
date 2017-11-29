Public Class DReservas
    Private _idReserva As Integer
    Private _idPersona As Integer
    Private _fechaReserva As Date
    Private _fechaVencimiento As Date
    Private _precio As Double
    Private _idLotePublico As Integer

    Public Sub New()

    End Sub

    Public Sub New(_idPersona As Integer, _fechaReserva As Date, _fechaVencimiento As Date,
                   _precio As Double, _idLotePublico As Integer)
        Me.IdPersona = _idPersona
        Me.FechaReserva = _fechaReserva
        Me.FechaVencimiento = _fechaVencimiento
        Me.Precio = _precio
        Me.IdLotePublico = _idLotePublico
    End Sub

    Public Property IdReserva As Integer
        Get
            Return _idReserva
        End Get
        Set(value As Integer)
            _idReserva = value
        End Set
    End Property

    Public Property IdPersona As Integer
        Get
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
        End Set
    End Property

    Public Property FechaReserva As Date
        Get
            Return _fechaReserva
        End Get
        Set(value As Date)
            _fechaReserva = value
        End Set
    End Property

    Public Property FechaVencimiento As Date
        Get
            Return _fechaVencimiento
        End Get
        Set(value As Date)
            _fechaVencimiento = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property IdLotePublico As Integer
        Get
            Return _idLotePublico
        End Get
        Set(value As Integer)
            _idLotePublico = value
        End Set
    End Property


End Class
