Imports System.Text
Imports System.Security.Cryptography

Module Module1
    Public intPerm, intAccnum, intRowitem, intlookfor As Integer
    Public pubName, strName, strAcctype, strRefer As String

    Public Function getmd5(ByVal SourceText As String) As String
        Dim Ue As New UnicodeEncoding()
        Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
        Dim Md5 As New MD5CryptoServiceProvider()
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        Return Convert.ToBase64String(ByteHash)
    End Function

End Module
