<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeesPayments
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
        components = New ComponentModel.Container()
        txtSearch = New TextBox()
        Panel2 = New Panel()
        btnPrintReceipt = New Button()
        btnReload = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        txtPaymentMethod = New ComboBox()
        txtPaymentDate = New DateTimePicker()
        Label8 = New Label()
        txtBalance = New TextBox()
        Label7 = New Label()
        txtEmail = New TextBox()
        Label6 = New Label()
        txtReceiptNumber = New TextBox()
        Label5 = New Label()
        txtFeeType = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtAmountPaid = New TextBox()
        Label1 = New Label()
        txtStudentID = New TextBox()
        btnSearch = New Button()
        FeesPaymentsBindingSource = New BindingSource(components)
        FeesPaymentsBindingSource1 = New BindingSource(components)
        DataGridView1 = New DataGridView()
        Panel6 = New Panel()
        btnLogOut = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        StudentID = New DataGridViewTextBoxColumn()
        AmountPaid = New DataGridViewTextBoxColumn()
        FeeType = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        Balance = New DataGridViewTextBoxColumn()
        ReceiptNumber = New DataGridViewTextBoxColumn()
        PaymentMethod = New DataGridViewTextBoxColumn()
        PaymentDate = New DataGridViewTextBoxColumn()
        Panel2.SuspendLayout()
        CType(FeesPaymentsBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(FeesPaymentsBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtSearch.Location = New Point(719, 848)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(379, 45)
        txtSearch.TabIndex = 60
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel2.Controls.Add(btnPrintReceipt)
        Panel2.Controls.Add(btnReload)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnSave)
        Panel2.Location = New Point(34, 761)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1308, 67)
        Panel2.TabIndex = 57
        ' 
        ' btnPrintReceipt
        ' 
        btnPrintReceipt.BackColor = Color.DeepSkyBlue
        btnPrintReceipt.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrintReceipt.Location = New Point(1045, 3)
        btnPrintReceipt.Name = "btnPrintReceipt"
        btnPrintReceipt.Size = New Size(205, 50)
        btnPrintReceipt.TabIndex = 4
        btnPrintReceipt.Text = "Print Receipt"
        btnPrintReceipt.UseVisualStyleBackColor = False
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
        btnSave.Text = "Pay"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtPaymentMethod
        ' 
        txtPaymentMethod.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPaymentMethod.FormattingEnabled = True
        txtPaymentMethod.Items.AddRange(New Object() {"Cash", "Ecocash", "Bank Transfer", "Zipit"})
        txtPaymentMethod.Location = New Point(629, 414)
        txtPaymentMethod.Name = "txtPaymentMethod"
        txtPaymentMethod.Size = New Size(379, 46)
        txtPaymentMethod.TabIndex = 59
        ' 
        ' txtPaymentDate
        ' 
        txtPaymentDate.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPaymentDate.Location = New Point(629, 300)
        txtPaymentDate.Name = "txtPaymentDate"
        txtPaymentDate.Size = New Size(391, 45)
        txtPaymentDate.TabIndex = 58
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label8.Location = New Point(661, 626)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 38)
        Label8.TabIndex = 56
        Label8.Text = "Balance"
        ' 
        ' txtBalance
        ' 
        txtBalance.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtBalance.Location = New Point(632, 667)
        txtBalance.Name = "txtBalance"
        txtBalance.Size = New Size(379, 45)
        txtBalance.TabIndex = 55
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label7.Location = New Point(63, 626)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 38)
        Label7.TabIndex = 54
        Label7.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtEmail.Location = New Point(34, 667)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(379, 45)
        txtEmail.TabIndex = 53
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label6.Location = New Point(661, 513)
        Label6.Name = "Label6"
        Label6.Size = New Size(222, 38)
        Label6.TabIndex = 52
        Label6.Text = "Receipt Number"
        ' 
        ' txtReceiptNumber
        ' 
        txtReceiptNumber.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtReceiptNumber.Location = New Point(632, 554)
        txtReceiptNumber.Name = "txtReceiptNumber"
        txtReceiptNumber.Size = New Size(379, 45)
        txtReceiptNumber.TabIndex = 51
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label5.Location = New Point(63, 513)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 38)
        Label5.TabIndex = 50
        Label5.Text = "Fee Type"
        ' 
        ' txtFeeType
        ' 
        txtFeeType.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtFeeType.Location = New Point(34, 554)
        txtFeeType.Name = "txtFeeType"
        txtFeeType.Size = New Size(379, 45)
        txtFeeType.TabIndex = 49
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label4.Location = New Point(661, 374)
        Label4.Name = "Label4"
        Label4.Size = New Size(236, 38)
        Label4.TabIndex = 48
        Label4.Text = "Payment Method"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label3.Location = New Point(648, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 38)
        Label3.TabIndex = 47
        Label3.Text = "Payment Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label2.Location = New Point(63, 374)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 38)
        Label2.TabIndex = 46
        Label2.Text = "Amount Paid"
        ' 
        ' txtAmountPaid
        ' 
        txtAmountPaid.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtAmountPaid.Location = New Point(34, 415)
        txtAmountPaid.Name = "txtAmountPaid"
        txtAmountPaid.Size = New Size(379, 45)
        txtAmountPaid.TabIndex = 45
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label1.Location = New Point(63, 259)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 38)
        Label1.TabIndex = 44
        Label1.Text = "Student ID"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtStudentID.Location = New Point(34, 300)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(379, 45)
        txtStudentID.TabIndex = 43
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Olive
        btnSearch.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(1104, 848)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(139, 50)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' FeesPaymentsBindingSource
        ' 
        FeesPaymentsBindingSource.DataSource = GetType(FeesPayments)
        ' 
        ' FeesPaymentsBindingSource1
        ' 
        FeesPaymentsBindingSource1.DataSource = GetType(FeesPayments)
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {StudentID, AmountPaid, FeeType, Email, Balance, ReceiptNumber, PaymentMethod, PaymentDate})
        DataGridView1.Location = New Point(12, 948)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1330, 290)
        DataGridView1.TabIndex = 61
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel6.Controls.Add(btnLogOut)
        Panel6.Controls.Add(Button3)
        Panel6.Controls.Add(Button2)
        Panel6.Controls.Add(Button1)
        Panel6.Location = New Point(34, 12)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1139, 67)
        Panel6.TabIndex = 62
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.Red
        btnLogOut.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.Location = New Point(567, 3)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(176, 50)
        btnLogOut.TabIndex = 5
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(290, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(176, 50)
        Button3.TabIndex = 4
        Button3.Text = "Enroll"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(889, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(204, 50)
        Button2.TabIndex = 3
        Button2.Text = "Dashboard"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(39, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 50)
        Button1.TabIndex = 2
        Button1.Text = "MainMenu"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' StudentID
        ' 
        StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        StudentID.HeaderText = "Student ID"
        StudentID.MinimumWidth = 8
        StudentID.Name = "StudentID"
        ' 
        ' AmountPaid
        ' 
        AmountPaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        AmountPaid.HeaderText = "AmountPaid"
        AmountPaid.MinimumWidth = 8
        AmountPaid.Name = "AmountPaid"
        ' 
        ' FeeType
        ' 
        FeeType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FeeType.HeaderText = "Fee Type"
        FeeType.MinimumWidth = 8
        FeeType.Name = "FeeType"
        ' 
        ' Email
        ' 
        Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Email.HeaderText = "Email"
        Email.MinimumWidth = 8
        Email.Name = "Email"
        ' 
        ' Balance
        ' 
        Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Balance.HeaderText = "Balance"
        Balance.MinimumWidth = 8
        Balance.Name = "Balance"
        ' 
        ' ReceiptNumber
        ' 
        ReceiptNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ReceiptNumber.HeaderText = "Receipt Number"
        ReceiptNumber.MinimumWidth = 8
        ReceiptNumber.Name = "ReceiptNumber"
        ' 
        ' PaymentMethod
        ' 
        PaymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        PaymentMethod.HeaderText = "PaymentMethod"
        PaymentMethod.MinimumWidth = 8
        PaymentMethod.Name = "PaymentMethod"
        ' 
        ' PaymentDate
        ' 
        PaymentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        PaymentDate.HeaderText = "PaymentDate"
        PaymentDate.MinimumWidth = 8
        PaymentDate.Name = "PaymentDate"
        ' 
        ' FeesPayments
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1735, 1250)
        Controls.Add(Panel6)
        Controls.Add(DataGridView1)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(Panel2)
        Controls.Add(txtPaymentMethod)
        Controls.Add(txtPaymentDate)
        Controls.Add(Label8)
        Controls.Add(txtBalance)
        Controls.Add(Label7)
        Controls.Add(txtEmail)
        Controls.Add(Label6)
        Controls.Add(txtReceiptNumber)
        Controls.Add(Label5)
        Controls.Add(txtFeeType)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtAmountPaid)
        Controls.Add(Label1)
        Controls.Add(txtStudentID)
        Name = "FeesPayments"
        Text = "FeesPayments"
        Panel2.ResumeLayout(False)
        CType(FeesPaymentsBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(FeesPaymentsBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReload As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPaymentMethod As ComboBox
    Friend WithEvents txtPaymentDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReceiptNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFeeType As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents FeesPaymentsBindingSource As BindingSource
    Friend WithEvents FeesPaymentsBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents StudentID As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents FeeType As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Balance As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNumber As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDate As DataGridViewTextBoxColumn
End Class
