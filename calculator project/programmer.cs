using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
namespace calculator_project
{
    public partial class programmer : Form
    {
        public static Color color1;
        public static Font font1;
        public programmer(Color color, string style)
        {
            InitializeComponent();

            btnEquals.Enabled = true;

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

            if (this.BackColor == Color.White)
            {
                label1.ForeColor = Color.Black;
                lblShowOpt.ForeColor = Color.DarkGray;
                label1.BackColor = Color.WhiteSmoke;
                lblShowOpt.BackColor = Color.WhiteSmoke;

                PnlHistory.BackColor = Color.WhiteSmoke;
                PnlHistory.ForeColor = Color.Black;
                BoxDisplayHistory.BackColor = Color.WhiteSmoke;
                BoxDisplayHistory.ForeColor = Color.Black;
            }
            else if(this.BackColor == Color.Black)
            {
                label1.BackColor = Color.Black;
                lblShowOpt.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                lblShowOpt.ForeColor = Color.WhiteSmoke;

                PnlHistory.BackColor = Color.Black;
                PnlHistory.ForeColor = Color.White;
                BoxDisplayHistory.BackColor = Color.Black;
                BoxDisplayHistory.ForeColor = Color.White;
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

            string txtFile = File.ReadAllText(Environment.CurrentDirectory + @"\HistoryProgram.txt");
            BoxDisplayHistory.Text = txtFile;

        }
        double number1, number2;
        double resultH1 = 0;
        double resultH2 = 0;
        double resultO1 = 0;
        double resultO2 = 0;
        double resultB1 = 0;
        double resultB2 = 0;
        int ResultNot = 0;
        string opt1 = "", opt2 = "";
        bool enter_value = false;
 
        int x = 0;
        decimal NumBit = 0, NumOct = 0, NumHex = 0, NumDec = 0;
        string binary = "", octal = "", Deci = "", hexadecimal = "";
        decimal floorH = 0, floorD = 0, floorO = 0, floorB = 0;
        int count = 0;
        int Count = 0;
        Int64 deci = 0;
        Int64 Binary = 0;
        Color color2;
        string form2 = "";

        decimal calcHexa(string input)
        {
            Int64 hexa = 0;

            hexa = Convert.ToInt64(input, 16);
            decimal Hexa = Convert.ToDecimal(hexa);
            Hexa = Math.Floor(Hexa);
            return Hexa;
        }

        decimal calcOctal(string input)
        {
       
            Int64 octal = 0;  
            
            octal = Convert.ToInt64(input, 8);
            decimal Octal = Convert.ToDecimal(octal);
            Octal = Math.Floor(Octal);
            return Octal;
        }

        decimal calcBinary(string input)
        {

            Int64 binary = 0;

            binary = Convert.ToInt64(input, 2);
            decimal Binary = Convert.ToDecimal(binary);
            Binary = Math.Floor(Binary);
            return Binary;
        }

        string CalcOctal(double input)
        {
            Int64 octal = Convert.ToInt64(input);
            string output = Convert.ToString(octal, 8);
            return output;
        }

        string CalcBinary(double input)
        {
            Int64 binary = Convert.ToInt64(input);
            string output = Convert.ToString(binary, 2);
            return output;
        }

        string CalcHexa(double input)
        {
            Int64 hexa = Convert.ToInt64(input);
            string output = Convert.ToString(hexa, 16);
            output = output.ToUpper();
            return output;
        }

        private void lblHEX_Click(object sender, EventArgs e)
        {
            x = 16;
        }

        private void lblDEC_Click(object sender, EventArgs e)
        {
            x = 10;
        }

        private void lblOCT_Click(object sender, EventArgs e)
        {
            x = 8;   
        }

        private void lblBIN_Click(object sender, EventArgs e)
        {
            x = 2;     
        }

        private void programmer_KeyDown(object sender, KeyEventArgs e)
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
                display.Text = display.Text.Remove(display.Text.Length - 1);

                if (display.Text == "")
                {
                    display.Text = "0";
                }
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

        private void btnEquals_Click(object sender, EventArgs e)
        {
            BtnOpt_Click(sender, e);
            lblShowOpt.Text = lblShowOpt.Text.Remove(lblShowOpt.Text.Length - 1);

            if (x == 10)
            {
                lblShowOpt.Text += "=";
                display.Text = number1 + "";

            }
            else if(x == 8)
            {
                lblShowOpt.Text += "=";
                octal = Convert.ToString(Convert.ToInt64(resultO1), 8);
                display.Text = octal;
            }
            else if(x == 2)
            {
                lblShowOpt.Text += "=";
                binary = Convert.ToString(Convert.ToInt64(resultB1), 2);
                display.Text = binary;

            }
            else if(x == 16)
            {
                lblShowOpt.Text += "=";
                hexadecimal = Convert.ToString(Convert.ToInt64(resultH1), 16);
                hexadecimal = hexadecimal.ToUpper();
                display.Text = hexadecimal;

            }

            if(display.Text == "0")
            {
                lblBIN.Text = "BIN     0";
                lblOCT.Text = "OCT     0";
                lblDEC.Text = "DEC     0";
                lblHEX.Text = "HEX     0";
            }
            count = 0;
        }
        


        private void BtnOpt_Click(object sender, EventArgs e)
        {
            Button btnOpt = (Button)sender;
            enter_value = true;
     
            if (x == 10)
            {
                count++;

                if(count == 1)
                {
                    number1 = Convert.ToDouble(display.Text);

                    lblShowOpt.Text = number1 + btnOpt.Text;
                    opt1 = btnOpt.Text;
                    BoxDisplayHistory.AppendText(number1 + opt1);
                
                }
                else if(count == 2)
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

                        case " AND ":
                            number1 = Convert.ToDouble(Convert.ToInt64(number1) & Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;

                        case " OR ":
                            number1 = Convert.ToDouble(Convert.ToInt64(number1) | Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;

                        case " XOR ":
                            number1 = Convert.ToDouble(Convert.ToInt64(number1) ^ Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NAND ":
                            number1 = ~(Convert.ToInt64(number1) & Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NOR ":
                            number1 = ~(Convert.ToInt64(number1) | Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;
                    }
                    display.Text = number1 + "";

                    BoxDisplayHistory.AppendText(number2 + " = " + number1 + "\n");

                    count++;
                    opt1 = opt2;
                }
                else
                {
                    opt2 = btnOpt.Text;
                    number2 = Convert.ToDouble(display.Text);
                    lblShowOpt.Text += number2 + opt2;
                    BoxDisplayHistory.AppendText(number1 + opt1 + number2 + "=");

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

                        case " AND ":
                            number1 = Convert.ToDouble(Convert.ToInt64(number1) & Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;

                        case " OR ":
                            number1 = Convert.ToDouble(Convert.ToInt64(number1) | Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;

                        case " XOR ":
                            number1 = Convert.ToDouble(Convert.ToInt64(number1) ^ Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NAND ":
                            number1 = ~(Convert.ToInt64(number1) & Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NOR ":
                            number1 = ~(Convert.ToInt64(number1) | Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;
                    }
                    display.Text = number1 + "";

                    BoxDisplayHistory.AppendText(number1 + "\n");
                    count++;
                    opt1 = opt2;
                }
              
            }

            else if (x == 16)
            {
               
                count++;

                if (count == 1)
                {
                    resultH1 = Convert.ToDouble(calcHexa(display.Text));

                    lblShowOpt.Text = display.Text + btnOpt.Text;
                    opt1 = btnOpt.Text;
                    BoxDisplayHistory.AppendText(resultH1 + opt1);

                }
                else if (count == 2)
                {
                    opt2 = btnOpt.Text;
                    resultH2 = Convert.ToDouble(calcHexa(display.Text));

                    lblShowOpt.Text += display.Text + opt2;

                    switch (opt1)
                    {
                        case "+":

                            resultH1 += resultH2;
                            break;

                        case "−":

                            resultH1 -= resultH2;
                            break;

                        case "×":

                            resultH1 *= resultH2;
                            break;

                        case "÷":

                            resultH1 /= resultH2;
                            break;

                        case " AND ":
                            resultH1 = Convert.ToDouble(Convert.ToInt64(resultH1) & Convert.ToInt64(resultH2));
                            PnlBitWise.SendToBack();
                            break;

                        case " OR ":
                            resultH1 = Convert.ToDouble(Convert.ToInt64(resultH1) | Convert.ToInt64(resultH2));
                            PnlBitWise.SendToBack();
                            break;

                        case " XOR ":
                            resultH1 = Convert.ToDouble(Convert.ToInt64(resultH1) ^ Convert.ToInt64(resultH2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NAND ":
                            resultH1 = ~(Convert.ToInt64(resultH1) & Convert.ToInt64(resultH2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NOR ":
                            number1 = ~(Convert.ToInt64(number1) | Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;
                    }
                    display.Text = CalcHexa(resultH1);

                    BoxDisplayHistory.AppendText(resultH2 + " = " + display.Text + "\n");

                    count++;
                    opt1 = opt2;
                }
                else
                {
                    opt2 = btnOpt.Text;

                    resultH2 = Convert.ToDouble(calcHexa(display.Text));

                    lblShowOpt.Text += display.Text + opt2;
                    BoxDisplayHistory.AppendText(resultH1 + opt1 + resultH2 + "=");

                    switch (opt1)
                    {
                         case "+":

                            resultH1 += resultH2;
                            break;

                        case "−":

                            resultH1 -= resultH2;
                            break;

                        case "×":

                            resultH1 *= resultH2;
                            break;

                        case "÷":

                            resultH1 /= resultH2;
                            break;


                        case " AND ":
                            resultH1 = Convert.ToDouble(Convert.ToInt64(resultH1) & Convert.ToInt64(resultH2));
                            PnlBitWise.SendToBack();
                            break;

                        case " OR ":
                            resultH1 = Convert.ToDouble(Convert.ToInt64(resultH1) | Convert.ToInt64(resultH2));
                            PnlBitWise.SendToBack();
                            break;

                        case " XOR ":
                            resultH1 = Convert.ToDouble(Convert.ToInt64(resultH1) ^ Convert.ToInt64(resultH2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NAND ":
                            resultH1 = ~(Convert.ToInt64(resultH1) & Convert.ToInt64(resultH2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NOR ":
                            number1 = ~(Convert.ToInt64(number1) | Convert.ToInt64(number2));
                            PnlBitWise.SendToBack();
                            break;
                    }
                    display.Text = CalcHexa(resultH1);

                    BoxDisplayHistory.AppendText(display.Text + "\n");
                    count++;
                    opt1 = opt2;
                }

            }
            else if(x == 8)
            {
              
                count++;

                if (count == 1)
                {
                    resultO1 = Convert.ToDouble(calcOctal(display.Text));

                    lblShowOpt.Text = display.Text + btnOpt.Text;
                    opt1 = btnOpt.Text;
                    BoxDisplayHistory.AppendText(resultO1 + opt1);

                }
                else if (count == 2)
                {
                    opt2 = btnOpt.Text;
                    resultO2 = Convert.ToDouble(calcOctal(display.Text));

                    lblShowOpt.Text += display.Text + opt2;

                    switch (opt1)
                    {
                        case "+":

                            resultO1 += resultO2;
                            break;

                        case "−":

                            resultO1 -= resultO2;
                            break;

                        case "×":

                            resultO1 *= resultO2;
                            break;

                        case "÷":

                            resultO1 /= resultO2;
                            break;

                        case " AND ":
                            resultO1 = Convert.ToDouble(Convert.ToInt64(resultO1) & Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;

                        case " OR ":
                            resultO1 = Convert.ToDouble(Convert.ToInt64(resultO1) | Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;

                        case " XOR ":
                            resultO1 = Convert.ToDouble(Convert.ToInt64(resultO1) ^ Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NAND ":
                            resultO1 = ~(Convert.ToInt64(resultO1) & Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NOR ":
                            resultO1 = ~(Convert.ToInt64(resultO1) | Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;
                    }
                    display.Text = CalcOctal(resultO1);
                    BoxDisplayHistory.AppendText(resultO2 + " = " + display.Text + "\n");

                    count++;
                    opt1 = opt2;
                }
                else
                {
                    opt2 = btnOpt.Text;

                    resultO2 = Convert.ToDouble(calcOctal(display.Text));

                    lblShowOpt.Text += display.Text + opt2;
                    BoxDisplayHistory.AppendText(resultO1 + opt1 + resultO2 + "=");

                    switch (opt1)
                    {
                       case "+":

                            resultO1 += resultO2;
                            break;

                        case "−":

                            resultO1 -= resultO2;
                            break;

                        case "×":

                            resultO1 *= resultO2;
                            break;

                        case "÷":

                            resultO1 /= resultO2;
                            break;

                          case " AND ":
                            resultO1 = Convert.ToDouble(Convert.ToInt64(resultO1) & Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;

                        case " OR ":
                            resultO1 = Convert.ToDouble(Convert.ToInt64(resultO1) | Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;

                        case " XOR ":
                            resultO1 = Convert.ToDouble(Convert.ToInt64(resultO1) ^ Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NAND ":
                            resultO1 = ~(Convert.ToInt64(resultO1) & Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NOR ":
                            resultO1 = ~(Convert.ToInt64(resultO1) | Convert.ToInt64(resultO2));
                            PnlBitWise.SendToBack();
                            break;
                    }
                    display.Text = CalcOctal(resultO1);

                    BoxDisplayHistory.AppendText(display.Text + "\n");
                    count++;
                    opt1 = opt2;
                }

            }
            else if(x == 2)
            {
            
                count++;

                if (count == 1)
                {
                    resultB1 = Convert.ToDouble(calcBinary(display.Text));

                    lblShowOpt.Text = display.Text + btnOpt.Text;
                    opt1 = btnOpt.Text;
                    BoxDisplayHistory.AppendText(resultB1 + opt1);

                }
                else if (count == 2)
                {
                    opt2 = btnOpt.Text;
                    resultB2 = Convert.ToDouble(calcBinary(display.Text));

                    lblShowOpt.Text += display.Text + opt2;

                    switch (opt1)
                    {
                        case "+":

                            resultB1 += resultB2;
                            break;

                        case "−":

                            resultB1 -= resultB2;
                            break;

                        case "×":

                            resultB1 *= resultB2;
                            break;

                        case "÷":

                           resultB1 /= resultB2;
                            break;

                        case " AND ":
                            resultB1 = Convert.ToDouble(Convert.ToInt64(resultB1) & Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;

                        case " OR ":
                            resultB1 = Convert.ToDouble(Convert.ToInt64(resultB1) | Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;

                        case " XOR ":
                            resultB1 = Convert.ToDouble(Convert.ToInt64(resultB1) ^ Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NAND ":
                            resultB1 = ~(Convert.ToInt64(resultB1) & Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NOR ":
                            resultB1 = ~(Convert.ToInt64(resultB1) | Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;
                    }
                    display.Text = CalcBinary(resultB1);

                    BoxDisplayHistory.AppendText(resultB2 + " = " + display.Text + "\n");

                    count++;
                    opt1 = opt2;
                }
                else
                {
                    opt2 = btnOpt.Text;

                    resultB2 = Convert.ToDouble(calcBinary(display.Text));

                    lblShowOpt.Text += display.Text + opt2;
                    BoxDisplayHistory.AppendText(resultB1 + opt1 + resultB2 + "=");

                    switch (opt1)
                    {
                         case "+":

                            resultB1 += resultB2;
                            break;

                        case "−":

                            resultB1 -= resultB2;
                            break;

                        case "×":

                            resultB1 *= resultB2;
                            break;

                        case "÷":

                            resultB1 /= resultB2;
                            break;

                        case " AND ":
                            resultB1 = Convert.ToDouble(Convert.ToInt64(resultB1) & Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;

                        case " OR ":
                            resultB1 = Convert.ToDouble(Convert.ToInt64(resultB1) | Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;

                        case " XOR ":
                            resultB1 = Convert.ToDouble(Convert.ToInt64(resultB1) ^ Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NAND ":
                            resultB1 = ~(Convert.ToInt64(resultB1) & Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;

                        case " NOR ":
                            resultB1 = ~(Convert.ToInt64(resultB1) | Convert.ToInt64(resultB2));
                            PnlBitWise.SendToBack();
                            break;
                    }
                    display.Text = CalcBinary(resultB1);

                    BoxDisplayHistory.AppendText(display.Text + "\n");
                    count++;
                    opt1 = opt2;
                }
            }     
        }

        private void BtnNumers_Click(object sender, EventArgs e)
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

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            display.Text = display.Text.Remove(display.Text.Length - 1);

            if (display.Text == "")
            {
                display.Text = "0";
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
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

            lblHEX.Text = "HEX     0";
            lblDEC.Text = "DEC     0";
            lblOCT.Text = "OCT     0";
            lblBIN.Text = "BIN     0";

            if (display.Text == "0")
            {
                BtnClear.Text = "C";
            }
            else
            {
                BtnClear.Text = "CE";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                display.Text = (Convert.ToDecimal(display.Text) * -1) + "";
            }
        }

        private void BtnNOT_Click(object sender, EventArgs e)
        {
            ResultNot = Convert.ToInt32(display.Text);
            display.Text = (~ResultNot) + "";
  
            PnlBitWise.SendToBack();
        }


        private void lblBIN_MouseLeave(object sender, EventArgs e)
        {
            lblBIN.BackColor = Color.Transparent;
            Lbl4.Visible = false;
        }

        private void lblOCT_MouseLeave(object sender, EventArgs e)
        {
            lblOCT.BackColor = Color.Transparent;
            Lbl3.Visible = false;
        }
        private void lblDEC_MouseLeave(object sender, EventArgs e)
        {
            lblDEC.BackColor = Color.Transparent;
            Lbl2.Visible = false;
        }

        private void lblHEX_MouseLeave(object sender, EventArgs e)
        {
            lblHEX.BackColor = Color.Transparent;
            Lbl1.Visible = false;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panel2.Location == new Point(-300, 43))
            {
                panel2.Location = new Point(0, 43);
                panel2.BringToFront();
            }
            else
            {
                panel2.Location = new Point(-300, 43);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (display.Text.Equals(double.NaN + ""))
            {
                display.Text = "0";
            }
            else if (display.Text.Equals(double.NegativeInfinity + ""))
            {
                display.Text = "U+221E";
            }
            else if (display.Text.Equals(double.PositiveInfinity + ""))
            {
                display.Text = "U+221E";
            }

            if (x == 16)
            {
                try
                {
                    if (display.Text != "0")
                    {

                        lblHEX.Text = "HEX      " + display.Text;

                        Int64 Display = Convert.ToInt64(display.Text, 16);
                        lblDEC.Text = "DEC      " + Display;

                        octal = Convert.ToString(Display, 8);
                        lblOCT.Text = "OCT      " + octal;

                        binary = Convert.ToString(Display, 2);
                        lblBIN.Text = "BIN      " + binary;
                    }
                    else
                    {
                        lblBIN.Text = "BIN     0";
                        lblOCT.Text = "OCT     0";
                        lblDEC.Text = "DEC     0";
                        lblHEX.Text = "HEX     0";
                    }
                }
                catch
                {

                }
            }

            else if(x == 10)
            {

                try
                {
                    if (display.Text != "")
                    {

                        NumDec = Convert.ToDecimal(display.Text);
                        floorD = Math.Floor(NumDec);
                        Deci = Convert.ToString(floorD);
                        lblDEC.Text = "DEC      " + Deci;
                        display.Text = Deci;

                        NumBit = Convert.ToDecimal(display.Text);
                        floorB = Convert.ToDecimal(Math.Floor(NumBit));

                        binary = Convert.ToString(Convert.ToInt64(floorB), 2);
                        lblBIN.Text = "BIN      " + binary;

                        octal = Convert.ToString(Convert.ToInt64(floorB), 8);
                        lblOCT.Text = "OCT      " + octal;

                        hexadecimal = Convert.ToString(Convert.ToInt64(floorB), 16);

                        hexadecimal = hexadecimal.ToUpper();
                        lblHEX.Text = "HEX      " + hexadecimal;

                    }
                    else
                    {
                        lblBIN.Text = "BIN     0";
                        lblOCT.Text = "OCT     0";
                        lblDEC.Text = "DEC     0";
                        lblHEX.Text = "HEX     0";
                    }
                }
                catch
                {

                }
            }
         
            else if(x == 8)
            {
                try
                {
                    if (display.Text != "")
                    {
                        NumOct = Convert.ToDecimal(display.Text);
                        floorO = Convert.ToDecimal(Math.Floor(NumOct));
                        octal = Convert.ToString(floorO);
                        lblOCT.Text = "OCT      " + octal;

                        deci = Convert.ToInt64(octal, 8);
                        lblDEC.Text = "DEC      " + deci;

                        binary = Convert.ToString(deci, 2);
                        lblBIN.Text = "BIN      " + binary;

                        hexadecimal = Convert.ToString(deci, 16);
                        hexadecimal = hexadecimal.ToUpper();
                        lblHEX.Text = "HEX      " + hexadecimal;
                    }

                    else
                    {
                        lblBIN.Text = "BIN     0";
                        lblOCT.Text = "OCT     0";
                        lblDEC.Text = "DEC     0";
                        lblHEX.Text = "HEX     0";
                    }
                }
                catch
                {

                 
                }
            }
            else if(x == 2)
            {
                try
                {

                }
                catch
                {
                    if (display.Text != "")
                    {

                        NumBit = Convert.ToDecimal(display.Text);
                        floorB = Convert.ToDecimal(Math.Floor(NumBit));

                        binary = Convert.ToString(floorB);
                        lblBIN.Text = "BIN      " + binary;
                        display.Text = binary;

                        Binary = Convert.ToInt64(binary, 2);
                        lblDEC.Text = "DEC      " + Binary;

                        octal = Convert.ToString(Binary, 8);
                        lblOCT.Text = "OCT      " + octal;

                        hexadecimal = Convert.ToString(Binary, 16);
                        hexadecimal = hexadecimal.ToUpper();
                        lblHEX.Text = "HEX      " + hexadecimal;
                    }
                    else
                    {
                        lblBIN.Text = "BIN     0";
                        lblOCT.Text = "OCT     0";
                        lblDEC.Text = "DEC     0";
                        lblHEX.Text = "HEX     0";
                    }
                }
            }
        }

        private void AllControls_MouseHover(object sender, EventArgs e)
        {
            if(this.BackColor == ColorTranslator.FromHtml("#202028"))
            {
                this.ForeColor = Color.White;
            }
            if (x == 16)
            {
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
                Btn2.Enabled = true;
                Btn3.Enabled = true;
                Btn4.Enabled = true;
                Btn5.Enabled = true;
                Btn6.Enabled = true;
                Btn7.Enabled = true;
                Btn8.Enabled = true;
                Btn9.Enabled = true;

                if (this.BackColor == Color.White || this.BackColor == programmer.DefaultBackColor)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c is Button)
                        {
                            c.BackColor = Color.WhiteSmoke;
                            c.ForeColor = Color.Black;
                        }
                    }
                    btnA.ForeColor = Color.Black;
                    btnB.ForeColor = Color.Black;
                    btnC.ForeColor = Color.Black;
                    btnD.ForeColor = Color.Black;
                    btnE.ForeColor = Color.Black;
                    btnF.ForeColor = Color.Black;
                    btn0.ForeColor = Color.Black;
                    Btn1.ForeColor = Color.Black;
                    Btn2.ForeColor = Color.Black;
                    Btn3.ForeColor = Color.Black;
                    Btn4.ForeColor = Color.Black;
                    Btn5.ForeColor = Color.Black;
                    Btn6.ForeColor = Color.Black;
                    Btn7.ForeColor = Color.Black;
                    Btn8.ForeColor = Color.Black;
                    Btn9.ForeColor = Color.Black;

                    btnA.BackColor = Color.White;
                    btnB.BackColor = Color.White;
                    btnC.BackColor = Color.White;
                    btnD.BackColor = Color.White;
                    btnE.BackColor = Color.White;
                    btnF.BackColor = Color.White;
                    btn0.BackColor = Color.White;
                    Btn1.BackColor = Color.White;
                    Btn2.BackColor = Color.White;
                    Btn3.BackColor = Color.White;
                    Btn4.BackColor = Color.White;
                    Btn5.BackColor = Color.White;
                    Btn6.BackColor = Color.White;
                    Btn7.BackColor = Color.White;
                    Btn8.BackColor = Color.White;
                    Btn9.BackColor = Color.White;

                }
                else if (this.BackColor == Color.Black)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c.Tag == "OverBtn")
                        {
                            c.BackColor = ColorTranslator.FromHtml("#464650");
                            c.ForeColor = Color.White;
                        }
                        if (c is Label)
                        {
                            c.ForeColor = Color.White;
                        }
                    }

                    btnEquals.ForeColor = Color.Black;
                    btnA.ForeColor = Color.White;
                    btnB.ForeColor = Color.White;
                    btnC.ForeColor = Color.White;
                    btnD.ForeColor = Color.White;
                    btnE.ForeColor = Color.White;
                    btnF.ForeColor = Color.White;
                    btn0.ForeColor = Color.White;
                    Btn1.ForeColor = Color.White;
                    Btn2.ForeColor = Color.White;
                    Btn3.ForeColor = Color.White;
                    Btn4.ForeColor = Color.White;
                    Btn5.ForeColor = Color.White;
                    Btn6.ForeColor = Color.White;
                    Btn7.ForeColor = Color.White;
                    Btn8.ForeColor = Color.White;
                    Btn9.ForeColor = Color.White;

                    btnA.BackColor = ColorTranslator.FromHtml("#464650");
                    btnB.BackColor = ColorTranslator.FromHtml("#464650");
                    btnC.BackColor = ColorTranslator.FromHtml("#464650");
                    btnD.BackColor = ColorTranslator.FromHtml("#464650");
                    btnE.BackColor = ColorTranslator.FromHtml("#464650");
                    btnF.BackColor = ColorTranslator.FromHtml("#464650");
                    btn0.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn1.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn2.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn3.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn4.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn5.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn6.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn7.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn8.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn9.BackColor = ColorTranslator.FromHtml("#464650");
                }

                lblHEX.BackColor = Color.Gray;
                Lbl1.Visible = true;
            }
            else if(x == 10)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;

                Btn2.Enabled = true;
                Btn3.Enabled = true;
                Btn4.Enabled = true;
                Btn5.Enabled = true;
                Btn6.Enabled = true;
                Btn7.Enabled = true;
                Btn8.Enabled = true;
                Btn9.Enabled = true;

                if (this.BackColor == Color.White || this.BackColor == programmer.DefaultBackColor)
                {

                    btnA.ForeColor = Color.Gray;
                    btnB.ForeColor = Color.Gray;
                    btnC.ForeColor = Color.Gray;
                    btnD.ForeColor = Color.Gray;
                    btnE.ForeColor = Color.Gray;
                    btnF.ForeColor = Color.Gray;

                    btn0.ForeColor = Color.Black;
                    Btn1.ForeColor = Color.Black;
                    Btn2.ForeColor = Color.Black;
                    Btn3.ForeColor = Color.Black;
                    Btn4.ForeColor = Color.Black;
                    Btn5.ForeColor = Color.Black;
                    Btn6.ForeColor = Color.Black;
                    Btn7.ForeColor = Color.Black;
                    Btn8.ForeColor = Color.Black;
                    Btn9.ForeColor = Color.Black;

                    btnA.BackColor = Color.LightGray;
                    btnB.BackColor = Color.LightGray;
                    btnC.BackColor = Color.LightGray;
                    btnD.BackColor = Color.LightGray;
                    btnE.BackColor = Color.LightGray;
                    btnF.BackColor = Color.LightGray;

                    btn0.BackColor = Color.White;
                    Btn1.BackColor = Color.White;
                    Btn2.BackColor = Color.White;
                    Btn3.BackColor = Color.White;
                    Btn4.BackColor = Color.White;
                    Btn5.BackColor = Color.White;
                    Btn6.BackColor = Color.White;
                    Btn7.BackColor = Color.White;
                    Btn8.BackColor = Color.White;
                    Btn9.BackColor = Color.White;

                }
                else if (this.BackColor == Color.Black)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c.Tag == "OverBtn")
                        {
                            c.BackColor = ColorTranslator.FromHtml("#464650");
                            c.ForeColor = Color.White;
                        }
                        if (c is Label)
                        {
                            c.ForeColor = Color.White;
                        }
                    }

                    btnA.ForeColor = Color.DarkGray;
                    btnB.ForeColor = Color.DarkGray;
                    btnC.ForeColor = Color.DarkGray;
                    btnD.ForeColor = Color.DarkGray;
                    btnE.ForeColor = Color.DarkGray;
                    btnF.ForeColor = Color.DarkGray;

                    btn0.ForeColor = Color.White;
                    Btn1.ForeColor = Color.White;
                    Btn2.ForeColor = Color.White;
                    Btn3.ForeColor = Color.White;
                    Btn4.ForeColor = Color.White;
                    Btn5.ForeColor = Color.White;
                    Btn6.ForeColor = Color.White;
                    Btn7.ForeColor = Color.White;
                    Btn8.ForeColor = Color.White;
                    Btn9.ForeColor = Color.White;

                    btnA.BackColor = ColorTranslator.FromHtml("#808080");
                    btnB.BackColor = ColorTranslator.FromHtml("#808080");
                    btnC.BackColor = ColorTranslator.FromHtml("#808080");
                    btnD.BackColor = ColorTranslator.FromHtml("#808080");
                    btnE.BackColor = ColorTranslator.FromHtml("#808080");
                    btnF.BackColor = ColorTranslator.FromHtml("#808080");

                    btn0.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn1.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn2.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn3.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn4.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn5.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn6.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn7.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn8.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn9.BackColor = ColorTranslator.FromHtml("#464650");
                }

                lblDEC.BackColor = Color.Gray;
                Lbl2.Visible = true;
            }
            else if(x == 8)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                Btn8.Enabled = false;
                Btn9.Enabled = false;

                Btn2.Enabled = true;
                Btn3.Enabled = true;
                Btn4.Enabled = true;
                Btn5.Enabled = true;
                Btn6.Enabled = true;
                Btn7.Enabled = true;

                if (this.BackColor == Color.White || this.BackColor == programmer.DefaultBackColor)
                {
                    btnA.ForeColor = Color.Gray;
                    btnB.ForeColor = Color.Gray;
                    btnC.ForeColor = Color.Gray;
                    btnD.ForeColor = Color.Gray;
                    btnE.ForeColor = Color.Gray;
                    btnF.ForeColor = Color.Gray;
                    Btn8.ForeColor = Color.Gray;
                    Btn9.ForeColor = Color.Gray;

                    btn0.ForeColor = Color.Black;
                    Btn1.ForeColor = Color.Black;
                    Btn2.ForeColor = Color.Black;
                    Btn3.ForeColor = Color.Black;
                    Btn4.ForeColor = Color.Black;
                    Btn5.ForeColor = Color.Black;
                    Btn6.ForeColor = Color.Black;
                    Btn7.ForeColor = Color.Black;

                    btnA.BackColor = Color.LightGray;
                    btnB.BackColor = Color.LightGray;
                    btnC.BackColor = Color.LightGray;
                    btnD.BackColor = Color.LightGray;
                    btnE.BackColor = Color.LightGray;
                    btnF.BackColor = Color.LightGray;
                    Btn8.BackColor = Color.LightGray;
                    Btn9.BackColor = Color.LightGray;

                    btn0.BackColor = Color.White;
                    Btn1.BackColor = Color.White;
                    Btn2.BackColor = Color.White;
                    Btn3.BackColor = Color.White;
                    Btn4.BackColor = Color.White;
                    Btn5.BackColor = Color.White;
                    Btn6.BackColor = Color.White;
                    Btn7.BackColor = Color.White;
                }
                else if (this.BackColor == Color.Black)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c.Tag == "OverBtn")
                        {
                            c.BackColor = ColorTranslator.FromHtml("#464650");
                            c.ForeColor = Color.White;
                        }
                        if (c is Label)
                        {
                            c.ForeColor = Color.White;
                        }
                    }

                    btn0.ForeColor = Color.White;
                    Btn1.ForeColor = Color.White;
                    Btn2.ForeColor = Color.White;
                    Btn3.ForeColor = Color.White;
                    Btn4.ForeColor = Color.White;
                    Btn5.ForeColor = Color.White;
                    Btn6.ForeColor = Color.White;
                    Btn7.ForeColor = Color.White;

                    btnA.ForeColor = Color.DarkGray;
                    btnB.ForeColor = Color.DarkGray;
                    btnC.ForeColor = Color.DarkGray;
                    btnD.ForeColor = Color.DarkGray;
                    btnE.ForeColor = Color.DarkGray;
                    btnF.ForeColor = Color.DarkGray;
                    Btn8.ForeColor = Color.DarkGray;
                    Btn9.ForeColor = Color.DarkGray;

                    btn0.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn1.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn2.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn3.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn4.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn5.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn6.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn7.BackColor = ColorTranslator.FromHtml("#464650");

                    btnA.BackColor = ColorTranslator.FromHtml("#808080");
                    btnB.BackColor = ColorTranslator.FromHtml("#808080");
                    btnC.BackColor = ColorTranslator.FromHtml("#808080");
                    btnD.BackColor = ColorTranslator.FromHtml("#808080");
                    btnE.BackColor = ColorTranslator.FromHtml("#808080");
                    btnF.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn8.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn9.BackColor = ColorTranslator.FromHtml("#808080");
                }

                lblOCT.BackColor = Color.Gray;
                Lbl3.Visible = true;
            }
            else if(x == 2)
            {

                foreach (Control c in this.Controls)
                {
                    if (c != btn0 && c != Btn1 && c != BtnExit && c != BtnHistory && c.Tag != "OverBtn" && c is Button && c != btnEquals)
                    {
                        c.Enabled = false;
                    }
                }

                if (this.BackColor == Color.White || this.BackColor == programmer.DefaultBackColor)
                {
                    btnA.ForeColor = Color.Gray;
                    btnB.ForeColor = Color.Gray;
                    btnC.ForeColor = Color.Gray;
                    btnD.ForeColor = Color.Gray;
                    btnE.ForeColor = Color.Gray;
                    btnF.ForeColor = Color.Gray;
                    Btn2.ForeColor = Color.Gray;
                    Btn3.ForeColor = Color.Gray;
                    Btn4.ForeColor = Color.Gray;
                    Btn5.ForeColor = Color.Gray;
                    Btn6.ForeColor = Color.Gray;
                    Btn7.ForeColor = Color.Gray;
                    Btn8.ForeColor = Color.Gray;
                    Btn9.ForeColor = Color.Gray;

                    Btn1.ForeColor = Color.Black;
                    btn0.ForeColor = Color.Black;

                    btnA.BackColor = Color.LightGray;
                    btnB.BackColor = Color.LightGray;
                    btnC.BackColor = Color.LightGray;
                    btnD.BackColor = Color.LightGray;
                    btnE.BackColor = Color.LightGray;
                    btnF.BackColor = Color.LightGray;
                    Btn2.BackColor = Color.LightGray;
                    Btn3.BackColor = Color.LightGray;
                    Btn4.BackColor = Color.LightGray;
                    Btn5.BackColor = Color.LightGray;
                    Btn6.BackColor = Color.LightGray;
                    Btn7.BackColor = Color.LightGray;
                    Btn8.BackColor = Color.Gainsboro;
                    Btn9.BackColor = Color.Gainsboro;

                    btn0.BackColor = Color.White;
                    Btn1.BackColor = Color.White;
                }
                else if (this.BackColor == Color.Black)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c.Tag == "OverBtn")
                        {
                            c.BackColor = ColorTranslator.FromHtml("#464650");
                            c.ForeColor = Color.White;
                        }
                        if (c is Label)
                        {
                            c.ForeColor = Color.White;
                        }
                    }

                    btnA.ForeColor = Color.DarkGray;
                    btnB.ForeColor = Color.DarkGray;
                    btnC.ForeColor = Color.DarkGray;
                    btnD.ForeColor = Color.DarkGray;
                    btnE.ForeColor = Color.DarkGray;
                    btnF.ForeColor = Color.DarkGray;
                    Btn2.ForeColor = Color.DarkGray;
                    Btn3.ForeColor = Color.DarkGray;
                    Btn4.ForeColor = Color.DarkGray;
                    Btn5.ForeColor = Color.DarkGray;
                    Btn6.ForeColor = Color.DarkGray;
                    Btn7.ForeColor = Color.DarkGray;
                    Btn8.ForeColor = Color.DarkGray;
                    Btn9.ForeColor = Color.DarkGray;

                    Btn1.ForeColor = Color.White;
                    btn0.ForeColor = Color.White;

                    btnA.BackColor = ColorTranslator.FromHtml("#808080");
                    btnB.BackColor = ColorTranslator.FromHtml("#808080");
                    btnC.BackColor = ColorTranslator.FromHtml("#808080");
                    btnD.BackColor = ColorTranslator.FromHtml("#808080");
                    btnE.BackColor = ColorTranslator.FromHtml("#808080");
                    btnF.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn2.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn3.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn4.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn5.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn6.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn7.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn8.BackColor = ColorTranslator.FromHtml("#808080");
                    Btn9.BackColor = ColorTranslator.FromHtml("#808080");

                    btn0.BackColor = ColorTranslator.FromHtml("#464650");
                    Btn1.BackColor = ColorTranslator.FromHtml("#464650");
                }

                Lbl4.Visible = true;
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temperature form1 = new Temperature(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speed form1 = new Speed(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += "(";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text += ")";
        }

        private void button4_Click(object sender, EventArgs e)
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
        private void lblBIN_MouseHover_1(object sender, EventArgs e)
        {
            x = 2;
        }

        private void lblOCT_MouseHover_1(object sender, EventArgs e)
        {
            x = 8;
        }

        private void lblDEC_MouseHover_1(object sender, EventArgs e)
        {
            x = 10;
        }

        private void lblHEX_MouseHover_1(object sender, EventArgs e)
        {
            x = 16;
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            File.Delete(Environment.CurrentDirectory + @"\HistoryProgram.txt");
            File.AppendAllText(Environment.CurrentDirectory + @"\HistoryProgram.txt", BoxDisplayHistory.Text + "\n");
            this.Close();
        }
        private void BtnHistory_Click(object sender, EventArgs e)
        {
            if (PnlHistory.Height == 10)
            {
                PnlHistory.Height = 280;
                PnlHistory.BringToFront();
            }
            else
            {
                PnlHistory.Height = 10;
            }
        }
        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            BoxDisplayHistory.Clear();
            if(BoxDisplayHistory.Text == string.Empty)
            {
                BoxDisplayHistory.Text = "There's no history yet!";
            }
        }

        private void BITwise_Click(object sender, EventArgs e)
        {
            PnlBitWise.Visible = true;
            PnlBitWise.BringToFront();      
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
            display.Text = (Convert.ToDecimal(display.Text) / 100) + "";
            }
        }
    }
}
