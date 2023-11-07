<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class receiptForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblvat = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblvtbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.barcodePic = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.Change = New System.Windows.Forms.Label()
        Me.Cash = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dgReceipt = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.thankyou = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        CType(Me.barcodePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Qty"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.BackColor = System.Drawing.Color.Transparent
        Me.lblCashier.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(176, 74)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(91, 13)
        Me.lblCashier.TabIndex = 80
        Me.lblCashier.Text = "                     "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(76, 167)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(16, 14)
        Me.lblTotal.TabIndex = 77
        Me.lblTotal.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(176, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "VAT_Exempted"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(176, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Zero_Rated"
        '
        'lblvat
        '
        Me.lblvat.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblvat.AutoSize = True
        Me.lblvat.BackColor = System.Drawing.Color.Transparent
        Me.lblvat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvat.Location = New System.Drawing.Point(176, 240)
        Me.lblvat.Name = "lblvat"
        Me.lblvat.Size = New System.Drawing.Size(32, 13)
        Me.lblvat.TabIndex = 72
        Me.lblvat.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "VAT_Tax"
        '
        'lblvtbl
        '
        Me.lblvtbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblvtbl.AutoSize = True
        Me.lblvtbl.BackColor = System.Drawing.Color.Transparent
        Me.lblvtbl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvtbl.Location = New System.Drawing.Point(176, 224)
        Me.lblvtbl.Name = "lblvtbl"
        Me.lblvtbl.Size = New System.Drawing.Size(32, 13)
        Me.lblvtbl.TabIndex = 70
        Me.lblvtbl.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "VATable"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-41, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "= = = = = = = = = = = = = = = = = = = = = = = = = = = = ="
        '
        'barcodePic
        '
        Me.barcodePic.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.barcodePic.Location = New System.Drawing.Point(0, 325)
        Me.barcodePic.Name = "barcodePic"
        Me.barcodePic.Size = New System.Drawing.Size(298, 66)
        Me.barcodePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.barcodePic.TabIndex = 65
        Me.barcodePic.TabStop = False
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(30, 165)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 16)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Total "
        '
        'Column3
        '
        Me.Column3.HeaderText = "Unit price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(176, 165)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(40, 16)
        Me.lblTotalAmount.TabIndex = 61
        Me.lblTotalAmount.Text = "0.00"
        '
        'lblCash
        '
        Me.lblCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCash.AutoSize = True
        Me.lblCash.BackColor = System.Drawing.Color.Transparent
        Me.lblCash.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(176, 182)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(32, 13)
        Me.lblCash.TabIndex = 60
        Me.lblCash.Text = "0.00"
        '
        'Change
        '
        Me.Change.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Change.AutoSize = True
        Me.Change.BackColor = System.Drawing.Color.Transparent
        Me.Change.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(30, 198)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(56, 13)
        Me.Change.TabIndex = 53
        Me.Change.Text = "CHANGE"
        '
        'Cash
        '
        Me.Cash.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Cash.AutoSize = True
        Me.Cash.BackColor = System.Drawing.Color.Transparent
        Me.Cash.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.Location = New System.Drawing.Point(30, 182)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(40, 13)
        Me.Cash.TabIndex = 52
        Me.Cash.Text = "CASH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * "
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-40, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "= = = = = = = = = = = = = = = = = = = = = = = = = = = = ="
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.BackColor = System.Drawing.Color.Transparent
        Me.lblTransaction.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaction.Location = New System.Drawing.Point(176, 89)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(91, 13)
        Me.lblTransaction.TabIndex = 56
        Me.lblTransaction.Text = "                     "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(380, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "= = = = = = = = = = = = = = = = = = = = = = = = = = = = ="
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(106, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 18)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "RECEIPT"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(176, 48)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(40, 13)
        Me.lblTime.TabIndex = 47
        Me.lblTime.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(31, 48)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 46
        Me.lblDate.Text = "Date:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(31, 89)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 13)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Transaction ID:"
        '
        'dgReceipt
        '
        Me.dgReceipt.AllowUserToAddRows = False
        Me.dgReceipt.AllowUserToDeleteRows = False
        Me.dgReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgReceipt.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgReceipt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReceipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgReceipt.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgReceipt.EnableHeadersVisualStyles = False
        Me.dgReceipt.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgReceipt.Location = New System.Drawing.Point(8, 120)
        Me.dgReceipt.Name = "dgReceipt"
        Me.dgReceipt.ReadOnly = True
        Me.dgReceipt.Size = New System.Drawing.Size(287, 32)
        Me.dgReceipt.TabIndex = 63
        '
        'Column4
        '
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lblvat)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblvtbl)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.barcodePic)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.lblTotalAmount)
        Me.Panel2.Controls.Add(Me.lblCash)
        Me.Panel2.Controls.Add(Me.thankyou)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.Change)
        Me.Panel2.Controls.Add(Me.Cash)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblTransaction)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.dgReceipt)
        Me.Panel2.Controls.Add(Me.lblCashier)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 460)
        Me.Panel2.TabIndex = 31
        '
        'thankyou
        '
        Me.thankyou.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.thankyou.AutoSize = True
        Me.thankyou.BackColor = System.Drawing.Color.Transparent
        Me.thankyou.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thankyou.Location = New System.Drawing.Point(31, 302)
        Me.thankyou.Name = "thankyou"
        Me.thankyou.Size = New System.Drawing.Size(236, 16)
        Me.thankyou.TabIndex = 59
        Me.thankyou.Text = "THANK YOU! COME BACK AGAIN"
        '
        'lblChange
        '
        Me.lblChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.Color.Transparent
        Me.lblChange.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(176, 198)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(32, 13)
        Me.lblChange.TabIndex = 58
        Me.lblChange.Text = "0.00"
        '
        'receiptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 482)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "receiptForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "receiptForm"
        CType(Me.barcodePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblvat As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblvtbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents barcodePic As System.Windows.Forms.PictureBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents Change As System.Windows.Forms.Label
    Friend WithEvents Cash As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dgReceipt As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents thankyou As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
End Class
