using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;

namespace calculator_project
{
    public partial class Weight : Form
    {
        public static Color color1;
        public static Font font1;
        public Weight(Color color, string style)
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
        decimal Display = 0;
        decimal convert = 0;
        double ounces = 141.7476;
        double pound = 2267.962;
        double stone = 31751.47;
        double ShortTons = 4535924;
        double LongTons = 5080235;

        double Ounces = 35.27396;
        double Pounds = 2.204623;
        double Stones = 0.157473;
        double shorttons = 0.001102311;
        double longtons = 0.000984207;

        bool enter_value = false;

        Color color2;
        string form2;

        void Calc()
        {
            if (x == 1)
            {
                if (LblUnit1.Text == "Carats ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);

                    switch (LblUnit2.Text)
                    {
                        case "Miligrams ˅": convert = Display * 200; break;

                        case "Centigrams ˅": convert = Display * 20; break;

                        case "Decigrams ˅":  convert = Display * 2; break;

                        case "Grams ˅":      convert = Display / 5; break;

                        case "Dekagrams ˅":  convert = Display / 50; break;

                        case "Hectograms ˅": convert = Display / 500; break;

                        case "Kilograms ˅": convert = Display / 5000; break;

                        case "Metric tonnes ˅": convert = Display / 5000000; break;

                        case "Ounces ˅":   convert = Display * Convert.ToDecimal(Ounces * 0.0002); break;

                        case "Pounds ˅":   convert = Display * Convert.ToDecimal(Pounds * 0.0002);  break;

                        case "Stone ˅":   convert = Display * Convert.ToDecimal(Stones * 0.0002); break;

                        case "Short tons (US) ˅":  convert = Display * Convert.ToDecimal(shorttons * 0.0002); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons * 0.0002);   break;
                    }
                }
                else if (LblUnit1.Text == "Miligrams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);

                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":  convert = Display / 200;  break;

                        case "Centigrams ˅":  convert = Display / 10;  break;

                        case "Decigrams ˅":  convert = Display / 100;  break;

                        case "Grams ˅":    convert = Display / 1000;   break;

                        case "Dekagrams ˅":  convert = Display / 10000; break;

                        case "Hectograms ˅":  convert = Display / 100000;  break;

                        case "Kilograms ˅":   convert = Display / 1000000; break;

                        case "Metric tonnes ˅": convert = Display / 1000000000; break;

                        case "Ounces ˅":   convert = Display * Convert.ToDecimal(Ounces / 1000000); break;

                        case "Pounds ˅":  convert = Display * Convert.ToDecimal(Pounds / 1000000); break;

                        case "Stone ˅":   convert = Display * Convert.ToDecimal(Stones / 1000000);  break;

                        case "Short tons (US) ˅":  convert = Display * Convert.ToDecimal(shorttons / 1000000); break;

                        case "Long tons (UK) ˅":   convert = Display * Convert.ToDecimal(longtons / 1000000); break;
                    }

                }
                else if (LblUnit1.Text == "Centigrams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);

                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":   convert = Display / 20;  break;

                        case "Miligrams ˅": convert = Display * 10; break;

                        case "Decigrams ˅": convert = Display / 10; break;

                        case "Grams ˅":  convert = Display / 100; break;

                        case "Dekagrams ˅": convert = Display / 1000;break;

                        case "Hectograms ˅":convert = Display / 10000;break;

                        case "Kilograms ˅":convert = Display / 100000;break;

                        case "Metric tonnes ˅": convert = Display / 100000000;break;

                        case "Ounces ˅":convert = Display * Convert.ToDecimal(Ounces / 100000);break;

                        case "Pounds ˅":convert = Display * Convert.ToDecimal(Pounds / 100000);break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(Stones / 100000);break;

                        case "Short tons (US) ˅":convert = Display * Convert.ToDecimal(shorttons / 100000);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(longtons / 100000);break;
                    }
                }
                else if (LblUnit1.Text == "Decigrams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":   convert = Display / 2; break;

                        case "Miligrams ˅": convert = Display * 100; break;

                        case "Centigrams ˅":convert = Display * 10; break;

                        case "Grams ˅":  convert = Display / 10;  break;

                        case "Dekagrams ˅":  convert = Display / 100;break;

                        case "Hectograms ˅": convert = Display / 1000;break;

                        case "Kilograms ˅": convert = Display / 10000;break;

                        case "Metric tonnes ˅":convert = Display / 10000000;break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces / 10000);break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds / 10000);break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(Stones / 10000);break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons / 10000);break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons / 10000);break;
                    }
                }
                else if (LblUnit1.Text == "Grams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * 5;break;

                        case "Miligrams ˅":convert = Display * 1000;break;

                        case "Centigrams ˅":convert = Display * 100;break;

                        case "Decigrams ˅":convert = Display * 10;break;

                        case "Dekagrams ˅":convert = Display / 10;break;

                        case "Hectograms ˅":convert = Display / 100;break;

                        case "Kilograms ˅":convert = Display / 1000;break;

                        case "Metric tonnes ˅":convert = Display / 1000000;break;

                        case "Ounces ˅":convert = Display * Convert.ToDecimal(Ounces / 1000);break;

                        case "Pounds ˅":convert = Display * Convert.ToDecimal(Pounds / 1000);break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(Stones / 1000);break;

                        case "Short tons (US) ˅":convert = Display * Convert.ToDecimal(shorttons / 1000);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(longtons / 1000);break;
                    }
                }
                else if (LblUnit1.Text == "Dekagrams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * 50;break;

                        case "Miligrams ˅":convert = Display * 10000;break;

                        case "Centigrams ˅":convert = Display * 1000;break;

                        case "Decigrams ˅":convert = Display * 100;break;

                        case "Grams ˅":convert = Display * 10;break;

                        case "Hectograms ˅":convert = Display / 10;break;

                        case "Kilograms ˅":convert = Display / 100;break;

                        case "Metric tonnes ˅":convert = Display / 100000;break;

                        case "Ounces ˅":convert = Display * Convert.ToDecimal(Ounces / 100);break;

                        case "Pounds ˅":convert = Display * Convert.ToDecimal(Pounds / 100);break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(Stones / 100);break;

                        case "Short tons (US) ˅":convert = Display * Convert.ToDecimal(shorttons / 100);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(longtons / 100);break;
                    }
                }
                else if (LblUnit1.Text == "Hectograms ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * 500;break;

                        case "Miligrams ˅":convert = Display * 100000;break;

                        case "Centigrams ˅": convert = Display * 10000;break;

                        case "Decigrams ˅":convert = Display * 1000;break;

                        case "Grams ˅":convert = Display * 100;break;

                        case "Dekagrams ˅":convert = Display * 10;break;

                        case "Kilograms ˅":convert = Display / 10;break;

                        case "Metric tonnes ˅":convert = Display / 10000;break;

                        case "Ounces ˅":convert = Display * Convert.ToDecimal(Ounces / 10);break;

                        case "Pounds ˅":convert = Display * Convert.ToDecimal(Pounds / 10);break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(Stones / 10);break;

                        case "Short tons (US) ˅":convert = Display * Convert.ToDecimal(shorttons / 10);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(longtons / 10);break;
                    }
                }
                else if (LblUnit1.Text == "Kilograms ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * 5000;break;

                        case "Miligrams ˅":convert = Display * 1000000;break;

                        case "Centigrams ˅":convert = Display * 100000;break;

                        case "Decigrams ˅":convert = Display * 10000;break;

                        case "Grams ˅":convert = Display * 1000;break;

                        case "Dekagrams ˅":convert = Display * 100;break;

                        case "Hectograms ˅":convert = Display * 10;break;

                        case "Metric tonnes ˅":convert = Display / 1000;break;

                        case "Ounces ˅":convert = Display * Convert.ToDecimal(Ounces);break;

                        case "Pounds ˅":convert = Display * Convert.ToDecimal(Pounds);break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(Stones);break;

                        case "Short tons (US) ˅":convert = Display * Convert.ToDecimal(shorttons);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(longtons);break;
                    }
                }
                else if (LblUnit1.Text == "Metric tonnes ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);

                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * 5000000;break;

                        case "Miligrams ˅":convert = Display * 1000000000;break;

                        case "Centigrams ˅":convert = Display * 100000000;break;

                        case "Decigrams ˅":convert = Display * 10000000;break;

                        case "Grams ˅":convert = Display * 1000000;break;

                        case "Dekagrams ˅":  convert = Display * 100000;break;

                        case "Hectograms ˅":convert = Display * 10000;break;

                        case "Kilograms ˅":convert = Display * 1000;break;

                        case "Ounces ˅":convert = Display * Convert.ToDecimal(Ounces * 1000);break;

                        case "Pounds ˅":convert = Display * Convert.ToDecimal(Pounds * 1000);break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(Stones * 1000);break;

                        case "Short tons (US) ˅":       convert = Display * Convert.ToDecimal(shorttons * 1000);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(longtons * 1000);break;
                    }

                }
                else if (LblUnit1.Text == "Ounces ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * Convert.ToDecimal(ounces);break;

                        case "Miligrams ˅":convert = Display * Convert.ToDecimal(ounces * 200);break;

                        case "Centigrams ˅":convert = Display * Convert.ToDecimal(ounces * 20); break;

                        case "Decigrams ˅":convert = Display * Convert.ToDecimal(ounces * 2);break;

                        case "Grams ˅":convert = Display * Convert.ToDecimal(ounces / 5);break;

                        case "Dekagrams ˅":convert = Display * Convert.ToDecimal(ounces / 50);break;

                        case "Hectograms ˅":convert = Display * Convert.ToDecimal(ounces / 500);break;

                        case "Kilograms ˅":convert = Display * Convert.ToDecimal(ounces / 5000);break;

                        case "Metric tonnes ˅":convert = Display * Convert.ToDecimal(ounces / 5000000);break;

                        case "Pounds ˅":convert = Display / 16;break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(0.004464);break;

                        case "Short tons (US) ˅":convert = Display * Convert.ToDecimal(0.000031);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(0.000028);break;
                    }
                }
                else if (LblUnit1.Text == "Pounds ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * Convert.ToDecimal(pound);break;

                        case "Miligrams ˅":convert = Display * Convert.ToDecimal(pound * 200);break;

                        case "Centigrams ˅": convert = Display * Convert.ToDecimal(pound * 20);break;

                        case "Decigrams ˅":convert = Display * Convert.ToDecimal(pound * 2);break;

                        case "Grams ˅":convert = Display * Convert.ToDecimal(pound / 5);break;

                        case "Dekagrams ˅":convert = Display * Convert.ToDecimal(pound / 50);break;

                        case "Hectograms ˅":
                            convert = Display * Convert.ToDecimal(pound / 500);break;

                        case "Kilograms ˅":convert = Display * Convert.ToDecimal(pound / 5000);break;

                        case "Metric tonnes ˅":convert = Display * Convert.ToDecimal(pound / 5000000);break;

                        case "Ounces ˅":convert = Display * 16;break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(0.071429);break;

                        case "Short tons (US) ˅":convert = Display * Convert.ToDecimal(0.00005);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(0.000446);break;
                    }
                }
                else if (LblUnit1.Text == "Stone ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * Convert.ToDecimal(stone);break;

                        case "Miligrams ˅":convert = Display * Convert.ToDecimal(stone * 200);break;

                        case "Centigrams ˅":convert = Display * Convert.ToDecimal(stone * 20);break;

                        case "Decigrams ˅":convert = Display * Convert.ToDecimal(stone * 2);break;

                        case "Grams ˅":convert = Display * Convert.ToDecimal(stone / 5);break;

                        case "Dekagrams ˅":convert = Display * Convert.ToDecimal(stone / 50);break;

                        case "Hectograms ˅":convert = Display * Convert.ToDecimal(stone / 500);break;

                        case "Kilograms ˅":convert = Display * Convert.ToDecimal(stone / 5000); break;

                        case "Metric tonnes ˅":convert = Display * Convert.ToDecimal(stone / 5000000);break;

                        case "Ounces ˅":convert = Display * 224;break;

                        case "Pounds ˅":convert = Display * 14;break;

                        case "Short tons (US) ˅":convert = Display * Convert.ToDecimal(0.007);break;

                        case "Long tons (UK) ˅":convert = Display / 160;break;
                    }
                }
                else if (LblUnit1.Text == "Short tons (US) ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅":convert = Display * Convert.ToDecimal(ShortTons);break;

                        case "Miligrams ˅":convert = Display * Convert.ToDecimal(ShortTons * 200);break;

                        case "Centigrams ˅":convert = Display * Convert.ToDecimal(ShortTons * 20);break;

                        case "Decigrams ˅":convert = Display * Convert.ToDecimal(ShortTons * 2);break;

                        case "Grams ˅":convert = Display * Convert.ToDecimal(ShortTons / 5);break;

                        case "Dekagrams ˅":convert = Display * Convert.ToDecimal(ShortTons / 50);break;

                        case "Hectograms ˅":convert = Display * Convert.ToDecimal(ShortTons / 500);break;

                        case "Kilograms ˅":convert = Display * Convert.ToDecimal(ShortTons / 5000);break;

                        case "Metric tonnes ˅":convert = Display * Convert.ToDecimal(ShortTons / 5000000);break;

                        case "Ounces ˅":convert = Display * 32000;break;

                        case "Pounds ˅":convert = Display * 2000;break;

                        case "Stone ˅":convert = Display * Convert.ToDecimal(142.8571);break;

                        case "Long tons (UK) ˅":convert = Display * Convert.ToDecimal(0.892857);break;
                    }
                }
                else if (LblUnit1.Text == "Long tons (UK) ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay1.Text);
                    switch (LblUnit2.Text)
                    {
                        case "Carats ˅": convert = Display * Convert.ToDecimal(LongTons); break;

                        case "Miligrams ˅": convert = Display * Convert.ToDecimal(LongTons * 200);break;

                        case "Centigrams ˅":convert = Display * Convert.ToDecimal(LongTons * 20);break;

                        case "Decigrams ˅":convert = Display * Convert.ToDecimal(LongTons * 2);break;

                        case "Grams ˅":convert = Display * Convert.ToDecimal(LongTons / 5); break;

                        case "Dekagrams ˅":convert = Display * Convert.ToDecimal(LongTons / 50);break;

                        case "Hectograms ˅":convert = Display * Convert.ToDecimal(LongTons / 500);break;

                        case "Kilograms ˅":convert = Display * Convert.ToDecimal(LongTons / 5000);break;

                        case "Metric tonnes ˅":convert = Display * Convert.ToDecimal(LongTons / 5000000);break;

                        case "Ounces ˅":convert = Display * 35840;break;

                        case "Pounds ˅":convert = Display * 2240;break;

                        case "Stone ˅":convert = Display * 160;break;

                        case "Short tons (UK) ˅":convert = Display * Convert.ToDecimal(1.12);break;
                    }
                }
                LblDisplay2.Text = convert.ToString();
            }
            else if (x == 2)
            {
                if (LblUnit2.Text == "Carats ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);

                    switch (LblUnit1.Text)
                    {
                        case "Miligrams ˅": convert = Display * 200; break;

                        case "Centigrams ˅": convert = Display * 20; break;

                        case "Decigrams ˅": convert = Display * 2; break;

                        case "Grams ˅": convert = Display / 5; break;

                        case "Dekagrams ˅": convert = Display / 50; break;

                        case "Hectograms ˅": convert = Display / 500; break;

                        case "Kilograms ˅": convert = Display / 5000; break;

                        case "Metric tonnes ˅": convert = Display / 5000000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces * 0.0002); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds * 0.0002); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones * 0.0002); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons * 0.0002); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons * 0.0002); break;
                    }
                }
                else if (LblUnit2.Text == "Miligrams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);

                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display / 200; break;

                        case "Centigrams ˅": convert = Display / 10; break;

                        case "Decigrams ˅": convert = Display / 100; break;

                        case "Grams ˅": convert = Display / 1000; break;

                        case "Dekagrams ˅": convert = Display / 10000; break;

                        case "Hectograms ˅": convert = Display / 100000; break;

                        case "Kilograms ˅": convert = Display / 1000000; break;

                        case "Metric tonnes ˅": convert = Display / 1000000000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces / 1000000); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds / 1000000); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones / 1000000); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons / 1000000); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons / 1000000); break;
                    }

                }
                else if (LblUnit2.Text == "Centigrams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);

                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display / 20; break;

                        case "Miligrams ˅": convert = Display * 10; break;

                        case "Decigrams ˅": convert = Display / 10; break;

                        case "Grams ˅": convert = Display / 100; break;

                        case "Dekagrams ˅": convert = Display / 1000; break;

                        case "Hectograms ˅": convert = Display / 10000; break;

                        case "Kilograms ˅": convert = Display / 100000; break;

                        case "Metric tonnes ˅": convert = Display / 100000000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces / 100000); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds / 100000); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones / 100000); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons / 100000); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons / 100000); break;
                    }
                }
                else if (LblUnit2.Text == "Decigrams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display / 2; break;

                        case "Miligrams ˅": convert = Display * 100; break;

                        case "Centigrams ˅": convert = Display * 10; break;

                        case "Grams ˅": convert = Display / 10; break;

                        case "Dekagrams ˅": convert = Display / 100; break;

                        case "Hectograms ˅": convert = Display / 1000; break;

                        case "Kilograms ˅": convert = Display / 10000; break;

                        case "Metric tonnes ˅": convert = Display / 10000000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces / 10000); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds / 10000); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones / 10000); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons / 10000); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons / 10000); break;
                    }
                }
                else if (LblUnit2.Text == "Grams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * 5; break;

                        case "Miligrams ˅": convert = Display * 1000; break;

                        case "Centigrams ˅": convert = Display * 100; break;

                        case "Decigrams ˅": convert = Display * 10; break;

                        case "Dekagrams ˅": convert = Display / 10; break;

                        case "Hectograms ˅": convert = Display / 100; break;

                        case "Kilograms ˅": convert = Display / 1000; break;

                        case "Metric tonnes ˅": convert = Display / 1000000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces / 1000); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds / 1000); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones / 1000); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons / 1000); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons / 1000); break;
                    }
                }
                else if (LblUnit2.Text == "Dekagrams ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * 50; break;

                        case "Miligrams ˅": convert = Display * 10000; break;

                        case "Centigrams ˅": convert = Display * 1000; break;

                        case "Decigrams ˅": convert = Display * 100; break;

                        case "Grams ˅": convert = Display * 10; break;

                        case "Hectograms ˅": convert = Display / 10; break;

                        case "Kilograms ˅": convert = Display / 100; break;

                        case "Metric tonnes ˅": convert = Display / 100000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces / 100); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds / 100); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones / 100); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons / 100); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons / 100); break;
                    }
                }
                else if (LblUnit2.Text == "Hectograms ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * 500; break;

                        case "Miligrams ˅": convert = Display * 100000; break;

                        case "Centigrams ˅": convert = Display * 10000; break;

                        case "Decigrams ˅": convert = Display * 1000; break;

                        case "Grams ˅": convert = Display * 100; break;

                        case "Dekagrams ˅": convert = Display * 10; break;

                        case "Kilograms ˅": convert = Display / 10; break;

                        case "Metric tonnes ˅": convert = Display / 10000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces / 10); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds / 10); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones / 10); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons / 10); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons / 10); break;
                    }
                }
                else if (LblUnit2.Text == "Kilograms ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * 5000; break;

                        case "Miligrams ˅": convert = Display * 1000000; break;

                        case "Centigrams ˅": convert = Display * 100000; break;

                        case "Decigrams ˅": convert = Display * 10000; break;

                        case "Grams ˅": convert = Display * 1000; break;

                        case "Dekagrams ˅": convert = Display * 100; break;

                        case "Hectograms ˅": convert = Display * 10; break;

                        case "Metric tonnes ˅": convert = Display / 1000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons); break;
                    }
                }
                else if (LblUnit2.Text == "Metric tonnes ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);

                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * 5000000; break;

                        case "Miligrams ˅": convert = Display * 1000000000; break;

                        case "Centigrams ˅": convert = Display * 100000000; break;

                        case "Decigrams ˅": convert = Display * 10000000; break;

                        case "Grams ˅": convert = Display * 1000000; break;

                        case "Dekagrams ˅": convert = Display * 100000; break;

                        case "Hectograms ˅": convert = Display * 10000; break;

                        case "Kilograms ˅": convert = Display * 1000; break;

                        case "Ounces ˅": convert = Display * Convert.ToDecimal(Ounces * 1000); break;

                        case "Pounds ˅": convert = Display * Convert.ToDecimal(Pounds * 1000); break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(Stones * 1000); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(shorttons * 1000); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(longtons * 1000); break;
                    }

                }
                else if (LblUnit2.Text == "Ounces ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * Convert.ToDecimal(ounces); break;

                        case "Miligrams ˅": convert = Display * Convert.ToDecimal(ounces * 200); break;

                        case "Centigrams ˅": convert = Display * Convert.ToDecimal(ounces * 20); break;

                        case "Decigrams ˅": convert = Display * Convert.ToDecimal(ounces * 2); break;

                        case "Grams ˅": convert = Display * Convert.ToDecimal(ounces / 5); break;

                        case "Dekagrams ˅": convert = Display * Convert.ToDecimal(ounces / 50); break;

                        case "Hectograms ˅": convert = Display * Convert.ToDecimal(ounces / 500); break;

                        case "Kilograms ˅": convert = Display * Convert.ToDecimal(ounces / 5000); break;

                        case "Metric tonnes ˅": convert = Display * Convert.ToDecimal(ounces / 5000000); break;

                        case "Pounds ˅": convert = Display / 16; break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(0.004464); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(0.000031); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(0.000028); break;
                    }
                }
                else if (LblUnit2.Text == "Pounds ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * Convert.ToDecimal(pound); break;

                        case "Miligrams ˅": convert = Display * Convert.ToDecimal(pound * 200); break;

                        case "Centigrams ˅": convert = Display * Convert.ToDecimal(pound * 20); break;

                        case "Decigrams ˅": convert = Display * Convert.ToDecimal(pound * 2); break;

                        case "Grams ˅": convert = Display * Convert.ToDecimal(pound / 5); break;

                        case "Dekagrams ˅": convert = Display * Convert.ToDecimal(pound / 50); break;

                        case "Hectograms ˅":
                            convert = Display * Convert.ToDecimal(pound / 500); break;

                        case "Kilograms ˅": convert = Display * Convert.ToDecimal(pound / 5000); break;

                        case "Metric tonnes ˅": convert = Display * Convert.ToDecimal(pound / 5000000); break;

                        case "Ounces ˅": convert = Display * 16; break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(0.071429); break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(0.00005); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(0.000446); break;
                    }
                }
                else if (LblUnit2.Text == "Stone ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * Convert.ToDecimal(stone); break;

                        case "Miligrams ˅": convert = Display * Convert.ToDecimal(stone * 200); break;

                        case "Centigrams ˅": convert = Display * Convert.ToDecimal(stone * 20); break;

                        case "Decigrams ˅": convert = Display * Convert.ToDecimal(stone * 2); break;

                        case "Grams ˅": convert = Display * Convert.ToDecimal(stone / 5); break;

                        case "Dekagrams ˅": convert = Display * Convert.ToDecimal(stone / 50); break;

                        case "Hectograms ˅": convert = Display * Convert.ToDecimal(stone / 500); break;

                        case "Kilograms ˅": convert = Display * Convert.ToDecimal(stone / 5000); break;

                        case "Metric tonnes ˅": convert = Display * Convert.ToDecimal(stone / 5000000); break;

                        case "Ounces ˅": convert = Display * 224; break;

                        case "Pounds ˅": convert = Display * 14; break;

                        case "Short tons (US) ˅": convert = Display * Convert.ToDecimal(0.007); break;

                        case "Long tons (UK) ˅": convert = Display / 160; break;
                    }
                }
                else if (LblUnit2.Text == "Short tons (US) ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * Convert.ToDecimal(ShortTons); break;

                        case "Miligrams ˅": convert = Display * Convert.ToDecimal(ShortTons * 200); break;

                        case "Centigrams ˅": convert = Display * Convert.ToDecimal(ShortTons * 20); break;

                        case "Decigrams ˅": convert = Display * Convert.ToDecimal(ShortTons * 2); break;

                        case "Grams ˅": convert = Display * Convert.ToDecimal(ShortTons / 5); break;

                        case "Dekagrams ˅": convert = Display * Convert.ToDecimal(ShortTons / 50); break;

                        case "Hectograms ˅": convert = Display * Convert.ToDecimal(ShortTons / 500); break;

                        case "Kilograms ˅": convert = Display * Convert.ToDecimal(ShortTons / 5000); break;

                        case "Metric tonnes ˅": convert = Display * Convert.ToDecimal(ShortTons / 5000000); break;

                        case "Ounces ˅": convert = Display * 32000; break;

                        case "Pounds ˅": convert = Display * 2000; break;

                        case "Stone ˅": convert = Display * Convert.ToDecimal(142.8571); break;

                        case "Long tons (UK) ˅": convert = Display * Convert.ToDecimal(0.892857); break;
                    }
                }
                else if (LblUnit2.Text == "Long tons (UK) ˅")
                {
                    Display = Convert.ToDecimal(LblDisplay2.Text);
                    switch (LblUnit1.Text)
                    {
                        case "Carats ˅": convert = Display * Convert.ToDecimal(LongTons); break;

                        case "Miligrams ˅": convert = Display * Convert.ToDecimal(LongTons * 200); break;

                        case "Centigrams ˅": convert = Display * Convert.ToDecimal(LongTons * 20); break;

                        case "Decigrams ˅": convert = Display * Convert.ToDecimal(LongTons * 2); break;

                        case "Grams ˅": convert = Display * Convert.ToDecimal(LongTons / 5); break;

                        case "Dekagrams ˅": convert = Display * Convert.ToDecimal(LongTons / 50); break;

                        case "Hectograms ˅": convert = Display * Convert.ToDecimal(LongTons / 500); break;

                        case "Kilograms ˅": convert = Display * Convert.ToDecimal(LongTons / 5000); break;

                        case "Metric tonnes ˅": convert = Display * Convert.ToDecimal(LongTons / 5000000); break;

                        case "Ounces ˅": convert = Display * 35840; break;

                        case "Pounds ˅": convert = Display * 2240; break;

                        case "Stone ˅": convert = Display * 160; break;

                        case "Short tons (UK) ˅": convert = Display * Convert.ToDecimal(1.12); break;
                    }
                }
                LblDisplay1.Text = convert.ToString();
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

        private void LblUnit1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void LblUnit2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void LblDisplay2_Click(object sender, EventArgs e)
        {
            x = 2;
            LblDisplay2.Font = new Font(LblDisplay2.Font, FontStyle.Bold);
            LblDisplay1.Font = new Font(LblDisplay1.Font, FontStyle.Regular);
            enter_value = true;
        }

        private void LblDisplay1_Click(object sender, EventArgs e)
        {
            x = 1;
            LblDisplay1.Font = new Font(LblDisplay1.Font, FontStyle.Bold);
            LblDisplay2.Font = new Font(LblDisplay2.Font, FontStyle.Regular);
            enter_value = true;
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

        private void BtnUnits_MouseHover(object sender, EventArgs e)
        {
       
        }

        private void BtnUnits_MouseLeave(object sender, EventArgs e)
        {
  
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if(x == 1)
            {
                LblDisplay1.Text = LblDisplay1.Text.Remove(LblDisplay1.Text.Length - 1);

                if (LblDisplay1.Text == "")
                {
                    LblDisplay1.Text = "0";
                }
            }
            else if(x == 2)
            {
                LblDisplay2.Text = LblDisplay2.Text.Remove(LblDisplay2.Text.Length - 1);

                if (LblDisplay2.Text == "")
                {
                    LblDisplay2.Text = "0";
                }
            }
            Calc();

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LblDisplay1.Text = "0";
            LblDisplay2.Text = "0";
            enter_value = true;
        }

        private void Weight_Click(object sender, EventArgs e)
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

        private void Weight_KeyDown(object sender, KeyEventArgs e)
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

        private void TimerCalc_Tick(object sender, EventArgs e)
        {
            Calc();
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

        private void button36_Click(object sender, EventArgs e)
        {
            this.Hide();
            Currency form = new Currency(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volume form = new Volume(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Hide();
            Length form = new Length(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weight form = new Weight(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temperature form = new Temperature(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {

            this.Hide();
            Speed form = new Speed(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer form = new Timer(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Hide();
            setting form = new setting(color2, form2);
            form.Font = font1;
            form.BackColor = this.BackColor;
            form.ShowDialog();
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

  
    }
}
