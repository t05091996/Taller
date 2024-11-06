Public Class FormResumen
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim filtro As New Filtros With {
            .Rut = txtRut.Text,
            .Nombre = txtRepuesto.Text,
            .FechaD = txtFecha.Value
        }
        Dim listado As List(Of VentaRepuestos) = GetVentaRepuestosFilter(filtro)

        dgvResumen.DataSource = Nothing
        dgvResumen.DataSource = listado
    End Sub

    Private Sub FormResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Value = Date.Now
    End Sub
End Class