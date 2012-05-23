<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(managerForm))
        Me.exitButton = New System.Windows.Forms.Button
        Me.loggOffButton = New System.Windows.Forms.Button
        Me.payrollButton = New System.Windows.Forms.Button
        Me.nextDayArrivalButton = New System.Windows.Forms.Button
        Me.TypeOfRoomButton = New System.Windows.Forms.Button
        Me.paymentButton = New System.Windows.Forms.Button
        Me.Payment_QueriesDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Payment_QueriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotelapp_dbDataSet = New database_project.Hotelapp_dbDataSet
        Me.Payment_QueriesTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.Payment_QueriesTableAdapter
        Me.TableAdapterManager = New database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
        Me.Hotelapp_dbDataSet1 = New database_project.Hotelapp_dbDataSet1
        Me.Payroll_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payroll_QueryTableAdapter = New database_project.Hotelapp_dbDataSet1TableAdapters.Payroll_QueryTableAdapter
        Me.TableAdapterManager1 = New database_project.Hotelapp_dbDataSet1TableAdapters.TableAdapterManager
        Me.Payroll_QueryDataGridView = New System.Windows.Forms.DataGridView
        Me.ReservationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NightsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheckInDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheckOutDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RoomTypeDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Next_Day_ArrivalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Next_Day_ArrivalTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.Next_Day_ArrivalTableAdapter
        Me.Payroll_QueryDataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Next_Day_ArrivalDataGridView = New System.Windows.Forms.DataGridView
        Me.RoomType = New database_project.RoomType
        Me.Reserved_Room_Type_by_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reserved_Room_Type_by_DateTableAdapter = New database_project.RoomTypeTableAdapters.Reserved_Room_Type_by_DateTableAdapter
        Me.TableAdapterManager2 = New database_project.RoomTypeTableAdapters.TableAdapterManager
        Me.RoomTypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheckInDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Reserved_Room_Type_by_DateDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        CType(Me.Payment_QueriesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payment_QueriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotelapp_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payroll_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payroll_QueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Next_Day_ArrivalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payroll_QueryDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Next_Day_ArrivalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reserved_Room_Type_by_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reserved_Room_Type_by_DateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(210, 402)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'loggOffButton
        '
        Me.loggOffButton.Location = New System.Drawing.Point(129, 402)
        Me.loggOffButton.Name = "loggOffButton"
        Me.loggOffButton.Size = New System.Drawing.Size(75, 23)
        Me.loggOffButton.TabIndex = 0
        Me.loggOffButton.Text = "&Log Off.."
        Me.loggOffButton.UseVisualStyleBackColor = True
        '
        'payrollButton
        '
        Me.payrollButton.Location = New System.Drawing.Point(2, 98)
        Me.payrollButton.Name = "payrollButton"
        Me.payrollButton.Size = New System.Drawing.Size(111, 23)
        Me.payrollButton.TabIndex = 1
        Me.payrollButton.Text = "Pay &Roll"
        Me.payrollButton.UseVisualStyleBackColor = True
        '
        'nextDayArrivalButton
        '
        Me.nextDayArrivalButton.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.nextDayArrivalButton.Location = New System.Drawing.Point(2, 127)
        Me.nextDayArrivalButton.Name = "nextDayArrivalButton"
        Me.nextDayArrivalButton.Size = New System.Drawing.Size(111, 23)
        Me.nextDayArrivalButton.TabIndex = 1
        Me.nextDayArrivalButton.Text = "&Next Day Arrival"
        Me.nextDayArrivalButton.UseVisualStyleBackColor = True
        '
        'TypeOfRoomButton
        '
        Me.TypeOfRoomButton.Location = New System.Drawing.Point(2, 156)
        Me.TypeOfRoomButton.Name = "TypeOfRoomButton"
        Me.TypeOfRoomButton.Size = New System.Drawing.Size(111, 23)
        Me.TypeOfRoomButton.TabIndex = 1
        Me.TypeOfRoomButton.Text = "Room &Type By Date"
        Me.TypeOfRoomButton.UseVisualStyleBackColor = True
        '
        'paymentButton
        '
        Me.paymentButton.Location = New System.Drawing.Point(2, 69)
        Me.paymentButton.Name = "paymentButton"
        Me.paymentButton.Size = New System.Drawing.Size(111, 23)
        Me.paymentButton.TabIndex = 1
        Me.paymentButton.Text = "&Payments"
        Me.paymentButton.UseVisualStyleBackColor = True
        '
        'Payment_QueriesDataGridView
        '
        Me.Payment_QueriesDataGridView.AutoGenerateColumns = False
        Me.Payment_QueriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Payment_QueriesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Payment_QueriesDataGridView.DataSource = Me.Payment_QueriesBindingSource
        Me.Payment_QueriesDataGridView.Location = New System.Drawing.Point(156, 55)
        Me.Payment_QueriesDataGridView.Name = "Payment_QueriesDataGridView"
        Me.Payment_QueriesDataGridView.RowTemplate.Height = 23
        Me.Payment_QueriesDataGridView.Size = New System.Drawing.Size(472, 341)
        Me.Payment_QueriesDataGridView.TabIndex = 7
        Me.Payment_QueriesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CheckInDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CheckInDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nights"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nights"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RoomType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RoomType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PaymentType"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PaymentType"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PaymentAmount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PaymentAmount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Payment_QueriesBindingSource
        '
        Me.Payment_QueriesBindingSource.DataMember = "Payment Queries"
        Me.Payment_QueriesBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'Hotelapp_dbDataSet
        '
        Me.Hotelapp_dbDataSet.DataSetName = "Hotelapp_dbDataSet"
        Me.Hotelapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Payment_QueriesTableAdapter
        '
        Me.Payment_QueriesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_InTableAdapter = Nothing
        Me.TableAdapterManager.Check_OutTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.GuestTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PayrollTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
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
        'Payroll_QueryDataGridView
        '
        Me.Payroll_QueryDataGridView.AutoGenerateColumns = False
        Me.Payroll_QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Payroll_QueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.NightsDataGridViewTextBoxColumn, Me.CheckInDateDataGridViewTextBoxColumn, Me.CheckOutDateDataGridViewTextBoxColumn, Me.RoomTypeDataGridView})
        Me.Payroll_QueryDataGridView.DataSource = Me.Next_Day_ArrivalBindingSource
        Me.Payroll_QueryDataGridView.Location = New System.Drawing.Point(154, 55)
        Me.Payroll_QueryDataGridView.Name = "Payroll_QueryDataGridView"
        Me.Payroll_QueryDataGridView.RowTemplate.Height = 23
        Me.Payroll_QueryDataGridView.Size = New System.Drawing.Size(474, 341)
        Me.Payroll_QueryDataGridView.TabIndex = 7
        Me.Payroll_QueryDataGridView.Visible = False
        '
        'ReservationIDDataGridViewTextBoxColumn
        '
        Me.ReservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID"
        Me.ReservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID"
        Me.ReservationIDDataGridViewTextBoxColumn.Name = "ReservationIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'NightsDataGridViewTextBoxColumn
        '
        Me.NightsDataGridViewTextBoxColumn.DataPropertyName = "Nights"
        Me.NightsDataGridViewTextBoxColumn.HeaderText = "Nights"
        Me.NightsDataGridViewTextBoxColumn.Name = "NightsDataGridViewTextBoxColumn"
        '
        'CheckInDateDataGridViewTextBoxColumn
        '
        Me.CheckInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate"
        Me.CheckInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate"
        Me.CheckInDateDataGridViewTextBoxColumn.Name = "CheckInDateDataGridViewTextBoxColumn"
        '
        'CheckOutDateDataGridViewTextBoxColumn
        '
        Me.CheckOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate"
        Me.CheckOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate"
        Me.CheckOutDateDataGridViewTextBoxColumn.Name = "CheckOutDateDataGridViewTextBoxColumn"
        '
        'RoomTypeDataGridView
        '
        Me.RoomTypeDataGridView.DataPropertyName = "RoomType"
        Me.RoomTypeDataGridView.HeaderText = "RoomType"
        Me.RoomTypeDataGridView.Name = "RoomTypeDataGridView"
        Me.RoomTypeDataGridView.Visible = False
        '
        'Next_Day_ArrivalBindingSource
        '
        Me.Next_Day_ArrivalBindingSource.DataMember = "Next Day Arrival"
        Me.Next_Day_ArrivalBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'Next_Day_ArrivalTableAdapter
        '
        Me.Next_Day_ArrivalTableAdapter.ClearBeforeFill = True
        '
        'Payroll_QueryDataGridView1
        '
        Me.Payroll_QueryDataGridView1.AutoGenerateColumns = False
        Me.Payroll_QueryDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Payroll_QueryDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Payroll_QueryDataGridView1.DataSource = Me.Payroll_QueryBindingSource
        Me.Payroll_QueryDataGridView1.Location = New System.Drawing.Point(154, 55)
        Me.Payroll_QueryDataGridView1.Name = "Payroll_QueryDataGridView1"
        Me.Payroll_QueryDataGridView1.RowTemplate.Height = 23
        Me.Payroll_QueryDataGridView1.Size = New System.Drawing.Size(474, 341)
        Me.Payroll_QueryDataGridView1.TabIndex = 8
        Me.Payroll_QueryDataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "EmployeeID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "HoursWork"
        Me.DataGridViewTextBoxColumn9.HeaderText = "HoursWork"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Overtime"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Overtime"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PayRate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PayRate"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "OvertimeRate"
        Me.DataGridViewTextBoxColumn12.HeaderText = "OvertimeRate"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Deduction"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Deduction"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NetPay"
        Me.DataGridViewTextBoxColumn14.HeaderText = "NetPay"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Next_Day_ArrivalDataGridView
        '
        Me.Next_Day_ArrivalDataGridView.AutoGenerateColumns = False
        Me.Next_Day_ArrivalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Next_Day_ArrivalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckInDateDataGridViewTextBoxColumn1, Me.RoomTypeDataGridViewTextBoxColumn1})
        Me.Next_Day_ArrivalDataGridView.DataSource = Me.Reserved_Room_Type_by_DateBindingSource
        Me.Next_Day_ArrivalDataGridView.Location = New System.Drawing.Point(155, 54)
        Me.Next_Day_ArrivalDataGridView.Name = "Next_Day_ArrivalDataGridView"
        Me.Next_Day_ArrivalDataGridView.RowTemplate.Height = 23
        Me.Next_Day_ArrivalDataGridView.Size = New System.Drawing.Size(473, 342)
        Me.Next_Day_ArrivalDataGridView.TabIndex = 9
        Me.Next_Day_ArrivalDataGridView.Visible = False
        '
        'RoomType
        '
        Me.RoomType.DataSetName = "RoomType"
        Me.RoomType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reserved_Room_Type_by_DateBindingSource
        '
        Me.Reserved_Room_Type_by_DateBindingSource.DataMember = "Reserved Room Type by Date"
        Me.Reserved_Room_Type_by_DateBindingSource.DataSource = Me.RoomType
        '
        'Reserved_Room_Type_by_DateTableAdapter
        '
        Me.Reserved_Room_Type_by_DateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = database_project.RoomTypeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RoomTypeDataGridViewTextBoxColumn1
        '
        Me.RoomTypeDataGridViewTextBoxColumn1.DataPropertyName = "RoomType"
        Me.RoomTypeDataGridViewTextBoxColumn1.HeaderText = "RoomType"
        Me.RoomTypeDataGridViewTextBoxColumn1.Name = "RoomTypeDataGridViewTextBoxColumn1"
        Me.RoomTypeDataGridViewTextBoxColumn1.Visible = False
        '
        'CheckInDateDataGridViewTextBoxColumn1
        '
        Me.CheckInDateDataGridViewTextBoxColumn1.DataPropertyName = "CheckInDate"
        Me.CheckInDateDataGridViewTextBoxColumn1.HeaderText = "CheckInDate"
        Me.CheckInDateDataGridViewTextBoxColumn1.Name = "CheckInDateDataGridViewTextBoxColumn1"
        '
        'Reserved_Room_Type_by_DateDataGridView
        '
        Me.Reserved_Room_Type_by_DateDataGridView.AutoGenerateColumns = False
        Me.Reserved_Room_Type_by_DateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Reserved_Room_Type_by_DateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Reserved_Room_Type_by_DateDataGridView.DataSource = Me.Reserved_Room_Type_by_DateBindingSource
        Me.Reserved_Room_Type_by_DateDataGridView.Location = New System.Drawing.Point(156, 54)
        Me.Reserved_Room_Type_by_DateDataGridView.Name = "Reserved_Room_Type_by_DateDataGridView"
        Me.Reserved_Room_Type_by_DateDataGridView.RowTemplate.Height = 23
        Me.Reserved_Room_Type_by_DateDataGridView.Size = New System.Drawing.Size(472, 342)
        Me.Reserved_Room_Type_by_DateDataGridView.TabIndex = 10
        Me.Reserved_Room_Type_by_DateDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CheckInDate"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CheckInDate"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "RoomType"
        Me.DataGridViewTextBoxColumn16.HeaderText = "RoomType"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 24)
        Me.MenuStrip1.TabIndex = 40
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
        'managerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 495)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Reserved_Room_Type_by_DateDataGridView)
        Me.Controls.Add(Me.Next_Day_ArrivalDataGridView)
        Me.Controls.Add(Me.Payroll_QueryDataGridView1)
        Me.Controls.Add(Me.Payroll_QueryDataGridView)
        Me.Controls.Add(Me.Payment_QueriesDataGridView)
        Me.Controls.Add(Me.TypeOfRoomButton)
        Me.Controls.Add(Me.paymentButton)
        Me.Controls.Add(Me.nextDayArrivalButton)
        Me.Controls.Add(Me.payrollButton)
        Me.Controls.Add(Me.loggOffButton)
        Me.Controls.Add(Me.exitButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "managerForm"
        Me.Text = "Hotel Database Application| Manager Menue"
        CType(Me.Payment_QueriesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payment_QueriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotelapp_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payroll_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payroll_QueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Next_Day_ArrivalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payroll_QueryDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Next_Day_ArrivalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reserved_Room_Type_by_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reserved_Room_Type_by_DateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents loggOffButton As System.Windows.Forms.Button
    Friend WithEvents payrollButton As System.Windows.Forms.Button
    Friend WithEvents nextDayArrivalButton As System.Windows.Forms.Button
    Friend WithEvents TypeOfRoomButton As System.Windows.Forms.Button
    Friend WithEvents paymentButton As System.Windows.Forms.Button
    Friend WithEvents Hotelapp_dbDataSet As database_project.Hotelapp_dbDataSet
    Friend WithEvents Payment_QueriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Payment_QueriesTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.Payment_QueriesTableAdapter
    Friend WithEvents TableAdapterManager As database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Payment_QueriesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hotelapp_dbDataSet1 As database_project.Hotelapp_dbDataSet1
    Friend WithEvents Payroll_QueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Payroll_QueryTableAdapter As database_project.Hotelapp_dbDataSet1TableAdapters.Payroll_QueryTableAdapter
    Friend WithEvents TableAdapterManager1 As database_project.Hotelapp_dbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Payroll_QueryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Next_Day_ArrivalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Next_Day_ArrivalTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.Next_Day_ArrivalTableAdapter
    Friend WithEvents ReservationIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NightsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckInDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckOutDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payroll_QueryDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Next_Day_ArrivalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RoomType As database_project.RoomType
    Friend WithEvents Reserved_Room_Type_by_DateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reserved_Room_Type_by_DateTableAdapter As database_project.RoomTypeTableAdapters.Reserved_Room_Type_by_DateTableAdapter
    Friend WithEvents TableAdapterManager2 As database_project.RoomTypeTableAdapters.TableAdapterManager
    Friend WithEvents CheckInDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserved_Room_Type_by_DateDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintCustomerInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
