using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FontSelectForm : Form
    {
        ChildForm cf;
        FontStyle shape;
        private System.Drawing.Text.InstalledFontCollection objFont = new System.Drawing.Text.InstalledFontCollection();
        public FontSelectForm()
        {
            InitializeComponent();
        }

        private void FontSelectForm_Load(object sender, EventArgs e)
        {
            cf = (ChildForm)MainForm.getChildForm();
            int indexSize;
            this.selectFont.Text = cf.Getfont().Name;
            this.sizeText.Text = cf.Getfont().Size.ToString();
             shape= cf.Getfont().Style;
            if (shape.Equals(FontStyle.Regular))
            {
                this.shapeText.Text = "常规";
                shapeList.SelectedIndex = 0;
            }
            else if (shape.Equals(FontStyle.Italic))
            {
                this.shapeText.Text = "倾斜";
                shapeList.SelectedIndex = 1;
            }
            else if (shape.Equals(FontStyle.Bold))
            {
                this.shapeText.Text = "粗体";
                shapeList.SelectedIndex = 2;
            }
            else if (shape.Equals(FontStyle.Bold | FontStyle.Italic))
            {
                this.shapeText.Text = "粗体 倾斜";
                shapeList.SelectedIndex = 3;
            }
            foreach(System.Drawing.FontFamily i in objFont.Families)
            {
                this.fontList.Items.Add(i.Name.ToString());
                
            }
            
            this.fontList.SelectedIndex = this.fontList.FindString(this.selectFont.Text);
            indexSize = this.fontList.SelectedIndex - 3;
            if (indexSize<0)
                indexSize = 0;
            this.fontList.TopIndex = indexSize ;

            this.previewtext.Font= new System.Drawing.Font(cf.Getfont().Name, float.Parse(cf.Getfont().Size.ToString()), cf.Getfont().Style, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

        }

        private void selectFont_TextChanged(object sender, EventArgs e)
        {
            this.fontList.SelectedIndex = -1;
            int tempIndex;
            int indexSize;
            if (this.selectFont.Text != String.Empty)
            {
                tempIndex= this.fontList.FindString(this.selectFont.Text);
                
                if (this.fontList.Items.Contains(this.selectFont.Text))
                {
                    this.fontList.SelectedIndex = tempIndex;
                    if (this.shapeList.Items.Contains(this.shapeText.Text))
                    {
                        if (this.sizeText.Text.Length > 0)
                        {
                            this.previewtext.Font = new System.Drawing.Font(this.selectFont.Text, float.Parse(this.sizeText.Text), CheckFontStyle(this.shapeText.Text), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        }
                    }
                }
                indexSize = tempIndex - 3;
                if (indexSize < 0)
                    indexSize = 0;
                this.fontList.TopIndex = indexSize;
            }
        }

        private void fontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.fontList.SelectedIndex >= 0)
            {
                this.selectFont.Text = this.fontList.SelectedItem.ToString();
            }

        }

        private void shapeText_TextChanged(object sender, EventArgs e)
        {
            this.shapeList.SelectedIndex = -1;
            int tempIndex;
            if (this.shapeText.Text != String.Empty)
            {
                tempIndex = this.shapeList.FindString(this.shapeText.Text);

                if (this.shapeList.Items.Contains(this.shapeText.Text))
                {
                    this.shapeList.SelectedIndex = tempIndex;
                    if (this.fontList.Items.Contains(this.selectFont.Text))
                    {
                        if (this.sizeText.Text.Length > 0)
                        {
                            this.previewtext.Font = new System.Drawing.Font(this.selectFont.Text, float.Parse(this.sizeText.Text), CheckFontStyle(this.shapeText.Text), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        }
                    }
                }
                this.shapeList.TopIndex = tempIndex;
            }
        }

        private void shapeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.shapeList.SelectedIndex >= 0)
            {
                this.shapeText.Text = this.shapeList.SelectedItem.ToString();
            }
        }

        private void sizeText_TextChanged(object sender, EventArgs e)
        {
            String pattern= @"^[0-9]*[0-9][0-9]*$";
            if (!Regex.IsMatch(this.sizeText.Text, pattern))
            {
                this.sizeText.Text = String.Empty;
            }
            if (this.sizeText.Text.Length > 0)
            {
                if (Convert.ToInt16(this.sizeText.Text) > 200)
                {
                    this.sizeText.Text = 200.ToString();
                }
                if (this.fontList.Items.Contains(this.selectFont.Text))
                {
                    if (this.shapeList.Items.Contains(this.shapeText.Text))
                    {
                        this.previewtext.Font = new System.Drawing.Font(this.selectFont.Text, float.Parse(this.sizeText.Text), CheckFontStyle(this.shapeText.Text), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    }
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(!this.fontList.Items.Contains(this.selectFont.Text)|| !this.shapeList.Items.Contains(this.shapeText.Text))
            {
                MessageBox.Show("请选择正确的字体参数!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt16(this.sizeText.Text) > 72)
            {
                DialogResult result = MessageBox.Show("字体设置过大严重影响阅读与显示\n仍要设置吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;
            }
            FontStyle ft=CheckFontStyle(this.shapeText.Text);            
            cf.SetFont(this.selectFont.Text, float.Parse(this.sizeText.Text), ft);
        }
        private FontStyle CheckFontStyle(String str)
        {
            if (str.Equals("常规"))
            {
                return FontStyle.Regular;
            }
            else if (str.Equals("倾斜"))
            {
                return FontStyle.Italic;
            }
            else if (str.Equals("粗体"))
            {
                return FontStyle.Bold;
            }
            else if (str.Equals(("粗体 倾斜")))
            {
                return FontStyle.Bold | FontStyle.Italic;
            }
            return FontStyle.Regular;
        }

    }

  
}
