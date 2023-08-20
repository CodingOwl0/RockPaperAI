<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.B_Schere = New System.Windows.Forms.Button()
        Me.B_Stein = New System.Windows.Forms.Button()
        Me.B_Papier = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_Output = New System.Windows.Forms.Label()
        Me.L_Won = New System.Windows.Forms.Label()
        Me.B_Reset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L_PlayerScore = New System.Windows.Forms.Label()
        Me.L_PCScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'B_Schere
        '
        Me.B_Schere.Location = New System.Drawing.Point(12, 12)
        Me.B_Schere.Name = "B_Schere"
        Me.B_Schere.Size = New System.Drawing.Size(234, 29)
        Me.B_Schere.TabIndex = 0
        Me.B_Schere.Text = "Schere"
        Me.B_Schere.UseVisualStyleBackColor = True
        '
        'B_Stein
        '
        Me.B_Stein.Location = New System.Drawing.Point(12, 47)
        Me.B_Stein.Name = "B_Stein"
        Me.B_Stein.Size = New System.Drawing.Size(234, 29)
        Me.B_Stein.TabIndex = 1
        Me.B_Stein.Text = "Stein"
        Me.B_Stein.UseVisualStyleBackColor = True
        '
        'B_Papier
        '
        Me.B_Papier.Location = New System.Drawing.Point(12, 82)
        Me.B_Papier.Name = "B_Papier"
        Me.B_Papier.Size = New System.Drawing.Size(234, 29)
        Me.B_Papier.TabIndex = 2
        Me.B_Papier.Text = "Papier"
        Me.B_Papier.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Computer wählt: "
        '
        'L_Output
        '
        Me.L_Output.AutoSize = True
        Me.L_Output.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.L_Output.Location = New System.Drawing.Point(435, 16)
        Me.L_Output.Name = "L_Output"
        Me.L_Output.Size = New System.Drawing.Size(52, 20)
        Me.L_Output.TabIndex = 4
        Me.L_Output.Text = "NONE"
        '
        'L_Won
        '
        Me.L_Won.AutoSize = True
        Me.L_Won.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.L_Won.Location = New System.Drawing.Point(307, 162)
        Me.L_Won.Name = "L_Won"
        Me.L_Won.Size = New System.Drawing.Size(125, 28)
        Me.L_Won.TabIndex = 5
        Me.L_Won.Text = "No one won"
        '
        'B_Reset
        '
        Me.B_Reset.Location = New System.Drawing.Point(12, 165)
        Me.B_Reset.Name = "B_Reset"
        Me.B_Reset.Size = New System.Drawing.Size(234, 29)
        Me.B_Reset.TabIndex = 6
        Me.B_Reset.Text = "Reset"
        Me.B_Reset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Computer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Player:"
        '
        'L_PlayerScore
        '
        Me.L_PlayerScore.AutoSize = True
        Me.L_PlayerScore.Location = New System.Drawing.Point(391, 56)
        Me.L_PlayerScore.Name = "L_PlayerScore"
        Me.L_PlayerScore.Size = New System.Drawing.Size(17, 20)
        Me.L_PlayerScore.TabIndex = 10
        Me.L_PlayerScore.Text = "0"
        '
        'L_PCScore
        '
        Me.L_PCScore.AutoSize = True
        Me.L_PCScore.Location = New System.Drawing.Point(391, 82)
        Me.L_PCScore.Name = "L_PCScore"
        Me.L_PCScore.Size = New System.Drawing.Size(17, 20)
        Me.L_PCScore.TabIndex = 11
        Me.L_PCScore.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 213)
        Me.Controls.Add(Me.L_PCScore)
        Me.Controls.Add(Me.L_PlayerScore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_Reset)
        Me.Controls.Add(Me.L_Won)
        Me.Controls.Add(Me.L_Output)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_Papier)
        Me.Controls.Add(Me.B_Stein)
        Me.Controls.Add(Me.B_Schere)
        Me.Name = "Form1"
        Me.Text = "RockPaperAI - Machine Learning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Schere As Button
    Friend WithEvents B_Stein As Button
    Friend WithEvents B_Papier As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents L_Output As Label
    Friend WithEvents L_Won As Label
    Friend WithEvents B_Reset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents L_PlayerScore As Label
    Friend WithEvents L_PCScore As Label
End Class
