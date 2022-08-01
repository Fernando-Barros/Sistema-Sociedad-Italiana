<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Localidad
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
        Me.But_Acepto = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LabPais = New System.Windows.Forms.Label
        Me.TextB_Localidad = New System.Windows.Forms.TextBox
        Me.But_Modificar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'But_Acepto
        '
        Me.But_Acepto.Location = New System.Drawing.Point(12, 112)
        Me.But_Acepto.Name = "But_Acepto"
        Me.But_Acepto.Size = New System.Drawing.Size(77, 24)
        Me.But_Acepto.TabIndex = 2
        Me.But_Acepto.Text = "Agregar"
        Me.But_Acepto.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(186, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabPais
        '
        Me.LabPais.AutoSize = True
        Me.LabPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabPais.Location = New System.Drawing.Point(9, 45)
        Me.LabPais.Name = "LabPais"
        Me.LabPais.Size = New System.Drawing.Size(61, 15)
        Me.LabPais.TabIndex = 2
        Me.LabPais.Text = "Localidad"
        '
        'TextB_Localidad
        '
        Me.TextB_Localidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextB_Localidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextB_Localidad.Location = New System.Drawing.Point(73, 44)
        Me.TextB_Localidad.Name = "TextB_Localidad"
        Me.TextB_Localidad.Size = New System.Drawing.Size(174, 20)
        Me.TextB_Localidad.TabIndex = 1
        '
        'But_Modificar
        '
        Me.But_Modificar.Location = New System.Drawing.Point(99, 112)
        Me.But_Modificar.Name = "But_Modificar"
        Me.But_Modificar.Size = New System.Drawing.Size(77, 24)
        Me.But_Modificar.TabIndex = 4
        Me.But_Modificar.Text = "Modificar"
        Me.But_Modificar.UseVisualStyleBackColor = True
        '
        'Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(275, 148)
        Me.Controls.Add(Me.But_Modificar)
        Me.Controls.Add(Me.TextB_Localidad)
        Me.Controls.Add(Me.LabPais)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.But_Acepto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Localidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Localidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_Acepto As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LabPais As System.Windows.Forms.Label
    Friend WithEvents TextB_Localidad As System.Windows.Forms.TextBox
    Friend WithEvents But_Modificar As System.Windows.Forms.Button
End Class
