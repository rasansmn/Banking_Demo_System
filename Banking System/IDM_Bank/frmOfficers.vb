Imports System.Data.SqlClient

Public Class frmOfficers
    Dim idmdb As New dbconnect

    Private Sub frmOfficers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadofficers()
        Dim rown As Integer = GridOfficers.CurrentRowIndex
        intlookfor = GridOfficers.Item(rown, 0)
        showofficer()
        showtransactions()
        showaccounts()
    End Sub

    Sub loadofficers()
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT * FROM officers", idmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "officers")
            GridOfficers.SetDataBinding(dset, "officers")
            GridOfficers.DataSource = dset
            GridOfficers.DataMember = "officers"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Sub showofficer()
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT * from officers WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read = True
                lblAccnum.Text = read("acc_num").ToString
                lblName.Text = read("name").ToString
                lblPermission.Text = read("permission").ToString
                lblGender.Text = read("gender").ToString
                lblBday.Text = read("birthday").ToString
                lblAddress.Text = read("address").ToString
                lblNic.Text = read("nic_num").ToString
                lblDetails.Text = read("details").ToString
                lblPhone.Text = read("phone").ToString
                lblEmail.Text = read("email").ToString
                lblJoined.Text = read("joined_date").ToString
                lblTransactions.Text = read("transactions").ToString
                lblCraccounts.Text = read("created_accounts").ToString
            End While
            read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Sub showtransactions()
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT * FROM transactions WHERE operator_id = '" & intlookfor & "'", idmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "transactions")
            GridTransactions.SetDataBinding(dset, "transactions")
            GridTransactions.DataSource = dset
            GridTransactions.DataMember = "transactions"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Sub showaccounts()
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT * FROM account WHERE created_by = '" & intlookfor & "'", idmdb.objcon)
            Dim dset As New Data.DataSet
            dset.Clear()
            dadapt.Fill(dset, "account")
            GridAccounts.SetDataBinding(dset, "account")
            GridAccounts.DataSource = dset
            GridAccounts.DataMember = "account"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Private Sub GridOfficers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOfficers.Click
        Dim rown As Integer = GridOfficers.CurrentRowIndex
        intlookfor = GridOfficers.Item(rown, 0)
        showofficer()
        showtransactions()
        showaccounts()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If intlookfor = 0 Then
            MessageBox.Show("Please select an officer from table", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmEditofficer.Show()
            frmEditofficer.MdiParent = frmMain
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Officer account : " & intlookfor & vbCrLf & vbCrLf & "This officer account will be deleted", "Warning", MessageBoxButtons.OKCancel)
        If result = Windows.Forms.DialogResult.OK Then
            Try
                idmdb.Open()
                Dim cmddelacc As New SqlCommand("DELETE from officers WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
                cmddelacc.ExecuteNonQuery()
                Dim cmddelsec As New SqlCommand("DELETE from security WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
                cmddelsec.ExecuteNonQuery()
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
            Try
                idmdb.Open()
                Dim dadapt As New SqlClient.SqlDataAdapter("SELECT * FROM officers WHERE " & cmbLook.Text & " like '%" & txtSearch.Text & "%'", idmdb.objcon)
                Dim dset As New Data.DataSet
                dset.Clear()
                dadapt.Fill(dset, "officers")
                GridOfficers.SetDataBinding(dset, "officers")
                GridOfficers.DataSource = dset
                GridOfficers.DataMember = "officers"
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                idmdb.Close()
            End Try
        End If
    End Sub

    Private Sub btnAddofficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddofficer.Click
        frmAddofficer.Show()
        frmAddofficer.MdiParent = frmMain
    End Sub
End Class