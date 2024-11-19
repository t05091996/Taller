<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSolicitudSiniestro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitudSiniestro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSiniestro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbDatosClientes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbDatosSiniestro = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscarGroup = New FontAwesome.Sharp.IconButton()
        Me.cbEstadoGroup = New System.Windows.Forms.ComboBox()
        Me.txtNombreClienteGroup = New System.Windows.Forms.TextBox()
        Me.dgvSolicitud = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_siniestro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_Siniestro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Compania = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_Seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.btnLimpiar = New FontAwesome.Sharp.IconButton()
        Me.btnActualizar = New FontAwesome.Sharp.IconButton()
        Me.dtpFechaSiniestro = New System.Windows.Forms.DateTimePicker()
        Me.txtRutCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.dtFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(424, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solicitudes de Servicios"
        '
        'cbSiniestro
        '
        Me.cbSiniestro.FormattingEnabled = True
        Me.cbSiniestro.Location = New System.Drawing.Point(24, 71)
        Me.cbSiniestro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSiniestro.Name = "cbSiniestro"
        Me.cbSiniestro.Size = New System.Drawing.Size(291, 29)
        Me.cbSiniestro.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Siniestro"
        '
        'lbDatosClientes
        '
        Me.lbDatosClientes.BackColor = System.Drawing.Color.Transparent
        Me.lbDatosClientes.Location = New System.Drawing.Point(20, 185)
        Me.lbDatosClientes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDatosClientes.Name = "lbDatosClientes"
        Me.lbDatosClientes.Size = New System.Drawing.Size(295, 50)
        Me.lbDatosClientes.TabIndex = 3
        Me.lbDatosClientes.Text = "Datos Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 4
        '
        'lbDatosSiniestro
        '
        Me.lbDatosSiniestro.BackColor = System.Drawing.Color.Transparent
        Me.lbDatosSiniestro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbDatosSiniestro.Location = New System.Drawing.Point(381, 116)
        Me.lbDatosSiniestro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDatosSiniestro.Name = "lbDatosSiniestro"
        Me.lbDatosSiniestro.Size = New System.Drawing.Size(362, 140)
        Me.lbDatosSiniestro.TabIndex = 5
        Me.lbDatosSiniestro.Text = "Datos siniestro"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.BackColor = System.Drawing.Color.Transparent
        Me.lbFecha.Location = New System.Drawing.Point(382, 46)
        Me.lbFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(122, 21)
        Me.lbFecha.TabIndex = 6
        Me.lbFecha.Text = "Fecha siniestro"
        Me.lbFecha.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 235)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripción"
        Me.Label3.UseMnemonic = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(21, 260)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(294, 72)
        Me.txtDescripcion.TabIndex = 8
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Completado", "Pendiente"})
        Me.cbEstado.Location = New System.Drawing.Point(21, 370)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(291, 29)
        Me.cbEstado.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 346)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Estado"
        Me.Label5.UseMnemonic = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnBuscarGroup)
        Me.GroupBox1.Controls.Add(Me.cbEstadoGroup)
        Me.GroupBox1.Controls.Add(Me.txtNombreClienteGroup)
        Me.GroupBox1.Controls.Add(Me.dgvSolicitud)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 419)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1040, 302)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nombre Cliente"
        '
        'btnBuscarGroup
        '
        Me.btnBuscarGroup.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarGroup.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        Me.btnBuscarGroup.IconColor = System.Drawing.Color.Black
        Me.btnBuscarGroup.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscarGroup.IconSize = 40
        Me.btnBuscarGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarGroup.Location = New System.Drawing.Point(737, 40)
        Me.btnBuscarGroup.Name = "btnBuscarGroup"
        Me.btnBuscarGroup.Size = New System.Drawing.Size(120, 53)
        Me.btnBuscarGroup.TabIndex = 3
        Me.btnBuscarGroup.Text = "Buscar"
        Me.btnBuscarGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarGroup.UseVisualStyleBackColor = True
        '
        'cbEstadoGroup
        '
        Me.cbEstadoGroup.FormattingEnabled = True
        Me.cbEstadoGroup.Items.AddRange(New Object() {"Todo", "Completado", "Pendiente"})
        Me.cbEstadoGroup.Location = New System.Drawing.Point(308, 64)
        Me.cbEstadoGroup.Name = "cbEstadoGroup"
        Me.cbEstadoGroup.Size = New System.Drawing.Size(308, 27)
        Me.cbEstadoGroup.TabIndex = 2
        '
        'txtNombreClienteGroup
        '
        Me.txtNombreClienteGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreClienteGroup.Location = New System.Drawing.Point(10, 64)
        Me.txtNombreClienteGroup.Name = "txtNombreClienteGroup"
        Me.txtNombreClienteGroup.Size = New System.Drawing.Size(289, 26)
        Me.txtNombreClienteGroup.TabIndex = 1
        '
        'dgvSolicitud
        '
        Me.dgvSolicitud.AllowUserToAddRows = False
        Me.dgvSolicitud.AllowUserToDeleteRows = False
        Me.dgvSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitud.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha_solicitud, Me.fecha_siniestro, Me.Cliente, Me.Descripcion, Me.Estado_Siniestro, Me.Nombre_Compania, Me.Estado_Seguro, Me.Estado_Servicio})
        Me.dgvSolicitud.Location = New System.Drawing.Point(11, 99)
        Me.dgvSolicitud.Name = "dgvSolicitud"
        Me.dgvSolicitud.ReadOnly = True
        Me.dgvSolicitud.Size = New System.Drawing.Size(1022, 196)
        Me.dgvSolicitud.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "#"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 20
        '
        'fecha_solicitud
        '
        Me.fecha_solicitud.HeaderText = "Fecha Solicitud"
        Me.fecha_solicitud.Name = "fecha_solicitud"
        Me.fecha_solicitud.ReadOnly = True
        Me.fecha_solicitud.Width = 85
        '
        'fecha_siniestro
        '
        Me.fecha_siniestro.HeaderText = "Fecha Siniestro"
        Me.fecha_siniestro.Name = "fecha_siniestro"
        Me.fecha_siniestro.ReadOnly = True
        Me.fecha_siniestro.Width = 85
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 160
        '
        'Estado_Siniestro
        '
        Me.Estado_Siniestro.HeaderText = "Estado Siniestro"
        Me.Estado_Siniestro.Name = "Estado_Siniestro"
        Me.Estado_Siniestro.ReadOnly = True
        '
        'Nombre_Compania
        '
        Me.Nombre_Compania.HeaderText = "Nombre Compañia"
        Me.Nombre_Compania.Name = "Nombre_Compania"
        Me.Nombre_Compania.ReadOnly = True
        Me.Nombre_Compania.Width = 200
        '
        'Estado_Seguro
        '
        Me.Estado_Seguro.HeaderText = "Estado Seguro"
        Me.Estado_Seguro.Name = "Estado_Seguro"
        Me.Estado_Seguro.ReadOnly = True
        Me.Estado_Seguro.Width = 120
        '
        'Estado_Servicio
        '
        Me.Estado_Servicio.HeaderText = "Estado Servicio"
        Me.Estado_Servicio.Name = "Estado_Servicio"
        Me.Estado_Servicio.ReadOnly = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.btnGuardar.IconColor = System.Drawing.Color.Black
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 35
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(903, 46)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 38)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btnLimpiar.IconColor = System.Drawing.Color.Black
        Me.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLimpiar.IconSize = 35
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.Location = New System.Drawing.Point(903, 99)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(150, 38)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.PenAlt
        Me.btnActualizar.IconColor = System.Drawing.Color.Black
        Me.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnActualizar.IconSize = 35
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.Location = New System.Drawing.Point(903, 157)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(150, 38)
        Me.btnActualizar.TabIndex = 14
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'dtpFechaSiniestro
        '
        Me.dtpFechaSiniestro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSiniestro.Location = New System.Drawing.Point(386, 71)
        Me.dtpFechaSiniestro.Name = "dtpFechaSiniestro"
        Me.dtpFechaSiniestro.Size = New System.Drawing.Size(132, 29)
        Me.dtpFechaSiniestro.TabIndex = 15
        '
        'txtRutCliente
        '
        Me.txtRutCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRutCliente.Location = New System.Drawing.Point(23, 140)
        Me.txtRutCliente.Name = "txtRutCliente"
        Me.txtRutCliente.Size = New System.Drawing.Size(193, 29)
        Me.txtRutCliente.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "RUT Cliente"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(4, 7)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(91, 36)
        Me.IconButton1.TabIndex = 18
        Me.IconButton1.Text = "Atrás"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'dtFechaSolicitud
        '
        Me.dtFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaSolicitud.Location = New System.Drawing.Point(562, 71)
        Me.dtFechaSolicitud.Name = "dtFechaSolicitud"
        Me.dtFechaSolicitud.Size = New System.Drawing.Size(132, 29)
        Me.dtFechaSolicitud.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(558, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fecha Solicitud"
        Me.Label9.UseMnemonic = False
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(746, 46)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(20, 21)
        Me.lbID.TabIndex = 21
        Me.lbID.Text = "#"
        Me.lbID.Visible = False
        '
        'FormSolicitudSiniestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Taller.My.Resources.Resources.applicationpresentation_103662
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1066, 725)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.dtFechaSolicitud)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRutCliente)
        Me.Controls.Add(Me.dtpFechaSiniestro)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbDatosSiniestro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbDatosClientes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbSiniestro)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSolicitudSiniestro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Servicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbSiniestro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbDatosClientes As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbDatosSiniestro As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLimpiar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnActualizar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBuscarGroup As FontAwesome.Sharp.IconButton
    Friend WithEvents cbEstadoGroup As ComboBox
    Friend WithEvents txtNombreClienteGroup As TextBox
    Friend WithEvents dgvSolicitud As DataGridView
    Friend WithEvents dtpFechaSiniestro As DateTimePicker
    Friend WithEvents txtRutCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents dtFechaSolicitud As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents lbID As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents fecha_solicitud As DataGridViewTextBoxColumn
    Friend WithEvents fecha_siniestro As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Estado_Siniestro As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Compania As DataGridViewTextBoxColumn
    Friend WithEvents Estado_Seguro As DataGridViewTextBoxColumn
    Friend WithEvents Estado_Servicio As DataGridViewTextBoxColumn
End Class
