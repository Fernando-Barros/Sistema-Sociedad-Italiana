Imports MySql.Data.MySqlClient
Public Class Localidad

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub But_Acepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Acepto.Click
        If TextB_Localidad.Text <> "" Then
            Try
                Call conectar()
                conexion.Open()
                Dim Comando As New MySqlCommand
                Comando.Connection = conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from localidad where localidad = '" & TextB_Localidad.Text.Trim & "';"
                Dim DReader As MySqlDataReader
                DReader = Comando.ExecuteReader
                If DReader.HasRows Then
                    MsgBox("Pais Existente")
                    DReader.Close()
                Else
                    DReader.Close()
                    Comando.CommandText = "insert into localidad (localidad) values('" & TextB_Localidad.Text.Trim & "');"
                    Comando.ExecuteNonQuery()
                End If
                DReader.Close()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
            ABMSocios.Text_Provincia.Text = TextB_Localidad.Text
            Close()
        Else
            MsgBox("Ingrese algun nombre o presione CANCELAR")
            TextB_Localidad.Focus()
        End If

    End Sub

    Private Sub Localidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextB_Localidad.Clear()
        TextB_Localidad.Text = ABMSocios.Text_Cuidad.Text
        Try
            Call conectar()
            conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from localidad;"
            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader
            If DReader.HasRows Then
                Dim Mysource As New AutoCompleteStringCollection
                Do While DReader.Read
                    Mysource.Add(DReader.Item("localidad"))
                Loop
                TextB_Localidad.AutoCompleteCustomSource = Mysource
            Else
                'MsgBox("El Pais no Extiste")
            End If
            DReader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    Dim IDPais As Integer
    Dim Nombre_p As String

    Private Sub But_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Modificar.Click
        If TextB_Localidad.Text <> "" Then
            Dim ID As String
            ID = burcar_ID("localidad", "localidad", TextB_Localidad.Text)
            Try
                Call conectar()
                conexion.Open()
                Dim Comando As New MySqlCommand
                Comando.Connection = conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "update pais SET localidad='" & TextB_Localidad.Text.Trim & "' where id=" & IDPais & ";"
                Comando.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
            End Try
            ABMSocios.Text_Pais.Text = TextB_Localidad.Text
            Close()
        Else
            MsgBox("Ingrese algun nombre o presione CANCELAR")
            TextB_Localidad.Focus()
        End If

    End Sub

   
    Private Sub TextB_Localidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextB_Localidad.TextChanged
      
    End Sub
End Class