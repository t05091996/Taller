Public Class Form3

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim rut As String = txtRut.Text
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe escribir un RUT, antes de realizar una búsqueda!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim usuario As Usuario = GetUsuariosByRun(rut)
            If (Not String.IsNullOrEmpty(usuario.Rut)) Then
                txtCorreo.Text = usuario.Correo
                txtContrasena.Text = usuario.Contrasena
                txtTipo.Text = usuario.Tipo
            Else
                MessageBox.Show("El usuario ingresado NO existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim rut As String = txtRut.Text
        Dim correo As String = txtCorreo.Text
        Dim contrasena As String = txtContrasena.Text
        Dim tipo As String = txtTipo.Text
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(correo) Or String.IsNullOrWhiteSpace(contrasena) Or String.IsNullOrWhiteSpace(tipo) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim existe As Usuario = GetUsuariosByRun(rut)
            If Not String.IsNullOrEmpty(existe.Rut) Then
                Dim usuario As New Usuario With {
                    .Rut = rut,
                    .Correo = correo,
                    .Contrasena = contrasena,
                    .Tipo = tipo
                }
                Dim update As Boolean = UpdateUsuario(usuario)
                If update Then
                    MessageBox.Show("Usuario Actualizado Correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Return
                End If
            Else
                MessageBox.Show("El usuario que desea modificar, no existe.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
        MessageBox.Show("Ha Ocurrido un Error intentelo más tarde.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim rut As String = txtRut.Text
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe escribir un RUT para eliminar un usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim usuario As Usuario = GetUsuariosByRun(rut)
            If (Not String.IsNullOrEmpty(usuario.Rut)) Then
                Dim respuesta As Int32 = MessageBox.Show("¿Realmente Desea eliminar al usuario?, esta acción no se puede revertir",
                                                         "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If respuesta = vbYes Then
                    Dim delete As Boolean = DeleteUsuario(rut)
                    If delete Then
                        MessageBox.Show("Usuario eliminado correctamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Limpiar()
                        Return
                    Else
                        MessageBox.Show("No se ha podido eliminar al usuario intentelo más tarde!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                MessageBox.Show("El rut ingresado no corresponde a ningun Usuario, intente con un usuario existente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
    End Sub

    Sub Limpiar()
        txtContrasena.Clear()
        txtCorreo.Clear()
        txtRut.Clear()
        txtTipo.Clear()
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        Dim rut As String = txtRut.Text
        Dim correo As String = txtCorreo.Text
        Dim contrasena As String = txtContrasena.Text
        Dim tipo As String = txtTipo.Text
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(correo) Or String.IsNullOrWhiteSpace(contrasena) Or String.IsNullOrWhiteSpace(tipo) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim existe As Usuario = GetUsuariosByRun(rut)
            If Not String.IsNullOrEmpty(existe.Rut) Then
                MessageBox.Show("El usuario ya existe, intente u usuario distinto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim usuario As New Usuario With {
                .Rut = rut,
                .Correo = correo,
                .Contrasena = contrasena,
                .Tipo = tipo
            }
            Dim crear As Boolean = CreateUsuario(usuario)
            If crear Then
                MessageBox.Show("Usuario Creado Correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Return
            End If
        End If
        MessageBox.Show("Ha Ocurrido un Error intentelo más tarde.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles BtnVer.Click
        If txtContrasena.UseSystemPasswordChar Then
            txtContrasena.UseSystemPasswordChar = False
            BtnVer.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Else
            txtContrasena.UseSystemPasswordChar = True
            BtnVer.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class