Public Class FormResumen
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim filtro As New Filtros With {
            .Rut = txtRut.Text,
            .Nombre = txtRepuesto.Text,
            .FechaD = txtFechaD.Value,
            .FechaH = txtFechaH.Value
        }

        Dim listado As List(Of VentaRepuestos) = GetVentaRepuestosFilter(filtro)

        dgvResumen.Rows.Clear()
        For i As Integer = 0 To listado.Count - 1
            'Venta, Fecha, Cliente, Articulo,Cantidad, Total
            dgvResumen.Rows.Add(listado(i).VentaID, listado(i).FechaVenta, listado(i).Cliente, listado(i).NombreRepuesto, listado(i).CantidadVendida, listado(i).Total)
        Next
    End Sub

    Private Sub FormResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaD.Value = Date.Now.AddYears(-1)
        txtFechaH.Value = Date.Now
    End Sub
End Class