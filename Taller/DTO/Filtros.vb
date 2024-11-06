Public Class Filtros
    Private _Rut As String
    Private _nombre As String
    Private _fechaD As Date

    Public Property FechaD As Date
        Get
            Return _fechaD
        End Get
        Set(value As Date)
            _fechaD = value
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

    Public Property Rut As String
        Get
            Return _Rut
        End Get
        Set(value As String)
            _Rut = value
        End Set
    End Property
End Class
