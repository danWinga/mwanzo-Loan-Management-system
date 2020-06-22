<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayCollection
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
        Me.btnAccSearch = New System.Windows.Forms.Button()
        Me.txtAccIdno = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAccStatus = New System.Windows.Forms.TextBox()
        Me.lbAccStatus = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.txtIdno = New System.Windows.Forms.TextBox()
        Me.lbGroupName = New System.Windows.Forms.Label()
        Me.lbIDno = New System.Windows.Forms.Label()
        Me.txtAccName = New System.Windows.Forms.TextBox()
        Me.lbAccName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lbFullName = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbContribution = New System.Windows.Forms.RadioButton()
        Me.rdbRegistration = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbGroupAcc = New System.Windows.Forms.RadioButton()
        Me.rdbIndividual = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.lbMobile = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.txtResident = New System.Windows.Forms.TextBox()
        Me.lbResident = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtLastAmount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtLastDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLastTransNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.txtContAmountPd = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtContBalance = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtRegPaidAmount = New System.Windows.Forms.TextBox()
        Me.txtRegReqAmount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.dtChqDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtChqAmount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtChqBankCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtChqNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rdbCheque = New System.Windows.Forms.RadioButton()
        Me.rdbCash = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GridA = New System.Windows.Forms.DataGridView()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSrchTransNo = New System.Windows.Forms.TextBox()
        Me.btnSrchTransNo = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.rtxtComment = New System.Windows.Forms.RichTextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.txtGcontact = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtGgroupName = New System.Windows.Forms.TextBox()
        Me.lbGgroupNme = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.GridA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAccSearch)
        Me.GroupBox1.Controls.Add(Me.txtAccIdno)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "search "
        '
        'btnAccSearch
        '
        Me.btnAccSearch.Location = New System.Drawing.Point(192, 16)
        Me.btnAccSearch.Name = "btnAccSearch"
        Me.btnAccSearch.Size = New System.Drawing.Size(112, 23)
        Me.btnAccSearch.TabIndex = 1
        Me.btnAccSearch.Text = "Acc No/IDNo"
        Me.btnAccSearch.UseVisualStyleBackColor = True
        '
        'txtAccIdno
        '
        Me.txtAccIdno.Location = New System.Drawing.Point(6, 17)
        Me.txtAccIdno.Name = "txtAccIdno"
        Me.txtAccIdno.Size = New System.Drawing.Size(180, 20)
        Me.txtAccIdno.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAccStatus)
        Me.GroupBox2.Controls.Add(Me.lbAccStatus)
        Me.GroupBox2.Controls.Add(Me.txtGroupName)
        Me.GroupBox2.Controls.Add(Me.txtIdno)
        Me.GroupBox2.Controls.Add(Me.lbGroupName)
        Me.GroupBox2.Controls.Add(Me.lbIDno)
        Me.GroupBox2.Controls.Add(Me.txtAccName)
        Me.GroupBox2.Controls.Add(Me.lbAccName)
        Me.GroupBox2.Controls.Add(Me.txtFullName)
        Me.GroupBox2.Controls.Add(Me.lbFullName)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 145)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Holder Information"
        '
        'txtAccStatus
        '
        Me.txtAccStatus.Location = New System.Drawing.Point(85, 97)
        Me.txtAccStatus.Name = "txtAccStatus"
        Me.txtAccStatus.Size = New System.Drawing.Size(218, 20)
        Me.txtAccStatus.TabIndex = 7
        '
        'lbAccStatus
        '
        Me.lbAccStatus.AutoSize = True
        Me.lbAccStatus.Location = New System.Drawing.Point(7, 99)
        Me.lbAccStatus.Name = "lbAccStatus"
        Me.lbAccStatus.Size = New System.Drawing.Size(59, 13)
        Me.lbAccStatus.TabIndex = 6
        Me.lbAccStatus.Text = "Acc Status"
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(85, 120)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(218, 20)
        Me.txtGroupName.TabIndex = 7
        '
        'txtIdno
        '
        Me.txtIdno.Location = New System.Drawing.Point(85, 72)
        Me.txtIdno.Name = "txtIdno"
        Me.txtIdno.Size = New System.Drawing.Size(218, 20)
        Me.txtIdno.TabIndex = 5
        '
        'lbGroupName
        '
        Me.lbGroupName.AutoSize = True
        Me.lbGroupName.Location = New System.Drawing.Point(8, 122)
        Me.lbGroupName.Name = "lbGroupName"
        Me.lbGroupName.Size = New System.Drawing.Size(67, 13)
        Me.lbGroupName.TabIndex = 6
        Me.lbGroupName.Text = "Group Name"
        '
        'lbIDno
        '
        Me.lbIDno.AutoSize = True
        Me.lbIDno.Location = New System.Drawing.Point(7, 74)
        Me.lbIDno.Name = "lbIDno"
        Me.lbIDno.Size = New System.Drawing.Size(30, 13)
        Me.lbIDno.TabIndex = 4
        Me.lbIDno.Text = "IdNo"
        '
        'txtAccName
        '
        Me.txtAccName.Location = New System.Drawing.Point(86, 46)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.Size = New System.Drawing.Size(218, 20)
        Me.txtAccName.TabIndex = 3
        '
        'lbAccName
        '
        Me.lbAccName.AutoSize = True
        Me.lbAccName.Location = New System.Drawing.Point(7, 48)
        Me.lbAccName.Name = "lbAccName"
        Me.lbAccName.Size = New System.Drawing.Size(78, 13)
        Me.lbAccName.TabIndex = 2
        Me.lbAccName.Text = "Account Name"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(86, 19)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(218, 20)
        Me.txtFullName.TabIndex = 1
        '
        'lbFullName
        '
        Me.lbFullName.AutoSize = True
        Me.lbFullName.Location = New System.Drawing.Point(6, 21)
        Me.lbFullName.Name = "lbFullName"
        Me.lbFullName.Size = New System.Drawing.Size(59, 13)
        Me.lbFullName.TabIndex = 0
        Me.lbFullName.Text = "Full Names"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbContribution)
        Me.GroupBox3.Controls.Add(Me.rdbRegistration)
        Me.GroupBox3.Location = New System.Drawing.Point(334, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 45)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choose Activity"
        '
        'rdbContribution
        '
        Me.rdbContribution.AutoSize = True
        Me.rdbContribution.Location = New System.Drawing.Point(122, 14)
        Me.rdbContribution.Name = "rdbContribution"
        Me.rdbContribution.Size = New System.Drawing.Size(81, 17)
        Me.rdbContribution.TabIndex = 1
        Me.rdbContribution.TabStop = True
        Me.rdbContribution.Text = "Contribution"
        Me.rdbContribution.UseVisualStyleBackColor = True
        '
        'rdbRegistration
        '
        Me.rdbRegistration.AutoSize = True
        Me.rdbRegistration.Location = New System.Drawing.Point(13, 17)
        Me.rdbRegistration.Name = "rdbRegistration"
        Me.rdbRegistration.Size = New System.Drawing.Size(81, 17)
        Me.rdbRegistration.TabIndex = 0
        Me.rdbRegistration.TabStop = True
        Me.rdbRegistration.Text = "Registration"
        Me.rdbRegistration.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdbGroupAcc)
        Me.GroupBox4.Controls.Add(Me.rdbIndividual)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 46)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Choose Account Category"
        '
        'rdbGroupAcc
        '
        Me.rdbGroupAcc.AutoSize = True
        Me.rdbGroupAcc.Location = New System.Drawing.Point(193, 19)
        Me.rdbGroupAcc.Name = "rdbGroupAcc"
        Me.rdbGroupAcc.Size = New System.Drawing.Size(97, 17)
        Me.rdbGroupAcc.TabIndex = 11
        Me.rdbGroupAcc.TabStop = True
        Me.rdbGroupAcc.Text = "Group Account"
        Me.rdbGroupAcc.UseVisualStyleBackColor = True
        '
        'rdbIndividual
        '
        Me.rdbIndividual.AutoSize = True
        Me.rdbIndividual.Location = New System.Drawing.Point(11, 19)
        Me.rdbIndividual.Name = "rdbIndividual"
        Me.rdbIndividual.Size = New System.Drawing.Size(118, 17)
        Me.rdbIndividual.TabIndex = 10
        Me.rdbIndividual.TabStop = True
        Me.rdbIndividual.Text = "Individual Accounts"
        Me.rdbIndividual.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtMobile)
        Me.GroupBox5.Controls.Add(Me.lbMobile)
        Me.GroupBox5.Controls.Add(Me.txtAddress)
        Me.GroupBox5.Controls.Add(Me.lbAddress)
        Me.GroupBox5.Controls.Add(Me.txtResident)
        Me.GroupBox5.Controls.Add(Me.lbResident)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 266)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(315, 114)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contact Information"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(85, 81)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(218, 20)
        Me.txtMobile.TabIndex = 9
        '
        'lbMobile
        '
        Me.lbMobile.AutoSize = True
        Me.lbMobile.Location = New System.Drawing.Point(7, 83)
        Me.lbMobile.Name = "lbMobile"
        Me.lbMobile.Size = New System.Drawing.Size(55, 13)
        Me.lbMobile.TabIndex = 8
        Me.lbMobile.Text = "Mobile No"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(85, 54)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(218, 20)
        Me.txtAddress.TabIndex = 7
        '
        'lbAddress
        '
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Location = New System.Drawing.Point(7, 56)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(45, 13)
        Me.lbAddress.TabIndex = 6
        Me.lbAddress.Text = "Address"
        '
        'txtResident
        '
        Me.txtResident.Location = New System.Drawing.Point(85, 26)
        Me.txtResident.Name = "txtResident"
        Me.txtResident.Size = New System.Drawing.Size(218, 20)
        Me.txtResident.TabIndex = 5
        '
        'lbResident
        '
        Me.lbResident.AutoSize = True
        Me.lbResident.Location = New System.Drawing.Point(7, 28)
        Me.lbResident.Name = "lbResident"
        Me.lbResident.Size = New System.Drawing.Size(49, 13)
        Me.lbResident.TabIndex = 4
        Me.lbResident.Text = "Resident"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtLastAmount)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.dtLastDate)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtLastTransNo)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(334, 63)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(494, 76)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Last Transaction Record"
        '
        'txtLastAmount
        '
        Me.txtLastAmount.Location = New System.Drawing.Point(288, 41)
        Me.txtLastAmount.Name = "txtLastAmount"
        Me.txtLastAmount.Size = New System.Drawing.Size(173, 20)
        Me.txtLastAmount.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(283, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Amount "
        '
        'dtLastDate
        '
        Me.dtLastDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtLastDate.Location = New System.Drawing.Point(155, 41)
        Me.dtLastDate.Name = "dtLastDate"
        Me.dtLastDate.Size = New System.Drawing.Size(115, 20)
        Me.dtLastDate.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(158, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Date"
        '
        'txtLastTransNo
        '
        Me.txtLastTransNo.Location = New System.Drawing.Point(13, 42)
        Me.txtLastTransNo.Name = "txtLastTransNo"
        Me.txtLastTransNo.Size = New System.Drawing.Size(136, 20)
        Me.txtLastTransNo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TransactionNo"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnPrint)
        Me.GroupBox7.Controls.Add(Me.btnUpdate)
        Me.GroupBox7.Controls.Add(Me.btnClear)
        Me.GroupBox7.Controls.Add(Me.btnSave)
        Me.GroupBox7.Controls.Add(Me.GroupBox12)
        Me.GroupBox7.Controls.Add(Me.GroupBox11)
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Location = New System.Drawing.Point(334, 145)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(494, 434)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Payment"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(379, 392)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(109, 31)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(265, 392)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 31)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 392)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 31)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(24, 392)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 31)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.GroupBox14)
        Me.GroupBox12.Controls.Add(Me.GroupBox13)
        Me.GroupBox12.Location = New System.Drawing.Point(6, 176)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(471, 210)
        Me.GroupBox12.TabIndex = 2
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Cash Payment"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.txtContAmountPd)
        Me.GroupBox14.Controls.Add(Me.Label19)
        Me.GroupBox14.Controls.Add(Me.txtContBalance)
        Me.GroupBox14.Controls.Add(Me.Label18)
        Me.GroupBox14.Location = New System.Drawing.Point(18, 112)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(430, 90)
        Me.GroupBox14.TabIndex = 5
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Contribution"
        '
        'txtContAmountPd
        '
        Me.txtContAmountPd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContAmountPd.Location = New System.Drawing.Point(170, 52)
        Me.txtContAmountPd.Name = "txtContAmountPd"
        Me.txtContAmountPd.Size = New System.Drawing.Size(251, 29)
        Me.txtContAmountPd.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = " Amount Paid"
        '
        'txtContBalance
        '
        Me.txtContBalance.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContBalance.Location = New System.Drawing.Point(170, 25)
        Me.txtContBalance.Name = "txtContBalance"
        Me.txtContBalance.Size = New System.Drawing.Size(251, 28)
        Me.txtContBalance.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Account Balance"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Label17)
        Me.GroupBox13.Controls.Add(Me.txtRegPaidAmount)
        Me.GroupBox13.Controls.Add(Me.txtRegReqAmount)
        Me.GroupBox13.Controls.Add(Me.Label16)
        Me.GroupBox13.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(433, 84)
        Me.GroupBox13.TabIndex = 4
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Registration"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Amount Paid"
        '
        'txtRegPaidAmount
        '
        Me.txtRegPaidAmount.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegPaidAmount.Location = New System.Drawing.Point(173, 48)
        Me.txtRegPaidAmount.Name = "txtRegPaidAmount"
        Me.txtRegPaidAmount.Size = New System.Drawing.Size(251, 28)
        Me.txtRegPaidAmount.TabIndex = 3
        '
        'txtRegReqAmount
        '
        Me.txtRegReqAmount.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegReqAmount.Location = New System.Drawing.Point(173, 18)
        Me.txtRegReqAmount.Name = "txtRegReqAmount"
        Me.txtRegReqAmount.Size = New System.Drawing.Size(251, 28)
        Me.txtRegReqAmount.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Required Amount"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.dtChqDate)
        Me.GroupBox11.Controls.Add(Me.Label15)
        Me.GroupBox11.Controls.Add(Me.txtChqAmount)
        Me.GroupBox11.Controls.Add(Me.Label14)
        Me.GroupBox11.Controls.Add(Me.txtChqBankCode)
        Me.GroupBox11.Controls.Add(Me.Label13)
        Me.GroupBox11.Controls.Add(Me.txtChqNo)
        Me.GroupBox11.Controls.Add(Me.Label12)
        Me.GroupBox11.Location = New System.Drawing.Point(6, 81)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(472, 86)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Cheque Details"
        '
        'dtChqDate
        '
        Me.dtChqDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtChqDate.Location = New System.Drawing.Point(195, 41)
        Me.dtChqDate.Name = "dtChqDate"
        Me.dtChqDate.Size = New System.Drawing.Size(115, 20)
        Me.dtChqDate.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(198, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Dated"
        '
        'txtChqAmount
        '
        Me.txtChqAmount.Location = New System.Drawing.Point(335, 41)
        Me.txtChqAmount.Name = "txtChqAmount"
        Me.txtChqAmount.Size = New System.Drawing.Size(111, 20)
        Me.txtChqAmount.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(332, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Amount Paid"
        '
        'txtChqBankCode
        '
        Me.txtChqBankCode.Location = New System.Drawing.Point(123, 41)
        Me.txtChqBankCode.Name = "txtChqBankCode"
        Me.txtChqBankCode.Size = New System.Drawing.Size(66, 20)
        Me.txtChqBankCode.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(120, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "BankCode"
        '
        'txtChqNo
        '
        Me.txtChqNo.Location = New System.Drawing.Point(17, 40)
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(100, 20)
        Me.txtChqNo.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ChequeNo"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.rdbCheque)
        Me.GroupBox10.Controls.Add(Me.rdbCash)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(472, 56)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Mode of Payment"
        '
        'rdbCheque
        '
        Me.rdbCheque.AutoSize = True
        Me.rdbCheque.Location = New System.Drawing.Point(202, 19)
        Me.rdbCheque.Name = "rdbCheque"
        Me.rdbCheque.Size = New System.Drawing.Size(62, 17)
        Me.rdbCheque.TabIndex = 2
        Me.rdbCheque.TabStop = True
        Me.rdbCheque.Text = "Cheque"
        Me.rdbCheque.UseVisualStyleBackColor = True
        '
        'rdbCash
        '
        Me.rdbCash.AutoSize = True
        Me.rdbCash.Location = New System.Drawing.Point(6, 19)
        Me.rdbCash.Name = "rdbCash"
        Me.rdbCash.Size = New System.Drawing.Size(49, 17)
        Me.rdbCash.TabIndex = 1
        Me.rdbCash.TabStop = True
        Me.rdbCash.Text = "Cash"
        Me.rdbCash.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GridA)
        Me.GroupBox9.Location = New System.Drawing.Point(842, 145)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(393, 434)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Transaction Record"
        '
        'GridA
        '
        Me.GridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridA.Location = New System.Drawing.Point(6, 19)
        Me.GridA.Name = "GridA"
        Me.GridA.Size = New System.Drawing.Size(381, 431)
        Me.GridA.TabIndex = 0
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label23)
        Me.GroupBox15.Controls.Add(Me.Label22)
        Me.GroupBox15.Controls.Add(Me.Label21)
        Me.GroupBox15.Controls.Add(Me.Label20)
        Me.GroupBox15.Location = New System.Drawing.Point(620, 12)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(615, 45)
        Me.GroupBox15.TabIndex = 9
        Me.GroupBox15.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(469, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(127, 21)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "10,000,000.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(310, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(159, 18)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Total Contribution :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(159, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 21)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "10,000,000.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(155, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Total Registration :"
        '
        'txtSrchTransNo
        '
        Me.txtSrchTransNo.Location = New System.Drawing.Point(6, 22)
        Me.txtSrchTransNo.Name = "txtSrchTransNo"
        Me.txtSrchTransNo.Size = New System.Drawing.Size(234, 20)
        Me.txtSrchTransNo.TabIndex = 2
        '
        'btnSrchTransNo
        '
        Me.btnSrchTransNo.Location = New System.Drawing.Point(249, 19)
        Me.btnSrchTransNo.Name = "btnSrchTransNo"
        Me.btnSrchTransNo.Size = New System.Drawing.Size(125, 23)
        Me.btnSrchTransNo.TabIndex = 3
        Me.btnSrchTransNo.Text = "Search Transaction"
        Me.btnSrchTransNo.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnSrchTransNo)
        Me.GroupBox8.Controls.Add(Me.txtSrchTransNo)
        Me.GroupBox8.Location = New System.Drawing.Point(842, 63)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(393, 61)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Search Transaction"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.rtxtComment)
        Me.GroupBox16.Location = New System.Drawing.Point(7, 476)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(315, 101)
        Me.GroupBox16.TabIndex = 10
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Comments"
        '
        'rtxtComment
        '
        Me.rtxtComment.BackColor = System.Drawing.SystemColors.Menu
        Me.rtxtComment.Location = New System.Drawing.Point(10, 16)
        Me.rtxtComment.Name = "rtxtComment"
        Me.rtxtComment.Size = New System.Drawing.Size(293, 78)
        Me.rtxtComment.TabIndex = 0
        Me.rtxtComment.Text = ""
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.txtGcontact)
        Me.GroupBox17.Controls.Add(Me.Label24)
        Me.GroupBox17.Controls.Add(Me.txtGgroupName)
        Me.GroupBox17.Controls.Add(Me.lbGgroupNme)
        Me.GroupBox17.Location = New System.Drawing.Point(7, 382)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(317, 88)
        Me.GroupBox17.TabIndex = 10
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Group Details"
        '
        'txtGcontact
        '
        Me.txtGcontact.Location = New System.Drawing.Point(85, 53)
        Me.txtGcontact.Name = "txtGcontact"
        Me.txtGcontact.Size = New System.Drawing.Size(218, 20)
        Me.txtGcontact.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 53)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Contacts"
        '
        'txtGgroupName
        '
        Me.txtGgroupName.Location = New System.Drawing.Point(85, 26)
        Me.txtGgroupName.Name = "txtGgroupName"
        Me.txtGgroupName.Size = New System.Drawing.Size(218, 20)
        Me.txtGgroupName.TabIndex = 5
        '
        'lbGgroupNme
        '
        Me.lbGgroupNme.AutoSize = True
        Me.lbGgroupNme.Location = New System.Drawing.Point(7, 28)
        Me.lbGgroupNme.Name = "lbGgroupNme"
        Me.lbGgroupNme.Size = New System.Drawing.Size(67, 13)
        Me.lbGgroupNme.TabIndex = 4
        Me.lbGgroupNme.Text = "Group Name"
        '
        'frmPayCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 622)
        Me.Controls.Add(Me.GroupBox17)
        Me.Controls.Add(Me.GroupBox16)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPayCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Payment Collection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.GridA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAccSearch As System.Windows.Forms.Button
    Friend WithEvents txtAccIdno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAccStatus As System.Windows.Forms.TextBox
    Friend WithEvents lbAccStatus As System.Windows.Forms.Label
    Friend WithEvents txtIdno As System.Windows.Forms.TextBox
    Friend WithEvents lbIDno As System.Windows.Forms.Label
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents lbAccName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lbFullName As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbContribution As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRegistration As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGroupName As System.Windows.Forms.TextBox
    Friend WithEvents lbGroupName As System.Windows.Forms.Label
    Friend WithEvents rdbGroupAcc As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lbMobile As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lbAddress As System.Windows.Forms.Label
    Friend WithEvents txtResident As System.Windows.Forms.TextBox
    Friend WithEvents lbResident As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dtLastDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLastTransNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLastAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCheque As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCash As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents dtChqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtChqAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtChqBankCode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtChqNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContAmountPd As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtContBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRegPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtRegReqAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GridA As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSrchTransNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSrchTransNo As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents rtxtComment As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtGgroupName As System.Windows.Forms.TextBox
    Friend WithEvents lbGgroupNme As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
