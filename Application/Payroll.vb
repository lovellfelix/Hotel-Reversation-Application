Public Class Payroll



    Private Sub Payroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet1.Payroll_Query' table. You can move, or remove it, as needed.
        Me.Payroll_QueryTableAdapter.Fill(Me.Hotelapp_dbDataSet1.Payroll_Query)

       
        End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'exit application.
        Me.Hide()
        AdminForm.Show()

    End Sub

    Private Sub newButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newButton.Click
        PayrollBindingSource.AddNew()
        EmployeeBindingSource.AddNew()
    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Dim response As String
        response = MsgBox("The current record is about to be deleted!", 20, "Warning")
        If response = vbYes Then
            Me.EmployeeBindingSource.RemoveCurrent()
            Me.PayrollBindingSource.RemoveCurrent()
            Me.EmployeeBindingSource.EndEdit()
            Me.PayrollBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.Hotelapp_dbDataSet.Employee)
            Me.PayrollTableAdapter.Update(Me.Hotelapp_dbDataSet.Payroll)
            MessageBox.Show("Record Deleted")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PayrollBindingSource.EndEdit()
        Me.EmployeeBindingSource.EndEdit()
        Me.EmployeeTableAdapter.Update(Me.Hotelapp_dbDataSet.Employee)
        Me.PayrollTableAdapter.Update(Me.Hotelapp_dbDataSet.Payroll)
        MessageBox.Show("Record saved")
    End Sub

    Private Sub firstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstButton.Click
        'move to the first record.
        EmployeeBindingSource.MoveFirst()
        PayrollBindingSource.MoveFirst()
        Payroll_QueryBindingSource.MoveFirst()

    End Sub

    Private Sub nextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nextButton.Click
        'move to the next record.
        EmployeeBindingSource.MoveNext()
        PayrollBindingSource.MoveNext()
        Payroll_QueryBindingSource.MoveNext()
    End Sub

    Private Sub previousButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles previousButton.Click
        'move to the previous record.
        EmployeeBindingSource.MovePrevious()
        PayrollBindingSource.MovePrevious()
        Payroll_QueryBindingSource.MovePrevious()

    End Sub

    Private Sub lastButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lastButton.Click
        'move to the last record.
        EmployeeBindingSource.MoveLast()
        EmployeeBindingSource.MoveLast()
        Payroll_QueryBindingSource.MoveLast()


    End Sub

    Private Sub loggOffButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loggOffButton.Click
        'return to login screen.
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim response As String
        response = MsgBox("Are you sure you want to close?", 20, "Warning")
        If response = vbYes Then
            Me.Hide()
            AdminForm.Show()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        PayrollBindingSource.AddNew()
        EmployeeBindingSource.AddNew()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.PayrollBindingSource.EndEdit()
        Me.EmployeeBindingSource.EndEdit()
        Me.EmployeeTableAdapter.Update(Me.Hotelapp_dbDataSet.Employee)
        Me.PayrollTableAdapter.Update(Me.Hotelapp_dbDataSet.Payroll)
        MessageBox.Show("Record saved")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim response As String
        response = MsgBox("The current record is about to be deleted!", 20, "Warning")
        If response = vbYes Then
            Me.EmployeeBindingSource.RemoveCurrent()
            Me.PayrollBindingSource.RemoveCurrent()
            Me.EmployeeBindingSource.EndEdit()
            Me.PayrollBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.Hotelapp_dbDataSet.Employee)
            Me.PayrollTableAdapter.Update(Me.Hotelapp_dbDataSet.Payroll)
            MessageBox.Show("Record Deleted")
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        'return to login screen.
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim response As String
        response = MsgBox("Are you sure you want to close? the application", 20, "Warning")
        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub PrintPreviewPayStubToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewPayStubToolStripMenuItem.Click
        'Print Preview pay stub.
    End Sub

    Private Sub PrintPayStubToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPayStubToolStripMenuItem.Click
        'print pay stub.
    End Sub
End Class