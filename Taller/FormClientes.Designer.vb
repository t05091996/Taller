<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidoM = New System.Windows.Forms.TextBox()
        Me.txtApellidoP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComuna = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.BtnEliminar = New FontAwesome.Sharp.IconButton()
        Me.BtnActualizar = New FontAwesome.Sharp.IconButton()
        Me.BtnBuscar = New FontAwesome.Sharp.IconButton()
        Me.BtnCrear = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(228, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro NUEVO Cliente."
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(243, 142)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(229, 32)
        Me.txtNombre.TabIndex = 26
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(243, 314)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(229, 32)
        Me.txtDireccion.TabIndex = 24
        '
        'txtRut
        '
        Me.txtRut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtRut.Location = New System.Drawing.Point(243, 77)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(229, 32)
        Me.txtRut.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 320)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Dirección: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 392)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Teléfono :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nombre :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "RUT :"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.Location = New System.Drawing.Point(243, 263)
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(229, 32)
        Me.txtApellidoM.TabIndex = 31
        '
        'txtApellidoP
        '
        Me.txtApellidoP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtApellidoP.Location = New System.Drawing.Point(243, 198)
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(229, 32)
        Me.txtApellidoP.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(123, 265)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 24)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Apellido M :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(128, 197)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 24)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Apellido P :"
        '
        'txtComuna
        '
        Me.txtComuna.Location = New System.Drawing.Point(243, 446)
        Me.txtComuna.Name = "txtComuna"
        Me.txtComuna.Size = New System.Drawing.Size(229, 32)
        Me.txtComuna.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(123, 452)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 24)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Comuna: "
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(243, 384)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(229, 32)
        Me.txtTelefono.TabIndex = 34
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 45
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(12, 11)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(108, 40)
        Me.IconButton1.TabIndex = 35
        Me.IconButton1.Text = "Volver"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Red
        Me.BtnEliminar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.UsersSlash
        Me.BtnEliminar.IconColor = System.Drawing.Color.Black
        Me.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEliminar.IconSize = 30
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.Location = New System.Drawing.Point(499, 311)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(143, 33)
        Me.BtnEliminar.TabIndex = 21
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.IconChar = FontAwesome.Sharp.IconChar.UsersGear
        Me.BtnActualizar.IconColor = System.Drawing.Color.Black
        Me.BtnActualizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnActualizar.IconSize = 30
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.Location = New System.Drawing.Point(498, 209)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(144, 33)
        Me.BtnActualizar.TabIndex = 20
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight
        Me.BtnBuscar.IconColor = System.Drawing.Color.Black
        Me.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnBuscar.IconSize = 30
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.Location = New System.Drawing.Point(499, 77)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(143, 32)
        Me.BtnBuscar.TabIndex = 19
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCrear
        '
        Me.BtnCrear.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.BtnCrear.IconColor = System.Drawing.Color.Black
        Me.BtnCrear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCrear.IconSize = 25
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.Location = New System.Drawing.Point(498, 144)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(144, 33)
        Me.BtnCrear.TabIndex = 18
        Me.BtnCrear.Text = "Crear"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.UseVisualStyleBackColor = True
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller.My.Resources.Resources._4105943_accounts_group_people_user_user_group_users_113923
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(699, 611)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtComuna)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtApellidoM)
        Me.Controls.Add(Me.txtApellidoP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FormClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents BtnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnActualizar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCrear As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApellidoM As TextBox
    Friend WithEvents txtApellidoP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtComuna As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
