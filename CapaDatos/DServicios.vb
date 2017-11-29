Public Class DServicios
    Private _idServicios As Integer
    Private _idPersona As Integer
    Private _nombre As String
    Private _empresa As String
    Private _fechaContratacion As Date
    Private _precio As Double

    Public Sub New()
    End Sub

    Public Sub New(_idServicios As Integer, _idPersona As Integer, _nombre As String, _empresa As String, _fechaContratacion As Date, _precio As Double)
        Me.IdServicios = _idServicios
        Me.IdPersona = _idPersona
        Me.Nombre = _nombre
        Me.Empresa = _empresa
        Me.FechaContratacion = _fechaContratacion
        Me.Precio = _precio
    End Sub

    Public Property IdServicios As Integer
        Get
            Return _idServicios
        End Get
        Set(value As Integer)
            _idServicios = value
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

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Empresa As String
        Get
            Return _empresa
        End Get
        Set(value As String)
            _empresa = value
        End Set
    End Property

    Public Property FechaContratacion As Date
        Get
            Return _fechaContratacion
        End Get
        Set(value As Date)
            _fechaContratacion = value
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


End Class
