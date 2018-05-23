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
    public partial class xiugai : Form
    {
        public xiugai()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 团员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {
                string sql = string.Format("update student set 政治面貌='共青团员' where name='{0}'", (string)listView1.SelectedItems[0].Tag);
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
                    fillview();
                }
            }
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
            string picture;
            string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
            SqlConnection connection1 = new SqlConnection(str);

            try
            {
                string sql = string.Format("select 上传用户,车辆品牌,车辆型号,车辆新旧程度,车辆编号,价格 from 待审核车辆 ");
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
                        price= dataReader["价格"].ToString();
                        UserHelp.num = sshenfen;
                        ListViewItem listviewstu = new ListViewItem(sshenfen);
                      /*  if (sshenfen != "共青团员" && sshenfen != "共产党员")
                            sshenfen = "其他";*/

                        listviewstu.Tag = (string)dataReader["车辆编号"];
                        listView1.Items.Add(listviewstu);
                        listviewstu.SubItems.AddRange(new string[] { ssex, sgrade, sclass, sname,price });
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

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

                string sql = string.Format("select 图片 from 待审核车辆 where 车辆编号='{0}'", (string)listView1.SelectedItems[0].Tag);
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

       

       

        private void 删除成员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {

                int a = 0;
                string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);
               
                try
                {
                    string sql0 = string.Format("insert into 库存车辆( 上传用户,车辆品牌,车辆型号,车辆新旧程度,车辆编号,价格,图片) select * from 待审核车辆 where 车辆编号='{0}'", (string)listView1.SelectedItems[0].Tag);
                    SqlCommand command = new SqlCommand(sql0, connection1);
                    connection1.Open();
                    a = command.ExecuteNonQuery();
                    if(a<1)
                    {
                        MessageBox.Show("数据转移失败！");
                    }
                   



                    
                    connection1.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("操作数据库出错");
                }





               



               
                
                    int result = 0;
                    try
                    {
                        string sql1 = string.Format("delete from 待审核车辆 where 车辆编号='{0}'", (string)listView1.SelectedItems[0].Tag);
                        SqlCommand command = new SqlCommand(sql1, DBHelper.connection);
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
                        MessageBox.Show("操作失败");
                    }
                    else
                    {
                        MessageBox.Show("操作成功");
                        fillview();
                    }
                

            }
        }

        private void 审核失败ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {

                int a = 0;
                string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);

                try
                {
                    string sql0 = string.Format("insert into 未通过车辆( 上传用户,车辆品牌,车辆型号,车辆新旧程度,车辆编号,价格,图片) select * from 待审核车辆 where 车辆编号='{0}'", (string)listView1.SelectedItems[0].Tag);
                    SqlCommand command = new SqlCommand(sql0, connection1);
                    connection1.Open();
                    a = command.ExecuteNonQuery();
                    if (a < 1)
                    {
                        MessageBox.Show("数据转移失败！");
                    }





                    connection1.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("操作数据库出错");
                }











                int result = 0;
                try
                {
                    string sql1 = string.Format("delete from 待审核车辆 where 车辆编号='{0}'", (string)listView1.SelectedItems[0].Tag);
                    SqlCommand command = new SqlCommand(sql1, DBHelper.connection);
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
                    MessageBox.Show("操作失败");
                }
                else
                {
                    MessageBox.Show("操作成功");
                    fillview();
                }


            }
            问题说明 frm = new 问题说明();
            frm.Show();



        }
    }
}
