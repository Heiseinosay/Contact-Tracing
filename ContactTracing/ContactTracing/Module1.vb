Imports System.Data.SqlClient
Module connection
    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Settings.contactTracing)
        Dim sqlDA As New SqlDataAdapter(Query, sqlCon)
        Dim sqlCB As New SqlCommandBuilder(sqlDA)
        Dim DT As New DataTable
        sqlDA.Fill(DT)
        Return DT
    End Function
End Module
