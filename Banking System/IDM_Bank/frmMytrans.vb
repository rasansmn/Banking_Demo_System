Imports System.Data.SqlClient
Public Class frmMytrans
    Dim idmdb As New dbconnect
    Dim querystring As String = "SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE acc_num = '" & intAccnum & "'"
    Dim intCounter As Integer

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

    Private Sub frmMytrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        querystring = "SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE acc_num = '" & intAccnum & "'"
        loadgrid()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        loadgrid()
    End Sub

    Private Sub rdolast10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdolast10.CheckedChanged
        querystring = "SET ROWCOUNT 10 SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE acc_num = '" & intAccnum & "'"
    End Sub

    Private Sub rdoAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoAll.CheckedChanged
        querystring = "SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE acc_num = '" & intAccnum & "'"
    End Sub

    Private Sub rdoDeposits_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDeposits.CheckedChanged
        querystring = "SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE trans_type = 'Deposit' AND acc_num = '" & intAccnum & "'"
    End Sub

    Private Sub rdoWithdrawals_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWithdrawals.CheckedChanged
        querystring = "SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE trans_type = 'Withdrawal' AND acc_num = '" & intAccnum & "'"
    End Sub

    Private Sub btnViewid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewid.Click
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT COUNT (*) from transactions WHERE trans_id = '" & Val(txtTransid.Text) & "' AND acc_num = '" & intAccnum & "'", idmdb.objcon)
            intCounter = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
        If intCounter < 1 Then
            MessageBox.Show("This transaction is not your", "Go", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTransid.Focus()
        Else
            querystring = "SELECT trans_id, trans_date, trans_amount, trans_type, balance from transactions WHERE trans_id = '" & Val(txtTransid.Text) & "'"
            loadgrid()
        End If
    End Sub
End Class