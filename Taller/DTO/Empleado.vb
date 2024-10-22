Public Class Empleado
    Private _rut As String
    Private _nombre As String
    Private _cargo As String
    Private _apellidoP As String
    Private _apellidoM As String
    Private _direccion As String
    Private _telefono As String
    Private _comuna As String

    Public Property Rut As String
        Get
            Return _rut
        End Get
        Set(value As String)
            _rut = value
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

    Public Property Cargo As String
        Get
            Return _cargo
        End Get
        Set(value As String)
            _cargo = value
        End Set
    End Property

    Public Property ApellidoM As String
        Get
            Return _apellidoM
        End Get
        Set(value As String)
            _apellidoM = value
        End Set
    End Property

    Public Property ApellidoP As String
        Get
            Return _apellidoP
        End Get
        Set(value As String)
            _apellidoP = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
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

    Public Property Comuna As String
        Get
            Return _comuna
        End Get
        Set(value As String)
            _comuna = value
        End Set
    End Property
End Class
