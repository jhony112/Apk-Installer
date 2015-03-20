<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.YtTheme1 = New Apk_Installer.YTTheme()
        Me.YtButton2 = New Apk_Installer.YTButton()
        Me.YtButton1 = New Apk_Installer.YTButton()
        Me.YtTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'YtTheme1
        '
        Me.YtTheme1.BackColor = System.Drawing.Color.White
        Me.YtTheme1.Controls.Add(Me.YtButton2)
        Me.YtTheme1.Controls.Add(Me.YtButton1)
        Me.YtTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YtTheme1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.YtTheme1.ForeColor = System.Drawing.Color.White
        Me.YtTheme1.Image = Nothing
        Me.YtTheme1.Location = New System.Drawing.Point(0, 0)
        Me.YtTheme1.MoveHeight = 20
        Me.YtTheme1.Name = "YtTheme1"
        Me.YtTheme1.Resizable = False
        Me.YtTheme1.Size = New System.Drawing.Size(596, 360)
        Me.YtTheme1.TabIndex = 0
        Me.YtTheme1.Text = "Apk Installer"
        Me.YtTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'YtButton2
        '
        Me.YtButton2.Image = Nothing
        Me.YtButton2.Location = New System.Drawing.Point(383, 260)
        Me.YtButton2.Name = "YtButton2"
        Me.YtButton2.NoRounding = False
        Me.YtButton2.Size = New System.Drawing.Size(130, 26)
        Me.YtButton2.TabIndex = 1
        Me.YtButton2.Text = "Install"
        '
        'YtButton1
        '
        Me.YtButton1.Image = Nothing
        Me.YtButton1.Location = New System.Drawing.Point(109, 195)
        Me.YtButton1.Name = "YtButton1"
        Me.YtButton1.NoRounding = False
        Me.YtButton1.Size = New System.Drawing.Size(75, 23)
        Me.YtButton1.TabIndex = 0
        Me.YtButton1.Text = "YtButton1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 360)
        Me.Controls.Add(Me.YtTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.YtTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents YtTheme1 As Apk_Installer.YTTheme
    Friend WithEvents YtButton2 As Apk_Installer.YTButton
    Friend WithEvents YtButton1 As Apk_Installer.YTButton
End Class
