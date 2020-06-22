<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewContributionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChequeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanRepaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Navy
        Me.MenuStrip.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RegistrationToolStripMenuItem, Me.LoanToolStripMenuItem, Me.LoansToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1113, 24)
        Me.MenuStrip.TabIndex = 2
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GroupRegistrationToolStripMenuItem, Me.MemberRegistrationToolStripMenuItem})
        Me.RegistrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'GroupRegistrationToolStripMenuItem
        '
        Me.GroupRegistrationToolStripMenuItem.Name = "GroupRegistrationToolStripMenuItem"
        Me.GroupRegistrationToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.GroupRegistrationToolStripMenuItem.Text = "Group Registration"
        '
        'MemberRegistrationToolStripMenuItem
        '
        Me.MemberRegistrationToolStripMenuItem.Name = "MemberRegistrationToolStripMenuItem"
        Me.MemberRegistrationToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.MemberRegistrationToolStripMenuItem.Text = "Member Registration"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewContributionToolStripMenuItem, Me.ChequeToolStripMenuItem})
        Me.LoanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.LoanToolStripMenuItem.Text = "Payments"
        '
        'NewContributionToolStripMenuItem
        '
        Me.NewContributionToolStripMenuItem.Name = "NewContributionToolStripMenuItem"
        Me.NewContributionToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.NewContributionToolStripMenuItem.Text = "Contribution/Registration"
        '
        'ChequeToolStripMenuItem
        '
        Me.ChequeToolStripMenuItem.Name = "ChequeToolStripMenuItem"
        Me.ChequeToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ChequeToolStripMenuItem.Text = "Cheque"
        '
        'LoansToolStripMenuItem
        '
        Me.LoansToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanRequestToolStripMenuItem, Me.LoanRepaymentToolStripMenuItem})
        Me.LoansToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.LoansToolStripMenuItem.Name = "LoansToolStripMenuItem"
        Me.LoansToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LoansToolStripMenuItem.Text = "Loans"
        '
        'LoanRequestToolStripMenuItem
        '
        Me.LoanRequestToolStripMenuItem.Name = "LoanRequestToolStripMenuItem"
        Me.LoanRequestToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.LoanRequestToolStripMenuItem.Text = "Loan Request"
        '
        'LoanRepaymentToolStripMenuItem
        '
        Me.LoanRepaymentToolStripMenuItem.Name = "LoanRepaymentToolStripMenuItem"
        Me.LoanRepaymentToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.LoanRepaymentToolStripMenuItem.Text = "Loan Repayment"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 656)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmStart"
        Me.Text = "MWANGAZA SACCO SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewContributionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChequeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoansToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanRepaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
