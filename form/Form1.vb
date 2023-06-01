Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Threading.Tasks
Imports System.ComponentModel
Public Class Edit



    ' Public Sub runquery(ByVal query As String)
    ' con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\data.accdb")
    'Dim cmd As New OleDbCommand(query, con)
    'cmd.Parameters.AddWithValue("@first name", First_nameTextBox.Text)
    'cmd.Parameters.AddWithValue("@Last name", Last_nameTextBox.Text)
    'cmd.Parameters.AddWithValue("@Contact No", Contact_noTextBox.Text)
    'cmd.Parameters.AddWithValue("@Vehicle type", Vehicle_typeTextBox.Text)
    'cmd.Parameters.AddWithValue("@Service", ServiceComboBox.Text)
    'cmd.Parameters.AddWithValue("@Price", PriceTextBox.Text)
    'con.Open()
    'cmd.ExecuteNonQuery()
    'con.Close()


    'End Sub

    '  Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
    '`Dim inserquery As String = "insert into POS (First name, Last name, Contact No, Price, Vehicle type, Service) VALUES (@first_name,@last_name, @Contact_No, @Vehicle_type, @Service, @Price  )"
    ' runquery(inserquery)
    ' MessageBox.Show("record successfully")



    Public Class pos
        ' ...




        ' ...
    End Class

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Me.POSTableAdapter.Fill(Me.DataDataSet.POS)
    End Sub





    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb" ' Replace with your actual database file path
        Dim connection As New OleDbConnection(connectionString)

        Try
            connection.Open()

            For Each row As DataGridViewRow In POSDataGridView.Rows
                If Not row.IsNewRow Then
                    Dim firstName As String = row.Cells("First_nameColumn").Value.ToString()
                    Dim lastName As String = row.Cells("Last_nameColumn").Value.ToString()
                    Dim contactNo As String = row.Cells("Contact_noColumn").Value.ToString()
                    Dim price As Decimal = Convert.ToDecimal(row.Cells("PriceColumn").Value)
                    Dim vehicleType As String = row.Cells("Vehicle_typeColumn").Value.ToString()
                    Dim service As String = row.Cells("ServiceColumn").Value.ToString()

                    ' Execute the INSERT query to save the data
                    Dim insertQuery As String = "INSERT INTO POS (First_name, Last_name, Contact_no, Price, Vehicle_type, Service) VALUES (@FirstName, @LastName, @ContactNo, @Price, @VehicleType, @Service)"
                    Dim command As New OleDbCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@ContactNo", contactNo)
                    command.Parameters.AddWithValue("@Price", price)
                    command.Parameters.AddWithValue("@VehicleType", vehicleType)
                    command.Parameters.AddWithValue("@Service", service)
                    command.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Data saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            connection.Close()
        End Try
    End Sub


End Class