Public Class VentaRepuestos
    Private _VentaID As Integer
    Private _NombreRepuesto As String
    Private _CantidadVendida As Integer
    Private _Cliente As String
    Private _FechaVenta As DateTime
    Private _Total As Integer

    Public Property VentaID As Integer
        Get
            Return _VentaID
        End Get
        Set(value As Integer)
            _VentaID = value
        End Set
    End Property

    Public Property NombreRepuesto As String
        Get
            Return _NombreRepuesto
        End Get
        Set(value As String)
            _NombreRepuesto = value
        End Set
    End Property

    Public Property CantidadVendida As Integer
        Get
            Return _CantidadVendida
        End Get
        Set(value As Integer)
            _CantidadVendida = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
        End Set
    End Property

    Public Property FechaVenta As DateTime
        Get
            Return _FechaVenta
        End Get
        Set(value As DateTime)
            _FechaVenta = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _Total
        End Get
        Set(value As Integer)
            _Total = value
        End Set
    End Property
End Class
