<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSocios
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
        Me.TabControlSocio = New System.Windows.Forms.TabControl()
        Me.Tab_ABM_S = New System.Windows.Forms.TabPage()
        Me.TabImprecion_S = New System.Windows.Forms.TabPage()
        Me.TabControlSocio.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlSocio
        '
        Me.TabControlSocio.Controls.Add(Me.Tab_ABM_S)
        Me.TabControlSocio.Controls.Add(Me.TabImprecion_S)
        Me.TabControlSocio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlSocio.Location = New System.Drawing.Point(0, 0)
        Me.TabControlSocio.Name = "TabControlSocio"
        Me.TabControlSocio.SelectedIndex = 0
        Me.TabControlSocio.Size = New System.Drawing.Size(777, 687)
        Me.TabControlSocio.TabIndex = 6
        Me.TabControlSocio.Visible = False
        '
        'Tab_ABM_S
        '
        Me.Tab_ABM_S.BackColor = System.Drawing.SystemColors.Control
        Me.Tab_ABM_S.Location = New System.Drawing.Point(4, 22)
        Me.Tab_ABM_S.Name = "Tab_ABM_S"
        Me.Tab_ABM_S.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_ABM_S.Size = New System.Drawing.Size(792, 424)
        Me.Tab_ABM_S.TabIndex = 0
        Me.Tab_ABM_S.Text = "ABM SOCIOS"
        '
        'TabImprecion_S
        '
        Me.TabImprecion_S.BackColor = System.Drawing.SystemColors.Control
        Me.TabImprecion_S.Location = New System.Drawing.Point(4, 22)
        Me.TabImprecion_S.Name = "TabImprecion_S"
        Me.TabImprecion_S.Padding = New System.Windows.Forms.Padding(3)
        Me.TabImprecion_S.Size = New System.Drawing.Size(769, 661)
        Me.TabImprecion_S.TabIndex = 1
        Me.TabImprecion_S.Text = "Impreción SOCIOS"
        '
        'FormSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 687)
        Me.Controls.Add(Me.TabControlSocio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSocios"
        Me.Text = "FormSocios"
        Me.TabControlSocio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlSocio As TabControl
    Friend WithEvents Tab_ABM_S As TabPage
    Friend WithEvents TabImprecion_S As TabPage
End Class
