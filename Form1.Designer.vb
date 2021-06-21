<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetailAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.CourseID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseLect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExitAdmin = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTable
        '
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseID, Me.CourseName, Me.CourseLect})
        Me.dgvTable.Location = New System.Drawing.Point(16, 44)
        Me.dgvTable.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.RowHeadersWidth = 62
        Me.dgvTable.RowTemplate.Height = 28
        Me.dgvTable.Size = New System.Drawing.Size(517, 120)
        Me.dgvTable.TabIndex = 42
        '
        'CourseID
        '
        Me.CourseID.HeaderText = "Course ID"
        Me.CourseID.MinimumWidth = 8
        Me.CourseID.Name = "CourseID"
        Me.CourseID.Width = 150
        '
        'CourseName
        '
        Me.CourseName.HeaderText = "Course Name"
        Me.CourseName.MinimumWidth = 8
        Me.CourseName.Name = "CourseName"
        Me.CourseName.Width = 150
        '
        'CourseLect
        '
        Me.CourseLect.HeaderText = "Course Lecturer"
        Me.CourseLect.MinimumWidth = 8
        Me.CourseLect.Name = "CourseLect"
        Me.CourseLect.Width = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 24)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Course Detail"
        '
        'btnExitAdmin
        '
        Me.btnExitAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitAdmin.Location = New System.Drawing.Point(280, 181)
        Me.btnExitAdmin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExitAdmin.Name = "btnExitAdmin"
        Me.btnExitAdmin.Size = New System.Drawing.Size(96, 34)
        Me.btnExitAdmin.TabIndex = 41
        Me.btnExitAdmin.Text = "EXIT"
        Me.btnExitAdmin.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(180, 181)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 34)
        Me.btnAdd.TabIndex = 43
        Me.btnAdd.Text = "ADD NEW"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'FrmDetailAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExitAdmin)
        Me.Name = "FrmDetailAdmin"
        Me.Text = "Admin"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents CourseID As DataGridViewTextBoxColumn
    Friend WithEvents CourseName As DataGridViewTextBoxColumn
    Friend WithEvents CourseLect As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExitAdmin As Button
    Friend WithEvents btnAdd As Button
End Class
