Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataAdapter
Imports System.Data.OleDb.OleDbCommand

Public Class frmStart
    Dim conn As New MyDb

    Public Role, User, Login, sectedAccNo As String
    Dim i, r, r2, y As Integer
    
    Dim nkey, Vkey As String
    Dim rs As DataTable
    Dim frm As Form
    Dim vbResponse
    


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
     
    End Sub

    Private Sub GroupRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupRegistrationToolStripMenuItem.Click
        Try
            Dim tempChild As Form = Me.ActiveMdiChild 'if null catch executes
            tempChild.Close()

            frm = New frmRegistration
            frm.MdiParent = Me
            frm.Show()


        Catch er As System.Exception
            Dim frm As New frmRegistration
            frm.MdiParent = Me
            frm.Tab.SelectedTab = frm.TabGroup
            frm.Show()
        Finally
            
        End Try
    End Sub

    Private Sub MemberRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberRegistrationToolStripMenuItem.Click
        Try
            Dim tempChild As Form = Me.ActiveMdiChild 'if null catch executes
            tempChild.Close()
            frm = New frmRegistration
            ' frm.TopLevel = False
            ' Me.plMain.Controls.Add(frm)
            frm.MdiParent = Me

            frm.Show()

        Catch er As System.Exception
            Dim frm As New frmRegistration
            frm.MdiParent = Me
            frm.Show()
        Finally
            
        End Try
    End Sub
    
    Private Sub NewContributionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewContributionToolStripMenuItem.Click
        Try
            Dim tempChild As Form = Me.ActiveMdiChild 'if null catch executes
            tempChild.Close()
            frm = New frmPayCollection

            frm.MdiParent = Me

            frm.Show()


        Catch er As System.Exception
            Dim frm As New frmPayCollection
            frm.MdiParent = Me
            frm.Show()
        Finally
     
        End Try
    End Sub

    Private Sub LoanRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanRequestToolStripMenuItem.Click
        Try
            Dim tempChild As Form = Me.ActiveMdiChild 'if null catch executes
            tempChild.Close()
            frm = New frmLoanApplication
            frm.MdiParent = Me
            frm.Show()

        Catch er As System.Exception
            Dim frm As New frmLoanApplication
            frm.MdiParent = Me
            frm.Show()
        Finally

        End Try
    End Sub

    Private Sub LoanRepaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanRepaymentToolStripMenuItem.Click
        Try
            Dim tempChild As Form = Me.ActiveMdiChild 'if null catch executes
            tempChild.Close()
            frm = New frmLoanRepayment

            frm.MdiParent = Me

            frm.Show()


        Catch er As System.Exception
            Dim frm As New frmLoanRepayment
            frm.MdiParent = Me
            frm.Show()
        Finally

        End Try
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
