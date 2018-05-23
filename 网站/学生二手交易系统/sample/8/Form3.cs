using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connstring = "Data Source=VANCOU-PC;Initial Catalog=test;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connstring);

            try
            {
                string sql = "SELECT 年级 FROM grade group by 年级,编号 order by 编号";
                SqlCommand command = new SqlCommand(sql,connection1 );
                connection1.Open();

                SqlDataReader datareader = command.ExecuteReader();
                string gradename = "";
                while (datareader.Read())
                {
                    gradename = (string)datareader[0];
                  
                    comboBox2.Items.Add(gradename);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sex = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string grade = comboBox2.Text;
            string classname = comboBox1.Text;
            string sql = string.Format("insert into student (姓名,性别,年级,班级) values ('{0}','{1}','{2}','{3}')", name, sex, grade,classname);
            string connstring = "Data Source=VANCOU-PC;Initial Catalog=test;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connstring); 
            
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connstring = "Data Source=VANCOU-PC;Initial Catalog=test;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connstring);
            comboBox1.Items.Clear();
            
            try
            {
                string sql = "SELECT 班级 FROM grade where 年级='"+comboBox2 .Text +"'";
                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();

                SqlDataReader datareader = command.ExecuteReader();
                string nianjiname = "";
                while (datareader.Read())
                {
                    nianjiname = (string)datareader[0];
                    nianjiname = string.Format(nianjiname);
                    MessageBox.Show("a" + nianjiname + "a");
                    comboBox1.Items.Add(nianjiname);
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
    }
}

