Imports System.Data.OleDb

Public Class Teachers
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\School_Management.accdb")

    Private Function ValidateFields() As Boolean
        Dim isValid As Boolean = True

        ' Validate employee id
        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
            txtEmployeeID.BackColor = Color.LightCoral
            isValid = False
        Else
            txtEmployeeID.BackColor = Color.White
        End If

        ' Validate full name
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            txtFullName.BackColor = Color.LightCoral
            isValid = False
        Else
            txtFullName.BackColor = Color.White
        End If

        ' Validate phone
        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            txtPhone.BackColor = Color.LightCoral
            isValid = False
        Else
            txtPhone.BackColor = Color.White
        End If

        ' Validate department
        If String.IsNullOrWhiteSpace(txtDepartment.Text) Then
            txtDepartment.BackColor = Color.LightCoral
            isValid = False
        Else
            txtDepartment.BackColor = Color.White
        End If

        ' Validate subjects taught
        If String.IsNullOrWhiteSpace(txtSubjectsTaught.Text) Then
            txtSubjectsTaught.BackColor = Color.LightCoral
            isValid = False
        Else
            txtSubjectsTaught.BackColor = Color.White
        End If

        ' Validate job title
        If String.IsNullOrWhiteSpace(txtJobTitle.Text) Then
            txtJobTitle.BackColor = Color.LightCoral
            isValid = False
        Else
            txtJobTitle.BackColor = Color.White
        End If

        If Not isValid Then
            MsgBox("Please fill in all the required fields", MsgBoxStyle.Critical)
        End If

        Return isValid
    End Function

    Private Sub ClearFields()
        txtAdmissionDate.Text = String.Empty
        txtDepartment.Text = String.Empty
        txtFullName.Text = String.Empty
        txtEmployeeID.Text = String.Empty
        txtJobTitle.Text = String.Empty
        txtSubjectsTaught.Text = String.Empty
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateFields() Then
            ' Proceed with registration
            Try
                mycon.Open()
                Dim mycmd As New OleDbCommand("INSERT INTO Teachers (Employee_ID, Full_Name, Job_Title, Admission_Date, Phone, Department, Subjects_Taught) VALUES (?, ?, ?, ?, ?, ?, ?)", mycon)

                ' Use parameters to prevent SQL injection
                mycmd.Parameters.AddWithValue("?", txtEmployeeID.Text)
                mycmd.Parameters.AddWithValue("?", txtFullName.Text)
                mycmd.Parameters.AddWithValue("?", txtJobTitle.Text)
                mycmd.Parameters.AddWithValue("?", txtAdmissionDate.Text)
                mycmd.Parameters.AddWithValue("?", txtPhone.Text)
                mycmd.Parameters.AddWithValue("?", txtDepartment.Text)
                mycmd.Parameters.AddWithValue("?", txtSubjectsTaught.Text)


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

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullscreen.Click
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Teachers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School_ManagementDataSet1.Teachers' table. You can move, or remove it, as needed.
        Me.TeachersTableAdapter.Fill(Me.School_ManagementDataSet1.Teachers)
        'TODO: This line of code loads data into the 'School_ManagementDataSet.Teachers' table. You can move, or remove it, as needed.
        'Me.TeachersTableAdapter.Fill(Me.School_ManagementDataSet.Teachers)
        ToolTip1.SetToolTip(btnHome, "Main Menu")
        btnMinimize.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand
        btnFullscreen.Cursor = Cursors.Hand
        btnHome.Cursor = Cursors.Hand
        btnSave.Cursor = Cursors.Hand
        btnDelete.Cursor = Cursors.Hand
        btnReload.Cursor = Cursors.Hand
        btnUpdate.Cursor = Cursors.Hand
        


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        MainMenu.Show()
        Me.Close()

    End Sub
End Class