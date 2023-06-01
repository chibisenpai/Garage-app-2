Imports Guna.UI2.WinForms
Imports System.Data.OleDb
Public Class pos
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

    Private Sub pos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataDataSet.POS' table. You can move, or remove it, as needed.

        bind_date()
    End Sub
    'add new fields into the pos system
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim strsql As String
        strsql = "Insert into POS(first_name,last_name,Contact_no,vehicle,service,price)Values(@first_name,@last_name,@Conatact_no,@vehicle,@service,@price)"
        Dim cmd2 As New OleDbCommand(strsql, conn)
        cmd2.Parameters.AddWithValue("@first_name", First_nameTextBox.Text)
        cmd2.Parameters.AddWithValue("@last_name", Last_nameTextBox.Text)
        cmd2.Parameters.AddWithValue("@Conatact_no", Contact_noTextBox.Text)
        cmd2.Parameters.AddWithValue("@vehicle", Vehicle_typeTextBox.Text)
        cmd2.Parameters.AddWithValue("@service", ServiceComboBox.Text)
        cmd2.Parameters.AddWithValue("@price", PriceTextBox.Text)
        conn.Open()
        cmd2.ExecuteNonQuery()
        conn.Close()
        bind_date()
    End Sub
    'hides the tab
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
    End Sub
End Class