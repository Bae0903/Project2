Public Class FrmDetailAdmin

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

    Private Sub btnExitAdmin_Click(sender As Object, e As EventArgs) Handles btnExitAdmin.Click
        Me.Hide()
        FrmMain.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        FrmAdd.Show()
    End Sub

    Private Sub dgvTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTable.CellClick
        Dim Result As New ArrayList
        Dim retrieveRow As New VBMySQL
        Dim strCourseID As String
        If e.RowIndex < 0 Then Exit Sub
        strCourseID = dgvTable.Item(0, e.RowIndex).Value.ToString()
        Dim strSql As String = "SELECT * FROM courselist WHERE CourseID = '" + strCourseID + "'"
        Try
            Result = retrieveRow.Retrieve_Row(strSql)

        Catch ex As Exception
            MessageBox.Show("The data reading process failed." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each row As Dictionary(Of String, Object) In Result

            With FrmEdit
                .txtCourseID.Text = row("CourseID").ToString
                .txtCourseName.Text = row("CourseName").ToString
                .txtCourseLect.Text = row("CourseLect").ToString
            End With
        Next
        Me.Hide()
        FrmEdit.Show()
    End Sub
End Class