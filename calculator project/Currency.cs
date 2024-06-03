using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using RestSharp;
using Newtonsoft.Json;

namespace calculator_project
{
    public partial class Currency : Form
    {
        public static Color color1;
        public static Font font1;

        private Dictionary<string, double> _currencies = new Dictionary<string, double>();

        public Currency(Color color, string style)
        {
            InitializeComponent();

            var currencies = GetLatestCurrencies();
            dynamic responseObject = JsonConvert.DeserializeObject(currencies);

            foreach (var item in responseObject.data)
            {
                DestinationCombo.Items.Add(item.First.code.ToString());
                SourceCombo.Items.Add(item.First.code.ToString());
                _currencies.Add(item.First.code.ToString(), item.First.value.Value);
            }

            this.BackColor = color1;

            if(font1 != null)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button || c is Label || c is ComboBox)
                    {
                        c.Font = font1;
                    }
                }
            }

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

        private string GetLatestCurrencies()
        {

            var client = new RestClient("https://api.currencyapi.com/v3/latest");

            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "cur_live_jkKXwV40yJRheb7GPwio8qI6U9sFSmugdsj3Rehq");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        int x;
        bool enter_value = false;
        string form2;
        Color color2;

        private void LblDisplay1_Click(object sender, EventArgs e)
        {
            x = 1;
            textAmount.Font = new Font(textAmount.Font, FontStyle.Bold);
            lblResult.Font = new Font(lblResult.Font, FontStyle.Regular);
        }

        private void LblDisplay2_Click(object sender, EventArgs e)
        {
            lblResult.Font = new Font(lblResult.Font, FontStyle.Bold);
            textAmount.Font = new Font(textAmount.Font, FontStyle.Regular);
            enter_value = true;
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                textAmount.Text = textAmount.Text.Remove(textAmount.Text.Length - 1);

                if (textAmount.Text == "")
                {
                    textAmount.Text = "0";
                }
            }
            else if (x == 2)
            {
                lblResult.Text = lblResult.Text.Remove(lblResult.Text.Length - 1);

                if (lblResult.Text == "")
                {
                    lblResult.Text = "0";
                }
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textAmount.Text = "0";
            lblResult.Text = "0";
            enter_value = true;
        }

        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            Button btnNum = (Button)sender;

            if (x == 1)
            {
                if (enter_value || textAmount.Text == "0")
                {
                    textAmount.Text = "";
                    enter_value = false;
                }
            }


            if (x == 1)
            {
                if (btnNum.Text == ".")
                {
                    if (!textAmount.Text.Contains("."))
                    {
                        textAmount.Text += btnNum.Text;
                    }
                }
                else
                {
                    textAmount.Text += btnNum.Text;
                }
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Location == new Point(-300, 45))
            {
                panel1.Location = new Point(0, 45);
            }
            else
            {
                panel1.Location = new Point(-300, 45);
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            var selectedSourceCurrency = SourceCombo.SelectedItem;
            var selectedDestCurrency = DestinationCombo.SelectedItem;
            var amount = double.Parse(textAmount.Text);

            var sourceCurrencyExchangeRate = _currencies.First(c => c.Key == selectedSourceCurrency).Value;
            var destinationCurrencyExchangeRate = _currencies.First(c => c.Key == selectedDestCurrency).Value;

            var calculatedAmount = (amount) * destinationCurrencyExchangeRate;

            lblResult.Text = $"{calculatedAmount}";
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temperature form1 = new Temperature(color2, form2);
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

        private void button2_Click(object sender, EventArgs e)
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

        private void Currency_KeyDown(object sender, KeyEventArgs e)
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

