Public Class managerForm


    Private Sub loggOffButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loggOffButton.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'return to main menu
        Dim response As String
        response = MsgBox("Are you sure you want to close Application?", 20, "Hotel Database App| Warning")
        If response = vbYes Then
            Me.Close()
            
            Me.Hide()
        End If
    End Sub

    Private Sub managerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RoomType.Reserved_Room_Type_by_Date' table. You can move, or remove it, as needed.
        Me.Reserved_Room_Type_by_DateTableAdapter.Fill(Me.RoomType.Reserved_Room_Type_by_Date)
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet.Next_Day_Arrival' table. You can move, or remove it, as needed.
        Me.Next_Day_ArrivalTableAdapter.Fill(Me.Hotelapp_dbDataSet.Next_Day_Arrival)
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet1.Payroll_Query' table. You can move, or remove it, as needed.
        Me.Payroll_QueryTableAdapter.Fill(Me.Hotelapp_dbDataSet1.Payroll_Query)
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet.Payment_Queries' table. You can move, or remove it, as needed.
        Me.Payment_QueriesTableAdapter.Fill(Me.Hotelapp_dbDataSet.Payment_Queries)

    End Sub

    Private Sub paymentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paymentButton.Click
        Payment_QueriesDataGridView.Show()
        Payroll_QueryDataGridView.Hide()
        Next_Day_ArrivalDataGridView.Hide()
    End Sub

    Private Sub payrollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles payrollButton.Click
        Payroll_QueryDataGridView.Show()
        Payment_QueriesDataGridView.Hide()
        Next_Day_ArrivalDataGridView.Hide()
        Reserved_Room_Type_by_DateDataGridView.Hide()
    End Sub

    Private Sub nextDayArrivalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextDayArrivalButton.Click
        Next_Day_ArrivalDataGridView.Show()
        Payroll_QueryDataGridView.Hide()
        Payment_QueriesDataGridView.Hide()
        Reserved_Room_Type_by_DateDataGridView.Hide()
    End Sub

    Private Sub TypeOfRoomButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeOfRoomButton.Click
        Reserved_Room_Type_by_DateDataGridView.Show()
        Next_Day_ArrivalDataGridView.Hide()
        Payroll_QueryDataGridView.Hide()
        Payment_QueriesDataGridView.Hide()
    End Sub
End Class