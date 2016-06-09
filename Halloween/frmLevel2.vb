Public Class frmLevel2
    'Detects if a mouse is hovering over the rectangles and boundaries.
    Private Sub recFails_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recFail1.MouseEnter, recFail2.MouseEnter, recFail3.MouseEnter, recFail4.MouseEnter, recBorder1.MouseEnter, recBorder2.MouseEnter, recBorder3.MouseEnter, recBorder4.MouseEnter, recFail9.MouseEnter, recFail8.MouseEnter, recFail7.MouseEnter, recFail6.MouseEnter, recFail5.MouseEnter, recFail11.MouseEnter, recFail10.MouseEnter
        'Gives notification informing the user of thier failure.
        MsgBox("You failed!")
        'Hides current form.
        Me.Visible = False
        'Shows the fail form.
        frmFail2.Visible = True
    End Sub
    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        'Shows all of the boundaries, fail rectangles, and the win button. Hides the start button.
        cmdWin.Visible = True
        cmdStart.Visible = False
        recFail1.Visible = True
        recFail2.Visible = True
        recFail3.Visible = True
        recFail4.Visible = True
        recFail5.Visible = True
        recFail6.Visible = True
        recFail7.Visible = True
        recFail8.Visible = True
        recFail9.Visible = True
        recFail10.Visible = True
        recFail11.Visible = True
        recBorder1.Visible = True
        recBorder2.Visible = True
        recBorder3.Visible = True
        recBorder4.Visible = True
    End Sub
    Private Sub cmdWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWin.Click
        'Shows the win form
        frmWin.Visible = True
        'Hides and this current form
        Me.Visible = False
        'Sets Level2 statement to true to show that you've completed level 2.
        frmMain.Level2 = True
        'Sets Level1 statement to false so it doesn't override the level2 statement.
        frmMain.Level1 = False
    End Sub
End Class