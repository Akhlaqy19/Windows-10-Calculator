Namespace Toast
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.toastPosition = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.message = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.labelX3 = New DevComponents.DotNetBar.LabelX()
        Me.labelX4 = New DevComponents.DotNetBar.LabelX()
        Me.toastGlow = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.slider1 = New DevComponents.DotNetBar.Controls.Slider()
        Me.checkBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.customGlowColor = New DevComponents.DotNetBar.ColorPickerButton()
        Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout
        '
        'labelX1
        '
        Me.labelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.labelX1.ForeColor = System.Drawing.Color.Black
        Me.labelX1.Location = New System.Drawing.Point(12, 12)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(523, 23)
        Me.labelX1.TabIndex = 0
        Me.labelX1.Text = "Toast Notifications"
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX1.Location = New System.Drawing.Point(411, 329)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(124, 47)
        Me.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.buttonX1.TabIndex = 1
        Me.buttonX1.Text = "Show Toast"
        '
        'toastPosition
        '
        Me.toastPosition.DisplayMember = "Text"
        Me.toastPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.toastPosition.ForeColor = System.Drawing.Color.Black
        Me.toastPosition.FormattingEnabled = true
        Me.toastPosition.ItemHeight = 16
        Me.toastPosition.Location = New System.Drawing.Point(12, 155)
        Me.toastPosition.Name = "toastPosition"
        Me.toastPosition.Size = New System.Drawing.Size(100, 22)
        Me.toastPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.toastPosition.TabIndex = 2
        '
        'labelX2
        '
        Me.labelX2.AutoSize = true
        Me.labelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.ForeColor = System.Drawing.Color.Black
        Me.labelX2.Location = New System.Drawing.Point(12, 135)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(73, 17)
        Me.labelX2.TabIndex = 3
        Me.labelX2.Text = "Toast position:"
        '
        'message
        '
        Me.message.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.message.Border.Class = "TextBoxBorder"
        Me.message.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.message.DisabledBackColor = System.Drawing.Color.White
        Me.message.ForeColor = System.Drawing.Color.Black
        Me.message.Location = New System.Drawing.Point(12, 250)
        Me.message.Multiline = true
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(523, 63)
        Me.message.TabIndex = 4
        Me.message.Text = "This is simple toast notification"
        '
        'labelX3
        '
        Me.labelX3.AutoSize = true
        Me.labelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX3.ForeColor = System.Drawing.Color.Black
        Me.labelX3.Location = New System.Drawing.Point(12, 230)
        Me.labelX3.Name = "labelX3"
        Me.labelX3.Size = New System.Drawing.Size(48, 17)
        Me.labelX3.TabIndex = 5
        Me.labelX3.Text = "Message:"
        '
        'labelX4
        '
        Me.labelX4.AutoSize = true
        Me.labelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX4.ForeColor = System.Drawing.Color.Black
        Me.labelX4.Location = New System.Drawing.Point(12, 182)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(59, 17)
        Me.labelX4.TabIndex = 7
        Me.labelX4.Text = "Glow Color:"
        '
        'toastGlow
        '
        Me.toastGlow.DisplayMember = "Text"
        Me.toastGlow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.toastGlow.ForeColor = System.Drawing.Color.Black
        Me.toastGlow.FormattingEnabled = true
        Me.toastGlow.ItemHeight = 16
        Me.toastGlow.Location = New System.Drawing.Point(12, 202)
        Me.toastGlow.Name = "toastGlow"
        Me.toastGlow.Size = New System.Drawing.Size(100, 22)
        Me.toastGlow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.toastGlow.TabIndex = 6
        '
        'slider1
        '
        Me.slider1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.slider1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.slider1.ForeColor = System.Drawing.Color.Black
        Me.slider1.LabelWidth = 110
        Me.slider1.Location = New System.Drawing.Point(218, 155)
        Me.slider1.Maximum = 30
        Me.slider1.Minimum = 1
        Me.slider1.Name = "slider1"
        Me.slider1.Size = New System.Drawing.Size(317, 20)
        Me.slider1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.slider1.TabIndex = 8
        Me.slider1.Text = "Duration 3 seconds:"
        Me.slider1.Value = 3
        '
        'checkBoxX1
        '
        Me.checkBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkBoxX1.ForeColor = System.Drawing.Color.Black
        Me.checkBoxX1.Location = New System.Drawing.Point(218, 202)
        Me.checkBoxX1.Name = "checkBoxX1"
        Me.checkBoxX1.Size = New System.Drawing.Size(147, 20)
        Me.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkBoxX1.TabIndex = 9
        Me.checkBoxX1.Text = "Show image on toast"
        '
        'customGlowColor
        '
        Me.customGlowColor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.customGlowColor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.customGlowColor.Image = CType(resources.GetObject("customGlowColor.Image"),System.Drawing.Image)
        Me.customGlowColor.Location = New System.Drawing.Point(118, 201)
        Me.customGlowColor.Name = "customGlowColor"
        Me.customGlowColor.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.customGlowColor.Size = New System.Drawing.Size(37, 23)
        Me.customGlowColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.customGlowColor.TabIndex = 10
        Me.customGlowColor.Visible = false
        '
        'styleManager1
        '
        Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(117,Byte),Integer), CType(CType(181,Byte),Integer)))
        '
        'labelX5
        '
        Me.labelX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX5.ForeColor = System.Drawing.Color.Black
        Me.labelX5.Location = New System.Drawing.Point(12, 41)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(523, 81)
        Me.labelX5.TabIndex = 11
        Me.labelX5.Text = resources.GetString("labelX5.Text")
        Me.labelX5.WordWrap = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(547, 385)
        Me.Controls.Add(Me.labelX5)
        Me.Controls.Add(Me.customGlowColor)
        Me.Controls.Add(Me.checkBoxX1)
        Me.Controls.Add(Me.slider1)
        Me.Controls.Add(Me.labelX4)
        Me.Controls.Add(Me.toastGlow)
        Me.Controls.Add(Me.labelX3)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.labelX2)
        Me.Controls.Add(Me.toastPosition)
        Me.Controls.Add(Me.buttonX1)
        Me.Controls.Add(Me.labelX1)
        Me.DoubleBuffered = true
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "Form1"
        Me.Text = "Toast Notifications"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

		#End Region

		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
		Private toastPosition As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private message As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX3 As DevComponents.DotNetBar.LabelX
		Private labelX4 As DevComponents.DotNetBar.LabelX
		Private WithEvents toastGlow As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private WithEvents slider1 As DevComponents.DotNetBar.Controls.Slider
		Private checkBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
		Private customGlowColor As DevComponents.DotNetBar.ColorPickerButton
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private labelX5 As DevComponents.DotNetBar.LabelX

	End Class
End Namespace

