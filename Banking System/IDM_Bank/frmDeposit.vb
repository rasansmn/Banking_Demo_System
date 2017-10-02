Imports System.Data.SqlClient
Public Class frmDeposit
    Dim idmdb As New dbconnect
    Dim intCounter, intTranscounter, intNewtransid, intMytransactions As Integer
    Dim strAmount As String
    Dim amount, balance, newbalance As Double
    Sub loadgrid()
        Try
            idmdb.Open()
            Dim dadapt As New SqlClient.SqlDataAdapter("SELECT * FROM transactions WHERE trans_type ='Deposit' ORDER BY trans_id DESC", idmdb.objcon)
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
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        strAmount = txtRs.Text + "." + txtCts.Text
        amount = Val(strAmount)

        If Trim(txtAccnum.Text) <> "." Then
            Try
                idmdb.Open()
                Dim cmd As New SqlCommand("SELECT COUNT (*) from account WHERE acc_num = '" & Val(txtAccnum.Text) & "'", idmdb.objcon)
                intCounter = cmd.ExecuteScalar
                Dim cmd2 As New SqlCommand("SELECT acc_balance from account where acc_num = '" & Val(txtAccnum.Text) & "'", idmdb.objcon)
                balance = cmd2.ExecuteScalar
                Dim cmd4 As New SqlCommand("SELECT COUNT (*) from transactions", idmdb.objcon)
                intTranscounter = cmd4.ExecuteScalar
                If intTranscounter > 0 Then
                    Dim getid As New SqlCommand("SELECT max(trans_id) from transactions", idmdb.objcon)
                    intNewtransid = getid.ExecuteScalar
                End If
                intNewtransid = intNewtransid + 1
                Dim cmd5 As New SqlCommand("SELECT transactions from officers WHERE acc_num = '" & intAccnum & "'", idmdb.objcon)
                intMytransactions = cmd5.ExecuteScalar
                intMytransactions = intMytransactions + 1
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                idmdb.Close()
            End Try
        End If

        If Trim(txtAccnum.Text) = "" Then
            MessageBox.Show("Please fill the account number", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAccnum.Focus()
        ElseIf intCounter < 1 Or IsNumeric(txtAccnum.Text) = False Then
            MessageBox.Show("This account number is not valid", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAccnum.Focus()
        ElseIf Trim(txtRs.Text) = "" And Trim(txtCts.Text) = "" Then
            MessageBox.Show("Please fill the amount", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRs.Focus()
        ElseIf IsNumeric(txtRs.Text) = False Or IsNumeric(txtCts.Text) = False Then
            MessageBox.Show("Please enter a valid amount", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRs.Focus()
        ElseIf Trim(txtName.Text) = "" Then
            MessageBox.Show("Please fill the name", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
        
        Else
            newbalance = balance + amount
            Dim result As DialogResult = MessageBox.Show("You are going to do a new transaction" & vbCrLf & vbCrLf & "Account number: " & txtAccnum.Text & vbCrLf & "Current balance: Rs." & balance & vbCrLf & "Transaction amount: Rs." & amount & vbCrLf & "New balance will be: Rs." & newbalance & vbCrLf & vbCrLf & "Proceed this transaction?", "New Deposit", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Try
                    idmdb.Open()
                    Dim cmdup As New SqlCommand("UPDATE account SET acc_balance = '" & newbalance & "' WHERE acc_num ='" & txtAccnum.Text & "'", idmdb.objcon)
                    cmdup.ExecuteNonQuery()
                    Dim cmdin As New SqlCommand("INSERT INTO transactions VALUES (" & intNewtransid & "," & txtAccnum.Text & ",'" & DateTime.Now & "','Deposit','" & amount & "','" & newbalance & "','" & txtName.Text & "','" & strName & "','" & intAccnum & "')", idmdb.objcon)
                    cmdin.ExecuteNonQuery()
                    Dim cmdup2 As New SqlCommand("UPDATE officers SET transactions = '" & intMytransactions & "' WHERE acc_num ='" & intAccnum & "'", idmdb.objcon)
                    cmdup2.ExecuteNonQuery()
                    MessageBox.Show("Records updated successfully", "New Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    idmdb.Close()
                    loadgrid()
                End Try
            End If
        End If
    End Sub

    Sub clear()
        txtAccnum.Clear()
        txtName.Clear()
        txtRs.Clear()
        txtCts.Clear()
        txtAccnum.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
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
            MessageBox.Show("This account number is not valid", "Account Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAccnum.Focus()
        Else
            Try
                idmdb.Open()
                Dim cmd As New SqlCommand("SELECT * from account WHERE acc_num = '" & txtAccnum.Text & "'", idmdb.objcon)
                Dim read As SqlDataReader = cmd.ExecuteReader
                While read.Read = True
                    Dim result As DialogResult = MessageBox.Show("Information of this account number" & vbCrLf & vbCrLf & "Account number: " & read("acc_num") & vbCrLf & "Current balance: " & read("acc_balance") & vbCrLf & "Name: " & read("name") & vbCrLf & "Gender: " & read("gender") & vbCrLf & "Permanent address: " & read("per_add") & vbCrLf & "Nation: " & read("nation") & vbCrLf & "NIC num: " & read("nic_num") & vbCrLf & "Phone: " & read("phone") & vbCrLf & "Fax: " & read("fax") & vbCrLf & "E-mail: " & read("email") & vbCrLf & "Employer: " & read("employer") & vbCrLf & "Employer address: " & read("emp_add") & vbCrLf & "Created on: " & read("created_on"), "Account Details", MessageBoxButtons.OK)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                idmdb.Close()
            End Try
        End If
    End Sub

    Private Sub frmDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
    End Sub
End Class