<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusquedaSiniestro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBusquedaSiniestro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.dgvSiniestro = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.siniestro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rut_Compania = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_Seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.BtnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnModificar = New FontAwesome.Sharp.IconButton()
        CType(Me.dgvSiniestro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT Cliente:"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(12, 124)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(204, 26)
        Me.txtRut.TabIndex = 3
        '
        'dgvSiniestro
        '
        Me.dgvSiniestro.AllowUserToAddRows = False
        Me.dgvSiniestro.AllowUserToDeleteRows = False
        Me.dgvSiniestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSiniestro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Detalle, Me.siniestro, Me.Nombre_Cliente, Me.Rut_Compania, Me.Estado_Seguro})
        Me.dgvSiniestro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvSiniestro.Location = New System.Drawing.Point(10, 178)
        Me.dgvSiniestro.Name = "dgvSiniestro"
        Me.dgvSiniestro.Size = New System.Drawing.Size(949, 238)
        Me.dgvSiniestro.TabIndex = 6
        '
        'Id
        '
        Me.Id.HeaderText = "#"
        Me.Id.Name = "Id"
        Me.Id.Width = 50
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Detalle
        '
        Me.Detalle.HeaderText = "Descripción"
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Width = 250
        '
        'siniestro
        '
        Me.siniestro.HeaderText = "Estado "
        Me.siniestro.Name = "siniestro"
        '
        'Nombre_Cliente
        '
        Me.Nombre_Cliente.HeaderText = "Cliente"
        Me.Nombre_Cliente.Name = "Nombre_Cliente"
        '
        'Rut_Compania
        '
        Me.Rut_Compania.HeaderText = "Compañia"
        Me.Rut_Compania.Name = "Rut_Compania"
        '
        'Estado_Seguro
        '
        Me.Estado_Seguro.HeaderText = "Seguro"
        Me.Estado_Seguro.Name = "Estado_Seguro"
        Me.Estado_Seguro.Width = 200
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft
        Me.btnVolver.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.IconSize = 30
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(182, 40)
        Me.btnVolver.TabIndex = 34
        Me.btnVolver.Text = "Volver a Siniestros"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Estado Siniestro:"
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Todo", "Activo", "Pendiente", "Finalizado"})
        Me.cbEstado.Location = New System.Drawing.Point(242, 123)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(204, 27)
        Me.cbEstado.TabIndex = 36
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight
        Me.btnBuscar.IconColor = System.Drawing.Color.Black
        Me.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(470, 97)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(131, 53)
        Me.btnBuscar.TabIndex = 37
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        Me.BtnEliminar.Location = New System.Drawing.Point(526, 455)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(146, 50)
        Me.BtnEliminar.TabIndex = 38
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Gears
        Me.btnModificar.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnModificar.IconSize = 40
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.Location = New System.Drawing.Point(199, 456)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(139, 50)
        Me.btnModificar.TabIndex = 39
        Me.btnModificar.Text = "Actualizar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'FormBusquedaSiniestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller.My.Resources.Resources.magnifier_and_car_icon_icons_com_71919
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(971, 544)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvSiniestro)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBusquedaSiniestro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda Avanzada"
        CType(Me.dgvSiniestro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents dgvSiniestro As DataGridView
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Detalle As DataGridViewTextBoxColumn
    Friend WithEvents siniestro As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Rut_Compania As DataGridViewTextBoxColumn
    Friend WithEvents Estado_Seguro As DataGridViewTextBoxColumn
End Class
