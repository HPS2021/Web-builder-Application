<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPConfirm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPConfirm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaGradientCircleButton1 = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(146, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please login with your Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(146, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "and new Password!"
        '
        'GunaGradientCircleButton1
        '
        Me.GunaGradientCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientCircleButton1.AnimationSpeed = 0.03!
        Me.GunaGradientCircleButton1.BaseColor1 = System.Drawing.Color.DarkMagenta
        Me.GunaGradientCircleButton1.BaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientCircleButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientCircleButton1.Image = Nothing
        Me.GunaGradientCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaGradientCircleButton1.Location = New System.Drawing.Point(538, 114)
        Me.GunaGradientCircleButton1.Name = "GunaGradientCircleButton1"
        Me.GunaGradientCircleButton1.OnHoverBaseColor1 = System.Drawing.Color.Red
        Me.GunaGradientCircleButton1.OnHoverBaseColor2 = System.Drawing.Color.DarkBlue
        Me.GunaGradientCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientCircleButton1.OnHoverImage = Nothing
        Me.GunaGradientCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientCircleButton1.Size = New System.Drawing.Size(66, 54)
        Me.GunaGradientCircleButton1.TabIndex = 3
        Me.GunaGradientCircleButton1.Text = "OK"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(38, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 75)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'RPConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(641, 190)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaGradientCircleButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "RPConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaGradientCircleButton1 As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
