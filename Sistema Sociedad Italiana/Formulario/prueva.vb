Public Class prueva

    Private Sub Button_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_buscar.Click
        TextEncryp.Text = CrearHashMD5(text_num.Text)
        'TextDesencryp.Text = Decifrado_clave(TextEncryp.Text)
        Dim OptionMess As DialogResult
        OptionMess = MsgBox("El SOCIO sera dado de BAJA", MsgBoxStyle.YesNo, "                          BAJA")

        If OptionMess = Windows.Forms.DialogResult.Yes Then
            MsgBox("El SOCIO sera dado de BAJA", MsgBoxStyle.YesNo, "                          BAJA")

        End If

    End Sub

    
End Class