Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connectionString As String = "Server=localhost;Database=taller;User ID='root';Password='';"

    Public Function VerificarUsuario(RUT As String, PASS As String) As Boolean
        Dim aprobado = False
        Using conexion As New MySqlConnection(connectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM usuarios WHERE Rut= @RUT AND Contraseña=@pass"
                Dim cmd As New MySqlCommand(query, conexion)
                'cmd.Connection = conexion
                cmd.Parameters.AddWithValue("@RUT", RUT)
                cmd.Parameters.AddWithValue("@pass", PASS)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    aprobado = True
                    My.Settings.Run = RUT
                    My.Settings.TipoUsuario = Convert.ToString(resultado("Tipo"))
                    My.Settings.Correo = Convert.ToString(resultado("Correo"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using

        Return aprobado
    End Function

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim rut As String = txtRut.Text
        Dim pass As String = txtPass.Text
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe ingresar su RUT y CONTRASEÑA!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim usuario As Boolean = VerificarUsuario(rut, pass)
        If usuario Then
            Dim Principal As Form2 = New Form2()
            Principal.Show()
            My.Forms.Form1.Dispose()
        Else
            MessageBox.Show("Usuario no existe!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRut.Clear()
            txtPass.Clear()
        End If
    End Sub

End Class
