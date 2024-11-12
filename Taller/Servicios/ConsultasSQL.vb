Imports MySql.Data.MySqlClient
Module ConsultasSQL
    Private Property ConnectionString As String = "Server=localhost;Database=taller;User ID='root';Password='';"

    Public Function GetEmpleadoByRun(ByRef run As String) As Empleado
        Dim empleado As New Empleado()
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM usuarios WHERE RUT=@rut"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", run)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    empleado.Rut = Convert.ToString(resultado("Rut"))
                    empleado.Nombre = Convert.ToString(resultado("Correo"))
                    empleado.ApellidoP = Convert.ToString(resultado("Tipo"))
                    empleado.ApellidoM = Convert.ToString(resultado("Tipo"))
                    empleado.Cargo = Convert.ToString(resultado("Tipo"))
                    empleado.Comuna = Convert.ToString(resultado("Tipo"))
                    empleado.Direccion = Convert.ToString(resultado("Tipo"))
                    empleado.Telefono = Convert.ToString(resultado("Tipo"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return empleado
    End Function

    Public Function GetAllEmpleados() As List(Of Empleado)
        Dim empleados As New List(Of Empleado)
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM usuarios"
                Dim cmd As New MySqlCommand(query, conexion)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    Dim empleado As New Empleado With {
                        .Rut = Convert.ToString(resultado("Rut")),
                        .Nombre = Convert.ToString(resultado("Correo")),
                        .ApellidoP = Convert.ToString(resultado("Tipo")),
                        .ApellidoM = Convert.ToString(resultado("Tipo")),
                        .Cargo = Convert.ToString(resultado("Tipo")),
                        .Comuna = Convert.ToString(resultado("Tipo")),
                        .Direccion = Convert.ToString(resultado("Tipo")),
                        .Telefono = Convert.ToString(resultado("Tipo"))
                    }
                    empleados.Add(empleado)
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return empleados
    End Function
    ' crud usuario
    Public Function CreateUsuario(ByRef usuario As Usuario) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "INSERT INTO usuarios (Rut, Correo, Contraseña, Tipo ) " &
                                    "VALUES (@rut, @correo, @contrasena, @tipo )"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", usuario.Rut)
                cmd.Parameters.AddWithValue("@correo", usuario.Correo)
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena)
                cmd.Parameters.AddWithValue("@tipo", usuario.Tipo)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function UpdateUsuario(ByRef usuario As Usuario) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "UPDATE usuarios SET Correo=@correo, Contraseña=@contrasena, Tipo=@tipo WHERE Rut=@rut"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", usuario.Rut)
                cmd.Parameters.AddWithValue("@correo", usuario.Correo)
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena)
                cmd.Parameters.AddWithValue("@tipo", usuario.Tipo)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function DeleteUsuario(ByRef run As String) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "DELETE FROM usuarios WHERE Rut=@rut"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", run)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function GetUsuariosByRun(ByRef run As String) As Usuario
        Dim usuario As New Usuario()
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM usuarios WHERE RUT=@rut"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", run)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    usuario.Rut = Convert.ToString(resultado("Rut"))
                    usuario.Correo = Convert.ToString(resultado("Correo"))
                    usuario.Tipo = Convert.ToString(resultado("Tipo"))
                    usuario.Contrasena = Convert.ToString(resultado("Contraseña"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return usuario
    End Function

    Public Function GetAllUsuarios() As List(Of Usuario)
        Dim usuarios As New List(Of Usuario)
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM usuarios"
                Dim cmd As New MySqlCommand(query, conexion)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    Dim usuario As New Usuario With {
                        .Rut = Convert.ToString(resultado("Rut")),
                        .Correo = Convert.ToString(resultado("Correo")),
                        .Tipo = Convert.ToString(resultado("Tipo"))
                    }
                    usuarios.Add(usuario)
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return usuarios
    End Function

    Public Function VerificarUsuario(RUT As String, PASS As String) As Boolean
        Dim aprobado = False
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM usuarios WHERE Rut=@rut AND Contraseña=@pass"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", RUT)
                cmd.Parameters.AddWithValue("@pass", PASS)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    aprobado = True
                    My.Settings.Run = RUT
                    My.Settings.TipoUsuario = Convert.ToString(resultado("Tipo"))
                    My.Settings.Correo = Convert.ToString(resultado("Correo"))

                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using

        Return aprobado
    End Function

    'crud producto
    Public Function GetProducto() As List(Of ModeloCombo)
        Dim lista As New List(Of ModeloCombo)
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT RepuestoID, NombreRepuesto FROM repuestos ORDER BY NombreRepuesto ASC"
                Dim cmd As New MySqlCommand(query, conexion)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    Dim modelo = New ModeloCombo With {
                        .RepuestoID = Convert.ToInt32(resultado("RepuestoID")),
                        .NombreRepuesto = Convert.ToString(resultado("NombreRepuesto"))
                    }
                    lista.Add(modelo)
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return lista
    End Function

    Public Function GetProductoByID(ByRef id As Int32) As Repuestos
        Dim lista As New Repuestos
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM repuestos WHERE RepuestoID=@id"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    lista.RepuestoID = Convert.ToInt32(resultado("RepuestoID"))
                    lista.NombreRepuesto = Convert.ToString(resultado("NombreRepuesto"))
                    lista.Precio = Convert.ToDecimal(resultado("PrecioUnitario"))
                    lista.Proveedor = Convert.ToString(resultado("Proveedor"))
                    lista.Stock = Convert.ToInt32(resultado("CantidadStock"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return lista
    End Function

    Public Function GetProductoLikeName(ByRef name As String) As Repuestos
        Dim lista As New Repuestos
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM repuestos WHERE NombreRepuesto like @name"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@name", name + "%")
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    lista.RepuestoID = Convert.ToInt32(resultado("RepuestoID"))
                    lista.NombreRepuesto = Convert.ToString(resultado("NombreRepuesto"))
                    lista.Precio = Convert.ToDecimal(resultado("PrecioUnitario"))
                    lista.Proveedor = Convert.ToString(resultado("Proveedor"))
                    lista.Stock = Convert.ToInt32(resultado("CantidadStock"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return lista
    End Function

    Public Function GetProductos(ByRef name As String) As List(Of Repuestos)
        Dim lista As New List(Of Repuestos)
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM repuestos WHERE NombreRepuesto like @name"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@name", name + "%")
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    Dim producto As New Repuestos With {
                    .RepuestoID = Convert.ToInt32(resultado("RepuestoID")),
                    .NombreRepuesto = Convert.ToString(resultado("NombreRepuesto")),
                    .Precio = Convert.ToDecimal(resultado("PrecioUnitario")),
                    .Proveedor = Convert.ToString(resultado("Proveedor")),
                    .Stock = Convert.ToInt32(resultado("CantidadStock"))
                    }
                    lista.Add(producto)
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return lista
    End Function

    Public Function CreateRepuesto(ByRef repuesto As Repuestos) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "INSERT INTO repuestos (RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario,Proveedor) " &
                                    "VALUES (@id, @producto, @stock, @precio, @proveedor )"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", repuesto.RepuestoID)
                cmd.Parameters.AddWithValue("@producto", repuesto.NombreRepuesto)
                cmd.Parameters.AddWithValue("@stock", repuesto.Stock)
                cmd.Parameters.AddWithValue("@precio", repuesto.Precio)
                cmd.Parameters.AddWithValue("@proveedor", repuesto.Proveedor)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function UpdateRepuesto(ByRef repuesto As Repuestos) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "UPDATE repuestos SET NombreRepuesto=@producto, CantidadStock=@stock, PrecioUnitario=@precio,Proveedor=@proveedor WHERE RepuestoID= @id"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", repuesto.RepuestoID)
                cmd.Parameters.AddWithValue("@producto", repuesto.NombreRepuesto)
                cmd.Parameters.AddWithValue("@stock", repuesto.Stock)
                cmd.Parameters.AddWithValue("@precio", repuesto.Precio)
                cmd.Parameters.AddWithValue("@proveedor", repuesto.Proveedor)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function DeleteRepuesto(ByRef id As Integer) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "DELETE FROM repuestos WHERE RepuestoID=@id"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    'crud cliente
    Public Function GetClienteByRun(ByRef run As String) As Cliente
        Dim cliente As New Cliente()
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM clientes WHERE RUT=@rut"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", run)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    cliente.Rut = Convert.ToString(resultado("Rut"))
                    cliente.Nombre = Convert.ToString(resultado("Nombre"))
                    cliente.ApellidoP = Convert.ToString(resultado("ApellidoP"))
                    cliente.ApellidoM = Convert.ToString(resultado("ApellidoM"))
                    cliente.Telefono = Convert.ToString(resultado("Telefono"))
                    cliente.Direccion = Convert.ToString(resultado("Direccion"))
                    cliente.Comuna = Convert.ToString(resultado("Comuna"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return cliente
    End Function

    Public Function CreateCliente(ByRef cliente As Cliente) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "INSERT INTO clientes (Rut, Nombre, ApellidoP, ApellidoM, Telefono, Direccion, Comuna ) " &
                                    "VALUES (@rut, @Nombre, @ApellidoP, @ApellidoM, @Telefono , @Direccion , @Comuna)"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", cliente.Rut)
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                cmd.Parameters.AddWithValue("@ApellidoP", cliente.ApellidoP)
                cmd.Parameters.AddWithValue("@ApellidoM", cliente.ApellidoM)
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion)
                cmd.Parameters.AddWithValue("@Comuna", cliente.Comuna)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function UpdateCliente(ByRef cliente As Cliente) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "Update clientes SET Nombre=@Nombre, ApellidoP=@ApellidoP," &
                                    "ApellidoM=@ApellidoM, Telefono=@Telefono, Direccion=@Direccion, Comuna=@Comuna " &
                                    "WHERE Rut=@rut"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", cliente.Rut)
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                cmd.Parameters.AddWithValue("@ApellidoP", cliente.ApellidoP)
                cmd.Parameters.AddWithValue("@ApellidoM", cliente.ApellidoM)
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion)
                cmd.Parameters.AddWithValue("@Comuna", cliente.Comuna)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function DeleteCliente(ByRef rut As String) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "DELETE FROM clientes WHERE Rut=@rut"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", rut)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    'crud VentaRepuestos
    Public Function GetVentaRepuestosById(ByRef id As Integer) As VentaRepuestos
        Dim venta As New VentaRepuestos()
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM ventasrepuestos WHERE VentaID=@id"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    venta.VentaID = Convert.ToInt32(resultado("VentaID"))
                    venta.CantidadVendida = Convert.ToInt32(resultado("CantidadVendida"))
                    venta.Cliente = Convert.ToString(resultado("Cliente"))
                    venta.FechaVenta = Convert.ToDateTime(resultado("FechaVenta"))
                    venta.NombreRepuesto = Convert.ToString(resultado("NombreRepuesto"))
                    venta.Total = Convert.ToInt32(resultado("Total"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return venta
    End Function

    Public Function CreateVentaRepuestos(ByRef venta As VentaRepuestos) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "INSERT INTO ventasrepuestos (Total, FechaVenta, Cliente, CantidadVendida, NombreRepuesto, VentaID) " &
                                    "VALUES (@Total, @FechaVenta, @Cliente, @CantidadVendida, @NombreRepuesto , @VentaID)"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@VentaID", venta.VentaID)
                cmd.Parameters.AddWithValue("@NombreRepuesto", venta.NombreRepuesto)
                cmd.Parameters.AddWithValue("@CantidadVendida", venta.CantidadVendida)
                cmd.Parameters.AddWithValue("@Cliente", venta.Cliente)
                cmd.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta)
                cmd.Parameters.AddWithValue("@Total", venta.Total)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function UpdateVentaRepuestos(ByRef venta As VentaRepuestos) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "Update ventasrepuestos SET NombreRepuesto=@NombreRepuesto, CantidadVendida=@CantidadVendida," &
                                    "Cliente=@Cliente, FechaVenta=@FechaVenta, Total=@Total " &
                                    "WHERE VentaID=@VentaID"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@VentaID", venta.VentaID)
                cmd.Parameters.AddWithValue("@NombreRepuesto", venta.NombreRepuesto)
                cmd.Parameters.AddWithValue("@CantidadVendida", venta.CantidadVendida)
                cmd.Parameters.AddWithValue("@Cliente", venta.Cliente)
                cmd.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta)
                cmd.Parameters.AddWithValue("@Total", venta.Total)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function DeleteVentaRepuestos(ByRef id As Integer) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "DELETE FROM ventasrepuestos WHERE VentaID=@id"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function GetVentaRepuestosFilter(ByRef filtro As Filtros) As List(Of VentaRepuestos)
        Dim lista As New List(Of VentaRepuestos)
        Dim rut As String = "AND Cliente like @rut"
        Dim nombre As String = "AND NombreRepuesto like @nombre"

        If String.IsNullOrEmpty(filtro.Rut) Then
            rut = String.Empty
        End If
        If String.IsNullOrEmpty(filtro.Nombre) Then
            nombre = String.Empty
        End If

        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = $"SELECT * FROM ventasrepuestos WHERE FechaVenta BETWEEN @fechaD AND @fechaH {rut} {nombre}"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", filtro.Rut & "%")
                cmd.Parameters.AddWithValue("@nombre", filtro.Nombre & "%")
                cmd.Parameters.AddWithValue("@fechaD", filtro.FechaD)
                cmd.Parameters.AddWithValue("@fechaH", filtro.FechaH)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    Dim venta As New VentaRepuestos With {
                        .VentaID = Convert.ToInt32(resultado("VentaID")),
                        .CantidadVendida = Convert.ToInt32(resultado("CantidadVendida")),
                        .Cliente = Convert.ToString(resultado("Cliente")),
                        .FechaVenta = Convert.ToDateTime(resultado("FechaVenta")),
                        .NombreRepuesto = Convert.ToString(resultado("NombreRepuesto")),
                        .Total = Convert.ToInt32(resultado("Total"))
                    }
                    lista.Add(venta)
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return lista
    End Function

    'crud Siniestros
    Public Function GetSiniestroById(ByRef id As Integer) As Siniestros
        Dim siniestro As New Siniestros()
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM siniestro WHERE SiniestroID=@id"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    siniestro.SiniestroID = Convert.ToInt32(resultado("SiniestroID"))
                    siniestro.Detalle = Convert.ToString(resultado("Detalle"))
                    siniestro.EstadoSiniestro = Convert.ToString(resultado("EstadoSiniestro"))
                    siniestro.FechaSiniestro = Convert.ToDateTime(resultado("FechaSiniestro"))
                    siniestro.RutCompania = Convert.ToString(resultado("RutCompania"))
                    siniestro.Rut = Convert.ToString(resultado("Rut"))
                    siniestro.EstadoSeguro = Convert.ToString(resultado("EstadoSeguro"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return siniestro
    End Function

    Public Function CreateSiniestro(ByRef siniestro As Siniestros) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "INSERT INTO siniestro (Detalle, Estado_Siniestro,Fecha_Siniestro,RutCompania,Rut,Estado_Seguro) " &
                                    "VALUES (@Detalle, @EstadoSiniestro, @FechaSiniestro, @Rutcompania , @Rut,@EstadoSeguro)"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@Detalle", siniestro.Detalle)
                cmd.Parameters.AddWithValue("@EstadoSiniestro", siniestro.EstadoSiniestro)
                cmd.Parameters.AddWithValue("@FechaSiniestro", siniestro.FechaSiniestro)
                cmd.Parameters.AddWithValue("@Rutcompania", siniestro.RutCompania)
                cmd.Parameters.AddWithValue("@Rut", siniestro.Rut)
                cmd.Parameters.AddWithValue("@EstadoSeguro", siniestro.EstadoSeguro)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function UpdateSiniestro(ByRef siniestro As Siniestros) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "UPDATE siniestro SET Detalle=@Detalle, Estado_Siniestro=@EstadoSiniestro," &
                                    "RutCompania=@Rutcompania, Rut=@Rut, Estado_Seguro=@EstadoSeguro, Fecha_Siniestro=@FechaSiniestro " &
                                    "WHERE SiniestroID=@SiniestroID"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@SiniestroID", siniestro.SiniestroID)
                cmd.Parameters.AddWithValue("@Detalle", siniestro.Detalle)
                cmd.Parameters.AddWithValue("@EstadoSiniestro", siniestro.EstadoSiniestro)
                cmd.Parameters.AddWithValue("@FechaSiniestro", siniestro.FechaSiniestro)
                cmd.Parameters.AddWithValue("@Rutcompania", siniestro.RutCompania)
                cmd.Parameters.AddWithValue("@Rut", siniestro.Rut)
                cmd.Parameters.AddWithValue("@EstadoSeguro", siniestro.EstadoSeguro)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
                Return False
            End Try
        End Using
        Return False
    End Function

    Public Function DeleteSiniestro(ByRef id As Integer) As Boolean
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "DELETE FROM siniestro WHERE SiniestroID=@id"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                conexion.Close()
                Return True
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return False
    End Function

    Public Function GetSiniestroFilter(ByRef rut As String, ByRef estado As String) As List(Of Siniestros)
        Dim lista As New List(Of Siniestros)
        Dim query As String = "SELECT * FROM siniestro WHERE Estado_Siniestro=@EstadoSiniestro"

        If estado = "Todo" Then
            query = "SELECT * FROM siniestro"
        End If
        If Not String.IsNullOrEmpty(rut) Then
            query &= " AND Rut like @rut"
        End If
        If estado = "Todo" And Not String.IsNullOrEmpty(rut) Then
            query = "SELECT * FROM siniestro WHERE Rut like @rut"
        End If

        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@rut", rut & "%")
                cmd.Parameters.AddWithValue("@EstadoSiniestro", estado)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    Dim siniestro As New Siniestros With {
                        .SiniestroID = Convert.ToInt32(resultado("SiniestroID")),
                        .Detalle = Convert.ToString(resultado("Detalle")),
                        .EstadoSiniestro = Convert.ToString(resultado("Estado_Siniestro")),
                        .FechaSiniestro = Convert.ToDateTime(resultado("Fecha_Siniestro")),
                        .RutCompania = Convert.ToString(resultado("RutCompania")),
                        .EstadoSeguro = Convert.ToString(resultado("Estado_Seguro")),
                        .Rut = Convert.ToString(resultado("Rut"))
                      }
                    lista.Add(siniestro)
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return lista
    End Function

    'crud Compania
    Public Function GetCompania() As List(Of Compania)
        Dim lista As New List(Of Compania)
        Using conexion As New MySqlConnection(ConnectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM compania ORDER BY Descripcion ASC"
                Dim cmd As New MySqlCommand(query, conexion)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    Dim modelo = New Compania With {
                        .Rut = Convert.ToString(resultado("Rut")),
                        .Descripcion = Convert.ToString(resultado("Descripcion"))
                    }
                    lista.Add(modelo)
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return lista
    End Function


End Module
