Imports MySql.Data.MySqlClient
Public Class provincia

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub But_Acepto_Click(sender As System.Object, e As System.EventArgs) Handles But_Acepto.Click
        If TextB_Provincia.Text <> "" Then
            Try
                Call conectar()
                conexion.Open()
                Dim Comando As New MySqlCommand
                Comando.Connection = conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from provincia where nom_provincia = '" & TextB_Provincia.Text & "';"
                Dim DReader As MySqlDataReader
                DReader = Comando.ExecuteReader
                If DReader.HasRows Then
                    MsgBox("Provincia Existente")
                    DReader.Close()
                Else
                    DReader.Close()
                    Comando.CommandText = "insert into provincia (nom_provincia) values('" & TextB_Provincia.Text & "');"
                    Comando.ExecuteNonQuery()
                End If
                DReader.Close()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
            ABMSocios.Text_Provincia.Text = TextB_Provincia.Text
            Close()
        Else
            MsgBox("Ingrese algun nombre o aprete CANCELAR")
            TextB_Provincia.Focus()
        End If
       
    End Sub

    Private Sub provincia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextB_Provincia.Clear()
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from provincia;"
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                Dim Mysource As New AutoCompleteStringCollection
                Do While DReader.Read
                    Mysource.Add(DReader.Item("nom_provincia"))
                Loop
                TextB_Provincia.AutoCompleteCustomSource = Mysource
            Else
                'MsgBox("El Socio no Extiste")
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    Dim IDProvincia As Integer
    Dim Nombre_p As String

    Private Sub But_Modificar_Click(sender As System.Object, e As System.EventArgs) Handles But_Modificar.Click
        If TextB_Provincia.Text <> "" Then
            Try
                Call conectar()
                conexion.Open()
                Dim Comando As New MySqlCommand
                Comando.Connection = conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "update provincia SET nom_provincia='" & TextB_Provincia.Text & "' where id_provincia=" & IDProvincia & ";"
                Comando.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
            ABMSocios.Text_Provincia.Text = TextB_Provincia.Text
            Close()
        Else
            MsgBox("Ingrese algun nombre o aprete CANCELAR")
            TextB_Provincia.Focus()
        End If
        
    End Sub


    Private Sub TextB_Provincia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextB_Provincia.KeyPress
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from provincia where nom_provincia = '" & TextB_Provincia.Text & "';"
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                DReader.Read()
                IDProvincia = DReader("id_provincia")
                DReader.Close()
                Lab_posi.Text = IDProvincia
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
End Class