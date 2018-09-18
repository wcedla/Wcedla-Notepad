namespace Notepad
{
    partial class FindText
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
            this.textLabel = new System.Windows.Forms.Label();
            this.textfind = new System.Windows.Forms.TextBox();
            this.nextFind = new System.Windows.Forms.Button();
            this.circlefind = new System.Windows.Forms.CheckBox();
            this.matchcase = new System.Windows.Forms.CheckBox();
            this.matchWords = new System.Windows.Forms.CheckBox();
            this.reverseFind = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(63, 47);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(99, 15);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "查找内容(N):";
            // 
            // textfind
            // 
            this.textfind.Location = new System.Drawing.Point(177, 44);
            this.textfind.Name = "textfind";
            this.textfind.Size = new System.Drawing.Size(353, 25);
            this.textfind.TabIndex = 1;
            this.textfind.TextChanged += new System.EventHandler(this.textfind_TextChanged);
            // 
            // nextFind
            // 
            this.nextFind.Location = new System.Drawing.Point(565, 44);
            this.nextFind.Name = "nextFind";
            this.nextFind.Size = new System.Drawing.Size(102, 33);
            this.nextFind.TabIndex = 2;
            this.nextFind.Text = "查找下一个";
            this.nextFind.UseVisualStyleBackColor = true;
            this.nextFind.Click += new System.EventHandler(this.nextFind_Click);
            // 
            // circlefind
            // 
            this.circlefind.AutoSize = true;
            this.circlefind.Location = new System.Drawing.Point(492, 110);
            this.circlefind.Name = "circlefind";
            this.circlefind.Size = new System.Drawing.Size(89, 19);
            this.circlefind.TabIndex = 3;
            this.circlefind.Text = "循环查找";
            this.circlefind.UseVisualStyleBackColor = true;
            this.circlefind.CheckedChanged += new System.EventHandler(this.circlefind_CheckedChanged);
            // 
            // matchcase
            // 
            this.matchcase.AutoSize = true;
            this.matchcase.Location = new System.Drawing.Point(66, 110);
            this.matchcase.Name = "matchcase";
            this.matchcase.Size = new System.Drawing.Size(104, 19);
            this.matchcase.TabIndex = 4;
            this.matchcase.Text = "匹配大小写";
            this.matchcase.UseVisualStyleBackColor = true;
            this.matchcase.CheckedChanged += new System.EventHandler(this.matchcase_CheckedChanged);
            // 
            // matchWords
            // 
            this.matchWords.AutoSize = true;
            this.matchWords.Location = new System.Drawing.Point(211, 110);
            this.matchWords.Name = "matchWords";
            this.matchWords.Size = new System.Drawing.Size(89, 19);
            this.matchWords.TabIndex = 5;
            this.matchWords.Text = "全词匹配";
            this.matchWords.UseVisualStyleBackColor = true;
            this.matchWords.CheckedChanged += new System.EventHandler(this.matchWords_CheckedChanged);
            // 
            // reverseFind
            // 
            this.reverseFind.AutoSize = true;
            this.reverseFind.Location = new System.Drawing.Point(354, 110);
            this.reverseFind.Name = "reverseFind";
            this.reverseFind.Size = new System.Drawing.Size(89, 19);
            this.reverseFind.TabIndex = 6;
            this.reverseFind.Text = "反向查找";
            this.reverseFind.UseVisualStyleBackColor = true;
            this.reverseFind.CheckedChanged += new System.EventHandler(this.reverseFind_CheckedChanged);
            // 
            // FindText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(740, 168);
            this.Controls.Add(this.reverseFind);
            this.Controls.Add(this.matchWords);
            this.Controls.Add(this.matchcase);
            this.Controls.Add(this.circlefind);
            this.Controls.Add(this.nextFind);
            this.Controls.Add(this.textfind);
            this.Controls.Add(this.textLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.Load += new System.EventHandler(this.FindText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textfind;
        private System.Windows.Forms.Button nextFind;
        private System.Windows.Forms.CheckBox circlefind;
        private System.Windows.Forms.CheckBox matchcase;
        private System.Windows.Forms.CheckBox matchWords;
        private System.Windows.Forms.CheckBox reverseFind;
    }
}