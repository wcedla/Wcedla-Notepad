using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class MainForm : Form
    {
        private String openFileName=String.Empty;//打开的文件的路径包括文件名
        private Boolean FileisOpen = false;//flag标志作用，判断当前状态是否已经打开文件。
        static ChildForm cf=null;//后续操作都需啊哟使用到子窗体实例，所以要全局变量。

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.Text = "未命名 - 记事本";//标题栏，美化作用
            cf = new ChildForm();                                 
            cf.MdiParent = this;//设置子窗体            
            cf.Dock = DockStyle.Fill;//使子窗体充满父窗体            
            cf.Show();//显示子窗体
            openFileName = String.Empty;//全局变量清空
            FileisOpen = false;
            this.自动换行WToolStripMenuItem.Checked = true;
            this.状态栏ToolStripMenuItem.Checked = true;




        } 
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cf != null)//如果子窗体没有实例化
            {
                this.statuslabel1.Text = "新建文本";
                if (cf.textChange)//如果文本已经被修改
                {
                    DialogResult dialogResult=MessageBox.Show("是否保存更改？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)//选择保存修改
                    {
                        if (FileisOpen)//如果当前状态是保存已经打开的文件，则应该不跳出选择保存文件的路径对话框，默认直接保存文件。
                        {
                            using (FileStream fs = File.Open(openFileName, FileMode.Create, FileAccess.ReadWrite))//openfilename因为前面的是否打开文件的flag已经判断了，所以可以不做判null处理。
                            {
                                byte[] bt = System.Text.Encoding.Default.GetBytes(cf.getText());//使用默认文本编码保存文件
                                fs.Write(bt, 0, bt.Length);
                                fs.Close();//记得一定要关闭流。
                                cf.Saveed();//刷新保存为以保存，实则是刷新textchange的状态。
                                this.statuslabel1.Text = "保存文本成功";
                            }
                            cf.Close();//关闭子窗体
                            openFileName = String.Empty;//全局变量清空
                            FileisOpen = false;
                            this.OnLoad(e);
                        }
                        else
                        {
                            SaveFile();//已经选择保存修改之后，由于当前状态为未打开文件，所以使用保存文件对话框保存文件。
                            cf.Saveed();//修改文件保存状态。
                            cf.Close();//新建窗体，重新初始化等操作
                            openFileName = String.Empty;
                            FileisOpen = false;
                            this.OnLoad(e);
                        }
                    }
                    else if(dialogResult==DialogResult.No)//选择不保存修改，不管当前状态是否是已经打开文件都直接执行新建窗体操作。
                    {
                        cf.Close();
                        openFileName = String.Empty;
                        FileisOpen = false;
                        this.OnLoad(e);
                    }
                }
                else//文本并未被修改则可以直接执行新建窗体操作。
                {
                    cf.Close();
                    openFileName = String.Empty;
                    FileisOpen = false;
                    this.OnLoad(e);
                }
            }
            else//子窗体实例化未成功，则请求用户重启软件。
            {
                MessageBox.Show("软件出现问题，请重启软件重试！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileisOpen)//如果当前状态为已经打开文件，
            {
                if (cf.textChange)//如果文件已经被修改
                {
                    DialogResult result = MessageBox.Show("文件已被更改，是否保存更改？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)//选择保存更改
                    {
                        using (FileStream fs = File.Open(openFileName, FileMode.Create, FileAccess.ReadWrite))//应为已经是打开文件状态了，所以不需要判断openFileName。
                        {
                            byte[] bt = System.Text.Encoding.Default.GetBytes(cf.getText());
                            fs.Write(bt, 0, bt.Length);
                            fs.Close();//关闭流
                            cf.Saveed();//刷新文件的保存状态.
                            this.statuslabel1.Text = "保存文本成功";
                            OpenFile();//保存完成， 执行打开窗体操作。
                            

                        }
                    }
                    else if (result == DialogResult.No)
                    {                       
                        OpenFile();//选择不保存文件，则直接执行打开文件操作。
                    }
                }
                else if (!cf.textChange)
                {
                    OpenFile();//打开文件状态下，并未修改文件，直接执行打开文件操作。
                }
            }
            else if (!FileisOpen)//当前状态为没有打开文件状态
            {

                if (cf.textChange)//文本已经被修改了
                {

                    DialogResult dialogResult = MessageBox.Show("是否保存文档内容？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)//选择保存对文件的修改。
                    {
                        SaveFile();//由于当前状态为没有打开文件，所以需要保存窗体来选择保存操作
                        cf.Saveed();//刷新文件的保存状态
                        OpenFile();//执行打开文件操作
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        OpenFile();//选择不保存对文件的修改则直接执行打开文件操作。
                    }

                }
                else//文件并未被修改,则直接执行打开文件操作。
                {
                    OpenFile();
                }
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cf.textChange)//如果文件已经被修改
            {
                if (FileisOpen)//如果当前状态为已经打开文件状态
                {
                    using (FileStream fs = File.Open(openFileName, FileMode.Create, FileAccess.ReadWrite))//当前状态为已经打开文件了，所以不需要判断openfilename
                    {
                        byte[] bt = System.Text.Encoding.Default.GetBytes(cf.getText());
                        fs.Write(bt, 0, bt.Length);
                        fs.Close();//关闭流
                        this.statuslabel1.Text = "保存文本成功";
                    }
                    cf.Saveed();//刷新文件的保存状态
                }
                else//如果当前状态为未打开文件
                {
                    SaveFile();//直接执行保存文件的操作
                    cf.Saveed();//修改文件的保存状态
                }
            }
        }


        /*
         * 保存当前richtextbox的文本内容
         */
        private void OpenFile()
        {
            this.statuslabel1.Text = "打开文本";
            OpenFileDialog ofd = new OpenFileDialog();//保存文件窗体
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//默认选择路径为文档路径
            ofd.Filter = "文本文档|*.txt|所有文件|*.*";//设置文件筛选格式
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Substring(ofd.FileName.LastIndexOf("\\")+1).Length > 0)//如果选择好了打开文件的路径和名字
            {
                FileStream textStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);//根据选择的文件参数，打开文件，获得文件流
                byte[] bt = new byte[textStream.Length];//文件流的read方法需要用到的byte数组。
                textStream.Read(bt, 0, bt.Length);//将文本内容全部存储到byte数组
                String textString = GetBytesEncoding(bt).GetString(bt);//使用了根绝bom判断文档格式的方法读取文件，判断方法来源网络。
                cf.SetText(textString, ofd.FileName);//调用子窗体的设置richtextbox的文本内容方法设置richtextbox的文本为从文件读取到的内容。
                openFileName = ofd.FileName;//保存当前打开的文件路径及路径名
                textStream.Close();//关闭流
                FileisOpen = true;//设置flag标志位为当前为已经打开文件状态
                this.Text = openFileName.Substring(openFileName.LastIndexOf("\\")+1) + " - 记事本";//刷新标题栏文本，美化作用
                this.statuslabel1.Text = openFileName.Substring(openFileName.LastIndexOf("\\") + 1);
            }
            
        }

        /*
         * 保存当前文本内容
         */

        private void SaveFile()
        {
            this.statuslabel1.Text = "保存文本";
            String directory = String.Empty;//初始化保存路径
            String filename = String.Empty;//初始化保存文件名
            SaveFileDialog sfd = new SaveFileDialog();//打开保存文件窗体           
            directory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//默认设置文档路径为存储路径
            filename = "文本文档.txt";//设置默认存储文件名
            sfd.InitialDirectory = directory;//设置存储路径
            sfd.FileName = filename;//设置文件名
            sfd.Filter = "文本文档|*.txt|所有文件|*.*";//设置文件筛选格式
            DialogResult dialogResult = sfd.ShowDialog();//显示保存操作窗体
            if (dialogResult == DialogResult.OK && sfd.FileName.Substring(sfd.FileName.LastIndexOf("\\")+1).Length > 0)//如果选择了确定保存
            {
                string filePath = sfd.FileName;//获取选择的路包括径文件名
                using (FileStream fs = File.Open(directory+"\\"+filename, FileMode.Create, FileAccess.ReadWrite))//根据路径文件名，选择覆盖保存。
                {
                    byte[] bt = System.Text.Encoding.Default.GetBytes(cf.getText());//根据系统默认的文本格式保存文本
                    fs.Write(bt, 0, bt.Length);//写入文件
                    fs.Close();//关闭流                  
                }
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//保存成功提示.
                this.Text = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                this.statuslabel1.Text = "保存文本成功";
            }
            else if (dialogResult == DialogResult.OK && sfd.FileName.Substring(sfd.FileName.LastIndexOf("\\")+1).Length <= 0)//如果文件名输入为空
            {
                MessageBox.Show("请检查文件名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         用于判断文本使用的编码方式，是使用了BOM的ANSI，unicode编码方式即gb2312，gb18030等
         还是使用了无BOM编码的utf-8编码方式
             */

        Encoding GetBytesEncoding(byte[] bs)
        {
            int len = bs.Length;
            if (len >= 3 && bs[0] == 0xEF && bs[1] == 0xBB && bs[2] == 0xBF)
            {
                return Encoding.UTF8;
            }
            int[] cs = { 7, 5, 4, 3, 2, 1, 0, 6, 14, 30, 62, 126 };
            for (int i = 0; i < len; i++)
            {
                int bits = -1;
                for (int j = 0; j < 6; j++)
                {
                    if (bs[i] >> cs[j] == cs[j + 6])
                    {
                        bits = j;
                        break;
                    }
                }
                if (bits == -1)
                {
                    return Encoding.Default;
                }
                while (bits--> 0)
                {
                    i++;
                    if (i == len || bs[i] >> 6 != 2)
                    {
                        return Encoding.Default;
                    }
                }
            }
            return Encoding.UTF8;
        }

        
        private void 编辑EToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
            if (!cf.isSelected)
            {
                this.复制CToolStripMenuItem.Enabled = false;
                this.剪切TToolStripMenuItem.Enabled = false;
            }
            else if(cf.isSelected)
            {
                this.复制CToolStripMenuItem.Enabled = true;
                this.剪切TToolStripMenuItem.Enabled = true;
            }
            if (!Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                this.粘贴PToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.粘贴PToolStripMenuItem.Enabled = true;
            }
            if (cf.getText() != String.Empty)
            {                
                this.查找FToolStripMenuItem.Enabled = true;
                this.替换ToolStripMenuItem.Enabled = true;
            }
            else
            {               
                this.查找FToolStripMenuItem.Enabled = false;
                this.替换ToolStripMenuItem.Enabled = false;
            }
            
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cf.isSelected)
            {
                //Clipboard.SetDataObject(cf.GetSelectText());
                cf.CopyText();
                this.statuslabel1.Text = "复制文本";
            }
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                cf.PasteText();
                this.statuslabel1.Text = "粘贴文本";
            }
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cf.CutText();
            this.statuslabel1.Text = "剪切文本";
        }

        private void 查找FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindText findText = new FindText();
            findText.TopLevel = true;
            findText.Show(this);
            this.statuslabel1.Text = "查找";
        }

        public static Form getChildForm()
        {
            return MainForm.cf;
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceTextForm rpf = new ReplaceTextForm();
            rpf.TopLevel = true;
            rpf.Show(this);
            this.statuslabel1.Text = "替换文本";
        }

        private void 自动换行WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.自动换行WToolStripMenuItem.Checked == true)
            {
                cf.SetMutilline(true);
                this.statuslabel1.Text = "开启自动换行";
            }
            else if(this.自动换行WToolStripMenuItem.Checked == false)
            {
                cf.SetMutilline(false);
                this.statuslabel1.Text = "关闭自动换行";
            }

        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontSelectForm fsf = new FontSelectForm();
            fsf.Show();
            this.statuslabel1.Text = "更改字体";
        }

        public void setStatusLabel(int i, String[] str)
        {
            switch (i)
            {
                case 1:
                    {
                        this.lengthlabel.Text = "文本长度:" + str[0];
                    }break;
                case 2:
                    {
                        this.locationlabel.Text = "行:" + str[0] + " 列:" + str[1];
                    }break;
            }
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.状态栏ToolStripMenuItem.Checked == true)
            {
                this.statusbar.Visible = true;
                this.statuslabel1.Text = "开启状态栏";
            }
            else if (this.状态栏ToolStripMenuItem.Checked == false)
            {
                this.statusbar.Visible = false;

            }
        }

        private void 查看帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "winhlp32.exe";
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm af = new aboutForm();
            af.Show();
        }
    }
}
