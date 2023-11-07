<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockQtyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.update = New System.Windows.Forms.ToolStripMenuItem()
        Me.save = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBarcode = New System.Windows.Forms.TextBox()
        Me.tbProductname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbBuyingprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbQty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbSellingprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbAddStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.eexit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newStock, Me.StockQtyToolStripMenuItem, Me.edit, Me.update, Me.save, Me.delete, Me.refresh, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'newStock
        '
        Me.newStock.Name = "newStock"
        Me.newStock.Size = New System.Drawing.Size(152, 22)
        Me.newStock.Text = "New Stock"
        '
        'StockQtyToolStripMenuItem
        '
        Me.StockQtyToolStripMenuItem.Name = "StockQtyToolStripMenuItem"
        Me.StockQtyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StockQtyToolStripMenuItem.Text = "Stock Qty"
        '
        'edit
        '
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(152, 22)
        Me.edit.Text = "Edit"
        '
        'update
        '
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(152, 22)
        Me.update.Text = "Update"
        '
        'save
        '
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(152, 22)
        Me.save.Text = "Save"
        '
        'delete
        '
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(152, 22)
        Me.delete.Text = "Delete"
        '
        'refresh
        '
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(152, 22)
        Me.refresh.Text = "Refresh"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'eexit
        '
        Me.eexit.Name = "eexit"
        Me.eexit.Size = New System.Drawing.Size(38, 20)
        Me.eexit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barcode"
        '
        'tbBarcode
        '
        Me.tbBarcode.Location = New System.Drawing.Point(29, 57)
        Me.tbBarcode.Name = "tbBarcode"
        Me.tbBarcode.Size = New System.Drawing.Size(270, 20)
        Me.tbBarcode.TabIndex = 2
        '
        'tbProductname
        '
        Me.tbProductname.Location = New System.Drawing.Point(29, 100)
        Me.tbProductname.Name = "tbProductname"
        Me.tbProductname.Size = New System.Drawing.Size(270, 20)
        Me.tbProductname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Name"
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(29, 143)
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.Size = New System.Drawing.Size(270, 20)
        Me.tbDescription.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description"
        '
        'tbBuyingprice
        '
        Me.tbBuyingprice.Location = New System.Drawing.Point(29, 185)
        Me.tbBuyingprice.Name = "tbBuyingprice"
        Me.tbBuyingprice.Size = New System.Drawing.Size(270, 20)
        Me.tbBuyingprice.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Buying price"
        '
        'tbQty
        '
        Me.tbQty.Location = New System.Drawing.Point(324, 57)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(270, 20)
        Me.tbQty.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Qty"
        '
        'tbSellingprice
        '
        Me.tbSellingprice.Location = New System.Drawing.Point(324, 100)
        Me.tbSellingprice.Name = "tbSellingprice"
        Me.tbSellingprice.Size = New System.Drawing.Size(270, 20)
        Me.tbSellingprice.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Selling price"
        '
        'tbStock
        '
        Me.tbStock.Location = New System.Drawing.Point(324, 143)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(270, 20)
        Me.tbStock.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Stock"
        '
        'tbAddStock
        '
        Me.tbAddStock.Location = New System.Drawing.Point(324, 185)
        Me.tbAddStock.Name = "tbAddStock"
        Me.tbAddStock.Size = New System.Drawing.Size(270, 20)
        Me.tbAddStock.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Add Stock"
        '
        'Picture
        '
        Me.Picture.Location = New System.Drawing.Point(620, 57)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(157, 125)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picture.TabIndex = 17
        Me.Picture.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(620, 185)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(702, 185)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dg.Location = New System.Drawing.Point(12, 268)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersVisible = False
        Me.dg.Size = New System.Drawing.Size(771, 242)
        Me.dg.TabIndex = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "Barcode ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Buying Price"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Selling Price"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Stock"
        Me.Column7.Name = "Column7"
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(513, 242)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(270, 20)
        Me.tbSearch.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(510, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Search"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'stockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 522)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.tbAddStock)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbStock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbSellingprice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbBuyingprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbProductname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "stockForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stockForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eexit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbBarcode As System.Windows.Forms.TextBox
    Friend WithEvents tbProductname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbBuyingprice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbQty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbSellingprice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbStock As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbAddStock As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockQtyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
