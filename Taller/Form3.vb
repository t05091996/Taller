Imports MySql.Data.MySqlClient
Public Class Form3
    Dim connectionString As String = "Server=localhost;Database=taller;User ID='root';Password='';"
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim rut As String = txtRut.Text
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe escribir un RUT, antes de realizar una búsqueda!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim aprobado As  = VerificarUsuario(rut)
        If Not String.IsNullOrWhiteSpace(persona.RUT) Then
            txtRut.Text = .RUT
            txtCorreo.Text = .Correo
            txtContraseña.Text = .Contraseña
            txtTipo.Text = .Tipo
            End Select

        Else
            Dim respuesta As Int32 = MessageBox.Show("¿Desea registrarse?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If respuesta = vbYes Then
                LimpiarI()
            End If

            Return

        End If


    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim rut As String = txtRut.Text
        Dim correo As String = txtCorreo.Text
        Dim contraseña As String = txtContraseña.Text
        Dim tipo As String = txtTipo.Text
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conexion As New MySqlConnection(connectionString)
            Try
                conexion.Open()
                Dim query As String = "UPDATE usuarios SET correo=@correo, contraseña=@contraseña, tipo=@tipo" &
                                    "WHERE RUT= @rut"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", rut)
                cmd.Parameters.AddWithValue("@correo", correo)
                cmd.Parameters.AddWithValue("@contraseña", contraseña)
                cmd.Parameters.AddWithValue("@tipo", tipo)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Datos actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Limpiar()

    End Sub
End Class