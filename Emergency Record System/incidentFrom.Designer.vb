<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incidentFrom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtiLoc = New System.Windows.Forms.TextBox()
        Me.cbAct = New System.Windows.Forms.ComboBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.cbIType = New System.Windows.Forms.ComboBox()
        Me.cbmonth = New System.Windows.Forms.ComboBox()
        Me.cbday = New System.Windows.Forms.ComboBox()
        Me.cbyear = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLper = New System.Windows.Forms.TextBox()
        Me.txtRNum = New System.Windows.Forms.TextBox()
        Me.txtRName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicalSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtiLoc)
        Me.GroupBox1.Controls.Add(Me.cbAct)
        Me.GroupBox1.Controls.Add(Me.txtDetails)
        Me.GroupBox1.Controls.Add(Me.cbIType)
        Me.GroupBox1.Controls.Add(Me.cbmonth)
        Me.GroupBox1.Controls.Add(Me.cbday)
        Me.GroupBox1.Controls.Add(Me.cbyear)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLper)
        Me.GroupBox1.Controls.Add(Me.txtRNum)
        Me.GroupBox1.Controls.Add(Me.txtRName)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 413)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Add Incident"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(153, 308)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(200, 22)
        Me.txtState.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Reporter's Number:"
        '
        'txtiLoc
        '
        Me.txtiLoc.Location = New System.Drawing.Point(153, 97)
        Me.txtiLoc.Name = "txtiLoc"
        Me.txtiLoc.Size = New System.Drawing.Size(200, 22)
        Me.txtiLoc.TabIndex = 25
        '
        'cbAct
        '
        Me.cbAct.FormattingEnabled = True
        Me.cbAct.Items.AddRange(New Object() {"Rescue  ", "Extinguish", "Investigate", "Service"})
        Me.cbAct.Location = New System.Drawing.Point(153, 235)
        Me.cbAct.Name = "cbAct"
        Me.cbAct.Size = New System.Drawing.Size(200, 24)
        Me.cbAct.TabIndex = 24
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(379, 52)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(210, 319)
        Me.txtDetails.TabIndex = 23
        '
        'cbIType
        '
        Me.cbIType.FormattingEnabled = True
        Me.cbIType.Items.AddRange(New Object() {"Lock-In", "Lock-Out", "Gas Leak", "False alarm", "Building Fire", "Smoke scare", "Cooking Fire", "Passenger vehicle fire", "Natural vegetation fire", "Attempted burning, illegal action"})
        Me.cbIType.Location = New System.Drawing.Point(153, 64)
        Me.cbIType.Name = "cbIType"
        Me.cbIType.Size = New System.Drawing.Size(200, 24)
        Me.cbIType.TabIndex = 22
        '
        'cbmonth
        '
        Me.cbmonth.FormattingEnabled = True
        Me.cbmonth.Items.AddRange(New Object() {"Jan-", "Feb-", "Mar-", "Apr-", "May-", "Jun-", "Jul-", "Aug-", "Sep-", "Oct-", "Nov-", "Dec-"})
        Me.cbmonth.Location = New System.Drawing.Point(153, 275)
        Me.cbmonth.Name = "cbmonth"
        Me.cbmonth.Size = New System.Drawing.Size(48, 24)
        Me.cbmonth.TabIndex = 21
        '
        'cbday
        '
        Me.cbday.FormattingEnabled = True
        Me.cbday.Items.AddRange(New Object() {"1-", "2-", "3-", "4-", "5-", "6-", "7-", "8-", "9-", "10-", "11-", "12-", "13-", "14-", "15-", "16-", "17-", "18-", "19-", "20-", "21-", "22-", "23-", "24-", "25-", "26-", "27-", "28-", "29-", "30-", "31-"})
        Me.cbday.Location = New System.Drawing.Point(224, 275)
        Me.cbday.Name = "cbday"
        Me.cbday.Size = New System.Drawing.Size(48, 24)
        Me.cbday.TabIndex = 20
        '
        'cbyear
        '
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028"})
        Me.cbyear.Location = New System.Drawing.Point(289, 272)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.Size = New System.Drawing.Size(64, 24)
        Me.cbyear.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Incident Type:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(153, 33)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Incident ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Reporter's Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Action Taken:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Lead Personnel:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = " Incident Location:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Details:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Date:"
        '
        'txtLper
        '
        Me.txtLper.Location = New System.Drawing.Point(153, 198)
        Me.txtLper.Name = "txtLper"
        Me.txtLper.Size = New System.Drawing.Size(200, 22)
        Me.txtLper.TabIndex = 9
        '
        'txtRNum
        '
        Me.txtRNum.Location = New System.Drawing.Point(153, 164)
        Me.txtRNum.Name = "txtRNum"
        Me.txtRNum.Size = New System.Drawing.Size(200, 22)
        Me.txtRNum.TabIndex = 7
        '
        'txtRName
        '
        Me.txtRName.Location = New System.Drawing.Point(153, 128)
        Me.txtRName.Name = "txtRName"
        Me.txtRName.Size = New System.Drawing.Size(200, 22)
        Me.txtRName.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(197, 348)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.SettingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechnicalSupportToolStripMenuItem, Me.UpdatesToolStripMenuItem, Me.AboutERSToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TechnicalSupportToolStripMenuItem
        '
        Me.TechnicalSupportToolStripMenuItem.Name = "TechnicalSupportToolStripMenuItem"
        Me.TechnicalSupportToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TechnicalSupportToolStripMenuItem.Text = "Technical Support"
        '
        'UpdatesToolStripMenuItem
        '
        Me.UpdatesToolStripMenuItem.Name = "UpdatesToolStripMenuItem"
        Me.UpdatesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UpdatesToolStripMenuItem.Text = "Updates"
        '
        'AboutERSToolStripMenuItem
        '
        Me.AboutERSToolStripMenuItem.Name = "AboutERSToolStripMenuItem"
        Me.AboutERSToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutERSToolStripMenuItem.Text = "About ERS"
        '
        'incidentFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(639, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "incidentFrom"
        Me.Text = "Incident Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbmonth As System.Windows.Forms.ComboBox
    Friend WithEvents cbday As System.Windows.Forms.ComboBox
    Friend WithEvents cbyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLper As System.Windows.Forms.TextBox
    Friend WithEvents txtRNum As System.Windows.Forms.TextBox
    Friend WithEvents txtRName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cbIType As System.Windows.Forms.ComboBox
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents cbAct As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtiLoc As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TechnicalSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtState As System.Windows.Forms.TextBox
End Class
