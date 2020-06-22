Public Class frmNextOfKin
    Dim conn As New MyDb

    Dim acc, nxtSur, nxtOthr, nxtRel, nxtShare, nxtAddress, nxtMobile As String
    Private Sub nxtClear()
        txtnxtSurname.Text = ""
        txtnxtOthernames.Text = ""
        txtnxtRelation.Text = ""
        txtnxMobile.Text = ""
        txtnxtPercent.Text = ""
        txtnxtAddress.Text = ""


    End Sub
    Private Sub nxtDisable()
        txtnxtSurname.Enabled = False
        txtnxtOthernames.Enabled = False
        txtnxtRelation.Enabled = False
        txtnxMobile.Enabled = False
        txtnxtPercent.Enabled = False
        txtnxtAddress.Enabled = False


    End Sub
    Private Sub nxtEnable()
        txtnxtSurname.Enabled = True
        txtnxtOthernames.Enabled = True
        txtnxtRelation.Enabled = True
        txtnxMobile.Enabled = True
        txtnxtPercent.Enabled = True
        txtnxtAddress.Enabled = True


    End Sub
    Private Sub assValues()
        nxtSur = Convert.ToString(txtnxtSurname.Text)
        nxtOthr = Convert.ToString(txtnxtOthernames.Text)
        nxtRel = Convert.ToString(txtnxtRelation.Text)
        nxtShare = Convert.ToString(txtnxtPercent.Text)
        nxtAddress = Convert.ToString(txtnxtAddress.Text)
        nxtMobile = Convert.ToString(txtnxMobile.Text)
        acc = Convert.ToString(txtNxtAccNo.Text)
    End Sub

    Private Sub btNxtSave_Click(sender As Object, e As EventArgs) Handles btNxtSave.Click
        Dim qry As String
        Dim regd As Date = Now

        assValues()


        qry = "INSERT INTO nextofKin(surname,othernames,relation,mobileNo,address,percentage,accNo)" & _
        "VALUES('" & nxtSur & "','" & nxtOthr & "','" & nxtRel & "','" & nxtMobile & "','" & nxtAddress & "','" & nxtShare & "','" & acc & "');"
        If nxtSur = "" Or nxtOthr = "" Or nxtAddress = "" Or acc = "" Or nxtMobile = "" Then

            MsgBox("Fill in all details before saving")
        Else
            conn.Insert(qry)
            frmRegistration.PopulateGridNxtOfKin(acc)
            'MsgBox("New NextOfKin Added Successful")
            nxtDisable()

        End If
    End Sub
   
    Private Sub btNxtClear_Click(sender As Object, e As EventArgs) Handles btNxtClear.Click
        frmRegistration.PopulateGridNxtOfKin(acc)
        nxtClear()
        nxtEnable()
        btNxtUpdate.Enabled = False
        btNxtDelete.Enabled = False
    End Sub
End Class