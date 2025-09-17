<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsEnrollment
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
        DataGridView1 = New DataGridView()
        Label8 = New Label()
        Label7 = New Label()
        txtEmail = New TextBox()
        Label6 = New Label()
        txtForm = New TextBox()
        Label5 = New Label()
        txtStudentSurname = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtStudentName = New TextBox()
        Label1 = New Label()
        txtStudentID = New TextBox()
        Panel1 = New Panel()
        txtSubjects = New CheckedListBox()
        Label9 = New Label()
        Label10 = New Label()
        txtDOB = New DateTimePicker()
        txtAdmissionDate = New DateTimePicker()
        txtGender = New ComboBox()
        Panel2 = New Panel()
        btnReload = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        txtDepartment = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(270, 844)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1087, 240)
        DataGridView1.TabIndex = 33
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label8.Location = New Point(662, 481)
        Label8.Name = "Label8"
        Label8.Size = New Size(171, 38)
        Label8.TabIndex = 32
        Label8.Text = "Department"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label7.Location = New Point(64, 481)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 38)
        Label7.TabIndex = 30
        Label7.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtEmail.Location = New Point(35, 522)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(379, 45)
        txtEmail.TabIndex = 29
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label6.Location = New Point(662, 368)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 38)
        Label6.TabIndex = 28
        Label6.Text = "Form"
        ' 
        ' txtForm
        ' 
        txtForm.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtForm.Location = New Point(633, 409)
        txtForm.Name = "txtForm"
        txtForm.Size = New Size(379, 45)
        txtForm.TabIndex = 27
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label5.Location = New Point(64, 368)
        Label5.Name = "Label5"
        Label5.Size = New Size(235, 38)
        Label5.TabIndex = 26
        Label5.Text = "Student Surname"
        ' 
        ' txtStudentSurname
        ' 
        txtStudentSurname.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtStudentSurname.Location = New Point(35, 409)
        txtStudentSurname.Name = "txtStudentSurname"
        txtStudentSurname.Size = New Size(379, 45)
        txtStudentSurname.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label4.Location = New Point(662, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 38)
        Label4.TabIndex = 24
        Label4.Text = "Admission Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label3.Location = New Point(649, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 38)
        Label3.TabIndex = 22
        Label3.Text = "Gender"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label2.Location = New Point(64, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(199, 38)
        Label2.TabIndex = 20
        Label2.Text = "Student Name"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtStudentName.Location = New Point(35, 270)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(379, 45)
        txtStudentName.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label1.Location = New Point(64, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 38)
        Label1.TabIndex = 18
        Label1.Text = "Student ID"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtStudentID.Location = New Point(35, 155)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(379, 45)
        txtStudentID.TabIndex = 17
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Location = New Point(12, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1139, 67)
        Panel1.TabIndex = 34
        ' 
        ' txtSubjects
        ' 
        txtSubjects.FormattingEnabled = True
        txtSubjects.Location = New Point(1143, 155)
        txtSubjects.Name = "txtSubjects"
        txtSubjects.Size = New Size(323, 228)
        txtSubjects.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label9.Location = New Point(1143, 114)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 38)
        Label9.TabIndex = 36
        Label9.Text = "Subjects"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label10.Location = New Point(1132, 481)
        Label10.Name = "Label10"
        Label10.Size = New Size(181, 38)
        Label10.TabIndex = 38
        Label10.Text = "Date of Birth"
        ' 
        ' txtDOB
        ' 
        txtDOB.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDOB.Location = New Point(1132, 522)
        txtDOB.Name = "txtDOB"
        txtDOB.Size = New Size(391, 45)
        txtDOB.TabIndex = 39
        ' 
        ' txtAdmissionDate
        ' 
        txtAdmissionDate.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAdmissionDate.Location = New Point(633, 289)
        txtAdmissionDate.Name = "txtAdmissionDate"
        txtAdmissionDate.Size = New Size(391, 45)
        txtAdmissionDate.TabIndex = 40
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGender.FormattingEnabled = True
        txtGender.Items.AddRange(New Object() {"Male", "Female"})
        txtGender.Location = New Point(633, 167)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(379, 46)
        txtGender.TabIndex = 41
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel2.Controls.Add(btnReload)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnSave)
        Panel2.Location = New Point(35, 616)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1139, 65)
        Panel2.TabIndex = 35
        ' 
        ' btnReload
        ' 
        btnReload.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnReload.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReload.Location = New Point(870, 3)
        btnReload.Name = "btnReload"
        btnReload.Size = New Size(129, 50)
        btnReload.TabIndex = 3
        btnReload.Text = "Re-load"
        btnReload.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Yellow
        btnUpdate.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(595, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(129, 50)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(312, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(129, 50)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Lime
        btnSave.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(60, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(129, 50)
        btnSave.TabIndex = 0
        btnSave.Text = "Enroll Student"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Green
        btnSearch.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(1305, 700)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(129, 50)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtSearch.Location = New Point(920, 703)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(379, 45)
        txtSearch.TabIndex = 42
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDepartment.FormattingEnabled = True
        txtDepartment.Items.AddRange(New Object() {"Sciences", "Commercials", "Arts"})
        txtDepartment.Location = New Point(630, 521)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(379, 46)
        txtDepartment.TabIndex = 43
        ' 
        ' StudentsEnrollment
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1911, 1250)
        Controls.Add(txtDepartment)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(Panel2)
        Controls.Add(txtGender)
        Controls.Add(txtAdmissionDate)
        Controls.Add(txtDOB)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(txtSubjects)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtEmail)
        Controls.Add(Label6)
        Controls.Add(txtForm)
        Controls.Add(Label5)
        Controls.Add(txtStudentSurname)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtStudentName)
        Controls.Add(Label1)
        Controls.Add(txtStudentID)
        Name = "StudentsEnrollment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentsEnrollment"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtForm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStudentSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSubjects As CheckedListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents txtAdmissionDate As DateTimePicker
    Friend WithEvents txtGender As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtDepartment As ComboBox
End Class
