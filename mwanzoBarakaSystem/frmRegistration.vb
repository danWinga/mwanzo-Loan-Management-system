Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataAdapter
Imports System.Data.OleDb.OleDbCommand
Public Class frmRegistration
    Inherits System.Windows.Forms.Form
    Dim conn As New MyDb
    Dim sname, otName, idNo, repIdNo, accNo, repaccNo, selaccNo, groupCode, selGrpCode, nationality, sex, maritalStatus, county, email, mobile, altno, telno, loc, address, adcode, skype, accstatus As String
    Dim dob, regDate As Date
    Dim gpGroupName, gpContact, gpConPerson, gpAddress, gpGroupCode, repGpName, repGpNo As String

    Dim accValue As String
    Private Sub genGpCode()

        Dim recValue As String = "record0"

        Dim sql = "SELECT  TOP 1 [groupcode] FROM groupTB   ORDER BY [ID] DESC   "
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
                conValue = "0000"
                gpGroupCode = conValue & 1
            ElseIf valuex > 0 & valuex < 10 Then
                conValue = "0000"
                gpGroupCode = conValue & (valuex + 1)
            ElseIf valuex >= 10 & valuex < 100 Then
                conValue = "000"
                gpGroupCode = conValue & (valuex + 1)
            ElseIf valuex >= 100 & valuex < 1000 Then
                conValue = "00"
                gpGroupCode = conValue & (valuex + 1)
            ElseIf valuex >= 1000 & valuex < 10000 Then
                conValue = "0"
                gpGroupCode = conValue & (valuex + 1)
            ElseIf valuex >= 10000 Then
                conValue = ""
                gpGroupCode = (valuex + 1)
           

            End If
            'MsgBox(recValue)
        Else
            conValue = "0000"
            gpGroupCode = conValue & 1
            ' MsgBox(accNo)

        End If

    End Sub
    'group Assign Avalues
    Private Sub gpAssignValues()

        gpGroupName = Convert.ToString(txtGpGroupName.Text)
        gpContact = Convert.ToString(txtGpContact.Text)
        gpConPerson = Convert.ToString(txtGpContPerson.Text)
        gpAddress = Convert.ToString(txtGpAddress.text)
        

    End Sub
    Private Sub gpClearValues()

        txtGpGroupName.Text = ""
        txtGpContact.Text = ""
        txtGpContPerson.Text = ""
        txtGpAddress.Text = ""
        gpGroupCode = ""
        btnGpSave.Enabled = True

    End Sub
    Private Sub checkGpRepValues(ByRef gpname As String)
        repGpName = ""
        repGpNo = ""
        Dim sql = "SELECT   [groupcode], [groupName] FROM groupTB   WHERE [groupName] = '" & gpname.Trim & "'   "
        Dim tbn As String = "rp"
        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("rp")
        If tbn2.Rows.Count > 0 Then
            repGpNo = tbn2.Rows(0)(0)
            repGpName = tbn2.Rows(0)(1)
            'MsgBox("ID is:" & repaccNo)
        Else
            repaccNo = "RECORD DOES NOT Exist"
            'MsgBox("ID is:" & repaccNo)
        End If


    End Sub
    Public Sub PopulateGridGroup()
        btnGpSave.Enabled = False

        btnGpDelete.Enabled = False
        btnGpUpdate.Enabled = False
        On Error Resume Next

        Dim sql = "SELECT groupcode,groupName,contact,address,contactPerson,regDate FROM groupTB   ORDER BY [ID] DESC   "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)

        GridG1.Columns(0).DataPropertyName = "groupcode"
        GridG1.Columns(1).DataPropertyName = "groupName"
        GridG1.Columns(2).DataPropertyName = "contact"
        GridG1.Columns(3).DataPropertyName = "address"
        GridG1.Columns(4).DataPropertyName = "contactPerson"
        GridG1.Columns(5).DataPropertyName = "regDate"
       
        GridG1.DataSource = rs

    End Sub
    Private Sub gpAddValue()
        gpAssignValues()
        Dim gpType As Integer = 3
        Dim regd As Date = Now
        genGpCode()

        Dim qry = "INSERT INTO groupTB(groupcode,groupTypeId,groupName,contact,address,contactPerson,regDate )" & _
        "VALUES('" & gpGroupCode & "','" & gpType & "','" & gpGroupName & "','" & gpContact & "','" & gpAddress & "','" & gpConPerson & "',  '" & regd & "');"

        If gpGroupCode = "" Or gpGroupName = "" Or gpContact = "" Or gpAddress = "" Then
            MsgBox("Sorry! Fill in all empty Fields then try ")
        Else

            checkGpRepValues(gpGroupName)
            If repGpName = "" Then
                conn.Insert(qry)
                MsgBox("RECORD SAVED")
                GridG1.DataSource = Nothing
                PopulateGridGroup()

            Else
                MsgBox("Sorry! RECORD EXIST ")

            End If
        End If
    End Sub
    ' Update group record 
    Private Sub updateGroup()
        gpAssignValues()
        Dim qry As String = ""
        Dim gpType As Integer = 3
        Dim regd As Date = Now

        qry = "UPDATE groupTB SET  groupName ='" & gpGroupName & "', contact ='" & gpContact & "', address ='" & gpAddress & "', contactPerson ='" & gpConPerson & "' WHERE [groupcode] ='" & gpGroupCode & "'"

        If gpGroupCode = "" Or gpGroupName = "" Or gpContact = "" Or gpAddress = "" Then
            MsgBox("Sorry! Fill in all empty Fields then try ")
        Else

            checkGpRepValues(gpGroupName)
            If repGpName = "" Then
                conn.Insert(qry)

                GridG1.DataSource = Nothing
                PopulateGridGroup()

            ElseIf repGpName = gpGroupName Then
                conn.Insert(qry)
                MsgBox("RECORD UPDATED")
                GridG1.DataSource = Nothing
                PopulateGridGroup()
            Else
                MsgBox("Sorry! RECORD EXIST ")

            End If
        End If

    End Sub
    'Delete Group
    Private Sub deleteGroup()

        Dim qry As String = ""
        qry = "DELETE FROM groupTB WHERE [groupcode] ='" & gpGroupCode & "'"
        
        If gpGroupCode <> "" Then
            Try
                conn.Insert(qry)
                GridG1.DataSource = Nothing
                PopulateGridGroup()
            Catch ex As Exception
                
            End Try
            

        Else
            MsgBox("Sorry! DELETE ALL MEMBERS UNDER THE GROUP FIRST ")

        End If

    End Sub
    Public Sub popGroupName()
        Dim sql = "SELECT groupcode, groupName FROM groupTB WHERE groupTypeId = 3  "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)
        cmbGroupName.DataSource = rs
        cmbGroupName.ValueMember = "groupcode"
        cmbGroupName.DisplayMember = "groupName"
     

    End Sub
    Public Sub PopulateGridLMembers()

        btnNewNxtOfKin.Enabled = False
        btnNxtOfKinEdit.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        On Error Resume Next

        GridA.DataSource = Nothing
        Dim sql = "SELECT accNo,IdNo, pgoupcode,surname,othernames,dob,nationality,sex,maritalStatus,county,email,mobile,altNo,telNo,location,address,code,skype,accstatus,regdate FROM memberaccount   ORDER BY [ID] DESC   "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)

        GridA.Columns(0).DataPropertyName = "accNo"
        GridA.Columns(1).DataPropertyName = "IdNo"
        GridA.Columns(2).DataPropertyName = "pgoupcode"
        GridA.Columns(3).DataPropertyName = "surname"
        GridA.Columns(4).DataPropertyName = "othernames"
        GridA.Columns(5).DataPropertyName = "dob"
        GridA.Columns(6).DataPropertyName = "nationality"
        GridA.Columns(7).DataPropertyName = "sex"
        GridA.Columns(8).DataPropertyName = "maritalStatus"
        GridA.Columns(9).DataPropertyName = "county"
        GridA.Columns(10).DataPropertyName = "email"
        GridA.Columns(11).DataPropertyName = "mobile"
        GridA.Columns(12).DataPropertyName = "altNo"
        GridA.Columns(13).DataPropertyName = "telNo"
        GridA.Columns(14).DataPropertyName = "location"
        GridA.Columns(15).DataPropertyName = "address"
        GridA.Columns(16).DataPropertyName = "code"
        GridA.Columns(17).DataPropertyName = "skype"
        GridA.Columns(18).DataPropertyName = "accstatus"
        GridA.Columns(19).DataPropertyName = "regdate"

        GridA.DataSource = rs

    End Sub
    Private Sub checkRepValues(ByRef accid As String)
        repIdNo = ""
        repaccNo = ""
        Dim sql = "SELECT   [accNo], [IdNo] FROM memberaccount   WHERE [IdNo] = '" & accid.Trim & "'   "
        Dim tbn As String = "rp"
        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("rp")
        If tbn2.Rows.Count > 0 Then
            repaccNo = tbn2.Rows(0)(0)
            repIdNo = tbn2.Rows(0)(1)
            'MsgBox("ID is:" & repaccNo)
        Else
            repaccNo = "RECORD DOES NOT Exist"
            'MsgBox("ID is:" & repaccNo)
        End If
        

    End Sub
    Private Sub generateAccNo()

        Dim recValue As String = "record0"
        Dim sql = "SELECT  TOP 1 [accNo] FROM memberaccount   ORDER BY [ID] DESC   "
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
                conValue = "00000000"
                accNo = conValue & 1
            ElseIf valuex > 0 & valuex < 10 Then
                conValue = "0000000"
                accNo = conValue & (valuex + 1)
            ElseIf valuex >= 10 & valuex < 100 Then
                conValue = "000000"
                accNo = conValue & (valuex + 1)
            ElseIf valuex >= 100 & valuex < 1000 Then
                conValue = "00000"
                accNo = conValue & (valuex + 1)
            ElseIf valuex >= 1000 & valuex < 10000 Then
                conValue = "0000"
                accNo = conValue & (valuex + 1)
            ElseIf valuex >= 10000 & valuex < 100000 Then
                conValue = "000"
                accNo = conValue & (valuex + 1)
            ElseIf valuex >= 100000 & valuex < 1000000 Then
                conValue = "00"
                accNo = conValue & (valuex + 1)
            ElseIf valuex >= 1000000 & valuex < 10000000 Then
                conValue = "0"
                accNo = conValue & (valuex + 1)
            ElseIf valuex >= 10000000 Then

                accNo = (valuex + 1)
            
            End If
            'MsgBox(recValue)
        Else
            conValue = "00000000"
            accNo = conValue & 1
            ' MsgBox(accNo)

        End If

    End Sub

    Private Sub AssignValues()

        sname = Convert.ToString(txtSurName.Text).Replace("'", "''")
        otName = Convert.ToString(txtOtherNames.Text)

        If rdbIndividual.Checked Then
            groupCode = "00001"
        Else
            MsgBox("grp :" & selGrpCode)
            Dim sl As String = cmbGroupName.SelectedValue.ToString

            getSectedGrpCode(selGrpCode)

        End If
        dob = cmbDob.Value.ToShortDateString
        sex = Convert.ToString(cmbGender.SelectedItem)
        nationality = Convert.ToString(txtNationality.Text)
        maritalStatus = Convert.ToString(cmbMaritalStatus.SelectedItem)
        county = Convert.ToString(txtCounty.Text)
        email = Convert.ToString(txtEmail.Text)
        mobile = Convert.ToString(txtMobileNo.Text)
        altno = Convert.ToString(txtAltNo.Text)
        loc = Convert.ToString(txtLocation.Text)
        idNo = Convert.ToString(txtIdNo.Text)
        address = Convert.ToString(txtAddress.Text)
        adcode = Convert.ToString(txtCode.Text)
        skype = Convert.ToString(txtSkpe.Text)
        accstatus = ""
        If rdbActive.Checked Then
            accstatus = "Active"
        ElseIf rdbDormant.Checked Then
            accstatus = "Dormant"
        ElseIf rdbWithdrawn.Checked Then
            accstatus = "Withdrawn"
        ElseIf rdbDeceased.Checked Then
            accstatus = "Deceased"
        End If
        telno = Convert.ToString(txtTelNo.Text)

    End Sub
    Private Sub getSectedGrpCode(ByRef grpcd As String)
        Dim sd As String = "uwezo1"
        groupCode = ""
        Dim sql = "SELECT   [groupcode]  FROM groupTB   WHERE [groupName] = '" & grpcd.Trim & "'   "
        Dim tbn As String = "rp"
        conn.SelectQry(sql, tbn)
        Dim tbn2 As DataTable
        tbn2 = conn.db.Tables("rp")
        If tbn2.Rows.Count > 0 Then
            groupCode = tbn2.Rows(0)(0)
            
        Else

            'MsgBox("ID is:" & repaccNo)
        End If

    End Sub
    Private Sub regclear()

        txtSurName.Text = ""
        txtOtherNames.Text = ""
        Dim thisDay As Date = Date.Today
        cmbDob.Value = thisDay
        txtNationality.Text = ""
        cmbGender.SelectedItem = Nothing
        cmbMaritalStatus.SelectedItem = Nothing
        txtCounty.Text = ""
        txtEmail.Text = ""
        txtMobileNo.Text = ""
        txtAltNo.Text = ""
        txtLocation.Text = ""
        txtAddress.Text = ""
        txtCode.Text = ""
        txtSkpe.Text = ""
        accNo = ""
        txtIdNo.Text = ""

    End Sub
    Private Sub PopulateGridM(ByVal grpCd As String)

        On Error Resume Next

        Dim sql = "SELECT accNo,IdNo,( surname +' '+ othernames) As fullNames,sex,(mobile +', ' + altNo + ', ' + telNo) As contact,(address +' '+ code +' '+ county) As address,accstatus,regdate FROM memberaccount where pgoupcode = '" & grpCd.Trim & "'    ORDER BY [ID] DESC   "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)

        GridM.Columns(0).DataPropertyName = "accNo"
        GridM.Columns(1).DataPropertyName = "idNo"
        GridM.Columns(2).DataPropertyName = "fullNames"
        GridM.Columns(3).DataPropertyName = "sex"
        GridM.Columns(4).DataPropertyName = "contact"
        GridM.Columns(5).DataPropertyName = "address"
        GridM.Columns(6).DataPropertyName = "accstatus"
        GridM.Columns(7).DataPropertyName = "regdate"

        GridM.DataSource = rs

    End Sub

    Private Sub searchGridM(ByVal grpCd As String, ByVal mAcc As String)

        On Error Resume Next

        Dim sql = "SELECT accNo,IdNo,( surname +' '+ othernames) As fullNames,sex,(mobile +', ' + altNo + ', ' + telNo) As contact,(address +' '+ code +' '+ county) As address,accstatus,regdate FROM memberaccount where pgoupcode = '" & grpCd.Trim & "' and accNo = '" & mAcc.Trim & "' or IdNo = '" & mAcc.Trim & "'   ORDER BY [ID] DESC   "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)

        GridM.Columns(0).DataPropertyName = "accNo"
        GridM.Columns(1).DataPropertyName = "idNo"
        GridM.Columns(2).DataPropertyName = "fullNames"
        GridM.Columns(3).DataPropertyName = "sex"
        GridM.Columns(4).DataPropertyName = "contact"
        GridM.Columns(5).DataPropertyName = "address"
        GridM.Columns(6).DataPropertyName = "accstatus"
        GridM.Columns(7).DataPropertyName = "regdate"

        GridM.DataSource = rs

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbSurname.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbOtherNames.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        Dim qry As String
        Dim regd As Date = Now
        lblStatus.Text = ""
        AssignValues()
        generateAccNo()

        qry = "INSERT INTO memberaccount(accNo,IdNo,pgoupcode,surname,othernames,dob,nationality,sex,maritalStatus,county,email,mobile,altNo,telNo,location,address,code,skype,accstatus,regdate)" & _
        "VALUES('" & accNo & "','" & idNo & "','" & groupCode & "','" & sname & "','" & otName & "','" & dob & "','" & nationality & "','" & sex & "','" & maritalStatus & "','" & county & "','" & email & "','" & mobile & "','" & altno & "','" & telno & "','" & loc & "','" & address & "','" & adcode & "','" & skype & "','" & accstatus & "','" & regd & "');"
        If idNo = "" Or accNo = "" Or groupCode = "" Or sname = "" Or nationality = "" Or sex = "" Or county = "" Or mobile = "" Then
            lblStatus.Text = "Fill in all details before saving"
            MsgBox("Fill in all details before saving")
        Else
            checkRepValues(idNo)
            If repIdNo = idNo Then
                MsgBox("Sorry!, RECORD  Exist")
            Else
                conn.Insert(qry)
                MsgBox("RECORD SAVED")
                'conn.creates(qry)
                PopulateGridLMembers()

            End If
            
        End If



    End Sub

    Private Sub rdbIndividual_CheckedChanged(sender As Object, e As EventArgs) Handles rdbIndividual.CheckedChanged
        cmbGroupName.Enabled = False

    End Sub

    Private Sub rdbGroup_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGroup.CheckedChanged
        cmbGroupName.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnAddNew.Enabled = True
        btnNewNxtOfKin.Enabled = False
        btnNxtOfKinEdit.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        regclear()
        Dim xc As String = "379393394"
        checkRepValues(xc)
        generateAccNo()




    End Sub

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frmPayCollection.Close()
        PopulateGridLMembers()
        popGroupName()
        PopulateGridGroup()
        gpClearValues()
        btnGpMSearch.Enabled = False
        btnGpMRefresh.Enabled = False
        txtGpMSearch.Enabled = False
    End Sub
    ' update member records 
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim qry As String
        Dim regd As Date = Now
        lblStatus.Text = ""
        AssignValues()

        groupCode = selGrpCode
        qry = "UPDATE memberaccount SET IdNo ='" & idNo & "', pgoupcode ='" & groupCode & "', surname ='" & sname & "', othernames ='" & otName & "', dob ='" & dob & "', nationality ='" & nationality & "', sex ='" & sex & "', maritalStatus ='" & maritalStatus & "', county ='" & county & "', email ='" & email & "', mobile ='" & mobile & "',altNo ='" & altno & "', telNo ='" & telno & "', location ='" & loc & "', address ='" & address & "', code ='" & adcode & "', skype ='" & skype & "', accstatus ='" & accstatus & "' WHERE [accNo] ='" & accNo & "'"
        
        If idNo = "" Or accNo = "" Or groupCode = "" Or sname = "" Or nationality = "" Or sex = "" Or county = "" Or mobile = "" Then
            lblStatus.Text = "Fill in all details before saving"
            MsgBox("Fill in all details before saving")
            
        Else
            checkRepValues(idNo)
            If (repIdNo = idNo And repaccNo = accNo) Then
                conn.Insert(qry)
                MsgBox("RECORD SAVED")
                PopulateGridLMembers()
            ElseIf (repIdNo = "") Then
                conn.Insert(qry)
                MsgBox("RECORD SAVED")
                PopulateGridLMembers()
            End If

        End If
        PopulateGridLMembers()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql = "SELECT  TOP 1 [accNo] FROM memberaccount   ORDER BY [ID] DESC   "
        Dim tbN As String = "gp"
        Dim dt As DataTable
        dt = conn.db.Tables("gp")
        conn.generateAccNo(dt, sql, tbN)
        MsgBox(conn.generateAccNo(dt, sql, tbN))
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub

    
    Private Sub GridA_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridA.CellClick
        ' MsgBox("Testing")
        Dim sr As String = ""
        If e.ColumnIndex <> 0 Then
            Try
                ' MsgBox(GridA.Rows(e.RowIndex.ToString).Cells(3).Value)
                sr = Convert.ToString(GridA.Rows(e.RowIndex.ToString).Cells(3).Value)

                'Dim x As String = GridA.Rows(e.RowIndex.ToString).Cells(0).Value
                accNo = GridA.Rows(e.RowIndex.ToString).Cells(0).Value
                txtIdNo.Text = GridA.Rows(e.RowIndex.ToString).Cells(1).Value
                'Dim gp As String = GridA.Rows(e.RowIndex.ToString).Cells(2).Value
                'MsgBox(sr)
                txtSurName.Text = GridA.Rows(e.RowIndex.ToString).Cells(3).Value
                txtOtherNames.Text = GridA.Rows(e.RowIndex.ToString).Cells(4).Value
                cmbDob.Value = Convert.ToDateTime(GridA.Rows(e.RowIndex.ToString).Cells(5).Value)
                txtNationality.Text = GridA.Rows(e.RowIndex.ToString).Cells(6).Value
                cmbGender.SelectedItem = GridA.Rows(e.RowIndex.ToString).Cells(7).Value
                cmbMaritalStatus.SelectedItem = GridA.Rows(e.RowIndex.ToString).Cells(8).Value
                txtCounty.Text = GridA.Rows(e.RowIndex.ToString).Cells(9).Value
                txtEmail.Text = GridA.Rows(e.RowIndex.ToString).Cells(10).Value
                txtMobileNo.Text = GridA.Rows(e.RowIndex.ToString).Cells(11).Value
                txtAltNo.Text = GridA.Rows(e.RowIndex.ToString).Cells(12).Value
                txtTelNo.Text = GridA.Rows(e.RowIndex.ToString).Cells(13).Value
                txtLocation.Text = GridA.Rows(e.RowIndex.ToString).Cells(14).Value
                txtAddress.Text = GridA.Rows(e.RowIndex.ToString).Cells(15).Value
                txtCode.Text = GridA.Rows(e.RowIndex.ToString).Cells(16).Value
                txtSkpe.Text = GridA.Rows(e.RowIndex.ToString).Cells(17).Value
                Dim accstatus As String = GridA.Rows(e.RowIndex.ToString).Cells(18).Value

                If accstatus = "Active" Then
                    rdbActive.Checked = True
                ElseIf accstatus = "Dormant" Then
                    rdbDormant.Checked = True
                ElseIf accstatus = "Withdrawn" Then
                    rdbWithdrawn.Checked = True
                ElseIf accstatus = "Deceased" Then
                    rdbDeceased.Checked = True
                End If
                btnAddNew.Enabled = False
                btnNewNxtOfKin.Enabled = True
                btnNxtOfKinEdit.Enabled = True
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                PopulateGridNxtOfKin(accNo)
                Dim indiv As String = "00001"
                Dim gpacc As String = GridA.Rows(e.RowIndex.ToString).Cells(2).Value
                If gpacc = indiv Then
                    rdbIndividual.Checked = True
                Else

                End If



            Catch ex As Exception

            End Try
        End If
    End Sub
    Public Sub PopulateGridNxtOfKin(ByRef acc As String)

        On Error Resume Next

        Dim sql = "SELECT ID,surname,othernames,relation,mobileNo,address,percentage,accNo FROM nextofKin WHERE accNO = '" & acc.Trim & "'  ORDER BY [ID] DESC   "
        Dim td As String = "accm"
        Dim rs As DataTable = Nothing
        conn.SelectQry(sql, td)
        rs = conn.SelectQry(sql, td)

        dGridN.Columns(0).DataPropertyName = "ID"
        dGridN.Columns(1).DataPropertyName = "surname"
        dGridN.Columns(2).DataPropertyName = "othernames"
        dGridN.Columns(3).DataPropertyName = "relation"
        dGridN.Columns(4).DataPropertyName = "mobileNo"
        dGridN.Columns(5).DataPropertyName = "address"
        dGridN.Columns(6).DataPropertyName = "percentage"

        dGridN.DataSource = rs

    End Sub
    

    
    
    Private Sub btnNewNxtOfKin_Click(sender As Object, e As EventArgs) Handles btnNewNxtOfKin.Click
        frmNextOfKin.txtNxtAccNo.Text = accNo
        frmNextOfKin.txtNxtAccNo.Enabled = False
        frmNextOfKin.Show()

    End Sub

    Private Sub GridG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridG1.CellClick


        Dim sr As String = ""
        If e.ColumnIndex <> 0 Then
            Try

                gpGroupCode = Convert.ToString(GridG1.Rows(e.RowIndex.ToString).Cells(0).Value)

                txtGpGroupName.Text = GridG1.Rows(e.RowIndex.ToString).Cells(1).Value
                txtGpContact.Text = GridG1.Rows(e.RowIndex.ToString).Cells(2).Value

                txtGpAddress.Text = GridG1.Rows(e.RowIndex.ToString).Cells(3).Value
                txtGpContPerson.Text = GridG1.Rows(e.RowIndex.ToString).Cells(4).Value

                btnGpSave.Enabled = False
                btnGpDelete.Enabled = True
                btnGpUpdate.Enabled = True

                PopulateGridM(gpGroupCode)
                btnGpMSearch.Enabled = True
                btnGpMRefresh.Enabled = True
                txtGpMSearch.Enabled = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub cmbGroupName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroupName.SelectedIndexChanged
        selGrpCode = cmbGroupName.SelectedValue.ToString

        getSectedGrpCode(selGrpCode)

    End Sub

    Private Sub btnGpClear_Click(sender As Object, e As EventArgs) Handles btnGpClear.Click
        btnGpSave.Enabled = True
        btnGpDelete.Enabled = False
        btnGpUpdate.Enabled = False
        txtGpGroupName.Text = ""
        txtGpContPerson.Text = ""
        txtGpAddress.Text = ""
        txtGpContact.Text = ""

    End Sub

    Private Sub GridA_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles GridA.CellContentClick

    End Sub

    Private Sub btnGpSave_Click(sender As Object, e As EventArgs) Handles btnGpSave.Click
        gpAddValue()
    End Sub

   
    Private Sub btnGpMSearch_Click(sender As Object, e As EventArgs) Handles btnGpMSearch.Click
        Dim sd As String = txtGpMSearch.Text
        searchGridM(gpGroupCode, sd)
    End Sub

    Private Sub btnGpMRefresh_Click(sender As Object, e As EventArgs) Handles btnGpMRefresh.Click
        PopulateGridGroup()
        txtGpMSearch.Text = ""
        Dim sd As String = txtGpMSearch.Text
        searchGridM(gpGroupCode, sd)
        btnGpMSearch.Enabled = False
        btnGpMRefresh.Enabled = False
        txtGpMSearch.Enabled = False
    End Sub

    Private Sub btnGpUpdate_Click(sender As Object, e As EventArgs) Handles btnGpUpdate.Click
        updateGroup()
        PopulateGridGroup()
    End Sub

    Private Sub btnGpDelete_Click(sender As Object, e As EventArgs) Handles btnGpDelete.Click
        deleteGroup()
    End Sub
End Class