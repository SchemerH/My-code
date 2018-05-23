using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void 退出ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新增学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         this.toolStripStatusLabel1.Text = this.toolStripStatusLabel1.Text + "-" + UserHelp.loginId;
          
        }

        private void 修改查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search  search = new search ();
            search.Show();
        }

        private void 信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infolist  infolist = new infolist();
            infolist.Show();
        }

        private void dGV显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvlist dgvlist = new dgvlist();
            dgvlist.Show();
        }

    }
}
