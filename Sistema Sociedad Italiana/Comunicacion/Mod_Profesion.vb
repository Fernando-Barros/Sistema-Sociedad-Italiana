Imports MySql.Data.MySqlClient
Module Mod_Profesion
    Function Buscar_Profecion(ByVal Profesion As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from localidad where id_localidad=" & Profesion & ";", conexion)
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                Profesion = DReader("localidad")
                DReader.Close()
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()

        End Try
        Return Profesion
    End Function

    '******************************************* Busca el ID del pais *****************************************
    Function Buscar_IDProfecion(ByVal Profesion As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from profesion where profesion='" & Profesion & "';", conexion)
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                Profesion = DReader("id_profesion")
                DReader.Close()
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()
        End Try
        Return Profesion
    End Function
End Module
