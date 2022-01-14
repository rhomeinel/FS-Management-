Imports System.Data.OleDb
Public Class equipForm
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
        sql = "select * from equipments"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "EquipmentBook")
        con.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSerial.Text = "" And cbEquip.Text = "" And cbOwn.Text = "" Then
            MsgBox("Enter All Fields")

        ElseIf cbEquip.Text = "" Or txtSerial.Text = "" Or cbOwn.Text = "" Then
            MsgBox("Please Complete all Fields")

        Else
            Dim dbcommand As String = "INSERT into equipments (serial, equipName, ownership)" & " VALUES ('" & txtSerial.Text + "','" & cbEquip.Text & "','" & cbOwn.Text & "')"
            Dim adapt As New OleDb.OleDbDataAdapter(dbcommand, con)
            Dim dset As New DataSet()
            adapt.Fill(dset)
            MsgBox("Equipment Succesfully added!")
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class