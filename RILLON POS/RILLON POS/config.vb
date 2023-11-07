Imports System.Data.OleDb
Module config
    Public dt As DataTable
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dbcon As String

    Sub dbConnection()
        conn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source= " & Application.StartupPath & "\dbase.accdb;Persist Security Info=False;Jet OLEDB:Database Password=AccountSecured;")
        conn.Open()
    End Sub
    '"Provider = Microsoft.ACE.OLEDB.12.0;Data Source= " & Application.StartupPath & "\dbase.accdb;Persist Security Info=False;Jet OLEDB:Database Password=AccountSecured;"
    Function getDataTable(ByVal SQL As String) As DataTable
        dbConnection()
        Dim cmd As New OleDbCommand(SQL, conn)
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Module
