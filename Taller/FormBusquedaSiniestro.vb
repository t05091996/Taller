Public Class FormBusquedaSiniestro
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormSiniestros.Show()
        Me.Close()
    End Sub
End Class