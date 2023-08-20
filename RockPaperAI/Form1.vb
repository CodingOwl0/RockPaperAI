Public Class Form1
    Private ReadOnly userChoice As New List(Of Wahl)
    Private ReadOnly pcChoice As New List(Of Wahl)
    Private ReadOnly scoreBoard(1) As Integer '0=Player, 1=Computer
    Private ReadOnly markovMatrix(2, 2) As Integer
    Private ReadOnly r As New Random

    Private Enum Wahl
        Scissors
        Stone
        Paper
    End Enum
    Private Enum Player
        Player1
        Computer
        None
    End Enum

    Private Sub B_UserAuswahl_Click(sender As Object, e As EventArgs) Handles B_Schere.Click, B_Papier.Click, B_Stein.Click
        Dim x As Button = CType(sender, Button)
        userChoice.Add(DirectCast([Enum].Parse(GetType(Wahl), x.Text), Wahl))

        If userChoice.Count - 1 = 0 Then
            pcChoice.Add(CType(r.Next(0, 2), Wahl))
        Else
            pcChoice.Add(Predict())
        End If

        Dim won As Player = WhoWon(userChoice(userChoice.Count - 1), pcChoice(pcChoice.Count - 1))
        Select Case won
            Case Player.Player1
                scoreBoard(0) += 1
            Case Player.Computer
                scoreBoard(1) += 1
        End Select
        L_Output.Text = pcChoice(pcChoice.Count - 1).ToString
        L_Won.Text = won.ToString
        L_PlayerScore.Text = scoreBoard(0).ToString
        L_PCScore.Text = scoreBoard(1).ToString
    End Sub
    Private Function Predict() As Wahl
        Dim output As Wahl = Nothing
        markovMatrix(userChoice(userChoice.Count - 2), userChoice(userChoice.Count - 1)) += 1

        Dim score As Integer = 0
        For n As Integer = 0 To 2
            If markovMatrix(n, userChoice(userChoice.Count - 1)) >= score Then
                Dim xs As Wahl = CType(n, Wahl)
                score = markovMatrix(n, userChoice(userChoice.Count - 1))
                output = xs
                Select Case xs
                    Case Wahl.Schere
                        output = Wahl.Stein
                    Case Wahl.Stein
                        output = Wahl.Papier
                    Case Wahl.Papier
                        output = Wahl.Schere
                End Select
            End If
        Next
        Return output
    End Function

    Private Function WhoWon(userC As Wahl, pcC As Wahl) As Player
        Dim won As Player = Nothing
        Select Case userC
            Case Wahl.Schere
                If pcC = Wahl.Schere Then
                    won = Player.None
                ElseIf pcC = Wahl.Stein Then
                    won = Player.Computer
                Else
                    won = Player.Player1
                End If
            Case Wahl.Stein
                If pcC = Wahl.Stein Then
                    won = Player.None
                ElseIf pcC = Wahl.Papier Then
                    won = Player.Computer
                Else
                    won = Player.Player1
                End If
            Case Wahl.Papier
                If pcC = Wahl.Papier Then
                    won = Player.None
                ElseIf pcC = Wahl.Schere Then
                    won = Player.Computer
                Else
                    won = Player.Player1
                End If
        End Select
        Return won
    End Function

    Private Sub B_Reset_Click(sender As Object, e As EventArgs) Handles B_Reset.Click
        userChoice.Clear()
        pcChoice.Clear()
        scoreBoard(0) = 0
        scoreBoard(1) = 0
        L_Output.Text = ""
        L_Won.Text = ""
        L_PCScore.Text = ""
        L_PlayerScore.Text = ""
    End Sub
End Class
