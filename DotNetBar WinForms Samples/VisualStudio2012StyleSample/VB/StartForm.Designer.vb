Namespace VisualStudio2012Style
	Partial Public Class StartForm
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
        Me.itemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.metroTileItem1 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.metroTileItem2 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.SuspendLayout
        '
        'itemPanel1
        '
        Me.itemPanel1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.itemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.itemPanel1.ContainerControlProcessDialogKey = true
        Me.itemPanel1.DragDropSupport = true
        Me.itemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.metroTileItem1, Me.metroTileItem2})
        Me.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itemPanel1.Location = New System.Drawing.Point(47, 39)
        Me.itemPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.itemPanel1.Name = "itemPanel1"
        Me.itemPanel1.Size = New System.Drawing.Size(233, 206)
        Me.itemPanel1.TabIndex = 0
        Me.itemPanel1.Text = "itemPanel1"
        '
        'metroTileItem1
        '
        Me.metroTileItem1.Image = Global.My.Resources.Resources.LightTheme
        Me.metroTileItem1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.metroTileItem1.Name = "metroTileItem1"
        Me.metroTileItem1.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem1.Text = "Start Light Theme Sample"
        Me.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.metroTileItem1.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(222,Byte),Integer), CType(CType(222,Byte),Integer))
        Me.metroTileItem1.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(222,Byte),Integer), CType(CType(222,Byte),Integer), CType(CType(222,Byte),Integer))
        Me.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.metroTileItem1.TileStyle.TextColor = System.Drawing.Color.Black
        '
        'metroTileItem2
        '
        Me.metroTileItem2.Image = Global.My.Resources.Resources.DarkTheme
        Me.metroTileItem2.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.metroTileItem2.Name = "metroTileItem2"
        Me.metroTileItem2.SymbolColor = System.Drawing.Color.Empty
        Me.metroTileItem2.Text = "Start Dark Theme Sample"
        Me.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.metroTileItem2.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.metroTileItem2.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(45,Byte),Integer), CType(CType(45,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(325, 262)
        Me.Controls.Add(Me.itemPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Studio 2012 Styling Sample"
        Me.ResumeLayout(false)

End Sub

		#End Region

		Private itemPanel1 As DevComponents.DotNetBar.ItemPanel
		Private WithEvents metroTileItem1 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private WithEvents metroTileItem2 As DevComponents.DotNetBar.Metro.MetroTileItem
	End Class
End Namespace

