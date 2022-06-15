Public Class NewAgent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False

    End Sub



    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
    End Sub

End Class
