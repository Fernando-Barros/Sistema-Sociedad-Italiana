<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMSocios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMSocios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_Apellido = New System.Windows.Forms.TextBox()
        Me.Text_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTime_Nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.But_Cancelar = New System.Windows.Forms.Button()
        Me.Text_Calle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text_Nº_Calle = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label_Nacimiento = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Text_Pais = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Text_Provincia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Text_Cuidad = New System.Windows.Forms.TextBox()
        Me.ListView_Socios = New System.Windows.Forms.ListView()
        Me.ColumApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumIDsocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextB_NMadre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextB_NPadre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextB_Madre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextB_Padre = New System.Windows.Forms.TextBox()
        Me.TextB_Antiguedad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox_Sexo = New System.Windows.Forms.ComboBox()
        Me.TextB_Padrino1 = New System.Windows.Forms.TextBox()
        Me.TextB_Profecion = New System.Windows.Forms.TextBox()
        Me.ComboBox_EC = New System.Windows.Forms.ComboBox()
        Me.But_NSocio = New System.Windows.Forms.Button()
        Me.But_GSocio = New System.Windows.Forms.Button()
        Me.But_Modifi = New System.Windows.Forms.Button()
        Me.But_Borrar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_DNI = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextB_OtorgDNI = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextB_NumeroDNI = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBoxSocio = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Lab_NSocio = New System.Windows.Forms.Label()
        Me.Preview_incripcion = New System.Windows.Forms.PrintPreviewDialog()
        Me.But_Imprimir = New System.Windows.Forms.Button()
        Me.Print_Incripcion = New System.Drawing.Printing.PrintDocument()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.But_Cerr_for = New System.Windows.Forms.Button()
        Me.GroupBox_adicionales = New System.Windows.Forms.GroupBox()
        Me.Text_LugarDondeTrabaja = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Text_Telef = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Text_Mail = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextB_Padrino2 = New System.Windows.Forms.TextBox()
        Me.But_Siguinte = New System.Windows.Forms.Button()
        Me.Label_FechIncriccion = New System.Windows.Forms.Label()
        Me.Label_Feche = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBoxSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_adicionales.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apellido"
        '
        'Text_Apellido
        '
        Me.Text_Apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Apellido.Location = New System.Drawing.Point(325, 73)
        Me.Text_Apellido.Name = "Text_Apellido"
        Me.Text_Apellido.Size = New System.Drawing.Size(223, 22)
        Me.Text_Apellido.TabIndex = 2
        '
        'Text_Nombre
        '
        Me.Text_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Nombre.Location = New System.Drawing.Point(325, 101)
        Me.Text_Nombre.Name = "Text_Nombre"
        Me.Text_Nombre.Size = New System.Drawing.Size(223, 22)
        Me.Text_Nombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'DateTime_Nacimiento
        '
        Me.DateTime_Nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime_Nacimiento.Location = New System.Drawing.Point(355, 69)
        Me.DateTime_Nacimiento.Name = "DateTime_Nacimiento"
        Me.DateTime_Nacimiento.Size = New System.Drawing.Size(104, 22)
        Me.DateTime_Nacimiento.TabIndex = 12
        Me.DateTime_Nacimiento.Value = New Date(1950, 1, 1, 0, 0, 0, 0)
        '
        'But_Cancelar
        '
        Me.But_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.But_Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Cancelar.Location = New System.Drawing.Point(345, 624)
        Me.But_Cancelar.Name = "But_Cancelar"
        Me.But_Cancelar.Size = New System.Drawing.Size(72, 25)
        Me.But_Cancelar.TabIndex = 6
        Me.But_Cancelar.Text = "Cancelar"
        Me.But_Cancelar.UseVisualStyleBackColor = False
        '
        'Text_Calle
        '
        Me.Text_Calle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Text_Calle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Calle.Location = New System.Drawing.Point(95, 16)
        Me.Text_Calle.Name = "Text_Calle"
        Me.Text_Calle.Size = New System.Drawing.Size(242, 22)
        Me.Text_Calle.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Domicilio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Text_Nº_Calle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Text_Calle)
        Me.GroupBox1.Location = New System.Drawing.Point(264, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 50)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Domicilio Real"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(352, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nº"
        '
        'Text_Nº_Calle
        '
        Me.Text_Nº_Calle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Text_Nº_Calle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Nº_Calle.Location = New System.Drawing.Point(381, 16)
        Me.Text_Nº_Calle.Name = "Text_Nº_Calle"
        Me.Text_Nº_Calle.Size = New System.Drawing.Size(70, 22)
        Me.Text_Nº_Calle.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label_Nacimiento)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Text_Pais)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Text_Provincia)
        Me.GroupBox2.Controls.Add(Me.DateTime_Nacimiento)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Text_Cuidad)
        Me.GroupBox2.Location = New System.Drawing.Point(265, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 104)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Del Nacimiento"
        '
        'Label_Nacimiento
        '
        Me.Label_Nacimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Nacimiento.AutoSize = True
        Me.Label_Nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nacimiento.Location = New System.Drawing.Point(362, 14)
        Me.Label_Nacimiento.Name = "Label_Nacimiento"
        Me.Label_Nacimiento.Size = New System.Drawing.Size(78, 51)
        Me.Label_Nacimiento.TabIndex = 13
        Me.Label_Nacimiento.Text = "Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        Me.Label_Nacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(126, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Pais"
        '
        'Text_Pais
        '
        Me.Text_Pais.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Text_Pais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Text_Pais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Text_Pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Pais.Location = New System.Drawing.Point(167, 70)
        Me.Text_Pais.Name = "Text_Pais"
        Me.Text_Pais.Size = New System.Drawing.Size(153, 22)
        Me.Text_Pais.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Provincia"
        '
        'Text_Provincia
        '
        Me.Text_Provincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Text_Provincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Text_Provincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Text_Provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Provincia.Location = New System.Drawing.Point(167, 42)
        Me.Text_Provincia.Name = "Text_Provincia"
        Me.Text_Provincia.Size = New System.Drawing.Size(153, 22)
        Me.Text_Provincia.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Pueblo y/o ciudad"
        '
        'Text_Cuidad
        '
        Me.Text_Cuidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Text_Cuidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Text_Cuidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Text_Cuidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Cuidad.Location = New System.Drawing.Point(167, 14)
        Me.Text_Cuidad.Name = "Text_Cuidad"
        Me.Text_Cuidad.Size = New System.Drawing.Size(154, 22)
        Me.Text_Cuidad.TabIndex = 9
        '
        'ListView_Socios
        '
        Me.ListView_Socios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumApellido, Me.ColumNombre, Me.ColumIDsocio})
        Me.ListView_Socios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Socios.FullRowSelect = True
        Me.ListView_Socios.HideSelection = False
        Me.ListView_Socios.Location = New System.Drawing.Point(12, 74)
        Me.ListView_Socios.Name = "ListView_Socios"
        Me.ListView_Socios.Size = New System.Drawing.Size(219, 491)
        Me.ListView_Socios.TabIndex = 30
        Me.ListView_Socios.UseCompatibleStateImageBehavior = False
        Me.ListView_Socios.View = System.Windows.Forms.View.Details
        '
        'ColumApellido
        '
        Me.ColumApellido.Text = "Apellido"
        Me.ColumApellido.Width = 108
        '
        'ColumNombre
        '
        Me.ColumNombre.Text = "Nombre"
        Me.ColumNombre.Width = 108
        '
        'ColumIDsocio
        '
        Me.ColumIDsocio.Text = "Id"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(268, 384)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Sexo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(423, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Estado Civil"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextB_NMadre)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextB_NPadre)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TextB_Madre)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TextB_Padre)
        Me.GroupBox3.Location = New System.Drawing.Point(261, 428)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 81)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Familia"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(230, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Nacionalidad"
        '
        'TextB_NMadre
        '
        Me.TextB_NMadre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextB_NMadre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextB_NMadre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextB_NMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_NMadre.Location = New System.Drawing.Point(326, 39)
        Me.TextB_NMadre.Name = "TextB_NMadre"
        Me.TextB_NMadre.Size = New System.Drawing.Size(153, 22)
        Me.TextB_NMadre.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(230, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Nacionalidad"
        '
        'TextB_NPadre
        '
        Me.TextB_NPadre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextB_NPadre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextB_NPadre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextB_NPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_NPadre.Location = New System.Drawing.Point(326, 13)
        Me.TextB_NPadre.Name = "TextB_NPadre"
        Me.TextB_NPadre.Size = New System.Drawing.Size(153, 22)
        Me.TextB_NPadre.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Madre"
        '
        'TextB_Madre
        '
        Me.TextB_Madre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextB_Madre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_Madre.Location = New System.Drawing.Point(70, 39)
        Me.TextB_Madre.Name = "TextB_Madre"
        Me.TextB_Madre.Size = New System.Drawing.Size(153, 22)
        Me.TextB_Madre.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Padre"
        '
        'TextB_Padre
        '
        Me.TextB_Padre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextB_Padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_Padre.Location = New System.Drawing.Point(70, 13)
        Me.TextB_Padre.Name = "TextB_Padre"
        Me.TextB_Padre.Size = New System.Drawing.Size(154, 22)
        Me.TextB_Padre.TabIndex = 15
        '
        'TextB_Antiguedad
        '
        Me.TextB_Antiguedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_Antiguedad.Location = New System.Drawing.Point(140, 87)
        Me.TextB_Antiguedad.Name = "TextB_Antiguedad"
        Me.TextB_Antiguedad.Size = New System.Drawing.Size(35, 22)
        Me.TextB_Antiguedad.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(61, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Antiguedad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 17)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Profeción u Oficio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 17)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Socios Proponentes 1"
        '
        'ComboBox_Sexo
        '
        Me.ComboBox_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Sexo.FormattingEnabled = True
        Me.ComboBox_Sexo.Location = New System.Drawing.Point(313, 383)
        Me.ComboBox_Sexo.Name = "ComboBox_Sexo"
        Me.ComboBox_Sexo.Size = New System.Drawing.Size(104, 24)
        Me.ComboBox_Sexo.TabIndex = 13
        '
        'TextB_Padrino1
        '
        Me.TextB_Padrino1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextB_Padrino1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextB_Padrino1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_Padrino1.Location = New System.Drawing.Point(149, 121)
        Me.TextB_Padrino1.Name = "TextB_Padrino1"
        Me.TextB_Padrino1.Size = New System.Drawing.Size(223, 22)
        Me.TextB_Padrino1.TabIndex = 21
        '
        'TextB_Profecion
        '
        Me.TextB_Profecion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextB_Profecion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextB_Profecion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_Profecion.Location = New System.Drawing.Point(141, 22)
        Me.TextB_Profecion.Name = "TextB_Profecion"
        Me.TextB_Profecion.Size = New System.Drawing.Size(309, 22)
        Me.TextB_Profecion.TabIndex = 19
        '
        'ComboBox_EC
        '
        Me.ComboBox_EC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_EC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_EC.FormattingEnabled = True
        Me.ComboBox_EC.Location = New System.Drawing.Point(510, 383)
        Me.ComboBox_EC.Name = "ComboBox_EC"
        Me.ComboBox_EC.Size = New System.Drawing.Size(102, 24)
        Me.ComboBox_EC.TabIndex = 14
        '
        'But_NSocio
        '
        Me.But_NSocio.AutoEllipsis = True
        Me.But_NSocio.BackColor = System.Drawing.Color.LawnGreen
        Me.But_NSocio.Location = New System.Drawing.Point(249, 597)
        Me.But_NSocio.Name = "But_NSocio"
        Me.But_NSocio.Size = New System.Drawing.Size(86, 55)
        Me.But_NSocio.TabIndex = 27
        Me.But_NSocio.Text = "Nuevo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Socio"
        Me.But_NSocio.UseVisualStyleBackColor = False
        '
        'But_GSocio
        '
        Me.But_GSocio.AutoEllipsis = True
        Me.But_GSocio.BackColor = System.Drawing.Color.Yellow
        Me.But_GSocio.Location = New System.Drawing.Point(157, 596)
        Me.But_GSocio.Name = "But_GSocio"
        Me.But_GSocio.Size = New System.Drawing.Size(86, 55)
        Me.But_GSocio.TabIndex = 28
        Me.But_GSocio.Text = "Guardar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Socio"
        Me.But_GSocio.UseVisualStyleBackColor = False
        '
        'But_Modifi
        '
        Me.But_Modifi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.But_Modifi.Location = New System.Drawing.Point(426, 626)
        Me.But_Modifi.Name = "But_Modifi"
        Me.But_Modifi.Size = New System.Drawing.Size(72, 25)
        Me.But_Modifi.TabIndex = 29
        Me.But_Modifi.Text = "Modificar"
        Me.But_Modifi.UseVisualStyleBackColor = True
        '
        'But_Borrar
        '
        Me.But_Borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.But_Borrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Borrar.Location = New System.Drawing.Point(504, 626)
        Me.But_Borrar.Name = "But_Borrar"
        Me.But_Borrar.Size = New System.Drawing.Size(89, 25)
        Me.But_Borrar.TabIndex = 30
        Me.But_Borrar.Text = "BAJA de Socio"
        Me.But_Borrar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox_DNI)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TextB_OtorgDNI)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TextB_NumeroDNI)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Location = New System.Drawing.Point(265, 185)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(484, 81)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Identificación"
        '
        'ComboBox_DNI
        '
        Me.ComboBox_DNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_DNI.FormattingEnabled = True
        Me.ComboBox_DNI.Items.AddRange(New Object() {"DNI", "PASAPORTE", "LC", "LE"})
        Me.ComboBox_DNI.Location = New System.Drawing.Point(94, 13)
        Me.ComboBox_DNI.Name = "ComboBox_DNI"
        Me.ComboBox_DNI.Size = New System.Drawing.Size(119, 24)
        Me.ComboBox_DNI.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Otorgado por"
        '
        'TextB_OtorgDNI
        '
        Me.TextB_OtorgDNI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextB_OtorgDNI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextB_OtorgDNI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextB_OtorgDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_OtorgDNI.Location = New System.Drawing.Point(107, 45)
        Me.TextB_OtorgDNI.Name = "TextB_OtorgDNI"
        Me.TextB_OtorgDNI.Size = New System.Drawing.Size(153, 22)
        Me.TextB_OtorgDNI.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(226, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 17)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Nº"
        '
        'TextB_NumeroDNI
        '
        Me.TextB_NumeroDNI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextB_NumeroDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_NumeroDNI.Location = New System.Drawing.Point(251, 13)
        Me.TextB_NumeroDNI.Name = "TextB_NumeroDNI"
        Me.TextB_NumeroDNI.Size = New System.Drawing.Size(130, 22)
        Me.TextB_NumeroDNI.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 18)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Documento"
        '
        'PictureBoxSocio
        '
        Me.PictureBoxSocio.Image = CType(resources.GetObject("PictureBoxSocio.Image"), System.Drawing.Image)
        Me.PictureBoxSocio.Location = New System.Drawing.Point(566, 12)
        Me.PictureBoxSocio.Name = "PictureBoxSocio"
        Me.PictureBoxSocio.Size = New System.Drawing.Size(183, 111)
        Me.PictureBoxSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSocio.TabIndex = 32
        Me.PictureBoxSocio.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(256, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 17)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "N° Socio"
        '
        'Lab_NSocio
        '
        Me.Lab_NSocio.AutoSize = True
        Me.Lab_NSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_NSocio.Location = New System.Drawing.Point(327, 50)
        Me.Lab_NSocio.Name = "Lab_NSocio"
        Me.Lab_NSocio.Size = New System.Drawing.Size(0, 17)
        Me.Lab_NSocio.TabIndex = 34
        '
        'Preview_incripcion
        '
        Me.Preview_incripcion.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Preview_incripcion.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Preview_incripcion.ClientSize = New System.Drawing.Size(400, 300)
        Me.Preview_incripcion.Enabled = True
        Me.Preview_incripcion.Icon = CType(resources.GetObject("Preview_incripcion.Icon"), System.Drawing.Icon)
        Me.Preview_incripcion.Name = "PrintPreviewDialog1"
        Me.Preview_incripcion.Visible = False
        '
        'But_Imprimir
        '
        Me.But_Imprimir.Location = New System.Drawing.Point(605, 626)
        Me.But_Imprimir.Name = "But_Imprimir"
        Me.But_Imprimir.Size = New System.Drawing.Size(75, 23)
        Me.But_Imprimir.TabIndex = 35
        Me.But_Imprimir.Text = "Imprimir"
        Me.But_Imprimir.UseVisualStyleBackColor = True
        '
        'Print_Incripcion
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'But_Cerr_for
        '
        Me.But_Cerr_for.Location = New System.Drawing.Point(615, 597)
        Me.But_Cerr_for.Name = "But_Cerr_for"
        Me.But_Cerr_for.Size = New System.Drawing.Size(75, 23)
        Me.But_Cerr_for.TabIndex = 36
        Me.But_Cerr_for.Text = "Cerra"
        Me.But_Cerr_for.UseVisualStyleBackColor = True
        '
        'GroupBox_adicionales
        '
        Me.GroupBox_adicionales.Controls.Add(Me.Text_LugarDondeTrabaja)
        Me.GroupBox_adicionales.Controls.Add(Me.Label24)
        Me.GroupBox_adicionales.Controls.Add(Me.Label23)
        Me.GroupBox_adicionales.Controls.Add(Me.Text_Telef)
        Me.GroupBox_adicionales.Controls.Add(Me.Label21)
        Me.GroupBox_adicionales.Controls.Add(Me.Text_Mail)
        Me.GroupBox_adicionales.Controls.Add(Me.Label22)
        Me.GroupBox_adicionales.Controls.Add(Me.TextB_Padrino2)
        Me.GroupBox_adicionales.Controls.Add(Me.TextB_Padrino1)
        Me.GroupBox_adicionales.Controls.Add(Me.Label16)
        Me.GroupBox_adicionales.Controls.Add(Me.TextB_Antiguedad)
        Me.GroupBox_adicionales.Controls.Add(Me.Label14)
        Me.GroupBox_adicionales.Controls.Add(Me.TextB_Profecion)
        Me.GroupBox_adicionales.Controls.Add(Me.Label15)
        Me.GroupBox_adicionales.Location = New System.Drawing.Point(99, 253)
        Me.GroupBox_adicionales.Name = "GroupBox_adicionales"
        Me.GroupBox_adicionales.Size = New System.Drawing.Size(502, 299)
        Me.GroupBox_adicionales.TabIndex = 37
        Me.GroupBox_adicionales.TabStop = False
        Me.GroupBox_adicionales.Text = "Datos Adicionales"
        '
        'Text_LugarDondeTrabaja
        '
        Me.Text_LugarDondeTrabaja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Text_LugarDondeTrabaja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Text_LugarDondeTrabaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_LugarDondeTrabaja.Location = New System.Drawing.Point(141, 55)
        Me.Text_LugarDondeTrabaja.Name = "Text_LugarDondeTrabaja"
        Me.Text_LugarDondeTrabaja.Size = New System.Drawing.Size(308, 22)
        Me.Text_LugarDondeTrabaja.TabIndex = 30
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(4, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(137, 17)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Lugar donde trabaja"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(0, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(147, 17)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Socios Proponentes 2"
        '
        'Text_Telef
        '
        Me.Text_Telef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Telef.Location = New System.Drawing.Point(149, 233)
        Me.Text_Telef.Name = "Text_Telef"
        Me.Text_Telef.Size = New System.Drawing.Size(223, 22)
        Me.Text_Telef.TabIndex = 26
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(82, 236)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 17)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Telefono"
        '
        'Text_Mail
        '
        Me.Text_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Mail.Location = New System.Drawing.Point(149, 205)
        Me.Text_Mail.Name = "Text_Mail"
        Me.Text_Mail.Size = New System.Drawing.Size(345, 22)
        Me.Text_Mail.TabIndex = 25
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(82, 205)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 17)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "E-Mail"
        '
        'TextB_Padrino2
        '
        Me.TextB_Padrino2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextB_Padrino2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextB_Padrino2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextB_Padrino2.Location = New System.Drawing.Point(149, 152)
        Me.TextB_Padrino2.Name = "TextB_Padrino2"
        Me.TextB_Padrino2.Size = New System.Drawing.Size(223, 22)
        Me.TextB_Padrino2.TabIndex = 23
        '
        'But_Siguinte
        '
        Me.But_Siguinte.Location = New System.Drawing.Point(476, 518)
        Me.But_Siguinte.Name = "But_Siguinte"
        Me.But_Siguinte.Size = New System.Drawing.Size(104, 34)
        Me.But_Siguinte.TabIndex = 38
        Me.But_Siguinte.Text = "Siguiente >"
        Me.But_Siguinte.UseVisualStyleBackColor = True
        '
        'Label_FechIncriccion
        '
        Me.Label_FechIncriccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_FechIncriccion.AutoSize = True
        Me.Label_FechIncriccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FechIncriccion.Location = New System.Drawing.Point(258, 22)
        Me.Label_FechIncriccion.Name = "Label_FechIncriccion"
        Me.Label_FechIncriccion.Size = New System.Drawing.Size(118, 17)
        Me.Label_FechIncriccion.TabIndex = 33
        Me.Label_FechIncriccion.Text = "Fecha Inscripción"
        '
        'Label_Feche
        '
        Me.Label_Feche.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Feche.AutoSize = True
        Me.Label_Feche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Feche.Location = New System.Drawing.Point(380, 22)
        Me.Label_Feche.Name = "Label_Feche"
        Me.Label_Feche.Size = New System.Drawing.Size(0, 17)
        Me.Label_Feche.TabIndex = 39
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ABMSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 663)
        Me.Controls.Add(Me.Label_Feche)
        Me.Controls.Add(Me.Label_FechIncriccion)
        Me.Controls.Add(Me.But_Siguinte)
        Me.Controls.Add(Me.GroupBox_adicionales)
        Me.Controls.Add(Me.But_Cerr_for)
        Me.Controls.Add(Me.But_Imprimir)
        Me.Controls.Add(Me.Lab_NSocio)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PictureBoxSocio)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.But_Borrar)
        Me.Controls.Add(Me.But_Modifi)
        Me.Controls.Add(Me.But_GSocio)
        Me.Controls.Add(Me.But_NSocio)
        Me.Controls.Add(Me.ComboBox_EC)
        Me.Controls.Add(Me.ComboBox_Sexo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListView_Socios)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.But_Cancelar)
        Me.Controls.Add(Me.Text_Nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Text_Apellido)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ABMSocios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABMSocios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBoxSocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_adicionales.ResumeLayout(False)
        Me.GroupBox_adicionales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents Text_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTime_Nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents But_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Text_Calle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Text_Nº_Calle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListView_Socios As System.Windows.Forms.ListView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColumApellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextB_NMadre As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextB_NPadre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextB_Madre As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextB_Padre As System.Windows.Forms.TextBox
    Friend WithEvents TextB_Antiguedad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Text_Cuidad As System.Windows.Forms.TextBox
    Friend WithEvents TextB_Padrino1 As System.Windows.Forms.TextBox
    Friend WithEvents TextB_Profecion As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_EC As System.Windows.Forms.ComboBox
    Friend WithEvents But_NSocio As System.Windows.Forms.Button
    Friend WithEvents But_GSocio As System.Windows.Forms.Button
    Friend WithEvents But_Modifi As System.Windows.Forms.Button
    Friend WithEvents But_Borrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextB_OtorgDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextB_NumeroDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Text_Pais As System.Windows.Forms.TextBox
    Public WithEvents Text_Provincia As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_DNI As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBoxSocio As System.Windows.Forms.PictureBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Lab_NSocio As System.Windows.Forms.Label
    Friend WithEvents ColumIDsocio As System.Windows.Forms.ColumnHeader
    Friend WithEvents Preview_incripcion As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents But_Imprimir As System.Windows.Forms.Button
    Friend WithEvents Print_Incripcion As System.Drawing.Printing.PrintDocument
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents But_Cerr_for As System.Windows.Forms.Button
    Friend WithEvents GroupBox_adicionales As System.Windows.Forms.GroupBox
    Friend WithEvents TextB_Padrino2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Text_Telef As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Text_Mail As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents But_Siguinte As System.Windows.Forms.Button
    Friend WithEvents Label_Nacimiento As System.Windows.Forms.Label
    Friend WithEvents Label_FechIncriccion As System.Windows.Forms.Label
    Friend WithEvents Label_Feche As System.Windows.Forms.Label
    Friend WithEvents Text_LugarDondeTrabaja As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
