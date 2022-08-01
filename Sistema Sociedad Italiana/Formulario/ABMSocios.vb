Imports MySql.Data.MySqlClient
Public Class ABMSocios
    '-----VARIABLE GLOBAL-----
    Public bandera As Integer
    '-------------------------
    Private Sub Combo_Sexo()
        Call Combo_Datos("sexo")
        If DReaderG.HasRows Then
            ComboBox_Sexo.Items.Clear()
            Do While DReaderG.Read
                ComboBox_Sexo.Items.Add(DReaderG.Item("sexo"))
            Loop
        Else
            MsgBox("SEXO no Extiste")
        End If
        DReaderG.Close()
        conexion.Close()
    End Sub

    Private Sub tprovincia()
        Call Combo_Datos("provincia")
        If DReaderG.HasRows Then
            Dim Mysource As New AutoCompleteStringCollection
            Do While DReaderG.Read
                Mysource.Add(DReaderG.Item("nom_provincia"))
            Loop
            Text_Provincia.AutoCompleteCustomSource = Mysource

        Else
            'MsgBox("La Provincia no Extiste")
        End If
        DReaderG.Close()
        conexion.Close()
    End Sub

    Private Sub Pais()
        Call Combo_Datos("pais")
        If DReaderG.HasRows Then
            Dim Mysource As New AutoCompleteStringCollection
            Do While DReaderG.Read
                Mysource.Add(DReaderG.Item("pais"))
            Loop
            Text_Pais.AutoCompleteCustomSource = Mysource
            TextB_NPadre.AutoCompleteCustomSource = Mysource
            TextB_NMadre.AutoCompleteCustomSource = Mysource
            TextB_OtorgDNI.AutoCompleteCustomSource = Mysource
        Else
            'MsgBox("El Pais no Extiste")
        End If
        DReaderG.Close()
        conexion.Close()
    End Sub

    Private Sub Est_Civil()
        Call Combo_Datos("estado_civil")
        If DReaderG.HasRows Then
            ComboBox_EC.Items.Clear()
            Do While DReaderG.Read
                ComboBox_EC.Items.Add(DReaderG.Item("estado_civil"))
            Loop
        Else
            MsgBox("El Socio no Extiste")
        End If
        DReaderG.Close()
        conexion.Close()
    End Sub

    Private Sub Padrinos()
        Call Combo_Datos("socios")
        If DReaderG.HasRows Then
            Dim Mysource As New AutoCompleteStringCollection
            Do While DReaderG.Read
                Mysource.Add(DReaderG.Item("apellido") + " " + DReaderG.Item("nombre")) ' para concadenar cod socio  + "                                      " + CStr(DReaderG.Item("id_socio"))
            Loop
            TextB_Padrino1.AutoCompleteCustomSource = Mysource
            TextB_Padrino2.AutoCompleteCustomSource = Mysource

        Else
            'MsgBox("El Socio no Extiste")
        End If
        DReaderG.Close()
        conexion.Close()
    End Sub

    Private Sub Localidad()
        Call Combo_Datos("localidad")
        If DReaderG.HasRows Then
            Dim Mysource As New AutoCompleteStringCollection
            Do While DReaderG.Read
                Mysource.Add(DReaderG.Item("localidad"))
            Loop
            Text_Cuidad.AutoCompleteCustomSource = Mysource

        Else
            'MsgBox("La Provincia no Extiste")
        End If
        DReaderG.Close()
        conexion.Close()
    End Sub

    Private Sub Limpiar()
        Text_Apellido.Clear()
        Text_Nombre.Clear()
        Text_Calle.Clear()
        Text_Nº_Calle.Clear()
        Text_Cuidad.Clear()
        Text_Provincia.Clear()
        Text_Pais.Clear()
        ComboBox_Sexo.SelectedIndex = -1
        ComboBox_EC.SelectedIndex = -1
        ComboBox_DNI.SelectedIndex = -1
        TextB_NumeroDNI.Clear()
        TextB_OtorgDNI.Clear()
        TextB_Padre.Clear()
        TextB_NPadre.Clear()
        TextB_Madre.Clear()
        TextB_NMadre.Clear()
        TextB_Profecion.Clear()
        Text_LugarDondeTrabaja.Clear()
        TextB_Antiguedad.Clear()
        TextB_Padrino1.Clear()
        TextB_Padrino2.Clear()
        Text_Mail.Clear()
        Text_Telef.Clear()
    End Sub

    '************************ListView del ListView*********************************
    Private Sub Carga_ListTano(ByVal Cadena As String)
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = Cadena
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                ListView_Socios.Items.Clear()
                Dim LV As New ListViewItem
                Do While DReader.Read
                    LV = ListView_Socios.Items.Add(DReader("apellido"))
                    LV.SubItems.Add(DReader("nombre"))
                    LV.SubItems.Add(DReader("id_socio"))
                Loop
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub Profesion()
        Call Combo_Datos("profesion")
        If DReaderG.HasRows Then
            Dim Mysource As New AutoCompleteStringCollection
            Do While DReaderG.Read
                Mysource.Add(DReaderG.Item("profesion"))
            Loop
            TextB_Profecion.AutoCompleteCustomSource = Mysource

        Else
            'MsgBox("La Provincia no Extiste")
        End If
        DReaderG.Close()
        conexion.Close()
    End Sub

    '------------IMPRIMIR----------------------------------------------------------------
    Private Sub Imprime()

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Print_Incripcion.Print()
        End If
    End Sub

    '************************llama a Carga de Formulario*********************************
    Private Sub ABMSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'But_GSocio.Visible = False
        But_Cancelar.Visible = False
        GroupBox_adicionales.Visible = False
        But_GSocio.Visible = False
        'But_Imprimir.Visible = False
        But_Borrar.Visible = True
        But_Cerr_for.Location = New Point(605, 626)
        But_Cerr_for.Visible = False
        But_Modifi.Location = New Point(345, 624)
        But_Imprimir.Location = New Point(426, 626)
        'Call conectar()
        Call Carga_ListTano("select * from socios where estado_socio <> 'baja' order by apellido,nombre ;")
        '----CARGA CAMPO PARA SU ELECIÓN-----
        Call tprovincia()
        Call Pais()
        Call Combo_Sexo()
        Call Est_Civil()
        Call Padrinos()
        Call Localidad()
        Call Profesion()

    End Sub
    '************************Carga al socio que se elige de la lista*********************************
    Private Sub ListView_Socios_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView_Socios.MouseClick
        Try
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Dim prue As Integer = ListView_Socios.FocusedItem.Index
            Comando.CommandText = "select * from socios" &
                                 " join provincia on socios.id_provincia=provincia.id_provincia" &
                                 "  join localidad on socios.id_localidad=localidad.id" &
                                 "  join pais on socios.id_pais=pais.id_pais" &
                                 "  join sexo on socios.id_sexo=sexo.id_sexo" &
                                 "  join estado_civil on socios.id_estado=estado_civil.id_estado" &
                                 "  join profesion on socios.id_profesion=profesion.id_profesion" &
                                 "  where id_socio=" & ListView_Socios.Items(prue).SubItems(2).Text & ";"
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                Label_Feche.Text = DReader("fecha_incripcion")
                Lab_NSocio.Text = DReader("id_socio")
                Text_Nombre.Text = DReader("nombre")
                Text_Apellido.Text = DReader("apellido")
                Text_Calle.Text = DReader("domicilio")
                Text_Nº_Calle.Text = DReader("n_altura")
                ComboBox_DNI.Text = DReader("tipo_docu")
                TextB_NumeroDNI.Text = DReader("n_documento")
                TextB_OtorgDNI.Text = DReader("pais")
                Text_Cuidad.Text = DReader("localidad")
                Text_Provincia.Text = DReader("nom_provincia")
                Text_Pais.Text = DReader("pais")
                DateTime_Nacimiento.Text = DReader("fecha")
                ComboBox_Sexo.Text = DReader("sexo")
                ComboBox_EC.Text = DReader("estado_civil")
                TextB_Padre.Text = DReader("padre")
                TextB_NPadre.Text = Buscar_Nom_Pais("Pais", DReader("nac_padre"))
                TextB_Madre.Text = DReader("madre")
                TextB_NMadre.Text = Buscar_Nom_Pais("Pais", DReader("nac_madre"))
                TextB_Profecion.Text = DReader("profesion")
                Text_LugarDondeTrabaja.Text = DReader("lug_trabaja")
                TextB_Antiguedad.Text = DReader("antiguedad")
                TextB_Padrino1.Text = DReader("padrino_1")
                TextB_Padrino2.Text = DReader("padrino_2")
                Text_Mail.Text = DReader("mail")
                Text_Telef.Text = DReader("telefono")
                PictureBoxSocio.Image = Bytes_foto(DReader("foto_socio"))
            Else
                MsgBox("El Socio no Extiste")
            End If

            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub Text_Provincia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Text_Provincia.DoubleClick
        provincia.ShowDialog()
        Text_Provincia.Text = provincia.TextB_Provincia.Text
        Call tprovincia()
    End Sub

    Private Sub Text_Pais_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Text_Pais.DoubleClick
        FPais.ShowDialog()
        Text_Pais.Text = FPais.TextB_Pais.Text
        Call Pais()
    End Sub

    Private Sub Text_OtorgDNI_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextB_OtorgDNI.DoubleClick
        FPais.ShowDialog()
        TextB_OtorgDNI.Text = FPais.TextB_Pais.Text
        Call Pais()
    End Sub

    Private Sub TextB_NPadre_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextB_NPadre.DoubleClick
        FPais.ShowDialog()
    End Sub

    Private Sub TextB_NMadre_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextB_NMadre.DoubleClick
        FPais.ShowDialog()
    End Sub

    'Dim sexo As String


    Private Sub ComboBox_Sexo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox_Sexo.MouseClick
        Call Combo_Sexo()

    End Sub

    Private Sub But_NSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_NSocio.Click
        Label_Feche.Text = DateTime.Now.ToString("dd/MM/yyyy")
        DateTime_Nacimiento.Text = New DateTime(1950, 1, 1) 'DateTime_Nacimiento.Value.ToString("1950-01-01")
        ListView_Socios.Visible = False
        But_NSocio.Visible = False
        But_GSocio.Visible = True
        But_Cancelar.Visible = True
        But_Cancelar.Location = New Point(253, 624)
        But_Modifi.Visible = False
        But_Borrar.Visible = False
        But_Imprimir.Visible = False
        Call NuevoID_Socio()
        PictureBoxSocio.Load(Application.StartupPath & "\FotoComodin2.png")
        'PictureBoxSocio.Image = Image.FromFile("\\Iconos\GruUsu.png")
        Call Limpiar()
        Text_Apellido.Focus()


    End Sub

    Private Sub But_GSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_GSocio.Click
        bandera = 0
        Call ControlCampo_Socios() 'comtrol campo socio
        If bandera = 0 Then
            Call carga_nuevo_Socio()

            But_GSocio.Visible = False
            But_NSocio.Visible = True
            But_Cancelar.Visible = False
            Call Carga_ListTano("select * from socios order by apellido,nombre;")
            ListView_Socios.Visible = True
            Call Limpiar()
        End If
    End Sub

    Private Sub But_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Cancelar.Click
        But_GSocio.Visible = False
        But_Cancelar.Visible = False
        But_NSocio.Visible = True
        But_Modifi.Visible = True
        But_Borrar.Visible = True
        But_Imprimir.Visible = True
        Label_Feche.Text = " "
        ListView_Socios.Visible = True
        ListView_Socios.Select()
        Lab_NSocio.Text = " "
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxSocio.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBoxSocio.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub But_Modifi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Modifi.Click
        bandera = 0
        Call ControlCampo_Socios()
        If bandera = 0 Then
            Call Modifica_Socio()
            Call Carga_ListTano("select * from socios order by apellido,nombre;")
        End If
        
    End Sub

    Private Sub But_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Imprimir.Click
        Preview_incripcion.Document = Print_Incripcion
        'tamaño de ventana
        Preview_incripcion.Width = 600
        Preview_incripcion.Height = 700
        'vista previa
        Preview_incripcion.Show()
        '--------------------------------------
        'PrintDialog1.Document = Print_Incripcion
        'Call Imprime()
    End Sub
    '***********   Esquema de imprecion   ***********
    Private Sub Print_Incripcion_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Print_Incripcion.PrintPage
        Dim prFont As New Font("times new roman", 11, FontStyle.Bold)
        Dim H As Integer = 0
        Dim V As Integer = 0
        Try
            'e.Graphics.DrawImage(Image.FromFile("C:\Users\Fernando\Documents\Visual Studio 2008\Projects\Sistema Sociedad Italiana\Sistema Sociedad Italiana\Iconos\solicituddeingreso1.png"), 50, 1)
            e.Graphics.DrawImage(Image.FromFile("Iconos\solicituddeingreso1.png"), 50, 1)
            e.Graphics.DrawImage(PictureBoxSocio.Image, 690, 25, 130, 89)
            e.Graphics.DrawString(Text_Apellido.Text, prFont, Brushes.Black, H + 190, V + 230)
            e.Graphics.DrawString(Text_Nombre.Text, prFont, Brushes.Black, H + 450, V + 230)
            e.Graphics.DrawString(Text_Calle.Text, prFont, Brushes.Black, H + 300, V + 265)
            e.Graphics.DrawString(Text_Nº_Calle.Text, prFont, Brushes.Black, H + 620, V + 265)
            e.Graphics.DrawString(Text_Cuidad.Text, prFont, Brushes.Black, H + 370, V + 300)
            e.Graphics.DrawString(Text_Provincia.Text, prFont, Brushes.Black, H + 600, V + 300)
            e.Graphics.DrawString(Text_Pais.Text, prFont, Brushes.Black, H + 370, V + 319)
            e.Graphics.DrawString(DateTime_Nacimiento.Text, prFont, Brushes.Black, H + 600, V + 319)
            e.Graphics.DrawString(ComboBox_Sexo.Text, prFont, Brushes.Black, H + 150, V + 352)
            e.Graphics.DrawString(ComboBox_EC.Text, prFont, Brushes.Black, H + 450, V + 352)
            e.Graphics.DrawString(ComboBox_DNI.Text, prFont, Brushes.Black, H + 350, V + 387)
            e.Graphics.DrawString(TextB_NumeroDNI.Text, prFont, Brushes.Black, H + 550, V + 387)
            e.Graphics.DrawString(TextB_OtorgDNI.Text, prFont, Brushes.Black, H + 360, V + 422)
            e.Graphics.DrawString(TextB_Padre.Text, prFont, Brushes.Black, H + 290, V + 495)
            e.Graphics.DrawString(TextB_NPadre.Text, prFont, Brushes.Black, H + 625, V + 495)
            e.Graphics.DrawString(TextB_Madre.Text, prFont, Brushes.Black, H + 290, V + 530)
            e.Graphics.DrawString(TextB_NMadre.Text, prFont, Brushes.Black, H + 625, V + 530)
            e.Graphics.DrawString(TextB_NMadre.Text, prFont, Brushes.Black, H + 625, V + 530)
            e.Graphics.DrawString(TextB_Profecion.Text, prFont, Brushes.Black, H + 290, V + 565)
            e.Graphics.DrawString(Text_LugarDondeTrabaja.Text, prFont, Brushes.Black, H + 290, V + 600)
            e.Graphics.DrawString(TextB_Antiguedad.Text, prFont, Brushes.Black, H + 659, V + 600)
            e.Graphics.DrawString(Label_Feche.Text, prFont, Brushes.Black, H + 140, V + 650) '<<
            e.Graphics.DrawString(TextB_Padrino1.Text, prFont, Brushes.Black, H + 100, V + 775)
            e.Graphics.DrawString(TextB_Padrino2.Text, prFont, Brushes.Black, H + 580, V + 775)
            e.Graphics.DrawString(Text_Mail.Text, prFont, Brushes.Black, H + 140, V + 985)
            e.Graphics.DrawString(Text_Telef.Text, prFont, Brushes.Black, H + 540, V + 985)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub But_Cerr_for_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Cerr_for.Click
        'Me.Visible = False
        'Exit Sub
        Imprimir_Socio.Close()
        Me.Close()
    End Sub


    Private Sub But_Siguinte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Siguinte.Click
        If But_Siguinte.Text = "Siguiente >" Then
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            ComboBox_Sexo.Visible = False
            ComboBox_EC.Visible = False
            GroupBox_adicionales.Visible = True
            GroupBox_adicionales.Location = New Point(237, 139)
            But_Siguinte.Text = "< Antes"
        Else
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            GroupBox3.Visible = True
            GroupBox4.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            ComboBox_Sexo.Visible = True
            ComboBox_EC.Visible = True
            GroupBox_adicionales.Visible = False
            GroupBox_adicionales.Location = New Point(237, 139)
            But_Siguinte.Text = "Siguiente >"
        End If
    End Sub

    Private Sub But_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Borrar.Click

        If Text_Apellido.Text <> "" Then
            Dim OptionMess As DialogResult
            OptionMess = MsgBox("El SOCIO " & Text_Apellido.Text + " " & Text_Nombre.Text + " sera dado de BAJA", MsgBoxStyle.YesNo, "                          BAJA")

            If OptionMess = Windows.Forms.DialogResult.Yes Then
                Try
                    Call conectar()
                    conexion.Open()
                    Dim comando As New MySqlCommand("UPDATE `socios` SET `estado_socio`='Baja' where id_socio=" & Lab_NSocio.Text & " ;", conexion)
                    comando.ExecuteNonQuery()
                    Call Carga_ListTano("select * from socios where estado_socio <> 'baja' order by apellido,nombre ;")
                    MsgBox("SOCIO dado de BAJA")
                    conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    conexion.Close()
                End Try
            End If
        Else
            MsgBox("Tiene que elegir un SOCIO")
        End If


    End Sub

    Private Sub Text_Nº_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Nº_Calle.KeyPress
        Call Numero(e)
    End Sub

    Private Sub Text_Provincia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Provincia.KeyPress
        Call Letras(e)
    End Sub


    Private Sub Text_Pais_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Pais.KeyPress
        Call Letras(e)
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call Letras(e)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextB_OtorgDNI.KeyPress
        Call Letras(e)
    End Sub

    Private Sub TextB_Padre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextB_Padre.KeyPress
        Call Letras(e)
    End Sub

    Private Sub TextB_Madre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextB_Madre.KeyPress
        Call Letras(e)
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextB_NumeroDNI.KeyPress
        Call Numero(e)
    End Sub

    Private Sub TextB_Antiguedad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextB_Antiguedad.KeyPress
        Call Numero(e)
    End Sub

    Private Sub Text_Telef_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Text_Telef.KeyPress
        Call Numero(e)
    End Sub


End Class