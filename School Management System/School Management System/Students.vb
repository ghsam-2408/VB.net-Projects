Imports System.Data.OleDb

Public Class Students
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\School_Management.accdb")

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadImg.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                profilepic.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch ex As Exception
                MsgBox("Error loading image: " & ex.Message)
            End Try
        End If

    End Sub


    Private Function ValidateFields() As Boolean
        Dim isValid As Boolean = True

        ' Validate student id
        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            txtStudentID.BackColor = Color.LightCoral
            isValid = False
        Else
            txtStudentID.BackColor = Color.White
        End If

        ' Validate student name
        If String.IsNullOrWhiteSpace(txtStudentName.Text) Then
            txtStudentName.BackColor = Color.LightCoral
            isValid = False
        Else
            txtStudentName.BackColor = Color.White
        End If

        ' Validate gender
        If String.IsNullOrWhiteSpace(txtGender.Text) Then
            txtGender.BackColor = Color.LightCoral
            isValid = False
        Else
            txtGender.BackColor = Color.White
        End If

        ' Validate phone
        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            txtPhone.BackColor = Color.LightCoral
            isValid = False
        Else
            txtPhone.BackColor = Color.White
        End If

        ' Validate form
        If String.IsNullOrWhiteSpace(txtForm.Text) Then
            txtForm.BackColor = Color.LightCoral
            isValid = False
        Else
            txtForm.BackColor = Color.White
        End If

        ' Validate job department
        If String.IsNullOrWhiteSpace(txtDepartment.Text) Then
            txtDepartment.BackColor = Color.LightCoral
            isValid = False
        Else
            txtDepartment.BackColor = Color.White
        End If

        ' Validate job subjects
        If String.IsNullOrWhiteSpace(txtSubjects.Text) Then
            txtSubjects.BackColor = Color.LightCoral
            isValid = False
        Else
            txtSubjects.BackColor = Color.White
        End If

        If Not isValid Then
            MsgBox("Please fill in all the required fields", MsgBoxStyle.Critical)
        End If

        Return isValid
    End Function

    Private Sub ClearFields()
        txtAdmissionDate.Text = String.Empty
        txtDepartment.Text = String.Empty
        txtDOB.Text = String.Empty
        txtForm.Text = String.Empty
        txtGender.Text = String.Empty
        txtStudentID.Text = String.Empty
        txtStudentName.Text = String.Empty
        txtSubjects.Text = String.Empty


    End Sub



    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School_ManagementDataSet2.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.School_ManagementDataSet2.Students)
        btnMinimize.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
        btnFullscreen.Cursor = Cursors.Hand
        btnHome.Cursor = Cursors.Hand
        btnDelete.Cursor = Cursors.Hand
        btnSave.Cursor = Cursors.Hand
        btnReload.Cursor = Cursors.Hand
        btnUpdate.Cursor = Cursors.Hand
        btnUploadImg.Cursor = Cursors.Hand

        ToolTip1.SetToolTip(btnHome, "Main Menu")

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        MainMenu.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullscreen.Click
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateFields() Then
            ' Proceed with registration
            Try
                mycon.Open()
                Dim mycmd As New OleDbCommand("INSERT INTO Students (Student_ID, Student_Name, Date_of_Birth, Gender, Phone, Admission_Date, Form, Department, Subjects) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)", mycon)

                ' Use parameters to prevent SQL injection
                mycmd.Parameters.AddWithValue("?", txtStudentID.Text)
                mycmd.Parameters.AddWithValue("?", txtStudentName.Text)
                mycmd.Parameters.AddWithValue("?", txtDOB.Text)
                mycmd.Parameters.AddWithValue("?", txtGender.Text)
                mycmd.Parameters.AddWithValue("?", txtPhone.Text)
                mycmd.Parameters.AddWithValue("?", txtAdmissionDate.Text)
                mycmd.Parameters.AddWithValue("?", txtForm.Text)
                mycmd.Parameters.AddWithValue("?", txtDepartment.Text)
                mycmd.Parameters.AddWithValue("?", txtSubjects.Text)



                ' Execute the query
                Dim rowsAffected As Integer = mycmd.ExecuteNonQuery()

                ' Check if insertion was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Record inserted successfully!")
                Else
                    MessageBox.Show("Failed to insert record.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                ' Ensure the connection is closed properly
                If mycon.State = ConnectionState.Open Then
                    mycon.Close()
                End If
            End Try
        End If

        ClearFields()
    End Sub
End Class