using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualStudio2012Style
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private LightThemeForm _LightThemeForm = null;
        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            if (_DarkThemeForm != null)
                _DarkThemeForm.Close();

            if (_LightThemeForm == null)
            {
                LightThemeForm form = new LightThemeForm();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                form.FormClosed += new FormClosedEventHandler(LightThemeFormClosed);
                _LightThemeForm = form;
            }
            else
                _LightThemeForm.Activate();
        }
        void LightThemeFormClosed(object sender, FormClosedEventArgs e)
        {
            _LightThemeForm.Dispose();
            _LightThemeForm = null;
        }

        private DarkThemeForm _DarkThemeForm = null;
        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            if (_LightThemeForm != null)
                _LightThemeForm.Close();

            if (_DarkThemeForm == null)
            {
                DarkThemeForm form = new DarkThemeForm();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                form.FormClosed += new FormClosedEventHandler(DarkThemeFormClosed);
                _DarkThemeForm = form;
            }
            else
                _DarkThemeForm.Activate();
        }
        void DarkThemeFormClosed(object sender, FormClosedEventArgs e)
        {
            _DarkThemeForm.Dispose();
            _DarkThemeForm = null;
        }
    }
}