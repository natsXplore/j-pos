Imports System.Data.OleDb
Imports System.IO

Public Class cashier
    Private Sub grid()
        receiptForm.dgReceipt.ScrollBars = ScrollBars.None

        receiptForm.dgReceipt.RowHeadersVisible = False
        receiptForm.dgReceipt.ColumnCount = 4

        receiptForm.dgReceipt.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        receiptForm.dgReceipt.CellBorderStyle = DataGridViewCellBorderStyle.None
    End Sub
    Private Sub cashier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dg.ReadOnly = True
        dg.AllowUserToAddRows = False
        loadProduct()
        TransactionID()
        'bindStock()

        tbTransaction.Enabled = False
        tbBarcode.Enabled = True

        comboProductList.Enabled = True

        tbPrice.Enabled = False
        tbStock.Enabled = False
        tbQuantity.Enabled = True
        tbTotal.Enabled = False
        tbCashier.Enabled = False

        tbTotalItems.Enabled = False
        tbTotalAmount.Enabled = False

        tbAmountPaid.Enabled = False
        tbChange.Enabled = False

        btnAdd.Enabled = True
        btnPay.Enabled = False
        btnReceipt.Enabled = False

        delete.Enabled = False

        tbQuantity.Select()

        grid()

        receiptForm.dgReceipt.Columns(0).Name = "Product"
        receiptForm.dgReceipt.Columns(1).Name = "Qty"
        receiptForm.dgReceipt.Columns(2).Name = "Unit price"
        receiptForm.dgReceipt.Columns(3).Name = "Amount"

        receiptForm.dgReceipt.Columns(0).Width = 10
        receiptForm.dgReceipt.Columns(1).Width = 3
        receiptForm.dgReceipt.Columns(2).Width = 3
        receiptForm.dgReceipt.Columns(3).Width = 50
    End Sub
    Private Sub TransactionID()
        Try
            Dim BarcodeID As New Random
            Dim ID As Integer = BarcodeID.Next(1, 1000000000)
            tbTransaction.Text = ID
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addProduct()
        Try
            dbcon = "INSERT INTO tblcashier VALUES( '" & tbTransaction.Text & "', '" & tbBarcode.Text & "', '" & comboProductList.Text & "','" & tbQuantity.Text & "', '" & tbPrice.Text & "','" & tbTotal.Text & "','" & Date.Now & "')"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim num As Integer
            num = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub resize()
        receiptForm.dgReceipt.Height = receiptForm.dgReceipt.ColumnHeadersHeight + receiptForm.dgReceipt.Rows.Cast(Of DataGridViewRow).Sum(Function(r) (r.Height))
        receiptForm.Panel2.Height = receiptForm.dgReceipt.Height + 350

        receiptForm.dgReceipt.ClearSelection()
    End Sub
    Private Sub loadProduct()
        Try
            dbcon = "SELECT BarcodeID,ProductName,Quantity,SellingPrice,TotalAmount FROM tblcashier WHERE TransactionID = '" & Trim(tbTransaction.Text) & "' "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dg.Rows.Clear()
            Do While dr.Read = True
                dg.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub totalAmount()
        Try
            dbcon = "SELECT sum(TotalAmount) FROM tblcashier where TransactionID = '" & Trim(tbTransaction.Text) & "' "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                tbTotalAmount.Text = dr(0)
            Loop
        Catch ex As Exception
        End Try
    End Sub
    Private Sub totalItems()
        Try

            dbcon = "SELECT sum(Quantity) FROM tblcashier where TransactionID = '" & Trim(tbTransaction.Text) & "' "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                tbTotalItems.Text = dr(0)
            Loop
        Catch ex As Exception
        End Try
    End Sub
    Public Sub bindStock()
        Dim str As String = "Select ProductName From tblstock order by ProductName"
        Dim dt As DataTable = getDataTable(str)

        comboProductList.DataSource = dt
        comboProductList.DisplayMember = "ProductName"

        If comboProductList.Items.Count > 0 Then
            comboProductList.SelectedIndex = 0
        End If
    End Sub

    Private Sub back_Click(sender As System.Object, e As System.EventArgs) Handles back.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub comboProductList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboProductList.SelectedIndexChanged
        Try
            dbConnection()
            Dim da As New OleDbDataAdapter(("select * from tblstock where ProductName ='" & Trim(comboProductList.Text) & "'"), conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                tbPrice.Text = dt.Rows(0).Item("SellingPrice") & ""
                tbStock.Text = dt.Rows(0).Item("Stock") & ""
                tbBarcode.Text = dt.Rows(0).Item("BarcodeID") & ""
            End If
            tbQuantity.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbQuantity_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbQuantity.TextChanged
        Try
            Dim amount As Double
            amount = Val(tbPrice.Text) * Val(tbQuantity.Text)
            tbTotal.Text = amount
        Catch ex As Exception
            MessageBox.Show("Do not input some integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub tbAmountPaid_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAmountPaid.TextChanged
        Dim change As Double
        change = Val(tbAmountPaid.Text) - Val(tbTotalAmount.Text)
        tbChange.Text = change.ToString("n2")
    End Sub
    Private Sub reduceStock()
        Try
            dbcon = "UPDATE tblstock set Stock=Stock - '" & Val(tbTotalItems.Text) & "'where BarcodeID='" & tbBarcode.Text & "'"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Try
            Dim stock As Integer = 0
            stock = tbStock.Text
            If tbQuantity.Text = "" Then
                MessageBox.Show("Please enter quantity", "Stock Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf tbQuantity.Text = 0 Then
                MessageBox.Show("Please enter quantity", "Stock Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf tbQuantity.Text > stock Then
                MessageBox.Show("Sorry, Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim rnum As Integer = receiptForm.dgReceipt.Rows.Add


                receiptForm.dgReceipt.Rows.Item(rnum).Cells(0).Value = comboProductList.Text
                receiptForm.dgReceipt.Rows.Item(rnum).Cells(1).Value = tbQuantity.Text
                receiptForm.dgReceipt.Rows.Item(rnum).Cells(2).Value = tbPrice.Text
                receiptForm.dgReceipt.Rows.Item(rnum).Cells(3).Value = tbTotal.Text

                receiptForm.lblTransaction.Text = tbTransaction.Text
                receiptForm.lblCashier.Text = tbCashier.Text
                grid()
                cal()

                tbAmountPaid.Enabled = True

                btnAdd.Enabled = True
                btnPay.Enabled = True
                btnReceipt.Enabled = False

                tbStock.Text = Val(tbStock.Text) - Val(tbQuantity.Text)
                addProduct()
                loadProduct()
                totalAmount()
                totalItems()
                tbTotal.Text = ""
                tbQuantity.Text = ""

                tbAmountPaid.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cal()
        Dim total As Integer = 0
        Dim sum As Double
        For index As Integer = 0 To receiptForm.dgReceipt.RowCount - 1
            total += Convert.ToDouble(receiptForm.dgReceipt.Rows(index).Cells(3).Value.ToString)
        Next
        receiptForm.lblTotalAmount.Text = "PHP " + (total.ToString)
    End Sub
    Private Sub calPayment()
        Dim cash As Integer = tbAmountPaid.Text
        Dim change As Integer = tbChange.Text
        receiptForm.lblCash.Text = "PHP " + (tbAmountPaid.Text)
        receiptForm.lblChange.Text = "PHP " + (tbChange.Text)
    End Sub
    Private Sub calVat()
        Dim vtbl As Double = 1.12
        Dim amount As Double
        Dim total As Integer
        amount = Val(tbTotalAmount.Text) / vtbl
        receiptForm.lblvtbl.Text = Math.Round(amount, 2)
        receiptForm.lblvat.Text = Math.Round(amount * 0.12, 2)
    End Sub

    Private Sub btnPay_Click(sender As System.Object, e As System.EventArgs) Handles btnPay.Click
        If tbAmountPaid.Text = "" Then
            MessageBox.Show("Input amount to proceed.", "Amount paid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbAmountPaid.Focus()
            Exit Sub
        ElseIf tbChange.Text < 0 Then
            MessageBox.Show("You do not have sufficient amount to proceed with this purchase.", "Insufficient Amount", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            dbcon = "INSERT INTO tblreport VALUES('" & tbTransaction.Text & "','" & comboProductList.Text & "', '" & tbTotalItems.Text & "', '" & tbTotalAmount.Text & "','" & tbAmountPaid.Text & "', '" & tbChange.Text & "', '" & Date.Now & "')"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                reduceStock()
                MessageBox.Show("Your purchase was successful.", "Purchase successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TransactionID()
                calPayment()
                calVat()
                receiptForm.lblTotal.Text = "(" + tbTotalItems.Text + ")"
                dg.Rows.Clear()
                tbTotalItems.Text = ""
                tbTotalAmount.Text = ""
                tbAmountPaid.Text = ""
                tbChange.Text = ""

                btnAdd.Enabled = True
                btnPay.Enabled = True
                btnReceipt.Enabled = True
            Else
                MessageBox.Show("Purchase unsuccessful", "Purchase unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnReceipt_Click(sender As System.Object, e As System.EventArgs) Handles btnReceipt.Click
        receiptForm.Show()
    End Sub
    Private Sub deleteProduct()
        Try
            dbcon = "DELETE * FROM tblcashier WHERE BarcodeID like'" & Trim(tbBarcode.Text) & "'"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub delete_Click(sender As System.Object, e As System.EventArgs) Handles delete.Click
        If MessageBox.Show("Are you sure want to delete all items?", "Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            tbStock.Text = ""

            deleteProduct()
            loadProduct()
            tbQuantity.Text = ""
            tbTotal.Text = ""
            tbTotalItems.Text = ""
            tbTotalAmount.Text = ""
            tbAmountPaid.Text = ""
            tbChange.Text = ""
            receiptForm.dgReceipt.Rows.Clear()
            bindStock()
        End If
    End Sub

    Private Sub refresh_Click(sender As System.Object, e As System.EventArgs) Handles refresh.Click
        TransactionID()
        loadProduct()
        tbQuantity.Text = ""
        tbTotal.Text = ""
        tbTotalItems.Text = ""
        tbTotalAmount.Text = ""
        tbAmountPaid.Text = ""
        tbChange.Text = ""
        receiptForm.dgReceipt.Rows.Clear()
        bindStock()
    End Sub

    Private Sub tbQuantity_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbQuantity.KeyDown
        If e.KeyCode = Keys.F2 Then
            tbAmountPaid.Enabled = True
            btnPay.Enabled = True
            tbAmountPaid.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then

            Try
                Dim stock As Integer = 0
                stock = tbStock.Text
                If tbQuantity.Text = "" Then
                    MessageBox.Show("Please enter quantity", "Stock Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf tbQuantity.Text = 0 Then
                    MessageBox.Show("Please enter quantity", "Stock Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf tbQuantity.Text > stock Then
                    MessageBox.Show("Sorry, Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim rnum As Integer = receiptForm.dgReceipt.Rows.Add


                    receiptForm.dgReceipt.Rows.Item(rnum).Cells(0).Value = comboProductList.Text
                    receiptForm.dgReceipt.Rows.Item(rnum).Cells(1).Value = tbQuantity.Text
                    receiptForm.dgReceipt.Rows.Item(rnum).Cells(2).Value = tbPrice.Text
                    receiptForm.dgReceipt.Rows.Item(rnum).Cells(3).Value = tbTotal.Text

                    receiptForm.lblTransaction.Text = tbTransaction.Text
                    receiptForm.lblCashier.Text = tbCashier.Text
                    grid()
                    cal()

                    tbAmountPaid.Enabled = False
                    btnPay.Enabled = False
                    btnAdd.Enabled = True

                    btnReceipt.Enabled = False

                    tbStock.Text = Val(tbStock.Text) - Val(tbQuantity.Text)
                    addProduct()
                    loadProduct()
                    totalAmount()
                    totalItems()
                    tbTotal.Text = ""
                    tbQuantity.Text = ""

                    'tbAmountPaid.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub tbAmountPaid_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbAmountPaid.KeyDown
        If e.KeyCode = Keys.F9 Then
            receiptForm.Show()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            If tbAmountPaid.Text = "" Then
                MessageBox.Show("Input amount to proceed.", "Amount paid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbAmountPaid.Focus()
                Exit Sub
            ElseIf tbChange.Text < 0 Then
                MessageBox.Show("You do not have sufficient amount to proceed with this purchase.", "Insufficient Amount", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Try
                dbcon = "INSERT INTO tblreport VALUES('" & tbTransaction.Text & "','" & comboProductList.Text & "', '" & tbTotalItems.Text & "', '" & tbTotalAmount.Text & "','" & tbAmountPaid.Text & "', '" & tbChange.Text & "', '" & Date.Now & "')"
                dbConnection()
                cmd = New OleDbCommand(dbcon, conn)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    reduceStock()
                    MessageBox.Show("Your purchase was successful.", "Purchase successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TransactionID()
                    calPayment()
                    calVat()
                    receiptForm.lblTotal.Text = "(" + tbTotalItems.Text + ")"
                    dg.Rows.Clear()
                    receiptForm.Show()
                    tbTotalItems.Text = ""
                    tbTotalAmount.Text = ""
                    tbAmountPaid.Text = ""
                    tbChange.Text = ""

                    btnAdd.Enabled = True
                    btnPay.Enabled = True
                    btnReceipt.Enabled = True

                Else
                    MessageBox.Show("Purchase unsuccessful", "Purchase unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub comboProductList_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles comboProductList.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                dbConnection()
                Dim da As New OleDbDataAdapter(("select * from tblstock where ProductName ='" & Trim(comboProductList.Text) & "'"), conn)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    tbPrice.Text = dt.Rows(0).Item("SellingPrice") & ""
                    tbStock.Text = dt.Rows(0).Item("Stock") & ""
                    tbBarcode.Text = dt.Rows(0).Item("BarcodeID") & ""
                End If
                tbQuantity.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ReleaseComObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub tbBarcode_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            bindStock()
        End If
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExcelToolStripMenuItem.Click
        Try
            Dim fileExport As String = Application.StartupPath & "\Exported Excel File\Cashier_Data.xlsx"
            If File.Exists(fileExport) Then
                Dim random As New Random()
                Dim randomNumber As Integer = random.Next(1000, 9999)
                Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(fileExport)
                Dim fileExtension As String = Path.GetExtension(fileExport)
                fileExport = Path.Combine(Application.StartupPath, fileNameWithoutExtension & "_" & randomNumber & fileExtension)
            End If

            Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = DirectCast(xlWorkBook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            For k As Integer = 1 To dg.Columns.Count
                xlWorkSheet.Cells(1, k) = dg.Columns(k - 1).HeaderText
            Next

            For i = 0 To dg.RowCount - 1
                For j = 0 To dg.ColumnCount - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = dg(j, i).Value.ToString()
                Next
            Next

            With xlWorkSheet
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With

            xlWorkBook.SaveAs(fileExport)
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseComObject(xlWorkSheet)
            ReleaseComObject(xlWorkBook)
            ReleaseComObject(xlApp)

            Process.Start(fileExport)

        Catch ex As Exception
            MessageBox.Show("An error occured: " & ex.Message, "Error")
        End Try
    End Sub
End Class