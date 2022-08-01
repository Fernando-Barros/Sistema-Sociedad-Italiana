<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimir_Socio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprimir_Socio))
        Me.Bot_Imp_Listado = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Col_ID_Socio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado_socio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RB_Activo = New System.Windows.Forms.RadioButton
        Me.RB_Baja = New System.Windows.Forms.RadioButton
        Me.RB_Todos = New System.Windows.Forms.RadioButton
        Me.RB_EAprovacion = New System.Windows.Forms.RadioButton
        Me.RB_Vitalicio = New System.Windows.Forms.RadioButton
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bot_Imp_Listado
        '
        Me.Bot_Imp_Listado.Location = New System.Drawing.Point(585, 359)
        Me.Bot_Imp_Listado.Name = "Bot_Imp_Listado"
        Me.Bot_Imp_Listado.Size = New System.Drawing.Size(117, 52)
        Me.Bot_Imp_Listado.TabIndex = 0
        Me.Bot_Imp_Listado.Text = "Imprimir"
        Me.Bot_Imp_Listado.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_ID_Socio, Me.Col_Apellido, Me.Col_Nombre, Me.Estado_socio})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(62, 197)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(474, 330)
        Me.DataGridView1.TabIndex = 1
        '
        'Col_ID_Socio
        '
        Me.Col_ID_Socio.HeaderText = "ID_Socio"
        Me.Col_ID_Socio.Name = "Col_ID_Socio"
        Me.Col_ID_Socio.ReadOnly = True
        Me.Col_ID_Socio.Width = 75
        '
        'Col_Apellido
        '
        Me.Col_Apellido.HeaderText = "Apellido"
        Me.Col_Apellido.Name = "Col_Apellido"
        Me.Col_Apellido.ReadOnly = True
        Me.Col_Apellido.Width = 68
        '
        'Col_Nombre
        '
        Me.Col_Nombre.HeaderText = "Nombre"
        Me.Col_Nombre.Name = "Col_Nombre"
        Me.Col_Nombre.ReadOnly = True
        Me.Col_Nombre.Width = 68
        '
        'Estado_socio
        '
        Me.Estado_socio.HeaderText = "Estado del Socio"
        Me.Estado_socio.Name = "Estado_socio"
        Me.Estado_socio.ReadOnly = True
        Me.Estado_socio.Width = 78
        '
        'RB_Activo
        '
        Me.RB_Activo.AutoSize = True
        Me.RB_Activo.Location = New System.Drawing.Point(542, 257)
        Me.RB_Activo.Name = "RB_Activo"
        Me.RB_Activo.Size = New System.Drawing.Size(60, 17)
        Me.RB_Activo.TabIndex = 2
        Me.RB_Activo.TabStop = True
        Me.RB_Activo.Text = "Activos"
        Me.RB_Activo.UseVisualStyleBackColor = True
        '
        'RB_Baja
        '
        Me.RB_Baja.AutoSize = True
        Me.RB_Baja.Location = New System.Drawing.Point(542, 303)
        Me.RB_Baja.Name = "RB_Baja"
        Me.RB_Baja.Size = New System.Drawing.Size(46, 17)
        Me.RB_Baja.TabIndex = 3
        Me.RB_Baja.TabStop = True
        Me.RB_Baja.Text = "Baja"
        Me.RB_Baja.UseVisualStyleBackColor = True
        '
        'RB_Todos
        '
        Me.RB_Todos.AutoSize = True
        Me.RB_Todos.Location = New System.Drawing.Point(542, 211)
        Me.RB_Todos.Name = "RB_Todos"
        Me.RB_Todos.Size = New System.Drawing.Size(55, 17)
        Me.RB_Todos.TabIndex = 4
        Me.RB_Todos.TabStop = True
        Me.RB_Todos.Text = "Todos"
        Me.RB_Todos.UseVisualStyleBackColor = True
        '
        'RB_EAprovacion
        '
        Me.RB_EAprovacion.AutoSize = True
        Me.RB_EAprovacion.Location = New System.Drawing.Point(542, 234)
        Me.RB_EAprovacion.Name = "RB_EAprovacion"
        Me.RB_EAprovacion.Size = New System.Drawing.Size(95, 17)
        Me.RB_EAprovacion.TabIndex = 5
        Me.RB_EAprovacion.TabStop = True
        Me.RB_EAprovacion.Text = "En Aprovacion"
        Me.RB_EAprovacion.UseVisualStyleBackColor = True
        '
        'RB_Vitalicio
        '
        Me.RB_Vitalicio.AutoSize = True
        Me.RB_Vitalicio.Location = New System.Drawing.Point(542, 280)
        Me.RB_Vitalicio.Name = "RB_Vitalicio"
        Me.RB_Vitalicio.Size = New System.Drawing.Size(61, 17)
        Me.RB_Vitalicio.TabIndex = 6
        Me.RB_Vitalicio.TabStop = True
        Me.RB_Vitalicio.Text = "Vitalicio"
        Me.RB_Vitalicio.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Imprimir_Socio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(753, 656)
        Me.Controls.Add(Me.RB_Vitalicio)
        Me.Controls.Add(Me.RB_EAprovacion)
        Me.Controls.Add(Me.RB_Todos)
        Me.Controls.Add(Me.RB_Baja)
        Me.Controls.Add(Me.RB_Activo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Bot_Imp_Listado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(800, 3500)
        Me.Name = "Imprimir_Socio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir_nuevo_Socio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bot_Imp_Listado As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Col_ID_Socio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado_socio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RB_Activo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Baja As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents RB_EAprovacion As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Vitalicio As System.Windows.Forms.RadioButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
