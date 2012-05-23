Public Class AdminForm

    Private Sub EmployeeInfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeInfoButton.Click
       
        'EmployeesForm.Show()
        'EmployeeInfoForm.Show()
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub PayRollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayRollButton.Click

        Payroll.Show()
        Me.Hide()
    End Sub

    Private Sub logOffButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logOffButton.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Dim response As String
        response = MsgBox("Are you sure you want to close? the application", 20, "Warning")
        If response = vbYes Then
            Me.Close()
        End If
    End Sub
End Class