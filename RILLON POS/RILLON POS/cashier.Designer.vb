<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cashier
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
        Me.refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.back = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCashier = New System.Windows.Forms.TextBox()
        Me.tbTransaction = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBarcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTotalItems = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbChange = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.comboProductList = New System.Windows.Forms.ComboBox()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(915, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.refresh, Me.delete, Me.PrintToolStripMenuItem, Me.back})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'refresh
        '
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(152, 22)
        Me.refresh.Text = "Refresh"
        '
        'delete
        '
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(152, 22)
        Me.delete.Text = "Delete All"
        '
        'back
        '
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(152, 22)
        Me.back.Text = "Back"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cashier"
        '
        'tbCashier
        '
        Me.tbCashier.Location = New System.Drawing.Point(26, 66)
        Me.tbCashier.Name = "tbCashier"
        Me.tbCashier.Size = New System.Drawing.Size(149, 20)
        Me.tbCashier.TabIndex = 2
        '
        'tbTransaction
        '
        Me.tbTransaction.Location = New System.Drawing.Point(26, 113)
        Me.tbTransaction.Name = "tbTransaction"
        Me.tbTransaction.Size = New System.Drawing.Size(149, 20)
        Me.tbTransaction.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transaction ID"
        '
        'tbBarcode
        '
        Me.tbBarcode.Location = New System.Drawing.Point(217, 66)
        Me.tbBarcode.Name = "tbBarcode"
        Me.tbBarcode.Size = New System.Drawing.Size(149, 20)
        Me.tbBarcode.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Barcode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Product List"
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(561, 66)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(149, 20)
        Me.tbPrice.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(558, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Price"
        '
        'tbStock
        '
        Me.tbStock.Location = New System.Drawing.Point(561, 113)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(149, 20)
        Me.tbStock.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(558, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Stock"
        '
        'tbQuantity
        '
        Me.tbQuantity.Location = New System.Drawing.Point(745, 66)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(149, 20)
        Me.tbQuantity.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(742, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Quantity"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(745, 113)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(149, 20)
        Me.tbTotal.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(742, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sub Total"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dg.Location = New System.Drawing.Point(26, 156)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersVisible = False
        Me.dg.Size = New System.Drawing.Size(868, 229)
        Me.dg.TabIndex = 17
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
        Me.Column3.HeaderText = "Qty"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        '
        'tbTotalAmount
        '
        Me.tbTotalAmount.Location = New System.Drawing.Point(26, 460)
        Me.tbTotalAmount.Name = "tbTotalAmount"
        Me.tbTotalAmount.Size = New System.Drawing.Size(149, 20)
        Me.tbTotalAmount.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 444)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Total Amount"
        '
        'tbTotalItems
        '
        Me.tbTotalItems.Location = New System.Drawing.Point(26, 413)
        Me.tbTotalItems.Name = "tbTotalItems"
        Me.tbTotalItems.Size = New System.Drawing.Size(149, 20)
        Me.tbTotalItems.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 397)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Items"
        '
        'tbChange
        '
        Me.tbChange.Location = New System.Drawing.Point(217, 460)
        Me.tbChange.Name = "tbChange"
        Me.tbChange.Size = New System.Drawing.Size(149, 20)
        Me.tbChange.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(214, 444)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Change"
        '
        'tbAmountPaid
        '
        Me.tbAmountPaid.Location = New System.Drawing.Point(217, 413)
        Me.tbAmountPaid.Name = "tbAmountPaid"
        Me.tbAmountPaid.Size = New System.Drawing.Size(149, 20)
        Me.tbAmountPaid.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(214, 397)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Amount paid"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(663, 410)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(231, 23)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(663, 439)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(231, 23)
        Me.btnPay.TabIndex = 27
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnReceipt
        '
        Me.btnReceipt.Location = New System.Drawing.Point(663, 468)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(231, 23)
        Me.btnReceipt.TabIndex = 28
        Me.btnReceipt.Text = "RECEIPT"
        Me.btnReceipt.UseVisualStyleBackColor = True
        '
        'comboProductList
        '
        Me.comboProductList.FormattingEnabled = True
        Me.comboProductList.Location = New System.Drawing.Point(217, 113)
        Me.comboProductList.Name = "comboProductList"
        Me.comboProductList.Size = New System.Drawing.Size(149, 21)
        Me.comboProductList.TabIndex = 1
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 510)
        Me.Controls.Add(Me.comboProductList)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbChange)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbAmountPaid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbTotalAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbTotalItems)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbQuantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbStock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbBarcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbTransaction)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCashier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cashier"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents back As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCashier As System.Windows.Forms.TextBox
    Friend WithEvents tbTransaction As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbStock As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents tbTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbTotalItems As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbChange As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents btnReceipt As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comboProductList As System.Windows.Forms.ComboBox
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
