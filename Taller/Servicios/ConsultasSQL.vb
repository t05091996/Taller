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
                Dim query As String = "SELECT * FROM usuarios WHERE Rut=@RUT AND Contraseña=@pass"
                Dim cmd As New MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@RUT", RUT)
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

End Module
