Public Class FormLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim rut As String = txtRut.Text
        Dim pass As String = txtPass.Text

        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe ingresar su RUT y CONTRASEÑA!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrWhiteSpace(pass) Then
            MessageBox.Show("Por favor, ingrese su Contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim usuario As Boolean = VerificarUsuario(rut, pass)

        If usuario Then
            Dim Principal As New FormMenu()
            Principal.Show()
            Me.Close()
        Else
            MessageBox.Show("Usuario no existe!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRut.Clear()
            txtPass.Clear()
        End If

    End Sub

End Class
