namespace calculator_project
{
    partial class setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlSetting = new System.Windows.Forms.Panel();
            this.BtnFont = new System.Windows.Forms.Button();
            this.BackgroundButton = new System.Windows.Forms.Button();
            this.LblFonts = new System.Windows.Forms.Label();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblChangeTheme = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblBack = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDark = new System.Windows.Forms.RadioButton();
            this.BtnLight = new System.Windows.Forms.RadioButton();
            this.PnlSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting ";
            this.label1.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appearance";
            this.label2.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(126, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "App themes";
            this.label3.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(126, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select wich app themes setting to display";
            this.label4.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // PnlSetting
            // 
            this.PnlSetting.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlSetting.Controls.Add(this.BtnFont);
            this.PnlSetting.Controls.Add(this.BtnLight);
            this.PnlSetting.Controls.Add(this.BtnDark);
            this.PnlSetting.Controls.Add(this.label8);
            this.PnlSetting.Controls.Add(this.label6);
            this.PnlSetting.Controls.Add(this.BackgroundButton);
            this.PnlSetting.Controls.Add(this.LblFonts);
            this.PnlSetting.Controls.Add(this.LblColor);
            this.PnlSetting.Location = new System.Drawing.Point(39, 228);
            this.PnlSetting.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSetting.Name = "PnlSetting";
            this.PnlSetting.Size = new System.Drawing.Size(562, 327);
            this.PnlSetting.TabIndex = 5;
            this.PnlSetting.Visible = false;
            this.PnlSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSetting_Paint);
            this.PnlSetting.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // BtnFont
            // 
            this.BtnFont.BackColor = System.Drawing.Color.Silver;
            this.BtnFont.FlatAppearance.BorderSize = 0;
            this.BtnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFont.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFont.Location = new System.Drawing.Point(211, 136);
            this.BtnFont.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(133, 73);
            this.BtnFont.TabIndex = 26;
            this.BtnFont.Text = "Box Fonts";
            this.BtnFont.UseVisualStyleBackColor = false;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            this.BtnFont.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // BackgroundButton
            // 
            this.BackgroundButton.BackColor = System.Drawing.Color.Silver;
            this.BackgroundButton.FlatAppearance.BorderSize = 0;
            this.BackgroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundButton.Location = new System.Drawing.Point(30, 136);
            this.BackgroundButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackgroundButton.Name = "BackgroundButton";
            this.BackgroundButton.Size = new System.Drawing.Size(117, 73);
            this.BackgroundButton.TabIndex = 21;
            this.BackgroundButton.Text = "Box Colors";
            this.BackgroundButton.UseVisualStyleBackColor = false;
            this.BackgroundButton.Click += new System.EventHandler(this.BackgroundButton_Click);
            this.BackgroundButton.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // LblFonts
            // 
            this.LblFonts.BackColor = System.Drawing.Color.Transparent;
            this.LblFonts.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFonts.ForeColor = System.Drawing.Color.Black;
            this.LblFonts.Location = new System.Drawing.Point(205, 46);
            this.LblFonts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFonts.Name = "LblFonts";
            this.LblFonts.Size = new System.Drawing.Size(99, 38);
            this.LblFonts.TabIndex = 7;
            this.LblFonts.Text = "Font  : ";
            this.LblFonts.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // LblColor
            // 
            this.LblColor.BackColor = System.Drawing.Color.Transparent;
            this.LblColor.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.ForeColor = System.Drawing.Color.Black;
            this.LblColor.Location = new System.Drawing.Point(37, 46);
            this.LblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(131, 38);
            this.LblColor.TabIndex = 6;
            this.LblColor.Text = "Back Color  : ";
            this.LblColor.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // LblChangeTheme
            // 
            this.LblChangeTheme.BackColor = System.Drawing.Color.Gainsboro;
            this.LblChangeTheme.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangeTheme.ForeColor = System.Drawing.Color.White;
            this.LblChangeTheme.Location = new System.Drawing.Point(39, 127);
            this.LblChangeTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblChangeTheme.Name = "LblChangeTheme";
            this.LblChangeTheme.Size = new System.Drawing.Size(562, 96);
            this.LblChangeTheme.TabIndex = 6;
            this.LblChangeTheme.Click += new System.EventHandler(this.LblChangeTheme_Click);
            this.LblChangeTheme.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Silver;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(498, 31);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(103, 60);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.BtnBack.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // LblBack
            // 
            this.LblBack.BackColor = System.Drawing.Color.Transparent;
            this.LblBack.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBack.ForeColor = System.Drawing.Color.White;
            this.LblBack.Image = ((System.Drawing.Image)(resources.GetObject("LblBack.Image")));
            this.LblBack.Location = new System.Drawing.Point(16, 0);
            this.LblBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBack.Name = "LblBack";
            this.LblBack.Size = new System.Drawing.Size(64, 38);
            this.LblBack.TabIndex = 13;
            this.LblBack.Click += new System.EventHandler(this.LblBack_Click);
            this.LblBack.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 56);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dark";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 56);
            this.label8.TabIndex = 23;
            this.label8.Text = "Light";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // BtnDark
            // 
            this.BtnDark.AutoSize = true;
            this.BtnDark.Location = new System.Drawing.Point(386, 129);
            this.BtnDark.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDark.Name = "BtnDark";
            this.BtnDark.Size = new System.Drawing.Size(14, 13);
            this.BtnDark.TabIndex = 24;
            this.BtnDark.TabStop = true;
            this.BtnDark.UseVisualStyleBackColor = true;
            this.BtnDark.Click += new System.EventHandler(this.BtnDark_Click);
            this.BtnDark.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // BtnLight
            // 
            this.BtnLight.AutoSize = true;
            this.BtnLight.Location = new System.Drawing.Point(386, 194);
            this.BtnLight.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLight.Name = "BtnLight";
            this.BtnLight.Size = new System.Drawing.Size(14, 13);
            this.BtnLight.TabIndex = 25;
            this.BtnLight.TabStop = true;
            this.BtnLight.UseVisualStyleBackColor = true;
            this.BtnLight.Click += new System.EventHandler(this.BtnLight_Click);
            this.BtnLight.MouseHover += new System.EventHandler(this.AllMouse_);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(645, 596);
            this.Controls.Add(this.LblBack);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PnlSetting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblChangeTheme);
            this.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.setting_Load);
            this.MouseHover += new System.EventHandler(this.AllMouse_);
            this.PnlSetting.ResumeLayout(false);
            this.PnlSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PnlSetting;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblFonts;
        private System.Windows.Forms.Label LblChangeTheme;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BackgroundButton;
        private System.Windows.Forms.Label LblBack;
        private System.Windows.Forms.Button BtnFont;
        private System.Windows.Forms.RadioButton BtnLight;
        private System.Windows.Forms.RadioButton BtnDark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}