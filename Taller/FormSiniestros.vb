Public Class FormSiniestros
    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged
        Dim rut As String = txtRut.Text
        ValidarCliente(rut)
    End Sub
    Sub ValidarCliente(ByRef rut As String)
        If rut.Length > 8 Then
            Dim cliente As Cliente = GetClienteByRun(rut)
            If cliente.Nombre IsNot Nothing Then
                lblDatos.Text = $"Nombre: {cliente.Nombre} {cliente.ApellidoP} {cliente.ApellidoM}"
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FormBusquedaSiniestro.Show()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormMenu.Show()
        Me.Close()
    End Sub

    Private Sub FormSiniestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDatos.Text = String.Empty
        dtFecha.Value = Date.Now
        Dim lista = GetCompania()
        cbCompania.DataSource = lista
        cbCompania.ValueMember = “Rut”
        cbCompania.DisplayMember = “Descripcion”
    End Sub

    Public Function ValidarDatos()
        If cbSeguro.SelectedIndex > 0 Then

        End If
    End Function

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        If ValidarTxtComboDateTime(Me) Then
            Dim siniestro = New Siniestros With {
                            .Rut = txtRut.Text,
                            .RutCompania = cbCompania.SelectedValue,
                            .EstadoSeguro = cbSeguro.SelectedItem,
                            .EstadoSiniestro = cbSiniestro.SelectedItem,
                            .FechaSiniestro = dtFecha.Value,
                            .Detalle = txtDetalle.Text
                        }
            If CreateSiniestro(siniestro) Then
                MessageBox.Show("Se ha creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("NO se ha podido crear el siniestro", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub bnLimpiar_Click(sender As Object, e As EventArgs) Handles bnLimpiar.Click
        cbCompania.SelectedIndex = -1
        cbSeguro.SelectedIndex = -1
        cbSiniestro.SelectedIndex = -1
        txtDetalle.Clear()
        txtRut.Clear()
    End Sub

End Class