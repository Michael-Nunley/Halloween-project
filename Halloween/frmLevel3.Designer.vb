<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel3))
        Me.recBorder1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recBorder4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFail8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recBorder2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recBorder3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.cmdWin = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.tmrMoving = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'recBorder1
        '
        Me.recBorder1.BackColor = System.Drawing.Color.Black
        Me.recBorder1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recBorder1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBorder1.Location = New System.Drawing.Point(-3, -4)
        Me.recBorder1.Name = "recBorder1"
        Me.recBorder1.Size = New System.Drawing.Size(933, 28)
        Me.recBorder1.Visible = False
        '
        'recFail1
        '
        Me.recFail1.BackColor = System.Drawing.Color.Black
        Me.recFail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recFail1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail1.BorderWidth = 5
        Me.recFail1.Location = New System.Drawing.Point(61, 25)
        Me.recFail1.Name = "recFail1"
        Me.recFail1.Size = New System.Drawing.Size(187, 496)
        Me.recFail1.Visible = False
        '
        'recBorder4
        '
        Me.recBorder4.BackColor = System.Drawing.Color.Black
        Me.recBorder4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recBorder4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBorder4.Location = New System.Drawing.Point(-3, -2)
        Me.recBorder4.Name = "recBorder4"
        Me.recBorder4.Size = New System.Drawing.Size(26, 538)
        Me.recBorder4.Visible = False
        '
        'recFail2
        '
        Me.recFail2.BackColor = System.Drawing.Color.Transparent
        Me.recFail2.BackgroundImage = Global.Halloween.My.Resources.Resources.Witch
        Me.recFail2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recFail2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail2.Location = New System.Drawing.Point(216, 22)
        Me.recFail2.Name = "recFail2"
        Me.recFail2.Size = New System.Drawing.Size(100, 80)
        Me.recFail2.Visible = False
        '
        'recFail4
        '
        Me.recFail4.BackColor = System.Drawing.Color.Transparent
        Me.recFail4.BackgroundImage = CType(resources.GetObject("recFail4.BackgroundImage"), System.Drawing.Image)
        Me.recFail4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recFail4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail4.Location = New System.Drawing.Point(216, 101)
        Me.recFail4.Name = "recFail4"
        Me.recFail4.Size = New System.Drawing.Size(100, 80)
        Me.recFail4.Visible = False
        '
        'recFail5
        '
        Me.recFail5.BackColor = System.Drawing.Color.Transparent
        Me.recFail5.BackgroundImage = Global.Halloween.My.Resources.Resources.Witch
        Me.recFail5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recFail5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail5.Location = New System.Drawing.Point(216, 181)
        Me.recFail5.Name = "recFail5"
        Me.recFail5.Size = New System.Drawing.Size(100, 80)
        Me.recFail5.Visible = False
        '
        'recFail6
        '
        Me.recFail6.BackColor = System.Drawing.Color.Transparent
        Me.recFail6.BackgroundImage = CType(resources.GetObject("recFail6.BackgroundImage"), System.Drawing.Image)
        Me.recFail6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recFail6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail6.Location = New System.Drawing.Point(216, 260)
        Me.recFail6.Name = "recFail6"
        Me.recFail6.Size = New System.Drawing.Size(100, 80)
        Me.recFail6.Visible = False
        '
        'recFail7
        '
        Me.recFail7.BackColor = System.Drawing.Color.Transparent
        Me.recFail7.BackgroundImage = CType(resources.GetObject("recFail7.BackgroundImage"), System.Drawing.Image)
        Me.recFail7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recFail7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail7.Location = New System.Drawing.Point(217, 340)
        Me.recFail7.Name = "recFail7"
        Me.recFail7.Size = New System.Drawing.Size(100, 80)
        Me.recFail7.Visible = False
        '
        'recFail3
        '
        Me.recFail3.BackColor = System.Drawing.Color.Black
        Me.recFail3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recFail3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail3.BorderWidth = 5
        Me.recFail3.Location = New System.Drawing.Point(774, 68)
        Me.recFail3.Name = "recFail3"
        Me.recFail3.Size = New System.Drawing.Size(132, 483)
        Me.recFail3.Visible = False
        '
        'recFail8
        '
        Me.recFail8.BackColor = System.Drawing.Color.Transparent
        Me.recFail8.BackgroundImage = CType(resources.GetObject("recFail8.BackgroundImage"), System.Drawing.Image)
        Me.recFail8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recFail8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFail8.Location = New System.Drawing.Point(217, 415)
        Me.recFail8.Name = "recFail8"
        Me.recFail8.Size = New System.Drawing.Size(100, 80)
        Me.recFail8.Visible = False
        '
        'recBorder2
        '
        Me.recBorder2.BackColor = System.Drawing.Color.Black
        Me.recBorder2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recBorder2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBorder2.Location = New System.Drawing.Point(907, -5)
        Me.recBorder2.Name = "recBorder2"
        Me.recBorder2.Size = New System.Drawing.Size(26, 571)
        Me.recBorder2.Visible = False
        '
        'recBorder3
        '
        Me.recBorder3.BackColor = System.Drawing.Color.Black
        Me.recBorder3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.recBorder3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recBorder3.Location = New System.Drawing.Point(-4, 534)
        Me.recBorder3.Name = "recBorder3"
        Me.recBorder3.Size = New System.Drawing.Size(930, 28)
        Me.recBorder3.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.recBorder3, Me.recBorder2, Me.recFail8, Me.recFail3, Me.recFail7, Me.recFail6, Me.recFail5, Me.recFail4, Me.recFail2, Me.recBorder4, Me.recFail1, Me.recBorder1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(929, 560)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'cmdWin
        '
        Me.cmdWin.Location = New System.Drawing.Point(26, 25)
        Me.cmdWin.Name = "cmdWin"
        Me.cmdWin.Size = New System.Drawing.Size(34, 27)
        Me.cmdWin.TabIndex = 7
        Me.cmdWin.TabStop = False
        Me.cmdWin.Text = "Win"
        Me.cmdWin.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdStart.Location = New System.Drawing.Point(866, 25)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(41, 35)
        Me.cmdStart.TabIndex = 6
        Me.cmdStart.TabStop = False
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'tmrMoving
        '
        Me.tmrMoving.Interval = 20
        '
        'frmLevel3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(929, 560)
        Me.Controls.Add(Me.cmdWin)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmLevel3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Level 3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents recBorder1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recBorder4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recFail8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recBorder2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recBorder3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents cmdWin As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents tmrMoving As System.Windows.Forms.Timer
End Class
