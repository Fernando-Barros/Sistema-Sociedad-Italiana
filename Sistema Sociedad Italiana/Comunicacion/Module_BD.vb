Imports MySql.Data.MySqlClient
Module Module_BD
    Friend conexion As MySqlConnection
    Sub conectar()
        Try
            Dim Cadena As String
            'Cadena=My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath+"")
            Cadena = "server=localhost; user id=Jose; password=josefer438; database=italiana; port=3306;"
            'Cadena = "server=localhost; user id=root; database=italiana; port=3306;"
            'conexion.ConnectionString = Cadena
            conexion = New MySqlConnection(Cadena)
        Catch ex As Exception
            MsgBox("No conecto")
            MsgBox(ex.Message, , "Error de la Base de Dato")
            conexion.Close()
        End Try

    End Sub
End Module
