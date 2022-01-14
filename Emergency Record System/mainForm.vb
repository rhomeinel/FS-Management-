Imports System.Data.OleDb
Public Class mainForm
    Dim dt As New DataTable
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim conString As String
    Dim maxRows As Integer
    Dim dsNewRow As DataRow
    Dim inc As Integer
    Dim adapt, adapt1 As New OleDbDataAdapter
    Dim conn As New OleDbConnection
    Dim dset As New DataSet
    Private Sub equipForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Erms.accdb'"
        con = New OleDbConnection(conString)
        con.Open()
        sql = "select * from maintenance"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "mainBook")
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtMserial.Text = "" And cbMType.Text = "" And cbChecks.Text = "" And txtMBy.Text = "" And txtNote.Text = "" And txtTotal.Text = "" And DateTimePicker.Text = "" Then
            MsgBox("Enter All Fields")

        ElseIf cbMType.Text = "" Or txtMserial.Text = "" Or cbChecks.Text = "" Or txtMBy.Text = "" Or txtNote.Text = "" Or txtTotal.Text = "" Or DateTimePicker.Text = "" Then
            MsgBox("Please Complete all Fields")

        Else
            Dim dbcommand As String = "INSERT into maintenance (eqSerial, mType, checks, mainBy, mDate, totalCost, notes)" & " VALUES ('" & txtMserial.Text + "','" & cbMType.Text & "','" & cbChecks.Text & "','" & txtMBy.Text & "','" & DateTimePicker.Text & "','" & txtTotal.Text & "','" & txtNote.Text & "')"
            Dim adapt As New OleDb.OleDbDataAdapter(dbcommand, con)
            Dim dset As New DataSet()
            adapt.Fill(dset)
            MsgBox("Succesfully added!")
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class