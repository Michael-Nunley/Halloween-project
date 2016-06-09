Public Class frmLevel1
    'Detects if a mouse is hovering over the rectangles and boundaries.
    Private Sub recFails_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recFail1.MouseEnter, recFail2.MouseEnter, recFail3.MouseEnter, recFail4.MouseEnter, recBorder1.MouseEnter, recBorder2.MouseEnter, recBorder3.MouseEnter, recBorder4.MouseEnter
        'Gives notification informing the user of thier failure.
        MsgBox("You failed!")
        'Hides current form.
        Me.Visible = False
        'Shows the fail form.
        frmFail1.Visible = True
    End Sub
    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Shows all of the boundaries, fail rectangles, and the win button. Hides the start button.
        cmdWin.Visible = True
        cmdStart.Visible = False
        recFail1.Visible = True
        recFail2.Visible = True
        recFail3.Visible = True
        recFail4.Visible = True
        recBorder1.Visible = True
        recBorder2.Visible = True
        recBorder3.Visible = True
        recBorder4.Visible = True
    End Sub
    Private Sub frmLevel1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'When this form is loaded, it makes sure the start button is showed and enabled (Extra precaution.)
        If Me.Visible = True Then
            cmdStart.Visible = True
        End If
    End Sub
    Private Sub cmdWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWin.Click
        'Shows the win form
        frmWin.Visible = True
        'Hides and this current form
        Me.Visible = False
        'Sets Level1 statement to true to show that you've completed level 1.
        frmMain.Level1 = True
    End Sub
    Private Sub cmdStart_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        'Shows all of the boundaries, fail rectangles, and the win button. Hides the start button.
        cmdWin.Visible = True
        cmdStart.Visible = False
        recFail1.Visible = True
        recFail2.Visible = True
        recFail3.Visible = True
        recFail4.Visible = True
        recBorder1.Visible = True
        recBorder2.Visible = True
        recBorder3.Visible = True
        recBorder4.Visible = True
    End Sub
End Class