Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            conexion.Open()
            Dim comando As New MySqlCommand("SELECT `nombre`, `pass` FROM `usuario` WHERE nombre=@nombre and pass=@pass;", conexion)
            comando.Parameters.AddWithValue("@nombre", TextBoxUsuario.Text.Trim)
            comando.Parameters.AddWithValue("@pass", CrearHashSHA1(TextBoxPass.Text.Trim))
            Dim lectura As MySqlDataReader = comando.ExecuteReader
            If lectura.HasRows Then
                conexion.Close()
                PanelPrincipal.Show()
                Me.Close()
            Else
                MsgBox("NOMBRE o CONTRASEÑA es incorrecto")
                TextBoxUsuario.Focus()
            End If
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            'conexion.Close()
        End Try
    End Sub

    Private Sub LinkLabel_NU_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_NU.LinkClicked
        Nuevo_Usuario.ShowDialog()
        TextBoxUsuario.Focus()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call conectar()
            conexion.Open()
        Catch ex As Exception
            If conexion.State = ConnectionState.Closed Then
                MsgBox("No conecto")
                MsgBox(ex.Message, , "Error de la Base de Dato")
                conexion.Close()
                Me.Close()
            End If
        End Try


        conexion.Close()
        LinkLabel_NU.Visible = False
    End Sub
End Class