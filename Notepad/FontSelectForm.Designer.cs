namespace Notepad
{
    partial class FontSelectForm
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
            this.selectFont = new System.Windows.Forms.TextBox();
            this.fontList = new System.Windows.Forms.ListBox();
            this.shapeText = new System.Windows.Forms.TextBox();
            this.shapeList = new System.Windows.Forms.ListBox();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.fontlabel = new System.Windows.Forms.Label();
            this.shapelabel = new System.Windows.Forms.Label();
            this.sizelabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.previewlabel = new System.Windows.Forms.GroupBox();
            this.previewtext = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.previewlabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFont
            // 
            this.selectFont.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectFont.Location = new System.Drawing.Point(90, 120);
            this.selectFont.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.selectFont.Name = "selectFont";
            this.selectFont.Size = new System.Drawing.Size(255, 27);
            this.selectFont.TabIndex = 0;
            this.selectFont.TextChanged += new System.EventHandler(this.selectFont_TextChanged);
            // 
            // fontList
            // 
            this.fontList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.fontList.FormattingEnabled = true;
            this.fontList.ItemHeight = 27;
            this.fontList.Location = new System.Drawing.Point(90, 147);
            this.fontList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(255, 220);
            this.fontList.TabIndex = 1;
            this.fontList.SelectedIndexChanged += new System.EventHandler(this.fontList_SelectedIndexChanged);
            // 
            // shapeText
            // 
            this.shapeText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shapeText.Location = new System.Drawing.Point(388, 120);
            this.shapeText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.shapeText.Name = "shapeText";
            this.shapeText.Size = new System.Drawing.Size(149, 27);
            this.shapeText.TabIndex = 2;
            this.shapeText.TextChanged += new System.EventHandler(this.shapeText_TextChanged);
            // 
            // shapeList
            // 
            this.shapeList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.shapeList.FormattingEnabled = true;
            this.shapeList.ItemHeight = 27;
            this.shapeList.Items.AddRange(new object[] {
            "常规",
            "倾斜",
            "粗体",
            "粗体 倾斜"});
            this.shapeList.Location = new System.Drawing.Point(388, 147);
            this.shapeList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(149, 220);
            this.shapeList.TabIndex = 3;
            this.shapeList.SelectedIndexChanged += new System.EventHandler(this.shapeList_SelectedIndexChanged);
            // 
            // sizeText
            // 
            this.sizeText.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sizeText.Location = new System.Drawing.Point(597, 120);
            this.sizeText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.sizeText.MaxLength = 3;
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(200, 34);
            this.sizeText.TabIndex = 4;
            this.sizeText.TextChanged += new System.EventHandler(this.sizeText_TextChanged);
            // 
            // fontlabel
            // 
            this.fontlabel.AutoSize = true;
            this.fontlabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.fontlabel.Location = new System.Drawing.Point(87, 88);
            this.fontlabel.Name = "fontlabel";
            this.fontlabel.Size = new System.Drawing.Size(52, 27);
            this.fontlabel.TabIndex = 5;
            this.fontlabel.Text = "字体";
            // 
            // shapelabel
            // 
            this.shapelabel.AutoSize = true;
            this.shapelabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.shapelabel.Location = new System.Drawing.Point(385, 88);
            this.shapelabel.Name = "shapelabel";
            this.shapelabel.Size = new System.Drawing.Size(52, 27);
            this.shapelabel.TabIndex = 6;
            this.shapelabel.Text = "字形";
            // 
            // sizelabel
            // 
            this.sizelabel.AutoSize = true;
            this.sizelabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sizelabel.Location = new System.Drawing.Point(593, 88);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(52, 27);
            this.sizelabel.TabIndex = 7;
            this.sizelabel.Text = "大小";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okButton.Location = new System.Drawing.Point(654, 330);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 37);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // previewlabel
            // 
            this.previewlabel.Controls.Add(this.previewtext);
            this.previewlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.previewlabel.Location = new System.Drawing.Point(597, 174);
            this.previewlabel.Name = "previewlabel";
            this.previewlabel.Size = new System.Drawing.Size(200, 131);
            this.previewlabel.TabIndex = 10;
            this.previewlabel.TabStop = false;
            this.previewlabel.Text = "示例";
            // 
            // previewtext
            // 
            this.previewtext.AutoSize = true;
            this.previewtext.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.previewtext.Location = new System.Drawing.Point(21, 35);
            this.previewtext.Name = "previewtext";
            this.previewtext.Size = new System.Drawing.Size(83, 25);
            this.previewtext.TabIndex = 0;
            this.previewtext.Text = "ABC123";
            this.previewtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FontSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(881, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.previewlabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sizelabel);
            this.Controls.Add(this.shapelabel);
            this.Controls.Add(this.fontlabel);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.shapeList);
            this.Controls.Add(this.shapeText);
            this.Controls.Add(this.fontList);
            this.Controls.Add(this.selectFont);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontSelectForm";
            this.Text = "字体";
            this.Load += new System.EventHandler(this.FontSelectForm_Load);
            this.previewlabel.ResumeLayout(false);
            this.previewlabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectFont;
        private System.Windows.Forms.ListBox fontList;
        private System.Windows.Forms.TextBox shapeText;
        private System.Windows.Forms.ListBox shapeList;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.Label fontlabel;
        private System.Windows.Forms.Label shapelabel;
        private System.Windows.Forms.Label sizelabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox previewlabel;
        private System.Windows.Forms.Label previewtext;
        private System.Windows.Forms.Button button1;
    }
}