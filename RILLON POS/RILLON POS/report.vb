Imports System.Data.OleDb
Public Class report

    Private Sub report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dg.ReadOnly = True
        dg.AllowUserToAddRows = False
        reportRecords()
    End Sub
    Sub reportRecords()
        Try
            dbcon = "SELECT  * FROM tblreport "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader
            dg.Rows.Clear()
            Do While dr.Read = True
                dg.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub tbSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbSearch.TextChanged
        Try
            dbcon = "SELECT * FROM tblreport where TransactionID LIKE '" & Trim(tbSearch.Text) & "%'"

            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dg.Rows.Clear()
            Do While dr.Read = True
                dg.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FileToolStripMenuItem.Click
        Me.Hide()
        tbSearch.Text = ""
        frmMain.Show()
    End Sub

    Private Sub RefeshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefeshToolStripMenuItem.Click
        tbSearch.Text = ""
        reportRecords()
    End Sub
End Class