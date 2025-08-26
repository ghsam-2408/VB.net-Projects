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
                mycmd.Parameters.AddWithValue("?", txtAdmissionDate.Value)
                mycmd.Parameters.AddWithValue("?", txtPhone.Text)
                mycmd.Parameters.AddWithValue("?", txtDepartment.Text)
                mycmd.Parameters.AddWithValue("?", txtSubjectsTaught.Text)


                ' Execute the query
                Dim rowsAffected As Integer = mycmd.ExecuteNonQuery()

                ' Check if insertion was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Record inserted successfully!")
                    'LoadData()

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
                LoadData()

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
        LoadData()

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

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        LoadData()

    End Sub
    ' Load data into DataGridView
    Private Sub LoadData()
        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Try
            mycon.Open()
            Dim query As String = "SELECT * FROM Teachers"
            da = New OleDbDataAdapter(query, mycon)
            dt = New DataTable()
            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            mycon.Close()
        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtEmployeeID.Text = "" Then
            MessageBox.Show("Please select a record to delete.")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                If mycon.State = ConnectionState.Open Then mycon.Close()
                mycon.Open()

                Dim query As String = "DELETE FROM Teachers WHERE Employee_ID=?"
                Dim cmd As New OleDbCommand(query, mycon)
                cmd.Parameters.AddWithValue("?", txtEmployeeID.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Record deleted successfully!")
                    
                Else
                    MessageBox.Show("Delete failed.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error deleting: " & ex.Message)
            Finally
                If mycon.State = ConnectionState.Open Then
                    mycon.Close()
                End If
                LoadData()

                ClearFields()

            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If mycon.State = ConnectionState.Open Then mycon.Close()
            mycon.Open()

            Dim query As String = "UPDATE Teachers SET Employee_ID=?, Full_Name=?, Job_Title=?, Admission_Date=?, Phone=?, Department=?, Subjects_Taught=? WHERE Employee_ID=?"
            Dim cmd As New OleDbCommand(query, mycon)

            cmd.Parameters.AddWithValue("?", txtEmployeeID.Text)
            cmd.Parameters.AddWithValue("?", txtFullName.Text)
            cmd.Parameters.AddWithValue("?", txtJobTitle.Text)
            cmd.Parameters.AddWithValue("?", txtAdmissionDate.Value)
            'cmd.Parameters.AddWithValue("?", txtPhone.Text)
            cmd.Parameters.AddWithValue("?", Convert.ToInt32(txtPhone.Text))
            cmd.Parameters.AddWithValue("?", txtDepartment.Text)
            cmd.Parameters.AddWithValue("?", txtSubjectsTaught.Text)
            cmd.Parameters.AddWithValue("?", txtEmployeeID.Text)



            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Record updated successfully!")
            Else
                MessageBox.Show("Update failed.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating: " & ex.Message)
        Finally
            If mycon.State = ConnectionState.Open Then
                mycon.Close()

            End If
            LoadData()

        End Try
    End Sub

    ' Populate textboxes when a row is clicked
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtEmployeeID.Text = row.Cells(0).Value.ToString()
            txtFullName.Text = row.Cells(1).Value.ToString()
            txtJobTitle.Text = row.Cells(2).Value.ToString()
            txtAdmissionDate.Text = row.Cells(3).Value.ToString()
            txtPhone.Text = row.Cells(4).Value.ToString()
            txtDepartment.Text = row.Cells(5).Value.ToString()
            txtSubjectsTaught.Text = row.Cells(6).Value.ToString()



        End If
    End Sub
End Class