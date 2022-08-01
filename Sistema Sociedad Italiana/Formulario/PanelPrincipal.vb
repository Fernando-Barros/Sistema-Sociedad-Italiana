Public Class PanelPrincipal
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub But_Socios_Click(sender As Object, e As EventArgs) Handles But_Socios.Click
        Me.ToolStripContainerPrin.ContentPanel.Controls.Clear()
        Dim Socios As New FormSocios
        Socios.MdiParent = Me
        Me.ToolStripContainerPrin.ContentPanel.Controls.Add(Socios)
        Socios.Show()
    End Sub

    Private Sub But_Alquiler_Click(sender As Object, e As EventArgs) Handles But_Alquiler.Click
        Me.ToolStripContainerPrin.ContentPanel.Controls.Clear()
    End Sub
End Class