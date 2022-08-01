Public Class PadreHijo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ToolStripContainerPadre.ContentPanel.Controls.Clear()
        Dim Socios As New FormSocios
        Socios.MdiParent = Me
        Me.ToolStripContainerPadre.ContentPanel.Controls.Add(Socios)
        Socios.Show()
    End Sub
End Class