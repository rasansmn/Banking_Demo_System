Imports System.Data.SqlClient

Public Class frmAdminsettings
    Dim idmdb As New dbconnect

    Private Sub frmAdminsettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            idmdb.Open()
            Dim cmd As New SqlCommand("SELECT * from settings WHERE field = 'General Savings'", idmdb.objcon)
            Dim read As SqlDataReader = cmd.ExecuteReader
            While read.Read = True
                txtDepgeneral.Text = read("basic_dep").ToString
                txtrategeneral.Text = read("value").ToString
            End While
            read.Close()
            Dim cmd2 As New SqlCommand("SELECT * from settings WHERE field = 'Yes'", idmdb.objcon)
            read = cmd2.ExecuteReader
            While read.Read = True
                txtDepyes.Text = read("basic_dep").ToString
                txtRateyes.Text = read("value").ToString
            End While
            read.Close()
            Dim cmd3 As New SqlCommand("SELECT * from settings WHERE field = 'Wanitha wasana'", idmdb.objcon)
            read = cmd3.ExecuteReader
            While read.Read = True
                txtDepwanitha.Text = read("basic_dep").ToString
                txtRatewanitha.Text = read("value").ToString
            End While
            read.Close()
            Dim cmd4 As New SqlCommand("SELECT * from settings WHERE field = 'Janajaya'", idmdb.objcon)
            read = cmd4.ExecuteReader
            While read.Read = True
                txtDepjanajaya.Text = read("basic_dep").ToString
                txtRatejanajaya.Text = read("value").ToString
            End While
            read.Close()
            Dim cmd5 As New SqlCommand("SELECT * from settings WHERE field = 'Parinatha'", idmdb.objcon)
            read = cmd5.ExecuteReader
            While read.Read = True
                txtDepparinatha.Text = read("basic_dep").ToString
                txtRateparinatha.Text = read("value").ToString
            End While
            read.Close()
            Dim cmd6 As New SqlCommand("SELECT * from settings WHERE field = 'Dhanayojana'", idmdb.objcon)
            read = cmd6.ExecuteReader
            While read.Read = True
                txtDepdhanayojana.Text = read("basic_dep").ToString
                txtRatedhanayojana.Text = read("value").ToString
            End While
            read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            idmdb.Open()
            Dim cmdup As New SqlCommand("UPDATE settings SET value = '" & Val(txtrategeneral.Text) & "', basic_dep = " & Val(txtDepgeneral.Text) & " WHERE field ='General savings'", idmdb.objcon)
            cmdup.ExecuteNonQuery()
            Dim cmdup2 As New SqlCommand("UPDATE settings SET value = '" & Val(txtRateyes.Text) & "', basic_dep = " & Val(txtDepyes.Text) & " WHERE field ='Yes'", idmdb.objcon)
            cmdup2.ExecuteNonQuery()
            Dim cmdup3 As New SqlCommand("UPDATE settings SET value = '" & Val(txtRatewanitha.Text) & "', basic_dep = " & Val(txtDepwanitha.Text) & " WHERE field ='Wanitha wasana'", idmdb.objcon)
            cmdup3.ExecuteNonQuery()
            Dim cmdup4 As New SqlCommand("UPDATE settings SET value = '" & Val(txtRatejanajaya.Text) & "', basic_dep = " & Val(txtDepjanajaya.Text) & " WHERE field ='Janajaya'", idmdb.objcon)
            cmdup4.ExecuteNonQuery()
            Dim cmdup5 As New SqlCommand("UPDATE settings SET value = '" & Val(txtRateparinatha.Text) & "', basic_dep = " & Val(txtDepparinatha.Text) & " WHERE field ='Parinatha'", idmdb.objcon)
            cmdup5.ExecuteNonQuery()
            Dim cmdup6 As New SqlCommand("UPDATE settings SET value = '" & Val(txtRatedhanayojana.Text) & "', basic_dep = " & Val(txtDepdhanayojana.Text) & " WHERE field ='Dhanayojana'", idmdb.objcon)
            cmdup6.ExecuteNonQuery()
            MessageBox.Show("Records updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            idmdb.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class