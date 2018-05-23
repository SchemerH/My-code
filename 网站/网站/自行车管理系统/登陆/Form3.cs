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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("用户名不可为空！");
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("密码不可为空！");
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("真实姓名不可为空！");
                }
                if ((textBox2.Text != "") && (textBox3.Text != "") && (textBox1.Text != ""))
                {


                    string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                    SqlConnection connection1 = new SqlConnection(str);
                    //connection1.Open();

                    string 用户名 = textBox2.Text;
                    string 密码 = textBox3.Text;
                    string 真实姓名 = textBox1.Text;
                    string 手机号 = textBox4.Text;
                    string 身份证号 = textBox5.Text;
                    string 性别 = comboBox1.Text;
                    string 省份 = comboBox2.Text;
                    string 城市 = comboBox3.Text;

                    string sql = string.Format("insert into 注册(ID,PWD,真实姓名,性别,手机号,身份证号,居住省份,居住城市) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", 用户名, 密码, 真实姓名, 性别, 手机号, 身份证号, 省份, 城市);



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
                            MessageBox.Show("添加成功！");
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
                    this.Close();

                }
            }
            else MessageBox.Show("请确认用户信息");
            
            
            


        }

        
        
        

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
            SqlConnection connection1 = new SqlConnection(str);
            comboBox1.Items.Clear();

            try
            {
                string sql = "SELECT 城市 FROM 居住地 where 省份='" + comboBox2.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();

                SqlDataReader datareader = command.ExecuteReader();
                string nianjiname = "";
                comboBox3.Items.Clear();
                while (datareader.Read())
                {
                    
                    nianjiname = (string)datareader[0];
                    
                    comboBox3.Items.Add(nianjiname);
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            var frm = new 用户协议();
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

