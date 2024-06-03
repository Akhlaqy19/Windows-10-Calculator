Namespace ToolboxControlSample
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
			Me.toolboxControl1 = New DevComponents.DotNetBar.Controls.ToolboxControl()
			Me.toolboxGroup1 = New DevComponents.DotNetBar.Controls.ToolboxGroup()
			Me.toolboxItem1 = New DevComponents.DotNetBar.Controls.ToolboxItem()
			Me.toolboxItem4 = New DevComponents.DotNetBar.Controls.ToolboxItem()
			Me.toolboxItem5 = New DevComponents.DotNetBar.Controls.ToolboxItem()
			Me.toolboxItem6 = New DevComponents.DotNetBar.Controls.ToolboxItem()
			Me.toolboxGroup2 = New DevComponents.DotNetBar.Controls.ToolboxGroup()
			Me.toolboxItem2 = New DevComponents.DotNetBar.Controls.ToolboxItem()
			Me.toolboxItem3 = New DevComponents.DotNetBar.Controls.ToolboxItem()
			Me.toolboxGroup3 = New DevComponents.DotNetBar.Controls.ToolboxGroup()
			Me.toolboxItem7 = New DevComponents.DotNetBar.Controls.ToolboxItem()
			Me.toolboxItem8 = New DevComponents.DotNetBar.Controls.ToolboxItem()
			Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
			Me.checkBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
			Me.itemPanel1 = New DevComponents.DotNetBar.ItemPanel()
			Me.checkBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
			Me.checkBoxX3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
			Me.checkBoxX4 = New DevComponents.DotNetBar.Controls.CheckBoxX()
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.checkBoxX5 = New DevComponents.DotNetBar.Controls.CheckBoxX()
			Me.SuspendLayout()
			' 
			' toolboxControl1
			' 
			' 
			' 
			' 
			Me.toolboxControl1.BackgroundStyle.Class = "ToolboxControl"
			Me.toolboxControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.toolboxControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.toolboxControl1.ExpandedWidth = 0
			Me.toolboxControl1.Groups.Add(Me.toolboxGroup1)
			Me.toolboxControl1.Groups.Add(Me.toolboxGroup2)
			Me.toolboxControl1.Groups.Add(Me.toolboxGroup3)
			Me.toolboxControl1.Location = New System.Drawing.Point(0, 8)
			Me.toolboxControl1.Name = "toolboxControl1"
			Me.toolboxControl1.Padding = New System.Windows.Forms.Padding(2)
			Me.toolboxControl1.Size = New System.Drawing.Size(189, 380)
			Me.toolboxControl1.TabIndex = 0
			Me.toolboxControl1.Text = "toolboxControl1"
			Me.toolboxControl1.TitleText = "Charts"
			' 
			' toolboxGroup1
			' 
			' 
			' 
			' 
			Me.toolboxGroup1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.toolboxGroup1.EqualItemSize = True
			Me.toolboxGroup1.Expanded = True
			Me.toolboxGroup1.GlobalItem = False
			Me.toolboxGroup1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.toolboxGroup1.Name = "toolboxGroup1"
			Me.toolboxGroup1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.toolboxItem1, Me.toolboxItem4, Me.toolboxItem5, Me.toolboxItem6})
			' 
			' 
			' 
			Me.toolboxGroup1.TitleGroupExpandedStyle.Class = "ToolboxGroupExpandedTitle"
			Me.toolboxGroup1.TitleGroupExpandedStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.toolboxGroup1.TitleMouseOverStyle.Class = "ToolboxGroupTitleMouseOver"
			Me.toolboxGroup1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.toolboxGroup1.TitleStyle.Class = "ToolboxGroupTitle"
			Me.toolboxGroup1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.toolboxGroup1.TitleText = "Column"
			' 
			' toolboxItem1
			' 
			Me.toolboxItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.toolboxItem1.GlobalItem = False
			Me.toolboxItem1.Image = My.Resources.Chart1
			Me.toolboxItem1.Name = "toolboxItem1"
			Me.toolboxItem1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
			Me.toolboxItem1.Text = "Stacked Column"
			' 
			' toolboxItem4
			' 
			Me.toolboxItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.toolboxItem4.GlobalItem = False
			Me.toolboxItem4.Image = My.Resources.Chart2
			Me.toolboxItem4.Name = "toolboxItem4"
			Me.toolboxItem4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
			Me.toolboxItem4.Text = "100% Stacked Column"
			' 
			' toolboxItem5
			' 
			Me.toolboxItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.toolboxItem5.GlobalItem = False
			Me.toolboxItem5.Image = My.Resources.Chart3
			Me.toolboxItem5.Name = "toolboxItem5"
			Me.toolboxItem5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
			Me.toolboxItem5.Text = "3D Clustered Column"
			' 
			' toolboxItem6
			' 
			Me.toolboxItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.toolboxItem6.GlobalItem = False
			Me.toolboxItem6.Image = My.Resources.Chart4
			Me.toolboxItem6.Name = "toolboxItem6"
			Me.toolboxItem6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
			Me.toolboxItem6.Text = "3D Stacked Column"
			' 
			' toolboxGroup2
			' 
			' 
			' 
			' 
			Me.toolboxGroup2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.toolboxGroup2.EqualItemSize = True
			Me.toolboxGroup2.Expanded = True
			Me.toolboxGroup2.GlobalItem = False
			Me.toolboxGroup2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.toolboxGroup2.MultiLine = False
			Me.toolboxGroup2.Name = "toolboxGroup2"
			Me.toolboxGroup2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.toolboxItem2, Me.toolboxItem3})
			' 
			' 
			' 
			Me.toolboxGroup2.TitleGroupExpandedStyle.Class = "ToolboxGroupExpandedTitle"
			Me.toolboxGroup2.TitleGroupExpandedStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.toolboxGroup2.TitleMouseOverStyle.Class = "ToolboxGroupTitleMouseOver"
			Me.toolboxGroup2.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.toolboxGroup2.TitleStyle.Class = "ToolboxGroupTitle"
			Me.toolboxGroup2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.toolboxGroup2.TitleText = "Line"
			' 
			' toolboxItem2
			' 
			Me.toolboxItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.toolboxItem2.GlobalItem = False
			Me.toolboxItem2.Image = My.Resources.Chart5
			Me.toolboxItem2.Name = "toolboxItem2"
			Me.toolboxItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
			Me.toolboxItem2.Text = "Stacked Line"
			' 
			' toolboxItem3
			' 
			Me.toolboxItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.toolboxItem3.GlobalItem = False
			Me.toolboxItem3.Image = My.Resources.Chart6
			Me.toolboxItem3.Name = "toolboxItem3"
			Me.toolboxItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
			Me.toolboxItem3.Text = "Line With Markers"
			' 
			' toolboxGroup3
			' 
			' 
			' 
			' 
			Me.toolboxGroup3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.toolboxGroup3.EqualItemSize = True
			Me.toolboxGroup3.Expanded = True
			Me.toolboxGroup3.GlobalItem = False
			Me.toolboxGroup3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.toolboxGroup3.MultiLine = False
			Me.toolboxGroup3.Name = "toolboxGroup3"
			Me.toolboxGroup3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.toolboxItem7, Me.toolboxItem8})
			' 
			' 
			' 
			Me.toolboxGroup3.TitleGroupExpandedStyle.Class = "ToolboxGroupExpandedTitle"
			Me.toolboxGroup3.TitleGroupExpandedStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.toolboxGroup3.TitleMouseOverStyle.Class = "ToolboxGroupTitleMouseOver"
			Me.toolboxGroup3.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.toolboxGroup3.TitleStyle.Class = "ToolboxGroupTitle"
			Me.toolboxGroup3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.toolboxGroup3.TitleText = "Pie"
			' 
			' toolboxItem7
			' 
			Me.toolboxItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.toolboxItem7.GlobalItem = False
			Me.toolboxItem7.Image = My.Resources.Chart7
			Me.toolboxItem7.Name = "toolboxItem7"
			Me.toolboxItem7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
			Me.toolboxItem7.Text = "Pie"
			' 
			' toolboxItem8
			' 
			Me.toolboxItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.toolboxItem8.GlobalItem = False
			Me.toolboxItem8.Image = My.Resources.Chart8
			Me.toolboxItem8.Name = "toolboxItem8"
			Me.toolboxItem8.Text = "3D Pie"
			' 
			' styleManager1
			' 
			Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
			Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255))))), System.Drawing.Color.FromArgb((CInt((CByte(1)))), (CInt((CByte(115)))), (CInt((CByte(199))))))
			' 
			' checkBoxX1
			' 
			' 
			' 
			' 
			Me.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.checkBoxX1.Location = New System.Drawing.Point(245, 22)
			Me.checkBoxX1.Name = "checkBoxX1"
			Me.checkBoxX1.Size = New System.Drawing.Size(100, 26)
			Me.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.checkBoxX1.TabIndex = 1
			Me.checkBoxX1.Text = "Title Bar Visible"
