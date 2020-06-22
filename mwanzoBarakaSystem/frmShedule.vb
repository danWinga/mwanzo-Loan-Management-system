Public Class frmShedule
    Dim P, MT, MP, MI, J, R, N, PB As Double
    Dim conn As New MyDb
    Public loanamount, loaRate As Double
    Public loanperiod As Integer
    Private Sub testFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MsgBox("loan amount " & loanamount)
        Dim TestDataTable As DataTable = CreateTestDataTable()
        Dim TestDict As New Dictionary(Of String, String)
        For Each row As DataRow In TestDataTable.Rows
            'you can add more content            
            Dim info As String = row("MPrincipal").ToString() & " " & row("MIterest").ToString() & " " & row("PBalance").ToString()
            TestDict.Add(row("ID").ToString(), info)

        Next

    End Sub


    Private Function CreateTestDataTable()
       
        Dim dt As New DataTable
        dt.Columns.Add("ID", System.Type.GetType("System.Int32"))
        dt.Columns.Add("MPrincipal", System.Type.GetType("System.String"))
        dt.Columns.Add("MIterest", System.Type.GetType("System.String"))
        dt.Columns.Add("PBalance", System.Type.GetType("System.String"))
        'MsgBox("loan amount " & P)
        P = loanamount
        R = loaRate / 100
        J = R / 12 ' J = effective interest rate
        Dim t As Integer = loanperiod  ' months
        N = t ' converting years to month
        MT = P * (J / (1 - (1 + J) ^ -N))


        PB = 0 ' PB = Principal Balance 
        Dim index = 1
        Do While P > 0
            PB = P
            MI = PB * J ' MI = 1st month Interest
            MP = MT - MI ' MP2 = 1st month Principal
            PB = P - MP
            Dim MPX, MIX, PBX As Double
            MPX = Math.Round(MP, 2, MidpointRounding.AwayFromZero)
            MIX = Math.Round(MI, 2, MidpointRounding.AwayFromZero)
            PBX = Math.Round(PB, 2, MidpointRounding.AwayFromZero)
            dt.Rows.Add(index, MPX, MIX, PBX)

            index = index + 1
            P = PB
        Loop
        GridB.DataSource = dt
    End Function

    Private Sub GridA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class