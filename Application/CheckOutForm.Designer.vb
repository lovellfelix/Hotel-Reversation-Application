<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutForm
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
        Dim CheckOutDateLabel1 As System.Windows.Forms.Label
        Dim CheckInDateLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim ReservationIDLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOutForm))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ReservationIDTextBox1 = New System.Windows.Forms.TextBox
        Me.Check_InBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotelapp_dbDataSet = New database_project.Hotelapp_dbDataSet
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CheckInDateTextBox = New System.Windows.Forms.TextBox
        Me.CheckOutDateTextBox = New System.Windows.Forms.TextBox
        Me.Check_OutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.GuestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Feedback_CommentRichTextBox = New System.Windows.Forms.RichTextBox
        Me.TableAdapterManager = New database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
        Me.Check_InTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.Check_InTableAdapter
        Me.Check_OutTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.Check_OutTableAdapter
        Me.GuestTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.GuestTableAdapter
        Me.ReservationTableAdapter = New database_project.Hotelapp_dbDataSetTableAdapters.ReservationTableAdapter
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.exitButton = New System.Windows.Forms.Button
        Me.loggOffButton = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.nextButton = New System.Windows.Forms.Button
        Me.lastButton = New System.Windows.Forms.Button
        Me.firstButton = New System.Windows.Forms.Button
        Me.previousButton = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.saveButton = New System.Windows.Forms.Button
        Me.deleteButton = New System.Windows.Forms.Button
        Me.newButton = New System.Windows.Forms.Button
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreviewFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintFeedBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        CheckOutDateLabel1 = New System.Windows.Forms.Label
        CheckInDateLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        ReservationIDLabel1 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.Check_InBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Check_OutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckOutDateLabel1
        '
        CheckOutDateLabel1.AutoSize = True
        CheckOutDateLabel1.Location = New System.Drawing.Point(6, 46)
        CheckOutDateLabel1.Name = "CheckOutDateLabel1"
        CheckOutDateLabel1.Size = New System.Drawing.Size(87, 13)
        CheckOutDateLabel1.TabIndex = 53
        CheckOutDateLabel1.Text = "Check Out Date:"
        '
        'CheckInDateLabel
        '
        CheckInDateLabel.AutoSize = True
        CheckInDateLabel.Location = New System.Drawing.Point(6, 20)
        CheckInDateLabel.Name = "CheckInDateLabel"
        CheckInDateLabel.Size = New System.Drawing.Size(79, 13)
        CheckInDateLabel.TabIndex = 54
        CheckInDateLabel.Text = "Check In Date:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(6, 26)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(62, 13)
        FirstNameLabel.TabIndex = 0
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(7, 57)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'ReservationIDLabel1
        '
        ReservationIDLabel1.AutoSize = True
        ReservationIDLabel1.Location = New System.Drawing.Point(6, 23)
        ReservationIDLabel1.Name = "ReservationIDLabel1"
        ReservationIDLabel1.Size = New System.Drawing.Size(83, 13)
        ReservationIDLabel1.TabIndex = 55
        ReservationIDLabel1.Text = "Reservation ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(ReservationIDLabel1)
        Me.GroupBox3.Controls.Add(Me.ReservationIDTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 51)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reservation #"
        '
        'ReservationIDTextBox1
        '
        Me.ReservationIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_InBindingSource, "ReservationID", True))
        Me.ReservationIDTextBox1.Location = New System.Drawing.Point(106, 20)
        Me.ReservationIDTextBox1.Name = "ReservationIDTextBox1"
        Me.ReservationIDTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.ReservationIDTextBox1.TabIndex = 56
        '
        'Check_InBindingSource
        '
        Me.Check_InBindingSource.DataMember = "Check In"
        Me.Check_InBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'Hotelapp_dbDataSet
        '
        Me.Hotelapp_dbDataSet.DataSetName = "Hotelapp_dbDataSet"
        Me.Hotelapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(CheckInDateLabel)
        Me.GroupBox4.Controls.Add(Me.CheckInDateTextBox)
        Me.GroupBox4.Controls.Add(CheckOutDateLabel1)
        Me.GroupBox4.Controls.Add(Me.CheckOutDateTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(243, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(204, 77)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lenght of Stay"
        '
        'CheckInDateTextBox
        '
        Me.CheckInDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_InBindingSource, "CheckInDate", True))
        Me.CheckInDateTextBox.Location = New System.Drawing.Point(104, 15)
        Me.CheckInDateTextBox.Name = "CheckInDateTextBox"
        Me.CheckInDateTextBox.Size = New System.Drawing.Size(90, 21)
        Me.CheckInDateTextBox.TabIndex = 55
        '
        'CheckOutDateTextBox
        '
        Me.CheckOutDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_OutBindingSource, "CheckOutDate", True))
        Me.CheckOutDateTextBox.Location = New System.Drawing.Point(104, 42)
        Me.CheckOutDateTextBox.Name = "CheckOutDateTextBox"
        Me.CheckOutDateTextBox.Size = New System.Drawing.Size(90, 21)
        Me.CheckOutDateTextBox.TabIndex = 54
        '
        'Check_OutBindingSource
        '
        Me.Check_OutBindingSource.DataMember = "Check Out"
        Me.Check_OutBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(243, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 94)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(74, 54)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.LastNameTextBox.TabIndex = 3
        '
        'GuestBindingSource
        '
        Me.GuestBindingSource.DataMember = "Guest"
        Me.GuestBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(74, 23)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 21)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Feedback_CommentRichTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 180)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer FeedBack"
        '
        'Feedback_CommentRichTextBox
        '
        Me.Feedback_CommentRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Check_OutBindingSource, "Feedback/Comment", True))
        Me.Feedback_CommentRichTextBox.Location = New System.Drawing.Point(6, 20)
        Me.Feedback_CommentRichTextBox.Name = "Feedback_CommentRichTextBox"
        Me.Feedback_CommentRichTextBox.Size = New System.Drawing.Size(213, 154)
        Me.Feedback_CommentRichTextBox.TabIndex = 3
        Me.Feedback_CommentRichTextBox.Text = ""
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Check_InTableAdapter = Me.Check_InTableAdapter
        Me.TableAdapterManager.Check_OutTableAdapter = Me.Check_OutTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.GuestTableAdapter = Me.GuestTableAdapter
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.PayrollTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Me.ReservationTableAdapter
        Me.TableAdapterManager.RoomTableAdapter = Nothing
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
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.exitButton)
        Me.GroupBox7.Controls.Add(Me.loggOffButton)
        Me.GroupBox7.Location = New System.Drawing.Point(260, 275)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(157, 56)
        Me.GroupBox7.TabIndex = 58
        Me.GroupBox7.TabStop = False
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
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.nextButton)
        Me.GroupBox6.Controls.Add(Me.lastButton)
        Me.GroupBox6.Controls.Add(Me.firstButton)
        Me.GroupBox6.Controls.Add(Me.previousButton)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 277)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(237, 54)
        Me.GroupBox6.TabIndex = 57
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
        Me.GroupBox5.Controls.Add(Me.saveButton)
        Me.GroupBox5.Controls.Add(Me.deleteButton)
        Me.GroupBox5.Controls.Add(Me.newButton)
        Me.GroupBox5.Location = New System.Drawing.Point(243, 215)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(204, 54)
        Me.GroupBox5.TabIndex = 56
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
        'newButton
        '
        Me.newButton.Location = New System.Drawing.Point(6, 20)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(58, 23)
        Me.newButton.TabIndex = 49
        Me.newButton.Text = "&New"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.Hotelapp_dbDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PrintToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(467, 24)
        Me.MenuStrip1.TabIndex = 59
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
        Me.DeleteToolStripMenuItem.Text = "De&lete"
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
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreviewFeedbackToolStripMenuItem, Me.PrintFeedBackToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PreviewFeedbackToolStripMenuItem
        '
        Me.PreviewFeedbackToolStripMenuItem.Name = "PreviewFeedbackToolStripMenuItem"
        Me.PreviewFeedbackToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PreviewFeedbackToolStripMenuItem.Text = "Pre&view Feed back"
        '
        'PrintFeedBackToolStripMenuItem
        '
        Me.PrintFeedBackToolStripMenuItem.Name = "PrintFeedBackToolStripMenuItem"
        Me.PrintFeedBackToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PrintFeedBackToolStripMenuItem.Text = "&Print Feed Back"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(186, 22)
        Me.ToolStripMenuItem2.Text = "Print Che&ck Out Date"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'CheckOutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 351)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CheckOutForm"
        Me.Text = "Hotel| Customer Check Out Information"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Check_InBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotelapp_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Check_OutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Hotelapp_dbDataSet As database_project.Hotelapp_dbDataSet
    Friend WithEvents Check_OutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As database_project.Hotelapp_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckOutDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuestTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.GuestTableAdapter
    Friend WithEvents Check_OutTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.Check_OutTableAdapter
    Friend WithEvents Check_InTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.Check_InTableAdapter
    Friend WithEvents ReservationIDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Check_InBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckInDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Feedback_CommentRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents loggOffButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents lastButton As System.Windows.Forms.Button
    Friend WithEvents firstButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents newButton As System.Windows.Forms.Button
    Friend WithEvents ReservationTableAdapter As database_project.Hotelapp_dbDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents ReservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewFeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintFeedBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
