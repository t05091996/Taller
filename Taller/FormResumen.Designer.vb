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
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRepuesto = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.dgvResumen = New System.Windows.Forms.DataGridView()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnBuscar.IconColor = System.Drawing.Color.Black
        Me.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(699, 30)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(131, 53)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre del Repuesto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Rut Cliente:"
        '
        'txtRepuesto
        '
        Me.txtRepuesto.Location = New System.Drawing.Point(176, 54)
        Me.txtRepuesto.Name = "txtRepuesto"
        Me.txtRepuesto.Size = New System.Drawing.Size(275, 29)
        Me.txtRepuesto.TabIndex = 6
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(468, 54)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(210, 29)
        Me.txtRut.TabIndex = 8
        '
        'dgvResumen
        '
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumen.Location = New System.Drawing.Point(12, 119)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.Size = New System.Drawing.Size(818, 354)
        Me.dgvResumen.TabIndex = 11
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(12, 54)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(142, 29)
        Me.txtFecha.TabIndex = 12
        Me.txtFecha.Value = New Date(2024, 11, 5, 17, 20, 54, 0)
        '
        'FormResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 485)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.dgvResumen)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtRepuesto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormResumen"
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
    Friend WithEvents txtFecha As DateTimePicker
End Class
