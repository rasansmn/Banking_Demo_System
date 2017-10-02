Imports System.Data.SqlClient

Public Class frmEditofficer
    Dim idmdb As New dbconnect
    Dim strAcc As String
    Dim intChperm As Integer

    Private Sub frmEditofficer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT * from officers WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read = True
                strAcc = read("acc_num").ToString
                txtName.Text = read("name").ToString
                cmbPerm.Text = read("permission").ToString
                cmbGender.Text = read("gender").ToString
                DatePicker.Text = read("birthday").ToString
                txtPeradd.Text = read("address").ToString
                txtNic.Text = read("nic_num").ToString
                txtPhone.Text = read("phone").ToString
                txtEmail.Text = read("email").ToString   
                txtDetails.Text = read("details").ToString
            End While
            read.Close()
            Dim cmd2 As New SqlCommand("SELECT username from security WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
            txtUname.Text = cmd2.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
        If cmbPerm.Text = "Manager" Then
            intChperm = 3
        Else
            intChperm = 2
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim counter As Integer
        Dim username As String
        Try
            idmdb.Open()
            Dim readuname As New SqlCommand("SELECT username from security WHERE acc_num = '" & intlookfor & "'", idmdb.objcon)
            username = readuname.ExecuteScalar
            If username <> txtUname.Text Then
                Dim cmd As New SqlCommand("SELECT COUNT (*) from security WHERE username = '" & txtUname.Text & "'", idmdb.objcon)
                counter = cmd.ExecuteScalar
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try

        If intlookfor = 0 Then
            MessageBox.Show("Invalid operation", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Trim(txtName.Text) = "" Then
            MessageBox.Show("Please fill the full name", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
        ElseIf Trim(cmbGender.Text) = "" Then
            MessageBox.Show("Please select the gender", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Trim(txtPeradd.Text) = "" Then
            MessageBox.Show("Please fill the permanent address", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPeradd.Focus()
        ElseIf Trim(txtNic.Text) = "" Then
            MessageBox.Show("Please fill the NIC num.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNic.Focus()
        ElseIf Trim(txtUname.Text) = "" Then
            MessageBox.Show("Please fill the username", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUname.Focus()
        ElseIf Trim(txtUname.Text.Length) < 4 Then
            MessageBox.Show("Username must contain atleast 4 charactors", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUname.Focus()
        ElseIf counter > 0 Then
            MessageBox.Show("This username alredy exist, please choose an another", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUname.Focus()
        Else
            Dim result As DialogResult = MessageBox.Show("You are going to update officer account" & vbCrLf & vbCrLf & "Account number: " & strAcc & vbCrLf & "Name: " & txtName.Text & vbCrLf & "Gender: " & cmbGender.Text & vbCrLf & "Address: " & txtPeradd.Text & vbCrLf & "NIC num: " & txtNic.Text & vbCrLf & "Phone: " & txtPhone.Text & vbCrLf & "E-mail: " & txtEmail.Text & vbCrLf & "Deatils: " & txtDetails.Text & vbCrLf & "Username: " & txtUname.Text & vbCrLf & vbCrLf & "Is above details are correct?", "Update", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Try
                    idmdb.Open()
                    Dim cmdup As New SqlCommand("UPDATE officers SET name ='" & txtName.Text & "', permission ='" & cmbPerm.Text & "', gender ='" & cmbGender.Text & "', birthday ='" & DatePicker.Value & "', address ='" & txtPeradd.Text & "', nic_num ='" & txtNic.Text & "', phone ='" & txtPhone.Text & "', email ='" & txtEmail.Text & "', details ='" & txtDetails.Text & "' WHERE acc_num ='" & intlookfor & "'", idmdb.objcon)
                    cmdup.ExecuteNonQuery()
                    Dim cmdup2 As New SqlCommand("UPDATE security SET username = '" & txtUname.Text & "', permission = " & intChperm & " WHERE acc_num ='" & intlookfor & "'", idmdb.objcon)
                    cmdup2.ExecuteNonQuery()
                    MessageBox.Show("Records updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    idmdb.Close()
                    Me.Close()
                End Try
            End If
        End If
    End Sub

    
    Private Sub btnUpdatepw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdatepw.Click
        If Trim(txtPw.Text) = "" Then
            MessageBox.Show("Please fill the password", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPw.Focus()
        ElseIf Trim(txtPw.Text.Length) < 4 Then
            MessageBox.Show("Password must contain atleast 4 charactors", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPw.Focus()
        Else
            Dim result As DialogResult = MessageBox.Show("You are going to update officer account" & vbCrLf & vbCrLf & "Account number: " & strAcc & vbCrLf & "Password: " & txtPw.Text & vbCrLf & vbCrLf & "Is above details are correct?", "Update", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Try
                    idmdb.Open()
                    Dim cmdup As New SqlCommand("UPDATE security SET password = '" & getmd5(txtPw.Text) & "' WHERE acc_num ='" & intlookfor & "'", idmdb.objcon)
                    cmdup.ExecuteNonQuery()
                    MessageBox.Show("Records updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    idmdb.Close()
                    Me.Close()
                End Try
            End If
        End If
    End Sub

End Class