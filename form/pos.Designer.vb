<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim Contact_noLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Vehicle_typeLabel As System.Windows.Forms.Label
        Dim ServiceLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.save = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.POSDataGridView = New System.Windows.Forms.DataGridView()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_noTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Vehicle_typeTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceTextBox = New System.Windows.Forms.TextBox()
        Me.POSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New form.dataDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSTableAdapter = New form.dataDataSetTableAdapters.POSTableAdapter()
        Me.TableAdapterManager = New form.dataDataSetTableAdapters.TableAdapterManager()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New form.dataDataSetTableAdapters.LoginTableAdapter()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        Contact_noLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Vehicle_typeLabel = New System.Windows.Forms.Label()
        ServiceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.POSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(72, 129)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(55, 13)
        First_nameLabel.TabIndex = 29
        First_nameLabel.Text = "first name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Location = New System.Drawing.Point(72, 155)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(55, 13)
        Last_nameLabel.TabIndex = 31
        Last_nameLabel.Text = "last name:"
        '
        'Contact_noLabel
        '
        Contact_noLabel.AutoSize = True
        Contact_noLabel.Location = New System.Drawing.Point(72, 181)
        Contact_noLabel.Name = "Contact_noLabel"
        Contact_noLabel.Size = New System.Drawing.Size(62, 13)
        Contact_noLabel.TabIndex = 33
        Contact_noLabel.Text = "Contact no:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(72, 259)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(33, 13)
        PriceLabel.TabIndex = 35
        PriceLabel.Text = "price:"
        '
        'Vehicle_typeLabel
        '
        Vehicle_typeLabel.AutoSize = True
        Vehicle_typeLabel.Location = New System.Drawing.Point(72, 233)
        Vehicle_typeLabel.Name = "Vehicle_typeLabel"
        Vehicle_typeLabel.Size = New System.Drawing.Size(67, 13)
        Vehicle_typeLabel.TabIndex = 37
        Vehicle_typeLabel.Text = "vehicle type:"
        '
        'ServiceLabel
        '
        ServiceLabel.AutoSize = True
        ServiceLabel.Location = New System.Drawing.Point(72, 207)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New System.Drawing.Size(44, 13)
        ServiceLabel.TabIndex = 39
        ServiceLabel.Text = "service:"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 3
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'save
        '
        Me.save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.Location = New System.Drawing.Point(60, 328)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(180, 45)
        Me.save.TabIndex = 13
        Me.save.Text = "save"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(60, 473)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 27
        Me.Guna2Button1.Text = "back"
        '
        'POSDataGridView
        '
        Me.POSDataGridView.AllowUserToDeleteRows = False
        Me.POSDataGridView.AutoGenerateColumns = False
        Me.POSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.POSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.POSDataGridView.DataSource = Me.POSBindingSource
        Me.POSDataGridView.Location = New System.Drawing.Point(358, 65)
        Me.POSDataGridView.Name = "POSDataGridView"
        Me.POSDataGridView.ReadOnly = True
        Me.POSDataGridView.Size = New System.Drawing.Size(616, 506)
        Me.POSDataGridView.TabIndex = 27
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "first name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(145, 126)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_nameTextBox.TabIndex = 30
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "last name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(145, 152)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_nameTextBox.TabIndex = 32
        '
        'Contact_noTextBox
        '
        Me.Contact_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "Contact no", True))
        Me.Contact_noTextBox.Location = New System.Drawing.Point(145, 178)
        Me.Contact_noTextBox.Name = "Contact_noTextBox"
        Me.Contact_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Contact_noTextBox.TabIndex = 34
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(145, 256)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 36
        '
        'Vehicle_typeTextBox
        '
        Me.Vehicle_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "vehicle type", True))
        Me.Vehicle_typeTextBox.Location = New System.Drawing.Point(145, 230)
        Me.Vehicle_typeTextBox.Name = "Vehicle_typeTextBox"
        Me.Vehicle_typeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vehicle_typeTextBox.TabIndex = 38
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.POSBindingSource, "service", True))
        Me.ServiceTextBox.Location = New System.Drawing.Point(145, 204)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ServiceTextBox.TabIndex = 40
        '
        'POSBindingSource
        '
        Me.POSBindingSource.DataMember = "POS"
        Me.POSBindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "first name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "first name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "last name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "last name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contact no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact no"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "service"
        Me.DataGridViewTextBoxColumn5.HeaderText = "service"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn6.HeaderText = "price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'POSTableAdapter
        '
        Me.POSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.POSTableAdapter = Me.POSTableAdapter
        Me.TableAdapterManager.UpdateOrder = form.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.DataDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(726, 20)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(200, 36)
        Me.Guna2TextBox1.TabIndex = 41
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(656, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(41, 13)
        Label1.TabIndex = 42
        Label1.Text = "Search"
        '
        'pos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 591)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(Contact_noLabel)
        Me.Controls.Add(Me.Contact_noTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Vehicle_typeLabel)
        Me.Controls.Add(Me.Vehicle_typeTextBox)
        Me.Controls.Add(ServiceLabel)
        Me.Controls.Add(Me.ServiceTextBox)
        Me.Controls.Add(Me.POSDataGridView)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pos"
        Me.Text = "pos"
        CType(Me.POSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents POSBindingSource As BindingSource
    Friend WithEvents DataDataSet As dataDataSet
    Friend WithEvents POSTableAdapter As dataDataSetTableAdapters.POSTableAdapter
    Friend WithEvents TableAdapterManager As dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As dataDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents Contact_noTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Vehicle_typeTextBox As TextBox
    Friend WithEvents ServiceTextBox As TextBox
    Friend WithEvents POSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
