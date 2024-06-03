using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace calculator_project
{
    public partial class setting : Form
    {
        public static Color color1;
        public static Font font1;
        public static Color color;
        public static Font font;
   
        ColorDialog colorDialog = new ColorDialog();

        public setting(Color color, string style)
        {
            InitializeComponent();

            this.BackColor = color1;

            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Button || c is System.Windows.Forms.Label || c is System.Windows.Forms.Panel)
                {
                    c.Font = font1;
                }
            }
            if(this.BackColor == Color.Black)
            {
                BackgroundButton.BackColor = Color.Black;
                BackgroundButton.ForeColor = Color.White;

                foreach (Control c in this.Controls)
                {
                    if (c is System.Windows.Forms.Label && c != LblBack)
                    {
                        c.BackColor = Color.Black;
                        c.ForeColor = Color.White;
                    }                 
                }
            }
            else if(this.BackColor == Color.White)
            {
                BackgroundButton.BackColor = Color.White;
                BackgroundButton.ForeColor = Color.Black;

                foreach (Control c in this.Controls)
                {
                    if (c is System.Windows.Forms.Label && c != LblBack)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }
                }
            }

            if (color != null)
            {
                color2 = color;
                foreach (Control c in this.Controls)
                {
                    c.BackColor = color;
                }
            }
            style1 = style;

            if (style == "None")
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else if (style == "Fixed3D")
            {
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }
            else if (style == "FixedDialog")
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            else if (style == "FixedSingle")
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else if (style == "Sizable")
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else if (style == "FixedToolWindow")
            {
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }

        }

        int x = 0;
        Color color2;
        string style1;
        FontDialog fontDialog = new FontDialog();

        private void LblChangeTheme_Click(object sender, EventArgs e)
        {
            if(PnlSetting.Visible == false)
            {
               PnlSetting.Visible = true;
            }
            else
            {
                PnlSetting.Visible = false;
            }
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundButton.BackColor = colorDialog.Color;

                if (colorDialog.Color != Color.Empty)
                {
                this.BackColor = colorDialog.Color;
                }
                if(colorDialog.Color == Color.Black)
                {
                    this.BackColor = colorDialog.Color;
                    BackgroundButton.ForeColor = Color.White;

                    foreach(Control c in this.Controls)
                    {
                        if(c is System.Windows.Forms.Label && c != LblBack ) 
                        {
                            c.BackColor = Color.Black;
                            c.ForeColor = Color.White;
                        }
                        BackgroundButton.ForeColor = Color.White;
                    }
                }
            }
        }

        private void LblBack_Click(object sender, EventArgs e)
        {
            font = BtnFont.Font;
            color = BackgroundButton.BackColor;

            this.Hide();

            Standard form = new Standard(color2, style1);
            form.Font = font;
            form.BackColor = color;
            form.ShowDialog();

            programmer form1 = new programmer(color2, style1);
            form1.Font = font;
            form1.BackColor = color;

            Currency form2 = new Currency(color2, style1);
            form2.Font = font;
            form2.BackColor = color;

            Length form3 = new Length(color2, style1);
            form3.Font = font;
            form3.BackColor = color;

            Speed form4 = new Speed(color2, style1);
            form4.Font = font;
            form4.BackColor = color;

            Temperature form5 = new Temperature(color2, style1);
            form5.Font = font;
            form5.BackColor = color;

            Timer form6 = new Timer(color2, style1);
            form6.Font = font;
            form6.BackColor = color;

            Volume form7 = new Volume(color2, style1);
            form7.Font = font;
            form7.BackColor = color;

            Weight form8 = new Weight(color2, style1);
            form8.Font = font;
            form8.BackColor = color;
        }

        private void BtnDark_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;

            BackgroundButton.BackColor = ColorTranslator.FromHtml("#202028");
            BackgroundButton.ForeColor = Color.White;

            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Label && c != LblBack)
                {
                    c.BackColor = Color.Black;
                    c.ForeColor = Color.White;
                }
            }
        }

        private void BtnLight_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            BackgroundButton.BackColor = Color.White;
            BackgroundButton.ForeColor = Color.Black;

            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Label && c != LblBack)
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                }
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {

            BtnFont.Font = fontDialog.Font;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                BtnFont.Font = fontDialog.Font;
                this.Font = fontDialog.Font;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            font = BtnFont.Font;
            color = BackgroundButton.BackColor;

            this.Hide();

            Standard form = new Standard(color2, style1);
            form.Font = font;
            form.BackColor = color;
            form.ShowDialog();

            programmer form1 = new programmer(color2, style1);
            form1.Font = font;
            form1.BackColor = color;

            Currency form2 = new Currency(color2, style1);
            form2.Font = font;
            form2.BackColor = color;

            Length form3 = new Length(color2, style1);
            form3.Font = font;
            form3.BackColor = color;

            Speed form4 = new Speed(color2, style1);
            form4.Font = font;
            form4.BackColor = color;

            Temperature form5 = new Temperature(color2, style1);
            form5.Font = font;
            form5.BackColor = color;

            Timer form6 = new Timer(color2, style1);
            form6.Font = font;
            form6.BackColor = color;

            Volume form7 = new Volume(color2, style1);
            form7.Font = font;
            form7.BackColor = color;

            Weight form8 = new Weight(color2, style1);
            form8.Font = font;
            form8.BackColor = color;

        }

        private void AllMouse_(object sender, EventArgs e)
        {
             if(this.BackColor == Color.White)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                foreach (Control c in this.Controls)
                {

                    if (c is System.Windows.Forms.Button || c is System.Windows.Forms.Panel)
                    {
                        c.BackColor = Color.WhiteSmoke;

                    }
                    c.ForeColor = Color.Black;
                }
             }
            else if(this.BackColor == Color.Black)
            {
                this.BackColor = ColorTranslator.FromHtml("#202020");
                this.ForeColor = Color.WhiteSmoke;

                foreach (Control c in this.Controls)
                {

                    if (c is System.Windows.Forms.Label && c != label1 && c != label2 && c != LblBack || c is System.Windows.Forms.Panel)
                    {
                        c.BackColor = ColorTranslator.FromHtml("#32323C");
                    }
                    if (c == label1 && c == label2 && c == LblBack)
                    {
                        c.BackColor = Color.Transparent;
                    }
                    if (c is System.Windows.Forms.Button)
                    {
                        c.BackColor = Color.DimGray;
                    }
                    c.ForeColor = Color.White;
                }

            }
        }

        private void PnlSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setting_Load(object sender, EventArgs e)
        {

        }
    }
}
