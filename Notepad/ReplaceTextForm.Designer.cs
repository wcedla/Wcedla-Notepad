namespace Notepad
{
    partial class ReplaceTextForm
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
            this.oldStr = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.newStr = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldStr
            // 
            this.oldStr.Location = new System.Drawing.Point(45, 60);
            this.oldStr.Name = "oldStr";
            this.oldStr.Size = new System.Drawing.Size(176, 25);
            this.oldStr.TabIndex = 0;
            this.oldStr.TextChanged += new System.EventHandler(this.oldStr_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(259, 63);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(52, 15);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "替换为";
            // 
            // newStr
            // 
            this.newStr.Location = new System.Drawing.Point(344, 60);
            this.newStr.Name = "newStr";
            this.newStr.Size = new System.Drawing.Size(176, 25);
            this.newStr.TabIndex = 2;
            this.newStr.TextChanged += new System.EventHandler(this.newStr_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(237, 115);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 33);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ReplaceTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(598, 177);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.newStr);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.oldStr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "替换";
            this.Load += new System.EventHandler(this.ReplaceTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldStr;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox newStr;
        private System.Windows.Forms.Button okButton;
    }
}