Public Class FormSiniestros
    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged
        Dim rut As String = txtRut.Text
        ValidarCliente(rut)
    End Sub
    Sub ValidarCliente(ByRef rut As String)
        If rut.Length > 8 Then
            Dim cliente As Cliente = GetClienteByRun(rut)
            If cliente.Nombre IsNot Nothing Then
                lblDatos.Text = $"Rut: {cliente.Rut}" & vbNewLine & $"Nombre: {cliente.Nombre}" & vbNewLine & $"{cliente.ApellidoP} {cliente.ApellidoM}"
            Else
                Dim msj As Integer = MessageBox.Show("Cliente NO EXISTE!, Desea crearlo?", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msj = vbOK Then
                    FormClientes.Show()
                End If
            End If
        Else
            lblDatos.Text = String.Empty
        End If
    End Sub

    Private Sub txtRutC_TextChanged(sender As Object, e As EventArgs) Handles txtRutC.TextChanged
        If txtRutC.Text.Length > 0 Then
            Dim id As Integer = Convert.ToInt32(txtRutC.Text)
            Dim producto As Repuestos = GetProductoByID(id)
            lblDatosRepuestos.Text = $"Item: {producto.NombreRepuesto}" & vbNewLine & $"Disponible: {producto.Stock} unidades" & vbNewLine & $"Precio: $ {producto.Precio}" & vbNewLine & $"Proveedor: {producto.Proveedor}"
            txtRutC.Text = producto.NombreRepuesto
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FormBusquedaSiniestro.Show()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormMenu.Show()
        Me.Close()
    End Sub
End Class