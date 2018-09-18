using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class ReplaceTextForm : Form
    {
        ChildForm cf;
        Boolean isOldStrEnable;
        Boolean isNewStrEnable;
        public ReplaceTextForm()
        {
            InitializeComponent();
        }

        private void ReplaceTextForm_Load(object sender, EventArgs e)
        {
            cf =(ChildForm) MainForm.getChildForm();
        }

        private void oldStr_TextChanged(object sender, EventArgs e)
        {
            if (this.oldStr.Text.Equals(String.Empty))
            {
                isOldStrEnable = false;
            }
            else if (!this.oldStr.Text.Equals(String.Empty))
            {
                isOldStrEnable = true;
            }

        }

        private void newStr_TextChanged(object sender, EventArgs e)
        {
            if (this.newStr.Text.Equals(String.Empty))
            {
                isNewStrEnable = false;
            }
            else if (!this.newStr.Text.Equals(String.Empty))
            {
                isNewStrEnable = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!isNewStrEnable || !isOldStrEnable)
            {
                MessageBox.Show("请输入内容！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = cf.FindText(this.oldStr.Text, 0, RichTextBoxFinds.None);
            if (index == -1)
            {
                MessageBox.Show("未找到需要替换的内容，请检查输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cf.ReplaceText(this.oldStr.Text, this.newStr.Text);
            MessageBox.Show("替换完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
