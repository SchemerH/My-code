using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data .SqlClient ;

namespace _8
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void filllistview()
        {
            string sname;
            string ssex;
            string sgrade;
            string sclass;
            string sshenfen;
            try
            {
                string sql = string.Format("select 姓名,性别,年级,班级,政治面貌 from student where 姓名 like '%{0}%'", textBox1.Text);
                SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                SqlDataReader dataReader;
                DBHelper.connection.Open();
                dataReader = command.ExecuteReader();
                
                listView1.Items.Clear();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("没有查到相关记录！");
                 
                }
                else
                {
                    while (dataReader.Read())
                    {
                        
                        sname = (string)dataReader["姓名"];
                        ssex = (string)dataReader["性别"];
                        sgrade = (string)dataReader["年级"];
                        sclass = (string)dataReader["班级"];
                        
                        sshenfen =(string)dataReader["政治面貌"];
                        ListViewItem listviewstu = new ListViewItem(sname);
                        listviewstu.Tag = (string)dataReader["姓名"];
                        listView1.Items.Add(listviewstu);
                        listviewstu.SubItems.AddRange(new string[] { ssex, sgrade, sclass,sshenfen });
                    }
                }
                dataReader.Close();
            }
            catch
            {
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("不能为空！");
                textBox1.Focus();
            }
            else
            {
                filllistview();
            }

        }



        private void 党员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {
                string sql = string.Format("update student set 政治面貌='党员' where 姓名='{0}'",(string) listView1.SelectedItems [0].Tag );
                int result = 0;
                try
                {
                    SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                    DBHelper.connection.Open();
                    result = command.ExecuteNonQuery();

                }
                catch
                {
                }
                finally
                {
                    DBHelper.connection.Close();
                }
                if (result < 1)
                {
                    MessageBox.Show("修改失败");
                }
                else
                {
                    MessageBox.Show("修改成功");
                    filllistview();
                }
            }

        }

        private void 删除学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {
                DialogResult choice = MessageBox.Show("确定要删除？","警告",MessageBoxButtons .YesNo );
                if (choice == DialogResult.Yes )
                {
                    int result = 0;
                    try
                    {
                        string sql = string.Format("delete from student where 姓名='{0}'",(string ) listView1 .SelectedItems [0].Tag);
                        SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                        DBHelper.connection.Open();
                        result = command.ExecuteNonQuery();

                    }
                    catch
                    {
                    }
                    finally
                    {
                        DBHelper.connection.Close();
                    }
                    if (result < 1)
                    {
                        MessageBox.Show("删除失败");
                    }
                    else
                    {
                        MessageBox.Show("删除成功");
                        filllistview();
                    }
                }

            }
        }
    }
}
