using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_project
{
    public partial class Timer : Form
    {
        public static Color color1;
        public static Font font1;
        public Timer(Color color, string style)
        {
            InitializeComponent();

            this.BackColor = color1;

            if (font1 != null)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button || c is Label || c is Panel)
                    {
                        c.Font = font1;
                    }
                }
            }
            else
            {
                this.Font = Timer.DefaultFont;
            }

            panel1.Visible = false;
            panel2.Visible = false;

            if (color1 == Color.Black)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.WhiteSmoke;

                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        c.BackColor = Color.DimGray;
                    }
                    c.ForeColor = Color.White;
                }
            }
            else if (color1 == Color.White)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        c.BackColor = Color.WhiteSmoke;
                        if (c == BtnBackSpace || c == BtnClear)
                        {
                            c.BackColor = Color.Gainsboro;
                        }
                    }
                    c.ForeColor = Color.Black;
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

            form2 = style;

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

        int x;
        decimal convert = 0, display = 0;
        bool enter_value = false;
        string form2;
        Color color2;

        void calcTime()
        {
            if (LblUnit1.Text == LblUnit2.Text && x == 1)
            {
                LblDisplay2.Text = LblDisplay1.Text;
            }
            else if (LblUnit1.Text == LblUnit2.Text && x == 2)
            {
                LblDisplay1.Text = LblDisplay2.Text;
            }
            else
            {
                if (x == 1)
                {

                    switch (LblUnit2.Text)
                    {
                        case "Microseconds ˅":

                            if (LblUnit1.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 1000;
                            }
                            else if (LblUnit1.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 1000000;
                            }
                            else if (LblUnit1.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 60000000;
                            }
                            else if (LblUnit1.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 3600000000;
                            }
                            else if (LblUnit1.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 86400000000;
                            }
                            else if (LblUnit1.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 604800000000;
                            }
                            else if (LblUnit1.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 31557600000000;
                            }
                            break;

                        case "Milliseconds ˅":

                            if (LblUnit1.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 1000;
                            }
                            else if (LblUnit1.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 1000;
                            }
                            else if (LblUnit1.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 60000;
                            }
                            else if (LblUnit1.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 3600000;
                            }
                            else if (LblUnit1.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 86400000;
                            }
                            else if (LblUnit1.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 604800000;
                            }
                            else if (LblUnit1.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 31557600000;
                            }

                            break;


                        case "Seconds ˅":

                            if (LblUnit1.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 1000000;
                            }
                            else if (LblUnit1.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 1000;
                            }
                            else if (LblUnit1.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 60;
                            }
                            else if (LblUnit1.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 3600;
                            }
                            else if (LblUnit1.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 86400;
                            }
                            else if (LblUnit1.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 604800;
                            }
                            else if (LblUnit1.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 31557600;
                            }

                            break;

                        case "Minutes ˅":

                            if (LblUnit1.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 60000000;
                            }
                            else if (LblUnit1.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 60000;
                            }
                            else if (LblUnit1.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 60;
                            }
                            else if (LblUnit1.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 60;
                            }
                            else if (LblUnit1.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 1440;
                            }
                            else if (LblUnit1.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 10080;
                            }
                            else if (LblUnit1.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 525960;
                            }

                            break;

                        case "Hours ˅":

                            if (LblUnit1.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 3600000000;
                            }
                            else if (LblUnit1.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 3600000;
                            }
                            else if (LblUnit1.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 3600;
                            }
                            else if (LblUnit1.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 60;
                            }
                            else if (LblUnit1.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 24;
                            }
                            else if (LblUnit1.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 168;
                            }
                            else if (LblUnit1.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 8766;
                            }

                            break;

                        case "Days ˅":

                            if (LblUnit1.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 86400000000;
                            }
                            else if (LblUnit1.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 86400000;
                            }
                            else if (LblUnit1.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 86400;
                            }
                            else if (LblUnit1.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 1440;
                            }
                            else if (LblUnit1.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 24;
                            }
                            else if (LblUnit1.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * 7;
                            }
                            else if (LblUnit1.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * Convert.ToDecimal(365.25);
                            }

                            break;

                        case "Weeks ˅":

                            if (LblUnit1.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 604800000000;
                            }
                            else if (LblUnit1.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 604800000;
                            }
                            else if (LblUnit1.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 604800;
                            }
                            else if (LblUnit1.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 10080;
                            }
                            else if (LblUnit1.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 168;
                            }
                            else if (LblUnit1.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 7;
                            }
                            else if (LblUnit1.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * Convert.ToDecimal(52.17857);
                            }

                            break;

                        case "Years ˅":

                            if (LblUnit1.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 31557600000000;
                            }
                            else if (LblUnit1.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 31557600000;
                            }
                            else if (LblUnit1.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 31557600;
                            }
                            else if (LblUnit1.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 525960;
                            }
                            else if (LblUnit1.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / 8766;
                            }
                            else if (LblUnit1.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / Convert.ToDecimal(365.25);
                            }
                            else if (LblUnit1.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display / Convert.ToDecimal(52.17857);
                            }

                            break;
                    }
                    LblDisplay2.Text = convert.ToString();
                }
                else if (x == 2)
                {
                    switch (LblUnit1.Text)
                    {
                        case "Microseconds ˅":

                            if (LblUnit2.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 1000;
                            }
                            else if (LblUnit2.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 1000000;
                            }
                            else if (LblUnit2.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 60000000;
                            }
                            else if (LblUnit2.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 3600000000;
                            }
                            else if (LblUnit2.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 86400000000;
                            }
                            else if (LblUnit2.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 604800000000;
                            }
                            else if (LblUnit2.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 31557600000000;
                            }
                            break;

                        case "Milliseconds ˅":

                            if (LblUnit2.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 1000;
                            }
                            else if (LblUnit2.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 1000;
                            }
                            else if (LblUnit2.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 60000;
                            }
                            else if (LblUnit2.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 3600000;
                            }
                            else if (LblUnit2.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 86400000;
                            }
                            else if (LblUnit2.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 604800000;
                            }
                            else if (LblUnit2.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 31557600000;
                            }

                            break;


                        case "Seconds ˅":

                            if (LblUnit2.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 1000000;
                            }
                            else if (LblUnit2.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 1000;
                            }
                            else if (LblUnit2.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 60;
                            }
                            else if (LblUnit2.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 3600;
                            }
                            else if (LblUnit2.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 86400;
                            }
                            else if (LblUnit2.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 604800;
                            }
                            else if (LblUnit2.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 31557600;
                            }

                            break;

                        case "Minutes ˅":

                            if (LblUnit2.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 60000000;
                            }
                            else if (LblUnit2.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 60000;
                            }
                            else if (LblUnit2.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 60;
                            }
                            else if (LblUnit2.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 60;
                            }
                            else if (LblUnit2.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 1440;
                            }
                            else if (LblUnit2.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 10080;
                            }
                            else if (LblUnit2.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 525960;
                            }

                            break;

                        case "Hours ˅":

                            if (LblUnit2.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 3600000000;
                            }
                            else if (LblUnit2.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 3600000;
                            }
                            else if (LblUnit2.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 3600;
                            }
                            else if (LblUnit2.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 60;
                            }
                            else if (LblUnit2.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 24;
                            }
                            else if (LblUnit2.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 168;
                            }
                            else if (LblUnit2.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 8766;
                            }

                            break;

                        case "Days ˅":

                            if (LblUnit2.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 86400000000;
                            }
                            else if (LblUnit2.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 86400000;
                            }
                            else if (LblUnit2.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 86400;
                            }
                            else if (LblUnit2.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 1440;
                            }
                            else if (LblUnit2.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 24;
                            }
                            else if (LblUnit2.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * 7;
                            }
                            else if (LblUnit2.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * Convert.ToDecimal(365.25);
                            }

                            break;

                        case "Weeks ˅":

                            if (LblUnit2.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 604800000000;
                            }
                            else if (LblUnit2.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 604800000;
                            }
                            else if (LblUnit2.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 604800;
                            }
                            else if (LblUnit2.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 10080;
                            }
                            else if (LblUnit2.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 168;
                            }
                            else if (LblUnit2.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 7;
                            }
                            else if (LblUnit2.Text == "Years ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * Convert.ToDecimal(52.17857);
                            }

                            break;

                        case "Years ˅":

                            if (LblUnit2.Text == "Microseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 31557600000000;
                            }
                            else if (LblUnit2.Text == "Milliseconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 31557600000;
                            }
                            else if (LblUnit2.Text == "Seconds ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 31557600;
                            }
                            else if (LblUnit2.Text == "Minutes ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 525960;
                            }
                            else if (LblUnit2.Text == "Hours ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / 8766;
                            }
                            else if (LblUnit2.Text == "Days ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / Convert.ToDecimal(365.25);
                            }
                            else if (LblUnit2.Text == "Weeks ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display / Convert.ToDecimal(52.17857);
                            }

                            break;
                    }
                    LblDisplay1.Text = convert.ToString();
                }
            
            }
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panel3.Location == new Point(-300, 43))
            {
                panel3.Location = new Point(0, 43);
            }
            else
            {
                panel3.Location = new Point(-300, 43);
            }
        }

        private void LblDisplay1_Click(object sender, EventArgs e)
        {
            x = 1;
            LblDisplay1.Font = new Font(LblDisplay1.Font, FontStyle.Bold);
            LblDisplay2.Font = new Font(LblDisplay1.Font, FontStyle.Regular);
            enter_value = true;
        }

        private void LblDisplay2_Click(object sender, EventArgs e)
        {
            x = 2;
            LblDisplay2.Font = new Font(LblDisplay1.Font, FontStyle.Bold);
            LblDisplay1.Font = new Font(LblDisplay1.Font, FontStyle.Regular);
            enter_value = true;
        }

        private void LblUnit1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void LblUnit2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c.Tag == "color" && this.BackColor == Color.Black)
                {
                    c.ForeColor = Color.White;
                }
            }

            calcTime();
            if (LblUnit1.Text == LblUnit2.Text && x == 1)
            {
                LblDisplay2.Text = LblDisplay1.Text;
            }
            if (LblUnit1.Text == LblUnit2.Text && x == 2)
            {
                LblDisplay1.Text = LblDisplay2.Text;
            }
        }

        private void BtnUnits1_Click(object sender, EventArgs e)
        {
            Button btnUnit1 = (Button)sender;
            LblUnit1.Text = btnUnit1.Text + " ˅";
            panel1.Visible = false;

        }

        private void BtnUnits2_Click(object sender, EventArgs e)
        {
            Button btnUnit2 = (Button)sender;
            LblUnit2.Text = btnUnit2.Text + " ˅";
            panel2.Visible = false;
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            Button btnNum = (Button)sender;

            if (x == 1)
            {
                if (enter_value || LblDisplay1.Text == "0")
                {
                    LblDisplay1.Text = "";
                    enter_value = false;
                }
            }
            else if (x == 2)
            {
                if (enter_value || LblDisplay2.Text == "0")
                {
                    LblDisplay2.Text = "";
                    enter_value = false;
                }
            }

            if (x == 1)
            {
                if (btnNum.Text == ".")
                {
                    if (!LblDisplay1.Text.Contains("."))
                    {
                        LblDisplay1.Text += btnNum.Text;
                    }
                }
                else
                {
                    LblDisplay1.Text += btnNum.Text;
                }
            }
            else if (x == 2)
            {
                if (btnNum.Text == ".")
                {
                    if (!LblDisplay2.Text.Contains("."))
                    {
                        LblDisplay2.Text += btnNum.Text;
                    }
                }
                else
                {
                    LblDisplay2.Text += btnNum.Text;
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LblDisplay1.Text = "0";
            LblDisplay2.Text = "0";
            enter_value = true;
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                LblDisplay1.Text = LblDisplay1.Text.Remove(LblDisplay1.Text.Length - 1);

                if (LblDisplay1.Text == "")
                {
                    LblDisplay1.Text = "0";
                }
            }
            else if (x == 2)
            {
                LblDisplay2.Text = LblDisplay2.Text.Remove(LblDisplay2.Text.Length - 1);

                if (LblDisplay2.Text == "")
                {
                    LblDisplay2.Text = "0";
                }
            }
            calcTime();
        }

        private void BtnStandard1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Standard form = new Standard(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void BtnProgrammer1_Click(object sender, EventArgs e)
        {
            this.Hide();
            programmer form = new programmer(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.Hide();
            Currency form = new Currency(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volume form = new Volume(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weight form = new Weight(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temperature form = new Temperature(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speed form = new Speed(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer form = new Timer(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Hide();
            setting form = new setting(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Length form = new Length(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void AllControls_(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.ForeColor = Color.Black;

                foreach (Control c in this.Controls)
                {
                    if (c is Button || c is Panel)
                    {
                        c.BackColor = Color.WhiteSmoke;
                        if (c == BtnBackSpace || c == BtnClear)
                        {
                            c.BackColor = Color.Gainsboro;
                        }
                    }
                    c.ForeColor = Color.Black;
                }
            }
            else if (this.BackColor == ColorTranslator.FromHtml("#202028"))
            {
                this.ForeColor = Color.WhiteSmoke;

                foreach (Control c in this.Controls)
                {
                    if (c is Button || c is Panel)
                    {
                        c.BackColor = ColorTranslator.FromHtml("#464650");
                    }
                    BtnBackSpace.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnClear.BackColor = ColorTranslator.FromHtml("#32323C");
                    c.ForeColor = Color.White;
                }
            }
        }


        private void Timer_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                Btn1.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                Btn2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                Btn3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                Btn4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                Btn5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                Btn6.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                Btn7.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                Btn8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                Btn9.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                BtnBackSpace.PerformClick();
            }
        }


    }
}
