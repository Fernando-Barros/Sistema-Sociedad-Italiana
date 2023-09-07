Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Module Modulo_DatosSocios
  
    Sub NuevoID_Socio()
        Try
            Dim Max_Id_socio As Integer
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand("SELECT MAX(id_socio) AS id_socio FROM socios;", conexion)
            Dim lector As MySqlDataReader = Comando.ExecuteReader
            While lector.Read
                Max_Id_socio = lector("id_socio")
            End While
            ABMSocios.Lab_NSocio.Text = Max_Id_socio + 1
            lector.Close()
            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub

    '********************MUESTRA DATOS DE UNA SOLA BASE DE BATOS*****************************************
    Public DReaderG As MySqlDataReader
    Sub Combo_Datos(ByVal Cadena As String)
        Try
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from " & Cadena & ";"
            DReaderG = Comando.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
            DReaderG.Close()
        End Try
    End Sub

    '+++++++++++++++++++++++++++BUSCA A LOS PADRINOS+++++++++++++++++++++++++++++++++++++++++++++++++++
    Function Padrino(ByVal Tabla As String, ByVal Id_Padrino As String) As String
        Dim Nombre_Padrino As String
        Nombre_Padrino = " "
        Try
            Call Conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from " & Tabla & " where id=" & Id_Padrino & ";"
            Dim DReader_padrino As MySqlDataReader
            DReader_padrino = Comando.ExecuteReader
            If DReader_padrino.HasRows Then
                DReader_padrino.Read()
                Nombre_Padrino = DReader_padrino("nombre") + " " + DReader_padrino("apellido")
                DReader_padrino.Close()
            End If
            DReader_padrino.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
            Nombre_Padrino = " "
        End Try
        Return Nombre_Padrino
    End Function

    Sub control_DNI()
        If ABMSocios.TextB_NumeroDNI.Text <> " " Then
            Try
                Call conectar()
                conexion.Open()
                Dim Comando As New MySqlCommand
                Comando.Connection = conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from socios where n_documento=" & ABMSocios.TextB_NumeroDNI.Text & ";"
                Dim DReader_N_Dni As MySqlDataReader
                DReader_N_Dni = Comando.ExecuteReader
                If DReader_N_Dni.HasRows Then
                    MsgBox("Exite el numero de DNI")

                    DReader_N_Dni.Close()
                    ABMSocios.TextB_NumeroDNI.Focus()
                End If
                DReader_N_Dni.Close()
                conexion.Close()
            Catch ex As Exception
                'MsgBox(ex.Message)
                conexion.Close()

            End Try
        End If


    End Sub

   

End Module
