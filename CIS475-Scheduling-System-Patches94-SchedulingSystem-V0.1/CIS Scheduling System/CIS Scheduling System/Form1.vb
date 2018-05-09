Public Class Form1
    Private Sub Classes_Needed_for_SemesterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Classes_Needed_for_SemesterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Classes_Needed_for_SemesterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CIS_Scheduling_SystemDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CIS_Scheduling_SystemDataSet.Days_and_hours' table. You can move, or remove it, as needed.
        Me.Days_and_hoursTableAdapter.Fill(Me.CIS_Scheduling_SystemDataSet.Days_and_hours)
        'TODO: This line of code loads data into the 'CIS_Scheduling_SystemDataSet.Classes_Taught' table. You can move, or remove it, as needed.
        Me.Classes_TaughtTableAdapter.Fill(Me.CIS_Scheduling_SystemDataSet.Classes_Taught)
        'TODO: This line of code loads data into the 'CIS_Scheduling_SystemDataSet.Classes_Needed_for_Semester' table. You can move, or remove it, as needed.
        Me.Classes_Needed_for_SemesterTableAdapter.Fill(Me.CIS_Scheduling_SystemDataSet.Classes_Needed_for_Semester)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClassesTaught_Click(sender As Object, e As EventArgs) Handles btnClassesTaught.Click
        Dim x = From y In CIS_Scheduling_SystemDataSet.Classes_Taught
                Where y.CIS_Classes_Previously_Taught Like ("*" + txtBoxClassesTaught.Text + "*")
                Select y

        Classes_TaughtBindingSource.DataSource = x.AsDataView
    End Sub



End Class
