<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userForm
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
        Me.newAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.update = New System.Windows.Forms.ToolStripMenuItem()
        Me.save = New System.Windows.Forms.ToolStripMenuItem()
        Me.del = New System.Windows.Forms.ToolStripMenuItem()
        Me.refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbEmployeeID = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbConfirmPassword = New System.Windows.Forms.TextBox()
        Me.tbPosition = New System.Windows.Forms.TextBox()
        Me.comboPrivilege = New System.Windows.Forms.ComboBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.btnRemoveImage = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(913, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newAccount, Me.edit, Me.update, Me.save, Me.del, Me.refresh, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'newAccount
        '
        Me.newAccount.Name = "newAccount"
        Me.newAccount.Size = New System.Drawing.Size(152, 22)
        Me.newAccount.Text = "New Account"
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
        'del
        '
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(152, 22)
        Me.del.Text = "Delete"
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
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'eexit
        '
        Me.eexit.Name = "eexit"
        Me.eexit.Size = New System.Drawing.Size(38, 20)
        Me.eexit.Text = "Exit"
        '
        'tbEmployeeID
        '
        Me.tbEmployeeID.Location = New System.Drawing.Point(12, 58)
        Me.tbEmployeeID.Name = "tbEmployeeID"
        Me.tbEmployeeID.Size = New System.Drawing.Size(227, 20)
        Me.tbEmployeeID.TabIndex = 1
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(12, 116)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(227, 20)
        Me.tbUsername.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(12, 164)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(227, 20)
        Me.tbPassword.TabIndex = 3
        '
        'tbConfirmPassword
        '
        Me.tbConfirmPassword.Location = New System.Drawing.Point(12, 210)
        Me.tbConfirmPassword.Name = "tbConfirmPassword"
        Me.tbConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirmPassword.Size = New System.Drawing.Size(227, 20)
        Me.tbConfirmPassword.TabIndex = 4
        '
        'tbPosition
        '
        Me.tbPosition.Location = New System.Drawing.Point(12, 248)
        Me.tbPosition.Name = "tbPosition"
        Me.tbPosition.Size = New System.Drawing.Size(227, 20)
        Me.tbPosition.TabIndex = 5
        '
        'comboPrivilege
        '
        Me.comboPrivilege.FormattingEnabled = True
        Me.comboPrivilege.Items.AddRange(New Object() {"Admin", "Cashier", "User"})
        Me.comboPrivilege.Location = New System.Drawing.Point(12, 287)
        Me.comboPrivilege.Name = "comboPrivilege"
        Me.comboPrivilege.Size = New System.Drawing.Size(227, 21)
        Me.comboPrivilege.TabIndex = 6
        '
        'Picture
        '
        Me.Picture.Location = New System.Drawing.Point(12, 314)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(227, 128)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picture.TabIndex = 7
        Me.Picture.TabStop = False
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.Location = New System.Drawing.Point(12, 448)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseImage.TabIndex = 8
        Me.btnBrowseImage.Text = "Browse"
        Me.btnBrowseImage.UseVisualStyleBackColor = True
        '
        'btnRemoveImage
        '
        Me.btnRemoveImage.Location = New System.Drawing.Point(164, 448)
        Me.btnRemoveImage.Name = "btnRemoveImage"
        Me.btnRemoveImage.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveImage.TabIndex = 9
        Me.btnRemoveImage.Text = "Clear"
        Me.btnRemoveImage.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dg.Location = New System.Drawing.Point(268, 80)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersVisible = False
        Me.dg.Size = New System.Drawing.Size(633, 375)
        Me.dg.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Employee ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Username"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Password"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "Position"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Privilege"
        Me.Column5.Name = "Column5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Privilege"
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(674, 54)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(227, 20)
        Me.tbSearch.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(671, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Search:"
        '
        'userForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 484)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btnRemoveImage)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.comboPrivilege)
        Me.Controls.Add(Me.tbPosition)
        Me.Controls.Add(Me.tbConfirmPassword)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.tbEmployeeID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "userForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents del As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eexit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbPosition As System.Windows.Forms.TextBox
    Friend WithEvents comboPrivilege As System.Windows.Forms.ComboBox
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowseImage As System.Windows.Forms.Button
    Friend WithEvents btnRemoveImage As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
