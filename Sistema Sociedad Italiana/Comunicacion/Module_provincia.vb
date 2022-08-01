Imports MySql.Data.MySqlClient
Module Module_provincia
    Function Busca_IDProvincia(ByVal NomProvincia As String) As String
        Dim Id_Pro As Integer
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from provincia where nom_provincia='" & NomProvincia & "';"
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                Id_Pro = DReader("id_provincia")
                DReader.Close()
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
        Return Id_Pro
    End Function


End Module
