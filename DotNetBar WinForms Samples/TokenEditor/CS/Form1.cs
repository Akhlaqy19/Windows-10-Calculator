using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Text.RegularExpressions;

namespace TokenEditorDemo
{
    public partial class Form1 : OfficeForm
    {
        public Form1()
        {
            InitializeComponent();

            // Load data into the TokenEditor for stored already recognized email addresses
            tokenEmails.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken("shawnsmith@yahoo.com", "Shawn Smith"));
            tokenEmails.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken("petebarley@gmail.com", "Pete Barley"));
            tokenEmails.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken("tobyhuck@email.com", "Toby Huck"));
            tokenEmails.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken("stevenratcliffe@proliancelimited.com", "Steven Ratcliffe"));
            tokenEmails.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken("dennissmith@gmail.com", "Dennis Smith"));

            // Create one token and select it for keywords TokenEditor
            tokenEditor1.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken("programming"));
            tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[0]);
        }

        Regex _MailRegex = new Regex(@"^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@(?:[a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(?:aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$", RegexOptions.Compiled);
        private void tokenEmails_ValidateToken(object sender, DevComponents.DotNetBar.Controls.ValidateTokenEventArgs ea)
        {
            // Validate email address before allowing it into the SelectedTokens collection
            ea.IsValid = _MailRegex.IsMatch(ea.Token.Value);
        }

        private void tokenEditor1_ValidateToken(object sender, DevComponents.DotNetBar.Controls.ValidateTokenEventArgs ea)
        {
            if (ea.IsNewToken)
            {
                // Remember the keyword created
                tokenEditor1.Tokens.Add(ea.Token);
            }
        }

        private void warningBox1_OptionsClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=1631");
        }
    }
}