<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOptions
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnUpuname = New System.Windows.Forms.Button
        Me.txtNewuname = New System.Windows.Forms.TextBox
        Me.txtPw = New System.Windows.Forms.TextBox
        Me.txtUname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnCancel2 = New System.Windows.Forms.Button
        Me.btnUppw = New System.Windows.Forms.Button
        Me.txtCpw = New System.Windows.Forms.TextBox
        Me.txtNewpw = New System.Windows.Forms.TextBox
        Me.txtOldpw = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(324, 171)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnUpuname)
        Me.TabPage1.Controls.Add(Me.txtNewuname)
        Me.TabPage1.Controls.Add(Me.txtPw)
        Me.TabPage1.Controls.Add(Me.txtUname)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(316, 145)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Username"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnUpuname
        '
        Me.btnUpuname.Location = New System.Drawing.Point(147, 109)
        Me.btnUpuname.Name = "btnUpuname"
        Me.btnUpuname.Size = New System.Drawing.Size(75, 23)
        Me.btnUpuname.TabIndex = 1
        Me.btnUpuname.Text = "Update"
        Me.btnUpuname.UseVisualStyleBackColor = True
        '
        'txtNewuname
        '
        Me.txtNewuname.Location = New System.Drawing.Point(125, 77)
        Me.txtNewuname.Name = "txtNewuname"
        Me.txtNewuname.Size = New System.Drawing.Size(179, 20)
        Me.txtNewuname.TabIndex = 6
        '
        'txtPw
        '
        Me.txtPw.Location = New System.Drawing.Point(125, 49)
        Me.txtPw.Name = "txtPw"
        Me.txtPw.Size = New System.Drawing.Size(179, 20)
        Me.txtPw.TabIndex = 5
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(125, 20)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(179, 20)
        Me.txtUname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(228, 109)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCancel2)
        Me.TabPage2.Controls.Add(Me.btnUppw)
        Me.TabPage2.Controls.Add(Me.txtCpw)
        Me.TabPage2.Controls.Add(Me.txtNewpw)
        Me.TabPage2.Controls.Add(Me.txtOldpw)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(316, 145)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Password"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCancel2
        '
        Me.btnCancel2.Location = New System.Drawing.Point(228, 109)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel2.TabIndex = 7
        Me.btnCancel2.Text = "Cancel"
        Me.btnCancel2.UseVisualStyleBackColor = True
        '
        'btnUppw
        '
        Me.btnUppw.Location = New System.Drawing.Point(147, 109)
        Me.btnUppw.Name = "btnUppw"
        Me.btnUppw.Size = New System.Drawing.Size(75, 23)
        Me.btnUppw.TabIndex = 6
        Me.btnUppw.Text = "Update"
        Me.btnUppw.UseVisualStyleBackColor = True
        '
        'txtCpw
        '
        Me.txtCpw.Location = New System.Drawing.Point(125, 77)
        Me.txtCpw.Name = "txtCpw"
        Me.txtCpw.Size = New System.Drawing.Size(179, 20)
        Me.txtCpw.TabIndex = 5
        '
        'txtNewpw
        '
        Me.txtNewpw.Location = New System.Drawing.Point(125, 49)
        Me.txtNewpw.Name = "txtNewpw"
        Me.txtNewpw.Size = New System.Drawing.Size(179, 20)
        Me.txtNewpw.TabIndex = 4
        '
        'txtOldpw
        '
        Me.txtOldpw.Location = New System.Drawing.Point(125, 20)
        Me.txtOldpw.Name = "txtOldpw"
        Me.txtOldpw.Size = New System.Drawing.Size(179, 20)
        Me.txtOldpw.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Confirm password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "New password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Old password:"
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 190)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOptions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewuname As System.Windows.Forms.TextBox
    Friend WithEvents txtPw As System.Windows.Forms.TextBox
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents txtCpw As System.Windows.Forms.TextBox
    Friend WithEvents txtNewpw As System.Windows.Forms.TextBox
    Friend WithEvents txtOldpw As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnUpuname As System.Windows.Forms.Button
    Friend WithEvents btnCancel2 As System.Windows.Forms.Button
    Friend WithEvents btnUppw As System.Windows.Forms.Button

End Class
