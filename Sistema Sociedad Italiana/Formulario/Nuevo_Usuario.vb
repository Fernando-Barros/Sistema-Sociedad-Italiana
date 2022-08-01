Imports MySql.Data.MySqlClient

Public Class Nuevo_Usuario
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBoxUsuariol.Text.Trim <> "" And TextBoxPassl.Text.Trim <> "" And TextBoxPass2l.Text.Trim <> "" Then
            Try
                Call conectar()
                conexion.Open()
                Dim comando As New MySqlCommand("SELECT `nombre` FROM `usuario` WHERE nombre=@nombre ;", conexion)
                comando.Parameters.AddWithValue("@nombre", TextBoxUsuariol.Text.Trim)
                Dim lectura As MySqlDataReader = comando.ExecuteReader
                If lectura.HasRows Then
                    MsgBox("NOMBRE Exite vuelva ")
                    lectura.Close()
                    conexion.Close()
                    TextBoxUsuariol.Clear()
                    TextBoxPassl.Clear()
                    TextBoxPass2l.Clear()
                    TextBoxUsuariol.Focus()
                Else

                    If TextBoxPassl.Text = TextBoxPass2l.Text Then
                        lectura.Close()
                        'Call conectar()
                        'conexion.Open()
                        Dim comando2 As New MySqlCommand("INSERT INTO `usuario`(`nombre`, `pass`) VALUES (@nombre,@pass);", conexion)
                        comando2.Parameters.AddWithValue("@nombre", TextBoxUsuariol.Text.Trim)
                        comando2.Parameters.AddWithValue("@pass", CrearHashSHA1(TextBoxPassl.Text.Trim))
                        comando2.ExecuteNonQuery()
                        conexion.Close()
                        Me.Close()
                    Else
                        MsgBox("Los PASSWORD no son iguales")
                        TextBoxPassl.Clear()
                        TextBoxPass2l.Clear()
                        TextBoxPassl.Focus()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        Else
            MsgBox("Rellene los campos correspondientes")
            TextBoxUsuariol.Focus()
        End If

       
    End Sub
End Class