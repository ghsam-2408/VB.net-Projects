Imports System.Data.OleDb

Public Class Fees
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\School_Management.accdb")

    Private Function ValidateFields() As Boolean
        Dim isValid As Boolean = True

        ' Validate student ID
        If String.IsNullOrWhiteSpace(txtStudentId.Text) Then
            txtStudentId.BackColor = Color.LightCoral
            isValid = False
        Else
            txtStudentId.BackColor = Color.White
        End If

        ' Validate fee type
        If String.IsNullOrWhiteSpace(txtFeeType.Text) Then
            txtFeeType.BackColor = Color.LightCoral
            isValid = False
        Else
            txtFeeType.BackColor = Color.White
        End If

        ' Validate amount paid
        If String.IsNullOrWhiteSpace(txtAmntPaid.Text) Then
            txtAmntPaid.BackColor = Color.LightCoral
            isValid = False
        Else
            txtAmntPaid.BackColor = Color.White
        End If

        ' Validate form
        If String.IsNullOrWhiteSpace(txtForm.Text) Then
            txtForm.BackColor = Color.LightCoral
            isValid = False
        Else
            txtForm.BackColor = Color.White
        End If

        ' Validate payment method
        If String.IsNullOrWhiteSpace(paymentMethod.Text) Then
            paymentMethod.BackColor = Color.LightCoral
            isValid = False
        Else
            paymentMethod.BackColor = Color.White
        End If

        ' Validate receipt number
        If String.IsNullOrWhiteSpace(txtReceiptNumber.Text) Then
            txtReceiptNumber.BackColor = Color.LightCoral
            isValid = False
        Else
            txtReceiptNumber.BackColor = Color.White
        End If

        ' Validate department
        If String.IsNullOrWhiteSpace(txtDepartment.Text) Then
            txtDepartment.BackColor = Color.LightCoral
            isValid = False
        Else
            txtDepartment.BackColor = Color.White
        End If

        If Not isValid Then
            MsgBox("Please fill in all the required fields", MsgBoxStyle.Critical)
        End If

        Return isValid
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click

        If ValidateFields() Then
            ' Proceed with payment

            Try
                mycon.Open()
                Dim mycmd As New OleDbCommand("INSERT INTO Fees (Student_ID, Fee_Type, Amount_Paid, Form, Payment_Date, Payment_Method, Receipt_Number, Department) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", mycon)

                ' Use parameters to prevent SQL injection
                mycmd.Parameters.AddWithValue("?", txtStudentId.Text)
                mycmd.Parameters.AddWithValue("?", txtFeeType.Text)
                mycmd.Parameters.AddWithValue("?", txtAmntPaid.Text)
                mycmd.Parameters.AddWithValue("?", txtForm.Text)
                mycmd.Parameters.AddWithValue("?", paymentDate.Text)
                mycmd.Parameters.AddWithValue("?", paymentMethod.Text)
                mycmd.Parameters.AddWithValue("?", txtReceiptNumber.Text)
                mycmd.Parameters.AddWithValue("?", txtDepartment.Text)



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

    Private Sub ClearFields()
        txtAmntPaid.Text = String.Empty
        txtDepartment.Text = String.Empty
        txtFeeType.Text = String.Empty
        txtForm.Text = String.Empty
        txtReceiptNumber.Text = String.Empty
        txtStudentId.Text = String.Empty
        paymentDate.Text = String.Empty
        paymentMethod.Text = String.Empty
        GenerateReceiptNumber()
    End Sub

    Private Sub Fees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School_ManagementDataSet3.Fees' table. You can move, or remove it, as needed.
        Me.FeesTableAdapter.Fill(Me.School_ManagementDataSet3.Fees)
        txtReceiptNumber.Enabled = False
        GenerateReceiptNumber()
        ToolTip1.SetToolTip(btnHome, "Main Menu")
        btnClose.Cursor = Cursors.Hand
        btnDelete.Cursor = Cursors.Hand
        btnHome.Cursor = Cursors.Hand
        btnMinimize.Cursor = Cursors.Hand
        btnPay.Cursor = Cursors.Hand
        btnReceipt.Cursor = Cursors.Hand
        btnReload.Cursor = Cursors.Hand
        btnSearch.Cursor = Cursors.Hand
        btnUpdate.Cursor = Cursors.Hand
        btnSearch.Cursor = Cursors.Hand


    End Sub

    Private Sub GenerateReceiptNumber()
        Try
            mycon.Open()
            Dim cmd As New OleDbCommand("SELECT MAX(Receipt_Number) FROM Fees", mycon)
            Dim result = cmd.ExecuteScalar()

            Dim newNumber As Integer
            If IsDBNull(result) OrElse result Is Nothing Then
                newNumber = 1 ' First receipt if table is empty
            Else
                newNumber = Convert.ToInt32(result) + 1
            End If

            txtReceiptNumber.Text = "RCPT" & newNumber.ToString("0000") ' e.g., RCPT0001, RCPT0002

        Catch ex As Exception
            MessageBox.Show("Error generating receipt number: " & ex.Message)
        Finally
            mycon.Close()
        End Try
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

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        MainMenu.Show()
    End Sub
End Class