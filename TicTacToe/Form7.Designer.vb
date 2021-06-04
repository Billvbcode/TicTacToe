<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTicTacToe
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
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Lbl9 = New System.Windows.Forms.Label()
        Me.Lbl8 = New System.Windows.Forms.Label()
        Me.Lbl7 = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.LblXorO = New System.Windows.Forms.Label()
        'Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        'Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        'Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        'Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        'Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(21, 52)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(21, 24)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "1"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(110, 52)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(21, 24)
        Me.Lbl2.TabIndex = 1
        Me.Lbl2.Text = "2"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(197, 52)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(21, 24)
        Me.Lbl3.TabIndex = 2
        Me.Lbl3.Text = "3"
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl6.Location = New System.Drawing.Point(197, 96)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(21, 24)
        Me.Lbl6.TabIndex = 5
        Me.Lbl6.Text = "6"
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl5.Location = New System.Drawing.Point(110, 96)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(21, 24)
        Me.Lbl5.TabIndex = 5
        Me.Lbl5.Text = "5"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl4.Location = New System.Drawing.Point(21, 96)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(21, 24)
        Me.Lbl4.TabIndex = 3
        Me.Lbl4.Text = "4"
        '
        'Lbl9
        '
        Me.Lbl9.AutoSize = True
        Me.Lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl9.Location = New System.Drawing.Point(197, 136)
        Me.Lbl9.Name = "Lbl9"
        Me.Lbl9.Size = New System.Drawing.Size(21, 24)
        Me.Lbl9.TabIndex = 9
        Me.Lbl9.Text = "9"
        '
        'Lbl8
        '
        Me.Lbl8.AutoSize = True
        Me.Lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl8.Location = New System.Drawing.Point(110, 136)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(21, 24)
        Me.Lbl8.TabIndex = 7
        Me.Lbl8.Text = "8"
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl7.Location = New System.Drawing.Point(21, 136)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(21, 24)
        Me.Lbl7.TabIndex = 6
        Me.Lbl7.Text = "7"
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(26, 202)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 9
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        Me.BtnStart.Visible = False
        '
        'LblXorO
        '
        Me.LblXorO.AutoSize = True
        Me.LblXorO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblXorO.Location = New System.Drawing.Point(150, 199)
        Me.LblXorO.Name = "LblXorO"
        Me.LblXorO.Size = New System.Drawing.Size(25, 24)
        Me.LblXorO.TabIndex = 10
        Me.LblXorO.Text = "X"
        '
        'ShapeContainer1
        '
        'Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        'Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        'Me.ShapeContainer1.Name = "ShapeContainer1"
        'Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        'Me.ShapeContainer1.Size = New System.Drawing.Size(284, 264)
        'Me.ShapeContainer1.TabIndex = 11
        'Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        'Me.LineShape4.Name = "LineShape4"
        'Me.LineShape4.X1 = 10
        'Me.LineShape4.X2 = 270
        'Me.LineShape4.Y1 = 125
        'Me.LineShape4.Y2 = 125
        ''
        ''LineShape3
        ''
        'Me.LineShape3.Name = "LineShape3"
        'Me.LineShape3.X1 = 19
        'Me.LineShape3.X2 = 263
        'Me.LineShape3.Y1 = 83
        'Me.LineShape3.Y2 = 82
        '
        'LineShape2
        ''
        'Me.LineShape2.Name = "LineShape2"
        'Me.LineShape2.X1 = 183
        'Me.LineShape2.X2 = 184
        'Me.LineShape2.Y1 = 47
        'Me.LineShape2.Y2 = 172
        ''
        ''LineShape1
        ''
        'Me.LineShape1.Name = "LineShape1"
        'Me.LineShape1.X1 = 97
        'Me.LineShape1.X2 = 98
        'Me.LineShape1.Y1 = 53
        'Me.LineShape1.Y2 = 171
        '
        'FrmTicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.LblXorO)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.Lbl9)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        ' Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FrmTicTacToe"
        Me.Text = "Tic Tac Toe Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents Lbl3 As System.Windows.Forms.Label
    Friend WithEvents Lbl6 As System.Windows.Forms.Label
    Friend WithEvents Lbl5 As System.Windows.Forms.Label
    Friend WithEvents Lbl4 As System.Windows.Forms.Label
    Friend WithEvents Lbl9 As System.Windows.Forms.Label
    Friend WithEvents Lbl8 As System.Windows.Forms.Label
    Friend WithEvents Lbl7 As System.Windows.Forms.Label
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents LblXorO As System.Windows.Forms.Label
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
