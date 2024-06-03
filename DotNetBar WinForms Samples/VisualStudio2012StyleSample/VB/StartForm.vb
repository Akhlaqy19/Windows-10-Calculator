Imports System.ComponentModel
Imports System.Text

Namespace VisualStudio2012Style
	Partial Public Class StartForm
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private _LightThemeForm As LightThemeForm = Nothing
		Private Sub metroTileItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles metroTileItem1.Click
			If _DarkThemeForm IsNot Nothing Then
				_DarkThemeForm.Close()
			End If

			If _LightThemeForm Is Nothing Then
				Dim form As New LightThemeForm()
				form.StartPosition = FormStartPosition.CenterScreen
				form.Show()
				AddHandler form.FormClosed, AddressOf LightThemeFormClosed
				_LightThemeForm = form
			Else
				_LightThemeForm.Activate()
			End If
		End Sub
		Private Sub LightThemeFormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			_LightThemeForm.Dispose()
			_LightThemeForm = Nothing
		End Sub

		Private _DarkThemeForm As DarkThemeForm = Nothing
		Private Sub metroTileItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles metroTileItem2.Click
			If _LightThemeForm IsNot Nothing Then
				_LightThemeForm.Close()
			End If

			If _DarkThemeForm Is Nothing Then
				Dim form As New DarkThemeForm()
				form.StartPosition = FormStartPosition.CenterScreen
				form.Show()
				AddHandler form.FormClosed, AddressOf DarkThemeFormClosed
				_DarkThemeForm = form
			Else
				_DarkThemeForm.Activate()
			End If
		End Sub
		Private Sub DarkThemeFormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			_DarkThemeForm.Dispose()
			_DarkThemeForm = Nothing
		End Sub
	End Class
End Namespace