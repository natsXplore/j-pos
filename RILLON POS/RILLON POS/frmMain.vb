Public Class frmMain

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Me.Hide()
            login.tbUser.Text = ""
            login.tbPass.Text = ""
            login.tbUser.Select()
            login.Show()
        End If
    End Sub

    Private Sub btnUser_Click(sender As System.Object, e As System.EventArgs) Handles btnUser.Click
        Me.Hide()
        userForm.Show()
    End Sub

    Private Sub btnStock_Click(sender As System.Object, e As System.EventArgs) Handles btnStock.Click
        Me.Hide()
        stockForm.Show()
    End Sub

    Private Sub btnCashier_Click(sender As System.Object, e As System.EventArgs) Handles btnCashier.Click
        Me.Hide()
        cashier.Show()
    End Sub

    Private Sub btnReport_Click(sender As System.Object, e As System.EventArgs) Handles btnReport.Click
        Me.Hide()
        report.Show()
    End Sub
End Class