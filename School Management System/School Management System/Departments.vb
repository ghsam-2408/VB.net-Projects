Imports System.Data.OleDb

Public Class Departments

    Private cmdBuilder As OleDbCommandBuilder
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\School_Management.accdb")

    Private Function ValidateFields() As Boolean
        Dim isValid As Boolean = True

        ' Validate department id
        If String.IsNullOrWhiteSpace(txtDeptID.Text) Then
            txtDeptID.BackColor = Color.LightCoral
            isValid = False
        Else
            txtDeptID.BackColor = Color.White
        End If

        ' Validate department hod
        If String.IsNullOrWhiteSpace(txtHOD.Text) Then
            txtHOD.BackColor = Color.LightCoral
            isValid = False
        Else
            txtHOD.BackColor = Color.White
        End If

        ' Validate department name
        If String.IsNullOrWhiteSpace(txtDeptName.Text) Then
            txtDeptName.BackColor = Color.LightCoral
            isValid = False
        Else
            txtDeptName.BackColor = Color.White
        End If

        ' Validate description
        If String.IsNullOrWhiteSpace(txtDescription.Text) Then
            txtDescription.BackColor = Color.LightCoral
            isValid = False
        Else
            txtDescription.BackColor = Color.White
        End If

        If Not isValid Then
            MsgBox("Please fill in all the required fields", MsgBoxStyle.Critical)
        End If

        Return isValid
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If ValidateFields() Then
            ' Proceed with payment

            Try
                mycon.Open()
                Dim mycmd As New OleDbCommand("INSERT INTO Departments (Department_ID, Department_Name, HOD, Description) VALUES (?, ?, ?, ?)", mycon)

                ' Use parameters to prevent SQL injection
                mycmd.Parameters.AddWithValue("?", txtDeptID.Text)
                mycmd.Parameters.AddWithValue("?", txtDeptName.Text)
                mycmd.Parameters.AddWithValue("?", txtHOD.Text)
                mycmd.Parameters.AddWithValue("?", txtDescription.Text)

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
        LoadData()


    End Sub

    Private Sub ClearFields()
        txtDeptID.Text = String.Empty
        txtDeptName.Text = String.Empty
        txtDescription.Text = String.Empty
        txtHOD.Text = String.Empty
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        MainMenu.Show()
        Me.Close()

    End Sub

    Private Sub Departments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()

        'TODO: This line of code loads data into the 'School_ManagementDataSet4.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.School_ManagementDataSet4.Departments)
        ToolTip1.SetToolTip(btnHome, "Main Menu")
        btnSearch.Cursor = Cursors.Hand
        btnReload.Cursor = Cursors.Hand
        btnSave.Cursor = Cursors.Hand
        btnUpdate.Cursor = Cursors.Hand
        btnMinimize.Cursor = Cursors.Hand
        btnHome.Cursor = Cursors.Hand
        btnDelete.Cursor = Cursors.Hand
        btnClose.Cursor = Cursors.Hand



    End Sub
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    ' Load data into DataGridView
    Private Sub LoadData()
        Try
            mycon.Open()
            Dim query As String = "SELECT * FROM Departments"
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

    ' Populate fields when form loads
    Private Sub Fees_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Populate textboxes when a row is clicked
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtDeptID.Text = row.Cells(0).Value.ToString()
            txtDeptName.Text = row.Cells(1).Value.ToString()
            txtHOD.Text = row.Cells(2).Value.ToString()
            txtDescription.Text = row.Cells(3).Value.ToString()

        End If
    End Sub

    Private ReadOnly connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\School_Management.accdb"

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtDeptID.Text) Then
            MessageBox.Show("Select a record first.")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Using cn As New OleDbConnection(connStr)
                    cn.Open()
                    ' Department_ID is alphanumeric, so treat as text
                    Using cmd As New OleDbCommand("DELETE FROM Departments WHERE Department_ID=?", cn)
                        cmd.Parameters.Add("?", OleDbType.VarWChar, 50).Value = txtDeptID.Text.Trim()

                        Dim affected As Integer = cmd.ExecuteNonQuery()
                        If affected > 0 Then
                            MessageBox.Show("Record deleted successfully!")
                            LoadData()
                            ClearFields()
                        Else
                            MessageBox.Show("No record matched that Department_ID.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Try
            If mycon.State = ConnectionState.Open Then mycon.Close()
            mycon.Open()

            Dim query As String = "UPDATE Departments SET Department_ID=?, Department_Name=?, HOD=?, Description=? WHERE Department_ID=?"
            Dim cmd As New OleDbCommand(query, mycon)

            cmd.Parameters.AddWithValue("?", txtDeptID.Text)
            cmd.Parameters.AddWithValue("?", txtDeptName.Text)
            cmd.Parameters.AddWithValue("?", txtHOD.Text)
            cmd.Parameters.AddWithValue("?", txtDescription.Text)
            cmd.Parameters.AddWithValue("?", txtDeptID.Text)  ' for WHERE

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Record updated successfully!")
                LoadData() ' Refresh grid
            Else
                MessageBox.Show("Update failed.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating: " & ex.Message)
        Finally
            If mycon.State = ConnectionState.Open Then mycon.Close()
        End Try


    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            mycon.Open()
            Dim query As String = "SELECT * FROM Departments WHERE Department_ID LIKE ?"
            Dim da As New OleDbDataAdapter(query, mycon)
            da.SelectCommand.Parameters.AddWithValue("?", "%" & txtSearch.Text & "%")

            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            mycon.Close()
        End Try
    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        LoadData()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class

