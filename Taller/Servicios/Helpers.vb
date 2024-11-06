Module Helpers
    Function ValidarVacio(ByRef formulario As Form) As Boolean
        Dim r As Boolean = True
        For Each c As Control In formulario.Controls
            If TypeOf c Is TextBox Then
                Dim textBox As TextBox = CType(c, TextBox)
                If textBox.Text = String.Empty Then
                    MessageBox.Show($"Debe rellenar el campo {textBox.Name.Replace("txt", "")}", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    r = False
                End If
            End If
        Next
        Return r
    End Function

    Sub LimpiarTexto(ByRef formulario As Form)
        For Each c As Control In formulario.Controls
            If TypeOf c Is TextBox Then
                Dim textBox As TextBox = CType(c, TextBox)
                textBox.Clear()
            End If
        Next
    End Sub
End Module
