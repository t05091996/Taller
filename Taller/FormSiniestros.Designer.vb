<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSiniestros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSiniestros))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtRutC = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblDatosRepuestos = New System.Windows.Forms.Label()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.BtnEliminar = New FontAwesome.Sharp.IconButton()
        Me.BtnActualizar = New FontAwesome.Sharp.IconButton()
        Me.BtnCrear = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.bnLimpiar = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 147)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rut Compañía:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 325)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado de Siniestro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(474, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gestión de Siniestros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 275)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado del Seguro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 371)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Detalle:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 421)
        Me.Label9.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Código Siniestro:"
        '
        'txtDetalle
        '
        Me.txtDetalle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(211, 365)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(247, 29)
        Me.txtDetalle.TabIndex = 9
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(213, 146)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(247, 29)
        Me.txtRut.TabIndex = 10
        '
        'txtRutC
        '
        Me.txtRutC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutC.Location = New System.Drawing.Point(211, 223)
        Me.txtRutC.Name = "txtRutC"
        Me.txtRutC.Size = New System.Drawing.Size(247, 29)
        Me.txtRutC.TabIndex = 11
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(211, 420)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(247, 29)
        Me.txtId.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(211, 322)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(247, 29)
        Me.ComboBox1.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(213, 83)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(247, 32)
        Me.DateTimePicker1.TabIndex = 14
        '
        'lblDatosRepuestos
        '
        Me.lblDatosRepuestos.AutoSize = True
        Me.lblDatosRepuestos.BackColor = System.Drawing.Color.Transparent
        Me.lblDatosRepuestos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosRepuestos.Location = New System.Drawing.Point(522, 231)
        Me.lblDatosRepuestos.Name = "lblDatosRepuestos"
        Me.lblDatosRepuestos.Size = New System.Drawing.Size(283, 21)
        Me.lblDatosRepuestos.TabIndex = 26
        Me.lblDatosRepuestos.Text = "jnunuhbnuhbnuhbuh\n iuhyubi8uniun"
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.BackColor = System.Drawing.Color.Transparent
        Me.lblDatos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.Location = New System.Drawing.Point(524, 146)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(283, 21)
        Me.lblDatos.TabIndex = 25
        Me.lblDatos.Text = "jnunuhbnuhbnuhbuh\n iuhyubi8uniun"
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
        Me.BtnEliminar.Location = New System.Drawing.Point(291, 589)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(146, 50)
        Me.BtnEliminar.TabIndex = 30
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
        Me.BtnActualizar.Location = New System.Drawing.Point(31, 589)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(143, 50)
        Me.BtnActualizar.TabIndex = 29
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnCrear
        '
        Me.BtnCrear.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.BtnCrear.IconColor = System.Drawing.Color.Black
        Me.BtnCrear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCrear.IconSize = 25
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.Location = New System.Drawing.Point(31, 512)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(143, 50)
        Me.BtnCrear.TabIndex = 27
        Me.BtnCrear.Text = "Crear"
        Me.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrear.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(797, 9)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(196, 40)
        Me.IconButton1.TabIndex = 31
        Me.IconButton1.Text = "Búsqueda Avanzada"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(211, 272)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(247, 29)
        Me.ComboBox2.TabIndex = 32
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft
        Me.btnVolver.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.IconSize = 45
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.Location = New System.Drawing.Point(13, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(167, 40)
        Me.btnVolver.TabIndex = 33
        Me.btnVolver.Text = "Menú Principal"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'bnLimpiar
        '
        Me.bnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Tarp
        Me.bnLimpiar.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bnLimpiar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.bnLimpiar.IconSize = 40
        Me.bnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnLimpiar.Location = New System.Drawing.Point(291, 512)
        Me.bnLimpiar.Name = "bnLimpiar"
        Me.bnLimpiar.Size = New System.Drawing.Size(144, 50)
        Me.bnLimpiar.TabIndex = 34
        Me.bnLimpiar.Text = "Limpiar"
        Me.bnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnLimpiar.UseVisualStyleBackColor = True
        '
        'FormSiniestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller.My.Resources.Resources.graphmagnifier_118081
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1005, 653)
        Me.Controls.Add(Me.bnLimpiar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.lblDatosRepuestos)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtRutC)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "FormSiniestros"
        Me.Text = "Gestión de Siniestros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtRutC As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblDatosRepuestos As Label
    Friend WithEvents lblDatos As Label
    Friend WithEvents BtnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnActualizar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCrear As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents bnLimpiar As FontAwesome.Sharp.IconButton
End Class
