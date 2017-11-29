Public Class DLotePrivado
    Private _idLotePrivado As Integer
    Private _area As Double
    Private _precioAlquiler As Double

    Public Sub New()
    End Sub

    Public Sub New(_idLotePrivado As Integer, _area As Double, _precioAlquiler As Double)
        Me.IdLotePrivado = _idLotePrivado
        Me.Area = _area
        Me.PrecioAlquiler = _precioAlquiler
    End Sub

    Public Property IdLotePrivado As Integer
        Get
            Return _idLotePrivado
        End Get
        Set(value As Integer)
            _idLotePrivado = value
        End Set
    End Property

    Public Property Area As Double
        Get
            Return _area
        End Get
        Set(value As Double)
            _area = value
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


End Class
