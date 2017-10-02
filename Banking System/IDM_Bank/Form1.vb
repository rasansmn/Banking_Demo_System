Imports System.Data.SqlClient
Public Class frmOpenacc
    Dim idmdb As New dbconnect
    Dim StrActype As String = "General savings"
    Dim strAmount As String
    Dim amount As Double

    Private Sub rdoGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoGeneral.CheckedChanged
        StrActype = "General savings"
    End Sub

    Private Sub rdoYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoYes.CheckedChanged
        StrActype = "Yes"
    End Sub

    Private Sub rdoWanitha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWanitha.CheckedChanged
        StrActype = "Wanitha wasana"
    End Sub

    Private Sub rdoJanajaya_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoJanajaya.CheckedChanged
        StrActype = "Janajaya"
    End Sub

    Private Sub rdoParinatha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoParinatha.CheckedChanged
        StrActype = "Parinatha"
    End Sub

    Private Sub rdoDhanayojana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDhanayojana.CheckedChanged
        StrActype = "Dhanayojana"
    End Sub


    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        strAmount = txtRs.Text + "." + txtCts.Text
        amount = Val(strAmount)
        Dim counter, seccounter, transcounter, newaccnum, newtransid, mytransactions, myaccounts As Integer
        Dim basicdeposit As Double
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT COUNT (*) from security WHERE username = '" + txtuname.Text + "'", idmdb.objcon)
            counter = cmd.ExecuteScalar
            Dim cmd2 As New SqlCommand("SELECT COUNT (*) from security", idmdb.objcon)
            seccounter = cmd2.ExecuteScalar
            If seccounter > 0 Then
                Dim cmd3 As New SqlCommand("SELECT max(acc_num) from security", idmdb.objcon)
                newaccnum = cmd3.ExecuteScalar
            End If
            newaccnum = newaccnum + 1
            Dim cmd4 As New SqlCommand("SELECT COUNT (*) from transactions", idmdb.objcon)
            transcounter = cmd4.ExecuteScalar
            If transcounter > 0 Then
                Dim getid As New SqlCommand("SELECT max(trans_id) from transactions", idmdb.objcon)
                newtransid = getid.ExecuteScalar
            End If
            newtransid = newtransid + 1
            Dim cmd5 As New SqlCommand("SELECT transactions, created_accounts from officers WHERE acc_num = '" & intAccnum & "'", idmdb.objcon)
            Dim read As SqlDataReader = cmd5.ExecuteReader
            While read.Read = True
                mytransactions = read("transactions")
                myaccounts = read("created_accounts")
            End While
            read.Close()
            mytransactions = mytransactions + 1
            myaccounts = myaccounts + 1
            Dim cmd6 As New SqlCommand("SELECT basic_dep from settings WHERE field = '" & StrActype & "'", idmdb.objcon)
            basicdeposit = cmd6.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try

        If Trim(txtName.Text) = "" Then
            MessageBox.Show("Please fill the full name", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
        ElseIf Trim(cmbGender.Text) = "" Then
            MessageBox.Show("Please select the gender", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Trim(txtPeradd.Text) = "" Then
            MessageBox.Show("Please fill the permanent address", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPeradd.Focus()
        ElseIf Trim(txtNation.Text) = "" Then
            MessageBox.Show("Please fill the nation", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNation.Focus()
        ElseIf Trim(txtNic.Text) = "" Then
            MessageBox.Show("Please fill the NIC num.", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNic.Focus()
        ElseIf Trim(txtRs.Text) = "" And Trim(txtCts.Text) = "" Then
            MessageBox.Show("Please fill the deposit value", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRs.Focus()
        ElseIf IsNumeric(txtRs.Text) = False Or IsNumeric(txtCts.Text) = False Then
            MessageBox.Show("Please fill a valid deposit value", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRs.Focus()
        ElseIf amount < basicdeposit Then
            MessageBox.Show("This basic deposit amount is not sufficient for " & StrActype & " Account type", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRs.Focus()
        ElseIf Trim(txtuname.Text) = "" Then
            MessageBox.Show("Please fill the username", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuname.Focus()
        ElseIf Trim(txtuname.Text.Length) < 4 Then
            MessageBox.Show("Username must contain atleast 4 charactors", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuname.Focus()
        ElseIf counter > 0 Then
            MessageBox.Show("Username already exist, please choose another", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuname.Focus()
        ElseIf Trim(txtpw.Text) = "" Then
            MessageBox.Show("Please fill the password", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpw.Focus()
        ElseIf txtpw.Text.Length < 6 Then
            MessageBox.Show("Password must contain atleast 6 charactors", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpw.Focus()
        ElseIf txtpw.Text <> txtcpw.Text Then
            MessageBox.Show("Password confirm do not match", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcpw.Focus()
        Else
            Dim result As DialogResult = MessageBox.Show("You are going to add a new account" & vbCrLf & vbCrLf & "Account number: " & newaccnum & vbCrLf & "Basic deposit Rs: " & amount & vbCrLf & "Name: " & txtName.Text & vbCrLf & "Gender: " & cmbGender.Text & vbCrLf & "Permanent address: " & txtPeradd.Text & vbCrLf & "Nation: " & txtNation.Text & vbCrLf & "NIC num: " & txtNic.Text & vbCrLf & "Phone: " & txtPhone.Text & vbCrLf & "Fax: " & txtFax.Text & vbCrLf & "E-mail: " & txtEmail.Text & vbCrLf & "Employer: " & txtEmp.Text & vbCrLf & "Employer address: " & txtEmpadd.Text & vbCrLf & "username: " & txtuname.Text & vbCrLf & "Password: " & txtpw.Text & vbCrLf & vbCrLf & "Is above details are correct?", "New Account", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Try
                    idmdb.Open()
                    Dim in_query As String = "INSERT INTO account VALUES (" & newaccnum & ",'" & txtDetails.Text & "','" & StrActype & "','" & amount & "','" & txtName.Text & "','" & datepicker.Value & "','" & cmbGender.Text & "','" & txtPeradd.Text & "','" & txtNation.Text & "','" & txtNic.Text & "','" & txtPhone.Text & "','" & txtFax.Text & "','" & txtEmail.Text & "','" & txtEmp.Text & "','" & txtEmpadd.Text & "','" & DateTime.Now & "','" & intAccnum & "')"
                    Dim cmd As New SqlCommand(in_query, idmdb.objcon)
                    cmd.ExecuteNonQuery()
                    Dim cmd2 As New SqlCommand("INSERT INTO security VALUES (" & newaccnum & ",'" & txtuname.Text & "','" & getmd5(txtpw.Text) & "', '1')", idmdb.objcon)
                    cmd2.ExecuteNonQuery()
                    Dim cmdin As New SqlCommand("INSERT INTO transactions VALUES (" & newtransid & "," & newaccnum & ",'" & DateTime.Now & "','Deposit','" & amount & "','" & amount & "','" & txtName.Text & "','" & strName & "','" & intAccnum & "')", idmdb.objcon)
                    cmdin.ExecuteNonQuery()
                    Dim cmdup As New SqlCommand("UPDATE officers SET transactions = '" & mytransactions & "', created_accounts ='" & myaccounts & "' WHERE acc_num ='" & intAccnum & "'", idmdb.objcon)
                    cmdup.ExecuteNonQuery()
                    MessageBox.Show("Records updated successfully", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    idmdb.Close()
                End Try
            End If
        End If
    End Sub

    Sub clear()
        txtName.Clear()
        txtPeradd.Clear()
        txtNation.Clear()
        txtNic.Clear()
        txtPhone.Clear()
        txtFax.Clear()
        txtEmail.Clear()
        txtEmp.Clear()
        txtEmpadd.Clear()
        txtRs.Clear()
        txtCts.Clear()
        txtuname.Clear()
        txtpw.Clear()
        txtcpw.Clear()
        rdoGeneral.Select()
        txtDetails.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
