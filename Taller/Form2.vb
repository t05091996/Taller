Public Class Form2
    ReadOnly Correo = My.Settings.Correo
    ReadOnly TipoUsuario = My.Settings.TipoUsuario
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Info.Text = $"Usuario: {Correo.Split("@")(0)}"
        lbl_Privilegio.Text = $"Privilegio: {TipoUsuario}"
    End Sub
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Form4.Show()
        Me.Close()
    End Sub
End Class