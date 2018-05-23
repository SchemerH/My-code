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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "")
            {

                MessageBox.Show("用户名不能为空", "提示", MessageBoxButtons.OK);
                textBox1.Focus();
            }
            if (textBox2.Text == "")
            {

                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK);
                textBox1.Focus();
            }
            if (comboBox1.Text=="普通用户")
            {
                string id = textBox1.Text;
                string pwd = textBox2.Text;
                UserHelp.loginId = textBox1.Text;
                UserHelp.loginType = comboBox1.Text;


                string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);
                int count = 0;

                try
                {
                    string sql = string.Format("select count(*) from 注册 where ID='{0}' and PWD='{1}'", id, pwd);
                    SqlCommand command = new SqlCommand(sql, connection1);
                    connection1.Open();
                    count = (int)command.ExecuteScalar();
                    if (count == 1)
                    {
                        MessageBox.Show("登陆成功！");
                        this.Hide();
                        var frm2 = new 普通用户();
                        frm2.Show();
                        /*frm2.receivedata = this.senddata;*/



                    }
                    else
                    {
                        MessageBox.Show("用户名或密码不存在");

                    }
                    int result = command.ExecuteNonQuery();

                    if (result == 1)

                    {
                        MessageBox.Show("失败！");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("操作数据库出错");
                }
                connection1.Close();


            }
            if (comboBox1.Text=="管理员用户")
            {
                 
                string id = textBox1.Text;
                string pwd = textBox2.Text;
                UserHelp.loginId = textBox1.Text;
                UserHelp.loginType = comboBox1.Text;


                string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);
                int count = 0;
                
                try
                {
                    string sql = string.Format("select count(*) from 管理员 where ID='{0}' and PWD='{1}'", id, pwd);
                    SqlCommand command = new SqlCommand(sql, connection1);
                    connection1.Open();
                    count = (int)command.ExecuteScalar();
                    if (count == 1)
                    {
                        MessageBox.Show("登陆成功！");
                        this.Hide();
                        var frm2 = new Form2();
                        frm2.Show();
                        /*frm2.receivedata = this.senddata;*/
                        
                        

                    }
                    else
                    {
                        MessageBox.Show( "用户名或密码不存在");
                        
                    }
                    int result = command.ExecuteNonQuery();

                    if (result == 1)
                   
                    {
                        MessageBox.Show("失败！");
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("操作数据库出错");
                }
                connection1.Close();  
                 
}           

        }
     /*   public string senddata
        {

            get { return this.textBox1.Text; }
        }
        */

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Show();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}

