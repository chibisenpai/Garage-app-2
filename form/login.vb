Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices



Public Class login
    Dim connect As New OleDbConnection(My.Settings.dataConnectionString)



    Private Sub Log_Click(sender As Object, e As EventArgs) Handles log.Click
        If username.Text = Nothing Or pass.Text = Nothing Then
            MsgBox("enter credentials", MsgBoxStyle.Exclamation)
        Else
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from login where username=? and password=?", connect)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = username.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = pass.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("login succeeded")
                username.Text = ("")
                pass.Text = ("")
                Main.Show()
                Me.Hide()
            Else
                MsgBox("password or username is wrong")
            End If
        End If
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub
End Class
