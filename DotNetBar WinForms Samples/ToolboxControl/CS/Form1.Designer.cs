namespace ToolboxControlSample
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
            this.toolboxControl1 = new DevComponents.DotNetBar.Controls.ToolboxControl();
            this.toolboxGroup1 = new DevComponents.DotNetBar.Controls.ToolboxGroup();
            this.toolboxItem1 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.toolboxItem4 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.toolboxItem5 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.toolboxItem6 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.toolboxGroup2 = new DevComponents.DotNetBar.Controls.ToolboxGroup();
            this.toolboxItem2 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.toolboxItem3 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.toolboxGroup3 = new DevComponents.DotNetBar.Controls.ToolboxGroup();
            this.toolboxItem7 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.toolboxItem8 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX4 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX5 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // toolboxControl1
            // 
            // 
            // 
            // 
            this.toolboxControl1.BackgroundStyle.Class = "ToolboxControl";
            this.toolboxControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolboxControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolboxControl1.ExpandedWidth = 0;
            this.toolboxControl1.Groups.Add(this.toolboxGroup1);
            this.toolboxControl1.Groups.Add(this.toolboxGroup2);
            this.toolboxControl1.Groups.Add(this.toolboxGroup3);
            this.toolboxControl1.Location = new System.Drawing.Point(0, 8);
            this.toolboxControl1.Name = "toolboxControl1";
            this.toolboxControl1.Padding = new System.Windows.Forms.Padding(2);
            this.toolboxControl1.Size = new System.Drawing.Size(189, 380);
            this.toolboxControl1.TabIndex = 0;
            this.toolboxControl1.Text = "toolboxControl1";
            this.toolboxControl1.TitleText = "Charts";
            // 
            // toolboxGroup1
            // 
            // 
            // 
            // 
            this.toolboxGroup1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolboxGroup1.EqualItemSize = true;
            this.toolboxGroup1.Expanded = true;
            this.toolboxGroup1.GlobalItem = false;
            this.toolboxGroup1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.toolboxGroup1.Name = "toolboxGroup1";
            this.toolboxGroup1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.toolboxItem1,
            this.toolboxItem4,
            this.toolboxItem5,
            this.toolboxItem6});
            // 
            // 
            // 
            this.toolboxGroup1.TitleGroupExpandedStyle.Class = "ToolboxGroupExpandedTitle";
            this.toolboxGroup1.TitleGroupExpandedStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolboxGroup1.TitleMouseOverStyle.Class = "ToolboxGroupTitleMouseOver";
            this.toolboxGroup1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolboxGroup1.TitleStyle.Class = "ToolboxGroupTitle";
            this.toolboxGroup1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolboxGroup1.TitleText = "Column";
            // 
            // toolboxItem1
            // 
            this.toolboxItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.toolboxItem1.GlobalItem = false;
            this.toolboxItem1.Image = global::ToolboxControlSample.Properties.Resources.Chart1;
            this.toolboxItem1.Name = "toolboxItem1";
            this.toolboxItem1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.toolboxItem1.Text = "Stacked Column";
            // 
            // toolboxItem4
            // 
            this.toolboxItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.toolboxItem4.GlobalItem = false;
            this.toolboxItem4.Image = global::ToolboxControlSample.Properties.Resources.Chart2;
            this.toolboxItem4.Name = "toolboxItem4";
            this.toolboxItem4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.toolboxItem4.Text = "100% Stacked Column";
            // 
            // toolboxItem5
            // 
            this.toolboxItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.toolboxItem5.GlobalItem = false;
            this.toolboxItem5.Image = global::ToolboxControlSample.Properties.Resources.Chart3;
            this.toolboxItem5.Name = "toolboxItem5";
            this.toolboxItem5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.toolboxItem5.Text = "3D Clustered Column";
            // 
            // toolboxItem6
            // 
            this.toolboxItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.toolboxItem6.GlobalItem = false;
            this.toolboxItem6.Image = global::ToolboxControlSample.Properties.Resources.Chart4;
            this.toolboxItem6.Name = "toolboxItem6";
            this.toolboxItem6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.toolboxItem6.Text = "3D Stacked Column";
            // 
            // toolboxGroup2
            // 
            // 
            // 
            // 
            this.toolboxGroup2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolboxGroup2.EqualItemSize = true;
            this.toolboxGroup2.Expanded = true;
            this.toolboxGroup2.GlobalItem = false;
            this.toolboxGroup2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.toolboxGroup2.MultiLine = false;
            this.toolboxGroup2.Name = "toolboxGroup2";
            this.toolboxGroup2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.toolboxItem2,
            this.toolboxItem3});
            // 
            // 
            // 
            this.toolboxGroup2.TitleGroupExpandedStyle.Class = "ToolboxGroupExpandedTitle";
            this.toolboxGroup2.TitleGroupExpandedStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolboxGroup2.TitleMouseOverStyle.Class = "ToolboxGroupTitleMouseOver";
            this.toolboxGroup2.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolboxGroup2.TitleStyle.Class = "ToolboxGroupTitle";
            this.toolboxGroup2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolboxGroup2.TitleText = "Line";
            // 
            // toolboxItem2
            // 
            this.toolboxItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.toolboxItem2.GlobalItem = false;
            this.toolboxItem2.Image = global::ToolboxControlSample.Properties.Resources.Chart5;
            this.toolboxItem2.Name = "toolboxItem2";
            this.toolboxItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.toolboxItem2.Text = "Stacked Line";
            // 
            // toolboxItem3
            // 
            this.toolboxItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.toolboxItem3.GlobalItem = false;
            this.toolboxItem3.Image = global::ToolboxControlSample.Properties.Resources.Chart6;
            this.toolboxItem3.Name = "toolboxItem3";
            this.toolboxItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.toolboxItem3.Text = "Line With Markers";
            // 
            // toolboxGroup3
            // 
            // 
            // 
            // 
            this.toolboxGroup3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolboxGroup3.EqualItemSize = true;
            this.toolboxGroup3.Expanded = true;
            this.toolboxGroup3.GlobalItem = false;
            this.toolboxGroup3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.toolboxGroup3.MultiLine = false;
            this.toolboxGroup3.Name = "toolboxGroup3";
            this.toolboxGroup3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.toolboxItem7,
            this.toolboxItem8});
            // 
            // 
            // 
            this.toolboxGroup3.TitleGroupExpandedStyle.Class = "ToolboxGroupExpandedTitle";
            this.toolboxGroup3.TitleGroupExpandedStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolboxGroup3.TitleMouseOverStyle.Class = "ToolboxGroupTitleMouseOver";
            this.toolboxGroup3.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.toolboxGroup3.TitleStyle.Class = "ToolboxGroupTitle";
            this.toolboxGroup3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.toolboxGroup3.TitleText = "Pie";
            // 
            // toolboxItem7
            // 
            this.toolboxItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.toolboxItem7.GlobalItem = false;
            this.toolboxItem7.Image = global::ToolboxControlSample.Properties.Resources.Chart7;
            this.toolboxItem7.Name = "toolboxItem7";
            this.toolboxItem7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.toolboxItem7.Text = "Pie";
            // 
            // toolboxItem8
            // 
            this.toolboxItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.toolboxItem8.GlobalItem = false;
            this.toolboxItem8.Image = global::ToolboxControlSample.Properties.Resources.Chart8;
            this.toolboxItem8.Name = "toolboxItem8";
            this.toolboxItem8.Text = "3D Pie";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(245, 22);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(100, 26);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 1;
            this.checkBoxX1.Text = "Title Bar Visible";
            this.checkBoxX1.CheckedChanged += new System.EventHandler(this.checkBoxX1_CheckedChanged);
            // 
            // itemPanel1
            // 
            this.itemPanel1.AllowDrop = true;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(245, 200);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.ReserveLeftSpace = false;
            this.itemPanel1.Size = new System.Drawing.Size(157, 182);
            this.itemPanel1.TabIndex = 2;
            this.itemPanel1.Text = "itemPanel1";
            this.itemPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.itemPanel1_DragDrop);
            this.itemPanel1.DragOver += new System.Windows.Forms.DragEventHandler(this.itemPanel1_DragOver);
            // 
            // checkBoxX2
            // 
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.Location = new System.Drawing.Point(245, 54);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(144, 26);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 3;
            this.checkBoxX2.Text = "Search Box Visible";
            this.checkBoxX2.CheckedChanged += new System.EventHandler(this.checkBoxX2_CheckedChanged);
            // 
            // checkBoxX3
            // 
            // 
            // 
            // 
            this.checkBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX3.Location = new System.Drawing.Point(245, 86);
            this.checkBoxX3.Name = "checkBoxX3";
            this.checkBoxX3.Size = new System.Drawing.Size(144, 26);
            this.checkBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX3.TabIndex = 4;
            this.checkBoxX3.Text = "Enable Item Rearrange";
            this.checkBoxX3.CheckedChanged += new System.EventHandler(this.checkBoxX3_CheckedChanged);
            // 
            // checkBoxX4
            // 
            // 
            // 
            // 
            this.checkBoxX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX4.Location = new System.Drawing.Point(245, 118);
            this.checkBoxX4.Name = "checkBoxX4";
            this.checkBoxX4.Size = new System.Drawing.Size(144, 26);
            this.checkBoxX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX4.TabIndex = 5;
            this.checkBoxX4.Text = "Enable Drag && Drop";
            this.checkBoxX4.CheckedChanged += new System.EventHandler(this.checkBoxX4_CheckedChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(245, 180);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 14);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Drop Target:";
            // 
            // checkBoxX5
            // 
            // 
            // 
            // 
            this.checkBoxX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX5.Location = new System.Drawing.Point(245, 148);
            this.checkBoxX5.Name = "checkBoxX5";
            this.checkBoxX5.Size = new System.Drawing.Size(144, 26);
            this.checkBoxX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX5.TabIndex = 7;
            this.checkBoxX5.Text = "Only expand single group";
            this.checkBoxX5.CheckedChanged += new System.EventHandler(this.checkBoxX5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 388);
            this.Controls.Add(this.checkBoxX5);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.checkBoxX4);
            this.Controls.Add(this.checkBoxX3);
            this.Controls.Add(this.checkBoxX2);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.checkBoxX1);
            this.Controls.Add(this.toolboxControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Text = "Form1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ToolboxControl toolboxControl1;
        private DevComponents.DotNetBar.Controls.ToolboxGroup toolboxGroup1;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem1;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem4;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem5;
        private DevComponents.DotNetBar.Controls.ToolboxGroup toolboxGroup2;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem2;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem3;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem6;
        private DevComponents.DotNetBar.Controls.ToolboxGroup toolboxGroup3;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem7;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem8;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX5;
    }
}

