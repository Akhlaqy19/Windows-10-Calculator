using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ToolboxControlSample
{
    public partial class Form1 : OfficeForm
    {
        public Form1()
        {
            InitializeComponent();

            checkBoxX1.Checked = toolboxControl1.TitleVisible;
            checkBoxX2.Checked = toolboxControl1.SearchBoxVisible;
            checkBoxX3.Checked = toolboxControl1.ItemRearrangeEnabled;
            checkBoxX4.Checked = toolboxControl1.ItemDragDropEnabled;
            checkBoxX5.Checked = toolboxControl1.ExpandSingleGroupOnly;
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            toolboxControl1.TitleVisible = checkBoxX1.Checked;
        }

        private void checkBoxX2_CheckedChanged(object sender, EventArgs e)
        {
            toolboxControl1.SearchBoxVisible = checkBoxX2.Checked;
        }

        private void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {
            toolboxControl1.ItemRearrangeEnabled = checkBoxX3.Checked;
        }

        private void checkBoxX4_CheckedChanged(object sender, EventArgs e)
        {
            toolboxControl1.ItemDragDropEnabled = checkBoxX4.Checked;
        }

        private void checkBoxX5_CheckedChanged(object sender, EventArgs e)
        {
            toolboxControl1.ExpandSingleGroupOnly = checkBoxX5.Checked;
        }

        private void itemPanel1_DragDrop(object sender, DragEventArgs e)
        {
            DevComponents.DotNetBar.Controls.ToolboxItem item = (DevComponents.DotNetBar.Controls.ToolboxItem)e.Data.GetData(typeof(DevComponents.DotNetBar.Controls.ToolboxItem));
            DevComponents.DotNetBar.Controls.ToolboxItem copy = (DevComponents.DotNetBar.Controls.ToolboxItem)item.Copy();
            itemPanel1.Items.Add(copy);
            itemPanel1.RecalcLayout();
        }

        private void itemPanel1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DevComponents.DotNetBar.Controls.ToolboxItem)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
       }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.devcomponents.com/kb2/?p=1926");
        } 
    }
}
