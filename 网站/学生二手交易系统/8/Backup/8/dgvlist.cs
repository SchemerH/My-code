using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _8
{
    public partial class dgvlist : Form
    {
        private DataSet dataset = new DataSet();//声明并初始化DataSet
        private SqlDataAdapter dataadapter;//声明DataAdapter
        public dgvlist()
        {
            InitializeComponent();
        }

        private void dgvlist_Load(object sender, EventArgs e)
        {
            string sql = "select id,姓名,性别,班级,年级,政治面貌 from student";
            //string sql = string.Format("select id,姓名,性别,年级,班级,政治面貌 from student where 姓名 like '%{0}%'", textBox1.Text);

            dataadapter = new SqlDataAdapter(sql, DBHelper.connection);
            //填充数据集
            dataadapter.Fill(dataset, "student");

            //dataGridView1.DataSource = dataset.Tables["student"];

           // dataGridView1.Columns[5].HeaderCell.Value = "身份";

           // dataGridView1.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定保存？","提示",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //生成用于修改的command命令
                SqlCommandBuilder builder = new SqlCommandBuilder(dataadapter);

                dataadapter.Update(dataset,"student");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataGridView1Row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(dataGridView1Row);
            }
            //需要加上更新，否则只是删除datagridview试图中的数据
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (this.dataGridView1.DataSource as DataTable).Rows.Clear();

            string sql = string.Format("select id,姓名,性别,年级,班级,政治面貌 from student where 姓名 like '%{0}%'", textBox1.Text);

            dataadapter = new SqlDataAdapter(sql, DBHelper.connection);
            //填充数据集
            dataadapter.Fill(dataset, "student");

           
            dataGridView1.DataSource = dataset.Tables["student"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (this.dataGridView1.DataSource as DataTable).Rows.Clear();
            string sql = "select id,姓名,性别,班级,年级,政治面貌 from student";
            //string sql = string.Format("select id,姓名,性别,年级,班级,政治面貌 from student where 姓名 like '%{0}%'", textBox1.Text);

            dataadapter = new SqlDataAdapter(sql, DBHelper.connection);
            //填充数据集
            dataadapter.Fill(dataset, "student");

            dataGridView1.DataSource = dataset.Tables["student"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "select id,姓名,性别,班级,年级,政治面貌 from student";
            switch (comboBox1.Text)
            {
                case "男":
                    sql += " where 性别='男'";
                    break;
                case "女":
                    sql += " where 性别='女'";
                    break;
                default:
                    break;
            }
          
            dataset.Tables["student"].Clear();
           
            dataadapter.SelectCommand.CommandText = sql;
            dataadapter.Fill(dataset,"student");
            dataGridView1.DataSource = dataset.Tables["student"];
        }
    }
}
