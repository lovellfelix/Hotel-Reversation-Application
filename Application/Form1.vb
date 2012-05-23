Public Class Form1

    Private Sub EmployeeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet1.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Hotelapp_dbDataSet1.Employee)
        'TODO: This line of code loads data into the 'Employeedataset.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter2.Fill(Me.Employeedataset.Employee)
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet1.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter1.Fill(Me.Hotelapp_dbDataSet1.Employee)
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet1.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter1.Fill(Me.Hotelapp_dbDataSet1.Employee)
        'TODO: This line of code loads data into the 'Hotelapp_dbDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Hotelapp_dbDataSet.Employee)

    End Sub

    Private Sub EmployeeBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hotelapp_dbDataSet1)

    End Sub
End Class