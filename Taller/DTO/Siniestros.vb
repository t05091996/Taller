Public Class Siniestros
    Private _Rut As String
    Private _RutCompania As String
    Private _SiniestroID As Integer
    Private _Detalle As String
    Private _EstadoSiniestro As String
    Private _EstadoSeguro As String
    Private _FechaSiniestro As DateTime

    Public Property Rut As String
        Get
            Return _Rut
        End Get
        Set(value As String)
            _Rut = value
        End Set
    End Property

    Public Property RutCompania As String
        Get
            Return _RutCompania
        End Get
        Set(value As String)
            _RutCompania = value
        End Set
    End Property

    Public Property SiniestroID As Integer
        Get
            Return _SiniestroID
        End Get
        Set(value As Integer)
            _SiniestroID = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
        End Set
    End Property

    Public Property EstadoSiniestro As String
        Get
            Return _EstadoSiniestro
        End Get
        Set(value As String)
            _EstadoSiniestro = value
        End Set
    End Property

    Public Property EstadoSeguro As String
        Get
            Return _EstadoSeguro
        End Get
        Set(value As String)
            _EstadoSeguro = value
        End Set
    End Property

    Public Property FechaSiniestro As Date
        Get
            Return _FechaSiniestro
        End Get
        Set(value As Date)
            _FechaSiniestro = value
        End Set
    End Property
End Class
