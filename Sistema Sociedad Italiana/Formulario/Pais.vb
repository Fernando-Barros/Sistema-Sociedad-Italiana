Imports MySql.Data.MySqlClient
Public Class FPais
    Dim IDPais As Integer
    Dim Nombre_p As String
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Pais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextB_Pais.Clear()
        TextB_Pais.Text = ABMSocios.Text_Pais.Text
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from pais;"
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                Dim Mysource As New AutoCompleteStringCollection
                Do While DReader.Read
                    Mysource.Add(DReader.Item("pais"))
                Loop
                TextB_Pais.AutoCompleteCustomSource = Mysource
            Else

            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub But_Acepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Acepto.Click
        If TextB_Pais.Text <> "" Then
            Try
                Call conectar()
                conexion.Open()
                Dim Comando As New MySqlCommand
                Comando.Connection = conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from pais where pais = '" & TextB_Pais.Text.Trim & "';"
                Dim DReader As MySqlDataReader
                DReader = Comando.ExecuteReader
                If DReader.HasRows Then
                    MsgBox("Pais Existente")
                    DReader.Close()
                Else
                    DReader.Close()
                    Comando.CommandText = "insert into pais (pais) values('" & TextB_Pais.Text.Trim & "');"
                    Comando.ExecuteNonQuery()
                End If
                DReader.Close()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
            Close()
        Else
            MsgBox("Ingrese algun nombre o presione CANCELAR")
            TextB_Pais.Focus()
        End If
    End Sub

    Private Sub But_Modificar_Click(sender As System.Object, e As System.EventArgs) Handles But_Modificar.Click
        If TextB_Pais.Text <> "" Then
            Try
                Call conectar()
                conexion.Open()
                Dim Comando As New MySqlCommand
                Comando.Connection = conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from pais where pais = '" & TextB_Pais.Text.Trim & "';"
                Dim DReader As MySqlDataReader
                DReader = Comando.ExecuteReader
                If DReader.HasRows Then
                    Comando.CommandText = "update pais SET pais='" & TextB_Pais.Text.Trim & "' where id_pais=" & IDPais & ";"
                    Comando.ExecuteNonQuery()
                    DReader.Close()
                    conexion.Close()
                    Close()
                Else
                    MsgBox("No se puede modidicar un pais que no a sido cargado")
                    TextB_Pais.Focus()
                End If
                DReader.Close()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
        Else
            MsgBox("Ingrese algun nombre o aprete CANCELAR")
            TextB_Pais.Focus()
        End If
    End Sub

    Private Sub TextB_Pais_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextB_Pais.KeyPress
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from pais where pais = '" & TextB_Pais.Text & "';"
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                IDPais = DReader("id_pais")
                DReader.Close()
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
End Class