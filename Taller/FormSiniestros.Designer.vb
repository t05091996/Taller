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
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.cbSiniestro = New System.Windows.Forms.ComboBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.BtnCrear = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.cbSeguro = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.bnLimpiar = New FontAwesome.Sharp.IconButton()
        Me.cbCompania = New System.Windows.Forms.ComboBox()
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
        Me.Label2.Location = New System.Drawing.Point(25, 201)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Compañía:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 314)
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
        Me.Label5.Location = New System.Drawing.Point(306, 14)
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
        Me.Label6.Location = New System.Drawing.Point(25, 253)
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
        Me.Label7.Location = New System.Drawing.Point(25, 379)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Detalle:"
        '
        'txtDetalle
        '
        Me.txtDetalle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(211, 373)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(237, 29)
        Me.txtDetalle.TabIndex = 9
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(213, 146)
        Me.txtRut.MaxLength = 9
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(235, 29)
        Me.txtRut.TabIndex = 10
        '
        'cbSiniestro
        '
        Me.cbSiniestro.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSiniestro.FormattingEnabled = True
        Me.cbSiniestro.Items.AddRange(New Object() {"Activo", "Pendiente", "Finalizado"})
        Me.cbSiniestro.Location = New System.Drawing.Point(211, 311)
        Me.cbSiniestro.Name = "cbSiniestro"
        Me.cbSiniestro.Size = New System.Drawing.Size(237, 29)
        Me.cbSiniestro.TabIndex = 13
        '
        'dtFecha
        '
        Me.dtFecha.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(213, 83)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(142, 32)
        Me.dtFecha.TabIndex = 14
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.BackColor = System.Drawing.Color.Transparent
        Me.lblDatos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.Location = New System.Drawing.Point(454, 149)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(283, 21)
        Me.lblDatos.TabIndex = 25
        Me.lblDatos.Text = "jnunuhbnuhbnuhbuh\n iuhyubi8uniun"
        '
        'BtnCrear
        '
        Me.BtnCrear.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrear.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.BtnCrear.IconColor = System.Drawing.Color.Black
        Me.BtnCrear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCrear.IconSize = 25
        Me.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCrear.Location = New System.Drawing.Point(29, 435)
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
        Me.IconButton1.Location = New System.Drawing.Point(629, 9)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(196, 40)
        Me.IconButton1.TabIndex = 31
        Me.IconButton1.Text = "Búsqueda Avanzada"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'cbSeguro
        '
        Me.cbSeguro.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSeguro.FormattingEnabled = True
        Me.cbSeguro.Items.AddRange(New Object() {"Vigente", "Caducado"})
        Me.cbSeguro.Location = New System.Drawing.Point(211, 250)
        Me.cbSeguro.Name = "cbSeguro"
        Me.cbSeguro.Size = New System.Drawing.Size(237, 29)
        Me.cbSeguro.TabIndex = 32
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
        Me.bnLimpiar.Location = New System.Drawing.Point(289, 435)
        Me.bnLimpiar.Name = "bnLimpiar"
        Me.bnLimpiar.Size = New System.Drawing.Size(144, 50)
        Me.bnLimpiar.TabIndex = 34
        Me.bnLimpiar.Text = "Limpiar"
        Me.bnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnLimpiar.UseVisualStyleBackColor = True
        '
        'cbCompania
        '
        Me.cbCompania.DropDownWidth = 710
        Me.cbCompania.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.cbCompania.FormattingEnabled = True
        Me.cbCompania.Location = New System.Drawing.Point(211, 195)
        Me.cbCompania.Name = "cbCompania"
        Me.cbCompania.Size = New System.Drawing.Size(308, 29)
        Me.cbCompania.TabIndex = 35
        '
        'FormSiniestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller.My.Resources.Resources.graphmagnifier_118081
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(829, 518)
        Me.Controls.Add(Me.cbCompania)
        Me.Controls.Add(Me.bnLimpiar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.cbSeguro)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.cbSiniestro)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSiniestros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents cbSiniestro As ComboBox
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents lblDatos As Label
    Friend WithEvents BtnCrear As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents cbSeguro As ComboBox
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents bnLimpiar As FontAwesome.Sharp.IconButton
    Friend WithEvents cbCompania As ComboBox
End Class
