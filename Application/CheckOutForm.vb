Public Class CheckOutForm





    Private Sub Check_OutBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Check_OutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet)

    End Sub

    Private Sub CheckOutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet.Check_Out' table. You can move, or remove it, as needed.
        Me.Check_OutTableAdapter.Fill(Me.Hotelapp_dbDataSet.Check_Out)
        Me.Check_InTableAdapter.Fill(Me.Hotelapp_dbDataSet.Check_In)
        Me.GuestTableAdapter.Fill(Me.Hotelapp_dbDataSet.Guest)
        Me.ReservationTableAdapter.Fill(Me.Hotelapp_dbDataSet.Reservation)
    End Sub

    Private Sub newButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'add new data to database.
        ReservationBindingSource.AddNew()
        GuestBindingSource.AddNew()
        Check_InBindingSource.AddNew()
        Check_OutBindingSource.AddNew()
    End Sub
    Private Sub ReservationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet.Room' table. You can move, or remove it, as needed.


        Me.Check_OutTableAdapter.Fill(Me.Hotelapp_dbDataSet.Check_Out)
        Me.Check_InTableAdapter.Fill(Me.Hotelapp_dbDataSet.Check_In)
        Me.GuestTableAdapter.Fill(Me.Hotelapp_dbDataSet.Guest)
        Me.ReservationTableAdapter.Fill(Me.Hotelapp_dbDataSet.Reservation)

    End Sub
   

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        'save record to database.
        Validate()
        ReservationBindingSource.EndEdit()
        Check_OutBindingSource.EndEdit()
        Check_InBindingSource.EndEdit()
        GuestBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet)
        MessageBox.Show("Record saved")

    End Sub
    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        'Delete record from database.

        Dim response As String
        response = MsgBox("The current record is about to be deleted!", 20, "Hotel Database App| Warning")
        If response = vbYes Then
            ReservationBindingSource.RemoveCurrent()
            GuestBindingSource.RemoveCurrent()
            Check_InBindingSource.RemoveCurrent()
            Check_OutBindingSource.RemoveCurrent()
            GuestBindingSource.EndEdit()
            Check_InBindingSource.EndEdit()
            Check_OutBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet)
            MessageBox.Show("Record Deleted")
        End If
    End Sub

    Private Sub firstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstButton.Click
        'move to first record in database.

        ReservationBindingSource.MoveFirst()
        GuestBindingSource.MoveFirst()
        Check_InBindingSource.MoveFirst()
        Check_OutBindingSource.MoveFirst()

    End Sub


    Private Sub previousButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles previousButton.Click
        'move to previous record in database.

        ReservationBindingSource.MovePrevious()
        GuestBindingSource.MovePrevious()
        Check_InBindingSource.MovePrevious()
        Check_OutBindingSource.MovePrevious()
    End Sub

    Private Sub nextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nextButton.Click
        'move to next record in database.

        ReservationBindingSource.MoveNext()
        GuestBindingSource.MoveNext()
        Check_InBindingSource.MoveNext()
        Check_OutBindingSource.MoveNext()
    End Sub

    Private Sub lastButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lastButton.Click
        'move to last record in database.

        ReservationBindingSource.MoveLast()
        GuestBindingSource.MoveLast()
        Check_InBindingSource.MoveLast()
        Check_OutBindingSource.MoveLast()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'return to main menu
        Dim response As String
        response = MsgBox("Are you sure you want to close?", 20, "Hotel Database App| Warning")
        If response = vbYes Then
            Me.Hide()
            MainForm.Show()
            MainForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'add new data to database.
        ReservationBindingSource.AddNew()
        GuestBindingSource.AddNew()
        Check_InBindingSource.AddNew()
        Check_OutBindingSource.AddNew()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Validate()
        ReservationBindingSource.EndEdit()
        Check_OutBindingSource.EndEdit()
        Check_InBindingSource.EndEdit()
        GuestBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet)
        MessageBox.Show("Record saved")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        'Delete record from database.

        Dim response As String
        response = MsgBox("The current record is about to be deleted!", 20, "Hotel Database App| Warning")
        If response = vbYes Then
            ReservationBindingSource.RemoveCurrent()
            GuestBindingSource.RemoveCurrent()
            Check_InBindingSource.RemoveCurrent()
            Check_OutBindingSource.RemoveCurrent()
            GuestBindingSource.EndEdit()
            Check_InBindingSource.EndEdit()
            Check_OutBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet)
            MessageBox.Show("Record Deleted")
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'return to main menu
        Dim response As String
        response = MsgBox("Are you sure you want to close?", 20, "Hotel Database App| Warning")
        If response = vbYes Then
            Me.Hide()
            MainForm.Show()
            MainForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PreviewFeedbackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewFeedbackToolStripMenuItem.Click
        'Print Preview Feed Back.
    End Sub

    Private Sub PrintFeedBackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintFeedBackToolStripMenuItem.Click
        'Print Feed Back.
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'Print Check out data.        
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        'show about application.
        AboutBox1.Show()
    End Sub
End Class