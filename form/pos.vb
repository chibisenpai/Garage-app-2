Public Class pos
    Private Sub PatientBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs)
        Me.Validate()
        Me.POSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If Trim(First_nameTextBox.Text) = Nothing Or (Last_nameTextBox.Text) = Nothing Or Trim(Contact_noTextBox.Text) = "" Or Trim(ServiceTextBox.Text) = "" Or Trim(PriceTextBox.Text) = "" Or Trim(Vehicle_typeTextBox.Text) = "" Or Trim(ServiceTextBox.Text) = "" Or Trim(Last_nameTextBox.Text) = "" Then
            MessageBox.Show("Please fill all the fields", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.POSTableAdapter.Insert(First_nameTextBox.Text, Last_nameTextBox.Text, Contact_noTextBox.Text, PriceTextBox.Text, ServiceTextBox.Text, Vehicle_typeTextBox.Text)
            MessageBox.Show("New Purchase has been added successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.POSTableAdapter.Fill(Me.DataDataSet.POS)
        End If
    End Sub




    Private Sub pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DataDataSet.Login)
        Me.POSTableAdapter.Fill(Me.DataDataSet.POS)
        Last_nameTextBox.Clear()
        First_nameTextBox.Clear()
        Contact_noTextBox.Clear()
        Vehicle_typeTextBox.Clear()
        ServiceTextBox.Clear()
        PriceTextBox.Clear()
        PriceTextBox.Clear()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub


End Class