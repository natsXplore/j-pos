Public Class receiptForm

    Private Sub receiptForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgReceipt.Columns(0).Width = 10
        dgReceipt.Columns(1).Width = 3
        dgReceipt.Columns(2).Width = 3
        dgReceipt.Columns(3).Width = 50

        dgReceipt.ReadOnly = True
        lblDate.Text = Format(Date.Now, "Short Date")
        lblTime.Text = Format(Date.Now, "Long Time")
    End Sub
    Private Sub resize()
        dgReceipt.Height = dgReceipt.ColumnHeadersHeight + dgReceipt.Rows.Cast(Of DataGridViewRow).Sum(Function(r) (r.Height))
        Panel2.Height = dgReceipt.Height + 430

        dgReceipt.ClearSelection()
    End Sub

    Private Sub dgReceipt_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgReceipt.RowsAdded
        resize()
    End Sub

    Private Sub dgReceipt_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgReceipt.RowsRemoved
        resize()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        cashier.bindStock()
        cashier.btnPay.Enabled = False
        cashier.btnAdd.Enabled = True
        cashier.btnReceipt.Enabled = False
        dgReceipt.ClearSelection()


        cashier.Show()
    End Sub
End Class