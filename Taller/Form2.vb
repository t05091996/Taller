Public Class Form2
    Dim TipoUsuario = My.Settings.TipoUsuario
    Dim Correo = My.Settings.Correo
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Info.Text = $"Usuario: {Correo.Split("@")(0)}"
        lbl_Privilegio.Text = $"Privilegio: {TipoUsuario}"
    End Sub
End Class