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
    public partial class FindText : Form
    {
        Boolean isCircle;//是否开启循环查找
        Boolean isMatchWords;//是否开启全词匹配    
        Boolean isMatchCaps;//是否开启匹配大小写
        Boolean isReverse;//是否开启反向查找

        ChildForm cf = null;
        int i, tempi;//查找用的index

        public FindText()
        {

            InitializeComponent();
        }

        private void FindText_Load(object sender, EventArgs e)
        {
            i = 0;
            tempi = 1;
            this.nextFind.Enabled = false;//查找按钮在查找文本框没输内容时应该是不可用的
            cf = (ChildForm)MainForm.getChildForm();//要获取到主窗口中创建的子窗体的实例，不然直接new的话不能够准确的获取到子窗体的数据。
            isMatchWords = false;
            isCircle = false;
            isMatchCaps = false;
            isReverse = false;
        }

        /*
         * 当文本框中有内容之后设置查找按钮为可用状态
         */

        private void textfind_TextChanged(object sender, EventArgs e)
        {
            if (this.textfind.Text == String.Empty)
            {
                this.nextFind.Enabled = false;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;

            }
            else
            {
                this.nextFind.Enabled = true;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
        }


        /*
         * 是否开启循环查找
         */

        private void circlefind_CheckedChanged(object sender, EventArgs e)
        {
            if (this.circlefind.Checked == true)
            {
                isCircle = true;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
            else if (this.circlefind.Checked == false)
            {
                isCircle = false;
                i = 0;//查找条件已经更改，重新初始化查找index//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
        }

        /*
         * 是否开启匹配大小写
         */

        private void matchcase_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matchcase.Checked == true)
            {
                isMatchCaps = true;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
            else if (this.matchcase.Checked == false)
            {
                isMatchCaps = false;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
        }

        /*
         * 是否开启全词匹配
         */

        private void matchWords_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matchWords.Checked == true)
            {
                isMatchWords = true;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
            else if(this.matchWords.Checked==false)
            {
                isMatchWords = false;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
        }

        /*
         * 是否开启反向查找
         */

        private void reverseFind_CheckedChanged(object sender, EventArgs e)
        {
            if (reverseFind.Checked == true)
            {
                isReverse = true;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
            else if (reverseFind.Checked == false)
            {
                isReverse = false;
                i = 0;//查找条件已经更改，重新初始化查找index
                tempi = 1;
            }
        }

        /*
         * 查找下一个按钮实现方法
         * 由于反向查找方法所需要的index与正向查找需要的index的变化是不同的
         * 正向查找是改变开始的idnex，反向查找是改变结尾的index
         */

        private void nextFind_Click(object sender, EventArgs e)
        {
            RichTextBoxFinds finds= RichTextBoxFinds.None;//枚举默认值

            if (isMatchCaps)//如果开启了匹配大小写
            {
                finds = RichTextBoxFinds.None | RichTextBoxFinds.MatchCase;
            }
            
            if (isMatchWords)//如果开启了全词匹配
            {
                finds |= RichTextBoxFinds.WholeWord;
            }

            if (isReverse)//如果开启了反向查找
            {
                finds |= RichTextBoxFinds.Reverse;
            }

            if (i == 0 && tempi == 0)//反向查找查找到了最开头，判断是否开启了循环查找，如果未开启则提示查找到头了。
            {
                if (!isCircle)
                {
                    MessageBox.Show("查找也是有底线的！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            if (i>=cf.getText().Length)//正向查找查找到文件结尾之后，判断是否开启了循环查找
            {
                if (!isCircle)
                {
                    MessageBox.Show("查找也是有底线的！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            tempi = cf.FindText(this.textfind.Text, i,finds);//调用子窗体查找函数查找指定内容

            if (isReverse)//如果开启了反向查找，设置index的变化方法
            {
                if (tempi != -1)//就是一直查找到内容，查找不到内容会返回1，richtextbox的查找函数文件的末尾和开头如果都能匹配到查找的内容，不会返回-1，所以要在前面定义两个if判断来提示用户
                {
                    i = tempi;//让每次查找的结尾都为上一次查找到的index（0,0的情况前面进行了if判断提示
                    
                }
                else if (tempi == -1)//如果没有查找到内容，或者在限定的范围内没有找到匹配项
                {
                    if (i == 0)//如果当前是在全文中都没有找到内容，就提示没有匹配项
                    {
                        MessageBox.Show("没有查到相关文本内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else//如果是限定范围内没有找到匹配项
                    {
                        if (isCircle)//又开启了循环查找的话
                        {
                            i = 0;//那就重新重头开始查找
                            tempi = cf.FindText(this.textfind.Text, i, finds);
                            i = tempi;//设置前一个结果的index为搜索范围的结尾
                        }
                        else if (!isCircle)//没有开启循环查找,提示查找到结尾了
                        {
                            MessageBox.Show("查找也是有底线的！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else//正向查找
            {

                if (tempi != -1)//就是一直查找到内容，查找不到内容会返回1，richtextbox的查找函数文件的末尾和开头如果都能匹配到查找的内容，不会返回-1，所以要在前面定义两个if判断来提示用户
                {
                    i = tempi + 1;//设置下一个查找范围为上一个查找到的index的后一位                    
                }
                else if (tempi == -1)//如果没有查找到内容，或者在限定的范围内没有找到匹配项
                {
                    if (i == 0)//如果当前是在全文中都没有找到内容，就提示没有匹配项
                    {
                        MessageBox.Show("没有查到相关文本内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else//如果是限定范围内没有找到匹配项
                    {
                        if (isCircle)//如果开启了循环查找
                        {
                            i = 0;//那就重新重头开始查找
                            tempi = cf.FindText(this.textfind.Text, i, finds);
                            i = tempi + 1;//设置下一个查找范围为上一个查找到的index的后一位
                        }
                        else if (!isCircle)//没有开启循环查找,提示查找到结尾了
                        {
                            MessageBox.Show("查找也是有底线的！");
                        }
                    }

                }
            }
        }
    }
}
