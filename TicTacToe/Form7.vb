Public Class FrmTicTacToe
    Private Sub WinOrLose()
        If Lbl1.Text = LblXorO.Text And Lbl2.Text = LblXorO.Text And Lbl3.Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        If Lbl4.Text = LblXorO.Text And Lbl5.Text = LblXorO.Text And Lbl6.Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        If Lbl7.Text = LblXorO.Text And Lbl8.Text = LblXorO.Text And Lbl9.Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        If Lbl1.Text = LblXorO.Text And Lbl4.Text = LblXorO.Text And Lbl7.Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        If Lbl2.Text = LblXorO.Text And Lbl5.Text = LblXorO.Text And Lbl8.Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        If Lbl3.Text = LblXorO.Text And Lbl6.Text = LblXorO.Text And Lbl9.Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        If Lbl1.Text = LblXorO.Text And Lbl5.Text = LblXorO.Text And Lbl9.Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        If Lbl3.Text = LblXorO.Text And Lbl5.Text = LblXorO.Text And Lbl9.Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        If Lbl1.Text = "1" Or Lbl2.Text = "2" Or Lbl3.Text = "3" Or Lbl4.Text = "4" _
            Or Lbl5.Text = "5" Or Lbl6.Text = "6" Or Lbl7.Text = "7" _
            Or Lbl9.Text = "8" Or Lbl9.Text = "9" Then
            Exit Sub    ' Exit if any square have NOT been played
        End If
        MsgBox("The Cat Won", MsgBoxStyle.OkOnly, "Cat Wins") ' All squares played
        BtnStart.Visible = True  ' Show Start Button
    End Sub
    Private Sub XorO()
        If LblXorO.Text = "X" Then
            LblXorO.Text = "O" ' Only if LblXorO.Text = "X"
        Else
            LblXorO.Text = "X" ' Only if LblXorO.Text NOT "X"
        End If
    End Sub
    Private Sub Lbl1_Click(sender As System.Object, e As System.EventArgs) Handles Lbl1.Click
        If Lbl1.Text = "1" Then 'The player has not played
            Lbl1.Text = LblXorO.Text ' Pick up the X or O 
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub Lbl2_Click(sender As System.Object, e As System.EventArgs) Handles Lbl2.Click
        If Lbl2.Text = "2" Then 'The player has not played
            Lbl2.Text = LblXorO.Text ' Pick up the X or O
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub Lbl3_Click(sender As System.Object, e As System.EventArgs) Handles Lbl3.Click
        If Lbl3.Text = "3" Then 'The player has not played
            Lbl3.Text = LblXorO.Text ' Pick up the X or O
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub Lbl4_Click(sender As System.Object, e As System.EventArgs) Handles Lbl4.Click
        If Lbl4.Text = "4" Then 'The player has not played
            Lbl4.Text = LblXorO.Text ' Pick up the X or O
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub Lbl5_Click(sender As System.Object, e As System.EventArgs) Handles Lbl5.Click
        If Lbl5.Text = "5" Then 'The player has not played
            Lbl5.Text = LblXorO.Text ' Pick up the X or O
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub Lbl6_Click(sender As System.Object, e As System.EventArgs) Handles Lbl6.Click
        If Lbl6.Text = "6" Then 'The player has not played
            Lbl6.Text = LblXorO.Text ' Pick up the X or O
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub Lbl7_Click(sender As System.Object, e As System.EventArgs) Handles Lbl7.Click
        If Lbl7.Text = "7" Then 'The player has not played
            Lbl7.Text = LblXorO.Text ' Pick up the X or O
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub Lbl8_Click(sender As System.Object, e As System.EventArgs) Handles Lbl8.Click
        If Lbl8.Text = "8" Then 'The player has not played
            Lbl8.Text = LblXorO.Text ' Pick up the X or O
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub Lbl9_Click(sender As System.Object, e As System.EventArgs) Handles Lbl9.Click
        If Lbl9.Text = "9" Then 'The player has not played
            Lbl9.Text = LblXorO.Text ' Pick up the X or O
            WinOrLose() ' Check to see if this player has won
            XorO()  ' Call Xor O Subroutine
        End If
    End Sub

    Private Sub BtnStart_Click(sender As System.Object, e As System.EventArgs) Handles BtnStart.Click
        ' Reset all the Labels
        Lbl1.Text = "1"
        Lbl2.Text = "2"
        Lbl3.Text = "3"
        Lbl4.Text = "4"
        Lbl5.Text = "5"
        Lbl6.Text = "6"
        Lbl7.Text = "7"
        Lbl8.Text = "8"
        Lbl9.Text = "9"
        BtnStart.Visible = False  ' Hide Start Button
    End Sub

    Private Sub FrmTicTacToe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class