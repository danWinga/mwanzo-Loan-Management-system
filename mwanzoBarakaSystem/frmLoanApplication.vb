Public Class frmLoanApplication
    Dim conn As New MyDb
    Dim loanCode, accIndiv, accMmbeGrp, category, accGrp, searchValue, accNo, idNo, groupCode, groupName, fullname, mobile, Loc, address, accstatus, regRequiredAmount, grpContact, totalSavings, purpose As String
    Dim loanRqAmount, maxLoanAmount, rate, duration, amountpaid, loanBalance, accTatus, mainGrpId As String
    Dim repayStartDate As Date
    Dim P, MT, MP, MI, J, R, PB As Double
    Dim MPX, MIX, PBX As Double
    Dim index, T, N As Integer
    Private Sub genLoanCode()

        Dim recValue As String = "record0"

        Dim sql = "SELECT  TOP 1 [loanCode] FROM loan   ORDER BY [sysDate] DESC   "
        Dim tbn As String = "ln"
        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("ln")
        Dim cl As String
        Dim conValue As String = ""
        Dim valuex As Integer = 0
        If tbn2.Rows.Count <> 0 Then
            cl = tbn2.Rows(0)(0)
            valuex = Convert.ToInt16(cl)
            If valuex < 1 Then
                conValue = "0000"
                loanCode = conValue & 1
            ElseIf valuex > 0 & valuex < 10 Then
                conValue = "0000"
                loanCode = conValue & (valuex + 1)
            ElseIf valuex >= 10 & valuex < 100 Then
                conValue = "000"
                loanCode = conValue & (valuex + 1)
            ElseIf valuex >= 100 & valuex < 1000 Then
                conValue = "00"
                loanCode = conValue & (valuex + 1)
            ElseIf valuex >= 1000 & valuex < 10000 Then
                conValue = "0"
                loanCode = conValue & (valuex + 1)
            ElseIf valuex >= 10000 Then
                conValue = ""
                loanCode = (valuex + 1)

            End If
            'MsgBox(recValue)
        Else
            conValue = "0000"
            loanCode = conValue & 1
            ' MsgBox(accNo)

        End If

    End Sub
    ' check loanee account group
    Private Sub chooseAccGroup()
        mainGrpId = ""
        accIndiv = ""
        accMmbeGrp = ""
        accGrp = ""
        accGrp = ""
        If rdbIndividual.Checked = True Then
            accIndiv = "1"
            category = accIndiv
        ElseIf rdbGrpMember.Checked = True Then
            accMmbeGrp = "2"
            category = accMmbeGrp
        ElseIf rdbIsGroup.Checked = True Then
            accGrp = "3"
            category = accGrp
        End If

    End Sub
    Private Sub searchAcc()

        searchValue = Convert.ToString(txtSearch.Text)
        If searchValue = "" Then
            MsgBox("Enter Account No. or ID No, then try again ")
        Else
            If rdbMemberAcc.Checked = True Then
                Dim sql = "SELECT   m.accNo, m.IdNo, m.pgoupcode, g.groupName,( m.surname +' '+ m.othernames) As fullNames,(m.mobile +' ' + m.altNo + ' ' + m.telNo) As contact,m.location, (m.address +' '+ m.code +' '+ m.county) As address, m.accstatus,g.contact  FROM memberAccount AS m INNER JOIN groupTB As g  ON m.pgoupcode = g.groupcode    WHERE m.accNo = '" & searchValue.Trim & "' OR m.IdNo = '" & searchValue.Trim & "' "
                ' Dim sql = "SELECT   groupcode,groupName, contact  FROM  groupTB   WHERE groupcode = '" & accNo.Trim & "' OR groupName = '" & accN .Trim & "' "
                Dim tbn As String = "gp"

                conn.SelectQry(sql, tbn)
                Dim tbn2 As DataTable
                tbn2 = conn.db.Tables("gp")

                If tbn2.Rows.Count <> 0 Then
                    accNo = tbn2.Rows(0)(0)
                    idNo = tbn2.Rows(0)(1)
                    groupCode = tbn2.Rows(0)(2)
                    groupName = tbn2.Rows(0)(3)
                    fullname = tbn2.Rows(0)(4)
                    mobile = tbn2.Rows(0)(5)
                    Loc = tbn2.Rows(0)(6)
                    address = tbn2.Rows(0)(7)
                    accstatus = tbn2.Rows(0)(8)
                    grpContact = tbn2.Rows(0)(9)
                    getAccGroupDetails()
                    PopulateGridB(accNo)
                    PopulateGridA(accNo)
                Else
                    MsgBox("Sorry! No member Account / ID found ")
                End If
            ElseIf rdbGroupAcc.Checked = True Then

                'Dim sql = "SELECT   m.accNo, m.IdNo, m.pgoupcode, g.groupName,( m.surname +' '+ m.othernames) As fullNames,(m.mobile +' ' + m.altNo + ' ' + m.telNo) As contact,m.location, (m.address +' '+ m.code +' '+ m.county) As address, m.accstatus,g.contact  FROM memberAccount AS m INNER JOIN groupTB As g  ON m.pgoupcode = g.groupcode    WHERE m.accNo = '" & searchValue.Trim & "' OR m.IdNo = '" & searchValue.Trim & "' "
                Dim sql = "SELECT   groupcode,groupTypeId,groupName, contact  FROM  groupTB  WHERE groupcode = '" & searchValue.Trim & "' OR groupName = '" & searchValue.Trim & "' "
                Dim tbn As String = "gp"
                conn.SelectQry(sql, tbn)
                Dim tbn2 As DataTable
                tbn2 = conn.db.Tables("gp")

                If tbn2.Rows.Count <> 0 Then
                    accNo = tbn2.Rows(0)(0)
                    groupCode = tbn2.Rows(0)(0)
                    accGrp = tbn2.Rows(0)(1)
                    groupName = tbn2.Rows(0)(2)
                    grpContact = tbn2.Rows(0)(3)
                    MsgBox("groupcode: " & accNo)
                    getAccGroupDetails()
                    PopulateGridB(accNo)
                    PopulateGridA(accNo)
                    rdbIsGroup.Checked = True
                Else
                    MsgBox("Sorry! No member Account / ID found ")
                End If


            End If

        End If
        



    End Sub
    Private Sub tSavings()

        Dim recValue As String = ""
        searchValue = Convert.ToString(txtSearch.Text)
       
        Dim sql = "SELECT  totalAmount  FROM memberAccManager     WHERE memberAcc = '" & accNo.Trim & "'  "

        Dim tbn As String = "gp"

        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("gp")

        If tbn2.Rows.Count <> 0 Then
            totalSavings = tbn2.Rows(0)(0)
            'MsgBox("total Savings :" & totalSavings)

        Else

            rtxtComment.Text = "No Savings has been made to this account"
            txtTotalSaving.Text = ""
        End If

    End Sub
    Private Sub getAccGroupDetails()
        tSavings()
        If groupCode = "00001" And rdbMemberAcc.Checked = True Then
            rdbIndividual.Checked = True
            txtGroupName.Enabled = False
            txtGrpContract.Enabled = False
            txtGroupName.Text = ""
            txtGrpContract.Text = ""
        ElseIf accGrp = "3" And rdbGroupAcc.Checked = True Then
            txtGroupName.Enabled = True
            txtGrpContract.Enabled = True
            txtGroupName.Text = groupName
            txtGrpContract.Text = grpContact
            rdbIsGroup.Checked = True
        Else
            rdbGrpMember.Checked = True
            txtGroupName.Enabled = True
            txtGrpContract.Enabled = True
            txtGroupName.Text = groupName
            txtGrpContract.Text = grpContact

        End If
        Dim regx = Convert.ToDouble(totalSavings)
        Dim ttAmount = String.Format("{0:#,##0.00}", regx)
        txtTotalSaving.Text = ttAmount


    End Sub
    Private Sub fillfields()
        txtFullName.Text = fullname
        txtAccNumber.Text = accNo
        txtMobileNo.Text = mobile
        rtxtAddress.Text = Loc + vbNewLine + address

    End Sub
    Private Sub clearfields()
        txtFullName.Text = ""
        txtAccNumber.Text = ""
        txtMobileNo.Text = ""
        rtxtAddress.Text = ""
        rdbGrpMember.Checked = False
        rdbIndividual.Checked = False
        txtGroupName.Text = ""
        txtTotalSaving.Text = ""
        txtGrpContract.Text = ""
        accNo = ""
        totalSavings = "0.00"


    End Sub
    'populate transaction records GRIDB
    Public Sub PopulateGridB(ByRef accno As String)

        On Error Resume Next
        Dim cont As String = "Contribution"
        Dim sql = "SELECT transId, payMode,payDate,amountPaid FROM memberPayment WHERE  transactionType='" & cont & "' And accNo ='" & accno & "'  ORDER BY [payDate] DESC   "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)

        GridB.Columns(0).DataPropertyName = "transId"
        GridB.Columns(1).DataPropertyName = "payMode"
        GridB.Columns(2).DataPropertyName = "payDate"
        GridB.Columns(3).DataPropertyName = "amountPaid"

        GridB.DataSource = rs

    End Sub
    'populate loan records GRIDA
    Public Sub PopulateGridA(ByRef accno As String)


        On Error Resume Next

        Dim sql = "SELECT loanCode, principalAmount,duration,purpose, amountPaid,balanceAmount,sysDate,repaymentDate,loanStatus FROM loan WHERE   accNo ='" & accno & "'  ORDER BY [sysDate] DESC   "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)

        GridA.Columns(0).DataPropertyName = "loanCode"
        GridA.Columns(1).DataPropertyName = "principalAmount"
        GridA.Columns(2).DataPropertyName = "duration"
        GridA.Columns(3).DataPropertyName = "purpose"
        GridA.Columns(4).DataPropertyName = "amountPaid"
        GridA.Columns(5).DataPropertyName = "balanceAmount"
        GridA.Columns(6).DataPropertyName = "sysDate"
        GridA.Columns(7).DataPropertyName = "repaymentDate"
        GridA.Columns(8).DataPropertyName = "loanStatus"
        GridA.DataSource = rs

    End Sub
    ' calculate maximum loan amount
    Private Sub getMaxLoanAmount()
        maxLoanAmount = "0.00"
        rate = "0"
        duration = "0"
        If rdbIndividual.Checked = True Then
            Dim valuex As Double = Convert.ToDouble(totalSavings) * 3
            maxLoanAmount = String.Format("{0:#,##0.00}", valuex)
            txtAvlAmount.Text = maxLoanAmount
            rate = 12
            txtRate.Text = rate
            txtMaxPeriod.Text = "3 yrs"
        ElseIf rdbGrpMember.Checked = True Then
            Dim valuex As Double = Convert.ToDouble(totalSavings) * 4
            maxLoanAmount = String.Format("{0:#,##0.00}", valuex)
            txtAvlAmount.Text = maxLoanAmount
            rate = 1
            txtRate.Text = rate
            txtMaxPeriod.Text = "4 yrs"

        ElseIf rdbIsGroup.Checked = True Then

            Dim valuex As Double = Convert.ToDouble(totalSavings) * 3
            maxLoanAmount = String.Format("{0:#,##0.00}", valuex)
            txtAvlAmount.Text = maxLoanAmount
            rate = 0.8
            txtRate.Text = rate
            txtMaxPeriod.Text = "4 yrs"
        End If
    End Sub
    Private Sub calcMonthlyPayment(ByRef p1 As Double, ByRef r1 As Double, ByRef d1 As Integer)

        P = p1
        R = r1 / 100
        J = R / 12 ' J = effective interest rate
        T = d1  ' in months
        N = T ' converting in month
        MT = P * (J / (1 - (1 + J) ^ -N))

        PB = 0 ' PB = Principal Balance 
        index = 1
        Do While P > 0
            PB = P
            MI = PB * J ' MI = 1st month Interest
            MP = MT - MI ' MP2 = 1st month Principal
            PB = P - MP

            MPX = Math.Round(MP, 2, MidpointRounding.AwayFromZero)
            MIX = Math.Round(MI, 2, MidpointRounding.AwayFromZero)
            PBX = Math.Round(PB, 2, MidpointRounding.AwayFromZero)

            If PBX > 0 Then
                saveloanShedule()
            Else

            End If

            P = PB
            index = index + 1
            repayStartDate = repayStartDate.AddDays(30)
        Loop

    End Sub
    ' monthly principal amount 

    Private Sub getFields()
        accNo = txtAccNumber.Text
        loanRqAmount = txtRqstAmount.Text
        rate = txtRate.Text
        duration = txtPeriod.Text
        repayStartDate = Convert.ToDateTime(dtRepDate.Text)
        totalSavings = txtTotalSaving.Text
        maxLoanAmount = txtAvlAmount.Text
        purpose = rtxtPurpose.Text
        amountpaid = "0.00"
        accstatus = "NOTPAID"
        chooseAccGroup()
        
    End Sub
    Private Sub checkLoanPeriod()


        getFields()
        If accNo = "" Or purpose = "" Then
            MsgBox("Sorry , Search for a correct account , then try again ")
        ElseIf loanRqAmount = 0 Or rate = 0 Or duration = 0 Or maxLoanAmount = 0 Then
            MsgBox("Sorry , Not qualified for a loan ")
        ElseIf loanRqAmount > 0 And rate > 0 And duration > 0 And maxLoanAmount > 0 Then

            genLoanCode()
            loanStatusCheck(accNo)
            loanBalance = loanRqAmount

            If rdbIndividual.Checked = True Then
                If duration > (3 * 12) Then
                    MsgBox("Maximum loan repayment period is 3 years ( 36 months)")
                Else
                    loanSaving()

                End If

            ElseIf rdbGrpMember.Checked = True Then
                If duration > (4 * 12) Then
                    MsgBox("Maximum loan repayment period is 4 years ( 48 months)")
                Else
                    loanSaving()

                End If

            ElseIf rdbIsGroup.Checked = True Then

                If duration > (5 * 12) Then
                    MsgBox("Maximum loan repayment period is 4 years ( 60 months)")
                Else
                    loanSaving()

                End If
            End If
        End If
    End Sub
    Private Sub loanSaving()
        Dim qry As String
        Dim sysDate As Date = Now
        If accTatus = "" And loanRqAmount < maxLoanAmount Then
            qry = "INSERT INTO loan(loanCode,accNo,groupCategoryId,principalAmount,rate,duration,purpose,amountPaid,balanceAmount,sysDate,repaymentDate,loanStatus)" & _
  "VALUES('" & loanCode & "','" & accNo & "','" & category & "','" & loanRqAmount & "','" & rate & "','" & duration & "','" & purpose & "','" & amountpaid & "','" & loanBalance & "','" & sysDate & "','" & repayStartDate & "','" & accstatus & "' );"
            conn.Insert(qry)
            calcMonthlyPayment(loanRqAmount, rate, duration)
        ElseIf loanRqAmount > maxLoanAmount Then
            MsgBox("Sorry, The account qualifies for this amount :  " & maxLoanAmount)

        Else
            MsgBox("Sorry, Kindly clear the outstanding loan arears  ")

        End If
            

    End Sub
    Private Sub saveloanShedule()
        Dim status = "NOTPAID"
        Dim qry As String
        qry = "INSERT INTO loanShedule(indexID,loanCode,repayDueDate,interestAmount,monthlyPincipal,principalBal,status)" & _
       "VALUES('" & index & "','" & loanCode & "','" & repayStartDate & "','" & MIX & "','" & MPX & "','" & PBX & "','" & status & "' );"
        conn.Insert(qry)

    End Sub
    Private Sub loanStatusCheck(ByRef accno As String)
        Dim sts As String = "NOTPAID"
        If accno <> "" Then
            Dim sql = "SELECT  loanCode,loanStatus  FROM loan  WHERE loanStatus = '" & sts.Trim & "' AND  accNo = '" & accno.Trim & "' "
            ' Dim sql = "SELECT loanCode, status FROM loan WHERE  transactionType='" & cont & "' And accNo ='" & accno & "'  ORDER BY [payDate] DESC   "
            Dim tbn As String = "gp"

            conn.SelectQry(sql, tbn)
            Dim tbn2 As DataTable
            tbn2 = conn.db.Tables("gp")

            If tbn2.Rows.Count <> 0 Then
                accTatus = tbn2.Rows(0)(1)
               
            Else
                accTatus = ""
            End If
        Else
            MsgBox("Enter Account No. or ID No, then try again ")

        End If



    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblRepDate.Click

    End Sub

    Private Sub frmLoanApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        clearfields()
        searchAcc()
        fillfields()
        getMaxLoanAmount()
    End Sub

    Private Sub txtRqstAmount_TextChanged(sender As Object, e As EventArgs) Handles txtRqstAmount.TextChanged
        'Dim value As String = txtRqstAmount.Text
        'If value = "" Then
        'value = 0.0
        'End If
        'loanRqAmount = value.Replace(",", "")
        'Dim regx = Convert.ToDouble(loanRqAmount)
        'txtRqstAmount.Text = String.Format("{0:#,##0.00}", regx)


    End Sub
    

    Private Sub txtPeriod_TextChanged(sender As Object, e As EventArgs) Handles txtPeriod.TextChanged
    
    End Sub

    Private Sub btnLoanShedule_Click(sender As Object, e As EventArgs) Handles btnLoanShedule.Click
        If txtRqstAmount.Text = "" Or txtPeriod.Text = "" Then
            MsgBox("Sorry! Fill in the the missing values , then try again ")
            rtxtComment.Text = "Sorry! Fill in the the missing values , then try again "
        Else
           

            frmShedule.loanamount = txtRqstAmount.Text
            frmShedule.loaRate = txtRate.Text
            frmShedule.loanperiod = txtPeriod.Text
            frmShedule.Show()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'repayStartDate = Convert.ToDateTime(repayStartDate.AddDays(30))

        repayStartDate = Convert.ToDateTime(dtRepDate.Text)
        Dim today As System.DateTime
        Dim answer As System.DateTime

        today = System.DateTime.Now
        answer = repayStartDate.AddDays(36)
        repayStartDate = repayStartDate.AddDays(31)
        MsgBox("New Date is : " & repayStartDate)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        checkLoanPeriod()
    End Sub
End Class