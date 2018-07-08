<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WallAvoid_Form
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
        Me.components = New System.ComponentModel.Container()
        Me.MainWindow = New System.Windows.Forms.PictureBox()
        Me.DrawTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.MainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWindow
        '
        Me.MainWindow.Location = New System.Drawing.Point(13, 35)
        Me.MainWindow.Name = "MainWindow"
        Me.MainWindow.Size = New System.Drawing.Size(100, 50)
        Me.MainWindow.TabIndex = 0
        Me.MainWindow.TabStop = False
        '
        'DrawTimer
        '
        Me.DrawTimer.Interval = 10
        '
        'WallAvoid_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainWindow)
        Me.Name = "WallAvoid_Form"
        Me.Text = "Wall Avoid"
        CType(Me.MainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainWindow As PictureBox
    Friend WithEvents DrawTimer As Timer
End Class
