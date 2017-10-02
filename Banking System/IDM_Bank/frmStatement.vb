Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmStatement
    Dim idmdb As New dbconnect
    Dim dset As DataSet
    Dim myreport As ReportDocument

    Private Sub frmStatement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myreport.SetDataSource(dset)
        CrystalReportViewer1.ReportSource = myreport
    End Sub

    Public Sub New(ByVal ds As DataSet, ByVal rpt As ReportDocument)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        dset = New DataSet
        myreport = New ReportDocument
        dset = ds
        myreport = rpt
        ' Add any initialization after the InitializeComponent() call.
    End Sub
End Class