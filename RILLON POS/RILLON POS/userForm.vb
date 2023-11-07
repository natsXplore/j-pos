Imports System.Data.OleDb
Imports System.IO
Public Class userForm

    Private Sub userForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Records()
    End Sub
    Sub picClear()
        Picture.Image = Nothing
        Picture.BackColor = Color.Empty
        Picture.Invalidate()
    End Sub
    Sub Clear()
        tbUsername.Text = ""
        tbPassword.Text = ""
        tbConfirmPassword.Text = ""
        tbPosition.Text = ""
        comboPrivilege.SelectedItem = Nothing

        picClear()
    End Sub
    Private Sub DeleteEmployeeData()
        Try
            dbcon = "DELETE * FROM tbluser WHERE ID like'" & Trim(tbEmployeeID.Text) & "'"
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
    Sub SetImg()
        Dim ms As New MemoryStream()
        Dim bmpImage As New Bitmap(Picture.Image)
        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim data As Byte() = ms.GetBuffer()
        Dim p As New OleDbParameter("@img", OleDbType.Binary)
        p.Value = data
        cmd.Parameters.Add(p)
    End Sub
    Private Sub EmployeeID()
        dbConnection()
        Dim oleDBDR As OleDbDataReader
        Dim oleDBCommand As New OleDbCommand
        Dim strEmployeeID As String
        With oleDBCommand
            .Connection = conn
            .CommandText = "SELECT * FROM tbluser ORDER BY ID DESC"
        End With
        oleDBDR = oleDBCommand.ExecuteReader

        If oleDBDR.Read Then
            strEmployeeID = Mid(oleDBDR(0), 5, Len(oleDBDR(0)))
            tbEmployeeID.Text = "JAR-" & Format(Val(strEmployeeID) + 1, "000")
        Else
            tbEmployeeID.Text = "JAR-001"
        End If
    End Sub

    Private Sub Records()
        Try
            dbcon = "SELECT  * FROM tbluser "
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader
            dg.Rows.Clear()
            Do While dr.Read = True
                dg.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub EmployeeInfo()
        Try
            If tbUsername.Text = "" Or tbPassword.Text = "" Or tbConfirmPassword.Text = "" Or tbPosition.Text = "" Or comboPrivilege.Text = "" Then
                MessageBox.Show("Please complete all fields.", "Input details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbUsername.Focus()
            ElseIf tbPassword.Text = tbConfirmPassword.Text = 0 Then
                MessageBox.Show("Password didn't match", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbPassword.Text = ""
                tbConfirmPassword.Text = ""
                tbPassword.Focus()
                Exit Sub
            End If
            dbConnection()
            Dim cmd As New OleDbCommand("INSERT INTO tbluser VALUES(@ID,@Username,@Password,@Position,@UserType,@userPhoto)", conn)
            cmd.Parameters.AddWithValue("@EmployeeID", tbEmployeeID.Text)
            cmd.Parameters.AddWithValue("@Username", tbUsername.Text)
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text)
            cmd.Parameters.AddWithValue("@Position", tbPosition.Text)
            cmd.Parameters.AddWithValue("@UserType", comboPrivilege.Text)
            Dim ms As New MemoryStream()
            Picture.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@userPhoto", OleDbType.Binary)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee registered successfully?", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
            Records()
        Catch ex As Exception
            MessageBox.Show("Insert Employee picture", "Input picture", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub newAccount_Click(sender As System.Object, e As System.EventArgs) Handles newAccount.Click
        Records()
        Clear()
        EmployeeID()
        tbUsername.Focus()
    End Sub

    Private Sub btnBrowseImage_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseImage.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Browse Employee image..."
                .Filter = "Image file (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.Picture.Image = System.Drawing.Bitmap.FromFile(.FileName)
                Else
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub btnRemoveImage_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveImage.Click
        picClear()
    End Sub

    Private Sub save_Click(sender As System.Object, e As System.EventArgs) Handles save.Click
        EmployeeInfo()
        EmployeeID()
    End Sub

    Private Sub dg_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellClick
        BindtoText()
        If e.RowIndex >= 0 AndAlso e.RowIndex < dg.Rows.Count Then
            ' Set the Selected property of the clicked row to True
            dg.Rows(e.RowIndex).Selected = True
        End If
    End Sub
    Sub BindtoText()
        With dg
            tbEmployeeID.Text = .CurrentRow.Cells(0).Value
        End With
    End Sub
    Private Sub EmployeePhoto()
        Try
            dbConnection()
            Dim arrImage() As Byte
            Dim myMS As New IO.MemoryStream
            Dim da As New OleDbDataAdapter(("select * from tbluser where ID ='" & Trim(tbEmployeeID.Text) & "'"), conn)

            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0).Item("userPhoto")) Then
                    arrImage = dt.Rows(0).Item("userPhoto")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Me.Picture.Image = System.Drawing.Image.FromStream(myMS)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tbEmployeeID_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbEmployeeID.TextChanged
        Try
            dbConnection()
            Dim da As New OleDbDataAdapter(("select * from tbluser where ID ='" & Trim(tbEmployeeID.Text) & "'"), conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                tbUsername.Text = dt.Rows(0).Item(1) & ""
                tbPassword.Text = dt.Rows(0).Item(2) & ""
                tbConfirmPassword.Text = dt.Rows(0).Item(2) & ""
                tbPosition.Text = dt.Rows(0).Item(3) & ""
                comboPrivilege.Text = dt.Rows(0).Item(4) & ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        EmployeePhoto()
    End Sub

    Private Sub update_Click(sender As System.Object, e As System.EventArgs) Handles update.Click
        Try
            If tbPassword.Text = tbConfirmPassword.Text = 0 Then
                tbPassword.Text = ""
                tbConfirmPassword.Text = ""
                MessageBox.Show("Password didn't match", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            dbcon = "UPDATE [tbluser] SET [Username] = '" & tbUsername.Text & "',[Password]='" & tbPassword.Text & "', [Position] = '" & tbPosition.Text & "',[UserType] = '" & comboPrivilege.Text & "',[userPhoto] = @img WHERE [ID] = '" & tbEmployeeID.Text & "'"
            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            Dim i As Integer
            SetImg()
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Employee account successfully updated.", "Employee updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Records()
            Else
                MessageBox.Show("Failed to update employee.", "Failed to update", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub del_Click(sender As System.Object, e As System.EventArgs) Handles del.Click
        If MessageBox.Show("Are you sure want to delete this employee?", "Deleting Employee Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteEmployeeData()
            Clear()
            tbEmployeeID.Text = ""
            Records()

        End If
    End Sub

    Private Sub refresh_Click(sender As System.Object, e As System.EventArgs) Handles refresh.Click
        Clear()
        tbEmployeeID.Text = ""
        tbSearch.Text = ""
        Records()
    End Sub

    Private Sub tbSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbSearch.TextChanged
        Try
            dbcon = "SELECT * FROM [tbluser] where [Username] LIKE '" & Trim(tbSearch.Text) & "%'"

            dbConnection()
            cmd = New OleDbCommand(dbcon, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dg.Rows.Clear()
            Do While dr.Read = True
                dg.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            Loop
        Catch ex As Exception
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub eexit_Click(sender As System.Object, e As System.EventArgs) Handles eexit.Click
        Clear()
        Records()
        'tbEmployeeID.Enabled = False
        'tbUsername.Enabled = False
        'tbPassword.Enabled = False
        'tbConfirmPassword.Enabled = False
        'tbPosition.Enabled = False
        'comboPrivilege.Enabled = False

        'addUser.Enabled = True
        'edit.Enabled = True
        'update.Enabled = False
        'save.Enabled = False
        'refresh.Enabled = True
        'delete.Enabled = False
        'Print.Enabled = True
        'cancel.Enabled = False
        'about.Enabled = True
        'Exitt.Enabled = True
        Me.Hide()
        frmMain.Show()
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

    Private Sub ExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExcelToolStripMenuItem.Click
        Try
            Dim fileExport As String = Application.StartupPath & "\Exported Excel File\User_Data.xlsx"
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
                .Columns("C").Delete()
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