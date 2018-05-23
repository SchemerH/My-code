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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ShowUserForm()
        {
            switch (comboBox1.Text)
            {
                case "管理员":
                    Form2 form2 = new Form2();
                   // this.Visible = false;
                   
                    form2.Show(); 
                    this.Close();
                    break;
                default:
                    MessageBox.Show("尚未开发");
                    break;
            }
        }

        public bool ValidateUser(String loginType, String loginID, String loginPwd, ref String message)
        {
            int count = 0;
            bool isValidUser = false;
            //查询数据库
            if (loginType == "管理员")
            {
                string sql = string.Format("select count(*) from admin where loginID='{0}' and loginPwd='{1}'", loginID, loginPwd);
                try
                {
                    SqlCommand command = new SqlCommand(sql, DBHelper.connection);
                    DBHelper.connection.Open();
                    count = (int)command.ExecuteScalar();
                    if (count == 1)
                    {
                        isValidUser = true;
                    }
                    else
                    {
                        message = "用户名或密码不存在";
                        isValidUser = false;
                    }

                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                finally
                {
                    DBHelper.connection.Close();
                }
            }

            return isValidUser;
        }
                    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("用户名不能为空", "提示", MessageBoxButtons.OKCancel , MessageBoxIcon.Information);
                textBox1.Focus();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("你选择了确定按钮");
                }
                else
                {
                    MessageBox.Show("你选择了取消按钮");
                }
            }
            else if (textBox1.Text != "zoe")
            {
                MessageBox.Show("用户名不正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
            else
            {
                
                //验证数据库用户是否存在
                bool isValidUser = false;
                string message = "";
                
                isValidUser = ValidateUser (comboBox1.Text ,textBox1.Text,textBox2 .Text ,ref message);

                if (isValidUser)
                {
                    UserHelp.loginId = textBox1.Text;
                    UserHelp.loginType = comboBox1.Text;
                    ShowUserForm();
                }
                else
                {
                    MessageBox.Show(message, "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
