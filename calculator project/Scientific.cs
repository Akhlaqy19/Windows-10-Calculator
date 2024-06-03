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
    public partial class Scientific : Form
    {

        public static Color color1;
        public static Font font1;

        public Scientific(Color color, string style)
        {
            InitializeComponent();

            if (color1 != Color.White && color1 != Color.Black)
            {

                this.BackColor = color1;
            }

            if (font1 != null)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button || c is Label || c is RichTextBox || c is Panel)
                    {
                        c.Font = font1;
                    }
                }

            }
            else
            {
                this.Font = programmer.DefaultFont;
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

        double number1, number2;
        string opt1 = "", opt2 = "";
        bool enter_value = false;
        int count = 0;
        Color color2;
        string form2 = "";

        private void Scientific_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenu_Click_1(object sender, EventArgs e)
        {
            if (panel1.Location == new Point(-300, 43))
            {
                panel1.Location = new Point(0, 43);
                panel1.BringToFront();
            }
            else
            {
                panel1.Location = new Point(-300, 43);
            }
        }

        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
            {
                BtnClear.Text = "CE";
            }


            Button BtnHex = (Button)sender;
            if (display.Text == "0" || enter_value)
            {
                display.Text = "";
                enter_value = false;
            }

            display.Text += BtnHex.Text;
        }

        private void BtnMathDouble(object sender, EventArgs e)
        {
            Button btnOpt = (Button)sender;
            enter_value = true;

            count++;

            if (count == 1)
            {
                number1 = Convert.ToDouble(display.Text);

                lblShowOpt.Text = number1 + btnOpt.Text;
                opt1 = btnOpt.Text;
        //BoxDisplayHistory.AppendText(number1 + opt1);

            }
            else if (count == 2)
            {
                opt2 = btnOpt.Text;
                number2 = Convert.ToDouble(display.Text);

                lblShowOpt.Text += number2 + opt2;

                switch (opt1)
                {
                    case "+":
                        number1 = number1 + number2;

                        break;

                    case "−":
                        number1 = number1 - number2;

                        break;

                    case "×":
                        number1 = number1 * number2;

                        break;

                    case "÷":
                        number1 = number1 / number2;

                        break;

                    case "mod":
                        number1 = number1 % number2;

                        break;
                
            }
                display.Text = number1 + "";

                count++;
                opt1 = opt2;
            }
            else
            {
                opt2 = btnOpt.Text;
                number2 = Convert.ToDouble(display.Text);
                lblShowOpt.Text += number2 + opt2;


                switch (opt1)
                {
                    case "+":
                        number1 = number1 + number2;
                        break;

                    case "−":
                        number1 = number1 - number2;
                        break;

                    case "×":
                        number1 = number1 * number2;
                        break;

                    case "÷":
                        number1 = number1 / number2;
                        break;


                    case "mod":
                        number1 = number1 % number2;

                        break;
                }
                display.Text = number1 + "";

                count++;
                opt1 = opt2;
            }

           

        }

        private void Scientific_KeyDown(object sender, KeyEventArgs e)
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
                BtnBackspace.PerformClick();
            }
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                BtnAdd.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                BtnSub.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                BtnMultyply.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                BtnDivision.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnEquals.PerformClick();
            }
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            display.Text = display.Text.Remove(display.Text.Length - 1);

            if (display.Text == "")
            {
                display.Text = "0";
            }
        }

        private void Btnpi_Click(object sender, EventArgs e)
        {
            display.Text = Math.PI + "";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                display.Text = (Convert.ToDecimal(display.Text) * -1) + "";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            BtnMathDouble(sender, e);
            lblShowOpt.Text = lblShowOpt.Text.Remove(lblShowOpt.Text.Length - 1);
            lblShowOpt.Text += "=";
            display.Text = number1 + "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (display.Text.Equals(double.NaN + ""))
            {
                display.Text = "0";
            }
            else if (display.Text.Equals(double.NegativeInfinity + ""))
            {
                display.Text = "Overflow";
            }
            else if (display.Text.Equals(double.PositiveInfinity + ""))
            {
                display.Text = "Overflow";
            }
        }

        private void AllControls_(object sender, EventArgs e)
        {
            if (this.BackColor == ColorTranslator.FromHtml("#202028"))
            {
                this.ForeColor = Color.White;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Standard form1 = new Standard(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Scientific form1 = new Scientific(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            programmer form1 = new programmer(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Currency form1 = new Currency(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volume form1 = new Volume(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Length form1 = new Length(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weight form1 = new Weight(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temperature form1 = new Temperature(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speed form1 = new Speed(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer form1 = new Timer(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            setting form1 = new setting(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void BtnNamad_Click(object sender, EventArgs e)
        {
            display.Text = Math.Exp(Convert.ToDouble(display.Text)) + "";
        }

        private void BtnSC_Click(object sender, EventArgs e)
        {
            PnlBitWise.Visible = true;
            PnlBitWise.BringToFront();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += "(";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text += ")";
        }

        private void BtnSingleOpt_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(count == 2)
            {
                opt1 = btn.Text;
                switch(opt1)
                {
                    case "√x":

                        lblShowOpt.Text += $"√({display.Text}):";
                        display.Text = Math.Sqrt(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "10^x":
                        lblShowOpt.Text += $"10^({display.Text}):";
                        display.Text = Math.Pow(10, Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "log":
                        lblShowOpt.Text += $"√({display.Text}):";
                        display.Text = Math.Log(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "1/x":
                        lblShowOpt.Text += $"1/({display.Text}):";
                        display.Text = (1 / Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "x^3":
                        lblShowOpt.Text += $"cube({display.Text}):";
                        display.Text = Math.Pow(Convert.ToDouble(display.Text), 3).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "|x|":
                        lblShowOpt.Text += $"abs({display.Text}):";
                        display.Text = Math.Abs(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "sin":
                        lblShowOpt.Text += $"sin({display.Text}):";
                        display.Text = Math.Sin(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "cos":
                        lblShowOpt.Text += $"cos({display.Text}):";
                        display.Text = Math.Cos(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "tan":
                        lblShowOpt.Text += $"tan({display.Text}):";
                        display.Text = Math.Tan(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "cosh":
                        lblShowOpt.Text += $"cosh({display.Text}):";
                        display.Text = Math.Cosh(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                }
            }
            else
            {
                opt2 = btn.Text;

                switch (opt2)
                {
                    case "√x":

                        lblShowOpt.Text += $"√({display.Text}):";
                        display.Text = Math.Sqrt(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "10^x":
                        lblShowOpt.Text += $"10^({display.Text}):";
                        display.Text = Math.Pow(10, Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "log":
                        lblShowOpt.Text += $"√({display.Text}):";
                        display.Text = Math.Log(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "1/x":
                        lblShowOpt.Text += $"1/({display.Text}):";
                        display.Text = (1 / Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "x^3":
                        lblShowOpt.Text += $"cube({display.Text}):";
                        display.Text = Math.Pow(Convert.ToDouble(display.Text), 3).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "|x|":
                        lblShowOpt.Text += $"abs({display.Text}):";
                        display.Text = Math.Abs(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "sin":
                        lblShowOpt.Text += $"sin({display.Text}):";
                        display.Text = Math.Sin(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "cos":
                        lblShowOpt.Text += $"cos({display.Text}):";
                        display.Text = Math.Cos(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "tan":
                        lblShowOpt.Text += $"tan({display.Text}):";
                        display.Text = Math.Tan(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;

                    case "cosh":
                        lblShowOpt.Text += $"cosh({display.Text}):";
                        display.Text = Math.Cosh(Convert.ToDouble(display.Text)).ToString();
                        PnlBitWise.SendToBack();
                        break;
                }
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;

            display.Text = "0";

            if (BtnClear.Text == "CE")
            {
                display.Text = "0";
            }
            else
            {
                display.Text = "0";
                lblShowOpt.Text = "";
            }

            if (display.Text == "0")
            {
                BtnClear.Text = "C";
            }
            else
            {
                BtnClear.Text = "CE";
            }
        }
    }
}
