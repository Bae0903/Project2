Public Class FrmDetail
    Public Sub ReadDataFromDB()
        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL
        retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM courselist")
        If retrieveTable.CreateDataReader.HasRows = False Then
            MessageBox.Show("No data found.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim row As DataRow
        dgvTable.Rows.Clear()
        For Each row In retrieveTable.Rows
            dgvTable.Rows.Add(row("CourseID"), row("CourseName"), row("CourseLect"))
        Next
        retrieveTable = Nothing
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadDataFromDB()
    End Sub

    Private Sub btnExitStudent_Click(sender As Object, e As EventArgs) Handles btnExitStudent.Click
        Me.Hide()
        FrmMain.Show()
    End Sub
End Class