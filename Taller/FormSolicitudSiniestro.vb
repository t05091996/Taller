Public Class FormSolicitudSiniestro
    Private Sub FormSolicitudSiniestro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista = GetSiniestros()
        cbSiniestro.DataSource = lista
        cbSiniestro.ValueMember = “SiniestroID”
        cbSiniestro.DisplayMember = “Detalle”
        dtpFechaSiniestro.Value = Date.Now
        lbDatosClientes.Text = String.Empty
        lbDatosSiniestro.Text = String.Empty
        dtFechaSolicitud.Value = Date.Now
        lbID.Text = String.Empty
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FormMenu.Show()
        Me.Close()
    End Sub

    Private Sub cbSiniestro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbSiniestro.SelectionChangeCommitted
        Dim id As Integer = cbSiniestro.SelectedValue
        Dim modulo As ModuloSolicitud = GetSolicitud(id)
        dtpFechaSiniestro.Value = modulo.FechaSiniestro
        txtRutCliente.Text = modulo.RutCliente
        lbDatosClientes.Text = modulo.NombreCliente
        lbDatosSiniestro.Text = modulo.RutCompania & vbNewLine & modulo.NombreCompania & vbNewLine & modulo.EstadoSeguro & vbNewLine & modulo.Detalle
    End Sub

    Private Sub btnBuscarGroup_Click(sender As Object, e As EventArgs) Handles btnBuscarGroup.Click
        Dim nombre As String = txtNombreClienteGroup.Text
        Dim estado As String = cbEstadoGroup.SelectedItem
        Dim llenar = GetSolicitudFilter(nombre, estado)
        dgvSolicitud.Rows.Clear()
        'SiniestroID, FechaSolicitud, FechaSiniestro, NombreCliente, DescripcionProblema,
        'EstadoSiniestro, NombreCompania, EstadoSeguro, estado, 
        For i As Integer = 0 To llenar.Count - 1
            dgvSolicitud.Rows.Add(llenar(i).SolicitudID, llenar(i).FechaSolicitud.ToShortDateString, llenar(i).FechaSiniestro.ToShortDateString,
                                  llenar(i).NombreCliente, llenar(i).DescripcionProblema, llenar(i).EstadoSiniestro, llenar(i).NombreCompania,
                                  llenar(i).EstadoSeguro, llenar(i).Estado)
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarTxtComboDateTime(Me) Then
            Dim solicitud = New Solicitud With {
                        .Siniestroid = cbSiniestro.SelectedValue,
                        .FechaSolicitud = dtpFechaSiniestro.Value,
                        .RutEmpleado = My.Settings.Run,
                        .Rut = txtRutCliente.Text,
                        .DescripcionProblema = txtDescripcion.Text,
                        .Estado = cbEstado.SelectedItem
                    }
            If CreateSolicitud(solicitud) Then
                MessageBox.Show("Se ha creado su solicitud correctamente", "ÉXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarFormulario()
            Else
                MessageBox.Show("NO se ha podido crear la solicitud", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFormulario()
    End Sub

    Sub LimpiarFormulario()
        lbDatosClientes.Text = String.Empty
        lbDatosSiniestro.Text = String.Empty
        lbID.Text = String.Empty
        LimpiarTodo(Me)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim id As Object = lbID.Text
        If IsNumeric(id) Then
            Dim solicitud = New Solicitud With {
                        .Siniestroid = cbSiniestro.SelectedValue,
                        .FechaSolicitud = dtpFechaSiniestro.Value,
                        .RutEmpleado = My.Settings.Run,
                        .Rut = txtRutCliente.Text,
                        .DescripcionProblema = txtDescripcion.Text,
                        .Estado = cbEstado.SelectedItem,
                        .SolicitudID = lbID.Text
            }
            Dim mensaje As Integer = MessageBox.Show("¿Desea actualizar la solicitud?", "ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mensaje = vbYes Then
                If UpdateSolicitud(solicitud) Then
                    MessageBox.Show("Se ha actualizado su solicitud correctamente", "ÉXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarFormulario()
                Else
                    MessageBox.Show("NO se ha podido actualizar su solicitud", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                LimpiarFormulario() 'limpiar si no quiere actualizar
            End If
        End If
    End Sub

    Private Sub dgvSolicitud_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolicitud.CellContentClick
        If dgvSolicitud.Rows.Count > 0 Then
            Dim id As Integer = dgvSolicitud.Rows(e.RowIndex).Cells(0).Value
            Dim solicitud As ModuloSolicitud = GetSolicitudByID(id)
            lbID.Text = solicitud.SolicitudID
            txtDescripcion.Text = solicitud.DescripcionProblema
            txtRutCliente.Text = solicitud.RutCliente
            cbEstado.SelectedItem = solicitud.Estado
            lbDatosClientes.Text = solicitud.NombreCliente
            lbDatosSiniestro.Text = solicitud.RutCompania & vbNewLine & solicitud.NombreCompania & vbNewLine & solicitud.EstadoSeguro & vbNewLine & solicitud.Detalle
            dtFechaSolicitud.Value = solicitud.FechaSolicitud
            dtpFechaSiniestro.Value = solicitud.FechaSiniestro
            cbSiniestro.SelectedValue = solicitud.SiniestroID
        End If
    End Sub


End Class