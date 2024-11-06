Public Class FormMenu
    ReadOnly Correo = My.Settings.Correo
    ReadOnly TipoUsuario = My.Settings.TipoUsuario
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Info.Text = $"Usuario: {Correo.Split("@")(0)}"
        lbl_Privilegio.Text = $"Privilegio: {TipoUsuario}"
    End Sub
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        FormUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        FormInventario.Show()
        Me.Close()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        FormVentas.Show()
        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class