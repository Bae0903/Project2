Imports MySql.Data.MySqlClient
Public Class FrmAdd

    'Private Sub btnSave_Click(sender As Object, e As EventArgs)
    'Dim intId As Integer
    'Dim strName As String = txtCourseName.Text
    'Dim strLect As String = txtCourseLect.Text
    'Dim strID As String = txtCourseID.Text
    'Dim strSql = "INSERT INTO course;ist VALUES (null, '" & strName & "', '" & strLect & "', '" & strID & "')"
    'Dim CreateMySQL As New VBMySQL
    'Try
    'If strName = "" And strLect = "" AndAlso strID = 0 Then
    '           MessageBox.Show("Please insert data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    'Else
    '           CreateMySQL.Insert_Row(strSql)
    '          MessageBox.Show("Data successfully saved.", "Congratulations", MessageBoxButtons.OK)
    'End If
    '
    'Catch ex As Exception
    '       MessageBox.Show("The data failed to stored." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'Finally
    'Me.Close()
    '       FrmDetailAdmin.ReadDataFromDB()
    '      FrmDetailAdmin.Show()
    'End Try
    'End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result = MessageBox.Show(" Are you sure you want to Cancel?", "Books", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            FrmDetailAdmin.Show()
        End If
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intId As Integer
        Dim strCourseID As String = txtCourseID.Text
        Dim strCourseName As String = txtCourseName.Text
        Dim strCourseLect As String = txtCourseLect.Text
        Dim strSql = "INSERT INTO courselist VALUES ('" & strCourseID & "', '" & strCourseName & "', '" & strCourseLect & "')"
        Dim CreateMySQL As New VBMySQL
        Try
            If strCourseID = "" And strCourseName = "" AndAlso strCourseLect = "" Then
                MessageBox.Show("Please insert data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                CreateMySQL.Insert_Row(strSql)
                MessageBox.Show("Data successfully saved.", "Congratulations", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            MessageBox.Show("The data failed to stored." & vbCrLf & ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Close()
            FrmDetailAdmin.ReadDataFromDB()
            FrmDetailAdmin.Show()
        End Try
    End Sub
End Class