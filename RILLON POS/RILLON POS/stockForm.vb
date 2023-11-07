Imports System.Data.OleDb
Imports System.IO
Public Class stockForm
    Private Sub BarcodeID()
        Try
            Dim BarcodeID As New Random
            Dim ID As Integer = BarcodeID.Next(1, 1000000)
            tbBarcode.Text = ID
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        'tbProduceName.Text = ""
        'tbDescription.Text = ""
        'tbQuantity.Text = ""
        'tbBuyingPrice.Text = ""
        'tbSellingPrice.Text = ""
        'tbStock.Text = ""
        'tbAddStock.Text = ""
        picClear()
    End Sub
    Private Sub ProductImg()
        Try
            dbConnection()
            Dim arrImage() As Byte
            Dim myMS As New IO.MemoryStream
            Dim da As New OleDbDataAdapter(("select * from tblstock where BarcodeID ='" & Trim(tbBarcode.Text) & "'"), conn)

            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0).Item("stockPhoto")) Then
                    arrImage = dt.Rows(0).Item("stockPhoto")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Picture.Image = System.Drawing.Image.FromStream(myMS)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub stockIMG()
        Dim ms As New MemoryStream()
        Dim bmpImage As New Bitmap(Picture.Image)
        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim data As Byte() = ms.GetBuffer()
        Dim p As New OleDbParameter("@stockPhoto", OleDbType.Binary)
        p.Value = data
        cmd.Parameters.Add(p)
    End Sub
    Sub picClear()
        Picture.Image = Nothing
        Picture.BackColor = Color.Empty
        Picture.Invalidate()
    End Sub
    Sub stockRecords()
        Try
            dbcon = "SELECT  * FROM tblstock "
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
    Private Sub stockInfo()
        Try
            dbConnection()
            Dim cmd As New OleDbCommand("INSERT INTO tblstock VALUES(@BarcodeID,@ProductName,@Description,@BuyingPrice,@Quantity,@SellingPrice,@Stock,@stockPhoto)", conn)

            cmd.Parameters.AddWithValue("@BarcodeID", tbBarcode.Text)
            cmd.Parameters.AddWithValue("@ProductName", tbProductname.Text)
            cmd.Parameters.AddWithValue("@Description", tbDescription.Text)
            cmd.Parameters.AddWithValue("@BuyingPrice", tbBuyingprice.Text)
            cmd.Parameters.AddWithValue("@Quantity", tbQty.Text)
            cmd.Parameters.AddWithValue("@SellingPrice", tbSellingprice.Text)
            cmd.Parameters.AddWithValue("@Stock", tbStock.Text)
            Dim ms As New MemoryStream()
            Picture.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@stockPhoto", OleDbType.Binary)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            stockRecords()
            ' count()
        Catch ex As Exception
            MessageBox.Show("Input stock picture", "Input picture", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub deleteStock()
        Try
            dbcon = "DELETE * FROM tblstock WHERE BarcodeID like'" & Trim(tbBarcode.Text) & "'"
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

    Private Sub newStock_Click(sender As System.Object, e As System.EventArgs) Handles newStock.Click
        'tbBarcodeID.Enabled = False
        'tbProduceName.Enabled = True
        'tbDescription.Enabled = True
        'tbBuyingPrice.Enabled = True
        'tbQuantity.Enabled = False
        'tbSellingPrice.Enabled = False
        'tbStock.Enabled = True
        'tbAddStock.Enabled = False

        'newProduct.Enabled = False
        'addStock.Enabled = False
        'edit.Enabled = False
        'update.Enabled = False
        'save.Enabled = True
        'refresh.Enabled = False
        'delete.Enabled = False
        'Print.Enabled = False
        'Cancel.Enabled = True
        'About.Enabled = True
        'Exitt.Enabled = True
        clear()
        tbQty.Text = 1
        BarcodeID()
        tbProductname.Focus()
    End Sub

    Private Sub save_Click(sender As System.Object, e As System.EventArgs) Handles save.Click
        If tbProductname.Text = "" And tbDescription.Text = "" And tbQty.Text = "" And tbBuyingprice.Text = "" And tbSellingprice.Text = "" And tbStock.Text = "" Then
            MessageBox.Show("Please fill up all fields.", "Input Details!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbProductname.Text = "" Then
            MessageBox.Show("Input product name.", "Input product name!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbDescription.Text = "" Then
            MessageBox.Show("Input product description.", "Input description!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbBuyingprice.Text = "" Then
            MessageBox.Show("Input product buying price.", "Input price!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbSellingprice.Text = "" Then
            MessageBox.Show("Input product selling price.", "Input price!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tbStock.Text = "" Then
            MessageBox.Show("Input amount of stock", "Input Stock!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            stockInfo()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Browse stock image..."
                .Filter = "Image file (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Picture.Image = System.Drawing.Bitmap.FromFile(.FileName)
                Else
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub stockForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        stockRecords()
    End Sub

    Private Sub update_Click(sender As System.Object, e As System.EventArgs) Handles update.Click
        Try
            dbcon = "UPDATE [tblstock] SET [Stock] = '" & Val(tbStock.Text) + Val(tbAddStock.Text) & "',[ProductName]='" & tbProductname.Text & "',[Description]='" & tbDescription.Text & "',[Quantity]='" & tbQty.Text & "',[BuyingPrice]='" & tbBuyingprice.Text & "',[SellingPrice]='" & tbSellingprice.Text & "',[stockPhoto] = @stockPhoto WHERE [BarcodeID] = '" & tbBarcode.Text & "'"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim i As Integer
            stockIMG()
            i = cmd.ExecuteNonQuery
            MessageBox.Show("Stock information successfuly updated.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbAddStock.Text = ""
            stockRecords()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub BindtoText()
        With dg
            tbBarcode.Text = .CurrentRow.Cells(0).Value
        End With
    End Sub

    Private Sub dg_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellClick
        BindtoText()
    End Sub

    Private Sub tbBarcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbBarcode.TextChanged
        Try
            dbConnection()
            Dim da As New OleDbDataAdapter(("select * from tblstock where BarcodeID ='" & Trim(tbBarcode.Text) & "'"), conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                tbProductname.Text = dt.Rows(0).Item(1) & ""
                tbDescription.Text = dt.Rows(0).Item(2) & ""
                tbBuyingprice.Text = dt.Rows(0).Item(3) & ""
                tbQty.Text = dt.Rows(0).Item(4) & ""

                tbSellingprice.Text = dt.Rows(0).Item(5) & ""
                tbStock.Text = dt.Rows(0).Item(6) & ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ProductImg()
    End Sub

    Private Sub dg_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellEnter
        BindtoText()
    End Sub

    Private Sub tbSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbSearch.TextChanged
        Try
            dbcon = "SELECT * FROM [tblstock] where [BarcodeID] LIKE '" & Trim(tbSearch.Text) & "%'"

            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dg.Rows.Clear()
            Do While dr.Read = True
                dg.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub delete_Click(sender As System.Object, e As System.EventArgs) Handles delete.Click
        If MessageBox.Show("Are you sure want to delete this stock?", "Deleting stock", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            deleteStock()
            clear()
            tbBarcode.Text = ""

            'tbBarcodeID.Enabled = False
            'tbProduceName.Enabled = False
            'tbDescription.Enabled = False
            'tbBuyingprice.Enabled = False
            'tbQuantity.Enabled = False
            'tbSellingprice.Enabled = False
            'tbStock.Enabled = False
            'tbAddStock.Enabled = False

            'newProduct.Enabled = True
            'addStock.Enabled = True
            'edit.Enabled = True
            'update.Enabled = False
            'save.Enabled = False
            'refresh.Enabled = True
            'delete.Enabled = False
            'Print.Enabled = True
            'Cancel.Enabled = False
            'About.Enabled = True
            'Exitt.Enabled = True
            tbSearch.Text = ""
            stockRecords()

        End If
    End Sub

    Private Sub refresh_Click(sender As System.Object, e As System.EventArgs) Handles refresh.Click
        tbSearch.Text = ""
        stockRecords()
    End Sub

    Private Sub eexit_Click(sender As System.Object, e As System.EventArgs) Handles eexit.Click
        stockRecords()
        'tbBarcodeID.Enabled = False
        'tbProduceName.Enabled = False
        'tbDescription.Enabled = False
        'tbBuyingprice.Enabled = False
        'tbQuantity.Enabled = False
        'tbSellingprice.Enabled = False
        'tbStock.Enabled = False
        'tbAddStock.Enabled = False

        'newProduct.Enabled = True
        'addStock.Enabled = True
        'edit.Enabled = True
        'update.Enabled = False
        'save.Enabled = False
        'refresh.Enabled = True
        'delete.Enabled = True
        'Print.Enabled = True
        'Cancel.Enabled = False
        'About.Enabled = True
        'Exitt.Enabled = True
        tbSearch.Text = ""
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub StockQtyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockQtyToolStripMenuItem.Click
        tbAddStock.Text = ""


        'tbBarcodeID.Enabled = False
        'tbProduceName.Enabled = False
        'tbDescription.Enabled = False
        'tbBuyingprice.Enabled = False
        'tbQuantity.Enabled = False
        'tbSellingprice.Enabled = False
        'tbStock.Enabled = False
        'tbAddStock.Enabled = True

        'newProduct.Enabled = False
        'addStock.Enabled = False
        'edit.Enabled = False
        'update.Enabled = True
        'save.Enabled = False
        'refresh.Enabled = False
        'delete.Enabled = False
        'Print.Enabled = False
        'Cancel.Enabled = True
        'About.Enabled = True
        'Exitt.Enabled = True

        tbAddStock.Focus()
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExcelToolStripMenuItem.Click
        Try
            Dim fileExport As String = Application.StartupPath & "\Exported Excel File\Stock_Data.xlsx"
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
End Class