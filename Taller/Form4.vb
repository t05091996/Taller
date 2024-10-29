Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista = GetProducto()
        cbProducto.DataSource = lista
        cbProducto.ValueMember = “RepuestoID”
        cbProducto.DisplayMember = “NombreRepuesto”
    End Sub

    Sub Limpiar()
        txtID.Clear()
        txtPrecio.Clear()
        txtProveedor.Clear()
        txtStock.Clear()
        txtRepuesto.Clear()
        cbProducto.SelectedIndex = 1
    End Sub

    Function ValidarVacio() As Boolean
        Dim r As Boolean = True
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                Dim textBox As TextBox = CType(c, TextBox)
                If textBox.Text = String.Empty Then
                    MessageBox.Show($"Debe rellenar el campo {textBox.Name.Replace("txt", "")}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    r = False
                End If
            End If
        Next
        Return r
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Debe rellenar el campo id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If DeleteRepuesto(Convert.ToInt32(txtID.Text)) Then
                MessageBox.Show("Se ha eliminado con exito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim lista = GetProducto()
                cbProducto.DataSource = Nothing
                cbProducto.DataSource = lista
                cbProducto.ValueMember = “RepuestoID”
                cbProducto.DisplayMember = “NombreRepuesto”
                cbProducto.SelectedIndex = 1
                Limpiar()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If ValidarVacio() Then
            Dim producto = New Repuestos With {
                        .RepuestoID = txtID.Text,
                        .Precio = txtPrecio.Text,
                        .Proveedor = txtProveedor.Text,
                        .Stock = txtStock.Text,
                        .NombreRepuesto = txtRepuesto.Text
                    }
            If UpdateRepuesto(producto) Then
                MessageBox.Show("Se ha modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim lista = GetProducto()
                cbProducto.DataSource = Nothing
                cbProducto.DataSource = lista
                cbProducto.ValueMember = “RepuestoID”
                cbProducto.DisplayMember = “NombreRepuesto”
                cbProducto.SelectedIndex = 1
                Limpiar()
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If ValidarVacio() Then
            Dim producto = New Repuestos With {
                        .RepuestoID = txtID.Text,
                        .Precio = txtPrecio.Text,
                        .Proveedor = txtProveedor.Text,
                        .Stock = txtStock.Text,
                        .NombreRepuesto = txtRepuesto.Text
                    }
            Dim verificar = GetProductoLikeName(txtRepuesto.Text)
            If String.IsNullOrEmpty(verificar.NombreRepuesto) Then
                If CreateRepuesto(producto) Then
                    MessageBox.Show("Se ha creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim lista = GetProducto()
                    cbProducto.DataSource = Nothing
                    cbProducto.DataSource = lista
                    cbProducto.ValueMember = “RepuestoID”
                    cbProducto.DisplayMember = “NombreRepuesto”
                    cbProducto.SelectedIndex = 1
                    Limpiar()
                Else
                    MessageBox.Show("Ha ocurrido un ERROR!, NO se puede duplicar el registro", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Ha ocurrido un ERROR!, NO se puede duplicar el registro", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim name As String = txtRepuesto.Text
        If String.IsNullOrEmpty(name) Then
            MessageBox.Show("Debe escribir el nombre del producto para buscar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim producto = GetProductoLikeName(name)
            txtID.Text = producto.RepuestoID
            txtPrecio.Text = Convert.ToString(Convert.ToUInt32(producto.Precio))
            txtProveedor.Text = producto.Proveedor
            txtStock.Text = producto.Stock
            txtRepuesto.Text = producto.NombreRepuesto
            cbProducto.SelectedIndex = -1
        End If
    End Sub

    Private Sub cbProducto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbProducto.SelectionChangeCommitted
        Dim id As Integer = cbProducto.SelectedValue
        Dim producto = GetProductoByID(id)
        txtID.Text = producto.RepuestoID
        txtPrecio.Text = Convert.ToString(Convert.ToUInt32(producto.Precio))
        txtProveedor.Text = producto.Proveedor
        txtStock.Text = producto.Stock
        txtRepuesto.Text = producto.NombreRepuesto
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class