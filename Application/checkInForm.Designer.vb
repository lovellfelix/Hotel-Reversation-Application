<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationForm
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
        Dim ReservationIDLabel As System.Windows.Forms.Label
        Dim ChildrenLabel As System.Windows.Forms.Label
        Dim AdultsLabel As System.Windows.Forms.Label
        Dim NightsLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim CheckInDateLabel As System.Windows.Forms.Label
        Dim CheckOutDateLabel As System.Windows.Forms.Label
        Dim StateLabel1 As System.Windows.Forms.Label
        Dim PaymentTypeLabel As System.Windows.Forms.Label
        Dim PaymentAmountLabel As System.Windows.Forms.Label
        Dim RoomTypeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationForm))
        Me.ReservationIDTextBox = New System.Windows.Forms.TextBox
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotelapp_dbDataSet = New database_project.Hotelapp_dbDataSet
        Me.ChildrenTextBox = New System.Windows.Forms.TextBox
        Me.AdultsTextBox = New System.Windows.Forms.TextBox
        Me.NightsTextBox = New System.Windows.Forms.TextBox
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.GuestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.ZipTextBox = New System.Windows.Forms.TextBox
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RoomTypeComboBox = New System.Windows.Forms.ComboBox
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CheckOutDateTextBox = New System.Windows.Forms.TextBox
        Me.Check_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckInDateTextBox = New System.Windows.Forms.TextBox
        Me.Check_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PaymentAmountTextBox = New System.Windows.Forms.TextBox
        Me.PaymentTypeTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.searchButton = New System.Windows.Forms.Button
        Me.FNsearchTB = New System.Windows.Forms.TextBox
        Me.IDsearchTB = New System.Windows.Forms.TextBox
        Me.LNsearchTB = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintCustomerInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReservationTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.ReservationTableAdapter
        Me.TableAdapterManager = New database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
        Me.Check_InTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.Check_InTableAdapter
        Me.Check_OutTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.Check_OutTableAdapter
        Me.GuestTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.GuestTableAdapter
        Me.PaymentTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.PaymentTableAdapter
        Me.RoomTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.RoomTableAdapter
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.nextButton = New System.Windows.Forms.Button
        Me.lastButton = New System.Windows.Forms.Button
        Me.firstButton = New System.Windows.Forms.Button
        Me.previousButton = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.saveButton = New System.Windows.Forms.Button
        Me.deleteButton = New System.Windows.Forms.Button
        Me.newButton = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.exitButton = New System.Windows.Forms.Button
        Me.loggOffButton = New System.Windows.Forms.Button
        Me.ReservationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        ReservationIDLabel = New System.Windows.Forms.Label
        ChildrenLabel = New System.Windows.Forms.Label
        AdultsLabel = New System.Windows.Forms.Label
        NightsLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        TelephoneLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        ZipLabel = New System.Windows.Forms.Label
        CountryLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CheckInDateLabel = New System.Windows.Forms.Label
        CheckOutDateLabel = New System.Windows.Forms.Label
        StateLabel1 = New System.Windows.Forms.Label
        PaymentTypeLabel = New System.Windows.Forms.Label
        PaymentAmountLabel = New System.Windows.Forms.Label
        RoomTypeLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Check_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Check_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReservationIDLabel
        '
        ReservationIDLabel.AutoSize = True
        ReservationIDLabel.Location = New System.Drawing.Point(6, 21)
        ReservationIDLabel.Name = "ReservationIDLabel"
        ReservationIDLabel.Size = New System.Drawing.Size(83, 13)
        ReservationIDLabel.TabIndex = 1
        ReservationIDLabel.Text = "Reservation ID:"
        '
        'ChildrenLabel
        '
        ChildrenLabel.AutoSize = True
        ChildrenLabel.Location = New System.Drawing.Point(6, 95)
        ChildrenLabel.Name = "ChildrenLabel"
        ChildrenLabel.Size = New System.Drawing.Size(50, 13)
        ChildrenLabel.TabIndex = 5
        ChildrenLabel.Text = "Children:"
        '
        'AdultsLabel
        '
        AdultsLabel.AutoSize = True
        AdultsLabel.Location = New System.Drawing.Point(10, 69)
        AdultsLabel.Name = "AdultsLabel"
        AdultsLabel.Size = New System.Drawing.Size(41, 13)
        AdultsLabel.TabIndex = 7
        AdultsLabel.Text = "Adults:"
        '
        'NightsLabel
        '
        NightsLabel.AutoSize = True
        NightsLabel.Location = New System.Drawing.Point(10, 41)
        NightsLabel.Name = "NightsLabel"
        NightsLabel.Size = New System.Drawing.Size(41, 13)
        NightsLabel.TabIndex = 13
        NightsLabel.Text = "Nights:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(6, 23)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(62, 13)
        FirstNameLabel.TabIndex = 15
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(6, 50)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 17
        LastNameLabel.Text = "Last Name:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(4, 226)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 19
        TelephoneLabel.Text = "Telephone:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(7, 77)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(50, 13)
        AddressLabel.TabIndex = 21
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(7, 104)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(30, 13)
        CityLabel.TabIndex = 23
        CityLabel.Text = "City:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(7, 158)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 27
        ZipLabel.Text = "Zip:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(4, 190)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(50, 13)
        CountryLabel.TabIndex = 29
        CountryLabel.Text = "Country:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(4, 76)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 13)
        Label2.TabIndex = 17
        Label2.Text = "Last Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(4, 48)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(62, 13)
        Label3.TabIndex = 15
        Label3.Text = "First Name:"
        '
        'CheckInDateLabel
        '
        CheckInDateLabel.AutoSize = True
        CheckInDateLabel.Location = New System.Drawing.Point(3, 23)
        CheckInDateLabel.Name = "CheckInDateLabel"
        CheckInDateLabel.Size = New System.Drawing.Size(79, 13)
        CheckInDateLabel.TabIndex = 0
        CheckInDateLabel.Text = "Check In Date:"
        '
        'CheckOutDateLabel
        '
        CheckOutDateLabel.AutoSize = True
        CheckOutDateLabel.Location = New System.Drawing.Point(3, 51)
        CheckOutDateLabel.Name = "CheckOutDateLabel"
        CheckOutDateLabel.Size = New System.Drawing.Size(87, 13)
        CheckOutDateLabel.TabIndex = 2
        CheckOutDateLabel.Text = "Check Out Date:"
        '
        'StateLabel1
        '
        StateLabel1.AutoSize = True
        StateLabel1.Location = New System.Drawing.Point(7, 133)
        StateLabel1.Name = "StateLabel1"
        StateLabel1.Size = New System.Drawing.Size(37, 13)
        StateLabel1.TabIndex = 30
        StateLabel1.Text = "State:"
        '
        'PaymentTypeLabel
        '
        PaymentTypeLabel.AutoSize = True
        PaymentTypeLabel.Location = New System.Drawing.Point(6, 23)
        PaymentTypeLabel.Name = "PaymentTypeLabel"
        PaymentTypeLabel.Size = New System.Drawing.Size(80, 13)
        PaymentTypeLabel.TabIndex = 34
        PaymentTypeLabel.Text = "Payment Type:"
        '
        'PaymentAmountLabel
        '
        PaymentAmountLabel.AutoSize = True
        PaymentAmountLabel.Location = New System.Drawing.Point(6, 50)
        PaymentAmountLabel.Name = "PaymentAmountLabel"
        PaymentAmountLabel.Size = New System.Drawing.Size(93, 13)
        PaymentAmountLabel.TabIndex = 35
        PaymentAmountLabel.Text = "Payment Amount:"
        '
        'RoomTypeLabel
        '
        RoomTypeLabel.AutoSize = True
        RoomTypeLabel.Location = New System.Drawing.Point(10, 14)
        RoomTypeLabel.Name = "RoomTypeLabel"
        RoomTypeLabel.Size = New System.Drawing.Size(65, 13)
        RoomTypeLabel.TabIndex = 30
        RoomTypeLabel.Text = "Room Type:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(3, 21)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 13)
        Label1.TabIndex = 1
        Label1.Text = "Reservation ID:"
        '
        'ReservationIDTextBox
        '
        Me.ReservationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "ReservationID", True))
        Me.ReservationIDTextBox.Location = New System.Drawing.Point(95, 18)
        Me.ReservationIDTextBox.Name = "ReservationIDTextBox"
        Me.ReservationIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ReservationIDTextBox.TabIndex = 2
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'Hotelapp_dbDataSet
        '
        Me.Hotelapp_dbDataSet.DataSetName = "Hotelapp_dbDataSet"
        Me.Hotelapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChildrenTextBox
        '
        Me.ChildrenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Children", True))
        Me.ChildrenTextBox.Location = New System.Drawing.Point(92, 96)
        Me.ChildrenTextBox.Name = "ChildrenTextBox"
        Me.ChildrenTextBox.Size = New System.Drawing.Size(113, 21)
        Me.ChildrenTextBox.TabIndex = 6
        '
        'AdultsTextBox
        '
        Me.AdultsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Adults", True))
        Me.AdultsTextBox.Location = New System.Drawing.Point(92, 69)
        Me.AdultsTextBox.Name = "AdultsTextBox"
        Me.AdultsTextBox.Size = New System.Drawing.Size(113, 21)
        Me.AdultsTextBox.TabIndex = 8
        '
        'NightsTextBox
        '
        Me.NightsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Nights", True))
        Me.NightsTextBox.Location = New System.Drawing.Point(92, 42)
        Me.NightsTextBox.Name = "NightsTextBox"
        Me.NightsTextBox.Size = New System.Drawing.Size(113, 21)
        Me.NightsTextBox.TabIndex = 14
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(93, 23)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FirstNameTextBox.TabIndex = 16
        '
        'GuestBindingSource
        '
        Me.GuestBindingSource.DataMember = "Guest"
        Me.GuestBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(93, 50)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.LastNameTextBox.TabIndex = 18
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(92, 226)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(100, 21)
        Me.TelephoneTextBox.TabIndex = 20
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(93, 77)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 21)
        Me.AddressTextBox.TabIndex = 22
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(93, 104)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CityTextBox.TabIndex = 24
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(93, 158)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 21)
        Me.ZipTextBox.TabIndex = 28
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(92, 190)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CountryTextBox.TabIndex = 30
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(StateLabel1)
        Me.GroupBox1.Controls.Add(Me.StateTextBox)
        Me.GroupBox1.Controls.Add(TelephoneLabel)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(CountryLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.CountryTextBox)
        Me.GroupBox1.Controls.Add(Me.TelephoneTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(ZipLabel)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.ZipTextBox)
        Me.GroupBox1.Controls.Add(CityLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 271)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(92, 130)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 21)
        Me.StateTextBox.TabIndex = 31
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(RoomTypeLabel)
        Me.GroupBox2.Controls.Add(Me.RoomTypeComboBox)
        Me.GroupBox2.Controls.Add(Me.ChildrenTextBox)
        Me.GroupBox2.Controls.Add(ChildrenLabel)
        Me.GroupBox2.Controls.Add(Me.AdultsTextBox)
        Me.GroupBox2.Controls.Add(AdultsLabel)
        Me.GroupBox2.Controls.Add(Me.NightsTextBox)
        Me.GroupBox2.Controls.Add(NightsLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(243, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 123)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Room Information"
        '
        'RoomTypeComboBox
        '
        Me.RoomTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "RoomType", True))
        Me.RoomTypeComboBox.FormattingEnabled = True
        Me.RoomTypeComboBox.Location = New System.Drawing.Point(92, 11)
        Me.RoomTypeComboBox.Name = "RoomTypeComboBox"
        Me.RoomTypeComboBox.Size = New System.Drawing.Size(113, 21)
        Me.RoomTypeComboBox.TabIndex = 31
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "Room"
        Me.RoomBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(ReservationIDLabel)
        Me.GroupBox3.Controls.Add(Me.ReservationIDTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 55)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reservation #"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(CheckOutDateLabel)
        Me.GroupBox4.Controls.Add(Me.CheckOutDateTextBox)
        Me.GroupBox4.Controls.Add(CheckInDateLabel)
        Me.GroupBox4.Controls.Add(Me.CheckInDateTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 88)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(224, 83)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lenght of Stay"
        '
        'CheckOutDateTextBox
        '
        Me.CheckOutDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_OutBindingSource, "CheckOutDate", True))
        Me.CheckOutDateTextBox.Location = New System.Drawing.Point(96, 48)
        Me.CheckOutDateTextBox.Name = "CheckOutDateTextBox"
        Me.CheckOutDateTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CheckOutDateTextBox.TabIndex = 3
        '
        'Check_OutBindingSource
        '
        Me.Check_OutBindingSource.DataMember = "Check Out"
        Me.Check_OutBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'CheckInDateTextBox
        '
        Me.CheckInDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_InBindingSource, "CheckInDate", True))
        Me.CheckInDateTextBox.Location = New System.Drawing.Point(96, 23)
        Me.CheckInDateTextBox.Name = "CheckInDateTextBox"
        Me.CheckInDateTextBox.Size = New System.Drawing.Size(100, 21)
        Me.CheckInDateTextBox.TabIndex = 1
        '
        'Check_InBindingSource
        '
        Me.Check_InBindingSource.DataMember = "Check In"
        Me.Check_InBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(PaymentAmountLabel)
        Me.GroupBox5.Controls.Add(Me.PaymentAmountTextBox)
        Me.GroupBox5.Controls.Add(PaymentTypeLabel)
        Me.GroupBox5.Controls.Add(Me.PaymentTypeTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(243, 305)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(224, 83)
        Me.GroupBox5.TabIndex = 37
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Billing Information"
        '
        'PaymentAmountTextBox
        '
        Me.PaymentAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "PaymentAmount", True))
        Me.PaymentAmountTextBox.Location = New System.Drawing.Point(105, 47)
        Me.PaymentAmountTextBox.Name = "PaymentAmountTextBox"
        Me.PaymentAmountTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PaymentAmountTextBox.TabIndex = 36
        '
        'PaymentTypeTextBox
        '
        Me.PaymentTypeTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.PaymentTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "PaymentType", True))
        Me.PaymentTypeTextBox.Location = New System.Drawing.Point(105, 20)
        Me.PaymentTypeTextBox.Name = "PaymentTypeTextBox"
        Me.PaymentTypeTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PaymentTypeTextBox.TabIndex = 35
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.searchButton)
        Me.GroupBox6.Controls.Add(Label1)
        Me.GroupBox6.Controls.Add(Label3)
        Me.GroupBox6.Controls.Add(Me.FNsearchTB)
        Me.GroupBox6.Controls.Add(Me.IDsearchTB)
        Me.GroupBox6.Controls.Add(Me.LNsearchTB)
        Me.GroupBox6.Controls.Add(Label2)
        Me.GroupBox6.Location = New System.Drawing.Point(243, 27)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(224, 144)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Search for information"
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(143, 103)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 20
        Me.searchButton.Text = "Sear&ch"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'FNsearchTB
        '
        Me.FNsearchTB.Location = New System.Drawing.Point(88, 45)
        Me.FNsearchTB.Name = "FNsearchTB"
        Me.FNsearchTB.Size = New System.Drawing.Size(130, 21)
        Me.FNsearchTB.TabIndex = 16
        '
        'IDsearchTB
        '
        Me.IDsearchTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "ReservationID", True))
        Me.IDsearchTB.Location = New System.Drawing.Point(88, 18)
        Me.IDsearchTB.Name = "IDsearchTB"
        Me.IDsearchTB.Size = New System.Drawing.Size(130, 21)
        Me.IDsearchTB.TabIndex = 2
        '
        'LNsearchTB
        '
        Me.LNsearchTB.Location = New System.Drawing.Point(88, 76)
        Me.LNsearchTB.Name = "LNsearchTB"
        Me.LNsearchTB.Size = New System.Drawing.Size(130, 21)
        Me.LNsearchTB.TabIndex = 18
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(480, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.LogOffToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
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
        Me.DeleteToolStripMenuItem.Text = "De&lete"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.LogOffToolStripMenuItem.Text = "Log Off..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintCustomerInfoToolStripMenuItem, Me.PrintReceiptToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.CustomerToolStripMenuItem.Text = "&Print"
        '
        'PrintCustomerInfoToolStripMenuItem
        '
        Me.PrintCustomerInfoToolStripMenuItem.Name = "PrintCustomerInfoToolStripMenuItem"
        Me.PrintCustomerInfoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.PrintCustomerInfoToolStripMenuItem.Text = "Print Customer& Information"
        '
        'PrintReceiptToolStripMenuItem
        '
        Me.PrintReceiptToolStripMenuItem.Name = "PrintReceiptToolStripMenuItem"
        Me.PrintReceiptToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.PrintReceiptToolStripMenuItem.Text = "Print &Receipt"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_InTableAdapter = Me.Check_InTableAdapter
        Me.TableAdapterManager.Check_OutTableAdapter = Me.Check_OutTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.GuestTableAdapter = Me.GuestTableAdapter
        Me.TableAdapterManager.PaymentTableAdapter = Me.PaymentTableAdapter
        Me.TableAdapterManager.PayrollTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Me.ReservationTableAdapter
        Me.TableAdapterManager.RoomTableAdapter = Me.RoomTableAdapter
        Me.TableAdapterManager.UpdateOrder = database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Check_InTableAdapter
        '
        Me.Check_InTableAdapter.ClearBeforeFill = True
        '
        'Check_OutTableAdapter
        '
        Me.Check_OutTableAdapter.ClearBeforeFill = True
        '
        'GuestTableAdapter
        '
        Me.GuestTableAdapter.ClearBeforeFill = True
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.nextButton)
        Me.GroupBox7.Controls.Add(Me.lastButton)
        Me.GroupBox7.Controls.Add(Me.firstButton)
        Me.GroupBox7.Controls.Add(Me.previousButton)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 454)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(225, 48)
        Me.GroupBox7.TabIndex = 55
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Record Navigation"
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(117, 20)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(58, 23)
        Me.nextButton.TabIndex = 49
        Me.nextButton.Text = "Ne&xt »"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'lastButton
        '
        Me.lastButton.Location = New System.Drawing.Point(181, 20)
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
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.saveButton)
        Me.GroupBox8.Controls.Add(Me.deleteButton)
        Me.GroupBox8.Controls.Add(Me.newButton)
        Me.GroupBox8.Location = New System.Drawing.Point(244, 394)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(224, 54)
        Me.GroupBox8.TabIndex = 56
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Modify Record"
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(146, 20)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(57, 23)
        Me.saveButton.TabIndex = 49
        Me.saveButton.Text = "S&ave"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(79, 20)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(61, 23)
        Me.deleteButton.TabIndex = 49
        Me.deleteButton.Text = "De&lete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'newButton
        '
        Me.newButton.Location = New System.Drawing.Point(17, 20)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(58, 23)
        Me.newButton.TabIndex = 49
        Me.newButton.Text = "&New"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.exitButton)
        Me.GroupBox9.Controls.Add(Me.loggOffButton)
        Me.GroupBox9.Location = New System.Drawing.Point(315, 454)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(152, 43)
        Me.GroupBox9.TabIndex = 57
        Me.GroupBox9.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(83, 13)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(65, 23)
        Me.exitButton.TabIndex = 48
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'loggOffButton
        '
        Me.loggOffButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggOffButton.Location = New System.Drawing.Point(3, 13)
        Me.loggOffButton.Name = "loggOffButton"
        Me.loggOffButton.Size = New System.Drawing.Size(70, 23)
        Me.loggOffButton.TabIndex = 48
        Me.loggOffButton.Text = "L&og Off..."
        Me.loggOffButton.UseVisualStyleBackColor = True
        '
        'ReservationBindingSource1
        '
        Me.ReservationBindingSource1.DataMember = "GuestReservation"
        Me.ReservationBindingSource1.DataSource = Me.GuestBindingSource
        '
        'ReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 508)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReservationForm"
        Me.Text = "Hotel Database Application| Reservation Information"
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Check_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Check_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hotelapp_dbDataSet As database_project.Hotelapp_dbDataSet
    Friend WithEvents ReservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents TableAdapterManager As database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReservationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChildrenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdultsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NightsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuestTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.GuestTableAdapter
    Friend WithEvents GuestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReservationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents PaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents FNsearchTB As System.Windows.Forms.TextBox
    Friend WithEvents LNsearchTB As System.Windows.Forms.TextBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Check_InTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.Check_InTableAdapter
    Friend WithEvents Check_InBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckInDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Check_OutTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.Check_OutTableAdapter
    Friend WithEvents Check_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckOutDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents lastButton As System.Windows.Forms.Button
    Friend WithEvents firstButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents newButton As System.Windows.Forms.Button
    Friend WithEvents PaymentAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents loggOffButton As System.Windows.Forms.Button
    Friend WithEvents IDsearchTB As System.Windows.Forms.TextBox
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintCustomerInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
