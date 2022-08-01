Public Class FormPrincipal

    Private Sub ButSerrar_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub But_Socios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Socios.Click
        'Codigo para abrir formulario dentro de otro
        'Dim Socios As New FormSocios With {
        '    .MdiParent = Me
        '}
        'Me.ToolStripContainerSocios.ContentPanel.Controls.Add(Socios)
        'Socios.Show()

        'TabControlSocio.Visible = True
        'ABMSocios.TopLevel = False
        'Imprimir_Socio.TopLevel = False
        'Imprimir_Socio.Show()
        'TabPage2.Controls.Add(Imprimir_Socio)
        'ABMSocios.Show()
        'Tab_ABM.Controls.Add(ABMSocios)
    End Sub

    Private Sub Text_Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call Numero(e)


    End Sub


   
    Private Sub But_Escuela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Escuela.Click

        'TabControlSocio.Visible = True
        'TabControlSocio.SelectedTab = TabPage2


    End Sub

   
    Private Sub FormPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Login.Close()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        ' Me.Close()
        End
    End Sub

End Class
