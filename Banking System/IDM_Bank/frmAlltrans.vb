Imports System.Data.SqlClient
Public Class frmAlltrans
    Dim idmdb As New dbconnect
    Dim querystring As String = "SELECT * FROM transactions"
    Dim intTransid, intCounter, intOperatorid As Integer

    Private Sub frmAlltrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
        Dim rown As Integer = DataGrid1.CurrentRowIndex
        intlookfor = DataGrid1.Item(rown, 1)
        intTransid = DataGrid1.Item(rown, 0)
        intOperatorid = DataGrid1.Item(rown, 8)
        showacc()
        showtrans()
        showoperator()
    End Sub

    Sub loadgrid()
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter(querystring, idmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "transactions")
            DataGrid1.SetDataBinding(dset, "transactions")
            DataGrid1.DataSource = dset
            DataGrid1.DataMember = "transactions"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Sub showtrans()
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT * from transactions WHERE acc_num = '" & intlookfor & "' AND trans_id = '" & intTransid & "'", idmdb.objcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read = True
                lbltransid.Text = read("trans_id").ToString
                lblAcc.Text = read("acc_num").ToString
                lblDate.Text = read("trans_date").ToString
                lbltranstype.Text = read("trans_type").ToString
                lblAmount.Text = read("trans_amount").ToString
                lblBal.Text = read("balance").ToString
                lblTransactor.Text = read("transactor_name").ToString
                lblOperator.Text = read("operator").ToString
                lblOpid.Text = read("operator_id").ToString
            End While
            read.Close()
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
                lblBday.Text = read("birthday").ToString
                lblAddress.Text = read("per_add").ToString
                lblNation.Text = read("nation").ToString
                lblNic.Text = read("nic_num").ToString
                lblPhone.Text = read("phone").ToString
                lblFax.Text = read("fax").ToString
                lblEmail.Text = read("email").ToString
                lblEmployer.Text = read("employer").ToString
                lblEmpadd.Text = read("emp_add").ToString
            End While
            read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Sub showoperator()
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT * from officers WHERE acc_num = '" & intOperatorid & "'", idmdb.objcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read = True
                labOperatorid.Text = read("acc_num").ToString
                labName.Text = read("name").ToString
                labPerm.Text = read("permission").ToString
                labGender.Text = read("gender").ToString
                labAddress.Text = read("address").ToString
                labTransactions.Text = read("transactions").ToString
                labCraccounts.Text = read("created_accounts").ToString
            End While
            read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        Dim rown As Integer = DataGrid1.CurrentRowIndex
        intlookfor = DataGrid1.Item(rown, 1)
        intTransid = DataGrid1.Item(rown, 0)
        intOperatorid = DataGrid1.Item(rown, 8)
        showacc()
        showtrans()
        showoperator()
    End Sub

    Private Sub rdoAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoAll.CheckedChanged
        querystring = "SELECT * FROM transactions"
    End Sub

    Private Sub rdoDeposits_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDeposits.CheckedChanged
        querystring = "SELECT * FROM transactions WHERE trans_type ='Deposit'"
    End Sub

    Private Sub rdoWithdrawals_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWithdrawals.CheckedChanged
        querystring = "SELECT * FROM transactions WHERE trans_type ='Withdrawal'"
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Dim rown As Integer = DataGrid1.CurrentRowIndex
        intlookfor = DataGrid1.Item(rown, 1)
        intTransid = DataGrid1.Item(rown, 0)
        intOperatorid = DataGrid1.Item(rown, 8)
        loadgrid()
        showacc()
        showtrans()
        showoperator()
    End Sub

    Private Sub btnViewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewid.Click
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT COUNT (*) from transactions WHERE trans_id = '" & Val(txtTransid.Text) & "'", idmdb.objcon)
            intCounter = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
        If intCounter = 0 Then
            MessageBox.Show("This transaction ID is not valid", "Go", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransid.Focus()
        Else
            querystring = "SELECT * from transactions WHERE trans_id = '" & Val(txtTransid.Text) & "'"
            loadgrid()
            Dim rown As Integer = DataGrid1.CurrentRowIndex
            intlookfor = DataGrid1.Item(rown, 1)
            intTransid = DataGrid1.Item(rown, 0)
            intOperatorid = DataGrid1.Item(rown, 8)
            showacc()
            showtrans()
            showoperator()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If Trim(cmbLook.Text) <> "" Then
            Try
                idmdb.Open()
                Dim dadapt As New SqlClient.SqlDataAdapter("SELECT * FROM transactions WHERE " & cmbLook.Text & " like '%/" & txtsearch.Text & "/%'", idmdb.objcon)
                Dim dset As New Data.DataSet
                dset.Clear()
                dadapt.Fill(dset, "transactions")
                DataGrid1.SetDataBinding(dset, "transactions")
                DataGrid1.DataSource = dset
                DataGrid1.DataMember = "transactions"
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
End Class