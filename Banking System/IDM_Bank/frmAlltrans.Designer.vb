<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlltrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlltrans))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTransid = New System.Windows.Forms.TextBox
        Me.btnViewid = New System.Windows.Forms.Button
        Me.rdoAll = New System.Windows.Forms.RadioButton
        Me.rdoDeposits = New System.Windows.Forms.RadioButton
        Me.rdoWithdrawals = New System.Windows.Forms.RadioButton
        Me.btnGo = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblOpid = New System.Windows.Forms.Label
        Me.lblOperator = New System.Windows.Forms.Label
        Me.lblTransactor = New System.Windows.Forms.Label
        Me.lblBal = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.lbltranstype = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblAcc = New System.Windows.Forms.Label
        Me.lbltransid = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblEmpadd = New System.Windows.Forms.Label
        Me.lblEmployer = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblFax = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblNic = New System.Windows.Forms.Label
        Me.lblNation = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblBday = New System.Windows.Forms.Label
        Me.lblGender = New System.Windows.Forms.Label
        Me.lblCrdt = New System.Windows.Forms.Label
        Me.lblAcctype = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblAccnum = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
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
        Me.cmbLook = New System.Windows.Forms.ComboBox
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnDeposit = New System.Windows.Forms.Button
        Me.btnWithdrawal = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.labCraccounts = New System.Windows.Forms.Label
        Me.labTransactions = New System.Windows.Forms.Label
        Me.labDetails = New System.Windows.Forms.Label
        Me.labAddress = New System.Windows.Forms.Label
        Me.labGender = New System.Windows.Forms.Label
        Me.labPerm = New System.Windows.Forms.Label
        Me.labName = New System.Windows.Forms.Label
        Me.l1 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.labOperatorid = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.l6s = New System.Windows.Forms.Label
        Me.l5 = New System.Windows.Forms.Label
        Me.l4 = New System.Windows.Forms.Label
        Me.l3 = New System.Windows.Forms.Label
        Me.l2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGrid1.BackColor = System.Drawing.Color.White
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Ivory
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.Lavender
        Me.DataGrid1.CaptionText = "Transactions"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.ForeColor = System.Drawing.Color.Black
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Wheat
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid1.Location = New System.Drawing.Point(13, 48)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.Wheat
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid1.Size = New System.Drawing.Size(580, 208)
        Me.DataGrid1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tranaction ID:"
        '
        'txtTransid
        '
        Me.txtTransid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransid.Location = New System.Drawing.Point(96, 21)
        Me.txtTransid.Name = "txtTransid"
        Me.txtTransid.Size = New System.Drawing.Size(68, 20)
        Me.txtTransid.TabIndex = 3
        '
        'btnViewid
        '
        Me.btnViewid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewid.Location = New System.Drawing.Point(170, 19)
        Me.btnViewid.Name = "btnViewid"
        Me.btnViewid.Size = New System.Drawing.Size(60, 23)
        Me.btnViewid.TabIndex = 4
        Me.btnViewid.Text = "Show"
        Me.btnViewid.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Checked = True
        Me.rdoAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAll.Location = New System.Drawing.Point(334, 22)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(36, 17)
        Me.rdoAll.TabIndex = 5
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'rdoDeposits
        '
        Me.rdoDeposits.AutoSize = True
        Me.rdoDeposits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDeposits.Location = New System.Drawing.Point(374, 22)
        Me.rdoDeposits.Name = "rdoDeposits"
        Me.rdoDeposits.Size = New System.Drawing.Size(66, 17)
        Me.rdoDeposits.TabIndex = 6
        Me.rdoDeposits.Text = "Deposits"
        Me.rdoDeposits.UseVisualStyleBackColor = True
        '
        'rdoWithdrawals
        '
        Me.rdoWithdrawals.AutoSize = True
        Me.rdoWithdrawals.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWithdrawals.Location = New System.Drawing.Point(438, 22)
        Me.rdoWithdrawals.Name = "rdoWithdrawals"
        Me.rdoWithdrawals.Size = New System.Drawing.Size(83, 17)
        Me.rdoWithdrawals.TabIndex = 7
        Me.rdoWithdrawals.Text = "Withdrawals"
        Me.rdoWithdrawals.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(525, 19)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(66, 23)
        Me.btnGo.TabIndex = 8
        Me.btnGo.Text = "Show"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOpid)
        Me.GroupBox1.Controls.Add(Me.lblOperator)
        Me.GroupBox1.Controls.Add(Me.lblTransactor)
        Me.GroupBox1.Controls.Add(Me.lblBal)
        Me.GroupBox1.Controls.Add(Me.lblAmount)
        Me.GroupBox1.Controls.Add(Me.lbltranstype)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblAcc)
        Me.GroupBox1.Controls.Add(Me.lbltransid)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(631, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 295)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Infomation"
        '
        'lblOpid
        '
        Me.lblOpid.AutoSize = True
        Me.lblOpid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpid.Location = New System.Drawing.Point(116, 213)
        Me.lblOpid.Name = "lblOpid"
        Me.lblOpid.Size = New System.Drawing.Size(45, 13)
        Me.lblOpid.TabIndex = 30
        Me.lblOpid.Text = "Label35"
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.Location = New System.Drawing.Point(116, 190)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(45, 13)
        Me.lblOperator.TabIndex = 29
        Me.lblOperator.Text = "Label34"
        '
        'lblTransactor
        '
        Me.lblTransactor.AutoSize = True
        Me.lblTransactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactor.Location = New System.Drawing.Point(116, 168)
        Me.lblTransactor.Name = "lblTransactor"
        Me.lblTransactor.Size = New System.Drawing.Size(45, 13)
        Me.lblTransactor.TabIndex = 28
        Me.lblTransactor.Text = "Label33"
        '
        'lblBal
        '
        Me.lblBal.AutoSize = True
        Me.lblBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBal.Location = New System.Drawing.Point(116, 144)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(45, 13)
        Me.lblBal.TabIndex = 27
        Me.lblBal.Text = "Label32"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(116, 121)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(45, 13)
        Me.lblAmount.TabIndex = 26
        Me.lblAmount.Text = "Label31"
        '
        'lbltranstype
        '
        Me.lbltranstype.AutoSize = True
        Me.lbltranstype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltranstype.Location = New System.Drawing.Point(116, 96)
        Me.lbltranstype.Name = "lbltranstype"
        Me.lbltranstype.Size = New System.Drawing.Size(45, 13)
        Me.lbltranstype.TabIndex = 25
        Me.lbltranstype.Text = "Label30"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(116, 73)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(45, 13)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "Label29"
        '
        'lblAcc
        '
        Me.lblAcc.AutoSize = True
        Me.lblAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcc.Location = New System.Drawing.Point(116, 51)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(45, 13)
        Me.lblAcc.TabIndex = 23
        Me.lblAcc.Text = "Label28"
        '
        'lbltransid
        '
        Me.lbltransid.AutoSize = True
        Me.lbltransid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransid.Location = New System.Drawing.Point(116, 29)
        Me.lbltransid.Name = "lbltransid"
        Me.lbltransid.Size = New System.Drawing.Size(45, 13)
        Me.lbltransid.TabIndex = 14
        Me.lbltransid.Text = "Label27"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 213)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 13)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Operator ID:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 190)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 13)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Operator:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(13, 168)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 13)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Transactor name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Balance:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 121)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Amount:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Transaction type:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(13, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Date:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(13, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 13)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Account number:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 13)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Transaction ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblEmpadd)
        Me.GroupBox2.Controls.Add(Me.lblEmployer)
        Me.GroupBox2.Controls.Add(Me.lblEmail)
        Me.GroupBox2.Controls.Add(Me.lblFax)
        Me.GroupBox2.Controls.Add(Me.lblPhone)
        Me.GroupBox2.Controls.Add(Me.lblNic)
        Me.GroupBox2.Controls.Add(Me.lblNation)
        Me.GroupBox2.Controls.Add(Me.lblAddress)
        Me.GroupBox2.Controls.Add(Me.lblBday)
        Me.GroupBox2.Controls.Add(Me.lblGender)
        Me.GroupBox2.Controls.Add(Me.lblCrdt)
        Me.GroupBox2.Controls.Add(Me.lblAcctype)
        Me.GroupBox2.Controls.Add(Me.lblBalance)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.lblAccnum)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 391)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 214)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Infomation"
        '
        'lblEmpadd
        '
        Me.lblEmpadd.AutoSize = True
        Me.lblEmpadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpadd.Location = New System.Drawing.Point(424, 165)
        Me.lblEmpadd.Name = "lblEmpadd"
        Me.lblEmpadd.Size = New System.Drawing.Size(45, 13)
        Me.lblEmpadd.TabIndex = 42
        Me.lblEmpadd.Text = "Label32"
        '
        'lblEmployer
        '
        Me.lblEmployer.AutoSize = True
        Me.lblEmployer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployer.Location = New System.Drawing.Point(425, 143)
        Me.lblEmployer.Name = "lblEmployer"
        Me.lblEmployer.Size = New System.Drawing.Size(45, 13)
        Me.lblEmployer.TabIndex = 41
        Me.lblEmployer.Text = "Label31"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(425, 120)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 13)
        Me.lblEmail.TabIndex = 40
        Me.lblEmail.Text = "Label30"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.Location = New System.Drawing.Point(425, 95)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(45, 13)
        Me.lblFax.TabIndex = 39
        Me.lblFax.Text = "Label29"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(424, 70)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(45, 13)
        Me.lblPhone.TabIndex = 38
        Me.lblPhone.Text = "Label28"
        '
        'lblNic
        '
        Me.lblNic.AutoSize = True
        Me.lblNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNic.Location = New System.Drawing.Point(425, 48)
        Me.lblNic.Name = "lblNic"
        Me.lblNic.Size = New System.Drawing.Size(45, 13)
        Me.lblNic.TabIndex = 37
        Me.lblNic.Text = "Label27"
        '
        'lblNation
        '
        Me.lblNation.AutoSize = True
        Me.lblNation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNation.Location = New System.Drawing.Point(424, 24)
        Me.lblNation.Name = "lblNation"
        Me.lblNation.Size = New System.Drawing.Size(45, 13)
        Me.lblNation.TabIndex = 36
        Me.lblNation.Text = "Label26"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(110, 187)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 35
        Me.lblAddress.Text = "Label25"
        '
        'lblBday
        '
        Me.lblBday.AutoSize = True
        Me.lblBday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBday.Location = New System.Drawing.Point(110, 165)
        Me.lblBday.Name = "lblBday"
        Me.lblBday.Size = New System.Drawing.Size(45, 13)
        Me.lblBday.TabIndex = 34
        Me.lblBday.Text = "Label24"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(110, 143)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 33
        Me.lblGender.Text = "Label23"
        '
        'lblCrdt
        '
        Me.lblCrdt.AutoSize = True
        Me.lblCrdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrdt.Location = New System.Drawing.Point(110, 120)
        Me.lblCrdt.Name = "lblCrdt"
        Me.lblCrdt.Size = New System.Drawing.Size(45, 13)
        Me.lblCrdt.TabIndex = 32
        Me.lblCrdt.Text = "Label22"
        '
        'lblAcctype
        '
        Me.lblAcctype.AutoSize = True
        Me.lblAcctype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctype.Location = New System.Drawing.Point(110, 95)
        Me.lblAcctype.Name = "lblAcctype"
        Me.lblAcctype.Size = New System.Drawing.Size(45, 13)
        Me.lblAcctype.TabIndex = 31
        Me.lblAcctype.Text = "Label21"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(110, 70)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(45, 13)
        Me.lblBalance.TabIndex = 30
        Me.lblBalance.Text = "Label20"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(110, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 13)
        Me.lblName.TabIndex = 29
        Me.lblName.Text = "Label19"
        '
        'lblAccnum
        '
        Me.lblAccnum.AutoSize = True
        Me.lblAccnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccnum.Location = New System.Drawing.Point(110, 24)
        Me.lblAccnum.Name = "lblAccnum"
        Me.lblAccnum.Size = New System.Drawing.Size(45, 13)
        Me.lblAccnum.TabIndex = 14
        Me.lblAccnum.Text = "Label18"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(314, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Nation:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(314, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "NIC number:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(314, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Phone:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(314, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Fax:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(314, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "E-Mail:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(314, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Employer:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Account number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Balance:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Account type:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Created on:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Birthday:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Employer address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(308, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Search in:"
        '
        'cmbLook
        '
        Me.cmbLook.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLook.FormattingEnabled = True
        Me.cmbLook.Items.AddRange(New Object() {"trans_id", "acc_num", "trans_date", "trans_type", "trans_amount", "balance", "transactor_name", "operator", "operator_id"})
        Me.cmbLook.Location = New System.Drawing.Point(365, 262)
        Me.cmbLook.Name = "cmbLook"
        Me.cmbLook.Size = New System.Drawing.Size(121, 21)
        Me.cmbLook.TabIndex = 12
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(492, 263)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 20)
        Me.txtsearch.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDeposit)
        Me.GroupBox3.Controls.Add(Me.btnWithdrawal)
        Me.GroupBox3.Controls.Add(Me.txtsearch)
        Me.GroupBox3.Controls.Add(Me.DataGrid1)
        Me.GroupBox3.Controls.Add(Me.cmbLook)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtTransid)
        Me.GroupBox3.Controls.Add(Me.btnGo)
        Me.GroupBox3.Controls.Add(Me.btnViewid)
        Me.GroupBox3.Controls.Add(Me.rdoWithdrawals)
        Me.GroupBox3.Controls.Add(Me.rdoAll)
        Me.GroupBox3.Controls.Add(Me.rdoDeposits)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(606, 295)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transactions"
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(14, 262)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(96, 23)
        Me.btnDeposit.TabIndex = 17
        Me.btnDeposit.Text = "New Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Location = New System.Drawing.Point(114, 262)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(103, 23)
        Me.btnWithdrawal.TabIndex = 18
        Me.btnWithdrawal.Text = "New Withdrawal"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(116, 19)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 13)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Transactions"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(116, 38)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(269, 26)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Select the transaction on the transactions table to view " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "it's contents and rela" & _
            "ted account infomation"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.labCraccounts)
        Me.GroupBox4.Controls.Add(Me.labTransactions)
        Me.GroupBox4.Controls.Add(Me.labDetails)
        Me.GroupBox4.Controls.Add(Me.labAddress)
        Me.GroupBox4.Controls.Add(Me.labGender)
        Me.GroupBox4.Controls.Add(Me.labPerm)
        Me.GroupBox4.Controls.Add(Me.labName)
        Me.GroupBox4.Controls.Add(Me.l1)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.labOperatorid)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.l6s)
        Me.GroupBox4.Controls.Add(Me.l5)
        Me.GroupBox4.Controls.Add(Me.l4)
        Me.GroupBox4.Controls.Add(Me.l3)
        Me.GroupBox4.Controls.Add(Me.l2)
        Me.GroupBox4.Location = New System.Drawing.Point(631, 391)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(273, 214)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Operator Infomation"
        '
        'labCraccounts
        '
        Me.labCraccounts.AutoSize = True
        Me.labCraccounts.Location = New System.Drawing.Point(116, 187)
        Me.labCraccounts.Name = "labCraccounts"
        Me.labCraccounts.Size = New System.Drawing.Size(45, 13)
        Me.labCraccounts.TabIndex = 33
        Me.labCraccounts.Text = "Label44"
        '
        'labTransactions
        '
        Me.labTransactions.AutoSize = True
        Me.labTransactions.Location = New System.Drawing.Point(116, 165)
        Me.labTransactions.Name = "labTransactions"
        Me.labTransactions.Size = New System.Drawing.Size(45, 13)
        Me.labTransactions.TabIndex = 32
        Me.labTransactions.Text = "Label43"
        '
        'labDetails
        '
        Me.labDetails.AutoSize = True
        Me.labDetails.Location = New System.Drawing.Point(116, 143)
        Me.labDetails.Name = "labDetails"
        Me.labDetails.Size = New System.Drawing.Size(45, 13)
        Me.labDetails.TabIndex = 31
        Me.labDetails.Text = "Label42"
        '
        'labAddress
        '
        Me.labAddress.AutoSize = True
        Me.labAddress.Location = New System.Drawing.Point(116, 120)
        Me.labAddress.Name = "labAddress"
        Me.labAddress.Size = New System.Drawing.Size(45, 13)
        Me.labAddress.TabIndex = 30
        Me.labAddress.Text = "Label41"
        '
        'labGender
        '
        Me.labGender.AutoSize = True
        Me.labGender.Location = New System.Drawing.Point(116, 95)
        Me.labGender.Name = "labGender"
        Me.labGender.Size = New System.Drawing.Size(45, 13)
        Me.labGender.TabIndex = 29
        Me.labGender.Text = "Label40"
        '
        'labPerm
        '
        Me.labPerm.AutoSize = True
        Me.labPerm.Location = New System.Drawing.Point(116, 70)
        Me.labPerm.Name = "labPerm"
        Me.labPerm.Size = New System.Drawing.Size(45, 13)
        Me.labPerm.TabIndex = 28
        Me.labPerm.Text = "Label39"
        '
        'labName
        '
        Me.labName.AutoSize = True
        Me.labName.Location = New System.Drawing.Point(116, 48)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(45, 13)
        Me.labName.TabIndex = 19
        Me.labName.Text = "Label38"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Location = New System.Drawing.Point(13, 48)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(38, 13)
        Me.l1.TabIndex = 27
        Me.l1.Text = "Name:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(13, 24)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(65, 13)
        Me.Label36.TabIndex = 26
        Me.Label36.Text = "Operator ID:"
        '
        'labOperatorid
        '
        Me.labOperatorid.AutoSize = True
        Me.labOperatorid.Location = New System.Drawing.Point(116, 24)
        Me.labOperatorid.Name = "labOperatorid"
        Me.labOperatorid.Size = New System.Drawing.Size(45, 13)
        Me.labOperatorid.TabIndex = 25
        Me.labOperatorid.Text = "Label35"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(13, 187)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(94, 13)
        Me.Label34.TabIndex = 24
        Me.Label34.Text = "Created accounts:"
        '
        'l6s
        '
        Me.l6s.AutoSize = True
        Me.l6s.Location = New System.Drawing.Point(13, 165)
        Me.l6s.Name = "l6s"
        Me.l6s.Size = New System.Drawing.Size(71, 13)
        Me.l6s.TabIndex = 23
        Me.l6s.Text = "Transactions:"
        '
        'l5
        '
        Me.l5.AutoSize = True
        Me.l5.Location = New System.Drawing.Point(13, 143)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(42, 13)
        Me.l5.TabIndex = 22
        Me.l5.Text = "Details:"
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.Location = New System.Drawing.Point(13, 120)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(48, 13)
        Me.l4.TabIndex = 21
        Me.l4.Text = "Address:"
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Location = New System.Drawing.Point(13, 95)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(45, 13)
        Me.l3.TabIndex = 20
        Me.l3.Text = "Gender:"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Location = New System.Drawing.Point(13, 70)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(60, 13)
        Me.l2.TabIndex = 19
        Me.l2.Text = "Permission:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Image = Global.IDM_Bank.My.Resources.Resources.imfages
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmAlltrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(917, 617)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlltrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTransid As System.Windows.Forms.TextBox
    Friend WithEvents btnViewid As System.Windows.Forms.Button
    Friend WithEvents rdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDeposits As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWithdrawals As System.Windows.Forms.RadioButton
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLook As System.Windows.Forms.ComboBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
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
    Friend WithEvents lblEmpadd As System.Windows.Forms.Label
    Friend WithEvents lblEmployer As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblNic As System.Windows.Forms.Label
    Friend WithEvents lblNation As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblBday As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblCrdt As System.Windows.Forms.Label
    Friend WithEvents lblAcctype As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAccnum As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblOpid As System.Windows.Forms.Label
    Friend WithEvents lblOperator As System.Windows.Forms.Label
    Friend WithEvents lblTransactor As System.Windows.Forms.Label
    Friend WithEvents lblBal As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lbltranstype As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblAcc As System.Windows.Forms.Label
    Friend WithEvents lbltransid As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents btnWithdrawal As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents labOperatorid As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents l6s As System.Windows.Forms.Label
    Friend WithEvents l5 As System.Windows.Forms.Label
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents labCraccounts As System.Windows.Forms.Label
    Friend WithEvents labTransactions As System.Windows.Forms.Label
    Friend WithEvents labDetails As System.Windows.Forms.Label
    Friend WithEvents labAddress As System.Windows.Forms.Label
    Friend WithEvents labGender As System.Windows.Forms.Label
    Friend WithEvents labPerm As System.Windows.Forms.Label
    Friend WithEvents labName As System.Windows.Forms.Label
End Class
