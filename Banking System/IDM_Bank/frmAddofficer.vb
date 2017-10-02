Imports System.Data.SqlClient
Public Class frmAddofficer
    Dim idmdb As New dbconnect
    Dim StrPerm As String = "Clerk"
    Dim intPer As Integer = 2

    Private Sub rdoClerk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoClerk.CheckedChanged
        StrPerm = "Clerk"
        intper = 2
    End Sub

    Private Sub rdoManager_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoManager.CheckedChanged
        StrPerm = "Manager"
        intper = 3
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim counter, seccounter, newaccnum As Integer
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
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
        '------------------------------------------------------------------------------------------------------------------
        If Trim(txtName.Text) = "" Then
            MessageBox.Show("Please fill the full name", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
        ElseIf Trim(cmbGender.Text) = "" Then
            MessageBox.Show("Please select the gender", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Trim(txtaddress.Text) = "" Then
            MessageBox.Show("Please fill the permanent address", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtaddress.Focus()
        ElseIf Trim(txtNic.Text) = "" Then
            MessageBox.Show("Please fill the NIC num.", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNic.Focus()
        ElseIf Trim(txtuname.Text) = "" Then
            MessageBox.Show("Please fill the username", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuname.Focus()
        ElseIf Trim(txtuname.Text.Length) < 4 Then
            MessageBox.Show("Username must contain atleast 4 charactors", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuname.Focus()
        ElseIf counter > 0 Then
            MessageBox.Show("Username already exist, please choose another", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuname.Focus()
        ElseIf Trim(txtPw.Text) = "" Then
            MessageBox.Show("Please fill the password", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPw.Focus()
        ElseIf txtPw.Text.Length < 6 Then
            MessageBox.Show("Password must contain atleast 6 charactors", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPw.Focus()
        ElseIf txtPw.Text <> txtCpw.Text Then
            MessageBox.Show("Password confirm do not match", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCpw.Focus()
        Else
            Dim result As DialogResult = MessageBox.Show("You are going to add a new bank officer" & vbCrLf & vbCrLf & "Name: " & txtName.Text & vbCrLf & "Permission: " & StrPerm & vbCrLf & "Gender: " & cmbGender.Text & vbCrLf & "Address: " & txtaddress.Text & vbCrLf & "NIC num: " & txtNic.Text & vbCrLf & "Phone: " & txtPhone.Text & vbCrLf & "E-mail: " & txtEmail.Text & vbCrLf & "username: " & txtuname.Text & vbCrLf & "Password: " & txtPw.Text & vbCrLf & vbCrLf & "Is above details are correct?", "New Officer", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Try
                    idmdb.Open()
                    Dim in_query As String = "INSERT INTO officers VALUES (" & newaccnum & ",'" & StrPerm & "','" & txtName.Text & "','" & cmbGender.Text & "','" & datepicker.Value & "','" & txtaddress.Text & "','" & txtNic.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtDetails.Text & "','" & DateTime.Now & "','0','0')"
                    Dim cmd As New SqlCommand(in_query, idmdb.objcon)
                    cmd.ExecuteNonQuery()
                    Dim cmd2 As New SqlCommand("INSERT INTO security VALUES (" & newaccnum & ",'" & txtuname.Text & "','" & getmd5(txtPw.Text) & "', '" & intPer & "')", idmdb.objcon)
                    cmd2.ExecuteNonQuery()
                    MessageBox.Show("Records updated successfully", "New Officer", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        txtaddress.Clear()
        txtNic.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtDetails.Clear()
        txtuname.Clear()
        txtPw.Clear()
        txtCpw.Clear()
        rdoClerk.Select()
        txtName.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class