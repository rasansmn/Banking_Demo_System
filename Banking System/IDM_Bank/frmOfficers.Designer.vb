<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfficers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOfficers))
        Me.GridOfficers = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.lblCraccounts = New System.Windows.Forms.Label
        Me.lblTransactions = New System.Windows.Forms.Label
        Me.lblJoined = New System.Windows.Forms.Label
        Me.lblDetails = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblNic = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblBday = New System.Windows.Forms.Label
        Me.lblGender = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblPermission = New System.Windows.Forms.Label
        Me.lblAccnum = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmbLook = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnAddofficer = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridTransactions = New System.Windows.Forms.DataGrid
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridAccounts = New System.Windows.Forms.DataGrid
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.GridOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridOfficers
        '
        Me.GridOfficers.AlternatingBackColor = System.Drawing.Color.White
        Me.GridOfficers.BackColor = System.Drawing.Color.White
        Me.GridOfficers.BackgroundColor = System.Drawing.Color.Ivory
        Me.GridOfficers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridOfficers.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.GridOfficers.CaptionForeColor = System.Drawing.Color.Lavender
        Me.GridOfficers.CaptionText = "Officers"
        Me.GridOfficers.DataMember = ""
        Me.GridOfficers.FlatMode = True
        Me.GridOfficers.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GridOfficers.ForeColor = System.Drawing.Color.Black
        Me.GridOfficers.GridLineColor = System.Drawing.Color.Wheat
        Me.GridOfficers.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.GridOfficers.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridOfficers.HeaderForeColor = System.Drawing.Color.Black
        Me.GridOfficers.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.GridOfficers.Location = New System.Drawing.Point(14, 19)
        Me.GridOfficers.Name = "GridOfficers"
        Me.GridOfficers.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.GridOfficers.ParentRowsForeColor = System.Drawing.Color.Black
        Me.GridOfficers.SelectionBackColor = System.Drawing.Color.Wheat
        Me.GridOfficers.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.GridOfficers.Size = New System.Drawing.Size(525, 173)
        Me.GridOfficers.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.lblCraccounts)
        Me.GroupBox1.Controls.Add(Me.lblTransactions)
        Me.GroupBox1.Controls.Add(Me.lblJoined)
        Me.GroupBox1.Controls.Add(Me.lblDetails)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblNic)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblBday)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblPermission)
        Me.GroupBox1.Controls.Add(Me.lblAccnum)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(579, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 529)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Officer Infomation"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(144, 359)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 28
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(225, 359)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblCraccounts
        '
        Me.lblCraccounts.AutoSize = True
        Me.lblCraccounts.Location = New System.Drawing.Point(124, 321)
        Me.lblCraccounts.Name = "lblCraccounts"
        Me.lblCraccounts.Size = New System.Drawing.Size(45, 13)
        Me.lblCraccounts.TabIndex = 27
        Me.lblCraccounts.Text = "Label26"
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Location = New System.Drawing.Point(124, 298)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(45, 13)
        Me.lblTransactions.TabIndex = 26
        Me.lblTransactions.Text = "Label25"
        '
        'lblJoined
        '
        Me.lblJoined.AutoSize = True
        Me.lblJoined.Location = New System.Drawing.Point(124, 274)
        Me.lblJoined.Name = "lblJoined"
        Me.lblJoined.Size = New System.Drawing.Size(45, 13)
        Me.lblJoined.TabIndex = 25
        Me.lblJoined.Text = "Label24"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(124, 249)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(45, 13)
        Me.lblDetails.TabIndex = 24
        Me.lblDetails.Text = "Label23"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(124, 225)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 13)
        Me.lblEmail.TabIndex = 23
        Me.lblEmail.Text = "Label22"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(124, 200)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(45, 13)
        Me.lblPhone.TabIndex = 22
        Me.lblPhone.Text = "Label21"
        '
        'lblNic
        '
        Me.lblNic.AutoSize = True
        Me.lblNic.Location = New System.Drawing.Point(124, 175)
        Me.lblNic.Name = "lblNic"
        Me.lblNic.Size = New System.Drawing.Size(45, 13)
        Me.lblNic.TabIndex = 21
        Me.lblNic.Text = "Label20"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(124, 150)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 20
        Me.lblAddress.Text = "Label19"
        '
        'lblBday
        '
        Me.lblBday.AutoSize = True
        Me.lblBday.Location = New System.Drawing.Point(124, 126)
        Me.lblBday.Name = "lblBday"
        Me.lblBday.Size = New System.Drawing.Size(45, 13)
        Me.lblBday.TabIndex = 19
        Me.lblBday.Text = "Label18"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(124, 102)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 18
        Me.lblGender.Text = "Label17"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(124, 77)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 13)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "Label16"
        '
        'lblPermission
        '
        Me.lblPermission.AutoSize = True
        Me.lblPermission.Location = New System.Drawing.Point(124, 53)
        Me.lblPermission.Name = "lblPermission"
        Me.lblPermission.Size = New System.Drawing.Size(45, 13)
        Me.lblPermission.TabIndex = 16
        Me.lblPermission.Text = "Label15"
        '
        'lblAccnum
        '
        Me.lblAccnum.AutoSize = True
        Me.lblAccnum.Location = New System.Drawing.Point(124, 29)
        Me.lblAccnum.Name = "lblAccnum"
        Me.lblAccnum.Size = New System.Drawing.Size(45, 13)
        Me.lblAccnum.TabIndex = 4
        Me.lblAccnum.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Permission:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 321)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Created accounts:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Transactions:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Joined on:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Details:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "E-Mail:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "NIC num:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Birthday:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account num:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.cmbLook)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btnAddofficer)
        Me.GroupBox2.Controls.Add(Me.GridOfficers)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 228)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Officers"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(438, 199)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 7
        '
        'cmbLook
        '
        Me.cmbLook.FormattingEnabled = True
        Me.cmbLook.Items.AddRange(New Object() {"acc_num", "permission", "name", "gender", "birthday", "address", "nic_num", "phone", "email", "details", "joined_date"})
        Me.cmbLook.Location = New System.Drawing.Point(326, 198)
        Me.cmbLook.Name = "cmbLook"
        Me.cmbLook.Size = New System.Drawing.Size(106, 21)
        Me.cmbLook.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(267, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Search in:"
        '
        'btnAddofficer
        '
        Me.btnAddofficer.Location = New System.Drawing.Point(14, 197)
        Me.btnAddofficer.Name = "btnAddofficer"
        Me.btnAddofficer.Size = New System.Drawing.Size(113, 23)
        Me.btnAddofficer.TabIndex = 4
        Me.btnAddofficer.Text = "Add New Officer"
        Me.btnAddofficer.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridTransactions)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 318)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 143)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transactions done by officer"
        '
        'GridTransactions
        '
        Me.GridTransactions.AlternatingBackColor = System.Drawing.Color.White
        Me.GridTransactions.BackColor = System.Drawing.Color.White
        Me.GridTransactions.BackgroundColor = System.Drawing.Color.Ivory
        Me.GridTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridTransactions.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.GridTransactions.CaptionForeColor = System.Drawing.Color.Lavender
        Me.GridTransactions.CaptionText = "Transactions"
        Me.GridTransactions.DataMember = ""
        Me.GridTransactions.FlatMode = True
        Me.GridTransactions.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GridTransactions.ForeColor = System.Drawing.Color.Black
        Me.GridTransactions.GridLineColor = System.Drawing.Color.Wheat
        Me.GridTransactions.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.GridTransactions.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridTransactions.HeaderForeColor = System.Drawing.Color.Black
        Me.GridTransactions.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.GridTransactions.Location = New System.Drawing.Point(14, 19)
        Me.GridTransactions.Name = "GridTransactions"
        Me.GridTransactions.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.GridTransactions.ParentRowsForeColor = System.Drawing.Color.Black
        Me.GridTransactions.SelectionBackColor = System.Drawing.Color.Wheat
        Me.GridTransactions.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.GridTransactions.Size = New System.Drawing.Size(524, 112)
        Me.GridTransactions.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridAccounts)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 466)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(553, 147)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Accounts created by officer"
        '
        'GridAccounts
        '
        Me.GridAccounts.AlternatingBackColor = System.Drawing.Color.White
        Me.GridAccounts.BackColor = System.Drawing.Color.White
        Me.GridAccounts.BackgroundColor = System.Drawing.Color.Ivory
        Me.GridAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridAccounts.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.GridAccounts.CaptionForeColor = System.Drawing.Color.Lavender
        Me.GridAccounts.CaptionText = "Accounts"
        Me.GridAccounts.DataMember = ""
        Me.GridAccounts.FlatMode = True
        Me.GridAccounts.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GridAccounts.ForeColor = System.Drawing.Color.Black
        Me.GridAccounts.GridLineColor = System.Drawing.Color.Wheat
        Me.GridAccounts.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.GridAccounts.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridAccounts.HeaderForeColor = System.Drawing.Color.Black
        Me.GridAccounts.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.GridAccounts.Location = New System.Drawing.Point(16, 23)
        Me.GridAccounts.Name = "GridAccounts"
        Me.GridAccounts.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.GridAccounts.ParentRowsForeColor = System.Drawing.Color.Black
        Me.GridAccounts.SelectionBackColor = System.Drawing.Color.Wheat
        Me.GridAccounts.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.GridAccounts.Size = New System.Drawing.Size(522, 112)
        Me.GridAccounts.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(113, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Officers"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(113, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(393, 26)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Select the officer on the officers table to view it's contents and related transa" & _
            "ction " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "infomation and accounts created by the officer"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Image = Global.IDM_Bank.My.Resources.Resources.imfcfdges
        Me.PictureBox1.Location = New System.Drawing.Point(41, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmOfficers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 626)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOfficers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Officers"
        CType(Me.GridOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridOfficers As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridTransactions As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridAccounts As System.Windows.Forms.DataGrid
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCraccounts As System.Windows.Forms.Label
    Friend WithEvents lblTransactions As System.Windows.Forms.Label
    Friend WithEvents lblJoined As System.Windows.Forms.Label
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblNic As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblBday As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPermission As System.Windows.Forms.Label
    Friend WithEvents lblAccnum As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAddofficer As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbLook As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
