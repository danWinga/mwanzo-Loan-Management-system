Public Class frmPayCollection
    Dim conn As New MyDb
    Dim fullname, idNo, repIdNo, accNo, perAccNo, regAmount, regRequiredAmount, groupCode, groupName, mobile, loc, address, accstatus, paidAmount As String
    Dim transid, accCategory, activity, paymode, accbalance, chequeNo, chqBankCode, memberActualSaving As String
    Dim ttamount, groupSavings, individualSaving, subAcc, dbmemberNo, selMemberNo, grpCont, checkReg As String
    Dim regtransid, regRqAmount, regpaidAmount, regbalAmount As String
    Dim paydate, chqDate As Date
    Private Sub disableItems()
        txtAccIdno.Enabled = True
        btnAccSearch.Enabled = True
        txtFullName.Enabled = False
        txtAccName.Enabled = False
        txtIdno.Enabled = False
        txtAccStatus.Enabled = False
        txtGroupName.Enabled = False
        txtResident.Enabled = False
        txtAddress.Enabled = False
        txtMobile.Enabled = False
        txtGgroupName.Enabled = False
        txtGcontact.Enabled = False

        rdbRegistration.Enabled = False
        rdbContribution.Enabled = False

        txtLastTransNo.Enabled = False
        dtLastDate.Enabled = False
        txtLastAmount.Enabled = False

        rdbCash.Enabled = False
        rdbCheque.Enabled = False

        txtChqNo.Enabled = False
        txtChqBankCode.Enabled = False
        dtChqDate.Enabled = False
        txtChqAmount.Enabled = False


        txtRegReqAmount.Enabled = False
        txtRegPaidAmount.Enabled = False

        txtContBalance.Enabled = False
        txtContAmountPd.Enabled = False

        btnSave.Enabled = False
        btnClear.Enabled = False
        btnUpdate.Enabled = False
        btnPrint.Enabled = False
        If rdbIndividual.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox3.Enabled = True
        End If
    End Sub
    Private Sub manageRdb()
        txtRegPaidAmount.Enabled = False
        txtContAmountPd.Enabled = False
        txtChqNo.Enabled = False
        txtChqBankCode.Enabled = False
        dtChqDate.Enabled = False
        txtChqAmount.Enabled = False
        If rdbRegistration.Checked = True And rdbCash.Checked = True Then
            txtRegPaidAmount.Enabled = True

        ElseIf rdbContribution.Checked = True And rdbCash.Checked = True Then
            txtContAmountPd.Enabled = True
        ElseIf rdbRegistration.Checked = True And rdbCheque.Checked = True Then
            txtChqNo.Enabled = True
            txtChqBankCode.Enabled = True
            dtChqDate.Enabled = True
            txtChqAmount.Enabled = True

        ElseIf rdbContribution.Checked = True And rdbCheque.Checked = True Then
            txtChqNo.Enabled = True
            txtChqBankCode.Enabled = True
            dtChqDate.Enabled = True
            txtChqAmount.Enabled = True
        End If
        If accNo <> "" Then
            checkRegPayment(accNo)
        Else

        End If

    End Sub
    Private Sub searchAcc()
        emptyIndvDetails()
        Dim recValue As String = ""
        recValue = Convert.ToString(txtAccIdno.Text)
        If rdbIndividual.Checked = True And rdbRegistration.Checked = True Or rdbContribution.Checked = True Then

            Dim sql = "SELECT   m.accNo, m.IdNo, m.pgoupcode, g.groupName,( m.surname +' '+ m.othernames) As fullNames,(m.mobile +' ' + m.altNo + ' ' + m.telNo) As contact,m.location, (m.address +' '+ m.code +' '+ m.county) As address, m.accstatus  FROM memberAccount AS m INNER JOIN groupTB As g  ON m.pgoupcode = g.groupcode   WHERE m.accNo = '" & recValue.Trim & "' OR m.IdNo = '" & recValue.Trim & "' "
            ' OR m.IdNo = '" & recValue.Trim & "'
            'Dim sql = "SELECT accNo,IdNo, pgoupcode,surname,othernames,dob,nationality,sex,maritalStatus,county,email,mobile,altNo,telNo,location,address,code,skype,accstatus,regdate FROM memberaccount  WHERE  accNo = '" & recValue.Trim & "'  OR  IdNo = '" & recValue.Trim & "' "
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
                loc = tbn2.Rows(0)(6)
                address = tbn2.Rows(0)(7)
                accstatus = tbn2.Rows(0)(8)
                Dim regx As Double = 2000.0
                regRequiredAmount = String.Format("{0:#,##0.00}", regx)
                txtRegReqAmount.Text = regRequiredAmount
                fillIndvDetails()
                PopulateGridA(accNo)
            Else
                MsgBox("Sorry! , No Record Found")
                PopulateGridA(accNo)
            End If

        ElseIf rdbGroupAcc.Checked = True And rdbRegistration.Checked = True Then
            Dim sql = "SELECT   groupcode,groupName, contact  FROM  groupTB   WHERE groupcode = '" & recValue.Trim & "' OR groupName = '" & recValue.Trim & "' "
            Dim tbn As String = "gp"

            conn.SelectQry(sql, tbn)
            Dim tbn2 As DataTable
            tbn2 = conn.db.Tables("gp")

            Dim valuex As Integer = 0
            If tbn2.Rows.Count <> 0 Then
                groupCode = tbn2.Rows(0)(0)
                groupName = tbn2.Rows(0)(1)

                txtGgroupName.Text = groupName
                txtGcontact.Text = tbn2.Rows(0)(2)
                Dim regx As Double = 5000.0
                regRequiredAmount = String.Format("{0:#,##0.00}", regx)
                txtRegReqAmount.Text = regRequiredAmount
                rdbCash.Enabled = True
                rdbCheque.Enabled = True
                PopulateGridA(accNo)
            Else
                MsgBox("Sorry! , No Record Found")
                PopulateGridA(accNo)
            End If
        ElseIf rdbGroupAcc.Checked = True And rdbContribution.Checked = True Then
            Dim sql = "SELECT   groupcode,groupName, contact  FROM  groupTB   WHERE groupcode = '" & recValue.Trim & "' OR groupName = '" & recValue.Trim & "' "
            Dim tbn As String = "gp"
            conn.SelectQry(sql, tbn)
            Dim tbn2 As DataTable
            tbn2 = conn.db.Tables("gp")

            Dim valuex As Integer = 0
            If tbn2.Rows.Count <> 0 Then
                groupCode = tbn2.Rows(0)(0)
                groupName = tbn2.Rows(0)(1)

                txtGgroupName.Text = groupName
                txtGcontact.Text = tbn2.Rows(0)(2)
                Dim regx As Double = 0.0
                regRequiredAmount = String.Format("{0:#,##0.00}", regx)
                txtRegReqAmount.Text = regRequiredAmount
                rdbCash.Enabled = True
                rdbCheque.Enabled = True
                PopulateGridA(accNo)
            Else
                MsgBox("Sorry! , No Record Found")
                PopulateGridA(accNo)
            End If

        Else
            MsgBox("Kindly choose    ACTIVITY   ")
        End If
    End Sub
    Private Sub fillIndvDetails()
        txtFullName.Text = fullname
        txtAccName.Text = accNo
        txtIdno.Text = idNo
        txtAccStatus.Text = accstatus
        txtGroupName.Text = groupName
        txtResident.Text = loc
        txtAddress.Text = address
        txtMobile.Text = mobile
        rdbCash.Enabled = True
        rdbCheque.Enabled = True
    End Sub
    Private Sub emptyIndvDetails()
        'rdbRegistration.Checked = False
        ' rdbContribution.Checked = False  

        idNo = ""
        groupCode = ""
        groupName = ""
        fullname = ""
        mobile = ""
        loc = ""
        address = ""
        accstatus = ""
        txtFullName.Text = ""
        txtAccName.Text = ""
        txtIdno.Text = ""
        txtAccStatus.Text = ""
        txtGroupName.Text = ""
        txtResident.Text = ""
        txtAddress.Text = ""
        txtMobile.Text = ""
        txtGgroupName.Text = ""
        txtGcontact.Text = ""
        txtRegReqAmount.Text = ""
        rdbCash.Enabled = False
        rdbCheque.Enabled = False
    End Sub
    Private Sub getTransactValue()
        paydate = Now
        paidAmount = ""
        accNo = Convert.ToString(txtAccName.Text)
        accCategory = ""
        If rdbIndividual.Checked = True Then
            accCategory = "Individual"
        ElseIf rdbGroupAcc.Checked = True Then
            accCategory = "Group"

        End If
        If rdbRegistration.Checked = True Then
            activity = "Registration"
        ElseIf rdbContribution.Checked = True Then
            activity = "Contribution"
        End If

        If rdbCash.Checked = True Then
            paymode = "Cash"
        ElseIf rdbCheque.Checked = True Then
            paymode = "Cheque"
            chequeNo = txtChqNo.Text
            chqBankCode = txtChqBankCode.Text
            paidAmount = txtChqAmount.Text
        End If
        'payment method check
        If rdbRegistration.Checked = True And rdbCash.Checked = True Then
            paidAmount = txtRegPaidAmount.Text
           
        ElseIf rdbContribution.Checked = True And rdbCash.Checked = True Then
            paidAmount = txtContAmountPd.Text
        ElseIf rdbRegistration.Checked = True And rdbCheque.Checked = True Then

            paidAmount = txtChqAmount.Text

        ElseIf rdbContribution.Checked = True And rdbCheque.Checked = True Then
            paidAmount = txtChqAmount.Text
        End If
        If paidAmount = "" Then
            MsgBox("Fill in Amount to Transact")
        
        End If
        'subAccount values 
        subAcc = ""
        If rdbIndividual.Checked = True And rdbRegistration.Checked = True Then
            subAcc = "MB001"
        ElseIf rdbIndividual.Checked = True And rdbContribution.Checked = True Then
            subAcc = "MBCNT003"
        ElseIf rdbGroupAcc.Checked = True And rdbContribution.Checked = True Then
            subAcc = "GPCNT004"
        ElseIf rdbGroupAcc.Checked = True And rdbRegistration.Checked = True Then
            subAcc = "GP002"
        End If

    End Sub
    Private Sub test()
        getTransactValue()
        MsgBox("AccNo := " & accNo + "\n" + "accCategory := " & accCategory + "\n" + "activity := " & activity)
    End Sub
    Private Sub saveData()
        'Dim trans, accCategory, activity, paymode, accbalance As String
        checkRegPayment(accNo)
        perAccNo = ""
        generateTransNo() ' generate transaction code
        perAccNo = accNo
        getTransactValue() ' fill transaction values+
        selectManageAcc(perAccNo)

        If activity = "Registration" And paymode = "Cash" Then
            registrationAcc()
        ElseIf activity = "Registration" And paymode = "Cheque" Then
            registrationAcc()
            chequePay()
        ElseIf activity = "Contribution" And paymode = "Cash" Then
            Pay()
            personalSavings()
        ElseIf activity = "Contribution" And paymode = "Cheque" Then
            Pay()
            chequePay()
            personalSavings()
        End If
        

    End Sub
    Private Sub Pay()
        
        Dim qry As String = ""
        Dim accBal As String = ""
        If activity = "Registration" Then
            accBal = "0.00"
        Else
            accBal = Convert.ToDouble(accbalance) + (Convert.ToDouble(paidAmount))
        End If
        qry = "INSERT INTO memberPayment(transId,accNo,accCategory,transactionType,payMode,payDate,amountPaid,accBalance,subAcc)" & _
        "VALUES('" & transid & "','" & accNo & "','" & accCategory & "','" & activity & "','" & paymode & "','" & paydate & "','" & paidAmount & "','" & accBal & "','" & subAcc & "' );"
        conn.Insert(qry)


    End Sub
    ' Check if registration has been paid
    Private Sub checkRegPayment(ByRef accno As String)
        regtransid = ""
        regRqAmount = "0.00"
        regpaidAmount = "0.00"
        regbalAmount = "0.00"
        Dim act As String = "Registration"
        Dim sql = "SELECT [requiredAmount], [paidAmount], [balAmount] FROM registrationAcc   WHERE [accNo] = '" & accno.Trim & "'   "
        Dim tbn As String = "rp"
        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("rp")
        If tbn2.Rows.Count > 0 Then

            regRqAmount = tbn2.Rows(0)(0)
            regpaidAmount = tbn2.Rows(0)(1)
            regbalAmount = tbn2.Rows(0)(2)

        End If

    End Sub
    ' registration account management
    Private Sub registrationAcc()
        Dim qry As String

        Dim pamount As String = ""
        regRqAmount = regRequiredAmount.Replace(",", "")
        Dim bal = "0.00"
        Dim extra As String = "0.00"
        MsgBox("regpaidAmount is:" & regpaidAmount)
        If Convert.ToDouble(regpaidAmount) < Convert.ToDouble(regbalAmount) Then
            MsgBox("reg1:" & regpaidAmount)
            bal = Convert.ToDouble(regbalAmount) - Convert.ToDouble(paidAmount)
            qry = "UPDATE registrationAcc SET paidAmount ='" & regRqAmount & "', balAmount = '" & bal & "'  WHERE [accNo] ='" & perAccNo.Trim & "';"
            conn.Insert(qry)


        ElseIf Convert.ToDouble(paidAmount) > Convert.ToDouble(regbalAmount) And Convert.ToDouble(regbalAmount) > 0.0 Then
            MsgBox("reg2:" & regpaidAmount)
            extra = Convert.ToDouble(paidAmount) - Convert.ToDouble(regbalAmount)
            qry = "UPDATE registrationAcc SET paidAmount ='" & regRqAmount & "', balAmount = '" & bal & "'  WHERE [accNo] ='" & perAccNo.Trim & "';"
            conn.Insert(qry)
            paidAmount = extra
            activity = "Contribution"
            Pay()
            personalSavings()

        ElseIf Convert.ToDouble(regRqAmount) = Convert.ToDouble(regpaidAmount) Then
            'paid registration 
            MsgBox("reg3:" & regpaidAmount)
            MsgBox("The account has paid full amount of Registration" + vbNewLine + "Will add the  amount to you account contribution")
            rtxtComment.Text = "The account has paid full amount of Registration"
            rtxtComment.ForeColor = Color.BlueViolet
            activity = "Contribution"
            Pay()
            personalSavings()

        ElseIf regpaidAmount = "0.00" Then
            MsgBox("reg4:" & regpaidAmount)
            regbalAmount = Convert.ToDouble(regRqAmount) - Convert.ToDouble(paidAmount)
            qry = "INSERT INTO registrationAcc(accNo,requiredAmount,paidAmount,balAmount )" & _
            "VALUES('" & accNo & "','" & regRqAmount & "','" & paidAmount & "','" & regbalAmount & "' );"
            conn.Insert(qry)
        Else
            MsgBox("reg5:" & regpaidAmount)
            qry = "UPDATE registrationAcc SET paidAmount ='" & regRqAmount & "', balAmount = '" & bal & "'  WHERE [accNo] ='" & perAccNo.Trim & "';"
            conn.Insert(qry)
        End If

    End Sub
    Private Sub chequePay()
        Dim qry As String
        qry = "INSERT INTO chequeTB(transId,payDate,chequeNo,bankCode,amountPaid)" & _
        "VALUES('" & transid & "','" & paydate & "','" & chequeNo & "','" & chqBankCode & "','" & paidAmount & "' );"
        conn.Insert(qry)
    End Sub

    Private Sub manageAcc()
        Dim qry As String
        ttamount = ""
        ttamount = Convert.ToDouble(accbalance) + ((Convert.ToDouble(paidAmount)) - (Convert.ToDouble(grpCont)))
        If selMemberNo = perAccNo Then
            qry = "UPDATE memberAccManager SET totalAmount ='" & ttamount & "' WHERE [memberAcc] ='" & perAccNo.Trim & "';"
            conn.Insert(qry)
        Else

            qry = "INSERT INTO memberAccManager(memberAcc,totalAmount )" & _
            "VALUES('" & perAccNo & "','" & ttamount & "' );"
            conn.Insert(qry)
        End If

    End Sub
    Private Sub personalSavings()
        Dim nePerSaving As String = ""
        Dim newGroupSaving As String = ""
        Dim qry As String
        grpCont = "0.00"
        selectPerSave(perAccNo)
        If groupCode = "00001" Then

            If perAccNo = dbmemberNo Then
                nePerSaving = Convert.ToDouble(individualSaving) + (Convert.ToDouble(paidAmount))
                newGroupSaving = "0.00"
                qry = "UPDATE personalSavings SET groupSavings ='" & newGroupSaving & "', individualSaving ='" & nePerSaving & "' WHERE [memberNo] ='" & perAccNo & "';"
                conn.Insert(qry)
               
            Else

                newGroupSaving = "0.00"
                ' MsgBox("asss: " & perAccNo)
                qry = "INSERT INTO personalSavings(memberNo,groupSavings,individualSaving )" & _
            "VALUES('" & perAccNo & "','" & newGroupSaving & "','" & paidAmount & "' );"
                conn.Insert(qry)


            End If
        ElseIf groupCode <> "00001" Then
            grpCont = "200.00"
            If perAccNo = dbmemberNo Then
                nePerSaving = Convert.ToDouble(individualSaving) + ((Convert.ToDouble(paidAmount)) - (Convert.ToDouble(grpCont)))
                newGroupSaving = Convert.ToDouble(groupSavings) + Convert.ToDouble(grpCont)
                qry = "UPDATE personalSavings SET groupSavings ='" & newGroupSaving & "', individualSaving ='" & nePerSaving & "' WHERE [memberNo] ='" & perAccNo & "';"
                conn.Insert(qry)

            Else
                newGroupSaving = grpCont
                ' MsgBox("asss: " & perAccNo)
                qry = "INSERT INTO personalSavings(memberNo,groupSavings,individualSaving )" & _
            "VALUES('" & perAccNo & "','" & newGroupSaving & "','" & newGroupSaving & "' );"
                conn.Insert(qry)

            End If

        End If
        
        manageAcc()

    End Sub
    Private Sub generalJournal()
        Dim regIndvAcc, regGrpAcc As String
        If rdbRegistration.Checked = True And rdbIndividual.Checked = True Then
            regIndvAcc = ""
            regGrpAcc = ""
        End If
        ttamount = Convert.ToDouble(paidAmount) + Convert.ToDouble(accbalance)
        Dim qry As String
        qry = "INSERT INTO memberAccManager(transDate,transNo,accounts,debit,credit )" & _
        "VALUES('" & accNo & "','" & ttamount & "' );"
        conn.Insert(qry)
    End Sub
    

    
    Private Sub selectManageAcc(ByRef accno As String)
        accbalance = "0.00"
        Dim sql = "SELECT [memberAcc] ,[totalAmount] FROM memberAccManager   WHERE [memberAcc] = '" & accno.Trim & "'   "


        Dim tbn As String = "rp"
        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("rp")
        If tbn2.Rows.Count > 0 Then
            selMemberNo = tbn2.Rows(0)(0)
            accbalance = tbn2.Rows(0)(1)

            'MsgBox("ID is:" & repaccNo)
        Else
            accbalance = "0.00"
            'MsgBox("ID is:" & repaccNo)
        End If


    End Sub
    ' individual and personal group saving
    Private Sub selectPerSave(ByRef accno As String)
        dbmemberNo = ""
        groupSavings = ""
        individualSaving = ""
        Dim sql = "SELECT [memberNo] ,[groupSavings],[individualSaving] FROM personalSavings   WHERE [memberNo] = '" & accno.Trim & "'   "
        Dim tbn As String = "rp"
        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("rp")
        If tbn2.Rows.Count > 0 Then
            dbmemberNo = tbn2.Rows(0)(0)
            groupSavings = tbn2.Rows(0)(1)
            individualSaving = tbn2.Rows(0)(2)

            'MsgBox("ID is:" & repaccNo)
        Else
            accbalance = "000.00"
            'MsgBox("ID is:" & repaccNo)
        End If


    End Sub
    

    Private Sub generateTransNo()
        transid = ""

        Dim sql = "SELECT  TOP 1 [transId] FROM memberPayment ORDER BY [payDate] DESC   "
        Dim tbn As String = "gp"
        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("gp")
        Dim cl As String
        Dim conValue As String = ""
        Dim valuex As Integer = 0
        If tbn2.Rows.Count <> 0 Then
            cl = tbn2.Rows(0)(0)
            valuex = Convert.ToInt16(cl)
            If valuex < 1 Then
                conValue = "0000000"
                transid = conValue & 1
            ElseIf valuex > 0 & valuex < 10 Then
                conValue = "0000000"
                transid = conValue & (valuex + 1)
            ElseIf valuex >= 10 & valuex < 100 Then
                conValue = "000000"
                transid = conValue & (valuex + 1)
            ElseIf valuex >= 100 & valuex < 1000 Then
                conValue = "00000"
                transid = conValue & (valuex + 1)
            ElseIf valuex >= 1000 & valuex < 10000 Then
                conValue = "0000"
                transid = conValue & (valuex + 1)
            ElseIf valuex >= 10000 & valuex < 100000 Then
                conValue = "000"
                transid = conValue & (valuex + 1)
            ElseIf valuex >= 100000 & valuex < 1000000 Then
                conValue = "00"
                transid = conValue & (valuex + 1)
            ElseIf valuex >= 1000000 & valuex < 10000000 Then
                conValue = "0"
                transid = conValue & (valuex + 1)
            ElseIf valuex >= 10000000 Then

                transid = (valuex + 1)

            End If
            'MsgBox(recValue)
        Else
            conValue = "0000000"
            transid = conValue & 1
            ' MsgBox(accNo)

        End If
        MsgBox(transid)
    End Sub
    Public Sub PopulateGridA(ByRef accno As String)


        On Error Resume Next
        ' WHERE accNo = '" & accno.Trim & "' 
        Dim sql = "SELECT transId, transactionType,payMode,payDate,amountPaid FROM memberPayment   ORDER BY [payDate] DESC   "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)

        GridA.Columns(0).DataPropertyName = "transId"
        GridA.Columns(1).DataPropertyName = "transactionType"
        GridA.Columns(2).DataPropertyName = "payMode"
        GridA.Columns(3).DataPropertyName = "payDate"
        GridA.Columns(4).DataPropertyName = "amountPaid"

        GridA.DataSource = rs


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub

    Private Sub frmPayCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmRegistration.Close()

        disableItems()

    End Sub

    Private Sub rdbIndividual_CheckedChanged(sender As Object, e As EventArgs) Handles rdbIndividual.CheckedChanged
        disableItems()
        emptyIndvDetails()
        rdbRegistration.Enabled = True
        rdbRegistration.Checked = False
        rdbContribution.Enabled = True
        rdbContribution.Checked = False
    End Sub

    Private Sub rdbRegistration_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRegistration.CheckedChanged
        txtAccIdno.Enabled = True
        btnAccSearch.Enabled = True
        manageRdb()
        rtxtComment.Text = ""
        
        
    End Sub

    Private Sub rdbContribution_CheckedChanged(sender As Object, e As EventArgs) Handles rdbContribution.CheckedChanged
        txtAccIdno.Enabled = True
        btnAccSearch.Enabled = True
        rtxtComment.Text = ""
        txtRegReqAmount.Text = "0.00"

        manageRdb()
    End Sub

    Private Sub rdbGroupAcc_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGroupAcc.CheckedChanged
        disableItems()
        emptyIndvDetails()
        rdbRegistration.Enabled = True
        rdbRegistration.Checked = False
        rdbContribution.Enabled = True
        rdbContribution.Checked = False
    End Sub

    Private Sub rdbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCash.CheckedChanged
        btnSave.Enabled = True
        btnClear.Enabled = True
        manageRdb()
        

    End Sub

    Private Sub rdbCheque_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCheque.CheckedChanged

       manageRdb()
       

        
    End Sub

    Private Sub btnAccSearch_Click(sender As Object, e As EventArgs) Handles btnAccSearch.Click
        If txtAccIdno.Text <> "" Then
            searchAcc()
            txtAccIdno.Text = ""

        Else
            MsgBox(" Sorry ! Enter ACCOUNT NO OR IDNo  then Search again")
            accNo = ""
            PopulateGridA(accNo)
            GridA.Refresh()


        End If
        
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveData()
        disableItems()
    End Sub

    Private Sub txtAccIdno_TextChanged(sender As Object, e As EventArgs) Handles txtAccIdno.TextChanged

    End Sub
End Class