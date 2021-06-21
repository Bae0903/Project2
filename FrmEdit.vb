Public Class FrmEdit

    ' Private Sub dgvTable_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    'Dim Result As New ArrayList
    'Dim retrieveRow As New VBMySQL
    'Dim strName As String
    'If e.RowIndex < 0 Then Exit Sub
    'strName = dgvTable.Item(0, e.RowIndex).Value.ToString()
    'Dim strSql As String = "SELECT * FROM courselist WHERE CourseName = '" + strName + "'"
    'Try
    '     Result = retrieveRow.Retrieve_Row(strSql)

    '  Catch ex As Exception
    '       MessageBox.Show("The data reading process failed." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'For Each row As Dictionary(Of String, Object) In Result
    '    With FrmAdd
    '         .txtCourseName.Text = row("CourseName").ToString
    '          .txtCourseLect.Text = row("CourseLect").ToString
    '           .txtCourseID.Text = (row("CourseID").ToString)
    '        End With


    'Next
    'Me.Hide()
    ' FrmDetail.Show()
    ' End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show(" Are you sure you want to Cancel?", "Books", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            FrmDetailAdmin.Show()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strCourseID As String = txtCourseID.Text
        Dim strCourseName As String = txtCourseName.Text
        Dim strCourseLect As String = txtCourseLect.Text
        Dim strSql = "UPDATE courselist SET CourseID='" & strCourseID & "',CourseName='" & strCourseName & "',CourseLect='" & strCourseLect & "' WHERE CourseID= '" & strCourseID & "'"
        Dim CreateMySQL As New VBMySQL
        Try
            CreateMySQL.Insert_Row(strSql)
            MessageBox.Show("Successfully Edited.", "Congratulations", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Failed to update data" & vbCrLf & ex.Message,
           "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
        FrmDetailAdmin.ReadDataFromDB()
        FrmDetailAdmin.Show()
    End Sub
End Class