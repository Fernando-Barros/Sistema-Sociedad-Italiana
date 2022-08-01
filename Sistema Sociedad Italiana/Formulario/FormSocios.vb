Public Class FormSocios
    Private Sub Tab_ABM_Click(sender As Object, e As EventArgs) Handles Tab_ABM_S.Click

    End Sub

    Private Sub FormSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControlSocio.Visible = True
        ABMSocios.TopLevel = False
        Imprimir_Socio.TopLevel = False
        Imprimir_Socio.Show()
        TabImprecion_S.Controls.Add(Imprimir_Socio)
        ABMSocios.Show()
        Tab_ABM_S.Controls.Add(ABMSocios)
    End Sub
End Class