<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevelSelection
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
        Me.cmdLevel1 = New System.Windows.Forms.Button()
        Me.cmdLevel2 = New System.Windows.Forms.Button()
        Me.cmdLevel3 = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdLevel1
        '
        Me.cmdLevel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdLevel1.ForeColor = System.Drawing.Color.White
        Me.cmdLevel1.Location = New System.Drawing.Point(12, 12)
        Me.cmdLevel1.Name = "cmdLevel1"
        Me.cmdLevel1.Size = New System.Drawing.Size(75, 68)
        Me.cmdLevel1.TabIndex = 0
        Me.cmdLevel1.Text = "Level 1 EASY"
        Me.cmdLevel1.UseVisualStyleBackColor = False
        '
        'cmdLevel2
        '
        Me.cmdLevel2.BackColor = System.Drawing.Color.DarkRed
        Me.cmdLevel2.Enabled = False
        Me.cmdLevel2.ForeColor = System.Drawing.Color.White
        Me.cmdLevel2.Location = New System.Drawing.Point(93, 12)
        Me.cmdLevel2.Name = "cmdLevel2"
        Me.cmdLevel2.Size = New System.Drawing.Size(75, 68)
        Me.cmdLevel2.TabIndex = 1
        Me.cmdLevel2.Text = "Level 2 MEDIUM"
        Me.cmdLevel2.UseVisualStyleBackColor = False
        '
        'cmdLevel3
        '
        Me.cmdLevel3.BackColor = System.Drawing.Color.Black
        Me.cmdLevel3.Enabled = False
        Me.cmdLevel3.ForeColor = System.Drawing.Color.White
        Me.cmdLevel3.Location = New System.Drawing.Point(174, 12)
        Me.cmdLevel3.Name = "cmdLevel3"
        Me.cmdLevel3.Size = New System.Drawing.Size(75, 68)
        Me.cmdLevel3.TabIndex = 2
        Me.cmdLevel3.Text = "Level 3 HARD"
        Me.cmdLevel3.UseVisualStyleBackColor = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.White
        Me.cmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Image = Global.Halloween.My.Resources.Resources.Bone
        Me.cmdBack.Location = New System.Drawing.Point(12, 86)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(237, 86)
        Me.cmdBack.TabIndex = 3
        Me.cmdBack.Text = "Back to main screen."
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Halloween.My.Resources.Resources.Bats
        Me.Button1.Location = New System.Drawing.Point(12, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 51)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmLevelSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Halloween.My.Resources.Resources.Skeleton
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(255, 241)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdLevel3)
        Me.Controls.Add(Me.cmdLevel2)
        Me.Controls.Add(Me.cmdLevel1)
        Me.Name = "frmLevelSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Level Selection"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdLevel1 As System.Windows.Forms.Button
    Friend WithEvents cmdLevel2 As System.Windows.Forms.Button
    Friend WithEvents cmdLevel3 As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
