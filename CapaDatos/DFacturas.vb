Public Class DFacturas
    Private _idFacturas As Integer
    Private _idPersona As Integer
    Private _precioAlquiler As Double
    Private _precioExpensas As Double
    Private _fecha As Date
    Private _fechaVencimiento As Date
    Private _bonificacion As Boolean
    Private _expensaPagada As Boolean
    Private _totalPagar As Double

    Public Sub New()

    End Sub

    Public Sub New(_idFacturas As Integer, _idPersona As Integer, _precioAlquiler As Double, _precioExpensas As Double, _fecha As Date, _fechaVencimiento As Date, _bonificacion As Boolean, _expensaPagada As Boolean, _totalPagar As Double)
        Me.IdFacturas = _idFacturas
        Me.IdPersona = _idPersona
        Me.PrecioAlquiler = _precioAlquiler
        Me.PrecioExpensas = _precioExpensas
        Me.Fecha = _fecha
        Me.FechaVencimiento = _fechaVencimiento
        Me.Bonificacion = _bonificacion
        Me.ExpensaPagada = _expensaPagada
        Me.TotalPagar = _totalPagar
    End Sub

    Public Property IdFacturas As Integer
        Get
            Return _idFacturas
        End Get
        Set(value As Integer)
            _idFacturas = value
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

    Public Property PrecioAlquiler As Double
        Get
            Return _precioAlquiler
        End Get
        Set(value As Double)
            _precioAlquiler = value
        End Set
    End Property

    Public Property PrecioExpensas As Double
        Get
            Return _precioExpensas
        End Get
        Set(value As Double)
            _precioExpensas = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
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

    Public Property Bonificacion As Boolean
        Get
            Return _bonificacion
        End Get
        Set(value As Boolean)
            _bonificacion = value
        End Set
    End Property

    Public Property ExpensaPagada As Boolean
        Get
            Return _expensaPagada
        End Get
        Set(value As Boolean)
            _expensaPagada = value
        End Set
    End Property

    Public Property TotalPagar As Double
        Get
            Return _totalPagar
        End Get
        Set(value As Double)
            _totalPagar = value
        End Set
    End Property

End Class
