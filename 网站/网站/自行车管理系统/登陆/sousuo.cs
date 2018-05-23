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
    public partial class sousuo : Form
    {
        private DataSet dataset = new DataSet();
        private SqlDataAdapter dataadapter;
        public sousuo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataset.Tables["库存车辆"].Clear();
            string sql = string.Format("select 上传用户,车辆品牌,车辆型号,车辆新旧程度,车辆编号,价格 from 库存车辆 where 价格>'{0}' and 价格<'{1}'", textBox1.Text,textBox2.Text);



            dataadapter = new SqlDataAdapter(sql, DBHelper.connection);


            dataadapter.Fill(dataset, "库存车辆");
            
            dataGridView1.DataSource = dataset.Tables["库存车辆"];
            if (dataGridView1.Rows.Count < 2)
                MessageBox.Show("不存在相应数据！");


        }

        private void sousuo_Load(object sender, EventArgs e)
        {
            string sql = "select 上传用户,车辆品牌,车辆型号,车辆新旧程度,车辆编号,价格 from 库存车辆";


            dataadapter = new SqlDataAdapter(sql, DBHelper.connection);

            dataadapter.Fill(dataset, "库存车辆");
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            dataset.Tables["库存车辆"].Clear();
            string sql = string.Format("select 车辆编号,车辆品牌,车辆型号,车辆新旧程度,上传用户,价格 from 库存车辆 where 车辆品牌 = '{0}' and 车辆型号='{1}'", comboBox1.Text,comboBox2.Text);



            dataadapter = new SqlDataAdapter(sql, DBHelper.connection);


            dataadapter.Fill(dataset, "库存车辆");


            dataGridView1.DataSource = dataset.Tables["库存车辆"];

            if (comboBox1.Text == "*")
            {
                dataset.Tables["库存车辆"].Clear();
                sql = string.Format("select 车辆编号,车辆品牌,车辆型号,车辆新旧程度,上传用户,价格 from 库存车辆 ");



                dataadapter = new SqlDataAdapter(sql, DBHelper.connection);


                dataadapter.Fill(dataset, "库存车辆");


                dataGridView1.DataSource = dataset.Tables["库存车辆"];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
            SqlConnection connection1 = new SqlConnection(str);
            comboBox2.Items.Clear();

            try
            {
                string sql = "SELECT 型号 FROM 车辆 where 品牌='" + comboBox1.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();

                SqlDataReader datareader = command.ExecuteReader();
                string nianjiname = "";
                comboBox2.Items.Clear();
                while (datareader.Read())
                {

                    nianjiname = (string)datareader[0];

                    comboBox2.Items.Add(nianjiname);
                }
                datareader.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("操作数据库出错");

            }
            finally
            {
                connection1.Close();
            }
        }
        private void button9_Click(object sender,EventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {
                DialogResult choice = MessageBox.Show("确定要购买？", "警告", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {

                    int a = 0;
                    string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                    SqlConnection connection1 = new SqlConnection(str);

                    try
                    {
                        string sql0 = string.Format("insert into 销售车辆( 上传用户,车辆品牌,车辆型号,车辆新旧程度,车辆编号,价格,图片) select * from 库存车辆 where 车辆编号='{0}'", (string)dataGridView1.SelectedCells[0].Value.ToString());
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





                    string sql = string.Format("update 销售车辆 set 购买用户='{0}' where 车辆编号='{1}'", UserHelp.loginId,(string)dataGridView1.SelectedCells[0].Value.ToString());
                    int q = 0;
                    try
                    {
                        SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                        DBHelper.connection.Open();
                        q = command.ExecuteNonQuery();

                    }
                    catch
                    {
                    }
                    finally
                    {
                        DBHelper.connection.Close();
                    }
                    if (q < 1)
                    {
                        MessageBox.Show("修改失败");
                    }
                    else
                    {
                        MessageBox.Show("修改成功");
                        
                    }





                    int result = 0;
                    try
                    {
                        string sql1 = string.Format("delete from 库存车辆 where 车辆编号='{0}'", (string)dataGridView1.SelectedCells[0].Value.ToString());
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
                        MessageBox.Show("购买失败");
                    }
                    else
                    {
                        MessageBox.Show("购买成功");
                        
                    }



             
                }

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("没有选中记录");

            }
            else
            {
                string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);

                string sql = string.Format("select 图片 from 库存车辆 where 车辆编号='{0}'", (string)dataGridView1.SelectedCells[0].Value.ToString());
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
