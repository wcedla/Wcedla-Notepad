namespace Notepad
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.statuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lengthlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.locationlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.格式OToolStripMenuItem,
            this.查看VToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(974, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.保存SToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.剪切TToolStripMenuItem,
            this.查找FToolStripMenuItem,
            this.替换ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            this.编辑EToolStripMenuItem.MouseEnter += new System.EventHandler(this.编辑EToolStripMenuItem_MouseEnter);
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            this.复制CToolStripMenuItem.Click += new System.EventHandler(this.复制CToolStripMenuItem_Click);
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            this.粘贴PToolStripMenuItem.Click += new System.EventHandler(this.粘贴PToolStripMenuItem_Click);
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            this.剪切TToolStripMenuItem.Click += new System.EventHandler(this.剪切TToolStripMenuItem_Click);
            // 
            // 查找FToolStripMenuItem
            // 
            this.查找FToolStripMenuItem.Name = "查找FToolStripMenuItem";
            this.查找FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.查找FToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.查找FToolStripMenuItem.Text = "查找(&F)";
            this.查找FToolStripMenuItem.Click += new System.EventHandler(this.查找FToolStripMenuItem_Click);
            // 
            // 替换ToolStripMenuItem
            // 
            this.替换ToolStripMenuItem.Name = "替换ToolStripMenuItem";
            this.替换ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.替换ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.替换ToolStripMenuItem.Text = "替换(&R)";
            this.替换ToolStripMenuItem.Click += new System.EventHandler(this.替换ToolStripMenuItem_Click);
            // 
            // 格式OToolStripMenuItem
            // 
            this.格式OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动换行WToolStripMenuItem,
            this.字体ToolStripMenuItem});
            this.格式OToolStripMenuItem.Name = "格式OToolStripMenuItem";
            this.格式OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.格式OToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.格式OToolStripMenuItem.Text = "格式(&O)";
            // 
            // 自动换行WToolStripMenuItem
            // 
            this.自动换行WToolStripMenuItem.CheckOnClick = true;
            this.自动换行WToolStripMenuItem.Name = "自动换行WToolStripMenuItem";
            this.自动换行WToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.自动换行WToolStripMenuItem.Text = "自动换行(&W)";
            this.自动换行WToolStripMenuItem.Click += new System.EventHandler(this.自动换行WToolStripMenuItem_Click);
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.字体ToolStripMenuItem.Text = "字体(&F)";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // 查看VToolStripMenuItem
            // 
            this.查看VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏ToolStripMenuItem});
            this.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem";
            this.查看VToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.查看VToolStripMenuItem.Text = "查看(&V)";
            // 
            // 状态栏ToolStripMenuItem
            // 
            this.状态栏ToolStripMenuItem.CheckOnClick = true;
            this.状态栏ToolStripMenuItem.Name = "状态栏ToolStripMenuItem";
            this.状态栏ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.状态栏ToolStripMenuItem.Text = "状态栏";
            this.状态栏ToolStripMenuItem.Click += new System.EventHandler(this.状态栏ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助HToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 查看帮助HToolStripMenuItem
            // 
            this.查看帮助HToolStripMenuItem.Name = "查看帮助HToolStripMenuItem";
            this.查看帮助HToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.查看帮助HToolStripMenuItem.Text = "查看帮助(&H)";
            this.查看帮助HToolStripMenuItem.Click += new System.EventHandler(this.查看帮助HToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // statusbar
            // 
            this.statusbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel1,
            this.lengthlabel,
            this.locationlabel});
            this.statusbar.Location = new System.Drawing.Point(0, 523);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(974, 25);
            this.statusbar.TabIndex = 2;
            this.statusbar.Text = "状态栏";
            // 
            // statuslabel1
            // 
            this.statuslabel1.Name = "statuslabel1";
            this.statuslabel1.Size = new System.Drawing.Size(39, 20);
            this.statuslabel1.Text = "状态";
            // 
            // lengthlabel
            // 
            this.lengthlabel.Margin = new System.Windows.Forms.Padding(150, 3, 0, 2);
            this.lengthlabel.Name = "lengthlabel";
            this.lengthlabel.Size = new System.Drawing.Size(82, 20);
            this.lengthlabel.Text = "文本长度:0";
            // 
            // locationlabel
            // 
            this.locationlabel.Margin = new System.Windows.Forms.Padding(150, 3, 0, 2);
            this.locationlabel.Name = "locationlabel";
            this.locationlabel.Size = new System.Drawing.Size(91, 20);
            this.locationlabel.Text = "行：0 列：0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 548);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "记事本";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动换行WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel1;
        private System.Windows.Forms.ToolStripStatusLabel lengthlabel;
        private System.Windows.Forms.ToolStripStatusLabel locationlabel;
    }
}

