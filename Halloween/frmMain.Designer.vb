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
        Me.components = New System.ComponentModel.Container()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdLevelSelection = New System.Windows.Forms.Button()
        Me.progLevelProgress = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.tmrLevelProgress = New System.Windows.Forms.Timer(Me.components)
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.picCandy1 = New System.Windows.Forms.PictureBox()
        Me.picCandy2 = New System.Windows.Forms.PictureBox()
        Me.picCandy3 = New System.Windows.Forms.PictureBox()
        CType(Me.picCandy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCandy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCandy3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(12, 298)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 0
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Cursor = System.Windows.Forms.Cursors.Help
        Me.cmdHelp.Location = New System.Drawing.Point(179, 298)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 1
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdLevelSelection
        '
        Me.cmdLevelSelection.Location = New System.Drawing.Point(348, 298)
        Me.cmdLevelSelection.Name = "cmdLevelSelection"
        Me.cmdLevelSelection.Size = New System.Drawing.Size(75, 23)
        Me.cmdLevelSelection.TabIndex = 2
        Me.cmdLevelSelection.Text = "Level Select"
        Me.cmdLevelSelection.UseVisualStyleBackColor = True
        '
        'progLevelProgress
        '
        Me.progLevelProgress.Location = New System.Drawing.Point(12, 25)
        Me.progLevelProgress.Maximum = 3
        Me.progLevelProgress.Name = "progLevelProgress"
        Me.progLevelProgress.Size = New System.Drawing.Size(411, 23)
        Me.progLevelProgress.Step = 1
        Me.progLevelProgress.TabIndex = 3
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(9, 9)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(85, 13)
        Me.lblProgress.TabIndex = 4
        Me.lblProgress.Text = "Current Progress"
        '
        'tmrLevelProgress
        '
        Me.tmrLevelProgress.Enabled = True
        Me.tmrLevelProgress.Interval = 500
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.BackColor = System.Drawing.Color.Transparent
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(95, 264)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(249, 31)
        Me.lblWinner.TabIndex = 5
        Me.lblWinner.Text = "You beat the game!"
        Me.lblWinner.Visible = False
        '
        'picCandy1
        '
        Me.picCandy1.BackColor = System.Drawing.Color.Transparent
        Me.picCandy1.BackgroundImage = Global.Halloween.My.Resources.Resources.Candy
        Me.picCandy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCandy1.Location = New System.Drawing.Point(12, 54)
        Me.picCandy1.Name = "picCandy1"
        Me.picCandy1.Size = New System.Drawing.Size(230, 74)
        Me.picCandy1.TabIndex = 6
        Me.picCandy1.TabStop = False
        Me.picCandy1.Visible = False
        '
        'picCandy2
        '
        Me.picCandy2.BackColor = System.Drawing.Color.Transparent
        Me.picCandy2.BackgroundImage = Global.Halloween.My.Resources.Resources.Candy
        Me.picCandy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCandy2.Location = New System.Drawing.Point(179, 107)
        Me.picCandy2.Name = "picCandy2"
        Me.picCandy2.Size = New System.Drawing.Size(230, 74)
        Me.picCandy2.TabIndex = 8
        Me.picCandy2.TabStop = False
        Me.picCandy2.Visible = False
        '
        'picCandy3
        '
        Me.picCandy3.BackColor = System.Drawing.Color.Transparent
        Me.picCandy3.BackgroundImage = Global.Halloween.My.Resources.Resources.Candy
        Me.picCandy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCandy3.Location = New System.Drawing.Point(47, 165)
        Me.picCandy3.Name = "picCandy3"
        Me.picCandy3.Size = New System.Drawing.Size(230, 74)
        Me.picCandy3.TabIndex = 9
        Me.picCandy3.TabStop = False
        Me.picCandy3.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Halloween.My.Resources.Resources.Pumpkin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(435, 333)
        Me.Controls.Add(Me.picCandy3)
        Me.Controls.Add(Me.picCandy2)
        Me.Controls.Add(Me.picCandy1)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.progLevelProgress)
        Me.Controls.Add(Me.cmdLevelSelection)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdExit)
        Me.Name = "frmMain"
        Me.Text = "Main"
        CType(Me.picCandy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCandy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCandy3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
    Friend WithEvents cmdLevelSelection As System.Windows.Forms.Button
    Friend WithEvents progLevelProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents tmrLevelProgress As System.Windows.Forms.Timer
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents picCandy1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCandy2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCandy3 As System.Windows.Forms.PictureBox

End Class
