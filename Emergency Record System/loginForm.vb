Imports System.Data.OleDb
Public Class loginForm
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sql As String
        Dim Log_in As New DataTable
        Dim connect As New OleDbConnection
        Dim countattempts As Integer = 5
        Try
            If TextBox1.Text = "" Then
                MsgBox("Please Enter Pin ")

            Else
                con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Erms.accdb'")
                sql = "SELECT * FROM personnelTable where Pincode = " & TextBox1.Text & ""

                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(Log_in)
                If Log_in.Rows.Count > 0 Then
                    Dim Type, Fullname, accno As String
                    Type = Log_in.Rows(0).Item("type")
                    Fullname = Log_in.Rows(0).Item("Firstname")
                    accno = Log_in.Rows(0).Item("p_ID")
                    If Type = "admin" Then
                        MsgBox("Welcome " & Fullname & " you login as Administrator ")
                        Form1.Show()
                        Me.Hide()

                    ElseIf Type = "Block" Then
                        MsgBox("Your account is currently Block")
                        MsgBox("Contact the Administrator for Help")

                    Else
                        MsgBox("Welcome " & Fullname)

                        userForm.lblname.Text = Fullname
                        userForm.lblpID.Text = accno
                        userForm.Show()
                        Me.Hide()


                    End If

                Else
                    MsgBox("You are Not Registered!!!")
                    MsgBox("Please contact Administrator to Register")


                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TextBox1.Text = ""
    End Sub

End Class