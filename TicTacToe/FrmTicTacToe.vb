Public Class FrmTicTacToe
    Dim LblTTT(800) As Label  ' Array of labels

    Private Sub FrmTicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim j As Integer
        Dim Icnt As Integer
        Icnt = 1 ' Label counter
        For j = 1 To 3     ' Vertical
            For i = 1 To 3 ' Horizontal
                LblTTT(Icnt) = New System.Windows.Forms.Label
                With LblTTT(Icnt)
                    .Name = Icnt                                  'Label Name
                    .Location = New System.Drawing.Point _
                         (44 + (i - 1) * 89, 46 + (j - 1) * 44)
                    .Font = New Font("Times New Roman",
                         16, FontStyle.Bold)     'Label Font
                    .Text = Icnt                                  'Label Text
                    .AutoSize = True           'Adjust label size
                End With
                Me.Controls.Add(LblTTT(Icnt)) ' Add to form
                AddHandler LblTTT(Icnt).Click, AddressOf LblTTT_Click 'Click Event
                Icnt += 1 ' Increase Label counter
            Next
        Next
    End Sub
    '
    'Label Click Event
    Private Sub LblTTT_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Check to See if Square cas been played
        If sender.Text = sender.Name Then 'Not played
            sender.Text = LblXorO.Text ' Pick up the X or O 
            WinOrLose() ' Check to see if this player has won
            ' 
            ' Switch Between "X"  and "O"
            If LblXorO.Text = "X" Then
                LblXorO.Text = "O" ' Only if LblXorO.Text = "X"
            Else
                LblXorO.Text = "X" ' Only if LblXorO.Text NOT "X"
            End If
        End If
    End Sub

    Private Sub FrmTicTacToe_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'Paint Tic Tac Toe Lines
        Dim g As Graphics = Me.CreateGraphics
        ' Create pen (Color, Width)
        Dim blackPen As New Pen(Color.Black, 3)
        ' DrawLine (X1 , Y1 , X2 , Y2)
        g.DrawLine(blackPen, 20, 80, 300, 80) 'Horz1
        g.DrawLine(blackPen, 20, 125, 300, 125) 'Horz2
        '
        g.DrawLine(blackPen, 115, 30, 115, 200) 'Vert1
        g.DrawLine(blackPen, 205, 30, 205, 200) 'Vert2
    End Sub
    Private Sub WinOrLose()
        Dim i As Integer
        For i = 1 To 7 Step 3  ' 1,2,3 or 4,5,6 or 7,8,9
            If LblTTT(i).Text = LblXorO.Text _
                And LblTTT(i + 1).Text = LblXorO.Text _
                And LblTTT(i + 2).Text = LblXorO.Text Then
                MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
                BtnStart.Visible = True  ' Show Start Button
                Exit Sub    ' Exit if any player won
            End If
        Next
        For i = 1 To 3    ' 1,4,7 or 2,5,8 or 3,6,9
            If LblTTT(i).Text = LblXorO.Text _
                And LblTTT(i + 3).Text = LblXorO.Text _
                And LblTTT(i + 6).Text = LblXorO.Text Then
                MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
                BtnStart.Visible = True  ' Show Start Button
                Exit Sub    ' Exit if any player won
            End If
        Next
        ' Lbl1.text=Lbl5.text=Lbl9.text
        If LblTTT(1).Text = LblXorO.Text _
            And LblTTT(5).Text = LblXorO.Text _
            And LblTTT(9).Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        ' Lbl3.text=Lbl5.text=Lbl7.text
        If LblTTT(3).Text = LblXorO.Text _
            And LblTTT(5).Text = LblXorO.Text _
            And LblTTT(7).Text = LblXorO.Text Then
            MsgBox(LblXorO.Text & " Won", MsgBoxStyle.OkOnly, "Winner")
            BtnStart.Visible = True  ' Show Start Button
            Exit Sub    ' Exit if any player won
        End If
        For i = 1 To 9    ' Exit if square has NOT been played
            If LblTTT(i).Text = LblTTT(i).Name Then Exit Sub
        Next
        MsgBox("The Cat Won", MsgBoxStyle.OkOnly, "Cat Wins") ' All squares played
        BtnStart.Visible = True  ' Show Start Button
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Dim i As Integer
        ' Reset all the Labels
        For i = 1 To 9
            LblTTT(i).Text = i
        Next
        BtnStart.Visible = False  ' Hide Start Button
    End Sub
End Class