Imports MySql.Data.MySqlClient
Module Estado_civil
    '*************** alta de sexo ******************************
    '*************** alta de sexo ******************************
    '*************** pasa Palabra sexo a ID  ******************************
    Function Buscar_IDECivil(ByVal Civil As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from estado_civil where estado_civil='" & Civil & "';", conexion)
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                Civil = DReader("id_estado")
                DReader.Close()
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()
        End Try
        Return Civil
    End Function

    '*************** pasa ID sexo a la Palabra  ******************************
    Function Buscar_PalabraEC(ByVal Civil As String) As String
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("select * from estado_civil where id_estado=" & Civil & ";", conexion)
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                Civil = DReader("estado_civil")
                DReader.Close()
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()
        End Try
        Return Civil
    End Function
End Module
