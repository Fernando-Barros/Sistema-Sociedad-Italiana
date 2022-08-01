Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Module Socio
    '++++++++++++++++++++++++++++Carga un nuevo socio++++++++++++++++++++++++++++++++++++++++++
    Sub carga_nuevo_Socio()
        Try
            Call conectar()
            conexion.Open()
            Dim comando As New MySqlCommand("INSERT INTO `socios`(`id_socio`, `estado_socio`," & _
                                            " `apellido`, `nombre`, `tipo_docu`, `n_documento`, `otorgado_por`," & _
                                            "`domicilio`, `n_altura`, `id_localidad`, `id_provincia`, `id_pais`, " & _
                                            "`fecha`, `id_sexo`, `id_estado`, `padre`, `nac_padre`, `madre`, `nac_madre`," & _
                                            "`id_profesion`,`lug_trabaja`,`antiguedad`, `fecha_incripcion`, `padrino_1`, `padrino_2`," & _
                                            "`mail`, `telefono`,foto_socio) VALUES (@id_socio, @estado_socio," & _
                                            " @apellido, @nombre, @tipo_docu, @n_documento, @otorgado_por," & _
                                            "@domicilio, @n_altura, @id_localidad, @id_provincia, @id_pais, " & _
                                            "@fecha, @id_sexo, @id_estado, @padre, @nac_padre, @madre, @nac_madre," & _
                                            "@id_profesion, @lug_trabaja, @antiguedad, @fecha_incripcion, @padrino_1, @padrino_2," & _
                                            "@mail, @telefono, @foto_socio);", conexion)
            comando.Parameters.AddWithValue("@id_socio", ABMSocios.Lab_NSocio.Text.Trim)
            comando.Parameters.AddWithValue("@estado_socio", "En_Aprovacion")
            comando.Parameters.AddWithValue("@apellido", ABMSocios.Text_Apellido.Text.Trim)
            comando.Parameters.AddWithValue("@nombre", ABMSocios.Text_Nombre.Text.Trim)
            comando.Parameters.AddWithValue("@tipo_docu", ABMSocios.ComboBox_DNI.Text.Trim)
            comando.Parameters.AddWithValue("@n_documento", ABMSocios.TextB_NumeroDNI.Text.Trim)
            comando.Parameters.AddWithValue("@otorgado_por", Buscar_ID_Pais(ABMSocios.TextB_OtorgDNI.Text.Trim))
            comando.Parameters.AddWithValue("@domicilio", ABMSocios.Text_Calle.Text)
            comando.Parameters.AddWithValue("@n_altura", ABMSocios.Text_Nº_Calle.Text)
            comando.Parameters.AddWithValue("@id_localidad", Buscar_ID_Localidad(ABMSocios.Text_Cuidad.Text.Trim))
            comando.Parameters.AddWithValue("@id_provincia", Busca_IDProvincia(ABMSocios.Text_Provincia.Text.Trim))
            comando.Parameters.AddWithValue("@id_pais", Buscar_ID_Pais(ABMSocios.Text_Pais.Text.Trim))
            comando.Parameters.AddWithValue("@fecha", ABMSocios.DateTime_Nacimiento.Value) '<<<<<<
            comando.Parameters.AddWithValue("@id_sexo", Buscar_IDSexo(ABMSocios.ComboBox_Sexo.Text.Trim))
            comando.Parameters.AddWithValue("@id_estado", Buscar_IDECivil(ABMSocios.ComboBox_EC.Text.Trim))
            comando.Parameters.AddWithValue("@padre", ABMSocios.TextB_Padre.Text.Trim)
            comando.Parameters.AddWithValue("@nac_padre", Buscar_ID_Pais(ABMSocios.TextB_NPadre.Text.Trim))
            comando.Parameters.AddWithValue("@madre", ABMSocios.TextB_Madre.Text.Trim)
            comando.Parameters.AddWithValue("@nac_madre", Buscar_ID_Pais(ABMSocios.TextB_NMadre.Text.Trim))
            comando.Parameters.AddWithValue("@id_profesion", Buscar_IDProfecion(ABMSocios.TextB_Profecion.Text.Trim))
            comando.Parameters.AddWithValue("@lug_trabaja", ABMSocios.Text_LugarDondeTrabaja.Text.Trim)
            comando.Parameters.AddWithValue("@antiguedad", ABMSocios.TextB_Antiguedad.Text.Trim)
            comando.Parameters.AddWithValue("@fecha_incripcion", ABMSocios.Label_Feche.Text)
            comando.Parameters.AddWithValue("@padrino_1", ABMSocios.TextB_Padrino1.Text.Trim)
            comando.Parameters.AddWithValue("@padrino_2", ABMSocios.TextB_Padrino2.Text.Trim)
            comando.Parameters.AddWithValue("@mail", ABMSocios.Text_Mail.Text)
            comando.Parameters.AddWithValue("@telefono", ABMSocios.Text_Telef.Text)
            comando.Parameters.AddWithValue("@foto_socio", Foto_Bite(ABMSocios.PictureBoxSocio))
            comando.ExecuteNonQuery()
            MsgBox("Nuevo Socio registrado")
            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR al registrar")
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    '++++++++++++++++++++++++++++Modifica en Socio++++++++++++++++++++++++++++++++++++++++++
    Sub Modifica_Socio()
        Try
            Call conectar()
            conexion.Open()
            Dim comando As New MySqlCommand("UPDATE `socios` SET `apellido`=@apellido,`nombre`=@nombre,`tipo_docu`=@tipo_docu," & _
                                            "`n_documento`=@n_documento,`otorgado_por`=@otorgado_por,`domicilio`=@domicilio," & _
                                            "`n_altura`=@n_altura,`id_localidad`=@id_localidad,`id_provincia`=@id_provincia," & _
                                            "`id_pais`=@id_pais,`fecha`=@fecha,`id_sexo`=@id_sexo," & _
                                            "`id_estado`=@id_estado,`padre`=@padre,`nac_padre`=@nac_padre," & _
                                            "`madre`=@madre,`nac_madre`=@nac_madre,`id_profesion`=@id_profesion,`lug_trabaja`=@lug_trabaja," & _
                                            "`antiguedad`=@antiguedad,`fecha_incripcion`=@fecha_incripcion,`padrino_1`=@padrino_1," & _
                                            "`padrino_2`=@padrino_2,`mail`=@mail,`telefono`=@telefono," & _
                                            "`foto_socio`=@foto_socio where id_socio=" & ABMSocios.Lab_NSocio.Text & " ;", conexion)

            comando.Parameters.AddWithValue("@apellido", ABMSocios.Text_Apellido.Text.Trim)
            comando.Parameters.AddWithValue("@nombre", ABMSocios.Text_Nombre.Text.Trim)
            comando.Parameters.AddWithValue("@tipo_docu", ABMSocios.ComboBox_DNI.Text.Trim)
            comando.Parameters.AddWithValue("@n_documento", ABMSocios.TextB_NumeroDNI.Text.Trim)
            comando.Parameters.AddWithValue("@otorgado_por", Buscar_ID_Pais(ABMSocios.TextB_OtorgDNI.Text.Trim))
            comando.Parameters.AddWithValue("@domicilio", ABMSocios.Text_Calle.Text)
            comando.Parameters.AddWithValue("@n_altura", ABMSocios.Text_Nº_Calle.Text)
            comando.Parameters.AddWithValue("@id_localidad", Buscar_ID_Localidad(ABMSocios.Text_Cuidad.Text.Trim))
            comando.Parameters.AddWithValue("@id_provincia", Busca_IDProvincia(ABMSocios.Text_Provincia.Text.Trim))
            comando.Parameters.AddWithValue("@id_pais", Buscar_ID_Pais(ABMSocios.Text_Pais.Text.Trim))
            comando.Parameters.AddWithValue("@fecha", ABMSocios.DateTime_Nacimiento.Value)
            comando.Parameters.AddWithValue("@id_sexo", Buscar_IDSexo(ABMSocios.ComboBox_Sexo.Text.Trim))
            comando.Parameters.AddWithValue("@id_estado", Buscar_IDECivil(ABMSocios.ComboBox_EC.Text.Trim))
            comando.Parameters.AddWithValue("@padre", ABMSocios.TextB_Padre.Text.Trim)
            comando.Parameters.AddWithValue("@nac_padre", Buscar_ID_Pais(ABMSocios.TextB_NPadre.Text.Trim))
            comando.Parameters.AddWithValue("@madre", ABMSocios.TextB_Madre.Text.Trim)
            comando.Parameters.AddWithValue("@nac_madre", Buscar_ID_Pais(ABMSocios.TextB_NMadre.Text.Trim))
            comando.Parameters.AddWithValue("@id_profesion", Buscar_IDProfecion(ABMSocios.TextB_Profecion.Text.Trim))
            comando.Parameters.AddWithValue("@lug_trabaja", ABMSocios.Text_LugarDondeTrabaja.Text.Trim)
            comando.Parameters.AddWithValue("@antiguedad", ABMSocios.TextB_Antiguedad.Text.Trim)
            comando.Parameters.AddWithValue("@fecha_incripcion", ABMSocios.Label_Feche.Text)
            comando.Parameters.AddWithValue("@padrino_1", ABMSocios.TextB_Padrino1.Text.Trim)
            comando.Parameters.AddWithValue("@padrino_2", ABMSocios.TextB_Padrino2.Text.Trim)
            comando.Parameters.AddWithValue("@mail", ABMSocios.Text_Mail.Text)
            comando.Parameters.AddWithValue("@telefono", ABMSocios.Text_Telef.Text)
            comando.Parameters.AddWithValue("@foto_socio", Foto_Bite(ABMSocios.PictureBoxSocio))
            'conexion.Open()
            comando.ExecuteNonQuery()
            MsgBox("Los DATOS modificado")
            conexion.Close()
        Catch ex As Exception
            MsgBox("nooo guardo")
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    '++++++++++++++++++++++++++++Da de Baja a un Socio++++++++++++++++++++++++++++++++++++++++++
    Sub Baja_Socio()

    End Sub

    Sub ControlCampo_Socios()

        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_Apellido.Text) = "" Then
                MsgBox("El APELLIDO es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.Text_Apellido.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_Nombre.Text) = "" Then
                MsgBox("El NOMBRE es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.Text_Nombre.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_Calle.Text) = "" Then
                MsgBox("El DOMICILIO es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.Text_Calle.Focus()
            End If
        End If
        '------------------------------

        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.ComboBox_DNI.Text) = "" Then
                MsgBox("El TIPO DE DOCUMENTO es obligatorio")
                ABMSocios.bandera = 1
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_NumeroDNI.Text) = "" Then
                MsgBox("Obligatorio COMPLETAR este campo")
                ABMSocios.bandera = 1
                ABMSocios.TextB_NumeroDNI.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_OtorgDNI.Text) = "" Then
                MsgBox("Obligatorio COMPLETAR este campo")
                ABMSocios.bandera = 1
                ABMSocios.TextB_OtorgDNI.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_Cuidad.Text) = "" Then
                MsgBox("Es obligatorio completar la CIUDAD donde vive")
                ABMSocios.bandera = 1
                ABMSocios.Text_Cuidad.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_Provincia.Text) = "" Then
                MsgBox("Es Es obligatorio completar la PROVINCIA donde vive")
                ABMSocios.bandera = 1
                ABMSocios.Text_Provincia.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_Pais.Text) = "" Then
                MsgBox("Es obligatorio completar la PAIS donde vive")
                ABMSocios.bandera = 1
                ABMSocios.Text_Pais.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            Dim Fercha = New DateTime(1950, 1, 1)
            If Trim(ABMSocios.DateTime_Nacimiento.Text) = Fercha Then
                MsgBox("Es obligatorio completar el campo con la FECHA DE NACIMIENTO")
                ABMSocios.bandera = 1
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.ComboBox_Sexo.Text) = "" Then
                MsgBox("Obligatorio completar el campo SEXO")
                ABMSocios.bandera = 1
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.ComboBox_EC.Text) = "" Then
                MsgBox("Obligatorio completar el campo ESTADO CIVIL")
                ABMSocios.bandera = 1
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_NPadre.Text) = "" Then
                MsgBox("El NOMBRE DEL PADRE es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.TextB_NPadre.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_NPadre.Text) = "" Then
                MsgBox("La NACIONALIDAD es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.TextB_NPadre.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_Madre.Text) = "" Then
                MsgBox("El NOMBRE DE LA MADRE es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.TextB_Madre.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_NMadre.Text) = "" Then
                MsgBox("La NACIONALIDAD es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.TextB_NMadre.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_Profecion.Text) = "" Then
                MsgBox("La PROFECIÓN es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.TextB_Profecion.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_LugarDondeTrabaja.Text) = "" Then
                MsgBox("El LUGAR DONDE TRABAJA es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.Text_LugarDondeTrabaja.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_Antiguedad.Text) = "" Then
                MsgBox("La ANTIGUEDAD es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.TextB_Antiguedad.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.TextB_Padrino1.Text) = "" Then
                MsgBox("El PADRINO es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.TextB_Padrino1.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_Mail.Text) = "" Then
                MsgBox("El Mail es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.Text_Mail.Focus()
            End If
        End If
        If ABMSocios.bandera = 0 Then
            If Trim(ABMSocios.Text_Telef.Text) = "" Then
                MsgBox("El NUMERO DE TELEFONO es obligatorio")
                ABMSocios.bandera = 1
                ABMSocios.Text_Telef.Focus()
            End If
        End If
    End Sub
End Module
