<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.lbl_Info = New System.Windows.Forms.Label()
        Me.lbl_Privilegio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 143)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido, elige una opción: "
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.List
        Me.IconButton1.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(1, -1)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(76, 31)
        Me.IconButton1.TabIndex = 6
        Me.IconButton1.Text = "Inicio"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Dolly
        Me.IconButton2.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.Location = New System.Drawing.Point(34, 221)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(227, 46)
        Me.IconButton2.TabIndex = 7
        Me.IconButton2.Text = "Gestión de Repuestos"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Gears
        Me.IconButton3.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton3.Location = New System.Drawing.Point(267, 221)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(226, 46)
        Me.IconButton3.TabIndex = 8
        Me.IconButton3.Text = "Gestión de Ventas de Repuestos"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Paperclip
        Me.IconButton4.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 40
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton4.Location = New System.Drawing.Point(34, 273)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(227, 40)
        Me.IconButton4.TabIndex = 9
        Me.IconButton4.Text = "Gestión de Solicitudes de servicio"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton5
        '
        Me.IconButton5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.FireFlameCurved
        Me.IconButton5.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 35
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton5.Location = New System.Drawing.Point(267, 273)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(226, 40)
        Me.IconButton5.TabIndex = 10
        Me.IconButton5.Text = "Gestión de Siniestros"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'lbl_Info
        '
        Me.lbl_Info.AutoSize = True
        Me.lbl_Info.Location = New System.Drawing.Point(239, 9)
        Me.lbl_Info.Name = "lbl_Info"
        Me.lbl_Info.Size = New System.Drawing.Size(171, 21)
        Me.lbl_Info.TabIndex = 11
        Me.lbl_Info.Text = "Usuario: Aseguradora"
        '
        'lbl_Privilegio
        '
        Me.lbl_Privilegio.AutoSize = True
        Me.lbl_Privilegio.Location = New System.Drawing.Point(239, 43)
        Me.lbl_Privilegio.Name = "lbl_Privilegio"
        Me.lbl_Privilegio.Size = New System.Drawing.Size(88, 21)
        Me.lbl_Privilegio.TabIndex = 12
        Me.lbl_Privilegio.Text = "Privilegio: "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller.My.Resources.Resources.deliverytruck_106577
        Me.ClientSize = New System.Drawing.Size(510, 498)
        Me.Controls.Add(Me.lbl_Privilegio)
        Me.Controls.Add(Me.lbl_Info)
        Me.Controls.Add(Me.IconButton5)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_Info As Label
    Friend WithEvents lbl_Privilegio As Label
End Class
