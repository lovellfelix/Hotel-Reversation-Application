<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeInfoForm
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
        Me.components = New System.ComponentModel.Container
        Dim SS_Label As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim RoleLabel As System.Windows.Forms.Label
        Dim MaritalStatusLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeInfoForm))
        Me.TableAdapterManager = New database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
        Me.EmployeeTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.EmployeeTableAdapter
        Me.UsersTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.UsersTableAdapter
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotelapp_dbDataSet = New database_project.Hotelapp_dbDataSet
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.newButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.saveButton = New System.Windows.Forms.Button
        Me.deleteButton = New System.Windows.Forms.Button
        Me.loggOffButton = New System.Windows.Forms.Button
        Me.lastButton = New System.Windows.Forms.Button
        Me.firstButton = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.nextButton = New System.Windows.Forms.Button
        Me.previousButton = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.SS_TextBox = New System.Windows.Forms.TextBox
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.UserNameTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.RoleTextBox = New System.Windows.Forms.TextBox
        Me.MaritalStatusTextBox = New System.Windows.Forms.TextBox
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.ZipTextBox = New System.Windows.Forms.TextBox
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        SS_Label = New System.Windows.Forms.Label
        EmployeeIDLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        UserNameLabel = New System.Windows.Forms.Label
        PasswordLabel = New System.Windows.Forms.Label
        RoleLabel = New System.Windows.Forms.Label
        MaritalStatusLabel = New System.Windows.Forms.Label
        TelephoneLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        StateLabel = New System.Windows.Forms.Label
        ZipLabel = New System.Windows.Forms.Label
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_InTableAdapter = Nothing
        Me.TableAdapterManager.Check_OutTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.GuestTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PayrollTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'Hotelapp_dbDataSet
        '
        Me.Hotelapp_dbDataSet.DataSetName = "Hotelapp_dbDataSet"
        Me.Hotelapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "EmployeeUsers"
        Me.UsersBindingSource.DataSource = Me.EmployeeBindingSource
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(RoleLabel)
        Me.GroupBox4.Controls.Add(Me.RoleTextBox)
        Me.GroupBox4.Controls.Add(PasswordLabel)
        Me.GroupBox4.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox4.Controls.Add(UserNameLabel)
        Me.GroupBox4.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(207, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(234, 117)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Login Credentials"
        '
        'newButton
        '
        Me.newButton.Location = New System.Drawing.Point(6, 20)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(58, 23)
        Me.newButton.TabIndex = 49
        Me.newButton.Text = "&New"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(82, 20)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(65, 23)
        Me.exitButton.TabIndex = 48
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(EmployeeIDLabel)
        Me.GroupBox3.Controls.Add(Me.EmployeeIDTextBox)
        Me.GroupBox3.Controls.Add(SS_Label)
        Me.GroupBox3.Controls.Add(Me.SS_TextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(191, 85)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employee Indentificaiton"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(ZipLabel)
        Me.GroupBox2.Controls.Add(Me.ZipTextBox)
        Me.GroupBox2.Controls.Add(StateLabel)
        Me.GroupBox2.Controls.Add(Me.StateTextBox)
        Me.GroupBox2.Controls.Add(CityLabel)
        Me.GroupBox2.Controls.Add(Me.CityTextBox)
        Me.GroupBox2.Controls.Add(AddressLabel)
        Me.GroupBox2.Controls.Add(Me.AddressTextBox)
        Me.GroupBox2.Controls.Add(TelephoneLabel)
        Me.GroupBox2.Controls.Add(Me.TelephoneTextBox)
        Me.GroupBox2.Controls.Add(MaritalStatusLabel)
        Me.GroupBox2.Controls.Add(Me.MaritalStatusTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 207)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(207, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 85)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.PrintToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 24)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem1, Me.SaveToolStripMenuItem1, Me.DeleteToolStripMenuItem, Me.LogOffToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.EditToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.EditToolStripMenuItem1.Text = "&Edit"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.SaveToolStripMenuItem1.Text = "&Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LogOffToolStripMenuItem.Text = "L&og Off.."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeInformationToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'EmployeeInformationToolStripMenuItem
        '
        Me.EmployeeInformationToolStripMenuItem.Name = "EmployeeInformationToolStripMenuItem"
        Me.EmployeeInformationToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EmployeeInformationToolStripMenuItem.Text = "&Employee Information"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.saveButton)
        Me.GroupBox5.Controls.Add(Me.deleteButton)
        Me.GroupBox5.Controls.Add(Me.newButton)
        Me.GroupBox5.Location = New System.Drawing.Point(208, 229)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(204, 54)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Modify Record"
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(137, 20)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(57, 23)
        Me.saveButton.TabIndex = 49
        Me.saveButton.Text = "S&ave"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(70, 20)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(61, 23)
        Me.deleteButton.TabIndex = 49
        Me.deleteButton.Text = "De&lete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'loggOffButton
        '
        Me.loggOffButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggOffButton.Location = New System.Drawing.Point(6, 20)
        Me.loggOffButton.Name = "loggOffButton"
        Me.loggOffButton.Size = New System.Drawing.Size(70, 23)
        Me.loggOffButton.TabIndex = 48
        Me.loggOffButton.Text = "L&og Off..."
        Me.loggOffButton.UseVisualStyleBackColor = True
        '
        'lastButton
        '
        Me.lastButton.Location = New System.Drawing.Point(195, 20)
        Me.lastButton.Name = "lastButton"
        Me.lastButton.Size = New System.Drawing.Size(36, 23)
        Me.lastButton.TabIndex = 53
        Me.lastButton.Text = "≥"
        Me.lastButton.UseVisualStyleBackColor = True
        '
        'firstButton
        '
        Me.firstButton.Location = New System.Drawing.Point(6, 20)
        Me.firstButton.Name = "firstButton"
        Me.firstButton.Size = New System.Drawing.Size(28, 23)
        Me.firstButton.TabIndex = 53
        Me.firstButton.Text = "≤"
        Me.firstButton.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.nextButton)
        Me.GroupBox6.Controls.Add(Me.lastButton)
        Me.GroupBox6.Controls.Add(Me.firstButton)
        Me.GroupBox6.Controls.Add(Me.previousButton)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 336)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(237, 54)
        Me.GroupBox6.TabIndex = 54
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Record Navigation"
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(117, 20)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(72, 23)
        Me.nextButton.TabIndex = 49
        Me.nextButton.Text = "Ne&xt »"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(40, 20)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(71, 23)
        Me.previousButton.TabIndex = 49
        Me.previousButton.Text = "« &Previous"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.exitButton)
        Me.GroupBox7.Controls.Add(Me.loggOffButton)
        Me.GroupBox7.Location = New System.Drawing.Point(255, 336)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(157, 52)
        Me.GroupBox7.TabIndex = 55
        Me.GroupBox7.TabStop = False
        '
        'SS_Label
        '
        SS_Label.AutoSize = True
        SS_Label.Location = New System.Drawing.Point(7, 23)
        SS_Label.Name = "SS_Label"
        SS_Label.Size = New System.Drawing.Size(31, 13)
        SS_Label.TabIndex = 3
        SS_Label.Text = "SS#:"
        '
        'SS_TextBox
        '
        Me.SS_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "SS#", True))
        Me.SS_TextBox.Location = New System.Drawing.Point(81, 19)
        Me.SS_TextBox.Name = "SS_TextBox"
        Me.SS_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.SS_TextBox.TabIndex = 4
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(5, 54)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(70, 13)
        EmployeeIDLabel.TabIndex = 4
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(81, 50)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeIDTextBox.TabIndex = 5
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(7, 16)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 0
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(73, 13)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(7, 50)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(74, 47)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(7, 22)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 0
        UserNameLabel.Text = "User Name:"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(76, 19)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 1
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(14, 52)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(76, 49)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'RoleLabel
        '
        RoleLabel.AutoSize = True
        RoleLabel.Location = New System.Drawing.Point(15, 80)
        RoleLabel.Name = "RoleLabel"
        RoleLabel.Size = New System.Drawing.Size(32, 13)
        RoleLabel.TabIndex = 4
        RoleLabel.Text = "Role:"
        '
        'RoleTextBox
        '
        Me.RoleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Role", True))
        Me.RoleTextBox.Location = New System.Drawing.Point(53, 77)
        Me.RoleTextBox.Name = "RoleTextBox"
        Me.RoleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RoleTextBox.TabIndex = 5
        '
        'MaritalStatusLabel
        '
        MaritalStatusLabel.AutoSize = True
        MaritalStatusLabel.Location = New System.Drawing.Point(4, 26)
        MaritalStatusLabel.Name = "MaritalStatusLabel"
        MaritalStatusLabel.Size = New System.Drawing.Size(74, 13)
        MaritalStatusLabel.TabIndex = 0
        MaritalStatusLabel.Text = "Marital Status:"
        '
        'MaritalStatusTextBox
        '
        Me.MaritalStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "MaritalStatus", True))
        Me.MaritalStatusTextBox.Location = New System.Drawing.Point(84, 23)
        Me.MaritalStatusTextBox.Name = "MaritalStatusTextBox"
        Me.MaritalStatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MaritalStatusTextBox.TabIndex = 1
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(17, 53)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 2
        TelephoneLabel.Text = "Telephone:"
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(84, 50)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelephoneTextBox.TabIndex = 3
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(24, 84)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 4
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(78, 81)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 5
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(27, 118)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 6
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(60, 100)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 7
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(27, 135)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 8
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(75, 133)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 9
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(35, 170)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 10
        ZipLabel.Text = "Zip:"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(66, 167)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipTextBox.TabIndex = 11
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 24)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(457, 25)
        Me.BindingNavigator1.TabIndex = 56
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'EmployeeInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 402)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmployeeInfoForm"
        Me.Text = "Admin Menue| Employee Information"
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableAdapterManager As database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents UsersTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Hotelapp_dbDataSet As database_project.Hotelapp_dbDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents newButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents loggOffButton As System.Windows.Forms.Button
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lastButton As System.Windows.Forms.Button
    Friend WithEvents firstButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SS_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaritalStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
