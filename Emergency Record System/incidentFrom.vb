Imports System.Data.OleDb
Class incidentFrom
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
        Dim adapt, adapt1 As New OleDb.OleDbDataAdapter
        Dim conn As New OleDb.OleDbConnection
        Dim dset As New DataSet
    Private Sub incidentFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Erms.accdb'"
        con = New OleDbConnection(conString)
        con.Open()
        sql = "select * from incidentTable"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "IncidentBook")
        con.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtId.Text = "" And cbIType.Text = "" And cbAct.Text = "" And txtDetails.Text = "" And txtLper.Text = "" And txtRName.Text = "" And txtRNum.Text = "" And txtState.Text = "" And cbday.Text = "" And cbmonth.Text = "" And cbyear.Text = "" Then
            MsgBox("Enter All Fields")

        ElseIf txtId.Text = "" Or cbIType.Text = "" Or cbAct.Text = "" Or txtDetails.Text = "" Or txtLper.Text = "" Or txtRName.Text = "" Or txtRNum.Text = "" Or txtState.Text = "" Or cbday.Text = "" Or cbmonth.Text = "" Or cbyear.Text = "" Then
            MsgBox("Please Complete all Fields")


            Else
                Dim dbcommand As String = "INSERT into incidentTable (I_ID, incidentType, assignedTo, location, actionTaken, reporterName, iDate, reporterNum , iStatus, details)" & " VALUES ('" & txtId.Text + "','" & cbIType.Text & "','" & txtLper.Text & "','" & txtiLoc.Text & "','" & cbAct.Text & "','" & txtRName.Text & "','" & (cbmonth.Text + cbday.Text + cbyear.Text) & "','" & txtRNum.Text & "','" & txtState.Text & "','" & txtDetails.Text & "')"
                Dim adapt As New OleDb.OleDbDataAdapter(dbcommand, con)
                Dim dset As New DataSet()
                adapt.Fill(dset)
                MsgBox("Incident Succesfully added!")
            Me.Hide()
            End If

    End Sub

End Class

