<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ServiceComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Vehicle_typeTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Contact_noTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Last_nameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.First_nameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.save = New Guna.UI2.WinForms.Guna2Button()
        Me.DataDataSet = New form.dataDataSet()
        Me.POSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POSTableAdapter = New form.dataDataSetTableAdapters.POSTableAdapter()
        Me.TableAdapterManager = New form.dataDataSetTableAdapters.TableAdapterManager()
        Me.POSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(131, 362)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(39, 23)
        Me.Guna2HtmlLabel6.TabIndex = 66
        Me.Guna2HtmlLabel6.Text = "Price"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.AutoRoundedCorners = True
        Me.PriceTextBox.BorderRadius = 12
        Me.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceTextBox.DefaultText = ""
        Me.PriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTextBox.Location = New System.Drawing.Point(183, 362)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PriceTextBox.PlaceholderText = ""
        Me.PriceTextBox.SelectedText = ""
        Me.PriceTextBox.Size = New System.Drawing.Size(192, 27)
        Me.PriceTextBox.TabIndex = 65
        '
        'ServiceComboBox
        '
        Me.ServiceComboBox.AutoRoundedCorners = True
        Me.ServiceComboBox.BackColor = System.Drawing.Color.Transparent
        Me.ServiceComboBox.BorderRadius = 17
        Me.ServiceComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ServiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ServiceComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServiceComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ServiceComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ServiceComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ServiceComboBox.ItemHeight = 30
        Me.ServiceComboBox.Items.AddRange(New Object() {"Oil filter change", "Wiper blades replacement ", "Replace air filter", "Scheduled maintenance ", "New tires", "Battery replacement ", "Brake work", "Antifreeze add", "Engine tune up", "Wheels aligned "})
        Me.ServiceComboBox.Location = New System.Drawing.Point(183, 302)
        Me.ServiceComboBox.Name = "ServiceComboBox"
        Me.ServiceComboBox.Size = New System.Drawing.Size(192, 36)
        Me.ServiceComboBox.TabIndex = 64
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(119, 309)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(56, 23)
        Me.Guna2HtmlLabel5.TabIndex = 63
        Me.Guna2HtmlLabel5.Text = "Service"
        '
        'Vehicle_typeTextBox
        '
        Me.Vehicle_typeTextBox.AutoRoundedCorners = True
        Me.Vehicle_typeTextBox.BorderRadius = 12
        Me.Vehicle_typeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Vehicle_typeTextBox.DefaultText = ""
        Me.Vehicle_typeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Vehicle_typeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Vehicle_typeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Vehicle_typeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Vehicle_typeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Vehicle_typeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Vehicle_typeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Vehicle_typeTextBox.Location = New System.Drawing.Point(183, 248)
        Me.Vehicle_typeTextBox.Name = "Vehicle_typeTextBox"
        Me.Vehicle_typeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Vehicle_typeTextBox.PlaceholderText = ""
        Me.Vehicle_typeTextBox.SelectedText = ""
        Me.Vehicle_typeTextBox.Size = New System.Drawing.Size(192, 27)
        Me.Vehicle_typeTextBox.TabIndex = 62
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(86, 250)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(96, 23)
        Me.Guna2HtmlLabel4.TabIndex = 61
        Me.Guna2HtmlLabel4.Text = "Vehicle Type"
        '
        'Contact_noTextBox
        '
        Me.Contact_noTextBox.AutoRoundedCorners = True
        Me.Contact_noTextBox.BorderRadius = 12
        Me.Contact_noTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Contact_noTextBox.DefaultText = ""
        Me.Contact_noTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Contact_noTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Contact_noTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Contact_noTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Contact_noTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Contact_noTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Contact_noTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Contact_noTextBox.Location = New System.Drawing.Point(183, 196)
        Me.Contact_noTextBox.Name = "Contact_noTextBox"
        Me.Contact_noTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Contact_noTextBox.PlaceholderText = ""
        Me.Contact_noTextBox.SelectedText = ""
        Me.Contact_noTextBox.Size = New System.Drawing.Size(192, 27)
        Me.Contact_noTextBox.TabIndex = 60
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(93, 200)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(86, 23)
        Me.Guna2HtmlLabel3.TabIndex = 59
        Me.Guna2HtmlLabel3.Text = "Contact No"
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.AutoRoundedCorners = True
        Me.Last_nameTextBox.BorderRadius = 12
        Me.Last_nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Last_nameTextBox.DefaultText = ""
        Me.Last_nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Last_nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Last_nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Last_nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Last_nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Last_nameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Last_nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(183, 145)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Last_nameTextBox.PlaceholderText = ""
        Me.Last_nameTextBox.SelectedText = ""
        Me.Last_nameTextBox.Size = New System.Drawing.Size(192, 27)
        Me.Last_nameTextBox.TabIndex = 58
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(98, 149)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(76, 23)
        Me.Guna2HtmlLabel2.TabIndex = 57
        Me.Guna2HtmlLabel2.Text = "Last name"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(97, 102)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(81, 23)
        Me.Guna2HtmlLabel1.TabIndex = 56
        Me.Guna2HtmlLabel1.Text = "First Name"
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.AutoRoundedCorners = True
        Me.First_nameTextBox.BorderRadius = 12
        Me.First_nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.First_nameTextBox.DefaultText = ""
        Me.First_nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.First_nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.First_nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.First_nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.First_nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.First_nameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.First_nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.First_nameTextBox.Location = New System.Drawing.Point(183, 98)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.First_nameTextBox.PlaceholderText = ""
        Me.First_nameTextBox.SelectedText = ""
        Me.First_nameTextBox.Size = New System.Drawing.Size(192, 27)
        Me.First_nameTextBox.TabIndex = 55
        '
        'save
        '
        Me.save.AutoRoundedCorners = True
        Me.save.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.save.BorderRadius = 21
        Me.save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.save.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.save.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.save.Location = New System.Drawing.Point(183, 418)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(192, 45)
        Me.save.TabIndex = 67
        Me.save.Text = "Save"
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'POSBindingSource
        '
        Me.POSBindingSource.DataMember = "POS"
        Me.POSBindingSource.DataSource = Me.DataDataSet
        '
        'POSTableAdapter
        '
        Me.POSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Cust_serviceTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.POSTableAdapter = Me.POSTableAdapter
        Me.TableAdapterManager.UpdateOrder = form.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'POSDataGridView
        '
        Me.POSDataGridView.AutoGenerateColumns = False
        Me.POSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.POSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.POSDataGridView.DataSource = Me.POSBindingSource
        Me.POSDataGridView.Location = New System.Drawing.Point(415, 39)
        Me.POSDataGridView.Name = "POSDataGridView"
        Me.POSDataGridView.Size = New System.Drawing.Size(710, 483)
        Me.POSDataGridView.TabIndex = 67
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "first name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "first name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "last name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "last name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contact no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact no"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "vehicle type"
        Me.DataGridViewTextBoxColumn6.HeaderText = "vehicle type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "service"
        Me.DataGridViewTextBoxColumn7.HeaderText = "service"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 555)
        Me.Controls.Add(Me.POSDataGridView)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.ServiceComboBox)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Vehicle_typeTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Contact_noTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Edit"
        Me.Text = "Form1"
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ServiceComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Vehicle_typeTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Contact_noTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Last_nameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents First_nameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataDataSet As dataDataSet
    Friend WithEvents POSBindingSource As BindingSource
    Friend WithEvents POSTableAdapter As dataDataSetTableAdapters.POSTableAdapter
    Friend WithEvents TableAdapterManager As dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents POSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
