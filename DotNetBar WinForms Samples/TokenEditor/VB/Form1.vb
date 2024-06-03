Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar
Imports System.Text.RegularExpressions

Namespace TokenEditorDemo
	Partial Public Class Form1
		Inherits OfficeForm

		Public Sub New()
			InitializeComponent()

			' Load data into the TokenEditor for stored already recognized email addresses
			tokenEmails.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken("shawnsmith@yahoo.com", "Shawn Smith"))
			tokenEmails.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken("petebarley@gmail.com", "Pete Barley"))
			tokenEmails.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken("tobyhuck@email.com", "Toby Huck"))
			tokenEmails.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken("stevenratcliffe@proliancelimited.com", "Steven Ratcliffe"))
			tokenEmails.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken("dennissmith@gmail.com", "Dennis Smith"))

			' Create one token and select it for keywords TokenEditor
			tokenEditor1.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken("programming"))
			tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens(0))
		End Sub

		Private _MailRegex As New Regex("^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@(?:[a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(?:aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$", RegexOptions.Compiled)
		Private Sub tokenEmails_ValidateToken(ByVal sender As Object, ByVal ea As DevComponents.DotNetBar.Controls.ValidateTokenEventArgs) Handles tokenEmails.ValidateToken
			' Validate email address before allowing it into the SelectedTokens collection
			ea.IsValid = _MailRegex.IsMatch(ea.Token.Value)
		End Sub

		Private Sub tokenEditor1_ValidateToken(ByVal sender As Object, ByVal ea As DevComponents.DotNetBar.Controls.ValidateTokenEventArgs) Handles tokenEditor1.ValidateToken
			If ea.IsNewToken Then
				' Remember the keyword created
				tokenEditor1.Tokens.Add(ea.Token)
			End If
		End Sub

		Private Sub warningBox1_OptionsClick(ByVal sender As Object, ByVal e As EventArgs) Handles warningBox1.OptionsClick
			System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=1631")
		End Sub
	End Class
End Namespace