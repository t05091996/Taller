Module ModulodeAyuda
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

    Sub LimpiarTodo(ByRef formulario As Form)
        For Each c As Control In formulario.Controls
            If TypeOf c Is TextBox Then
                Dim textBox As TextBox = CType(c, TextBox)
                textBox.Clear()
            End If
            If TypeOf c Is ComboBox Then
                Dim comboBox As ComboBox = CType(c, ComboBox)
                comboBox.SelectedIndex = -1
            End If
            If TypeOf c Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = CType(c, DateTimePicker)
                dateTimePicker.Value = Date.Now
            End If
            If TypeOf c Is DataGridView Then
                Dim dataGridView As DataGridView = CType(c, DataGridView)
                dataGridView.Rows.Clear()
            End If
        Next
    End Sub

    Function ValidarTxtComboDateTime(ByRef formulario As Form) As Boolean
        Dim r As Boolean = True
        For Each c As Control In formulario.Controls
            If TypeOf c Is TextBox Then
                Dim textBox As TextBox = CType(c, TextBox)
                If textBox.Text = String.Empty Then
                    MessageBox.Show($"Debe rellenar el campo {textBox.Name.Replace("txt", "")}", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    r = False
                End If
            End If
            If TypeOf c Is ComboBox Then
                Dim comboBox As ComboBox = CType(c, ComboBox)
                If comboBox.SelectedIndex < 0 Then
                    MessageBox.Show($"Debe seleccionar {comboBox.Name.Replace("cb", "").Replace("Compania", "Compañia")}", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    r = False
                End If
            End If
            If TypeOf c Is DateTimePicker Then
                Dim dtp As DateTimePicker = CType(c, DateTimePicker)
                If dtp.Name <> "dtpFechaSiniestro" Then
                    If dtp.Value < Date.Now.AddMonths(-1).AddDays(-1) Then
                        MessageBox.Show("La fecha ingresada NO puede ser menor a un mes", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        r = False
                    End If
                End If
            End If
        Next
        Return r
    End Function

End Module
