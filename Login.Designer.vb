<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaTileButton1 = New Guna.UI.WinForms.GunaTileButton()
        Me.GunaLinkLabel2 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaLineTextBox2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GunaGradient2Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaTileButton1)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLinkLabel2)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLinkLabel1)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLineTextBox2)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLineTextBox1)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Black
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Black
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(290, 74)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(228, 235)
        Me.GunaGradient2Panel1.TabIndex = 0
        '
        'GunaTileButton1
        '
        Me.GunaTileButton1.Animated = True
        Me.GunaTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaTileButton1.AnimationSpeed = 0.03!
        Me.GunaTileButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTileButton1.BaseColor = System.Drawing.Color.Black
        Me.GunaTileButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaTileButton1.BorderSize = 3
        Me.GunaTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTileButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaTileButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTileButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaTileButton1.Image = Nothing
        Me.GunaTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaTileButton1.Location = New System.Drawing.Point(31, 156)
        Me.GunaTileButton1.Name = "GunaTileButton1"
        Me.GunaTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaTileButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaTileButton1.OnHoverImage = Nothing
        Me.GunaTileButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaTileButton1.Radius = 10
        Me.GunaTileButton1.Size = New System.Drawing.Size(160, 26)
        Me.GunaTileButton1.TabIndex = 5
        Me.GunaTileButton1.Text = "SUBMIT"
        '
        'GunaLinkLabel2
        '
        Me.GunaLinkLabel2.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaLinkLabel2.AutoSize = True
        Me.GunaLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel2.LinkColor = System.Drawing.Color.Crimson
        Me.GunaLinkLabel2.Location = New System.Drawing.Point(160, 199)
        Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
        Me.GunaLinkLabel2.Size = New System.Drawing.Size(65, 20)
        Me.GunaLinkLabel2.TabIndex = 4
        Me.GunaLinkLabel2.TabStop = True
        Me.GunaLinkLabel2.Text = "Sign Up!"
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Highlight
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.Crimson
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(3, 199)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(118, 20)
        Me.GunaLinkLabel1.TabIndex = 3
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Forgot Password"
        Me.GunaLinkLabel1.VisitedLinkColor = System.Drawing.SystemColors.MenuHighlight
        '
        'GunaLineTextBox2
        '
        Me.GunaLineTextBox2.BackColor = System.Drawing.Color.Black
        Me.GunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox2.ForeColor = System.Drawing.Color.White
        Me.GunaLineTextBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox2.Location = New System.Drawing.Point(31, 93)
        Me.GunaLineTextBox2.Name = "GunaLineTextBox2"
        Me.GunaLineTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.GunaLineTextBox2.Size = New System.Drawing.Size(160, 30)
        Me.GunaLineTextBox2.TabIndex = 2
        Me.GunaLineTextBox2.Tag = "Password"
        Me.GunaLineTextBox2.Text = "Password"
        Me.GunaLineTextBox2.UseSystemPasswordChar = True
        '
        'GunaLineTextBox1
        '
        Me.GunaLineTextBox1.Animated = True
        Me.GunaLineTextBox1.BackColor = System.Drawing.Color.Black
        Me.GunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox1.ForeColor = System.Drawing.Color.White
        Me.GunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(31, 42)
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(160, 30)
        Me.GunaLineTextBox1.TabIndex = 1
        Me.GunaLineTextBox1.Tag = "Username"
        Me.GunaLineTextBox1.Text = "Username"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(83, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(57, 17)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "LOGIN"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLineTextBox2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTileButton1 As Guna.UI.WinForms.GunaTileButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
