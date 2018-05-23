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
    public partial class 车辆信息上传 : Form
    {
        public 车辆信息上传()
        {
            InitializeComponent();
        }
        int e;
        
        private void button1_Click(object sender, EventArgs ez)
        {
            count();
            string str = @" Data Source=DESKTOP-781JML6\SQL;Initial Catalog=bike;Integrated Security=SSPI";
            SqlConnection connection1 = new SqlConnection(str);




            string 车辆品牌 = comboBox1.Text;
            string 车辆型号 = comboBox2.Text;
            string 新旧程度描述 = textBox2.Text;
            int 价格 = Convert.ToInt32(textBox4.Text);
            string 车辆编号 = e.ToString();
            

            string sql = string.Format("insert into 待审核车辆(上传用户,车辆品牌,车辆型号,车辆新旧程度,车辆编号,价格,图片) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", UserHelp.loginId, 车辆品牌,车辆型号,新旧程度描述, 车辆编号,价格,path);



            try
            {

                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();

                int result = command.ExecuteNonQuery();

                if (result != 1)
                {
                    MessageBox.Show("添加失败！");
                }
                else
                {
                    string message = string.Format("上传成功，您的查询编号为：{0}", 车辆编号);
                    MessageBox.Show(message);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("操作数据库出错");

            }
            finally
            {
                connection1.Close();
            }
            this.Refresh();




/*
            connection1.Open();
            string spInsertImage = string.Format("update 待审核车辆 set 图片 ='{0}' where 车辆编号=车辆编号",path);
            SqlCommand cmd = new SqlCommand(spInsertImage, connection1);
           
            try
            {
                //调用存储过程spInsertImage  
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功插入一张图片到数据库中！");
            }
            catch
            {
                MessageBox.Show("出错了，请确认是否正确选择了图片文件！");
            }
            finally
            {
                connection1.Close();
            }
            */
            
        }

        private void count()
        {
            string str = @" Data Source=DESKTOP-781JML6\SQL;Initial Catalog=bike;Integrated Security=SSPI";
            SqlConnection connection1 = new SqlConnection(str);
            connection1.Open();
            string sql1 = string.Format("select count(*) from 待审核车辆");
            SqlCommand command1 = new SqlCommand(sql1, connection1);

            int a = Convert.ToInt32(command1.ExecuteScalar());

            string sql2 = string.Format("select count(*) from 库存车辆");
            SqlCommand command2 = new SqlCommand(sql2, connection1);

            int b = Convert.ToInt32(command2.ExecuteScalar());

            string sql3 = string.Format("select count(*) from 销售车辆");
            SqlCommand command3 = new SqlCommand(sql3, connection1);

            int c = Convert.ToInt32(command3.ExecuteScalar());

            string sql4 = string.Format("select count(*) from 未通过车辆");
            SqlCommand command4 = new SqlCommand(sql4, connection1);

            int d = Convert.ToInt32(command4.ExecuteScalar());
            e = a + b + c + d + 1;
            UserHelp.num = e.ToString();
            connection1.Close();
        }
        
        private void 车辆信息上传_Load(object sender, EventArgs ez)
        {
            
           


        
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = @" Data Source=DESKTOP-781JML6\SQL;Initial Catalog=bike;Integrated Security=SSPI";
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
        string path = "";
        private void button3_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             path = fileDialog.FileName;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            审查结果查询 frm = new 审查结果查询();
            frm.Show();

        }
    }
}
