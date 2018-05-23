using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 登陆
{
    public partial class kucun : Form
    {
        public kucun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillview();
        }
        private void fillview()
        {

            string sname;
            string ssex;
            string sgrade;
            string sclass;
            string sshenfen;
            string price;
            string buy;
            
            string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
            SqlConnection connection1 = new SqlConnection(str);

            try
            {
                string sql = string.Format("select 上传用户,车辆品牌,车辆型号,车辆新旧程度,车辆编号,价格,购买用户 from 销售车辆 ");
                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();

                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                listView1.Items.Clear();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("没有查到相关记录！");

                }
                else
                {
                    MessageBox.Show("查找成功！");
                    while (dataReader.Read())
                    {

                        sname = (string)dataReader["上传用户"];
                        ssex = (string)dataReader["车辆品牌"];
                        sgrade = (string)dataReader["车辆型号"];
                        sclass = (string)dataReader["车辆新旧程度"];
                        sshenfen = dataReader["车辆编号"].ToString(); //若是datareader的数据为空，不能用string直接进行转换，否则会出错
                        price = dataReader["价格"].ToString();
                        buy = dataReader["购买用户"].ToString();
                        UserHelp.num = sshenfen;
                        ListViewItem listviewstu = new ListViewItem(sshenfen);
                        /*  if (sshenfen != "共青团员" && sshenfen != "共产党员")
                              sshenfen = "其他";*/

                        listviewstu.Tag = (string)dataReader["车辆编号"];
                        listView1.Items.Add(listviewstu);
                        listviewstu.SubItems.AddRange(new string[] { ssex, sgrade, sclass, sname, price,buy });
                    }
                }






                dataReader.Close();
                connection1.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("操作数据库出错");
            }

        }

        private void 政治面貌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {
                string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);

                string sql = string.Format("select 图片 from 销售车辆 where 车辆编号='{0}'", (string)listView1.SelectedItems[0].Tag);
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection1);
                    connection1.Open();

                    SqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    if (!dataReader.HasRows)
                    {
                        MessageBox.Show("没有查到相关记录！");

                    }

                    string path;
                    while (dataReader.Read())
                    {
                        path = dataReader["图片"].ToString();


                        System.Diagnostics.Process.Start(@path);
                    }






                }
                catch
                {
                }
                finally
                {
                    connection1.Close();

                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 查看图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {
                string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);

                string sql = string.Format("select 图片 from 销售车辆 where 车辆编号='{0}'", (string)listView1.SelectedItems[0].Tag);
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection1);
                    connection1.Open();

                    SqlDataReader dataReader;
                    dataReader = command.ExecuteReader();
                    if (!dataReader.HasRows)
                    {
                        MessageBox.Show("没有查到相关记录！");

                    }

                    string path;
                    while (dataReader.Read())
                    {
                        path = dataReader["图片"].ToString();


                        System.Diagnostics.Process.Start(@path);
                    }






                }
                catch
                {
                }
                finally
                {
                    connection1.Close();

                }
            }
        }
    }
}
