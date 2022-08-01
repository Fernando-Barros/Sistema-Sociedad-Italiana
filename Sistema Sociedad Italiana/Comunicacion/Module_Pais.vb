Imports MySql.Data.MySqlClient
'******************************************* Busca el Nombre del pais *****************************************
Module Module_Pais
    Function Buscar_Nom_Pais(ByVal Tabla As String, ByVal Id_Pais As String) As String
        Dim Nombre_pais As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from " & Tabla & " where id_pais=" & Id_Pais & ";", conexion)
            Dim DReader_NomPais As MySqlDataReader
            DReader_NomPais = Comando.ExecuteReader
            If DReader_NomPais.HasRows Then
                DReader_NomPais.Read()
                Nombre_pais = DReader_NomPais("pais")
                DReader_NomPais.Close()
            End If
            DReader_NomPais.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()
            Nombre_pais = " "
        End Try
        Return Nombre_pais
    End Function

    '******************************************* Busca el ID del pais *****************************************
    Function Buscar_ID_Pais(ByVal Nombre_Pais As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from pais where pais='" & Nombre_Pais & "';", conexion)
            Dim DReader_NomPais As MySqlDataReader
            DReader_NomPais = Comando.ExecuteReader
            If DReader_NomPais.HasRows Then
                DReader_NomPais.Read()
                Nombre_Pais = DReader_NomPais("id_pais")
                DReader_NomPais.Close()
            End If
            DReader_NomPais.Close()
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            Nombre_Pais = " "
        End Try
        Return Nombre_Pais
    End Function
End Module
