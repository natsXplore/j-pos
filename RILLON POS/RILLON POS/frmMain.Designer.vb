<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnCashier = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(12, 12)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(105, 51)
        Me.btnUser.TabIndex = 0
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Location = New System.Drawing.Point(123, 12)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(105, 51)
        Me.btnStock.TabIndex = 1
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnCashier
        '
        Me.btnCashier.Location = New System.Drawing.Point(234, 12)
        Me.btnCashier.Name = "btnCashier"
        Me.btnCashier.Size = New System.Drawing.Size(105, 51)
        Me.btnCashier.TabIndex = 2
        Me.btnCashier.Text = "Cashier"
        Me.btnCashier.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(345, 12)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(105, 51)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(345, 69)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(105, 23)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 116)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnCashier)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnUser)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnCashier As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
