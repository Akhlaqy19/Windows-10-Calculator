Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar

Namespace Toast
	Partial Public Class Form1
		Inherits MetroForm

		Public Sub New()
			InitializeComponent()

			toastPosition.DataSource = System.Enum.GetValues(GetType(eToastPosition))
			toastPosition.SelectedIndex = 7
			toastGlow.DataSource = System.Enum.GetValues(GetType(eToastGlowColor))
			toastGlow.SelectedIndex = 2
			customGlowColor.SelectedColor = ToastNotification.CustomGlowColor
		End Sub

        Private Sub buttonX1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonX1.Click
            ' You can also use other static properties on ToastNotification to customize toast appearance, like:
            ' ToastNotification.DefaultToastGlowColor - to change the default toast glow color
            ' ToastNotification.DefaultToastPosition - to change default toast position
            ' ToastNotification.ToastBackColor - to change the toast notification background color which is by default black
            ' ToastNotification.ToastForeColor - to change the toast notification text color which is by default white
            ' ToastNotification.ToastFont - to change the toast notification font
            ' ToastNotification.ToastMargin - to set spacing between edges of the toast and its parent form

            ' Also note that ToastNotification.Show has overload which allows you to specify the explicit toast position using X, Y coordinates

            If CType(toastGlow.SelectedValue, eToastGlowColor) = eToastGlowColor.Custom Then
                ToastNotification.CustomGlowColor = Color.FromArgb(48, customGlowColor.SelectedColor)
            End If

            Dim glow As eToastGlowColor = eToastGlowColor.Blue
            If Not toastGlow Is Nothing Then
                glow = CType(toastGlow.SelectedValue, eToastGlowColor)
            End If
            Dim pos As eToastPosition = eToastPosition.BottomCenter
            If Not toastPosition.SelectedValue Is Nothing Then
                pos = CType(toastPosition.SelectedValue, eToastPosition)
            End If
            ToastNotification.Show(Me, message.Text, IIf(checkBoxX1.Checked, My.Resources.win, Nothing), slider1.Value * 1000, glow, pos)
        End Sub

		Private Sub slider1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles slider1.ValueChanged
			slider1.Text = "Duration, " & slider1.Value.ToString() & " seconds"
		End Sub

		Private Sub toastGlow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toastGlow.SelectedIndexChanged
			If CType(toastGlow.SelectedValue, eToastGlowColor) = eToastGlowColor.Custom Then
				customGlowColor.Visible = True
			Else
				customGlowColor.Visible = False
			End If
		End Sub

	End Class
End Namespace