Public Class FormClientes
    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellidoP As String = txtApellidoP.Text
        Dim apellidoM As String = txtApellidoM.Text
        Dim direccion As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim comuna As String = txtComuna.Text

        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellidoP) Or String.IsNullOrWhiteSpace(apellidoM) Or String.IsNullOrWhiteSpace(direccion) Or String.IsNullOrWhiteSpace(telefono) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim existe As Cliente = GetClienteByRun(rut)
            If Not String.IsNullOrEmpty(existe.Rut) Then
                MessageBox.Show("El cliente ya existe, intente un cliente distinto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim cliente As New Cliente With {
                .Rut = rut,
                .Nombre = nombre,
                .ApellidoP = apellidoP,
                .ApellidoM = apellidoM,
                .Direccion = direccion,
                .Telefono = telefono,
                .Comuna = comuna
            }
            Dim crear As Boolean = CreateCliente(cliente)
            If crear Then
                MessageBox.Show("Cliente Creado Correctamente.", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Return
            End If
        End If
        MessageBox.Show("Ha Ocurrido un Error intentelo más tarde.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Sub Limpiar()
        txtRut.Clear()
        txtNombre.Clear()
        txtApellidoP.Clear()
        txtApellidoM.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtComuna.Clear()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellidoP As String = txtApellidoP.Text
        Dim apellidoM As String = txtApellidoM.Text
        Dim direccion As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim comuna As String = txtComuna.Text
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellidoP) Or String.IsNullOrWhiteSpace(apellidoM) Or String.IsNullOrWhiteSpace(direccion) Or String.IsNullOrWhiteSpace(telefono) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim existe As Cliente = GetClienteByRun(rut)
            If Not String.IsNullOrEmpty(existe.Rut) Then
                Dim cliente As New Cliente With {
                   .Rut = rut,
                .Nombre = nombre,
                .ApellidoP = apellidoP,
                .ApellidoM = apellidoM,
                .Direccion = direccion,
                .Telefono = telefono,
                .Comuna = comuna
                }
                Dim update As Boolean = UpdateCliente(cliente)
                If update Then
                    MessageBox.Show("Cliente Actualizado Correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Return
                End If
            Else
                MessageBox.Show("El Cliente que desea modificar, no existe.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If
        MessageBox.Show("Ha Ocurrido un Error intentelo más tarde.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim rut As String = txtRut.Text
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe escribir un RUT para eliminar a un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim cliente As Cliente = GetClienteByRun(rut)
            If (Not String.IsNullOrEmpty(cliente.Rut)) Then
                Dim respuesta As Int32 = MessageBox.Show("¿Realmente Desea eliminar al cliente?, esta acción no se puede revertir",
                                                         "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If respuesta = vbYes Then
                    Dim delete As Boolean = DeleteCliente(rut)
                    If delete Then
                        MessageBox.Show("Cliente eliminado correctamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Limpiar()
                        Return
                    Else
                        MessageBox.Show("No se ha podido eliminar al cliente intentelo más tarde!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                MessageBox.Show("El rut ingresado no corresponde a ningún cliente, intente con un cliente existente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim rut As String = txtRut.Text
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe escribir un RUT, antes de realizar una búsqueda!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Dim cliente As Cliente = GetClienteByRun(rut)
            If (Not String.IsNullOrEmpty(cliente.Rut)) Then
                txtRut.Text = cliente.Rut
                txtNombre.Text = cliente.Nombre
                txtApellidoP.Text = cliente.ApellidoP
                txtApellidoM.Text = cliente.ApellidoM
                txtDireccion.Text = cliente.Direccion
                txtTelefono.Text = cliente.Telefono
                txtComuna.Text = cliente.Comuna
            Else
                MessageBox.Show("El Cliente ingresado NO existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub
End Class