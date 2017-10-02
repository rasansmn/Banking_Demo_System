Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class dlgOptions
    Dim idmdb As New dbconnect
    Dim intLogcounter, intUnamecounter As Integer

    Private Sub btnUpuname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpuname.Click
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT COUNT (*) from security WHERE username = '" & txtUname.Text & "' AND password = '" & getmd5(txtPw.Text) & "' AND acc_num ='" & intAccnum & "'", idmdb.objcon)
            intLogcounter = cmd.ExecuteScalar
            Dim cmd2 As New SqlCommand("SELECT COUNT (*) from security WHERE username = '" & txtNewuname.Text & "'", idmdb.objcon)
            intUnamecounter = cmd2.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
        If txtUname.Text = "" Then
            MessageBox.Show("Please enter your current username", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUname.Focus()
        ElseIf txtPw.Text = "" Then
            MessageBox.Show("Please enter your current password", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPw.Focus()
        ElseIf intLogcounter = 0 Then
            MessageBox.Show("Invalid login information, please check your username and password", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPw.Focus()
        ElseIf intUnamecounter > 0 Then
            MessageBox.Show("This username is already exist, please choose an another", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewuname.Focus()
        Else
            Try
                idmdb.Open()
                Dim cmdup2 As New SqlCommand("UPDATE security SET username = '" & txtNewuname.Text & "' WHERE acc_num ='" & intAccnum & "'", idmdb.objcon)
                cmdup2.ExecuteNonQuery()
                MessageBox.Show("Records updated successfully", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                idmdb.Close()
            End Try
        End If
    End Sub

    Sub clear()
        txtUname.Clear()
        txtPw.Clear()
        txtNewuname.Clear()
        txtOldpw.Clear()
        txtNewpw.Clear()
        txtCpw.Clear()
    End Sub

    Private Sub btnUppw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUppw.Click
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT COUNT (*) from security WHERE password = '" & getmd5(txtOldpw.Text) & "' AND acc_num ='" & intAccnum & "'", idmdb.objcon)
            intLogcounter = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try

        If txtOldpw.Text = "" Then
            MessageBox.Show("Please enter your current password", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPw.Focus()
        ElseIf txtNewpw.Text = "" Then
            MessageBox.Show("Please type the new password", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewpw.Focus()
        ElseIf intLogcounter = 0 Then
            MessageBox.Show("Invalid login information, please check your current password", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPw.Focus()
        ElseIf txtNewpw.Text.Length < 6 Then
            MessageBox.Show("New password must contain atleast 6 chractors", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewpw.Focus()
        ElseIf txtNewpw.Text <> txtCpw.Text Then
            MessageBox.Show("Confirm new password does not match", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCpw.Focus()
        Else
            Try
                idmdb.Open()
                Dim cmdup2 As New SqlCommand("UPDATE security SET password = '" & getmd5(txtNewpw.Text) & "' WHERE acc_num ='" & intAccnum & "'", idmdb.objcon)
                cmdup2.ExecuteNonQuery()
                MessageBox.Show("Records updated successfully", "Change Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                idmdb.Close()
            End Try
        End If
    End Sub
    
   
    Private Sub btnCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel2.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
