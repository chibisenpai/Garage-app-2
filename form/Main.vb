Public Class Main
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub log_Click(sender As Object, e As EventArgs) Handles log.Click
        Me.Hide()
        MsgBox("logged out")
        login.Show()
    End Sub

    Private Sub Guna2Shapes1_Click(sender As Object, e As EventArgs) Handles Guna2Shapes1.Click
        pos.Show()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        pos.Show()
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click
        pos.Show()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        posedit.Show()
    End Sub

    Private Sub Guna2Shapes2_Click(sender As Object, e As EventArgs) Handles Guna2Shapes2.Click
        posedit.Show()
    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click
        posedit.Show()

    End Sub
End Class