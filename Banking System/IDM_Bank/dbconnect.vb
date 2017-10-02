Public Class dbconnect
    Public objcon As New SqlClient.SqlConnection

    Sub Open()
        objcon.ConnectionString = "Integrated Security=True; Data Source=.\SQLEXPRESS; initial catalog=idm_bankdb;"
        objcon.Open()
    End Sub

    Sub Close()
        objcon.Close()
    End Sub

End Class
