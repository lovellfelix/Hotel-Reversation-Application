Imports System.Data.OleDb
Public Class ReservationForm


    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click




    End Sub



    Private Sub ReservationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet.Room' table. You can move, or remove it, as needed.

        Me.RoomTableAdapter.Fill(Me.Hotelapp_dbDataSet.Room)
        Me.Check_OutTableAdapter.Fill(Me.Hotelapp_dbDataSet.Check_Out)
        Me.Check_InTableAdapter.Fill(Me.Hotelapp_dbDataSet.Check_In)
        Me.GuestTableAdapter.Fill(Me.Hotelapp_dbDataSet.Guest)
        Me.PaymentTableAdapter.Fill(Me.Hotelapp_dbDataSet.Payment)
        Me.ReservationTableAdapter.Fill(Me.Hotelapp_dbDataSet.Reservation)

    End Sub
    Private Sub newButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newButton.Click
        'add new record to database.
        ReservationBindingSource.AddNew()
        RoomBindingSource.AddNew()
        Check_OutBindingSource.AddNew()
        Check_InBindingSource.AddNew()
        GuestBindingSource.AddNew()
        PaymentBindingSource.AddNew()
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        'save record to database.
        Validate()
        ReservationBindingSource.EndEdit()
        RoomBindingSource.EndEdit()
        Check_OutBindingSource.EndEdit()
        Check_InBindingSource.EndEdit()
        GuestBindingSource.EndEdit()
        PaymentBindingSource.EndEdit()
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
            RoomBindingSource.RemoveCurrent()
            PaymentBindingSource.RemoveCurrent()
            Check_InBindingSource.RemoveCurrent()
            Check_OutBindingSource.RemoveCurrent()
            GuestBindingSource.EndEdit()
            RoomBindingSource.EndEdit()
            PaymentBindingSource.EndEdit()
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
        RoomBindingSource.MoveFirst()
        PaymentBindingSource.MoveFirst()
        Check_InBindingSource.MoveFirst()
        Check_OutBindingSource.MoveFirst()

    End Sub


    Private Sub previousButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles previousButton.Click
        'move to previous record in database.

        ReservationBindingSource.MovePrevious()
        GuestBindingSource.MovePrevious()
        RoomBindingSource.MovePrevious()
        PaymentBindingSource.MovePrevious()
        Check_InBindingSource.MovePrevious()
        Check_OutBindingSource.MovePrevious()
    End Sub

    Private Sub nextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nextButton.Click
        'move to next record in database.

        ReservationBindingSource.MoveNext()
        GuestBindingSource.MoveNext()
        RoomBindingSource.MoveNext()
        PaymentBindingSource.MoveNext()
        Check_InBindingSource.MoveNext()
        Check_OutBindingSource.MoveNext()
    End Sub

    Private Sub lastButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lastButton.Click
        'move to last record in database.

        ReservationBindingSource.MoveLast()
        GuestBindingSource.MoveLast()
        RoomBindingSource.MoveLast()
        PaymentBindingSource.MoveLast()
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
            Me.Hide()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loggOffButton.Click
        Login.Show()
        Me.Hide()
    End Sub

  
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'add new record to database.
        ReservationBindingSource.AddNew()
        RoomBindingSource.AddNew()
        Check_OutBindingSource.AddNew()
        Check_InBindingSource.AddNew()
        GuestBindingSource.AddNew()
        PaymentBindingSource.AddNew()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Validate()
        ReservationBindingSource.EndEdit()
        RoomBindingSource.EndEdit()
        Check_OutBindingSource.EndEdit()
        Check_InBindingSource.EndEdit()
        GuestBindingSource.EndEdit()
        PaymentBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet)
        MessageBox.Show("Record saved")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        'Delete record from database.

        Dim response As String
        response = MsgBox("The current record is about to be deleted!", 20, "Hotel Database App| Warning")
        If response = vbYes Then
            ReservationBindingSource.RemoveCurrent()
            GuestBindingSource.RemoveCurrent()
            RoomBindingSource.RemoveCurrent()
            PaymentBindingSource.RemoveCurrent()
            Check_InBindingSource.RemoveCurrent()
            Check_OutBindingSource.RemoveCurrent()
            GuestBindingSource.EndEdit()
            RoomBindingSource.EndEdit()
            PaymentBindingSource.EndEdit()
            Check_InBindingSource.EndEdit()
            Check_OutBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet)
            MessageBox.Show("Record Deleted")
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
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

    Private Sub PrintCustomerInfoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintCustomerInfoToolStripMenuItem.Click
        'print Customer Information.
    End Sub

    Private Sub PrintReceiptToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintReceiptToolStripMenuItem.Click
        'Print Customer Receipt.
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'show about information.
        AboutBox1.Show()
    End Sub
End Class