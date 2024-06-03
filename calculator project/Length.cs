using System;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace calculator_project
{
    public partial class Length : Form
    {
        public static Color color1;
        public static Font font1;

        public Length(Color color, string style)
        {
            InitializeComponent();

            this.BackColor = color1;

            if(font1 != null)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is System.Windows.Forms.Button || c is System.Windows.Forms.Label || c is System.Windows.Forms.Panel)
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
        decimal convert = 0;
        decimal Display = 0;
        double inches = 39.37008;
        double feet = 3.28084;
        double yards = 1.093613;
        double miles = 0.621371;
        double Nmiles = 0.539957;

        double Inches = 0.0254;
        double Feet = 0.3048;
        double Yards = 0.9144;
        double Miles = 1609.344;
        double NMiles = 1852;

        Color color2;
        string form2 = "";
        bool enter_value = false;

        void calc()
        {
            if(x == 1)
            {
                Display = Convert.ToDecimal(LblDisplay1.Text);

                if (LblUnit1.Text == "Nanometers ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Microns ˅":  
                            convert = Display / 1000;
                            break;

                        case "Millimeters ˅":
                            convert = Display / 1000000;
                            break;

                        case "Centimeters ˅":
                            convert = Display / 10000000;
                            break;

                        case "Meters ˅":
                            convert = Display / 1000000000;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 1000000000000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches / 1000000000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet / 1000000000);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards / 1000000000);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles / 1000000000);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles / 1000000000);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Microns ˅")
                {
                    switch (LblUnit2.Text)
                    {                
                        case "Nanometers ˅":
                            convert = Display * 1000;
                            break;

                        case "Millimeters ˅":
                            convert = Display / 1000;
                            break;

                        case "Centimeters ˅":
                            convert = Display / 10000;
                            break;

                        case "Meters ˅":
                            convert = Display / 1000000;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 1000000000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches / 1000000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet / 1000000);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards / 1000000);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles / 1000000);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles / 1000000);

                            break;
                    }
                }
                else if (LblUnit1.Text == "Millimeters ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":            
                            convert = Display * 1000000;
                            break;

                        case "Microns ˅":
                            convert = Display * 1000;
                            break;

                        case "Centimeters ˅":
                            convert = Display / 10;
                            break;

                        case "Meters ˅":
                            convert = Display / 1000;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 1000000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches / 1000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet / 1000);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards / 1000);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles / 1000);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles / 1000);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Centimeters ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":            
                            convert = Display * 10000000;
                            break;

                        case "Microns ˅":
                            convert = Display * 10000;
                            break;

                        case "Millimeters ˅":
                            convert = Display * 10;
                            break;

                        case "Meters ˅":
                            convert = Display / 100;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 100000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches / 100);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet / 100);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards / 100);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles / 100);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles / 100);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Meters ˅")
                {      
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * 1000000000;
                            break;

                        case "Microns ˅":
                            convert = Display * 1000000;
                            break;

                        case "Millimeters ˅":
                            convert = Display * 1000;
                            break;

                        case "Centimeters ˅":
                            convert = Display * 100;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 1000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Kilometers ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * 1000000000000;
                            break;

                        case "Microns ˅":
                            convert = Display * 1000000000;
                            break;

                        case "Millimeters ˅":
                            convert = Display * 1000000;
                            break;

                        case "Centimeters ˅":
                            convert = Display * 100000;
                            break;

                        case "Meters ˅":
                            convert = Display * 1000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches * 1000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet * 1000);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards * 1000);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles * 1000);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles* 1000);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Inches ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(Inches * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(Inches * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(Inches * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(Inches * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(Inches);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(Inches / 1000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(1 / 12);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(1 / 36);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(0.000016);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(0.000014);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Feet ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(Feet * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(Feet * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(Feet * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(Feet * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(Feet);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(Feet / 1000);
                            break;

                        case "Inches ˅":
                            convert = Display * 12;
                            break;

                        case "Yards ˅":
                            convert = Display / 3;
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(0.000189);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(0.000165);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Yards ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(Yards * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(Yards * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(Yards * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(Yards * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(Yards);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(Yards / 1000);
                            break;

                        case "Inches ˅":
                            convert = Display * 36;
                            break;

                        case "Feet ˅":
                            convert = Display * 12;
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(0.000568);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(0.000494);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Miles ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(Miles * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(Miles * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(Miles * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(Miles * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(Miles);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(Miles / 1000);
                            break;

                        case "Inches ˅":
                            convert = Display * 63360;
                            break;

                        case "Feet ˅":
                            convert = Display * 5280;
                            break;

                        case "Yards ˅":
                            convert = Display * 1760;
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(0.868976);
                            break;
                    }
                }
                else if (LblUnit1.Text == "Nautical miles ˅")
                {
                    switch (LblUnit2.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(NMiles * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(NMiles * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(NMiles * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(NMiles * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(NMiles);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(NMiles / 1000);
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(72913.39);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(6076.115);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(2025.372);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(1.150779);
                            break;
                    }
                }
                LblDisplay2.Text = convert.ToString();
            }
            else if (x == 2)
            {
                Display = Convert.ToDecimal(LblDisplay2.Text);

                if (LblUnit2.Text == "Nanometers ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Microns ˅":
                            convert = Display / 1000;
                            break;

                        case "Millimeters ˅":
                            convert = Display / 1000000;
                            break;

                        case "Centimeters ˅":
                            convert = Display / 10000000;
                            break;

                        case "Meters ˅":
                            convert = Display / 1000000000;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 1000000000000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches / 1000000000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet / 1000000000);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards / 1000000000);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles / 1000000000);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles / 1000000000);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Microns ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * 1000;
                            break;

                        case "Millimeters ˅":
                            convert = Display / 1000;
                            break;

                        case "Centimeters ˅":
                            convert = Display / 10000;
                            break;

                        case "Meters ˅":
                            convert = Display / 1000000;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 1000000000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches / 1000000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet / 1000000);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards / 1000000);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles / 1000000);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles / 1000000);

                            break;
                    }
                }
                else if (LblUnit2.Text == "Millimeters ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * 1000000;
                            break;

                        case "Microns ˅":
                            convert = Display * 1000;
                            break;

                        case "Centimeters ˅":
                            convert = Display / 10;
                            break;

                        case "Meters ˅":
                            convert = Display / 1000;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 1000000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches / 1000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet / 1000);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards / 1000);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles / 1000);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles / 1000);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Centimeters ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * 10000000;
                            break;

                        case "Microns ˅":
                            convert = Display * 10000;
                            break;

                        case "Millimeters ˅":
                            convert = Display * 10;
                            break;

                        case "Meters ˅":
                            convert = Display / 100;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 100000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches / 100);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet / 100);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards / 100);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles / 100);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles / 100);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Meters ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * 1000000000;
                            break;

                        case "Microns ˅":
                            convert = Display * 1000000;
                            break;

                        case "Millimeters ˅":
                            convert = Display * 1000;
                            break;

                        case "Centimeters ˅":
                            convert = Display * 100;
                            break;

                        case "Kilometers ˅":
                            convert = Display / 1000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Kilometers ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * 1000000000000;
                            break;

                        case "Microns ˅":
                            convert = Display * 1000000000;
                            break;

                        case "Millimeters ˅":
                            convert = Display * 1000000;
                            break;

                        case "Centimeters ˅":
                            convert = Display * 100000;
                            break;

                        case "Meters ˅":
                            convert = Display * 1000;
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(inches * 1000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(feet * 1000);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(yards * 1000);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(miles * 1000);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(Nmiles * 1000);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Inches ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(Inches * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(Inches * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(Inches * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(Inches * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(Inches);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(Inches / 1000);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(1 / 12);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(1 / 36);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(0.000016);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(0.000014);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Feet ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(Feet * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(Feet * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(Feet * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(Feet * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(Feet);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(Feet / 1000);
                            break;

                        case "Inches ˅":
                            convert = Display * 12;
                            break;

                        case "Yards ˅":
                            convert = Display / 3;
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(0.000189);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(0.000165);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Yards ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(Yards * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(Yards * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(Yards * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(Yards * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(Yards);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(Yards / 1000);
                            break;

                        case "Inches ˅":
                            convert = Display * 36;
                            break;

                        case "Feet ˅":
                            convert = Display * 12;
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(0.000568);
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(0.000494);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Miles ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(Miles * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(Miles * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(Miles * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(Miles * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(Miles);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(Miles / 1000);
                            break;

                        case "Inches ˅":
                            convert = Display * 63360;
                            break;

                        case "Feet ˅":
                            convert = Display * 5280;
                            break;

                        case "Yards ˅":
                            convert = Display * 1760;
                            break;

                        case "Nautical miles ˅":
                            convert = Display * Convert.ToDecimal(0.868976);
                            break;
                    }
                }
                else if (LblUnit2.Text == "Nautical miles ˅")
                {
                    switch (LblUnit1.Text)
                    {
                        case "Nanometers ˅":
                            convert = Display * Convert.ToDecimal(NMiles * 1000000000);
                            break;

                        case "Microns ˅":
                            convert = Display * Convert.ToDecimal(NMiles * 1000000);
                            break;

                        case "Millimeters ˅":
                            convert = Display * Convert.ToDecimal(NMiles * 1000);
                            break;

                        case "Centimeters ˅":
                            convert = Display * Convert.ToDecimal(NMiles * 100);
                            break;

                        case "Meters ˅":
                            convert = Display * Convert.ToDecimal(NMiles);
                            break;

                        case "Kilometers ˅":
                            convert = Display * Convert.ToDecimal(NMiles / 1000);
                            break;

                        case "Inches ˅":
                            convert = Display * Convert.ToDecimal(72913.39);
                            break;

                        case "Feet ˅":
                            convert = Display * Convert.ToDecimal(6076.115);
                            break;

                        case "Yards ˅":
                            convert = Display * Convert.ToDecimal(2025.372);
                            break;

                        case "Miles ˅":
                            convert = Display * Convert.ToDecimal(1.150779);
                            break;
                    }
                }
                LblDisplay1.Text = convert.ToString();
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
            calc();
        }

        private void LblDisplay1_Click(object sender, EventArgs e)
        {
            x = 1;
            LblDisplay1.Font = new Font(LblDisplay1.Font, FontStyle.Bold);
            LblDisplay2.Font = new Font(LblDisplay2.Font, FontStyle.Regular);
            enter_value = true;
        }

        private void LblDisplay2_Click(object sender, EventArgs e)
        {
            x = 2;
            LblDisplay2.Font = new Font(LblDisplay2.Font, FontStyle.Bold);
            LblDisplay1.Font = new Font(LblDisplay1.Font, FontStyle.Regular);
            enter_value = true;
        }

        private void BtnUnits_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btnUnit1 = (System.Windows.Forms.Button)sender;
            LblUnit1.Text = btnUnit1.Text + " ˅";
            panel1.Visible = false;
        }

        private void BtnUnit2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btnUnit2 = (System.Windows.Forms.Button)sender;
            LblUnit2.Text = btnUnit2.Text + " ˅";
            panel2.Visible = false;
        }

        private void LblUnit1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void LblUnit2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void BtnsMouseHover(object sender, EventArgs e)
        {
   
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
          
        }

        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btnNum = (System.Windows.Forms.Button)sender;

            if(x == 1)
            {
                if (enter_value || LblDisplay1.Text == "0")
                {
                    LblDisplay1.Text = "";
                    enter_value = false;
                }
            }
            else if(x == 2)
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
            else if(x == 2) 
            {
                if(btnNum.Text == ".")
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

        private void Length_Click(object sender, EventArgs e)
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

        private void Length_KeyDown(object sender, KeyEventArgs e)
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
     
        private void BtnStandard1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Standard form1 = new Standard(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void BtnProgrammer1_Click(object sender, EventArgs e)
        {
            this.Hide();
            programmer form1 = new programmer(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {

            this.Hide();
            Currency form1 = new Currency(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volume form1 = new Volume(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Hide();
            Length form1 = new Length(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weight form1 = new Weight(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temperature form1 = new Temperature(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speed form1 = new Speed(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer form1 = new Timer(color2, form2);
            form1.Font = this.Font;
            form1.BackColor = this.BackColor;
            form1.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
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
                    if (c is System.Windows.Forms.Button || c is System.Windows.Forms.Panel)
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
                    if (c is System.Windows.Forms.Button || c is System.Windows.Forms.Panel)
                    {
                        c.BackColor = ColorTranslator.FromHtml("#464650");
                    }
                    BtnBackSpace.BackColor = ColorTranslator.FromHtml("#32323C");
                    BtnClear.BackColor = ColorTranslator.FromHtml("#32323C");
                    c.ForeColor = Color.White;
                }
            }
        }

        private void TimeCalc_Tick(object sender, EventArgs e)
        {

            calc();
            if (LblUnit1.Text == LblUnit2.Text && x == 1)
            {
                LblDisplay2.Text = LblDisplay1.Text;
            }
            else if(LblUnit1.Text == LblUnit2.Text && x == 2)
            {
                LblDisplay1.Text = LblDisplay2.Text;
            }
        }
    }
}