Public Class EmployeeInfoForm


    Private Sub EmployeesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Hotelapp_dbDataSet.Users)
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet.Employee' table. You can move, or remove it, as needed.

    End Sub


    Private Sub newButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newButton.Click

        UsersBindingSource.AddNew()
        EmployeeBindingSource.AddNew()
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click


        Me.UsersBindingSource.EndEdit()
        Me.EmployeeBindingSource.EndEdit()
        Me.EmployeeTableAdapter.Update(Me.Hotelapp_dbDataSet.Employee)
        Me.UsersTableAdapter.Update(Me.Hotelapp_dbDataSet.Users)
        MessageBox.Show("Record saved")

    End Sub
    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Dim response As String
        response = MsgBox("The current record is about to be deleted!", 20, "Warning")
        If response = vbYes Then
            Me.EmployeeBindingSource.RemoveCurrent()
            Me.UsersBindingSource.RemoveCurrent()
            Me.EmployeeBindingSource.EndEdit()
            Me.UsersBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.Hotelapp_dbDataSet.Employee)
            Me.UsersTableAdapter.Update(Me.Hotelapp_dbDataSet.Users)
            MessageBox.Show("Record Deleted")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Dim response As String
        response = MsgBox("Are you sure you want to close?", 20, "Warning")
        If response = vbYes Then
            Me.Hide()
            AdminForm.Show()
        End If
    End Sub

    Private Sub firstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstButton.Click
        EmployeeBindingSource.MoveFirst()
    End Sub


    Private Sub previousButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles previousButton.Click
        EmployeeBindingSource.MovePrevious()
    End Sub

    Private Sub nextButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nextButton.Click
        EmployeeBindingSource.MoveNext()
    End Sub

    Private Sub lastButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lastButton.Click
        EmployeeBindingSource.MoveLast()
    End Sub


    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub
End Class