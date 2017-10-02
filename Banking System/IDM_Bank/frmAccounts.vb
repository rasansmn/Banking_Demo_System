Imports System.Data.SqlClient

Public Class frmAccounts
    Dim idmdb As New dbconnect
    Dim accsqlquery As String = "SELECT * FROM account"
    Dim transsqlquery As String = "SELECT * from transactions WHERE acc_num = '" & intlookfor & "'"
    Dim intCounter As Integer

    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If intPerm = 3 Then
            btnEdit.Visible = True
            btnDelete.Visible = True
        End If
        showaccgrid()
        Dim rown As Integer = DataGrid1.CurrentRowIndex
        intlookfor = DataGrid1.Item(rown, 0)
        showacc()
        showtrans()
    End Sub

    Sub showaccgrid()
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter(accsqlquery, idmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "account")
            DataGrid1.SetDataBinding(dset, "account")
            DataGrid1.DataSource = dset
            DataGrid1.DataMember = "account"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Sub showacc()
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT * from account WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read = True
                lblAccnum.Text = read("acc_num").ToString
                lblName.Text = read("name").ToString
                lblBalance.Text = read("acc_balance").ToString
                lblAcctype.Text = read("acc_type").ToString
                lblCrdt.Text = read("created_on").ToString
                lblGender.Text = read("gender").ToString
                lblbday.Text = read("birthday").ToString
                lblAddress.Text = read("per_add").ToString
                lblNation.Text = read("nation").ToString
                lblNic.Text = read("nic_num").ToString
                lblPhone.Text = read("phone").ToString
                lblFax.Text = read("fax").ToString
                lblEmail.Text = read("email").ToString
                lblEmployer.Text = read("employer").ToString
                lblEmpadd.Text = read("emp_add").ToString
                lblDetails.Text = read("details").ToString
            End While
            read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Sub showtrans()
        transsqlquery = "SELECT * from transactions WHERE acc_num = '" & intlookfor & "'"
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter(transsqlquery, idmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "transactions")
            DataGrid2.SetDataBinding(dset, "transactions")

            DataGrid2.DataSource = dset
            DataGrid2.DataMember = "transactions"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        Dim rown As Integer = DataGrid1.CurrentRowIndex
        intlookfor = DataGrid1.Item(rown, 0)
        showacc()
        showtrans()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT COUNT (*) from account WHERE acc_num = '" & Val(txtAccnum.Text) & "'", idmdb.objcon)
            intCounter = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
        If intCounter < 1 Then
            MessageBox.Show("This account number is not valid", "Go", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAccnum.Focus()
        Else
            intlookfor = txtAccnum.Text
            accsqlquery = "SELECT * from account WHERE acc_num = '" & intlookfor & "'"
            showaccgrid()
            showacc()
            showtrans()
        End If
    End Sub
    
    Private Sub btnAllacc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllacc.Click
        accsqlquery = "SELECT * FROM account"
        showaccgrid()
        showacc()
        showtrans()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If intlookfor = 0 Then
            MessageBox.Show("Please select an account from table", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmEditaccount.Show()
            frmEditaccount.MdiParent = frmMain
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Account number: " & intlookfor & vbCrLf & vbCrLf & "This account and it's all transaction details will be deleted", "Warning", MessageBoxButtons.OKCancel)
        If result = Windows.Forms.DialogResult.OK Then
            Try
                idmdb.Open()
                Dim cmddelacc As New SqlCommand("DELETE from account WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
                cmddelacc.ExecuteNonQuery()
                Dim cmddelsec As New SqlCommand("DELETE from security WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
                cmddelsec.ExecuteNonQuery()
                Dim cmddeltrans As New SqlCommand("DELETE from transactions WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
                cmddeltrans.ExecuteNonQuery()
                MessageBox.Show("Records deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                idmdb.Close()
            End Try
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If Trim(cmbLook.Text) <> "" Then
            accsqlquery = "SELECT * FROM account WHERE " & cmbLook.Text & " like '%" & txtSearch.Text & "%'"
            Try
                idmdb.Open()
                Dim dadapt As New SqlClient.SqlDataAdapter(accsqlquery, idmdb.objcon)
                Dim dset As New Data.DataSet
                dset.Clear()
                dadapt.Fill(dset, "account")
                DataGrid1.SetDataBinding(dset, "account")
                DataGrid1.DataSource = dset
                DataGrid1.DataMember = "account"
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                idmdb.Close()
            End Try
        End If
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        frmDeposit.Show()
        frmDeposit.MdiParent = frmMain
    End Sub

    Private Sub btnWithdrawal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdrawal.Click
        frmWithdrawal.Show()
        frmWithdrawal.MdiParent = frmMain
    End Sub

    Private Sub btnNewacc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewacc.Click
        frmOpenacc.Show()
        frmOpenacc.MdiParent = frmMain
    End Sub

End Class