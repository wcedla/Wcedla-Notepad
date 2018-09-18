namespace Notepad
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.aboutlogo = new System.Windows.Forms.PictureBox();
            this.abouttitle = new System.Windows.Forms.Label();
            this.aboutversion = new System.Windows.Forms.Label();
            this.corporation = new System.Windows.Forms.Label();
            this.aboutmore = new System.Windows.Forms.Label();
            this.abouturl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.aboutlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutlogo
            // 
            this.aboutlogo.Image = ((System.Drawing.Image)(resources.GetObject("aboutlogo.Image")));
            this.aboutlogo.Location = new System.Drawing.Point(41, 41);
            this.aboutlogo.Name = "aboutlogo";
            this.aboutlogo.Size = new System.Drawing.Size(188, 158);
            this.aboutlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutlogo.TabIndex = 0;
            this.aboutlogo.TabStop = false;
            // 
            // abouttitle
            // 
            this.abouttitle.AutoSize = true;
            this.abouttitle.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.abouttitle.Location = new System.Drawing.Point(256, 41);
            this.abouttitle.Name = "abouttitle";
            this.abouttitle.Size = new System.Drawing.Size(388, 37);
            this.abouttitle.TabIndex = 1;
            this.abouttitle.Text = "wcedla 记事本 for windows";
            // 
            // aboutversion
            // 
            this.aboutversion.AutoSize = true;
            this.aboutversion.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aboutversion.Location = new System.Drawing.Point(258, 108);
            this.aboutversion.Name = "aboutversion";
            this.aboutversion.Size = new System.Drawing.Size(101, 25);
            this.aboutversion.TabIndex = 2;
            this.aboutversion.Text = "版本号:1.0";
            // 
            // corporation
            // 
            this.corporation.AutoSize = true;
            this.corporation.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.corporation.Location = new System.Drawing.Point(258, 174);
            this.corporation.Name = "corporation";
            this.corporation.Size = new System.Drawing.Size(459, 25);
            this.corporation.TabIndex = 3;
            this.corporation.Text = "版权所有 2018 WCEDLA Corporation 保留所有权力";
            // 
            // aboutmore
            // 
            this.aboutmore.AutoSize = true;
            this.aboutmore.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aboutmore.Location = new System.Drawing.Point(97, 277);
            this.aboutmore.Name = "aboutmore";
            this.aboutmore.Size = new System.Drawing.Size(240, 25);
            this.aboutmore.TabIndex = 4;
            this.aboutmore.Text = "获取更多相关信息，请访问";
            // 
            // abouturl
            // 
            this.abouturl.AutoSize = true;
            this.abouturl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.abouturl.Location = new System.Drawing.Point(343, 277);
            this.abouturl.Name = "abouturl";
            this.abouturl.Size = new System.Drawing.Size(230, 25);
            this.abouturl.TabIndex = 5;
            this.abouturl.TabStop = true;
            this.abouturl.Text = "http://www.wcedla.com";
            this.abouturl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.abouturl_LinkClicked);
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(746, 380);
            this.Controls.Add(this.abouturl);
            this.Controls.Add(this.aboutmore);
            this.Controls.Add(this.corporation);
            this.Controls.Add(this.aboutversion);
            this.Controls.Add(this.abouttitle);
            this.Controls.Add(this.aboutlogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutForm";
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.aboutlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox aboutlogo;
        private System.Windows.Forms.Label abouttitle;
        private System.Windows.Forms.Label aboutversion;
        private System.Windows.Forms.Label corporation;
        private System.Windows.Forms.Label aboutmore;
        private System.Windows.Forms.LinkLabel abouturl;
    }
}