Imports System.Drawing.Font
Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub مريضمراجعToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مريضمراجعToolStripMenuItem.Click

    End Sub

    Private Sub pdt_Click(sender As Object, e As EventArgs) Handles pdt.Click
        UnMotor.Show()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub قائمةالإنتظارToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles قائمةالإنتظارToolStripMenuItem1.Click
        policiesList.Show()
    End Sub

    Private Sub بياناتالفنيينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بياناتالفنيينToolStripMenuItem.Click
        Agent.show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    End Sub
End Class
