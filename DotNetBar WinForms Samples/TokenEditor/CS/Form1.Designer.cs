namespace TokenEditorDemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tokenEmails = new DevComponents.DotNetBar.Controls.TokenEditor();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tokenEditor1 = new DevComponents.DotNetBar.Controls.TokenEditor();
            this.warningBox1 = new DevComponents.DotNetBar.Controls.WarningBox();
            this.SuspendLayout();
            // 
            // tokenEmails
            // 
            // 
            // 
            // 
            this.tokenEmails.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tokenEmails.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tokenEmails.Location = new System.Drawing.Point(12, 30);
            this.tokenEmails.MaxHeightLines = 3;
            this.tokenEmails.Name = "tokenEmails";
            this.tokenEmails.Separators.Add(";");
            this.tokenEmails.Separators.Add(",");
            this.tokenEmails.Size = new System.Drawing.Size(348, 21);
            this.tokenEmails.TabIndex = 0;
            this.tokenEmails.ValidateToken += new DevComponents.DotNetBar.Controls.ValidateTokenEventHandler(this.tokenEmails_ValidateToken);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(221, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "E-mail address entry:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 104);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(348, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Keywords separated by comma or semicolon entry:";
            // 
            // tokenEditor1
            // 
            // 
            // 
            // 
            this.tokenEditor1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tokenEditor1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tokenEditor1.Location = new System.Drawing.Point(12, 130);
            this.tokenEditor1.MaxHeightLines = 3;
            this.tokenEditor1.Name = "tokenEditor1";
            this.tokenEditor1.Separators.Add(";");
            this.tokenEditor1.Separators.Add(",");
            this.tokenEditor1.Size = new System.Drawing.Size(348, 21);
            this.tokenEditor1.TabIndex = 2;
            this.tokenEditor1.ValidateToken += new DevComponents.DotNetBar.Controls.ValidateTokenEventHandler(this.tokenEditor1_ValidateToken);
            // 
            // warningBox1
            // 
            this.warningBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.warningBox1.CloseButtonVisible = false;
            this.warningBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.warningBox1.Image = ((System.Drawing.Image)(resources.GetObject("warningBox1.Image")));
            this.warningBox1.Location = new System.Drawing.Point(0, 263);
            this.warningBox1.Name = "warningBox1";
            this.warningBox1.OptionsText = "Read Now...";
            this.warningBox1.Size = new System.Drawing.Size(372, 33);
            this.warningBox1.TabIndex = 4;
            this.warningBox1.Text = "Getting started with TokenEditor control";
            this.warningBox1.OptionsClick += new System.EventHandler(this.warningBox1_OptionsClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(372, 296);
            this.Controls.Add(this.warningBox1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tokenEditor1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tokenEmails);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Token Editor Control Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TokenEditor tokenEmails;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TokenEditor tokenEditor1;
        private DevComponents.DotNetBar.Controls.WarningBox warningBox1;
    }
}