'			Me.checkBoxX1.CheckedChanged += New System.EventHandler(Me.checkBoxX1_CheckedChanged)
			' 
			' itemPanel1
			' 
			Me.itemPanel1.AllowDrop = True
			' 
			' 
			' 
			Me.itemPanel1.BackgroundStyle.Class = "ItemPanel"
			Me.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemPanel1.ContainerControlProcessDialogKey = True
			Me.itemPanel1.DragDropSupport = True
			Me.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.itemPanel1.Location = New System.Drawing.Point(245, 200)
			Me.itemPanel1.Name = "itemPanel1"
			Me.itemPanel1.ReserveLeftSpace = False
			Me.itemPanel1.Size = New System.Drawing.Size(157, 182)
			Me.itemPanel1.TabIndex = 2
			Me.itemPanel1.Text = "itemPanel1"
'			Me.itemPanel1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.itemPanel1_DragDrop)
'			Me.itemPanel1.DragOver += New System.Windows.Forms.DragEventHandler(Me.itemPanel1_DragOver)
			' 
			' checkBoxX2
			' 
			' 
			' 
			' 
			Me.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.checkBoxX2.Location = New System.Drawing.Point(245, 54)
			Me.checkBoxX2.Name = "checkBoxX2"
			Me.checkBoxX2.Size = New System.Drawing.Size(144, 26)
			Me.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.checkBoxX2.TabIndex = 3
			Me.checkBoxX2.Text = "Search Box Visible"
