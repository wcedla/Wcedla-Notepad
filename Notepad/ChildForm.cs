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
    public partial class ChildForm : Form
    {
        MainForm mf;
        public Boolean textChange = false;//文本是否修改标志
        String rememberText=String.Empty;//用于判断文本是否修改的中间变量
        Boolean textCheckPause = true;//由于textchange事件会一直执行，所以设置一个flag标志位，控制判断，使其可以中断，比如打开文件的时候，和之前文本不一样，但是不能让textchange为真。
        String FileName = String.Empty;//接收主窗体打开文件的文件路径文件名信息
        public Boolean isSelected = false;
        int reverseIndex;
        String[] textlength = new String[1];
        String[] lineandcolumn = new String[2];

        public ChildForm()
        {
            InitializeComponent();
           
        }


        private void ChildForm_Load(object sender, EventArgs e)
        {
            mf=(MainForm)this.MdiParent;
            this.TextArea.Dock = DockStyle.Fill;//时richtextbox充满整个窗体
            rememberText = this.TextArea.Text;//初始化中间变量
            textCheckPause = false;//窗体初始化完成开始监控文本变化
            reverseIndex = -1;


        }



        private void TextArea_TextChanged(object sender, EventArgs e)
        {
            textlength[0] = this.TextArea.Text.Length.ToString();
            mf.setStatusLabel(1, textlength);
            //MessageBox.Show(mf.ToString());
            if (!textCheckPause)//控制判断的开关
            {
                if (!this.TextArea.Text.Equals(rememberText))
                {
                    textChange = true;//文本已经变动
                }
                else if (this.TextArea.Text.Equals(rememberText))
                {
                    textChange = false;//文本未修改
                }
            }
        }

        /*
         * 主窗体设置文本到子窗体richtextbox显示的方法
         * 
         */

        public void SetText(string str,string filename)
        {
            textCheckPause = true;//关闭文本更改监控 
            textChange = false;//首先设置文本的修改状态为未修改                       
            this.TextArea.Text = str;//将文本设置到richtextbox中
            this.rememberText = this.TextArea.Text;//给中间变量重新赋值打开的文件的值，是的判断文本是否更改的源文件为打开的文件
            this.FileName = filename;//保存打开的文件的路径文件名
            textCheckPause = false;//文件打开完毕，重新设置文本改变监控为运行状态
        }

         
        /*
         * 将richtextbox的文本内容发送给主窗体
         */

        public String getText()
        {
            return this.TextArea.Text;
        }

        /*
         * 刷新文件的保存状态，实则就是让文本的textchange为false。
         */

        public void Saveed()
        {
            textChange = false;//设置文本为未修改状态
            textCheckPause = true;//关闭文件更改监控状态
            this.rememberText = this.TextArea.Text;//重新设置判断文本是否更改的中间变量的值            
            textCheckPause = false;//开启文本更改监控
        }

        private void TextArea_SelectionChanged(object sender, EventArgs e)
        {
            
            if (TextArea.SelectedText != String.Empty)
                isSelected = true;
            else
            {
                isSelected = false;
                GetCharLineAndColum(ref lineandcolumn[0], ref lineandcolumn[1]);
                mf.setStatusLabel(2, lineandcolumn);
            }
        }

        /*
         * richtextbox自带复制函数
         */

        public void CopyText()
        {
            this.TextArea.Copy();
        }

        /*
         * richTextbox自带的粘贴函数
         */

        public void PasteText()
        {
            this.TextArea.Paste();
        }

        /*
         * richTextbox自带剪切函数
         */

        public void CutText()
        {
            this.TextArea.Cut();
        }

        /*
         * 对外查找richtextbox文本接口函数
         * 由于反向查找需要用到的参数列表不同，
         * 所以需要做一下判断。
         */

        public int FindText(String str,int i,RichTextBoxFinds finds)
        {
            Boolean isReverse=finds.ToString().Contains("Reverse");//通过toString方法可以知道枚举组合中是否包含反向查找，从而可以选择对应的方法查找。
            if (isReverse)//如果开启了反向查找
            {                
                reverseIndex = this.TextArea.Find(str, 0, i, finds);//目的是逐渐缩小查找尾部的index，从而达到从最后向前面查找的效果
                this.TextArea.Focus();//目的是查找到后让richtextbox获取到焦点，达到可以显示查找到的内容的效果。
                return reverseIndex;//将查找到的index返回，查不到或者查到尾部了返回-1
            }
            else if (!isReverse)//如果没有开启反向查找
            {
                reverseIndex = this.TextArea.Find(str,i, finds);//只要逐渐改变开始查找的位置，就可以实现查找下一个的效果
                this.TextArea.Focus();//目的是查找到后让richtextbox获取到焦点，达到可以显示查找到的内容的效果。
                return reverseIndex;//将查找到的index返回，查不到或者查到尾部了返回-1
            }
            return -1;
        }

        public void ReplaceText(String oldStr,String newSrr)
        {
            this.TextArea.Text=this.TextArea.Text.Replace(oldStr, newSrr);
        }

        public void SetMutilline(Boolean b)
        {
            if (b == true)
                this.TextArea.WordWrap = true;
            else
                this.TextArea.WordWrap = false;
        }

        public Font Getfont()
        {
            return this.TextArea.Font;
        }
        public void SetFont(String fontFamily,float fontSize,FontStyle fontStyle)
        {
            this.TextArea.SelectAll();
            this.TextArea.SelectionFont = new System.Drawing.Font(fontFamily, float.Parse(fontSize.ToString()), fontStyle, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }

        private void GetCharLineAndColum(ref String linestr,ref String columnstr)
        {
            /*  得到光标行第一个字符的索引，
             *  即从第1个字符开始到光标行的第1个字符索引*/
            int index = TextArea.GetFirstCharIndexOfCurrentLine();
            /*  得到光标行的行号,第1行从0开始计算，习惯上我们是从1开始计算，所以+1。 */
            int line = TextArea.GetLineFromCharIndex(index) + 1;
            /*  SelectionStart得到光标所在位置的索引
             *  再减去
             *  当前行第一个字符的索引
             *  = 光标所在的列数(从0开始)  */
            int column = TextArea.SelectionStart - index + 1;
            /*  选择打印输出的控件  */
            linestr = line.ToString();
            columnstr = column.ToString();

        }
    }
}
