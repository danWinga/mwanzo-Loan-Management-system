<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanApplication
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtxtAddress = New System.Windows.Forms.RichTextBox()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAccNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GridA = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GridB = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rtxtPurpose = New System.Windows.Forms.RichTextBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.dtRepDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRepDate = New System.Windows.Forms.Label()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.txtAvlAmount = New System.Windows.Forms.TextBox()
        Me.lblAvlAmount = New System.Windows.Forms.Label()
        Me.txtRqstAmount = New System.Windows.Forms.TextBox()
        Me.lblRqtAmount = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtTotalSaving = New System.Windows.Forms.TextBox()
        Me.lblTotalSaving = New System.Windows.Forms.Label()
        Me.txtGrpContract = New System.Windows.Forms.TextBox()
        Me.lblContract = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.lblGroupName = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rdbIsGroup = New System.Windows.Forms.RadioButton()
        Me.rdbGrpMember = New System.Windows.Forms.RadioButton()
        Me.rdbIndividual = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLoanShedule = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rtxtComment = New System.Windows.Forms.RichTextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.rdbMemberAcc = New System.Windows.Forms.RadioButton()
        Me.rdbGroupAcc = New System.Windows.Forms.RadioButton()
        Me.lbMaxPeriod = New System.Windows.Forms.Label()
        Me.txtMaxPeriod = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search "
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(276, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(156, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search Acc/ ID"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(264, 20)
        Me.txtSearch.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtxtAddress)
        Me.GroupBox2.Controls.Add(Me.lblMobileNo)
        Me.GroupBox2.Controls.Add(Me.txtMobileNo)
        Me.GroupBox2.Controls.Add(Me.lblAddress)
        Me.GroupBox2.Controls.Add(Me.txtAccNumber)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtFullName)
        Me.GroupBox2.Controls.Add(Me.lblFullName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 181)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Holder Details"
        '
        'rtxtAddress
        '
        Me.rtxtAddress.Location = New System.Drawing.Point(110, 97)
        Me.rtxtAddress.Name = "rtxtAddress"
        Me.rtxtAddress.Size = New System.Drawing.Size(332, 65)
        Me.rtxtAddress.TabIndex = 7
        Me.rtxtAddress.Text = ""
        '
        'lblMobileNo
        '
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.Location = New System.Drawing.Point(6, 72)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(58, 13)
        Me.lblMobileNo.TabIndex = 6
        Me.lblMobileNo.Text = "Mobile No:"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(110, 71)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(228, 20)
        Me.txtMobileNo.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 135)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address"
        '
        'txtAccNumber
        '
        Me.txtAccNumber.Location = New System.Drawing.Point(110, 44)
        Me.txtAccNumber.Name = "txtAccNumber"
        Me.txtAccNumber.Size = New System.Drawing.Size(228, 20)
        Me.txtAccNumber.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account Number"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(110, 19)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(332, 20)
        Me.txtFullName.TabIndex = 1
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(6, 16)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(59, 13)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Names"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridA)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(458, 318)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Current Loan Record"
        '
        'GridA
        '
        Me.GridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridA.Location = New System.Drawing.Point(9, 19)
        Me.GridA.Name = "GridA"
        Me.GridA.Size = New System.Drawing.Size(443, 332)
        Me.GridA.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridB)
        Me.GroupBox4.Location = New System.Drawing.Point(486, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(443, 597)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Contribution Record"
        '
        'GridB
        '
        Me.GridB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridB.Location = New System.Drawing.Point(9, 19)
        Me.GridB.Name = "GridB"
        Me.GridB.Size = New System.Drawing.Size(428, 572)
        Me.GridB.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtMaxPeriod)
        Me.GroupBox5.Controls.Add(Me.lbMaxPeriod)
        Me.GroupBox5.Controls.Add(Me.rtxtPurpose)
        Me.GroupBox5.Controls.Add(Me.lblPurpose)
        Me.GroupBox5.Controls.Add(Me.txtRate)
        Me.GroupBox5.Controls.Add(Me.lblRate)
        Me.GroupBox5.Controls.Add(Me.dtRepDate)
        Me.GroupBox5.Controls.Add(Me.lblRepDate)
        Me.GroupBox5.Controls.Add(Me.txtPeriod)
        Me.GroupBox5.Controls.Add(Me.lblPeriod)
        Me.GroupBox5.Controls.Add(Me.txtAvlAmount)
        Me.GroupBox5.Controls.Add(Me.lblAvlAmount)
        Me.GroupBox5.Controls.Add(Me.txtRqstAmount)
        Me.GroupBox5.Controls.Add(Me.lblRqtAmount)
        Me.GroupBox5.Location = New System.Drawing.Point(935, 215)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(319, 222)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Loan Request"
        '
        'rtxtPurpose
        '
        Me.rtxtPurpose.Location = New System.Drawing.Point(119, 145)
        Me.rtxtPurpose.Name = "rtxtPurpose"
        Me.rtxtPurpose.Size = New System.Drawing.Size(183, 56)
        Me.rtxtPurpose.TabIndex = 11
        Me.rtxtPurpose.Text = ""
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Location = New System.Drawing.Point(16, 168)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(46, 13)
        Me.lblPurpose.TabIndex = 10
        Me.lblPurpose.Text = "Purpose"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(120, 90)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(182, 20)
        Me.txtRate.TabIndex = 9
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(16, 97)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 8
        Me.lblRate.Text = "Rate"
        '
        'dtRepDate
        '
        Me.dtRepDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRepDate.Location = New System.Drawing.Point(120, 116)
        Me.dtRepDate.Name = "dtRepDate"
        Me.dtRepDate.Size = New System.Drawing.Size(182, 20)
        Me.dtRepDate.TabIndex = 7
        '
        'lblRepDate
        '
        Me.lblRepDate.AutoSize = True
        Me.lblRepDate.Location = New System.Drawing.Point(16, 122)
        Me.lblRepDate.Name = "lblRepDate"
        Me.lblRepDate.Size = New System.Drawing.Size(87, 13)
        Me.lblRepDate.TabIndex = 6
        Me.lblRepDate.Text = "Repayment Date"
        '
        'txtPeriod
        '
        Me.txtPeriod.Location = New System.Drawing.Point(120, 67)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(52, 20)
        Me.txtPeriod.TabIndex = 5
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(16, 74)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(81, 13)
        Me.lblPeriod.TabIndex = 4
        Me.lblPeriod.Text = "Period (Months)"
        '
        'txtAvlAmount
        '
        Me.txtAvlAmount.Location = New System.Drawing.Point(120, 40)
        Me.txtAvlAmount.Name = "txtAvlAmount"
        Me.txtAvlAmount.Size = New System.Drawing.Size(182, 20)
        Me.txtAvlAmount.TabIndex = 3
        '
        'lblAvlAmount
        '
        Me.lblAvlAmount.AutoSize = True
        Me.lblAvlAmount.Location = New System.Drawing.Point(16, 43)
        Me.lblAvlAmount.Name = "lblAvlAmount"
        Me.lblAvlAmount.Size = New System.Drawing.Size(89, 13)
        Me.lblAvlAmount.TabIndex = 2
        Me.lblAvlAmount.Text = "Available Amount"
        '
        'txtRqstAmount
        '
        Me.txtRqstAmount.Location = New System.Drawing.Point(119, 15)
        Me.txtRqstAmount.Name = "txtRqstAmount"
        Me.txtRqstAmount.Size = New System.Drawing.Size(182, 20)
        Me.txtRqstAmount.TabIndex = 1
        '
        'lblRqtAmount
        '
        Me.lblRqtAmount.AutoSize = True
        Me.lblRqtAmount.Location = New System.Drawing.Point(16, 19)
        Me.lblRqtAmount.Name = "lblRqtAmount"
        Me.lblRqtAmount.Size = New System.Drawing.Size(98, 13)
        Me.lblRqtAmount.TabIndex = 0
        Me.lblRqtAmount.Text = "Requested Amount"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(935, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(319, 206)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Account Information"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtTotalSaving)
        Me.GroupBox8.Controls.Add(Me.lblTotalSaving)
        Me.GroupBox8.Controls.Add(Me.txtGrpContract)
        Me.GroupBox8.Controls.Add(Me.lblContract)
        Me.GroupBox8.Controls.Add(Me.txtGroupName)
        Me.GroupBox8.Controls.Add(Me.lblGroupName)
        Me.GroupBox8.Location = New System.Drawing.Point(9, 71)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(304, 116)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Group Details"
        '
        'txtTotalSaving
        '
        Me.txtTotalSaving.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSaving.Location = New System.Drawing.Point(119, 77)
        Me.txtTotalSaving.Name = "txtTotalSaving"
        Me.txtTotalSaving.Size = New System.Drawing.Size(173, 28)
        Me.txtTotalSaving.TabIndex = 5
        '
        'lblTotalSaving
        '
        Me.lblTotalSaving.AutoSize = True
        Me.lblTotalSaving.Location = New System.Drawing.Point(17, 80)
        Me.lblTotalSaving.Name = "lblTotalSaving"
        Me.lblTotalSaving.Size = New System.Drawing.Size(72, 13)
        Me.lblTotalSaving.TabIndex = 4
        Me.lblTotalSaving.Text = "Total Savings"
        '
        'txtGrpContract
        '
        Me.txtGrpContract.Location = New System.Drawing.Point(120, 51)
        Me.txtGrpContract.Name = "txtGrpContract"
        Me.txtGrpContract.Size = New System.Drawing.Size(173, 20)
        Me.txtGrpContract.TabIndex = 3
        '
        'lblContract
        '
        Me.lblContract.AutoSize = True
        Me.lblContract.Location = New System.Drawing.Point(17, 58)
        Me.lblContract.Name = "lblContract"
        Me.lblContract.Size = New System.Drawing.Size(49, 13)
        Me.lblContract.TabIndex = 2
        Me.lblContract.Text = "Contacts"
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(119, 25)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(173, 20)
        Me.txtGroupName.TabIndex = 1
        '
        'lblGroupName
        '
        Me.lblGroupName.AutoSize = True
        Me.lblGroupName.Location = New System.Drawing.Point(17, 28)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(64, 13)
        Me.lblGroupName.TabIndex = 0
        Me.lblGroupName.Text = "GroupName"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rdbIsGroup)
        Me.GroupBox7.Controls.Add(Me.rdbGrpMember)
        Me.GroupBox7.Controls.Add(Me.rdbIndividual)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(307, 54)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Group"
        '
        'rdbIsGroup
        '
        Me.rdbIsGroup.AutoSize = True
        Me.rdbIsGroup.Location = New System.Drawing.Point(206, 21)
        Me.rdbIsGroup.Name = "rdbIsGroup"
        Me.rdbIsGroup.Size = New System.Drawing.Size(62, 17)
        Me.rdbIsGroup.TabIndex = 2
        Me.rdbIsGroup.TabStop = True
        Me.rdbIsGroup.Text = "IsGroup"
        Me.rdbIsGroup.UseVisualStyleBackColor = True
        '
        'rdbGrpMember
        '
        Me.rdbGrpMember.AutoSize = True
        Me.rdbGrpMember.Location = New System.Drawing.Point(100, 21)
        Me.rdbGrpMember.Name = "rdbGrpMember"
        Me.rdbGrpMember.Size = New System.Drawing.Size(92, 17)
        Me.rdbGrpMember.TabIndex = 1
        Me.rdbGrpMember.TabStop = True
        Me.rdbGrpMember.Text = "GroupMember"
        Me.rdbGrpMember.UseVisualStyleBackColor = True
        '
        'rdbIndividual
        '
        Me.rdbIndividual.AutoSize = True
        Me.rdbIndividual.Location = New System.Drawing.Point(9, 21)
        Me.rdbIndividual.Name = "rdbIndividual"
        Me.rdbIndividual.Size = New System.Drawing.Size(74, 17)
        Me.rdbIndividual.TabIndex = 0
        Me.rdbIndividual.TabStop = True
        Me.rdbIndividual.Text = "Indivudual"
        Me.rdbIndividual.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.btnApply)
        Me.GroupBox9.Controls.Add(Me.btnClear)
        Me.GroupBox9.Controls.Add(Me.btnLoanShedule)
        Me.GroupBox9.Location = New System.Drawing.Point(935, 443)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(319, 51)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Commands"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(228, 19)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(85, 23)
        Me.btnApply.TabIndex = 8
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 19)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnLoanShedule
        '
        Me.btnLoanShedule.Location = New System.Drawing.Point(9, 19)
        Me.btnLoanShedule.Name = "btnLoanShedule"
        Me.btnLoanShedule.Size = New System.Drawing.Size(102, 23)
        Me.btnLoanShedule.TabIndex = 0
        Me.btnLoanShedule.Text = "Loan Shedule"
        Me.btnLoanShedule.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.rtxtComment)
        Me.GroupBox10.Location = New System.Drawing.Point(935, 498)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(319, 102)
        Me.GroupBox10.TabIndex = 7
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Comments"
        '
        'rtxtComment
        '
        Me.rtxtComment.BackColor = System.Drawing.SystemColors.Menu
        Me.rtxtComment.ForeColor = System.Drawing.Color.Red
        Me.rtxtComment.Location = New System.Drawing.Point(6, 19)
        Me.rtxtComment.Name = "rtxtComment"
        Me.rtxtComment.Size = New System.Drawing.Size(304, 69)
        Me.rtxtComment.TabIndex = 0
        Me.rtxtComment.Text = ""
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.rdbGroupAcc)
        Me.GroupBox11.Controls.Add(Me.rdbMemberAcc)
        Me.GroupBox11.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(458, 38)
        Me.GroupBox11.TabIndex = 8
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Account Category"
        '
        'rdbMemberAcc
        '
        Me.rdbMemberAcc.AutoSize = True
        Me.rdbMemberAcc.Location = New System.Drawing.Point(29, 15)
        Me.rdbMemberAcc.Name = "rdbMemberAcc"
        Me.rdbMemberAcc.Size = New System.Drawing.Size(105, 17)
        Me.rdbMemberAcc.TabIndex = 0
        Me.rdbMemberAcc.TabStop = True
        Me.rdbMemberAcc.Text = "Member account"
        Me.rdbMemberAcc.UseVisualStyleBackColor = True
        '
        'rdbGroupAcc
        '
        Me.rdbGroupAcc.AutoSize = True
        Me.rdbGroupAcc.Location = New System.Drawing.Point(237, 15)
        Me.rdbGroupAcc.Name = "rdbGroupAcc"
        Me.rdbGroupAcc.Size = New System.Drawing.Size(97, 17)
        Me.rdbGroupAcc.TabIndex = 1
        Me.rdbGroupAcc.TabStop = True
        Me.rdbGroupAcc.Text = "Group Account"
        Me.rdbGroupAcc.UseVisualStyleBackColor = True
        '
        'lbMaxPeriod
        '
        Me.lbMaxPeriod.AutoSize = True
        Me.lbMaxPeriod.Location = New System.Drawing.Point(181, 70)
        Me.lbMaxPeriod.Name = "lbMaxPeriod"
        Me.lbMaxPeriod.Size = New System.Drawing.Size(60, 13)
        Me.lbMaxPeriod.TabIndex = 12
        Me.lbMaxPeriod.Text = "Max Period"
        '
        'txtMaxPeriod
        '
        Me.txtMaxPeriod.Enabled = False
        Me.txtMaxPeriod.Location = New System.Drawing.Point(244, 66)
        Me.txtMaxPeriod.Name = "txtMaxPeriod"
        Me.txtMaxPeriod.Size = New System.Drawing.Size(58, 20)
        Me.txtMaxPeriod.TabIndex = 13
        '
        'frmLoanApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 622)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLoanApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Loan Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rtxtAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents lblMobileNo As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAccNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridA As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridB As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRepDate As System.Windows.Forms.Label
    Friend WithEvents txtPeriod As System.Windows.Forms.TextBox
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents txtAvlAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAvlAmount As System.Windows.Forms.Label
    Friend WithEvents txtRqstAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblRqtAmount As System.Windows.Forms.Label
    Friend WithEvents dtRepDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalSaving As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalSaving As System.Windows.Forms.Label
    Friend WithEvents txtGrpContract As System.Windows.Forms.TextBox
    Friend WithEvents lblContract As System.Windows.Forms.Label
    Friend WithEvents txtGroupName As System.Windows.Forms.TextBox
    Friend WithEvents lblGroupName As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbIsGroup As System.Windows.Forms.RadioButton
    Friend WithEvents rdbGrpMember As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnLoanShedule As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents rtxtComment As System.Windows.Forms.RichTextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents rtxtPurpose As System.Windows.Forms.RichTextBox
    Friend WithEvents lblPurpose As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbGroupAcc As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMemberAcc As System.Windows.Forms.RadioButton
    Friend WithEvents txtMaxPeriod As System.Windows.Forms.TextBox
    Friend WithEvents lbMaxPeriod As System.Windows.Forms.Label
End Class
