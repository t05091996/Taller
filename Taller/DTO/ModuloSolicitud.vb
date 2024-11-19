Public Class ModuloSolicitud
    'cliente
    Private _RutCliente As String
    Private _NombreCliente As String
    'compañia
    Private _RutCompania As String
    Private _NombreCompania As String
    'siniestro
    Private _SiniestroID As Integer
    Private _Detalle As String
    Private _EstadoSiniestro As String
    Private _EstadoSeguro As String
    Private _FechaSiniestro As DateTime
    'solicitud
    Private _SolicitudID As Integer
    Private _FechaSolicitud As DateTime
    Private _DescripcionProblema As String
    Private _Estado As String
    Private _RutEmpleado As String

    Public Property RutCliente As String
        Get
            Return _RutCliente
        End Get
        Set(value As String)
            _RutCliente = value
        End Set
    End Property

    Public Property NombreCliente As String
        Get
            Return _NombreCliente
        End Get
        Set(value As String)
            _NombreCliente = value
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

    Public Property NombreCompania As String
        Get
            Return _NombreCompania
        End Get
        Set(value As String)
            _NombreCompania = value
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

    Public Property SolicitudID As Integer
        Get
            Return _SolicitudID
        End Get
        Set(value As Integer)
            _SolicitudID = value
        End Set
    End Property

    Public Property FechaSolicitud As Date
        Get
            Return _FechaSolicitud
        End Get
        Set(value As Date)
            _FechaSolicitud = value
        End Set
    End Property

    Public Property DescripcionProblema As String
        Get
            Return _DescripcionProblema
        End Get
        Set(value As String)
            _DescripcionProblema = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

    Public Property RutEmpleado As String
        Get
            Return _RutEmpleado
        End Get
        Set(value As String)
            _RutEmpleado = value
        End Set
    End Property
End Class
