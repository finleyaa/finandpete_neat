Public Class Player

    Public Position As Point
    Public Alive As Boolean = True

    Public Size As Integer = 40

    Public MoveL As Boolean = False
    Public MoveR As Boolean = False

    Public Sub New(StartPos As Point)

        Position = StartPos

    End Sub

    Public Sub MoveLeft()
        If Alive Then
            Position.X -= 10
            If Position.X < 0 Then
                Position.X = 0
            End If
        End If
    End Sub

    Public Sub MoveRight()
        If Alive Then
            Position.X += 10
            If Position.X + Size > WallAvoid_Form.MainWindow.Width Then
                Position.X = WallAvoid_Form.MainWindow.Width - Size
            End If
        End If
    End Sub

    Public Sub Draw(g As Graphics)
        If Alive Then
            g.FillRectangle(Brushes.Blue, Position.X, Position.Y - Size, Size, Size)
        Else
            g.FillRectangle(Brushes.Red, Position.X, Position.Y - Size, Size, Size)
        End If
    End Sub

End Class
