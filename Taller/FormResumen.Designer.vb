<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResumen
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormResumen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRepuesto = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.dgvResumen = New System.Windows.Forms.DataGridView()
        Me.txtFechaD = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaH = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.NVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre del Repuesto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(619, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Rut Cliente:"
        '
        'txtRepuesto
        '
        Me.txtRepuesto.Location = New System.Drawing.Point(332, 54)
        Me.txtRepuesto.Name = "txtRepuesto"
        Me.txtRepuesto.Size = New System.Drawing.Size(275, 29)
        Me.txtRepuesto.TabIndex = 6
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(623, 54)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(155, 29)
        Me.txtRut.TabIndex = 8
        '
        'dgvResumen
        '
        Me.dgvResumen.AllowUserToAddRows = False
        Me.dgvResumen.AllowUserToDeleteRows = False
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NVenta, Me.Fecha, Me.Rut, Me.Articulo, Me.Cantidad, Me.Total})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResumen.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResumen.Location = New System.Drawing.Point(12, 119)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResumen.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResumen.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResumen.Size = New System.Drawing.Size(972, 354)
        Me.dgvResumen.TabIndex = 11
        '
        'txtFechaD
        '
        Me.txtFechaD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaD.Location = New System.Drawing.Point(12, 54)
        Me.txtFechaD.Name = "txtFechaD"
        Me.txtFechaD.Size = New System.Drawing.Size(142, 29)
        Me.txtFechaD.TabIndex = 12
        Me.txtFechaD.Value = New Date(2024, 11, 5, 17, 20, 54, 0)
        '
        'txtFechaH
        '
        Me.txtFechaH.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaH.Location = New System.Drawing.Point(171, 54)
        Me.txtFechaH.Name = "txtFechaH"
        Me.txtFechaH.Size = New System.Drawing.Size(142, 29)
        Me.txtFechaH.TabIndex = 14
        Me.txtFechaH.Value = New Date(2024, 11, 5, 17, 20, 54, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha hasta:"
        '
        'btnBuscar
        '
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight
        Me.btnBuscar.IconColor = System.Drawing.Color.Black
        Me.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(815, 30)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(131, 53)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'NVenta
        '
        Me.NVenta.HeaderText = "N° Venta"
        Me.NVenta.Name = "NVenta"
        Me.NVenta.ReadOnly = True
        Me.NVenta.Width = 120
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha de Venta"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 200
        '
        'Rut
        '
        Me.Rut.HeaderText = "Cliente"
        Me.Rut.Name = "Rut"
        Me.Rut.ReadOnly = True
        Me.Rut.Width = 120
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Artículo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.Width = 270
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 110
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'FormResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 485)
        Me.Controls.Add(Me.txtFechaH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFechaD)
        Me.Controls.Add(Me.dgvResumen)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtRepuesto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen Venta"
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRepuesto As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents dgvResumen As DataGridView
    Friend WithEvents txtFechaD As DateTimePicker
    Friend WithEvents txtFechaH As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents NVenta As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Rut As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
