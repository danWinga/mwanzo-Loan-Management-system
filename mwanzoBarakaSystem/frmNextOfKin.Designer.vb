<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNextOfKin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbnxtSurname = New System.Windows.Forms.Label()
        Me.txtnxtSurname = New System.Windows.Forms.TextBox()
        Me.txtnxtOthernames = New System.Windows.Forms.TextBox()
        Me.lbnxtOthernames = New System.Windows.Forms.Label()
        Me.txtnxtRelation = New System.Windows.Forms.TextBox()
        Me.lbnxtRelation = New System.Windows.Forms.Label()
        Me.gbnxtAddress = New System.Windows.Forms.GroupBox()
        Me.txtnxtPercent = New System.Windows.Forms.TextBox()
        Me.lbnxtPercent = New System.Windows.Forms.Label()
        Me.txtnxtAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnxMobile = New System.Windows.Forms.TextBox()
        Me.lbnxtMobile = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btNxtSave = New System.Windows.Forms.Button()
        Me.btNxtClear = New System.Windows.Forms.Button()
        Me.btNxtUpdate = New System.Windows.Forms.Button()
        Me.btNxtDelete = New System.Windows.Forms.Button()
        Me.txtNxtAccNo = New System.Windows.Forms.TextBox()
        Me.lbNxtAccNo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbnxtAddress.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnxtRelation)
        Me.GroupBox1.Controls.Add(Me.lbnxtRelation)
        Me.GroupBox1.Controls.Add(Me.txtnxtOthernames)
        Me.GroupBox1.Controls.Add(Me.lbnxtOthernames)
        Me.GroupBox1.Controls.Add(Me.txtnxtSurname)
        Me.GroupBox1.Controls.Add(Me.lbnxtSurname)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'lbnxtSurname
        '
        Me.lbnxtSurname.AutoSize = True
        Me.lbnxtSurname.Location = New System.Drawing.Point(26, 20)
        Me.lbnxtSurname.Name = "lbnxtSurname"
        Me.lbnxtSurname.Size = New System.Drawing.Size(49, 13)
        Me.lbnxtSurname.TabIndex = 0
        Me.lbnxtSurname.Text = "Surname"
        '
        'txtnxtSurname
        '
        Me.txtnxtSurname.Location = New System.Drawing.Point(103, 17)
        Me.txtnxtSurname.Name = "txtnxtSurname"
        Me.txtnxtSurname.Size = New System.Drawing.Size(174, 20)
        Me.txtnxtSurname.TabIndex = 1
        '
        'txtnxtOthernames
        '
        Me.txtnxtOthernames.Location = New System.Drawing.Point(103, 45)
        Me.txtnxtOthernames.Name = "txtnxtOthernames"
        Me.txtnxtOthernames.Size = New System.Drawing.Size(277, 20)
        Me.txtnxtOthernames.TabIndex = 3
        '
        'lbnxtOthernames
        '
        Me.lbnxtOthernames.AutoSize = True
        Me.lbnxtOthernames.Location = New System.Drawing.Point(26, 45)
        Me.lbnxtOthernames.Name = "lbnxtOthernames"
        Me.lbnxtOthernames.Size = New System.Drawing.Size(69, 13)
        Me.lbnxtOthernames.TabIndex = 2
        Me.lbnxtOthernames.Text = "Other Names"
        '
        'txtnxtRelation
        '
        Me.txtnxtRelation.Location = New System.Drawing.Point(103, 71)
        Me.txtnxtRelation.Name = "txtnxtRelation"
        Me.txtnxtRelation.Size = New System.Drawing.Size(277, 20)
        Me.txtnxtRelation.TabIndex = 5
        '
        'lbnxtRelation
        '
        Me.lbnxtRelation.AutoSize = True
        Me.lbnxtRelation.Location = New System.Drawing.Point(26, 71)
        Me.lbnxtRelation.Name = "lbnxtRelation"
        Me.lbnxtRelation.Size = New System.Drawing.Size(46, 13)
        Me.lbnxtRelation.TabIndex = 4
        Me.lbnxtRelation.Text = "Relation"
        '
        'gbnxtAddress
        '
        Me.gbnxtAddress.Controls.Add(Me.txtNxtAccNo)
        Me.gbnxtAddress.Controls.Add(Me.lbNxtAccNo)
        Me.gbnxtAddress.Controls.Add(Me.txtnxtPercent)
        Me.gbnxtAddress.Controls.Add(Me.lbnxtPercent)
        Me.gbnxtAddress.Controls.Add(Me.txtnxtAddress)
        Me.gbnxtAddress.Controls.Add(Me.Label2)
        Me.gbnxtAddress.Controls.Add(Me.txtnxMobile)
        Me.gbnxtAddress.Controls.Add(Me.lbnxtMobile)
        Me.gbnxtAddress.Location = New System.Drawing.Point(17, 127)
        Me.gbnxtAddress.Name = "gbnxtAddress"
        Me.gbnxtAddress.Size = New System.Drawing.Size(410, 108)
        Me.gbnxtAddress.TabIndex = 1
        Me.gbnxtAddress.TabStop = False
        Me.gbnxtAddress.Text = "Other details"
        '
        'txtnxtPercent
        '
        Me.txtnxtPercent.Location = New System.Drawing.Point(103, 71)
        Me.txtnxtPercent.Name = "txtnxtPercent"
        Me.txtnxtPercent.Size = New System.Drawing.Size(96, 20)
        Me.txtnxtPercent.TabIndex = 5
        '
        'lbnxtPercent
        '
        Me.lbnxtPercent.AutoSize = True
        Me.lbnxtPercent.Location = New System.Drawing.Point(26, 71)
        Me.lbnxtPercent.Name = "lbnxtPercent"
        Me.lbnxtPercent.Size = New System.Drawing.Size(52, 13)
        Me.lbnxtPercent.TabIndex = 4
        Me.lbnxtPercent.Text = "Share (%)"
        '
        'txtnxtAddress
        '
        Me.txtnxtAddress.Location = New System.Drawing.Point(103, 45)
        Me.txtnxtAddress.Name = "txtnxtAddress"
        Me.txtnxtAddress.Size = New System.Drawing.Size(277, 20)
        Me.txtnxtAddress.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address"
        '
        'txtnxMobile
        '
        Me.txtnxMobile.Location = New System.Drawing.Point(103, 17)
        Me.txtnxMobile.Name = "txtnxMobile"
        Me.txtnxMobile.Size = New System.Drawing.Size(174, 20)
        Me.txtnxMobile.TabIndex = 1
        '
        'lbnxtMobile
        '
        Me.lbnxtMobile.AutoSize = True
        Me.lbnxtMobile.Location = New System.Drawing.Point(26, 20)
        Me.lbnxtMobile.Name = "lbnxtMobile"
        Me.lbnxtMobile.Size = New System.Drawing.Size(55, 13)
        Me.lbnxtMobile.TabIndex = 0
        Me.lbnxtMobile.Text = "Mobile No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btNxtDelete)
        Me.GroupBox2.Controls.Add(Me.btNxtUpdate)
        Me.GroupBox2.Controls.Add(Me.btNxtClear)
        Me.GroupBox2.Controls.Add(Me.btNxtSave)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 46)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btNxtSave
        '
        Me.btNxtSave.Location = New System.Drawing.Point(11, 17)
        Me.btNxtSave.Name = "btNxtSave"
        Me.btNxtSave.Size = New System.Drawing.Size(95, 23)
        Me.btNxtSave.TabIndex = 0
        Me.btNxtSave.Text = "Save"
        Me.btNxtSave.UseVisualStyleBackColor = True
        '
        'btNxtClear
        '
        Me.btNxtClear.Location = New System.Drawing.Point(112, 17)
        Me.btNxtClear.Name = "btNxtClear"
        Me.btNxtClear.Size = New System.Drawing.Size(96, 23)
        Me.btNxtClear.TabIndex = 1
        Me.btNxtClear.Text = "Clear"
        Me.btNxtClear.UseVisualStyleBackColor = True
        '
        'btNxtUpdate
        '
        Me.btNxtUpdate.Location = New System.Drawing.Point(214, 18)
        Me.btNxtUpdate.Name = "btNxtUpdate"
        Me.btNxtUpdate.Size = New System.Drawing.Size(94, 23)
        Me.btNxtUpdate.TabIndex = 2
        Me.btNxtUpdate.Text = "Update"
        Me.btNxtUpdate.UseVisualStyleBackColor = True
        '
        'btNxtDelete
        '
        Me.btNxtDelete.Location = New System.Drawing.Point(314, 18)
        Me.btNxtDelete.Name = "btNxtDelete"
        Me.btNxtDelete.Size = New System.Drawing.Size(88, 23)
        Me.btNxtDelete.TabIndex = 3
        Me.btNxtDelete.Text = "Delete"
        Me.btNxtDelete.UseVisualStyleBackColor = True
        '
        'txtNxtAccNo
        '
        Me.txtNxtAccNo.Location = New System.Drawing.Point(253, 73)
        Me.txtNxtAccNo.Name = "txtNxtAccNo"
        Me.txtNxtAccNo.Size = New System.Drawing.Size(127, 20)
        Me.txtNxtAccNo.TabIndex = 7
        '
        'lbNxtAccNo
        '
        Me.lbNxtAccNo.AutoSize = True
        Me.lbNxtAccNo.Location = New System.Drawing.Point(207, 73)
        Me.lbNxtAccNo.Name = "lbNxtAccNo"
        Me.lbNxtAccNo.Size = New System.Drawing.Size(40, 13)
        Me.lbNxtAccNo.TabIndex = 6
        Me.lbNxtAccNo.Text = "AccNo"
        '
        'frmNextOfKin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 305)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbnxtAddress)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmNextOfKin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NextOfKin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbnxtAddress.ResumeLayout(False)
        Me.gbnxtAddress.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnxtRelation As System.Windows.Forms.TextBox
    Friend WithEvents lbnxtRelation As System.Windows.Forms.Label
    Friend WithEvents txtnxtOthernames As System.Windows.Forms.TextBox
    Friend WithEvents lbnxtOthernames As System.Windows.Forms.Label
    Friend WithEvents txtnxtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lbnxtSurname As System.Windows.Forms.Label
    Friend WithEvents gbnxtAddress As System.Windows.Forms.GroupBox
    Friend WithEvents txtnxtPercent As System.Windows.Forms.TextBox
    Friend WithEvents lbnxtPercent As System.Windows.Forms.Label
    Friend WithEvents txtnxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnxMobile As System.Windows.Forms.TextBox
    Friend WithEvents lbnxtMobile As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btNxtDelete As System.Windows.Forms.Button
    Friend WithEvents btNxtUpdate As System.Windows.Forms.Button
    Friend WithEvents btNxtClear As System.Windows.Forms.Button
    Friend WithEvents btNxtSave As System.Windows.Forms.Button
    Friend WithEvents txtNxtAccNo As System.Windows.Forms.TextBox
    Friend WithEvents lbNxtAccNo As System.Windows.Forms.Label
End Class
