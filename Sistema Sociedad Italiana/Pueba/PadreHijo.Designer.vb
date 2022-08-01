<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PadreHijo
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
        Me.ToolStripContainerPadre = New System.Windows.Forms.ToolStripContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStripContainerPadre.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainerPadre
        '
        Me.ToolStripContainerPadre.BottomToolStripPanelVisible = False
        '
        'ToolStripContainerPadre.ContentPanel
        '
        Me.ToolStripContainerPadre.ContentPanel.Size = New System.Drawing.Size(704, 450)
        Me.ToolStripContainerPadre.LeftToolStripPanelVisible = False
        Me.ToolStripContainerPadre.Location = New System.Drawing.Point(98, 0)
        Me.ToolStripContainerPadre.Name = "ToolStripContainerPadre"
        Me.ToolStripContainerPadre.RightToolStripPanelVisible = False
        Me.ToolStripContainerPadre.Size = New System.Drawing.Size(704, 450)
        Me.ToolStripContainerPadre.TabIndex = 0
        Me.ToolStripContainerPadre.Text = "ToolStripContainer1"
        Me.ToolStripContainerPadre.TopToolStripPanelVisible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PadreHijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStripContainerPadre)
        Me.IsMdiContainer = True
        Me.Name = "PadreHijo"
        Me.Text = "PadreHijo"
        Me.ToolStripContainerPadre.ResumeLayout(False)
        Me.ToolStripContainerPadre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainerPadre As ToolStripContainer
    Friend WithEvents Button1 As Button
End Class
