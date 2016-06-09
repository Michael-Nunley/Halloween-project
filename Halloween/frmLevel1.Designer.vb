<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel1
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.cmdStart = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recBorder2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recBorder4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recBorder3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recBorder1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.cmdWin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.cmdStart, Me.recBorder2, Me.recBorder4, Me.recBorder3, Me.recBorder1, Me.recFail4, Me.recFail3, Me.recFail2, Me.recFail1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(587, 461)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'cmdStart
        '
        Me.cmdStart.FillColor = System.Drawing.Color.White
        Me.cmdStart.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.cmdStart.Location = New System.Drawing.Point(218, 140)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.SelectionColor = System.Drawing.SystemColors.Control
        Me.cmdStart.Size = New System.Drawing.Size(43, 32)
        '
        'recBorder2
        '
        Me.recBorder2.BackColor = System.Drawing.Color.Black
        Me.recBorder2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recBorder2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBorder2.Location = New System.Drawing.Point(560, -4)
        Me.recBorder2.Name = "recBorder2"
        Me.recBorder2.Size = New System.Drawing.Size(26, 465)
        Me.recBorder2.Visible = False
        '
        'recBorder4
        '
        Me.recBorder4.BackColor = System.Drawing.Color.Black
        Me.recBorder4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recBorder4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBorder4.Location = New System.Drawing.Point(0, 1)
        Me.recBorder4.Name = "recBorder4"
        Me.recBorder4.Size = New System.Drawing.Size(26, 461)
        Me.recBorder4.Visible = False
        '
        'recBorder3
        '
        Me.recBorder3.BackColor = System.Drawing.Color.Black
        Me.recBorder3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recBorder3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBorder3.Location = New System.Drawing.Point(1, 433)
        Me.recBorder3.Name = "recBorder3"
        Me.recBorder3.Size = New System.Drawing.Size(584, 28)
        Me.recBorder3.Visible = False
        '
        'recBorder1
        '
        Me.recBorder1.BackColor = System.Drawing.Color.Black
        Me.recBorder1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recBorder1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBorder1.Location = New System.Drawing.Point(0, -1)
        Me.recBorder1.Name = "recBorder1"
        Me.recBorder1.Size = New System.Drawing.Size(582, 28)
        Me.recBorder1.Visible = False
        '
        'recFail4
        '
        Me.recFail4.BackColor = System.Drawing.Color.Black
        Me.recFail4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recFail4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail4.BorderWidth = 5
        Me.recFail4.Location = New System.Drawing.Point(263, 49)
        Me.recFail4.Name = "recFail4"
        Me.recFail4.Size = New System.Drawing.Size(269, 120)
        Me.recFail4.Visible = False
        '
        'recFail3
        '
        Me.recFail3.BackColor = System.Drawing.Color.Black
        Me.recFail3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recFail3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail3.BorderWidth = 5
        Me.recFail3.Location = New System.Drawing.Point(251, 283)
        Me.recFail3.Name = "recFail3"
        Me.recFail3.Size = New System.Drawing.Size(306, 148)
        Me.recFail3.Visible = False
        '
        'recFail2
        '
        Me.recFail2.BackColor = System.Drawing.Color.Black
        Me.recFail2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recFail2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail2.BorderWidth = 5
        Me.recFail2.Location = New System.Drawing.Point(219, 173)
        Me.recFail2.Name = "recFail2"
        Me.recFail2.Size = New System.Drawing.Size(313, 81)
        Me.recFail2.Visible = False
        '
        'recFail1
        '
        Me.recFail1.BackColor = System.Drawing.Color.Black
        Me.recFail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recFail1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail1.BorderWidth = 5
        Me.recFail1.Location = New System.Drawing.Point(64, 28)
        Me.recFail1.Name = "recFail1"
        Me.recFail1.Size = New System.Drawing.Size(152, 382)
        Me.recFail1.Visible = False
        '
        'cmdWin
        '
        Me.cmdWin.Location = New System.Drawing.Point(28, 95)
        Me.cmdWin.Name = "cmdWin"
        Me.cmdWin.Size = New System.Drawing.Size(34, 27)
        Me.cmdWin.TabIndex = 2
        Me.cmdWin.TabStop = False
        Me.cmdWin.Text = "Win"
        Me.cmdWin.UseVisualStyleBackColor = True
        '
        'frmLevel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(587, 461)
        Me.Controls.Add(Me.cmdWin)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmLevel1"
        Me.Text = "Level 1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents recFail1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recBorder2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recBorder4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recBorder3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recBorder1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cmdWin As System.Windows.Forms.Button
    Friend WithEvents cmdStart As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