'			Me.checkBoxX2.CheckedChanged += New System.EventHandler(Me.checkBoxX2_CheckedChanged)
			' 
			' checkBoxX3
			' 
			' 
			' 
			' 
			Me.checkBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.checkBoxX3.Location = New System.Drawing.Point(245, 86)
			Me.checkBoxX3.Name = "checkBoxX3"
			Me.checkBoxX3.Size = New System.Drawing.Size(144, 26)
			Me.checkBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.checkBoxX3.TabIndex = 4
			Me.checkBoxX3.Text = "Enable Item Rearrange"
'			Me.checkBoxX3.CheckedChanged += New System.EventHandler(Me.checkBoxX3_CheckedChanged)
			' 
			' checkBoxX4
			' 
			' 
			' 
			' 
			Me.checkBoxX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.checkBoxX4.Location = New System.Drawing.Point(245, 118)
			Me.checkBoxX4.Name = "checkBoxX4"
			Me.checkBoxX4.Size = New System.Drawing.Size(144, 26)
			Me.checkBoxX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.checkBoxX4.TabIndex = 5
			Me.checkBoxX4.Text = "Enable Drag && Drop"
'			Me.checkBoxX4.CheckedChanged += New System.EventHandler(Me.checkBoxX4_CheckedChanged)
			' 
			' labelX1
			' 
			' 
			' 
			' 
			Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX1.Location = New System.Drawing.Point(245, 180)
			Me.labelX1.Name = "labelX1"
			Me.labelX1.Size = New System.Drawing.Size(101, 14)
			Me.labelX1.TabIndex = 6
			Me.labelX1.Text = "Drop Target:"
			' 
			' checkBoxX5
			' 
			' 
			' 
			' 
			Me.checkBoxX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.checkBoxX5.Location = New System.Drawing.Point(245, 148)
			Me.checkBoxX5.Name = "checkBoxX5"
			Me.checkBoxX5.Size = New System.Drawing.Size(144, 26)
			Me.checkBoxX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.checkBoxX5.TabIndex = 7
			Me.checkBoxX5.Text = "Only expand single group"
'			Me.checkBoxX5.CheckedChanged += New System.EventHandler(Me.checkBoxX5_CheckedChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(417, 388)
			Me.Controls.Add(Me.checkBoxX5)
			Me.Controls.Add(Me.labelX1)
			Me.Controls.Add(Me.checkBoxX4)
			Me.Controls.Add(Me.checkBoxX3)
			Me.Controls.Add(Me.checkBoxX2)
			Me.Controls.Add(Me.itemPanel1)
			Me.Controls.Add(Me.checkBoxX1)
			Me.Controls.Add(Me.toolboxControl1)
			Me.DoubleBuffered = True
			Me.EnableGlass = False
			Me.HelpButton = True
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
			Me.Text = "Form1"
'			Me.HelpButtonClicked += New System.ComponentModel.CancelEventHandler(Me.Form1_HelpButtonClicked)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private toolboxControl1 As DevComponents.DotNetBar.Controls.ToolboxControl
		Private toolboxGroup1 As DevComponents.DotNetBar.Controls.ToolboxGroup
		Private toolboxItem1 As DevComponents.DotNetBar.Controls.ToolboxItem
		Private toolboxItem4 As DevComponents.DotNetBar.Controls.ToolboxItem
		Private toolboxItem5 As DevComponents.DotNetBar.Controls.ToolboxItem
		Private toolboxGroup2 As DevComponents.DotNetBar.Controls.ToolboxGroup
		Private toolboxItem2 As DevComponents.DotNetBar.Controls.ToolboxItem
		Private toolboxItem3 As DevComponents.DotNetBar.Controls.ToolboxItem
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private WithEvents checkBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents itemPanel1 As DevComponents.DotNetBar.ItemPanel
		Private WithEvents checkBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents checkBoxX3 As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents checkBoxX4 As DevComponents.DotNetBar.Controls.CheckBoxX
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private toolboxItem6 As DevComponents.DotNetBar.Controls.ToolboxItem
		Private toolboxGroup3 As DevComponents.DotNetBar.Controls.ToolboxGroup
		Private toolboxItem7 As DevComponents.DotNetBar.Controls.ToolboxItem
		Private toolboxItem8 As DevComponents.DotNetBar.Controls.ToolboxItem
		Private WithEvents checkBoxX5 As DevComponents.DotNetBar.Controls.CheckBoxX
	End Class
End Namespace

