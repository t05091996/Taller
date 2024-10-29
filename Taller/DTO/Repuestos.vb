Public Class Repuestos
    Private _RepuestoID As Int32
    Private _NombreRepuesto As String
    Private _Stock As Int32
    Private _Precio As Decimal
    Private _Proveedor As String

    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            _Stock = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _Precio
        End Get
        Set(value As Decimal)
            _Precio = value
        End Set
    End Property

    Public Property RepuestoID As Integer
        Get
            Return _RepuestoID
        End Get
        Set(value As Integer)
            _RepuestoID = value
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

    Public Property Proveedor As String
        Get
            Return _Proveedor
        End Get
        Set(value As String)
            _Proveedor = value
        End Set
    End Property
End Class
