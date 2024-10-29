Public Class ModeloCombo
    Private _RepuestoID As String
    Private _NombreRepuesto As String

    Public Property RepuestoID As String
        Get
            Return _RepuestoID
        End Get
        Set(value As String)
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
End Class
