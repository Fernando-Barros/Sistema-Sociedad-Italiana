Imports MySql.Data.MySqlClient
Module Sexo
    '*************** alta de sexo ******************************
    '*************** alta de sexo ******************************
    '*************** pasa Palabra sexo a ID  ******************************
    Function Buscar_IDSexo(ByVal sexo As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from sexo where sexo='" & sexo & "';", conexion)
            Dim DReader_sexo As MySqlDataReader
            DReader_sexo = Comando.ExecuteReader
            If DReader_sexo.HasRows Then
                DReader_sexo.Read()
                sexo = DReader_sexo("id_sexo")
                DReader_sexo.Close()
            End If
            DReader_sexo.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()
        End Try
        Return sexo
    End Function

    '*************** pasa ID sexo a la Palabra  ******************************
    Function Buscar_PalabraSexo(ByVal sexo As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from sexo where id_pais=" & sexo & ";", conexion)
            Dim DReader_sexo As MySqlDataReader
            DReader_sexo = Comando.ExecuteReader
            If DReader_sexo.HasRows Then
                DReader_sexo.Read()
                sexo = DReader_sexo("sexo")
                DReader_sexo.Close()
            End If
            DReader_sexo.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()
        End Try
        Return sexo
    End Function
End Module
