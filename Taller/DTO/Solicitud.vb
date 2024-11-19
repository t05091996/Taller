Public Class Solicitud
    Private _SolicitudID As Integer
    Private _Rut As String
    Private _FechaSolicitud As DateTime
    Private _DescripcionProblema As String
    Private _Estado As String
    Private _Siniestroid As Integer
    Private _RutEmpleado As String

    Public Property SolicitudID As Integer
        Get
            Return _SolicitudID
        End Get
        Set(value As Integer)
            _SolicitudID = value
        End Set
    End Property

    Public Property Rut As String
        Get
            Return _Rut
        End Get
        Set(value As String)
            _Rut = value
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

    Public Property Siniestroid As Integer
        Get
            Return _Siniestroid
        End Get
        Set(value As Integer)
            _Siniestroid = value
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
