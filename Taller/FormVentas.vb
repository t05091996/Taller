Public Class FormVentas
    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged
        Dim rut As String = txtRut.Text
        ValidarCliente(rut)
    End Sub

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDatos.Text = String.Empty
        lblDatosRepuestos.Text = String.Empty
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged
        If txtIdProducto.Text.Length > 0 Then
            Dim id As Integer = Convert.ToInt32(txtIdProducto.Text)
            Dim producto As Repuestos = GetProductoByID(id)
            lblDatosRepuestos.Text = $"Item: {producto.NombreRepuesto}" & vbNewLine & $"Disponible: {producto.Stock} unidades" & vbNewLine & $"Precio: $ {producto.Precio}" & vbNewLine & $"Proveedor: {producto.Proveedor}"
            txtProducto.Text = producto.NombreRepuesto
        End If

    End Sub

    Private Sub txtIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProducto.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
        Dim id As String = txtIdProducto.Text
        Dim producto As String = txtProducto.Text
        Dim respuesta As String = String.Empty
        If String.IsNullOrEmpty(id) And producto.Length > 2 Then
            Dim repuestos As List(Of Repuestos) = GetProductos(producto)
            For Each repuesto As Repuestos In repuestos
                respuesta &= $"Código: {repuesto.RepuestoID}" & vbNewLine & $"Item: {repuesto.NombreRepuesto}" & vbNewLine & vbNewLine
            Next
            lblDatosRepuestos.Text = respuesta
        End If
    End Sub

    Private Sub txtProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyDown
        txtIdProducto.Text = String.Empty
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If ValidarVacio(Me) Then
            Dim id As Integer = Convert.ToInt32(txtIdProducto.Text)
            Dim producto As String = txtProducto.Text
            Dim cliente As String = txtRut.Text
            Dim fecha As DateTime = DateTime.Now
            Dim cantidad As Integer = Convert.ToInt32(txtCantidad.Text)
            Dim fila As Integer = Convert.ToInt32(dgvProductos.DisplayedRowCount(True)) 'it start with 1 thing i don't know why it doesn't even matter how i start to cry
            Dim repuesto As Repuestos = GetProductoByID(id)
            If cantidad > repuesto.Stock Then
                MessageBox.Show("No hay suficiente stock para este producto", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim overStock As Boolean = True

            If fila > 0 Then
                Dim recuento As Integer = cantidad
                If fila > 1 Then
                    For i As Integer = 0 To fila - 1
                        Dim code = dgvProductos.Rows(i).Cells(3).Value
                        Dim stock = dgvProductos.Rows(i).Cells(5).Value
                        If id = code Then
                            recuento += stock
                            If repuesto.Stock < recuento Then
                                overStock = False
                            End If
                        End If
                    Next
                End If
                If overStock Then
                    'id, fecha, cliente, codigo, repuesto, cantidad, total
                    dgvProductos.Rows.Add(fila, fecha.ToShortDateString(), cliente, id, producto, cantidad, cantidad * repuesto.Precio)
                Else
                    MessageBox.Show("No hay suficiente stock para este producto", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub bnLimpiar_Click(sender As Object, e As EventArgs) Handles bnLimpiar.Click
        LimpiarTexto(Me)
        lblDatos.Text = String.Empty
        lblDatosRepuestos.Text = String.Empty
    End Sub

    Private Sub btnRealizar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click
        Dim filas = dgvProductos.Rows.Count
        If filas > 1 Then
            Dim ventas As Integer = 0
            For i As Integer = 0 To filas - 2
                'id, fecha, cliente, codigo, repuesto, cantidad, total
                Dim fecha = dgvProductos.Rows(i).Cells(1).Value
                Dim rut = dgvProductos.Rows(i).Cells(2).Value
                Dim id = dgvProductos.Rows(i).Cells(3).Value
                Dim nombre = dgvProductos.Rows(i).Cells(4).Value
                Dim cantidad = dgvProductos.Rows(i).Cells(5).Value
                Dim total = dgvProductos.Rows(i).Cells(6).Value
                'VentaID, NombreRepuesto, CantidadVendida, Cliente,FechaVenta, total
                Dim venta As New VentaRepuestos With {
                        .CantidadVendida = cantidad,
                        .Cliente = rut,
                        .FechaVenta = fecha,
                        .NombreRepuesto = nombre,
                        .Total = total
                }
                Dim vendido As Boolean = CreateVentaRepuestos(venta)
                If vendido Then
                    Dim repuesto As Repuestos = GetProductoByID(id)
                    repuesto.Stock -= cantidad ' resta la cantidad al stock
                    Dim update As Boolean = UpdateRepuesto(repuesto)
                    If (update) Then
                        ventas += 1
                    End If
                End If
            Next
            MessageBox.Show($"{ventas} Productos vendidos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvProductos.Rows.Clear()
        Else
            MessageBox.Show("Debe agregar al menos un producto", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnResumen_Click(sender As Object, e As EventArgs) Handles btnResumen.Click
        FormResumen.Show()
        Me.Close()
    End Sub

    Private Sub txtRut_Leave(sender As Object, e As EventArgs) Handles txtRut.Leave
        Dim rut As String = txtRut.Text
        ValidarCliente(rut)
    End Sub

    Sub ValidarCliente(ByRef rut As String)
        If rut.Length > 8 Then
            Dim cliente As Cliente = GetClienteByRun(rut)
            If cliente.Nombre IsNot Nothing Then
                lblDatos.Text = $"Rut: {cliente.Rut}" & vbNewLine & $"Nombre: {cliente.Nombre}" & vbNewLine & $"{cliente.ApellidoP} {cliente.ApellidoM}"
            Else
                Dim msj As Integer = MessageBox.Show("Cliente NO EXISTE!, Desea crearlo?", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If msj = vbOK Then
                    FormClientes.Show()
                End If
            End If
        Else
            lblDatos.Text = String.Empty
        End If
    End Sub

End Class