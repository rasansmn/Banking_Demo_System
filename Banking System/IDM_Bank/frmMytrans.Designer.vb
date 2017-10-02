<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMytrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMytrans))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnGo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTransid = New System.Windows.Forms.TextBox
        Me.btnViewid = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdolast10 = New System.Windows.Forms.RadioButton
        Me.rdoAll = New System.Windows.Forms.RadioButton
        Me.rdoDeposits = New System.Windows.Forms.RadioButton
        Me.rdoWithdrawals = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.DataGrid1.CaptionText = "My Transactions"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.Black
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Wheat
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid1.Location = New System.Drawing.Point(14, 132)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.Wheat
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid1.Size = New System.Drawing.Size(538, 210)
        Me.DataGrid1.TabIndex = 0
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(259, 15)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(44, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Transaction ID:"
        '
        'txtTransid
        '
        Me.txtTransid.Location = New System.Drawing.Point(88, 15)
        Me.txtTransid.Name = "txtTransid"
        Me.txtTransid.Size = New System.Drawing.Size(71, 20)
        Me.txtTransid.TabIndex = 5
        '
        'btnViewid
        '
        Me.btnViewid.Location = New System.Drawing.Point(165, 15)
        Me.btnViewid.Name = "btnViewid"
        Me.btnViewid.Size = New System.Drawing.Size(44, 23)
        Me.btnViewid.TabIndex = 6
        Me.btnViewid.Text = "Go"
        Me.btnViewid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnViewid)
        Me.GroupBox1.Controls.Add(Me.txtTransid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 46)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdolast10)
        Me.GroupBox2.Controls.Add(Me.rdoAll)
        Me.GroupBox2.Controls.Add(Me.rdoDeposits)
        Me.GroupBox2.Controls.Add(Me.rdoWithdrawals)
        Me.GroupBox2.Controls.Add(Me.btnGo)
        Me.GroupBox2.Location = New System.Drawing.Point(240, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 46)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'rdolast10
        '
        Me.rdolast10.AutoSize = True
        Me.rdolast10.Checked = True
        Me.rdolast10.Location = New System.Drawing.Point(9, 19)
        Me.rdolast10.Name = "rdolast10"
        Me.rdolast10.Size = New System.Drawing.Size(60, 17)
        Me.rdolast10.TabIndex = 10
        Me.rdolast10.TabStop = True
        Me.rdolast10.Text = "Last 10"
        Me.rdolast10.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Location = New System.Drawing.Point(75, 19)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(36, 17)
        Me.rdoAll.TabIndex = 11
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'rdoDeposits
        '
        Me.rdoDeposits.AutoSize = True
        Me.rdoDeposits.Location = New System.Drawing.Point(111, 19)
        Me.rdoDeposits.Name = "rdoDeposits"
        Me.rdoDeposits.Size = New System.Drawing.Size(66, 17)
        Me.rdoDeposits.TabIndex = 12
        Me.rdoDeposits.Text = "Deposits"
        Me.rdoDeposits.UseVisualStyleBackColor = True
        '
        'rdoWithdrawals
        '
        Me.rdoWithdrawals.AutoSize = True
        Me.rdoWithdrawals.Location = New System.Drawing.Point(177, 19)
        Me.rdoWithdrawals.Name = "rdoWithdrawals"
        Me.rdoWithdrawals.Size = New System.Drawing.Size(83, 17)
        Me.rdoWithdrawals.TabIndex = 13
        Me.rdoWithdrawals.Text = "Withdrawals"
        Me.rdoWithdrawals.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "My Transactions"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Image = Global.IDM_Bank.My.Resources.Resources.imfages
        Me.PictureBox1.Location = New System.Drawing.Point(42, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmMytrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 354)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMytrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Transactions"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTransid As System.Windows.Forms.TextBox
    Friend WithEvents btnViewid As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdolast10 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDeposits As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWithdrawals As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
