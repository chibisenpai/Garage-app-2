Imports Guna.UI2.WinForms
Imports System.Data.OleDb
Imports System.Web.UI.WebControls

Public Class posedit
    'to connect data base and load it to the data grid view
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|data.accdb")
    Private Sub bind_date()
        Dim cmd1 As New OleDbCommand("select * from POS", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim POS As New DataTable
        POS.Clear()
        da.Fill(POS)
        Guna2DataGridView1.DataSource = POS

    End Sub

    Private Sub posedit_Load(sender As Object, e As EventArgs) Handles Me.Load
        bind_date()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim cmd4 As New OleDbCommand("UPDATE POS SET first_name='" & First_nameTextBox.Text & "', last_name='" & Last_nameTextBox.Text & "', Contact_no='" & Contact_noTextBox.Text & "', vehicle='" & Vehicle_typeTextBox.Text & "', service='" & ServiceComboBox.Text & "', price=" & PriceTextBox.Text & " WHERE id=" & Guna2TextBox1.Text & "", conn)
        conn.Open()
        cmd4.ExecuteNonQuery()
        conn.Close()
        bind_date()
    End Sub


    'populates the field s
    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)

            Guna2TextBox1.Text = selectedRow.Cells("id").Value.ToString()
            First_nameTextBox.Text = selectedRow.Cells("first_name").Value.ToString()
            Last_nameTextBox.Text = selectedRow.Cells("last_name").Value.ToString()
            Contact_noTextBox.Text = selectedRow.Cells("Contact_no").Value.ToString()
            Vehicle_typeTextBox.Text = selectedRow.Cells("vehicle").Value.ToString()
            ServiceComboBox.Text = selectedRow.Cells("service").Value.ToString()
            PriceTextBox.Text = selectedRow.Cells("price").Value.ToString()
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub
    'delete button
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim cmd5 As New OleDbCommand("delete from POS where id=@id", conn)
        cmd5.Parameters.AddWithValue("@id", Guna2TextBox1.Text)
        conn.Open()
        cmd5.ExecuteNonQuery()
        conn.Close()
        bind_date()
    End Sub

    'hides the tab
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
    End Sub
End Class
