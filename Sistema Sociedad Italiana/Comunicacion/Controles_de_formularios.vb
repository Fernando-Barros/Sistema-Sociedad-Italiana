Imports MySql.Data.MySqlClient
Module Controles_de_formularios
    '++++++++++++++FUNCION QUE CONTROLA SOLO LETRAS O NUMEROS CUANDO INGRESA POR  TECLADO++++++++++++++++++++++++
    Sub Numero(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo Numero", MsgBoxStyle.Exclamation, "Impotante")
        End If
    End Sub

    Sub Letras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo Letras", MsgBoxStyle.Exclamation, "Impotante")
        End If
    End Sub


    Function burcar_ID(ByVal Tabla As String, ByVal Campo As String, ByVal Nombre As String) As String
        If Nombre <> "" Then
            Try
                Call conectar()
                conexion.Open()
                Dim Comando As New MySqlCommand
                Comando.Connection = conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from " & Tabla & " where " & Campo & " = '" & Nombre & "';"
                Dim DReader As MySqlDataReader
                DReader = Comando.ExecuteReader
                If DReader.HasRows Then
                    DReader.Read()
                    Nombre = DReader("id")
                    DReader.Close()
                End If
                DReader.Close()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        End If
        Return Nombre
    End Function
End Module
