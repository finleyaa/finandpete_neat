Public Class Wall

    Public RightWallX As Single = 0
    Public LeftWallX As Single = 0
    Public Y As Single = 0

    Public MaxTotalSize As Integer = 0

    Public WallHeight As Integer = 50
    Public GapSize As Integer = 0
    Public Rand As Random

    Public Sub New(MaxTotSize As Integer, GSize As Integer, Rnd As Random)

        MaxTotalSize = MaxTotSize
        GapSize = GSize

        Rand = Rnd

        RandomiseWall(Rand)

    End Sub

    Public Sub Draw(g As Graphics)

        g.FillRectangle(Brushes.Black, 0, Y, LeftWallX, WallHeight)
        g.FillRectangle(Brushes.Black, RightWallX, Y, MaxTotalSize, WallHeight)

    End Sub

    Public Sub MoveDown()

        If Y >= WallAvoid_Form.MainWindow.Height Then
            WallAvoid_Form.WallsPassed += 1
            Y = -WallHeight
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            GapSize = Math.Max(WallAvoid_Form.Player1.Size + 5, GapSize - 1)
            RandomiseWall(Rand)
        Else
            Y += 10
        End If

    End Sub

    Public Sub RandomiseWall(Rnd As Random)
        LeftWallX = Rnd.Next(MaxTotalSize - GapSize)
        RightWallX = LeftWallX + GapSize
    End Sub

End Class
