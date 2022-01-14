<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PincodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonnelTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErmsDataSet = New Emergency_Record_System.ErmsDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbmonth = New System.Windows.Forms.ComboBox()
        Me.cbday = New System.Windows.Forms.ComboBox()
        Me.cbyear = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.cbDept = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddIncidentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewIncidentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLogActivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEquipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicalSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.niERS = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PersonnelTableTableAdapter = New Emergency_Record_System.ErmsDataSetTableAdapters.personnelTableTableAdapter()
        Me.TableAdapterManager = New Emergency_Record_System.ErmsDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonnelTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.PincodeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.AccessDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonnelTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(325, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(926, 462)
        Me.DataGridView1.TabIndex = 8
        '
        'PIDDataGridViewTextBoxColumn
        '
        Me.PIDDataGridViewTextBoxColumn.DataPropertyName = "p_ID"
        Me.PIDDataGridViewTextBoxColumn.HeaderText = "p_ID"
        Me.PIDDataGridViewTextBoxColumn.Name = "PIDDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        '
        'PincodeDataGridViewTextBoxColumn
        '
        Me.PincodeDataGridViewTextBoxColumn.DataPropertyName = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.HeaderText = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.Name = "PincodeDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'AccessDataGridViewTextBoxColumn
        '
        Me.AccessDataGridViewTextBoxColumn.DataPropertyName = "access"
        Me.AccessDataGridViewTextBoxColumn.HeaderText = "access"
        Me.AccessDataGridViewTextBoxColumn.Name = "AccessDataGridViewTextBoxColumn"
        '
        'PersonnelTableBindingSource
        '
        Me.PersonnelTableBindingSource.DataMember = "personnelTable"
        Me.PersonnelTableBindingSource.DataSource = Me.ErmsDataSet
        '
        'ErmsDataSet
        '
        Me.ErmsDataSet.DataSetName = "ErmsDataSet"
        Me.ErmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbmonth)
        Me.GroupBox1.Controls.Add(Me.cbday)
        Me.GroupBox1.Controls.Add(Me.cbyear)
        Me.GroupBox1.Controls.Add(Me.btnRegister)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtpId)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtaddr)
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.txtpin)
        Me.GroupBox1.Controls.Add(Me.cbGender)
        Me.GroupBox1.Controls.Add(Me.cbDept)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 462)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personnel Information"
        '
        'cbmonth
        '
        Me.cbmonth.FormattingEnabled = True
        Me.cbmonth.Items.AddRange(New Object() {"Jan-", "Feb-", "Mar-", "Apr-", "May-", "Jun-", "Jul-", "Aug-", "Sep-", "Oct-", "Nov-", "Dec-"})
        Me.cbmonth.Location = New System.Drawing.Point(84, 242)
        Me.cbmonth.Name = "cbmonth"
        Me.cbmonth.Size = New System.Drawing.Size(48, 23)
        Me.cbmonth.TabIndex = 38
        '
        'cbday
        '
        Me.cbday.FormattingEnabled = True
        Me.cbday.Items.AddRange(New Object() {"1-", "2-", "3-", "4-", "5-", "6-", "7-", "8-", "9-", "10-", "11-", "12-", "13-", "14-", "15-", "16-", "17-", "18-", "19-", "20-", "21-", "22-", "23-", "24-", "25-", "26-", "27-", "28-", "29-", "30-", "31-"})
        Me.cbday.Location = New System.Drawing.Point(157, 242)
        Me.cbday.Name = "cbday"
        Me.cbday.Size = New System.Drawing.Size(48, 23)
        Me.cbday.TabIndex = 37
        '
        'cbyear
        '
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014"})
        Me.cbyear.Location = New System.Drawing.Point(220, 242)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.Size = New System.Drawing.Size(64, 23)
        Me.cbyear.TabIndex = 36
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(130, 369)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 12
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(17, 434)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Pin Code:"
        '
        'txtpId
        '
        Me.txtpId.Location = New System.Drawing.Point(84, 30)
        Me.txtpId.Name = "txtpId"
        Me.txtpId.Size = New System.Drawing.Size(100, 21)
        Me.txtpId.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Personnel ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Department:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Birth Date:"
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(84, 169)
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(200, 21)
        Me.txtaddr.TabIndex = 9
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(84, 206)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(100, 21)
        Me.txtcontact.TabIndex = 8
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(84, 132)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(200, 21)
        Me.txtlname.TabIndex = 7
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(84, 101)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(200, 21)
        Me.txtfname.TabIndex = 6
        '
        'txtpin
        '
        Me.txtpin.Location = New System.Drawing.Point(84, 66)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(100, 21)
        Me.txtpin.TabIndex = 5
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(84, 275)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(121, 23)
        Me.cbGender.TabIndex = 3
        '
        'cbDept
        '
        Me.cbDept.FormattingEnabled = True
        Me.cbDept.Items.AddRange(New Object() {"Finance", "Logistics", "Fire Safety", "Operations", "EMS Department", "Technical Service", "Human Resources", "Research & Development"})
        Me.cbDept.Location = New System.Drawing.Point(84, 309)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(200, 23)
        Me.cbDept.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.AddIncidentToolStripMenuItem, Me.ViewToolStripMenuItem, Me.EquipmentsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1263, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AddIncidentToolStripMenuItem
        '
        Me.AddIncidentToolStripMenuItem.Name = "AddIncidentToolStripMenuItem"
        Me.AddIncidentToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.AddIncidentToolStripMenuItem.Text = "Add Incident"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReportToolStripMenuItem, Me.ViewIncidentToolStripMenuItem1, Me.ViewLogActivityToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ViewToolStripMenuItem.Text = "Report"
        '
        'ViewReportToolStripMenuItem
        '
        Me.ViewReportToolStripMenuItem.Name = "ViewReportToolStripMenuItem"
        Me.ViewReportToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewReportToolStripMenuItem.Text = " View Report"
        '
        'ViewIncidentToolStripMenuItem1
        '
        Me.ViewIncidentToolStripMenuItem1.Name = "ViewIncidentToolStripMenuItem1"
        Me.ViewIncidentToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ViewIncidentToolStripMenuItem1.Text = "View Incident"
        '
        'ViewLogActivityToolStripMenuItem
        '
        Me.ViewLogActivityToolStripMenuItem.Name = "ViewLogActivityToolStripMenuItem"
        Me.ViewLogActivityToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewLogActivityToolStripMenuItem.Text = "View Log Activity"
        '
        'EquipmentsToolStripMenuItem
        '
        Me.EquipmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEquipmentToolStripMenuItem, Me.MaintenanceToolStripMenuItem})
        Me.EquipmentsToolStripMenuItem.Name = "EquipmentsToolStripMenuItem"
        Me.EquipmentsToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EquipmentsToolStripMenuItem.Text = "Equipments"
        '
        'AddEquipmentToolStripMenuItem
        '
        Me.AddEquipmentToolStripMenuItem.Name = "AddEquipmentToolStripMenuItem"
        Me.AddEquipmentToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddEquipmentToolStripMenuItem.Text = "Add Equipment"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechnicalSupportToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.AboutERSToolStripMenuItem})
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
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UpdateToolStripMenuItem.Text = "Updates"
        '
        'AboutERSToolStripMenuItem
        '
        Me.AboutERSToolStripMenuItem.Name = "AboutERSToolStripMenuItem"
        Me.AboutERSToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutERSToolStripMenuItem.Text = "About ERS"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'niERS
        '
        Me.niERS.Text = "Emergency R&R Sytem"
        Me.niERS.Visible = True
        '
        'PersonnelTableTableAdapter
        '
        Me.PersonnelTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.equipmentsTableAdapter = Nothing
        Me.TableAdapterManager.incidentTableTableAdapter = Nothing
        Me.TableAdapterManager.logActivityTableAdapter = Nothing
        Me.TableAdapterManager.maintenanceTableAdapter = Nothing
        Me.TableAdapterManager.personnelTableTableAdapter = Me.PersonnelTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Emergency_Record_System.ErmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1263, 522)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonnelTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtaddr As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Friend WithEvents cbDept As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddIncidentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewIncidentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewLogActivityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TechnicalSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents cbmonth As System.Windows.Forms.ComboBox
    Friend WithEvents cbday As System.Windows.Forms.ComboBox
    Friend WithEvents cbyear As System.Windows.Forms.ComboBox
    Friend WithEvents niERS As System.Windows.Forms.NotifyIcon
    Friend WithEvents EquipmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEquipmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErmsDataSet As Emergency_Record_System.ErmsDataSet
    Friend WithEvents PersonnelTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonnelTableTableAdapter As Emergency_Record_System.ErmsDataSetTableAdapters.personnelTableTableAdapter
    Friend WithEvents TableAdapterManager As Emergency_Record_System.ErmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
