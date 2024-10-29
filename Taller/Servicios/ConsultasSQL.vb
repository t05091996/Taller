Imports MySql.Data.MySqlClient
Module ConsultasSQL
    Private Property ConnectionString As String = "Server=localhost;Database=taller;User ID='root';Password='';"

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
End Module
