Imports System.Data.OleDb
Public Class login

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        login2()
        login1()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure want to close this application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Application.Exit()
        End If
    End Sub
    Sub login2()
        config.dbConnection()
        cmd = New OleDbCommand("SELECT * FROM tbluser", conn)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "tbluser")
        dt = ds.Tables("tbluser")
    End Sub
    Sub login1()
        If tbUser.Text = "" And tbPass.Text = "" Then
            MessageBox.Show("Input username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbUser.Focus()
            Exit Sub
        ElseIf tbUser.Text = "" Then
            MessageBox.Show("Input username", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbUser.Focus()
            Exit Sub
        ElseIf tbPass.Text = "" Then
            MessageBox.Show("Input password", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbPass.Focus()
            Exit Sub
        End If
        Dim username As String = tbUser.Text
        Dim password As String = tbPass.Text
        Static errorCount As Integer = 1
        For Each row As DataRow In dt.Rows
            If row("Username").ToString() = username AndAlso row("Password").ToString() = password Then
                Dim userType As String = row("UserType").ToString()
                If userType = "Admin" Then
                    If MessageBox.Show("Login as administrator", "", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                        Me.Hide()
                        frmMain.Show()
                        frmMain.btnUser.Enabled = True
                        frmMain.btnStock.Enabled = True
                        frmMain.btnReport.Enabled = True
                        frmMain.btnCashier.Enabled = True
                        Me.Hide()
                        errorCount = 1
                    End If

                    Exit Sub
                ElseIf userType = "Cashier" Then
                    If MessageBox.Show("Login as cashier", "", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                        Me.Hide()
                        frmMain.Show()
                        frmMain.btnUser.Enabled = False
                        frmMain.btnStock.Enabled = False
                        frmMain.btnReport.Enabled = True
                        frmMain.btnCashier.Enabled = True
                        Me.Hide()
                        errorCount = 1
                    End If

                    Exit Sub
                ElseIf userType = "User" Then
                    If MessageBox.Show("Login as user", "", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                        Me.Hide()
                        frmMain.Show()
                        frmMain.btnUser.Enabled = False
                        frmMain.btnStock.Enabled = True
                        frmMain.btnReport.Enabled = False
                        frmMain.btnCashier.Enabled = False
                        Me.Hide()
                        errorCount = 1
                    End If

                End If
                Exit Sub
            ElseIf (errorCount = 3) Then
                If MessageBox.Show("Too many login attempts", "", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                    Me.Hide()
                    Application.Exit()
                End If
                Exit Sub
                Return
            End If
        Next
        If MessageBox.Show("You have to 3 attempts to login (" & errorCount & " attempt)" & vbCrLf & "Wrong username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
            errorCount = errorCount + 1
            tbUser.Text = ""
            tbPass.Text = ""
            tbUser.Focus()
        End If
        Exit Sub
    End Sub
End Class
