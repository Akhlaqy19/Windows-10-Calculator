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
    public partial class Volume : Form
    {
        public static Color color1;
        public static Font font1;
        public Volume(Color color, string style)
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
                this.Font = Standard.DefaultFont;
            }

            panel1.Visible = false;
            panel3.Visible = false;

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
            CalcVolume();
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
            panel3.Visible = true;
        }

        private void BtnUnit1_Click(object sender, EventArgs e)
        {

            Button btnUnit1 = (Button)sender;
            LblUnit1.Text = btnUnit1.Text + " ˅";
            panel1.Visible = false;
        }

        private void BtnUnits2_Click(object sender, EventArgs e)
        {
            Button btnUnit2 = (Button)sender;

            LblUnit2.Text = btnUnit2.Text + " ˅";
            panel3.Visible = false;

        }

        private void Volume_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
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

        private void Volume_KeyDown(object sender, KeyEventArgs e)
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

        private void timer_Tick(object sender, EventArgs e)
        {

            CalcVolume();

            if (LblUnit1.Text == LblUnit2.Text && x == 1)
            {
                LblDisplay2.Text = LblDisplay1.Text;
            }
            if (LblUnit1.Text == LblUnit2.Text && x == 2)
            {
                LblDisplay1.Text = LblDisplay2.Text;
            }
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

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Currency form = new Currency(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volume form = new Volume(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Hide();
            Length form = new Length(color2, form2);
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

        private void BtnMenu_Click(object sender, EventArgs e)
        {

            if (panel2.Location == new Point(-300, 43))
            {
                panel2.Location = new Point(0, 43);
            }
            else
            {
                panel2.Location = new Point(-300, 43);
            }
        }

        private void AllControls(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void CalcVolume()
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
                    display = Convert.ToDecimal(LblDisplay1.Text);

                    switch (LblUnit2.Text)
                    {
                        case "Milliliters ˅":

                            if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display;
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * 1000;
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * 1000000;
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(4.928922);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(14.78676);
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(29.57353);
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(236.5882);
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(473.1765);
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(946.3529);
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(3785.412);
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(16.38706);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {      
                                convert = display * Convert.ToDecimal(28316.85);
                            }

                            break;

                        case "Cubic centimeters ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display;
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * 1000;
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * 1000000;
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(4.928922);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(14.78676);
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(29.57353);
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(236.5882);
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(473.1765);
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(946.3529);
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(3785.412);
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(16.38706);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(28316.85);
                            }

                            break;


                        case "Liters ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display / 1000;
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display / 1000;
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * 1000;
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.004928922);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.01478676);
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.02957353);
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.2365882);
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.4731765);
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.9463529);
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(3.785412);
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.01638706);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(28.31685);
                            }

                            break;

                        case "Cubic meters ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {

                                convert = display / 1000000;
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display / 1000000;
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display / 1000;
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000004928922);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00001478676);
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00002957353);
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.0002365882);
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.0004731765);
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.0009463529);
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.003785412);
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00001638706);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(0.02831685);
                            }

                            break;

                        case "Teaspoons (US) ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.2028841);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.2028841);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {   
                                convert = display * Convert.ToDecimal(202.8841);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(202884.1);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * 3;
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * 6;
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * 48;
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * 96;
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {   
                                convert = display * 192;
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * 768;
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(3.324675);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(5745.039);
                            }

                            break;


                        case "Tablespoons (US) ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.06762805);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.06762805);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(67.62805);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(67628.05);
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display / 3;
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * 2;
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * 16;
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * 32;
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * 64;
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * 256;
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(1.108225);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(1915.013);
                            }

                            break;


                        case "Fluid ounces (US) ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.03381402);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.03381402);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(33.81402);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(33814.02);
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display / 6;
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 2;
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * 8;
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * 16;
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * 32;
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * 128;
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            { 
                                convert = display * Convert.ToDecimal(0.554113);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(957.5065);
                            }

                            break;

                        case "Cups (US) ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.004226753);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.004226753);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(4.226753);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(4226.753);
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display / 48;
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 16;
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display / 8;
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * 2;
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * 4;
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            { 
                                convert = display * 16;
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.069264);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(119.6883);
                            }

                            break;


                        case "Pints (US) ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.002113376);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.002113376);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(2.113376);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(2113.376);
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.010417);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 32;
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display / 16;
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display / 2;
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * 2;
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * 8;
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.034632);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(59.84416);
                            }

                            break;


                        case "Quarts (US) ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.001056688);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.001056688);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(1.056688);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(1056.688);
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.005208);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 64;
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display / 32;
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display / 4;
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display / 2;
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * 4;
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.017316);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(29.92208);
                            }

                            break;

                        case "Gallons (US) ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000264172);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            { 
                                convert = display * Convert.ToDecimal(0.000264172);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.2641721);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(264.1721);
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display / 768;
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 256;
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display / 128;
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display / 16;
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display / 8;
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display / 4;
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.004329);
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(7.480519);
                            }

                            break;

                        case "Cubic inches ˅":

                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.06102374);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.06102374);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(61.02374);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(61023.74);
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.300781);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.902344);
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(1.804688);
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(14.4375);
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(28.875);
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(57.75);
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * 231;
                            }
                            else if (LblUnit1.Text == "Cubic feet ˅")
                            {
                                convert = display * 1728;
                            }

                            break;

                        case "Cubic feet ˅":


                            if (LblUnit1.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00003531467);
                            }
                            else if (LblUnit1.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00003531467);
                            }
                            else if (LblUnit1.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.03531467);
                            }
                            else if (LblUnit1.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(35.31467);
                            }
                            else if (LblUnit1.Text == "Teaspoons (US) ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay1.Text);
                                convert = display * Convert.ToDecimal(0.000174);
                            }
                            else if (LblUnit1.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000522);
                            }
                            else if (LblUnit1.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.001044);
                            }
                            else if (LblUnit1.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.008355);
                            }
                            else if (LblUnit1.Text == "Pints (US) ˅")
                            { 
                                convert = display * Convert.ToDecimal(0.01671);
                            }
                            else if (LblUnit1.Text == "Quarts (US) ˅")
                            {   
                                convert = display * Convert.ToDecimal(0.03342);
                            }
                            else if (LblUnit1.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.133681);
                            }
                            else if (LblUnit1.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000579);
                            }
                            break;

                    }
                    LblDisplay2.Text = convert.ToString();
                }
                else if (x == 2)
                {
                    display = Convert.ToDecimal(LblDisplay2.Text);

                    switch (LblUnit1.Text)
                    {
                        case "Milliliters ˅":

                            if (LblUnit2.Text == "Cubic centimeters ˅")
                            {                    
                                convert = display;
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * 1000;
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * 1000000;
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(4.928922);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(14.78676);
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(29.57353);
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(236.5882);
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(473.1765);
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            { 
                                convert = display * Convert.ToDecimal(946.3529);
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(3785.412);
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(16.38706);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(28316.85);
                            }

                            break;

                        case "Cubic centimeters ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display;
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * 1000;
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * 1000000;
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(4.928922);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(14.78676);
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(29.57353);
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(236.5882);
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(473.1765);
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(946.3529);
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(3785.412);
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(16.38706);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(28316.85);
                            }

                            break;

                        case "Liters ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display / 1000;
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display / 1000;
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * 1000;
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.004928922);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.01478676);
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.02957353);
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.2365882);
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {  
                                convert = display * Convert.ToDecimal(0.4731765);
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.9463529);
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {                          
                                convert = display * Convert.ToDecimal(3.785412);
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                display = Convert.ToDecimal(LblDisplay2.Text);
                                convert = display * Convert.ToDecimal(0.01638706);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(28.31685);
                            }

                            break;

                        case "Cubic meters ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display / 1000000;
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display / 1000000;
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display / 1000;
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000004928922);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00001478676);
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00002957353);
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.0002365882);
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.0004731765);
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.0009463529);
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.003785412);
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00001638706);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(0.02831685);
                            }

                            break;

                        case "Teaspoons (US) ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.2028841);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.2028841);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(202.8841);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(202884.1);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * 3;
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * 6;
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * 48;
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display * 96;
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * 192;
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * 768;
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(3.324675);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(5745.039);
                            }

                            break;


                        case "Tablespoons (US) ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.06762805);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.06762805);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(67.62805);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(67628.05);
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display / 3;
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * 2;
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * 16;
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display * 32;
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * 64;
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * 256;
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(1.108225);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(1915.013);
                            }

                            break;


                        case "Fluid ounces (US) ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            { 
                                convert = display * Convert.ToDecimal(0.03381402);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.03381402);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(33.81402);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(33814.02);
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display / 6;
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 2;
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * 8;
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            { 
                                convert = display * 16;
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * 32;
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * 128;
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.554113);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(957.5065);
                            }

                            break;


                        case "Cups (US) ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.004226753);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.004226753);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(4.226753);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(4226.753);
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display / 48;
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 16;
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display / 8;
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display * 2;
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * 4;
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * 16;
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.069264);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(119.6883);
                            }

                            break;

                        case "Pints (US) ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.002113376);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.002113376);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(2.113376);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(2113.376);
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.010417);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 32;
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display / 16;
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display / 2;
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * 2;
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * 8;
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.034632);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(59.84416);
                            }

                            break;

                        case "Quarts (US) ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.001056688);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.001056688);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(1.056688);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(1056.688);
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.005208);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 64;
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display / 32;
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display / 4;
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display / 2;
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * 4;
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.017316);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(29.92208);
                            }

                            break;

                        case "Gallons (US) ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000264172);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000264172);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.2641721);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(264.1721);
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display / 768;
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display / 256;
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display / 128;
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display / 16;
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display / 8;
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display / 4;
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.004329);
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * Convert.ToDecimal(7.480519);
                            }

                            break;

                        case "Cubic inches ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.06102374);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.06102374);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(61.02374);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(61023.74);
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.300781);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.902344);
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(1.804688);
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(14.4375);
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(28.875);
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(57.75);
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * 231;
                            }
                            else if (LblUnit2.Text == "Cubic feet ˅")
                            {
                                convert = display * 1728;
                            }

                            break;

                        case "Cubic feet ˅":

                            if (LblUnit2.Text == "Milliliters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00003531467);
                            }
                            else if (LblUnit2.Text == "Cubic centimeters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.00003531467);
                            }
                            else if (LblUnit2.Text == "Liters ˅")
                            {
                                convert = display * Convert.ToDecimal(0.03531467);
                            }
                            else if (LblUnit2.Text == "Cubic meters ˅")
                            {
                                convert = display * Convert.ToDecimal(35.31467);
                            }
                            else if (LblUnit2.Text == "Teaspoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000174);
                            }
                            else if (LblUnit2.Text == "Tablespoons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000522);
                            }
                            else if (LblUnit2.Text == "Fluid ounces (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.001044);
                            }
                            else if (LblUnit2.Text == "Cups (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.008355);
                            }
                            else if (LblUnit2.Text == "Pints (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.01671);
                            }
                            else if (LblUnit2.Text == "Quarts (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.03342);
                            }
                            else if (LblUnit2.Text == "Gallons (US) ˅")
                            {
                                convert = display * Convert.ToDecimal(0.133681);
                            }
                            else if (LblUnit2.Text == "Cubic inches ˅")
                            {
                                convert = display * Convert.ToDecimal(0.000579);
                            }
                            break;
                    }
                    LblDisplay1.Text = convert.ToString();
                }
            }
        }
    }
}
