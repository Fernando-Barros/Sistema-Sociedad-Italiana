<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prueva
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
        Me.Button_buscar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.text_num = New System.Windows.Forms.TextBox
        Me.Label_Psocioion = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextEncryp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextDesencryp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button_buscar
        '
        Me.Button_buscar.Location = New System.Drawing.Point(116, 159)
        Me.Button_buscar.Name = "Button_buscar"
        Me.Button_buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_buscar.TabIndex = 0
        Me.Button_buscar.Text = "Buscar"
        Me.Button_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "numero"
        '
        'text_num
        '
        Me.text_num.Location = New System.Drawing.Point(60, 12)
        Me.text_num.Name = "text_num"
        Me.text_num.Size = New System.Drawing.Size(212, 20)
        Me.text_num.TabIndex = 2
        '
        'Label_Psocioion
        '
        Me.Label_Psocioion.AutoSize = True
        Me.Label_Psocioion.Location = New System.Drawing.Point(113, 101)
        Me.Label_Psocioion.Name = "Label_Psocioion"
        Me.Label_Psocioion.Size = New System.Drawing.Size(0, 13)
        Me.Label_Psocioion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'TextEncryp
        '
        Me.TextEncryp.Location = New System.Drawing.Point(60, 51)
        Me.TextEncryp.Name = "TextEncryp"
        Me.TextEncryp.Size = New System.Drawing.Size(212, 20)
        Me.TextEncryp.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "encryp"
        '
        'TextDesencryp
        '
        Me.TextDesencryp.Location = New System.Drawing.Point(60, 94)
        Me.TextDesencryp.Name = "TextDesencryp"
        Me.TextDesencryp.Size = New System.Drawing.Size(212, 20)
        Me.TextDesencryp.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "desencryp"
        '
        'prueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextDesencryp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextEncryp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_Psocioion)
        Me.Controls.Add(Me.text_num)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_buscar)
        Me.Name = "prueva"
        Me.Text = "prueva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents text_num As System.Windows.Forms.TextBox
    Friend WithEvents Label_Psocioion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextEncryp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextDesencryp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
