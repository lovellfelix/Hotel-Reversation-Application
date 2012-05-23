Imports System.Data.OleDb

Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        Dim con As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;data source=\database project\Hotelapp_db.mdb")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT Role FROM Users WHERE UserName = '" & txtu.Text & "' AND Password = '" & txtp.Text & "'", con)
        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        Dim role As String

        Try

            'Password verification and go to main form.
            If (sdr.Read() = False) Then
                MessageBox.Show("Invalid username or password!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtp.Text = ""
            Else
                role = sdr.GetString(0)
                ' User Role verification.

                If role = "manager" Then
                    Dim managerForm As New managerForm
                    managerForm.Show()
                    'hide login form and clear login info incase of loggoff
                    With Me
                        .Hide()
                        .txtp.Text = ""
                        .txtu.Text = ""
                    End With

                ElseIf role = "receptionist" Then
                    Dim mainform As New MainForm
                    mainform.Show()
                    'hide login form and clear login info incase of loggoff
                    With Me
                        .Hide()
                        .txtp.Text = ""
                        .txtu.Text = ""
                    End With

                ElseIf role = "admin" Then
                    Dim adminform As New AdminForm
                    adminform.Show()
                    'hide login form and clear login info incase of loggoff
                    With Me
                        .Hide()
                        .txtp.Text = ""
                        .txtu.Text = ""
                    End With
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Authentication Failed...")
        End Try
        If con.State <> ConnectionState.Closed Then
            con.Close()
        End If

        con.Close()

    End Sub

    ' Cancel button

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
