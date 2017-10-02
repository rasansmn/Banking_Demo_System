Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmMain
    Dim idmdb As New dbconnect

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loggedoff()
        Dim counter As Integer
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT COUNT (*) from security WHERE permission = 3", idmdb.objcon)
            counter = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
        If counter = 0 Then
            If MessageBox.Show("IDM Banking System couldn't found any manager accounts in the database. Do you want to setup an account now?", "Initialize - IDM Banking System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                frmAddofficer.Show()
                frmAddofficer.MdiParent = Me
            End If
        End If
        update_interest()
    End Sub

    Sub loggedoff()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        menuMain.Hide()
        toolOfficer.Hide()
        ToolClient.Hide()
        ToolLogin.Show()
        CaccountMenu.Visible = False
        OaccountMenu.Visible = False
        OTransactionsMenu.Visible = False
        OfficersMenu.Visible = False
        ConfigureToolStripMenuItem.Visible = False
        ToolStripSeparator4.Visible = False
        tbtnConfigure.Visible = False
        tbtnOfficers.Visible = False
        ToolStripSeparator16.Visible = False
        ToolStripSeparator7.Visible = False
        lblStatusstrip.Text = "Enter your username and password to continue"
        Me.Text = "IDM Banking System"
        ttxtUsername.Focus()
        ttxtPassword.Clear()
        intPerm = 0
    End Sub

    Private Sub tbtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnLogin.Click
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT acc_num, permission from security WHERE username = '" + ttxtUsername.Text + "' AND password = '" + getmd5(ttxtPassword.Text) + "'", idmdb.objcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read = True
                intPerm = read("permission")
                intAccnum = read("acc_num")
            End While
            read.Close()
            If intPerm = 0 Then
                MessageBox.Show("Invalid login, please check your username and password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf intPerm = 1 Then
                Dim cmd2 As New SqlCommand("SELECT name from account WHERE acc_num = '" + intAccnum.ToString + "'", idmdb.objcon)
                strName = cmd2.ExecuteScalar
                ToolLogin.Hide()
                ToolClient.Show()
                menuMain.Show()
                CaccountMenu.Visible = True
                lblStatusstrip.Text = "Operator: " + strName
                Me.Text = "IDM Banking System - Client Panel"
            ElseIf intPerm = 2 Then
                Dim cmd2 As New SqlCommand("SELECT name from officers WHERE acc_num = '" + intAccnum.ToString + "'", idmdb.objcon)
                strName = cmd2.ExecuteScalar
                ToolLogin.Hide()
                toolOfficer.Show()
                menuMain.Show()
                OaccountMenu.Visible = True
                OTransactionsMenu.Visible = True
                lblStatusstrip.Text = "Operator: " + strName
                Me.Text = "IDM Banking System - Clerk Panel"
            ElseIf intPerm = 3 Then
                Dim cmd2 As New SqlCommand("SELECT name from officers WHERE acc_num = '" + intAccnum.ToString + "'", idmdb.objcon)
                strName = cmd2.ExecuteScalar
                ToolLogin.Hide()
                toolOfficer.Show()
                menuMain.Show()
                OaccountMenu.Visible = True
                OTransactionsMenu.Visible = True
                OfficersMenu.Visible = True
                ConfigureToolStripMenuItem.Visible = True
                ToolStripSeparator4.Visible = True
                tbtnConfigure.Visible = True
                tbtnOfficers.Visible = True
                ToolStripSeparator16.Visible = True
                ToolStripSeparator7.Visible = True
                lblStatusstrip.Text = "Operator: " + strName
                Me.Text = "IDM Banking System - Manager Panel"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Private Sub tbtnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnDeposit.Click
        frmDeposit.Show()
        frmDeposit.MdiParent = Me
    End Sub

    Private Sub tbtnWithdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnWithdrawal.Click
        frmWithdrawal.Show()
        frmWithdrawal.MdiParent = Me
    End Sub

    Private Sub tbtnAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnAccounts.Click
        frmAccounts.Show()
        frmAccounts.MdiParent = Me
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmMyaccount.Show()
        frmMyaccount.MdiParent = Me
    End Sub

    Private Sub GeneralAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmOpenacc.Show()
        frmOpenacc.MdiParent = Me
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        loggedoff()
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllToolStripMenuItem.Click
        frmAlltrans.Show()
        frmAlltrans.MdiParent = Me
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        dlgOptions.Show()
        dlgOptions.MdiParent = Me
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnMytrans.Click
        frmMytrans.Show()
        frmMytrans.MdiParent = Me
    End Sub

    Private Sub tbtnOpenacc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnOpenacc.Click
        frmOpenacc.Show()
        frmOpenacc.MdiParent = Me
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutIDMBank.Show()
        AboutIDMBank.MdiParent = Me
    End Sub

    Private Sub AddOfficerMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOfficerMenu.Click
        frmAddofficer.Show()
        frmAddofficer.MdiParent = Me
    End Sub

    Private Sub tbtnStatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnStatement.Click
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE acc_num = '" & intAccnum & "' AND trans_date like '%" & Now.Month.ToString & "%'", idmdb.objcon)
            Dim dset As New DSstate
            dset.Clear()
            dadapt.Fill(dset, "tblTrans")
            Dim dadapt2 As New SqlClient.SqlDataAdapter("SELECT name, acc_num, acc_balance from account WHERE acc_num = '" & intAccnum & "'", idmdb.objcon)
            dadapt2.Fill(dset, "tblAcc")
            Dim rep As New rptMstate
            rep.Refresh()
            Dim c As New frmStatement(dset, rep)
            c.Show()
            c.MdiParent = Me
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Private Sub tbtnCloptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnCloptions.Click
        dlgOptions.Show()
        dlgOptions.MdiParent = Me
    End Sub

    Private Sub tbtnCllogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnCllogout.Click
        loggedoff()
    End Sub

    Private Sub tbtnTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnTransactions.Click
        frmAlltrans.Show()
        frmAlltrans.MdiParent = Me
    End Sub

    Private Sub tbtnOfoptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnOfoptions.Click
        dlgOptions.Show()
        dlgOptions.MdiParent = Me
    End Sub

    Private Sub tbtnOflogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnOflogout.Click
        loggedoff()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub tbtnOfficers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnOfficers.Click
        frmOfficers.Show()
        frmOfficers.MdiParent = Me
    End Sub

    Private Sub tbtnConfigure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnConfigure.Click
        frmAdminsettings.Show()
        frmAdminsettings.MdiParent = Me
    End Sub

    Private Sub OpenAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAccountToolStripMenuItem.Click
        frmOpenacc.Show()
        frmOpenacc.MdiParent = Me
    End Sub

    Private Sub AllAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllAccountsToolStripMenuItem.Click
        frmAccounts.Show()
        frmAccounts.MdiParent = Me
    End Sub

    Private Sub ConfigureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigureToolStripMenuItem.Click
        frmAdminsettings.Show()
        frmAdminsettings.MdiParent = Me
    End Sub

    Private Sub MyaccToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyaccToolStripMenuItem.Click
        frmMyaccount.Show()
        frmMyaccount.MdiParent = Me
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        frmMytrans.Show()
        frmMytrans.MdiParent = Me
    End Sub

    Private Sub StatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatementToolStripMenuItem.Click
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE acc_num = '" & intAccnum & "' AND trans_date like '%" & Now.Month.ToString & "%'", idmdb.objcon)
            Dim dset As New DSstate
            dset.Clear()
            dadapt.Fill(dset, "tblTrans")
            Dim dadapt2 As New SqlClient.SqlDataAdapter("SELECT name, acc_num, acc_balance from account WHERE acc_num = '" & intAccnum & "'", idmdb.objcon)
            dadapt2.Fill(dset, "tblAcc")
            Dim rep As New rptMstate
            rep.Refresh()
            Dim c As New frmStatement(dset, rep)
            c.Show()
            c.MdiParent = Me
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Private Sub WithdrawalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawalToolStripMenuItem.Click
        frmWithdrawal.Show()
        frmWithdrawal.MdiParent = Me
    End Sub

    Private Sub AllofficersMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllofficersMenu.Click
        frmOfficers.Show()
        frmOfficers.MdiParent = Me
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        If intPerm = 2 Then
            frmClerkhelp.Show()
            frmClerkhelp.MdiParent = Me
        ElseIf intPerm = 3 Then
            frmManagerhelp.Show()
            frmManagerhelp.MdiParent = Me
        Else
            frmClienthelp.Show()
            frmClienthelp.MdiParent = Me
        End If
    End Sub

    Private Sub tbtnOfhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnOfhelp.Click
        If intPerm = 2 Then
            frmClerkhelp.Show()
            frmClerkhelp.MdiParent = Me
        Else
            frmManagerhelp.Show()
            frmManagerhelp.MdiParent = Me
        End If
    End Sub

    Private Sub tbtnClhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnClhelp.Click
        frmClienthelp.Show()
        frmClienthelp.MdiParent = Me
    End Sub

    Sub update_interest()
        Dim curbal, newbal, rate, interest As Double
        Dim month As Integer
        Dim acctype As String
        Dim irow As DataRow
        Try
            idmdb.Open()
            Dim cmdgetmonth As New SqlCommand("SELECT value from settings WHERE field ='Lastup'", idmdb.objcon)
            month = cmdgetmonth.ExecuteScalar
            If month <> Now.Month Then
                Dim dapubcb As New SqlDataAdapter("select * from account", idmdb.objcon)
                Dim dspubcb As New DataSet("pubcb")
                Dim commandbuilder_dspubcb As SqlCommandBuilder = New SqlCommandBuilder(dapubcb)
                dapubcb.Fill(dspubcb, "pubcb")
                For Each irow In dspubcb.Tables(0).Rows
                    acctype = irow("acc_type")
                    Dim cmd As New SqlCommand("SELECT value from settings WHERE field ='" & acctype & "'", idmdb.objcon)
                    rate = cmd.ExecuteScalar
                    curbal = irow("acc_balance")
                    interest = curbal * rate / 100
                    newbal = curbal + interest
                    irow("acc_balance") = newbal
                Next
                dapubcb.Update(dspubcb, "pubcb")
                Dim cmdup As New SqlCommand("UPDATE settings SET value = '" & Now.Month.ToString & "' WHERE field ='Lastup'", idmdb.objcon)
                cmdup.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

End Class
