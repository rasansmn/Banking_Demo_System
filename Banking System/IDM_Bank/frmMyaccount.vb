Imports System.Data.SqlClient

Public Class frmMyaccount
    Dim idmdb As New dbconnect
  
    Private Sub frmMyaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If intPerm = 1 Then
            intlookfor = intAccnum
        Else
            lblCap.Text = "View Account"
            Me.Text = "View Account"
        End If
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
            End While
            read.Close()
            Dim cmd2 As New SqlCommand("SELECT trans_id, trans_date, trans_type, trans_amount, balance from transactions WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
            Dim readtrans As SqlDataReader = cmd2.ExecuteReader
            While readtrans.Read = True
                lbltdate.Text = readtrans("trans_date").ToString
                lblTtype.Text = readtrans("trans_type").ToString
                lblTamount.Text = readtrans("trans_amount").ToString
                lblTbalance.Text = readtrans("balance").ToString
            End While
            readtrans.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Private Sub btnTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransactions.Click
        frmMytrans.Show()
        frmMytrans.MdiParent = frmMain
    End Sub
End Class