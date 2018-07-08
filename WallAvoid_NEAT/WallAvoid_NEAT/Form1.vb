Public Class WallAvoid_Form

    Public Wall1 As Wall
    Public Player1 As Player

    Public MaxTotalWallSize As Integer = 400
    Public GapSize As Integer = 100

    Public Rnd As New Random

    Public WallsPassed As Integer = 0
    Public HighScore As Integer = 0
    Public ScoreFont As New Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold)

    Private Sub WallAvoid_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ClientSize = New Size(400, 800)

        Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - Me.ClientSize.Width / 2, My.Computer.Screen.Bounds.Height / 2 - Me.ClientSize.Height / 2)

        MainWindow.Size = Me.ClientSize
        MainWindow.Location = New Point(0, 0)

        StartGame()

    End Sub

    Private Sub DrawTimer_Tick(sender As Object, e As EventArgs) Handles DrawTimer.Tick

        If WallsPassed > HighScore Then
            HighScore = WallsPassed
        End If

        If Player1.MoveL Then
            Player1.MoveLeft()
        End If

        If Player1.MoveR Then
            Player1.MoveRight()
        End If

        MainWindow.Refresh()

        If Player1.Position.Y - Player1.Size < Wall1.Y + Wall1.WallHeight Then
            If Player1.Position.X < Wall1.LeftWallX Or Player1.Position.X + Player1.Size > Wall1.RightWallX Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
                Player1.Alive = False
                DrawTimer.Stop()
                MainWindow.Refresh()
            End If
        End If

        Wall1.MoveDown()

    End Sub

    Private Sub MainWindow_Paint(sender As Object, e As PaintEventArgs) Handles MainWindow.Paint

        Wall1.Draw(e.Graphics)
        Player1.Draw(e.Graphics)
        e.Graphics.DrawString("Score: " & WallsPassed, ScoreFont, Brushes.Gray, New Point(0, 0))
        e.Graphics.DrawString("Highscore: " & HighScore, ScoreFont, Brushes.Gray, New Point(MainWindow.Width - 10 - e.Graphics.MeasureString("Highscore: " & HighScore, ScoreFont).Width, 0))

    End Sub

    Private Sub WallAvoid_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.A Then
            Player1.MoveL = True
        ElseIf e.KeyCode = Keys.D Then
            Player1.MoveR = True
        ElseIf e.KeyCode = Keys.R Then
            StartGame()
        End If

    End Sub

    Private Sub WallAvoid_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        If e.KeyCode = Keys.A Then
            Player1.MoveL = False
        ElseIf e.KeyCode = Keys.D Then
            Player1.MoveR = False
        End If

    End Sub

    Private Sub StartGame()
        WallsPassed = 0

        Wall1 = New Wall(MaxTotalWallSize, GapSize, Rnd)
        Player1 = New Player(New Point(Me.ClientSize.Width / 2, Me.ClientSize.Height))

        DrawTimer.Start()
    End Sub
End Class
