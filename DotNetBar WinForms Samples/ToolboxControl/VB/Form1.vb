Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Namespace ToolboxControlSample
	Partial Public Class Form1
		Inherits OfficeForm

		Public Sub New()
			InitializeComponent()

			checkBoxX1.Checked = toolboxControl1.TitleVisible
			checkBoxX2.Checked = toolboxControl1.SearchBoxVisible
			checkBoxX3.Checked = toolboxControl1.ItemRearrangeEnabled
			checkBoxX4.Checked = toolboxControl1.ItemDragDropEnabled
			checkBoxX5.Checked = toolboxControl1.ExpandSingleGroupOnly
		End Sub

		Private Sub checkBoxX1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxX1.CheckedChanged
			toolboxControl1.TitleVisible = checkBoxX1.Checked
		End Sub

		Private Sub checkBoxX2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxX2.CheckedChanged
			toolboxControl1.SearchBoxVisible = checkBoxX2.Checked
		End Sub

		Private Sub checkBoxX3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxX3.CheckedChanged
			toolboxControl1.ItemRearrangeEnabled = checkBoxX3.Checked
		End Sub

		Private Sub checkBoxX4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxX4.CheckedChanged
			toolboxControl1.ItemDragDropEnabled = checkBoxX4.Checked
		End Sub

		Private Sub checkBoxX5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxX5.CheckedChanged
			toolboxControl1.ExpandSingleGroupOnly = checkBoxX5.Checked
		End Sub

		Private Sub itemPanel1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles itemPanel1.DragDrop
			Dim item As DevComponents.DotNetBar.Controls.ToolboxItem = CType(e.Data.GetData(GetType(DevComponents.DotNetBar.Controls.ToolboxItem)), DevComponents.DotNetBar.Controls.ToolboxItem)
			Dim copy As DevComponents.DotNetBar.Controls.ToolboxItem = CType(item.Copy(), DevComponents.DotNetBar.Controls.ToolboxItem)
			itemPanel1.Items.Add(copy)
			itemPanel1.RecalcLayout()
		End Sub

		Private Sub itemPanel1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles itemPanel1.DragOver
			If e.Data.GetDataPresent(GetType(DevComponents.DotNetBar.Controls.ToolboxItem)) Then
				e.Effect = DragDropEffects.Copy
			Else
				e.Effect = DragDropEffects.None
			End If
		End Sub

		Private Sub Form1_HelpButtonClicked(ByVal sender As Object, ByVal e As CancelEventArgs) Handles MyBase.HelpButtonClicked
			System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=1926")
		End Sub
	End Class
End Namespace
