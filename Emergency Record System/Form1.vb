Imports System.Data.OleDb
Public Class Form1
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ErmsDataSet.personnelTable' table. You can move, or remove it, as needed.
        Me.PersonnelTableTableAdapter.Fill(Me.ErmsDataSet.personnelTable)
        conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Erms.accdb'"
        con = New OleDbConnection(conString)
        con.Open()
        sql = "select * from PersonnelTable"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "AddressBook")
        con.Close()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtpId.Text = "" And txtpin.Text = "" And txtcontact.Text = "" And txtfname.Text = "" And txtlname.Text = "" And txtaddr.Text = "" And txtcontact.Text = "" And cbGender.Text = "" And cbday.Text = "" And cbmonth.Text = "" And cbyear.Text = "" Then
            MsgBox("Enter All Fields")

        ElseIf txtpId.Text = "" Or txtpin.Text = "" Or txtcontact.Text = "" Or txtfname.Text = "" Or txtlname.Text = "" Or txtaddr.Text = "" Or txtcontact.Text = "" Or cbGender.Text = "" Or cbday.Text = "" Or cbmonth.Text = "" Or cbyear.Text = "" Then
            MsgBox("Please Complete all Fields")

        Else
            Dim adapt1 As New OleDb.OleDbDataAdapter("select * from personnelTable where Firstname='" & txtfname.Text & "'", con)
            Dim dset1 As New DataSet()
            adapt1.Fill(dset1)
            If dset1.Tables(0).Rows.Count <> 0 Then
                MsgBox("Account name already exist")
            Else
                Dim dbcommand As String = "INSERT into personnelTable (p_ID, Firstname, Lastname, Address, Phone, Gender, Birthdate, Pincode , type, department)" & " VALUES ('" & txtpId.Text + "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddr.Text & "','" & txtcontact.Text & "','" & cbGender.Text & "','" & (cbmonth.Text + cbday.Text + cbyear.Text) & "','" & txtpin.Text & "','" & "Active" & "','" & cbDept.Text & "')"
                Dim adapt As New OleDb.OleDbDataAdapter(dbcommand, con)
                Dim dset As New DataSet()
                adapt.Fill(dset)
                MsgBox("You Have Succesfully Registered!")
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub AddIncidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddIncidentToolStripMenuItem.Click
        incidentFrom.Show()
    End Sub

#Region "notification icon"
    Private Sub Form1_Move(sender As Object, e As System.EventArgs) Handles Me.Move
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            niERS.ShowBalloonTip(4600, "Emergency R&R System", "Emergency R&R System have been minimized. Click this icon to maximise it", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub niERS_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles niERS.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
#End Region

    Private Sub AddEquipmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEquipmentToolStripMenuItem.Click
        equipForm.Show()
    End Sub

    Private Sub MaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem.Click
        mainForm.Show()
    End Sub



    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        homeForm.Show()
    End Sub
End Class

