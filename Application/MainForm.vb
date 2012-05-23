Public Class MainForm

  

    'show check in form.
    Private Sub checkInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkInButton.Click
        Me.Hide()
        ReservationForm.Show()

    End Sub

    'show check out form.
    Private Sub checkOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkOutButton.Click
        Me.Hide()
        CheckOutForm.Show()
    End Sub
    ' Return user to login form.

    Private Sub logOffButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logOffButton.Click
        Login.Show()
        Me.Hide()

    End Sub


    Private Sub ReservationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        ReservationForm.Show()
    End Sub

    Private Sub ManagerReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        CheckOutForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim response As String
        response = MsgBox("Are you sure you want to close application?", 20, "Warning")
        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        AboutBox1.Show()
    End Sub
End Class
