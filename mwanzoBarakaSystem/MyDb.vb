Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataAdapter
Imports System.Data.OleDb.OleDbCommand

Public Class MyDb

    Dim dbCon As OleDb.OleDbConnection
    Public reader As OleDbDataReader
    Public db As DataSet
    Dim cm As New OleDbCommand
    Dim con As New OleDbConnection

    Dim cmd As New OleDbCommand

    

    Public Sub New()

        dbCon = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mwanzoDb.mdb")
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mwanzoDb.mdb")
        ' cmd.Connection = con
        'cmd.CommandText = "SELECT * FROM table1"


    End Sub

    Public Sub ManageConnection(ByVal CloseConnection As Boolean)
        Try
            'Prepare connection and query'
            'dbCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\mwanzoDb.mdb"
            'dbCon = New ConnectionString("Server=localhost; User Id = root; Pwd = 12345; Database = digitallibrary")
            dbCon = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\mwanzoDb.mdb")
            If CloseConnection = False Then
                If dbCon.State = ConnectionState.Closed Then _
                    dbCon.Open()
                'MsgBox("open")
            Else
                dbCon.Close()
            End If
        Catch ex As Exception
            MsgBox("FAIL")
        End Try

    End Sub
    Public Sub creates(ByRef qryStr As String)
        Try
            con.Open()

            cmd.Connection = con
            cmd.CommandText = qryStr
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Error " & ex.Message)

        End Try
    End Sub
    Public Sub Insert(ByRef qryStr As String)
        Try

            ManageConnection(True) 'Open connection'
            dbCon.Open()


            Dim SqlCmdx As New OleDbCommand(qryStr, dbCon)
            SqlCmdx.ExecuteNonQuery()

            ManageConnection(False) 'Close connection'

        Catch ex As Exception
            MsgBox("Error " & ex.Message)

        End Try
    End Sub

    Public Function SelectQry(ByRef qryStr As String, ByVal td As String) As DataTable
        Try
            db = New DataSet
            ManageConnection(True) 'Open connection'
            Dim tdFill As DataTable
            Dim SqlCmd As New OleDbCommand(qryStr, dbCon)

            Dim Adpt As New OleDbDataAdapter

            Adpt.SelectCommand = SqlCmd
            Adpt.Fill(db, td)
            tdFill = db.Tables(td)
            Return tdFill
            dbCon.Close()
            ManageConnection(False)
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try
        Return Nothing
    End Function


    Public Function generateAccNo(ByRef tbn2 As DataTable, ByRef sql As String, ByRef tbN As String) As String
        Try

            Dim cl As String = ""
            Dim accNo As String = ""
            Dim conValue As String = ""
            Dim valuex As Integer = 0
            If tbn2.Rows.Count <> 0 Then
                cl = tbn2.Rows(0)(0)
                'MsgBox(cl)
                valuex = Convert.ToInt16(cl)
                ' MsgBox("converted" & cl)
                If valuex < 1 Then
                    conValue = "00000000"
                    Return accNo = conValue & 1
                ElseIf valuex > 0 & valuex < 10 Then
                    conValue = "00000000"
                    accNo = conValue & (valuex + 1)
                ElseIf valuex >= 10 & valuex < 100 Then
                    conValue = "0000000"
                    Return accNo = conValue & (valuex + 1)
                ElseIf valuex >= 100 & valuex < 1000 Then
                    conValue = "000000"
                    Return accNo = conValue & (valuex + 1)
                ElseIf valuex >= 1000 & valuex < 10000 Then
                    conValue = "00000"
                    Return accNo = conValue & (valuex + 1)
                ElseIf valuex >= 10000 & valuex < 100000 Then
                    conValue = "0000"
                    Return accNo = conValue & (valuex + 1)
                ElseIf valuex >= 100000 & valuex < 1000000 Then
                    conValue = "000"
                    Return accNo = conValue & (valuex + 1)
                ElseIf valuex >= 1000000 & valuex < 10000000 Then
                    conValue = "00"
                    Return accNo = conValue & (valuex + 1)
                ElseIf valuex >= 10000000 & valuex < 100000000 Then
                    conValue = "0"
                    Return accNo = conValue & (valuex + 1)
                ElseIf valuex >= 100000000 Then

                    Return accNo = valuex + 1
                End If
                'MsgBox(recValue)
            Else
                conValue = "00000000"
                Return accNo = conValue & 1
                ' MsgBox(accNo)

            End If
        Catch ex As Exception

        End Try
        Return Nothing
    End Function




End Class
