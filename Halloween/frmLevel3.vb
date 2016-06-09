Public Class frmLevel3
    'Detects if a mouse is hovering over the rectangles and boundaries.
    Private Sub recFails_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recFail3.MouseEnter, recFail4.MouseEnter, recBorder1.MouseEnter, recBorder2.MouseEnter, recBorder3.MouseEnter, recBorder4.MouseEnter, recFail8.MouseEnter, recFail7.MouseEnter, recFail6.MouseEnter, recFail5.MouseEnter, recFail2.MouseEnter, recFail1.MouseEnter
        'Gives notification informing the user of thier failure.
        MsgBox("You failed!")
        'Hides current form.
        Me.Visible = False
        'Shows the fail form.
        frmFail3.Visible = True
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
        recBorder1.Visible = True
        recBorder2.Visible = True
        recBorder3.Visible = True
        recBorder4.Visible = True
        'enables the timer
        tmrMoving.Enabled = True
    End Sub
    Private Sub cmdWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWin.Click
        'Shows the win form
        frmWin.Visible = True
        'Hides and this current form
        Me.Visible = False
        'Sets Level3 statement to true to show that you've completed level 3.
        frmMain.Level3 = True
        'Sets Level1 statement to false so it doesn't override the level3 statement.
        frmMain.Level1 = False
        'Sets Level1 statement to false so it doesn't override the level3 statement.
        frmMain.Level2 = False
    End Sub
    Private Sub tmrMoving_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoving.Tick
        Dim point1 As Point
        Dim point2 As Point
        Dim point3 As Point
        Dim point4 As Point
        Dim point5 As Point
        Dim point6 As Point
        Dim rand As New Random
        'The first witch
        'Sets point1 to the location of recFail2
        point1 = recFail2.Location
        'If the x is less than or equal to 250, start adding.
        If point1.X <= 250 Then
            point1.X += rand.Next(1, 60)
            'If the x is more than or equal to 700, subtract.
        ElseIf point1.X >= 700 Then
            point1.X = 250
            'To start it off, it starts adding.
        Else
            point1.X += rand.Next(1, 60)
        End If
        'Set the location of recFail2 to the value of point1
        recFail2.Location = point1

        'The second witch
        point2 = recFail4.Location
        If point2.X <= 250 Then
            point2.X += rand.Next(1, 60)
        ElseIf point2.X >= 700 Then
            point2.X = 250
        Else
            point2.X += rand.Next(1, 60)
        End If
        recFail4.Location = point2

        'The third witch
        point3 = recFail5.Location
        If point3.X <= 250 Then
            point3.X += rand.Next(1, 60)
        ElseIf point3.X >= 700 Then
            point3.X = 250
        Else
            point3.X += rand.Next(1, 60)
        End If
        recFail5.Location = point3

        'The fourth witch
        point4 = recFail6.Location
        If point4.X <= 250 Then
            point4.X += rand.Next(1, 60)
        ElseIf point4.X >= 700 Then
            point4.X = 250
        Else
            point4.X += rand.Next(1, 60)
        End If
        recFail6.Location = point4

        'The fith witch
        point5 = recFail7.Location
        If point5.X <= 250 Then
            point5.X += rand.Next(1, 60)
        ElseIf point5.X >= 700 Then
            point5.X = 250
        Else
            point5.X += rand.Next(1, 60)
        End If
        recFail7.Location = point5

        'The sixth witch
        point6 = recFail8.Location
        If point6.X <= 250 Then
            point6.X += rand.Next(1, 60)
        ElseIf point6.X >= 700 Then
            point6.X = 250
        Else
            point6.X += rand.Next(1, 60)
        End If
        recFail8.Location = point6
    End Sub
End Class