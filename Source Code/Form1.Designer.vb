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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Options = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.s_accept = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcanvas = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sinc = New System.Windows.Forms.Button()
        Me.KeyCanvas = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Wbox = New System.Windows.Forms.GroupBox()
        Me.Woff = New System.Windows.Forms.RadioButton()
        Me.Won = New System.Windows.Forms.RadioButton()
        Me.Paste = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sbutton = New System.Windows.Forms.Button()
        Me.Options.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Wbox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(190, 195)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(153, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.ultim8-vineeth.blogspot.in"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(83, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "More like this at :"
        '
        'Options
        '
        Me.Options.Controls.Add(Me.TabControl1)
        Me.Options.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Options.ForeColor = System.Drawing.Color.DarkGreen
        Me.Options.Location = New System.Drawing.Point(95, 50)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(234, 142)
        Me.Options.TabIndex = 4
        Me.Options.TabStop = False
        Me.Options.Text = "Settings"
        Me.Options.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(228, 114)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.s_accept)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.tcanvas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(220, 79)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Time Lag"
        '
        's_accept
        '
        Me.s_accept.BackColor = System.Drawing.SystemColors.Desktop
        Me.s_accept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.s_accept.ForeColor = System.Drawing.Color.White
        Me.s_accept.Location = New System.Drawing.Point(71, 39)
        Me.s_accept.Name = "s_accept"
        Me.s_accept.Size = New System.Drawing.Size(75, 32)
        Me.s_accept.TabIndex = 5
        Me.s_accept.Text = "Done"
        Me.s_accept.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Set time Lag (sec) :"
        '
        'tcanvas
        '
        Me.tcanvas.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcanvas.Location = New System.Drawing.Point(167, 8)
        Me.tcanvas.Name = "tcanvas"
        Me.tcanvas.Size = New System.Drawing.Size(34, 29)
        Me.tcanvas.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Sinc)
        Me.TabPage2.Controls.Add(Me.KeyCanvas)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(220, 79)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Special Keys"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(-9, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 35)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Under Construction"
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources._1471203430_icon_minus_round
        Me.Button1.Location = New System.Drawing.Point(186, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(19, 22)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sinc
        '
        Me.Sinc.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sinc.Image = Global.WindowsApplication1.My.Resources.Resources._1471203370_add
        Me.Sinc.Location = New System.Drawing.Point(162, 0)
        Me.Sinc.Name = "Sinc"
        Me.Sinc.Size = New System.Drawing.Size(21, 22)
        Me.Sinc.TabIndex = 4
        Me.Sinc.UseVisualStyleBackColor = True
        '
        'KeyCanvas
        '
        Me.KeyCanvas.AutoSize = True
        Me.KeyCanvas.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCanvas.ForeColor = System.Drawing.Color.White
        Me.KeyCanvas.Location = New System.Drawing.Point(4, 24)
        Me.KeyCanvas.Name = "KeyCanvas"
        Me.KeyCanvas.Size = New System.Drawing.Size(120, 21)
        Me.KeyCanvas.TabIndex = 1
        Me.KeyCanvas.Text = "<-------->"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Special Keys :"
        '
        'Wbox
        '
        Me.Wbox.Controls.Add(Me.Woff)
        Me.Wbox.Controls.Add(Me.Won)
        Me.Wbox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wbox.ForeColor = System.Drawing.Color.White
        Me.Wbox.Location = New System.Drawing.Point(13, 123)
        Me.Wbox.Name = "Wbox"
        Me.Wbox.Size = New System.Drawing.Size(92, 57)
        Me.Wbox.TabIndex = 6
        Me.Wbox.TabStop = False
        Me.Wbox.Text = "Warning"
        Me.Wbox.Visible = False
        '
        'Woff
        '
        Me.Woff.AutoSize = True
        Me.Woff.Location = New System.Drawing.Point(5, 33)
        Me.Woff.Name = "Woff"
        Me.Woff.Size = New System.Drawing.Size(43, 21)
        Me.Woff.TabIndex = 2
        Me.Woff.Text = "off"
        Me.Woff.UseVisualStyleBackColor = True
        '
        'Won
        '
        Me.Won.AutoSize = True
        Me.Won.Checked = True
        Me.Won.Location = New System.Drawing.Point(5, 16)
        Me.Won.Name = "Won"
        Me.Won.Size = New System.Drawing.Size(40, 21)
        Me.Won.TabIndex = 1
        Me.Won.TabStop = True
        Me.Won.Text = "on"
        Me.Won.UseVisualStyleBackColor = True
        '
        'Paste
        '
        Me.Paste.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg
        Me.Paste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Paste.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paste.ForeColor = System.Drawing.Color.White
        Me.Paste.Location = New System.Drawing.Point(120, 129)
        Me.Paste.Name = "Paste"
        Me.Paste.Size = New System.Drawing.Size(162, 49)
        Me.Paste.TabIndex = 0
        Me.Paste.Text = "Paste"
        Me.Paste.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(371, 99)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'sbutton
        '
        Me.sbutton.BackColor = System.Drawing.Color.Black
        Me.sbutton.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sicon
        Me.sbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sbutton.Location = New System.Drawing.Point(322, 135)
        Me.sbutton.Name = "sbutton"
        Me.sbutton.Size = New System.Drawing.Size(38, 38)
        Me.sbutton.TabIndex = 5
        Me.sbutton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(399, 218)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Paste)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Wbox)
        Me.Controls.Add(Me.sbutton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SkillRack Bypass by ----Vineeth----"
        Me.Options.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Wbox.ResumeLayout(False)
        Me.Wbox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Paste As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Options As GroupBox
    Friend WithEvents sbutton As Button
    Friend WithEvents Wbox As GroupBox
    Friend WithEvents Woff As RadioButton
    Friend WithEvents Won As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents s_accept As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tcanvas As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents KeyCanvas As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Sinc As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
