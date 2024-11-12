Public Class FormBusquedaSiniestro
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If dgvSiniestro.Rows.Count > 0 Then
            Dim siniestro = New Siniestros With {
                .SiniestroID = dgvSiniestro.CurrentRow.Cells(0).Value,
                .FechaSiniestro = dgvSiniestro.CurrentRow.Cells(1).Value,
                .Detalle = dgvSiniestro.CurrentRow.Cells(2).Value,
                .EstadoSeguro = dgvSiniestro.CurrentRow.Cells(6).Value,
                .EstadoSiniestro = dgvSiniestro.CurrentRow.Cells(3).Value,
                .Rut = dgvSiniestro.CurrentRow.Cells(4).Value,
                .RutCompania = dgvSiniestro.CurrentRow.Cells(5).Value
            }
            Dim msj As Integer = MessageBox.Show("Desea modificar?, esta acción NO se puede revertir!", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If msj = vbOK Then
                If UpdateSiniestro(siniestro) Then
                    MessageBox.Show("Se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Buscarmuchasveces()
                Else
                    MessageBox.Show("Debe EDITAR la celda que quiere MODIFICAR!", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Realice una BÚSQUEDA de lo que desea modificar!", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If dgvSiniestro.Rows.Count > 0 Then
            Dim id As Integer = dgvSiniestro.CurrentRow.Cells(0).Value
            Dim msj As Integer = MessageBox.Show("Desea eliminar?, esta acción NO se puede revertir!", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If msj = vbOK Then
                Dim borrar As Boolean = DeleteSiniestro(id)
                If borrar Then
                    Buscarmuchasveces()
                    MessageBox.Show("Siniestro eliminado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Realice una BÚSQUEDA de lo que desea ELIMINAR!", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscarmuchasveces()
    End Sub

    Sub Buscarmuchasveces()
        If cbEstado.SelectedIndex > -1 Then
            Dim siniestros As List(Of Siniestros) = GetSiniestroFilter(txtRut.Text, cbEstado.SelectedItem)
            dgvSiniestro.Rows.Clear()
            For i As Integer = 0 To siniestros.Count - 1
                '#, Fecha, detalle, estado siniestro,rutCli,Compañia, estado seguro
                dgvSiniestro.Rows.Add(siniestros(i).SiniestroID, siniestros(i).FechaSiniestro.ToShortDateString(), siniestros(i).Detalle, siniestros(i).EstadoSiniestro, siniestros(i).Rut, siniestros(i).RutCompania, siniestros(i).EstadoSeguro)
            Next
        Else
            MessageBox.Show("Ingrese los filtros NECESARIOS para realizar una BÚSQUEDA!", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Private Sub dgvSiniestro_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiniestro.CellEndEdit
    '    If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
    '        Dim a As String = dgvSiniestro.CurrentCell.GetEditedFormattedValue(dgvSiniestro.CurrentRow.Index, DataGridViewDataErrorContexts.Display)
    '        dgvSiniestro.CurrentCell.Value = a
    '        MsgBox(a)
    '    End If
    'End Sub
End Class