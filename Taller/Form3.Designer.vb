<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCrear = New FontAwesome.Sharp.IconButton()
        Me.BtnBuscar = New FontAwesome.Sharp.IconButton()
        Me.BtnActualizar = New FontAwesome.Sharp.IconButton()
        Me.BtnEliminar = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.BtnVer = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 201)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Correo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 324)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo: "
        '
        'BtnCrear
        '
        Me.BtnCrear.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.BtnCrear.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnCrear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCrear.IconSize = 25
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.Location = New System.Drawing.Point(96, 383)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(144, 33)
        Me.BtnCrear.TabIndex = 4
        Me.BtnCrear.Text = "Crear"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Glasses
        Me.BtnBuscar.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnBuscar.IconSize = 30
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.Location = New System.Drawing.Point(425, 129)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(124, 33)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Leer"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.IconChar = FontAwesome.Sharp.IconChar.UsersGear
        Me.BtnActualizar.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnActualizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnActualizar.IconSize = 30
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.Location = New System.Drawing.Point(96, 449)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(144, 33)
        Me.BtnActualizar.TabIndex = 6
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.UsersSlash
        Me.BtnEliminar.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEliminar.IconSize = 30
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.Location = New System.Drawing.Point(273, 414)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(124, 33)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Administración de Usuarios"
        '
        'txtRut
        '
        Me.txtRut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtRut.Location = New System.Drawing.Point(190, 134)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(229, 26)
        Me.txtRut.TabIndex = 9
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(190, 318)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(229, 26)
        Me.txtTipo.TabIndex = 10
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(190, 261)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(229, 26)
        Me.txtContrasena.TabIndex = 11
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(190, 199)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(229, 26)
        Me.txtCorreo.TabIndex = 12
        '
        'BtnVer
        '
        Me.BtnVer.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.BtnVer.IconColor = System.Drawing.Color.DarkGray
        Me.BtnVer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnVer.IconSize = 30
        Me.BtnVer.Location = New System.Drawing.Point(438, 258)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(37, 30)
        Me.BtnVer.TabIndex = 13
        Me.BtnVer.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft
        Me.IconButton1.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(12, 12)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(108, 40)
        Me.IconButton1.TabIndex = 14
        Me.IconButton1.Text = "Volver"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller.My.Resources.Resources._4105943_accounts_group_people_user_user_group_users_113923
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(613, 540)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Uusarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCrear As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnActualizar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents BtnVer As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
