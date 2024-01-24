Public Class Form1
    Private Sub ProjetoAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetoAToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\000\exemplo\winformsapp1.exe")
    End Sub

    Private Sub PlaneamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaneamentoToolStripMenuItem.Click
        Dim myProcess = New Process()
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.FileName = "https://www.canva.com/design/DAF58mt9cPo/MLuXMr_RXyzxvv3dn14erA/view?utm_content=DAF58mt9cPo&utm_campaign=designshare&utm_medium=link&utm_source=editor"
        myProcess.Start()
    End Sub
End Class



