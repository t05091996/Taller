<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Repuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRealizar = New FontAwesome.Sharp.IconButton()
        Me.bnLimpiar = New FontAwesome.Sharp.IconButton()
        Me.btnResumen = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.lblDatosRepuestos = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(14, 97)
        Me.Label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(127, 23)
        Me.Label.TabIndex = 0
        Me.Label.Text = "RUT Cliente: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Repuesto: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(336, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gestión de Ventas de Repuestos"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(190, 91)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(238, 29)
        Me.txtRut.TabIndex = 5
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(190, 143)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(238, 29)
        Me.txtIdProducto.TabIndex = 6
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(190, 207)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(238, 29)
        Me.txtProducto.TabIndex = 7
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(190, 263)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(238, 29)
        Me.txtCantidad.TabIndex = 8
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Fecha, Me.Cliente, Me.Codigo, Me.Repuesto, Me.Cantidad, Me.Total})
        Me.dgvProductos.Location = New System.Drawing.Point(12, 417)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.Size = New System.Drawing.Size(994, 254)
        Me.dgvProductos.TabIndex = 15
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 150
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Repuesto
        '
        Me.Repuesto.HeaderText = "Repuesto"
        Me.Repuesto.Name = "Repuesto"
        Me.Repuesto.ReadOnly = True
        Me.Repuesto.Width = 300
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'btnRealizar
        '
        Me.btnRealizar.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.btnRealizar.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRealizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRealizar.IconSize = 40
        Me.btnRealizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRealizar.Location = New System.Drawing.Point(434, 256)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(163, 41)
        Me.btnRealizar.TabIndex = 12
        Me.btnRealizar.Text = "Realizar Venta"
        Me.btnRealizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizar.UseVisualStyleBackColor = True
        '
        'bnLimpiar
        '
        Me.bnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Tarp
        Me.bnLimpiar.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bnLimpiar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.bnLimpiar.IconSize = 40
        Me.bnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bnLimpiar.Location = New System.Drawing.Point(452, 136)
        Me.bnLimpiar.Name = "bnLimpiar"
        Me.bnLimpiar.Size = New System.Drawing.Size(115, 41)
        Me.bnLimpiar.TabIndex = 11
        Me.bnLimpiar.Text = "Limpiar"
        Me.bnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnLimpiar.UseVisualStyleBackColor = True
        '
        'btnResumen
        '
        Me.btnResumen.IconChar = FontAwesome.Sharp.IconChar.CartShopping
        Me.btnResumen.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnResumen.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnResumen.IconSize = 30
        Me.btnResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResumen.Location = New System.Drawing.Point(850, 12)
        Me.btnResumen.Name = "btnResumen"
        Me.btnResumen.Size = New System.Drawing.Size(163, 37)
        Me.btnResumen.TabIndex = 10
        Me.btnResumen.Text = "Resumen Venta"
        Me.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResumen.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAgregar.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAgregar.IconSize = 40
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(452, 89)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(115, 41)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar "
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.BackColor = System.Drawing.Color.Transparent
        Me.lblDatos.Location = New System.Drawing.Point(615, 75)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(283, 21)
        Me.lblDatos.TabIndex = 22
        Me.lblDatos.Text = "jnunuhbnuhbnuhbuh\n iuhyubi8uniun"
        '
        'btnVolver
        '
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft
        Me.btnVolver.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.IconSize = 45
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.Location = New System.Drawing.Point(12, 9)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(108, 40)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblDatosRepuestos
        '
        Me.lblDatosRepuestos.AutoSize = True
        Me.lblDatosRepuestos.BackColor = System.Drawing.Color.Transparent
        Me.lblDatosRepuestos.Location = New System.Drawing.Point(615, 156)
        Me.lblDatosRepuestos.Name = "lblDatosRepuestos"
        Me.lblDatosRepuestos.Size = New System.Drawing.Size(283, 21)
        Me.lblDatosRepuestos.TabIndex = 24
        Me.lblDatosRepuestos.Text = "jnunuhbnuhbnuhbuh\n iuhyubi8uniun"
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller.My.Resources.Resources.onlineshopping_117952
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1025, 683)
        Me.Controls.Add(Me.lblDatosRepuestos)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnRealizar)
        Me.Controls.Add(Me.bnLimpiar)
        Me.Controls.Add(Me.btnResumen)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Ventas de Repuestos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnResumen As FontAwesome.Sharp.IconButton
    Friend WithEvents bnLimpiar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRealizar As FontAwesome.Sharp.IconButton
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents lblDatos As Label
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents lblDatosRepuestos As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Repuesto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
