using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登陆
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           


        }
        string message;
       /* public string receivedata
        {
            set { message = value; }


        }
        */
      
     

        public void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void 新增用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiugai frm = new xiugai();
            frm.MdiParent = this;
            frm.Show();

        }

        private void 学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.MdiParent =this;
            form3.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
            

        }

       

        private void toolStripStatusLabel2_Click_1(object sender, EventArgs e)
        {

        }






        private void toolStripStatusLabel3_Click_1(object sender, EventArgs e)
         {
          /*
             toolStripStatusLabel3.Text = message;*/
    }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = this.toolStripStatusLabel1.Text +" ：" + UserHelp.loginId;

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousuo sousuo = new sousuo();
            sousuo.Show();

        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousuo sousuo = new sousuo();
            sousuo.Show();
        }

        private void 题库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiku tiku = new 登陆.tiku();
            tiku.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about1 about1 = new about1();
            about1.Show();
        }

        private void 信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kucun kucun = new kucun();
            kucun.Show();
        }

        private void 审理客户问题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            交互界面 frm = new 交互界面();
            frm.Show();
        }

        private void 审核失败车辆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            未通过 frm = new 未通过();
            frm.Show();
        }
    }
}
