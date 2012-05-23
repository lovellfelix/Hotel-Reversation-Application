<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
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
        Dim EmployeeNumberLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim HoursWorkLabel1 As System.Windows.Forms.Label
        Dim PayRateLabel As System.Windows.Forms.Label
        Dim OvertimeLabel As System.Windows.Forms.Label
        Dim NetPayLabel As System.Windows.Forms.Label
        Dim DeductionLabel As System.Windows.Forms.Label
        Dim FirstNameLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payroll))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.EmployeeNumberTextBox = New System.Windows.Forms.TextBox
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotelapp_dbDataSet = New database_project.Hotelapp_dbDataSet
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DeductionTextBox = New System.Windows.Forms.TextBox
        Me.PayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NetPayTextBox = New System.Windows.Forms.TextBox
        Me.OvertimeTextBox = New System.Windows.Forms.TextBox
        Me.PayRateTextBox = New System.Windows.Forms.TextBox
        Me.HoursWorkTextBox = New System.Windows.Forms.TextBox
        Me.EmployeeTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.EmployeeTableAdapter
        Me.TableAdapterManager = New database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
        Me.PayrollTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.PayrollTableAdapter
        Me.PayrollTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.nextButton = New System.Windows.Forms.Button
        Me.lastButton = New System.Windows.Forms.Button
        Me.firstButton = New System.Windows.Forms.Button
        Me.previousButton = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.deleteButton = New System.Windows.Forms.Button
        Me.newButton = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.loggOffButton = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewPayStubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPayStubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Hotelapp_dbDataSet1 = New database_project.Hotelapp_dbDataSet1
        Me.Payroll_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payroll_QueryTableAdapter = New database_project.Hotelapp_dbDataSet1TableAdapters.Payroll_QueryTableAdapter
        Me.TableAdapterManager1 = New database_project.Hotelapp_dbDataSet1TableAdapters.TableAdapterManager
        Me.FirstNameTextBox1 = New System.Windows.Forms.TextBox
        EmployeeNumberLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        HoursWorkLabel1 = New System.Windows.Forms.Label
        PayRateLabel = New System.Windows.Forms.Label
        OvertimeLabel = New System.Windows.Forms.Label
        NetPayLabel = New System.Windows.Forms.Label
        DeductionLabel = New System.Windows.Forms.Label
        FirstNameLabel1 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Hotelapp_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payroll_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeNumberLabel
        '
        EmployeeNumberLabel.AutoSize = True
        EmployeeNumberLabel.Location = New System.Drawing.Point(7, 53)
        EmployeeNumberLabel.Name = "EmployeeNumberLabel"
        EmployeeNumberLabel.Size = New System.Drawing.Size(64, 13)
        EmployeeNumberLabel.TabIndex = 2
        EmployeeNumberLabel.Text = "Employee #"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(7, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(31, 13)
        Label1.TabIndex = 1
        Label1.Text = "SS#:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(7, 64)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'HoursWorkLabel1
        '
        HoursWorkLabel1.AutoSize = True
        HoursWorkLabel1.Location = New System.Drawing.Point(8, 23)
        HoursWorkLabel1.Name = "HoursWorkLabel1"
        HoursWorkLabel1.Size = New System.Drawing.Size(67, 13)
        HoursWorkLabel1.TabIndex = 2
        HoursWorkLabel1.Text = "Hours Work:"
        '
        'PayRateLabel
        '
        PayRateLabel.AutoSize = True
        PayRateLabel.Location = New System.Drawing.Point(8, 69)
        PayRateLabel.Name = "PayRateLabel"
        PayRateLabel.Size = New System.Drawing.Size(55, 13)
        PayRateLabel.TabIndex = 3
        PayRateLabel.Text = "Pay Rate:"
        '
        'OvertimeLabel
        '
        OvertimeLabel.AutoSize = True
        OvertimeLabel.Location = New System.Drawing.Point(8, 47)
        OvertimeLabel.Name = "OvertimeLabel"
        OvertimeLabel.Size = New System.Drawing.Size(55, 13)
        OvertimeLabel.TabIndex = 4
        OvertimeLabel.Text = "Overtime:"
        '
        'NetPayLabel
        '
        NetPayLabel.AutoSize = True
        NetPayLabel.Location = New System.Drawing.Point(8, 127)
        NetPayLabel.Name = "NetPayLabel"
        NetPayLabel.Size = New System.Drawing.Size(49, 13)
        NetPayLabel.TabIndex = 6
        NetPayLabel.Text = "Net Pay:"
        '
        'DeductionLabel
        '
        DeductionLabel.AutoSize = True
        DeductionLabel.Location = New System.Drawing.Point(8, 102)
        DeductionLabel.Name = "DeductionLabel"
        DeductionLabel.Size = New System.Drawing.Size(59, 13)
        DeductionLabel.TabIndex = 8
        DeductionLabel.Text = "Deduction:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(EmployeeNumberLabel)
        Me.GroupBox3.Controls.Add(Me.EmployeeNumberTextBox)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 93)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employee Indentificaiton"
        '
        'EmployeeNumberTextBox
        '
        Me.EmployeeNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmployeeID", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.EmployeeNumberTextBox.Location = New System.Drawing.Point(73, 50)
        Me.EmployeeNumberTextBox.Name = "EmployeeNumberTextBox"
        Me.EmployeeNumberTextBox.Size = New System.Drawing.Size(100, 21)
        Me.EmployeeNumberTextBox.TabIndex = 3
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
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "SS#", True))
        Me.TextBox1.Location = New System.Drawing.Point(73, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(FirstNameLabel1)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox1)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 108)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(74, 61)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.LastNameTextBox.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(DeductionLabel)
        Me.GroupBox2.Controls.Add(Me.DeductionTextBox)
        Me.GroupBox2.Controls.Add(NetPayLabel)
        Me.GroupBox2.Controls.Add(Me.NetPayTextBox)
        Me.GroupBox2.Controls.Add(OvertimeLabel)
        Me.GroupBox2.Controls.Add(Me.OvertimeTextBox)
        Me.GroupBox2.Controls.Add(PayRateLabel)
        Me.GroupBox2.Controls.Add(Me.PayRateTextBox)
        Me.GroupBox2.Controls.Add(HoursWorkLabel1)
        Me.GroupBox2.Controls.Add(Me.HoursWorkTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(196, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 148)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salary Information"
        '
        'DeductionTextBox
        '
        Me.DeductionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "Deduction", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.DeductionTextBox.Location = New System.Drawing.Point(81, 95)
        Me.DeductionTextBox.Name = "DeductionTextBox"
        Me.DeductionTextBox.Size = New System.Drawing.Size(100, 21)
        Me.DeductionTextBox.TabIndex = 9
        '
        'PayrollBindingSource
        '
        Me.PayrollBindingSource.DataMember = "Payroll"
        Me.PayrollBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'NetPayTextBox
        '
        Me.NetPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payroll_QueryBindingSource, "NetPay", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.NetPayTextBox.Location = New System.Drawing.Point(81, 122)
        Me.NetPayTextBox.Name = "NetPayTextBox"
        Me.NetPayTextBox.Size = New System.Drawing.Size(100, 21)
        Me.NetPayTextBox.TabIndex = 7
        '
        'OvertimeTextBox
        '
        Me.OvertimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "Overtime", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.OvertimeTextBox.Location = New System.Drawing.Point(81, 44)
        Me.OvertimeTextBox.Name = "OvertimeTextBox"
        Me.OvertimeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.OvertimeTextBox.TabIndex = 5
        '
        'PayRateTextBox
        '
        Me.PayRateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "PayRate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.PayRateTextBox.Location = New System.Drawing.Point(81, 71)
        Me.PayRateTextBox.Name = "PayRateTextBox"
        Me.PayRateTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PayRateTextBox.TabIndex = 4
        '
        'HoursWorkTextBox
        '
        Me.HoursWorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "HoursWork", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.HoursWorkTextBox.Location = New System.Drawing.Point(81, 20)
        Me.HoursWorkTextBox.Name = "HoursWorkTextBox"
        Me.HoursWorkTextBox.Size = New System.Drawing.Size(100, 21)
        Me.HoursWorkTextBox.TabIndex = 3
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_InTableAdapter = Nothing
        Me.TableAdapterManager.Check_OutTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.GuestTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PayrollTableAdapter = Me.PayrollTableAdapter
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'PayrollTableAdapter
        '
        Me.PayrollTableAdapter.ClearBeforeFill = True
        '
        'PayrollTableAdapterBindingSource
        '
        Me.PayrollTableAdapterBindingSource.DataSource = GetType(database_project.Hotelapp_dbDataSetTableAdapters.PayrollTableAdapter)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.nextButton)
        Me.GroupBox6.Controls.Add(Me.lastButton)
        Me.GroupBox6.Controls.Add(Me.firstButton)
        Me.GroupBox6.Controls.Add(Me.previousButton)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 245)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(247, 54)
        Me.GroupBox6.TabIndex = 55
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
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(40, 20)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(71, 23)
        Me.previousButton.TabIndex = 49
        Me.previousButton.Text = "« &Previous"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.deleteButton)
        Me.GroupBox5.Controls.Add(Me.newButton)
        Me.GroupBox5.Location = New System.Drawing.Point(196, 185)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(209, 54)
        Me.GroupBox5.TabIndex = 56
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Modify Record"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "S&ave"
        Me.Button1.UseVisualStyleBackColor = True
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
        'newButton
        '
        Me.newButton.Location = New System.Drawing.Point(6, 20)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(58, 23)
        Me.newButton.TabIndex = 49
        Me.newButton.Text = "&New"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.loggOffButton)
        Me.GroupBox7.Location = New System.Drawing.Point(259, 245)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(146, 54)
        Me.GroupBox7.TabIndex = 57
        Me.GroupBox7.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(82, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 23)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'loggOffButton
        '
        Me.loggOffButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggOffButton.Location = New System.Drawing.Point(12, 20)
        Me.loggOffButton.Name = "loggOffButton"
        Me.loggOffButton.Size = New System.Drawing.Size(64, 23)
        Me.loggOffButton.TabIndex = 48
        Me.loggOffButton.Text = "L&og Off..."
        Me.loggOffButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PrintToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(418, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.LogOffToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.LogOffToolStripMenuItem.Text = "L&og Off..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewPayStubToolStripMenuItem, Me.PrintPayStubToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewPayStubToolStripMenuItem
        '
        Me.PrintPreviewPayStubToolStripMenuItem.Name = "PrintPreviewPayStubToolStripMenuItem"
        Me.PrintPreviewPayStubToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PrintPreviewPayStubToolStripMenuItem.Text = "Print Pre&view PayStub"
        '
        'PrintPayStubToolStripMenuItem
        '
        Me.PrintPayStubToolStripMenuItem.Name = "PrintPayStubToolStripMenuItem"
        Me.PrintPayStubToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PrintPayStubToolStripMenuItem.Text = "&Print PayStub"
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
        'Hotelapp_dbDataSet1
        '
        Me.Hotelapp_dbDataSet1.DataSetName = "Hotelapp_dbDataSet1"
        Me.Hotelapp_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Payroll_QueryBindingSource
        '
        Me.Payroll_QueryBindingSource.DataMember = "Payroll Query"
        Me.Payroll_QueryBindingSource.DataSource = Me.Hotelapp_dbDataSet1
        '
        'Payroll_QueryTableAdapter
        '
        Me.Payroll_QueryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Check_InTableAdapter = Nothing
        Me.TableAdapterManager1.Check_OutTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager1.GuestTableAdapter = Nothing
        Me.TableAdapterManager1.PaymentTableAdapter = Nothing
        Me.TableAdapterManager1.PayrollTableAdapter = Nothing
        Me.TableAdapterManager1.ReservationTableAdapter = Nothing
        Me.TableAdapterManager1.RoomTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = database_project.Hotelapp_dbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        '
        'FirstNameLabel1
        '
        FirstNameLabel1.AutoSize = True
        FirstNameLabel1.Location = New System.Drawing.Point(9, 35)
        FirstNameLabel1.Name = "FirstNameLabel1"
        FirstNameLabel1.Size = New System.Drawing.Size(62, 13)
        FirstNameLabel1.TabIndex = 4
        FirstNameLabel1.Text = "First Name:"
        '
        'FirstNameTextBox1
        '
        Me.FirstNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "FirstName", True))
        Me.FirstNameTextBox1.Location = New System.Drawing.Point(73, 29)
        Me.FirstNameTextBox1.Name = "FirstNameTextBox1"
        Me.FirstNameTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.FirstNameTextBox1.TabIndex = 5
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 311)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Payroll"
        Me.Text = "Admin Menue| PayRoll Information"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Hotelapp_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payroll_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hotelapp_dbDataSet As database_project.Hotelapp_dbDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents EmployeeNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PayrollBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OvertimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PayRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursWorkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeductionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PayrollTableAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents lastButton As System.Windows.Forms.Button
    Friend WithEvents firstButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents newButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents loggOffButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewPayStubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPayStubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.PayrollTableAdapter
    Friend WithEvents Hotelapp_dbDataSet1 As database_project.Hotelapp_dbDataSet1
    Friend WithEvents Payroll_QueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Payroll_QueryTableAdapter As database_project.Hotelapp_dbDataSet1TableAdapters.Payroll_QueryTableAdapter
    Friend WithEvents TableAdapterManager1 As database_project.Hotelapp_dbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents FirstNameTextBox1 As System.Windows.Forms.TextBox
End Class
