Imports MySql.Data.MySqlClient
Module ModuloRecursos
    Friend conexion As MySqlConnection
    Sub conectar()
        Try
            conexion = New MySqlConnection
            Dim Cadena As String
            'Cadena=My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath+"")
            Cadena = "server=localhost; user id=root; password=fer; database=prueba; port=3306"
            conexion.ConnectionString = Cadena

            'conexion.Open()
            'conexion.Close()
            MsgBox("Conecto")
        Catch ex As Exception
            MsgBox("No conecto")
        End Try

    End Sub

End Module
