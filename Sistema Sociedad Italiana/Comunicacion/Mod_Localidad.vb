Imports MySql.Data.MySqlClient
Module Mod_Localidad
    Function Buscar_Nom_Localidad(ByVal Localidad As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from localidad where id_localidad=" & Localidad & ";", conexion)
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                Localidad = DReader("localidad")
                DReader.Close()
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()

        End Try
        Return Localidad
    End Function

    '******************************************* Busca el ID del pais *****************************************
    Function Buscar_ID_Localidad(ByVal Localidad As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from localidad where localidad='" & Localidad & "';", conexion)
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                Localidad = DReader("id")
                DReader.Close()
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()

        End Try
        Return Localidad
    End Function
End Module
