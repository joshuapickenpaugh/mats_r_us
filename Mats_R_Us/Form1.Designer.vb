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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoPremium = New System.Windows.Forms.RadioButton()
        Me.rdoDeluxe = New System.Windows.Forms.RadioButton()
        Me.rdoStandard = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoPink = New System.Windows.Forms.RadioButton()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.rdoBlue = New System.Windows.Forms.RadioButton()
        Me.chkFoldable = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoPremium)
        Me.GroupBox1.Controls.Add(Me.rdoDeluxe)
        Me.GroupBox1.Controls.Add(Me.rdoStandard)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type:"
        '
        'rdoPremium
        '
        Me.rdoPremium.AutoSize = True
        Me.rdoPremium.Location = New System.Drawing.Point(21, 105)
        Me.rdoPremium.Name = "rdoPremium"
        Me.rdoPremium.Size = New System.Drawing.Size(65, 17)
        Me.rdoPremium.TabIndex = 2
        Me.rdoPremium.TabStop = True
        Me.rdoPremium.Text = "&Premium"
        Me.rdoPremium.UseVisualStyleBackColor = True
        '
        'rdoDeluxe
        '
        Me.rdoDeluxe.AutoSize = True
        Me.rdoDeluxe.Location = New System.Drawing.Point(21, 68)
        Me.rdoDeluxe.Name = "rdoDeluxe"
        Me.rdoDeluxe.Size = New System.Drawing.Size(58, 17)
        Me.rdoDeluxe.TabIndex = 1
        Me.rdoDeluxe.TabStop = True
        Me.rdoDeluxe.Text = "&Deluxe"
        Me.rdoDeluxe.UseVisualStyleBackColor = True
        '
        'rdoStandard
        '
        Me.rdoStandard.AutoSize = True
        Me.rdoStandard.Location = New System.Drawing.Point(21, 33)
        Me.rdoStandard.Name = "rdoStandard"
        Me.rdoStandard.Size = New System.Drawing.Size(68, 17)
        Me.rdoStandard.TabIndex = 0
        Me.rdoStandard.TabStop = True
        Me.rdoStandard.Text = "&Standard"
        Me.rdoStandard.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoPink)
        Me.GroupBox2.Controls.Add(Me.rdoRed)
        Me.GroupBox2.Controls.Add(Me.rdoBlue)
        Me.GroupBox2.Location = New System.Drawing.Point(142, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(126, 146)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color:"
        '
        'rdoPink
        '
        Me.rdoPink.AutoSize = True
        Me.rdoPink.Location = New System.Drawing.Point(6, 105)
        Me.rdoPink.Name = "rdoPink"
        Me.rdoPink.Size = New System.Drawing.Size(46, 17)
        Me.rdoPink.TabIndex = 2
        Me.rdoPink.TabStop = True
        Me.rdoPink.Text = "Pin&k"
        Me.rdoPink.UseVisualStyleBackColor = True
        '
        'rdoRed
        '
        Me.rdoRed.AutoSize = True
        Me.rdoRed.Location = New System.Drawing.Point(6, 68)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(45, 17)
        Me.rdoRed.TabIndex = 1
        Me.rdoRed.TabStop = True
        Me.rdoRed.Text = "&Red"
        Me.rdoRed.UseVisualStyleBackColor = True
        '
        'rdoBlue
        '
        Me.rdoBlue.AutoSize = True
        Me.rdoBlue.Location = New System.Drawing.Point(6, 33)
        Me.rdoBlue.Name = "rdoBlue"
        Me.rdoBlue.Size = New System.Drawing.Size(46, 17)
        Me.rdoBlue.TabIndex = 0
        Me.rdoBlue.TabStop = True
        Me.rdoBlue.Text = "&Blue"
        Me.rdoBlue.UseVisualStyleBackColor = True
        '
        'chkFoldable
        '
        Me.chkFoldable.AutoSize = True
        Me.chkFoldable.Location = New System.Drawing.Point(294, 46)
        Me.chkFoldable.Name = "chkFoldable"
        Me.chkFoldable.Size = New System.Drawing.Size(66, 17)
        Me.chkFoldable.TabIndex = 2
        Me.chkFoldable.Text = "&Foldable"
        Me.chkFoldable.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Price:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(13, 210)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = " "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(164, 210)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(285, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 268)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkFoldable)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mats-R-Us"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoPremium As RadioButton
    Friend WithEvents rdoDeluxe As RadioButton
    Friend WithEvents rdoStandard As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoPink As RadioButton
    Friend WithEvents rdoRed As RadioButton
    Friend WithEvents rdoBlue As RadioButton
    Friend WithEvents chkFoldable As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
