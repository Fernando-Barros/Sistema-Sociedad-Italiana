<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.But_Biblioteca = New System.Windows.Forms.Button
        Me.But_Escuela = New System.Windows.Forms.Button
        Me.But_Alquiler = New System.Windows.Forms.Button
        Me.But_Socios = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumBlue
        Me.Panel1.Controls.Add(Me.But_Biblioteca)
        Me.Panel1.Controls.Add(Me.But_Escuela)
        Me.Panel1.Controls.Add(Me.But_Alquiler)
        Me.Panel1.Controls.Add(Me.But_Socios)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 538)
        Me.Panel1.TabIndex = 1
        '
        'But_Biblioteca
        '
        Me.But_Biblioteca.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.But_Biblioteca.BackColor = System.Drawing.Color.Transparent
        Me.But_Biblioteca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.But_Biblioteca.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.But_Biblioteca.FlatAppearance.BorderSize = 0
        Me.But_Biblioteca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.But_Biblioteca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.But_Biblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_Biblioteca.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Biblioteca.ForeColor = System.Drawing.Color.White
        Me.But_Biblioteca.Image = CType(resources.GetObject("But_Biblioteca.Image"), System.Drawing.Image)
        Me.But_Biblioteca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_Biblioteca.Location = New System.Drawing.Point(1, 333)
        Me.But_Biblioteca.Name = "But_Biblioteca"
        Me.But_Biblioteca.Size = New System.Drawing.Size(137, 53)
        Me.But_Biblioteca.TabIndex = 3
        Me.But_Biblioteca.Text = "Biblioteca"
        Me.But_Biblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_Biblioteca.UseVisualStyleBackColor = False
        '
        'But_Escuela
        '
        Me.But_Escuela.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.But_Escuela.BackColor = System.Drawing.Color.Transparent
        Me.But_Escuela.Cursor = System.Windows.Forms.Cursors.Hand
        Me.But_Escuela.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.But_Escuela.FlatAppearance.BorderSize = 0
        Me.But_Escuela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.But_Escuela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.But_Escuela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_Escuela.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Escuela.ForeColor = System.Drawing.Color.White
        Me.But_Escuela.Image = CType(resources.GetObject("But_Escuela.Image"), System.Drawing.Image)
        Me.But_Escuela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_Escuela.Location = New System.Drawing.Point(0, 184)
        Me.But_Escuela.Name = "But_Escuela"
        Me.But_Escuela.Size = New System.Drawing.Size(137, 53)
        Me.But_Escuela.TabIndex = 2
        Me.But_Escuela.Text = "Escuela"
        Me.But_Escuela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_Escuela.UseVisualStyleBackColor = False
        '
        'But_Alquiler
        '
        Me.But_Alquiler.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.But_Alquiler.BackColor = System.Drawing.Color.Transparent
        Me.But_Alquiler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.But_Alquiler.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.But_Alquiler.FlatAppearance.BorderSize = 0
        Me.But_Alquiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.But_Alquiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.But_Alquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_Alquiler.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Alquiler.ForeColor = System.Drawing.Color.White
        Me.But_Alquiler.Image = CType(resources.GetObject("But_Alquiler.Image"), System.Drawing.Image)
        Me.But_Alquiler.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_Alquiler.Location = New System.Drawing.Point(1, 259)
        Me.But_Alquiler.Name = "But_Alquiler"
        Me.But_Alquiler.Size = New System.Drawing.Size(137, 53)
        Me.But_Alquiler.TabIndex = 1
        Me.But_Alquiler.Text = "Alquiler"
        Me.But_Alquiler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_Alquiler.UseVisualStyleBackColor = False
        '
        'But_Socios
        '
        Me.But_Socios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.But_Socios.BackColor = System.Drawing.Color.Transparent
        Me.But_Socios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.But_Socios.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.But_Socios.FlatAppearance.BorderSize = 0
        Me.But_Socios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.But_Socios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.But_Socios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.But_Socios.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Socios.ForeColor = System.Drawing.Color.White
        Me.But_Socios.Image = CType(resources.GetObject("But_Socios.Image"), System.Drawing.Image)
        Me.But_Socios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_Socios.Location = New System.Drawing.Point(1, 108)
        Me.But_Socios.Name = "But_Socios"
        Me.But_Socios.Size = New System.Drawing.Size(137, 53)
        Me.But_Socios.TabIndex = 0
        Me.But_Socios.Text = "Socios"
        Me.But_Socios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_Socios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(272, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(853, 538)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.Name = "FormPrincipal"
        Me.Text = "Sociedad Italiana"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents But_Socios As System.Windows.Forms.Button
    Friend WithEvents But_Biblioteca As System.Windows.Forms.Button
    Friend WithEvents But_Escuela As System.Windows.Forms.Button
    Friend WithEvents But_Alquiler As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
