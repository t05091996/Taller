Public Class Cliente
    Private _Rut As String
    Private _ApellidoP As String
    Private _ApellidoM As String
    Private _Nombre As String
    Private _Direccion As String
    Private _Comuna As String
    Private _Telefono As String

    Public Property Rut As String
        Get
            Return _Rut
        End Get
        Set(value As String)
            _Rut = value
        End Set
    End Property

    Public Property ApellidoP As String
        Get
            Return _ApellidoP
        End Get
        Set(value As String)
            _ApellidoP = value
        End Set
    End Property

    Public Property ApellidoM As String
        Get
            Return _ApellidoM
        End Get
        Set(value As String)
            _ApellidoM = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Comuna As String
        Get
            Return _Comuna
        End Get
        Set(value As String)
            _Comuna = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
End Class
