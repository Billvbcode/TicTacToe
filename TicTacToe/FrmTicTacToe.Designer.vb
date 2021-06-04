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
        Me.LblXorO = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblXorO
        '
        Me.LblXorO.AutoSize = True
        Me.LblXorO.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblXorO.Location = New System.Drawing.Point(352, 106)
        Me.LblXorO.Name = "LblXorO"
        Me.LblXorO.Size = New System.Drawing.Size(31, 29)
        Me.LblXorO.TabIndex = 0
        Me.LblXorO.Text = "X"
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(349, 61)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 25)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'FrmTicTacToe
        '
        Me.ClientSize = New System.Drawing.Size(536, 400)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LblXorO)
        Me.Name = "FrmTicTacToe"
        Me.Text = "TicTacToe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblXorO As Label
    Friend WithEvents BtnStart As Button
End Class
