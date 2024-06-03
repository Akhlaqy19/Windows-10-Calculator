Namespace TokenEditorDemo
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
        Me.tokenEmails = New DevComponents.DotNetBar.Controls.TokenEditor()
        Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.tokenEditor1 = New DevComponents.DotNetBar.Controls.TokenEditor()
        Me.warningBox1 = New DevComponents.DotNetBar.Controls.WarningBox()
        Me.SuspendLayout
        '
        'tokenEmails
        '
        '
        '
        '
        Me.tokenEmails.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tokenEmails.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tokenEmails.Location = New System.Drawing.Point(12, 30)
        Me.tokenEmails.MaxHeightLines = 3
        Me.tokenEmails.Name = "tokenEmails"
        Me.tokenEmails.Separators.Add(";")
        Me.tokenEmails.Separators.Add(",")
        Me.tokenEmails.Size = New System.Drawing.Size(348, 21)
        Me.tokenEmails.TabIndex = 0
        '
        'styleManager1
        '
        Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43,Byte),Integer), CType(CType(87,Byte),Integer), CType(CType(154,Byte),Integer)))
        '
        'labelX1
        '
        '
        '
        '
        Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX1.Location = New System.Drawing.Point(12, 4)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(221, 23)
        Me.labelX1.TabIndex = 1
        Me.labelX1.Text = "E-mail address entry:"
        '
        'labelX2
        '
        '
        '
        '
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.Location = New System.Drawing.Point(12, 104)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(348, 23)
        Me.labelX2.TabIndex = 3
        Me.labelX2.Text = "Keywords separated by comma or semicolon entry:"
        '
        'tokenEditor1
        '
        '
        '
        '
        Me.tokenEditor1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tokenEditor1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tokenEditor1.Location = New System.Drawing.Point(12, 130)
        Me.tokenEditor1.MaxHeightLines = 3
        Me.tokenEditor1.Name = "tokenEditor1"
        Me.tokenEditor1.Separators.Add(";")
        Me.tokenEditor1.Separators.Add(",")
        Me.tokenEditor1.Size = New System.Drawing.Size(348, 21)
        Me.tokenEditor1.TabIndex = 2
        '
        'warningBox1
        '
        Me.warningBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205,Byte),Integer), CType(CType(223,Byte),Integer), CType(CType(245,Byte),Integer))
        Me.warningBox1.CloseButtonVisible = false
        Me.warningBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.warningBox1.Image = CType(resources.GetObject("warningBox1.Image"),System.Drawing.Image)
        Me.warningBox1.Location = New System.Drawing.Point(0, 263)
        Me.warningBox1.Name = "warningBox1"
        Me.warningBox1.OptionsText = "Read Now..."
        Me.warningBox1.Size = New System.Drawing.Size(372, 33)
        Me.warningBox1.TabIndex = 4
        Me.warningBox1.Text = "Getting started with TokenEditor control"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(372, 296)
        Me.Controls.Add(Me.warningBox1)
        Me.Controls.Add(Me.labelX2)
        Me.Controls.Add(Me.tokenEditor1)
        Me.Controls.Add(Me.labelX1)
        Me.Controls.Add(Me.tokenEmails)
        Me.DoubleBuffered = true
        Me.EnableGlass = false
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.Text = "Token Editor Control Demo"
        Me.ResumeLayout(false)

End Sub

		#End Region

		Private WithEvents tokenEmails As DevComponents.DotNetBar.Controls.TokenEditor
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private WithEvents tokenEditor1 As DevComponents.DotNetBar.Controls.TokenEditor
		Private WithEvents warningBox1 As DevComponents.DotNetBar.Controls.WarningBox
	End Class
End Namespace

