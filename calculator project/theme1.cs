using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Taskbar;

namespace calculator_project
{
    public partial class theme1 : Form
    {
        public theme1()
        {
            InitializeComponent();
        }
        Color color;
        string form;
        ColorDialog colorDialog = new ColorDialog();

        private void radioButton1_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            form = "None";
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            form = "FixedSingle";
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            form = "Fixed3D";
        }
        private void radioButton7_Click(object sender, EventArgs e)
        {
            form = "FixedDialog";
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            form = "Sizable";
        }
        private void radioButton10_Click(object sender, EventArgs e)
        {
            form = "FixedToolWindow";
        }
        private void button7_Click(object sender, EventArgs e)
        {   
            this.Hide();

            new Standard(color, form).Show();
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                button8.BackColor = colorDialog.Color;

                if (colorDialog.Color != Color.Empty)
                {
                    button8.BackColor = colorDialog.Color;
                    color = button8.BackColor;
                }
            }
        }

        private void BtnDark_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#202028");
            this.ForeColor = Color.White;

            foreach (Control c in this.Controls)
            {
                c.ForeColor = Color.White;
                if (c is System.Windows.Forms.Label)
                {
                    c.BackColor = Color.Black;

                }
                if(c is System.Windows.Forms.Button && c != button1 && c != button2 && c != button3)
                {
                    c.BackColor = ColorTranslator.FromHtml("#32323C");
                }
            }
        }

        private void BtnLight_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Label)
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                }
                if(c is System.Windows.Forms.Button)
                {
                    if (c == button1)
                    {
                        c.BackColor = Color.Red;
                    }
                    else if (c == button2)
                    {
                        c.BackColor = Color.Green;
                    }
                    else if (c == button3)
                    {
                        c.BackColor = Color.Blue;
                    }
                    else
                    {
                        c.BackColor = Color.WhiteSmoke;
                        c.ForeColor = Color.Black;
                    }
                }
            }

        }
    }
}
