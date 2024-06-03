using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace calculator_project
{
    public partial class Standard : Form
    {
        public static Color color1;
        public static Font font1;
        public static Font font2;

        public Standard(Color color, string style)
        {
            InitializeComponent();

            this.BackColor = color1;

            if(font1 != null)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button || c is Label || c is RichTextBox || c is Panel)
                    {
                        c.Font = font1;
                    }
                }
                this.Font = font1;
            }
            else
            {
                this.Font = Standard.DefaultFont;
            }
            font2 = this.Font;
            panel1.Visible = false;

            if (color != null)
            {
                color2 = color;
                foreach (Control c in this.Controls)
                {
                    c.BackColor = color;
                }
            }
            else
            {

            }
            form2 = style;

            if (style == "None")
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else if(style == "Fixed3D")
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


            if (this.BackColor == Color.Black)
            {
                this.ForeColor = Color.WhiteSmoke;

                Color cl = ColorTranslator.FromHtml("#202020");
                this.BackColor = cl;
                this.ForeColor = Color.White;

                foreach (Control c in this.Controls)
                {
                    if(c is Label || c.Tag == "Over")
                    {
                        c.ForeColor = Color.White;
                    }

                    Btn0.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn1.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn2.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn3.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn4.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn5.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn6.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn7.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn8.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn9.BackColor = ColorTranslator.FromHtml("#464650");
                    ChangeSign.BackColor = ColorTranslator.FromHtml("#464650");
                    BtnDecimal.BackColor = ColorTranslator.FromHtml("#464650");

                    Btn0.ForeColor = Color.White;
                    Btn1.ForeColor = Color.White;
                    Btn2.ForeColor = Color.White;
                    Btn3.ForeColor = Color.White;
                    Btn4.ForeColor = Color.White;
                    Btn5.ForeColor = Color.White;
                    Btn6.ForeColor = Color.White;
                    Btn7.ForeColor = Color.White;
                    Btn8.ForeColor = Color.White;
                    Btn9.ForeColor = Color.White;
                    ChangeSign.ForeColor = Color.White;
                    BtnDecimal.ForeColor = Color.White;

                    BtnAdd.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnSub.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnMultyply.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnDivision.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnDivision.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnC.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnCE.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnFactor.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnPer.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnPercent.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnPower.BackColor = ColorTranslator.FromHtml("#32323C");

                    BtnAdd.ForeColor = Color.WhiteSmoke;
                    BtnSub.ForeColor = Color.WhiteSmoke;
                    BtnMultyply.ForeColor = Color.WhiteSmoke;
                    BtnDivision.ForeColor = Color.WhiteSmoke;
                    BtnDivision.ForeColor = Color.WhiteSmoke;
                    BtnC.ForeColor = Color.WhiteSmoke;
                    BtnCE.ForeColor = Color.WhiteSmoke;
                    BtnFactor.ForeColor = Color.WhiteSmoke;
                    BtnPer.ForeColor = Color.WhiteSmoke;
                    BtnPercent.ForeColor = Color.WhiteSmoke;
                    BtnPower.ForeColor = Color.WhiteSmoke;

                    Equals.BackColor = Color.LightGray;
                    Equals.ForeColor = Color.White;
    
                }
                PnlHistory.BackColor = Color.Black;
                PnlHistory.ForeColor = Color.White;
                BoxDisplayHistory.BackColor = Color.Black;
                BoxDisplayHistory.ForeColor = Color.White;


            }
            else if(this.BackColor == Color.White)
            {
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;

                Btn0.BackColor = Color.White;
                Btn1.BackColor = Color.White;
                Btn2.BackColor = Color.White;
                Btn3.BackColor = Color.White;
                Btn4.BackColor = Color.White;
                Btn5.BackColor = Color.White;
                Btn6.BackColor = Color.White;
                Btn7.BackColor = Color.White;
                Btn8.BackColor = Color.White;
                Btn9.BackColor = Color.White;
                ChangeSign.BackColor = Color.White;
                BtnDecimal.BackColor = Color.White;

                Btn0.ForeColor = Color.Black;
                Btn1.ForeColor = Color.Black;
                Btn2.ForeColor = Color.Black;
                Btn3.ForeColor = Color.Black;
                Btn4.ForeColor = Color.Black;
                Btn5.ForeColor = Color.Black;
                Btn6.ForeColor = Color.Black;
                Btn7.ForeColor = Color.Black;
                Btn8.ForeColor = Color.Black;
                Btn9.ForeColor = Color.Black;
                ChangeSign.ForeColor = Color.Black;
                BtnDecimal.ForeColor = Color.Black;

                BtnAdd.BackColor = Color.WhiteSmoke;
                BtnSub.BackColor = Color.WhiteSmoke;
                BtnMultyply.BackColor = Color.WhiteSmoke;
                BtnDivision.BackColor = Color.WhiteSmoke;
                BtnDivision.BackColor = Color.WhiteSmoke;
                BtnC.BackColor = Color.WhiteSmoke;
                BtnCE.BackColor = Color.WhiteSmoke;
                BtnFactor.BackColor = Color.WhiteSmoke;
                BtnPer.BackColor = Color.WhiteSmoke;
                BtnPercent.BackColor = Color.WhiteSmoke;
                BtnPower.BackColor = Color.WhiteSmoke;

                Equals.BackColor = Color.DarkSlateGray;
                Equals.ForeColor = Color.Black;
   
                PnlHistory.BackColor = Color.WhiteSmoke;
                PnlHistory.ForeColor = Color.Black;
                BoxDisplayHistory.BackColor = Color.WhiteSmoke;
                BoxDisplayHistory.ForeColor = Color.Black;
            }
            string txtFile = Environment.CurrentDirectory + @"\History.txt";
            BoxDisplayHistory.Text = File.ReadAllText(txtFile);

        }

        bool digit = false;
        decimal result = 0;
        double Result = 0;
        int factor = 0;
        int fact = 1;
        string Number1, Number2;
        string opt = "";
        bool enter_value = false;
        Color color2;
        string form2 = "";
        int count = 0;
        char EndDisplay;
        bool End = false;

        private void BtnNums_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (display.Text == "0" || enter_value)
            {
                display.Text = "";
                enter_value = false;
            }

            if (btn.Text == ".")
            {
                if (!display.Text.Contains("."))
                {
                    display.Text += btn.Text;
                }
            }
            else
            {
                display.Text += btn.Text;
            }

        }
        private void BtnMathOpt_Click(object sender, EventArgs e)
        {
            Button btnOpt = (Button)sender;
            count++;

            if (result != 0)
            {
                Equals.PerformClick();
                enter_value = true;
                opt = btnOpt.Text;
                lblShowOpt.Text = result + " " + opt;
            }
            else if (result == 0)
            {
                enter_value = true;
                opt = btnOpt.Text;
                result = decimal.Parse(display.Text);
                display.Text = "";
                lblShowOpt.Text = result + " " + opt;
            }
            if (display.Text != "0")
            {
                display.Text = "";
                Number1 = result + opt;
                lblShowOpt.Text = Number1;
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {

            Number2 = display.Text;

            ;
            switch (opt)
            {
                case "+":
                    display.Text = result + Convert.ToDecimal(display.Text) + "";
                    BoxDisplayHistory.AppendText(Number1 + Number2 + " = " + display.Text + "\n");

                    break;

                case "−":
                    display.Text = result - Convert.ToDecimal(display.Text) + "";
                    BoxDisplayHistory.AppendText(Number1 + Number2 + " = " + display.Text + "\n");

                    break;

                case "×":
                    display.Text = result * Convert.ToDecimal(display.Text) + "";
                    BoxDisplayHistory.AppendText(Number1 + Number2 + " = " + display.Text + "\n");

                    break;

                case "÷":
                    if (display.Text != "0")
                    {
                        display.Text = result / Convert.ToDecimal(display.Text) + "";
                        BoxDisplayHistory.AppendText(Number1 + Number2 + " = " + display.Text + "\n");

                    }
                    break;

                case "mod":
                    display.Text = result % Convert.ToDecimal(display.Text) + "";
                    BoxDisplayHistory.AppendText(Number1 + Number2 + "  = " + display.Text + "\n");

                    break;

                case "^":
                    Result = Convert.ToDouble(result);
                    display.Text = Math.Pow(Result, Double.Parse(display.Text)) + "";
                    BoxDisplayHistory.AppendText(Number1 + Number2 + "  = " + display.Text + "\n");

                    break;
                default:
                    lblShowOpt.Text = display.Text + " =";
                    break;
            }


            if (opt == "÷" && display.Text == "0")
            {
                display.Text = "Can't divide by zero";
            }
            else
            {
                result = Convert.ToDecimal(display.Text);
                Number1 = lblShowOpt.Text;

                lblShowOpt.Text = Number1 + Number2 + " = ";
            }

        }
        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
           if (display.Text == "Can't divide by zero")
            {
                display.Text = "";
                lblShowOpt.Text = "";
            }
           else
            {

            display.Text = display.Text.Remove(display.Text.Length-1);
            }

            if(display.Text == "")
            {
                display.Text = "0";
            }

        }

        private void BtnCE_Click_1(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            lblShowOpt.Text = "";
            result = 0;
            Number1 = "";
            Number2 = "";
        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            display.Text = (Convert.ToDecimal(display.Text) * -1) + "";
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if(panel1.Visible == true)
            {
                panel1.Visible = false;
            }

        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            display.Text = (Convert.ToDecimal(display.Text)/100) + "";
        }

        private void BtnFactor_Click(object sender, EventArgs e)
        {

            lblShowOpt.Text = "fact(" + display.Text + ")";
            factor = Convert.ToInt32(display.Text);
            fact = 1;

            for(int i = 2; i <= factor; i++)
            {
                fact *= i;
            }         

            display.Text = fact.ToString(); 
            BoxDisplayHistory.AppendText(lblShowOpt.Text + " = " + display.Text + "\n");
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            if(PnlHistory.Height == 10)
            {
                PnlHistory.Height = 400;
            }
            else
            {
                PnlHistory.Height = 10;
            }
            BtnClearHistory.BringToFront();
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {

            BoxDisplayHistory.Clear();
            if(BoxDisplayHistory.Text == string.Empty)
            {
                BoxDisplayHistory.Text = "There's no history yet!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Black)
            {
                panel1.BackColor = ColorTranslator.FromHtml("#32323C");
                panel1.ForeColor = Color.White;
            }

            if (display.Text.Equals(double.NaN + ""))
            {
                display.Text = "0";
            }
            else if(display.Text.Equals(double.NegativeInfinity + ""))
            {
                display.Text = "U+221E";
            }
            else if (display.Text.Equals(double.PositiveInfinity + ""))
            {
                display.Text = "U+221E";
            }
      
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Standard form1 = new Standard(color2 ,form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            programmer form1 = new programmer(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Currency form1 = new Currency(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Volume form1 = new Volume(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Length form1 = new Length(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Weight form1 = new Weight(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            setting form1 = new setting(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speed form1 = new Speed(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temperature form1 = new Temperature(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer form1 = new Timer(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void display_MouseHover(object sender, EventArgs e)
        {
            if (this.BackColor == ColorTranslator.FromHtml("#202028"))
            {
                this.ForeColor = Color.White;

                foreach (Control c in this.Controls)
                {
                    if (c is Label || c.Tag == "Over")
                    {
                        c.ForeColor = Color.White;
                    }

                    Btn0.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn1.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn2.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn3.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn4.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn5.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn6.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn7.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn8.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn9.BackColor = ColorTranslator.FromHtml("#464650");
                    ChangeSign.BackColor = ColorTranslator.FromHtml("#464650");
                    BtnDecimal.BackColor = ColorTranslator.FromHtml("#464650");

                    Btn0.ForeColor = Color.White;
                    Btn1.ForeColor = Color.White;
                    Btn2.ForeColor = Color.White;
                    Btn3.ForeColor = Color.White;
                    Btn4.ForeColor = Color.White;
                    Btn5.ForeColor = Color.White;
                    Btn6.ForeColor = Color.White;
                    Btn7.ForeColor = Color.White;
                    Btn8.ForeColor = Color.White;
                    Btn9.ForeColor = Color.White;
                    ChangeSign.ForeColor = Color.White;
                    BtnDecimal.ForeColor = Color.White;

                    BtnAdd.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnSub.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnMultyply.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnDivision.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnDivision.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnC.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnCE.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnFactor.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnPer.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnPercent.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnPower.BackColor = ColorTranslator.FromHtml("#32323C");

                    BtnAdd.ForeColor = Color.WhiteSmoke;
                    BtnSub.ForeColor = Color.WhiteSmoke;
                    BtnMultyply.ForeColor = Color.WhiteSmoke;
                    BtnDivision.ForeColor = Color.WhiteSmoke;
                    BtnDivision.ForeColor = Color.WhiteSmoke;
                    BtnC.ForeColor = Color.WhiteSmoke;
                    BtnCE.ForeColor = Color.WhiteSmoke;
                    BtnFactor.ForeColor = Color.WhiteSmoke;
                    BtnPer.ForeColor = Color.WhiteSmoke;
                    BtnPercent.ForeColor = Color.WhiteSmoke;
                    BtnPower.ForeColor = Color.WhiteSmoke;

                    Equals.BackColor = Color.LightGray;
                    Equals.ForeColor = Color.White;

                }
                PnlHistory.BackColor = Color.Black;
                PnlHistory.ForeColor = Color.White;
                BoxDisplayHistory.BackColor = Color.Black;
                BoxDisplayHistory.ForeColor = Color.White;


            }
            else if (this.BackColor == Color.White)
            {
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;

                Btn0.BackColor = Color.White;
                Btn1.BackColor = Color.White;
                Btn2.BackColor = Color.White;
                Btn3.BackColor = Color.White;
                Btn4.BackColor = Color.White;
                Btn5.BackColor = Color.White;
                Btn6.BackColor = Color.White;
                Btn7.BackColor = Color.White;
                Btn8.BackColor = Color.White;
                Btn9.BackColor = Color.White;
                ChangeSign.BackColor = Color.White;
                BtnDecimal.BackColor = Color.White;

                Btn0.ForeColor = Color.Black;
                Btn1.ForeColor = Color.Black;
                Btn2.ForeColor = Color.Black;
                Btn3.ForeColor = Color.Black;
                Btn4.ForeColor = Color.Black;
                Btn5.ForeColor = Color.Black;
                Btn6.ForeColor = Color.Black;
                Btn7.ForeColor = Color.Black;
                Btn8.ForeColor = Color.Black;
                Btn9.ForeColor = Color.Black;
                ChangeSign.ForeColor = Color.Black;
                BtnDecimal.ForeColor = Color.Black;

                BtnAdd.BackColor = Color.WhiteSmoke;
                BtnSub.BackColor = Color.WhiteSmoke;
                BtnMultyply.BackColor = Color.WhiteSmoke;
                BtnDivision.BackColor = Color.WhiteSmoke;
                BtnDivision.BackColor = Color.WhiteSmoke;
                BtnC.BackColor = Color.WhiteSmoke;
                BtnCE.BackColor = Color.WhiteSmoke;
                BtnFactor.BackColor = Color.WhiteSmoke;
                BtnPer.BackColor = Color.WhiteSmoke;
                BtnPercent.BackColor = Color.WhiteSmoke;
                BtnPower.BackColor = Color.WhiteSmoke;

                Equals.BackColor = Color.DarkSlateGray;
                Equals.ForeColor = Color.Black;

                PnlHistory.BackColor = Color.WhiteSmoke;
                PnlHistory.ForeColor = Color.Black;
                BoxDisplayHistory.BackColor = Color.WhiteSmoke;
                BoxDisplayHistory.ForeColor = Color.Black;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            File.Delete(Environment.CurrentDirectory + @"\History.txt");
            File.AppendAllText(Environment.CurrentDirectory + @"\History.txt", BoxDisplayHistory.Text);
            Application.Exit();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new theme1().Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new Scientific(color2, form2).Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
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
            if(e.KeyCode == Keys.Back)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);

                if (display.Text == "")
                {
                    display.Text = "0";
                }
            }
            if(e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                BtnAdd.PerformClick();
            }
            if(e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                BtnSub.PerformClick();
            }
            if(e.KeyCode == Keys.Multiply)
            {
                BtnMultyply.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                BtnDivision.PerformClick();
            }
            if(e.KeyCode == Keys.Enter)
            {
                Equals.PerformClick();
            }
        }
    }
}
