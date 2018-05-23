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
    public partial class 交互界面 : Form
    {
        public 交互界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string time;
            time=dt.ToLongTimeString().ToString();
            if (textBox2.Text != "")
            {

                string str = @" Data Source=DESKTOP-781JML6\SQL;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);
                connection1.Open();
                string sql1 = string.Format("select count(*) from 用户交互");
                SqlCommand command1 = new SqlCommand(sql1, connection1);

                int a = Convert.ToInt32(command1.ExecuteScalar());



             
                string sql = string.Format("insert into 用户交互(用户类型,用户名,时间,发送信息) values ('{0}','{1}','{2}','{3}')",UserHelp.loginType,UserHelp.loginId,time,textBox2.Text);



                try
                {

                    SqlCommand command = new SqlCommand(sql, connection1);
                  

                    int result = command.ExecuteNonQuery();

                    if (result != 1)
                    {
                        MessageBox.Show("添加失败！");
                    }
                    else
                    {
                        string message = string.Format("消息发送成功！");
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
                textBox2.Clear();




                try
                {
                    
                    string sql2 = string.Format("select * from 用户交互 order by 编号");
                    SqlCommand command2 = new SqlCommand(sql2, connection1);
                    connection1.Open();

                    SqlDataReader dataReader;
                    dataReader = command2.ExecuteReader();
                   textBox1.Clear();

                    if (!dataReader.HasRows)
                    {
                        MessageBox.Show("没有查到相关记录！");

                    }
                    else
                    {
                        
                       
                            while (dataReader.Read())
                            {
                                string type;
                                string id;
                                string shijian;
                                string message;
                                int num;

                                type = dataReader["用户类型"].ToString(); ;
                                id = (string)dataReader["用户名"];
                                //      shijian = (string)dataReader["时间"];
                                message = (string)dataReader["发送信息"];
                                num = Convert.ToInt32(dataReader["编号"]); //若是datareader的数据为空，不能用string直接进行转换，否则会出错
                            textBox1.AppendText( type + ":" + id + "\r\n" + message+" \r\n");
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





            if (textBox2.Text == "")
            {

                string str = @" Data Source=DESKTOP-781JML6\SQL;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);
                
               




                try
                {

                    string sql2 = string.Format("select * from 用户交互 order by 编号");
                    SqlCommand command2 = new SqlCommand(sql2, connection1);
                    connection1.Open();

                    SqlDataReader dataReader;
                    dataReader = command2.ExecuteReader();
                    textBox1.Clear();

                    if (!dataReader.HasRows)
                    {
                        MessageBox.Show("没有查到相关记录！");

                    }
                    else
                    {
                        MessageBox.Show("查找成功！");

                        while (dataReader.Read())
                        {
                            string type;
                            string id;
                            string shijian;
                            string message;
                            int num;

                            type = dataReader["用户类型"].ToString(); ;
                            id = (string)dataReader["用户名"];
                            //      shijian = (string)dataReader["时间"];
                            message = (string)dataReader["发送信息"];
                            num = Convert.ToInt32(dataReader["编号"]); //若是datareader的数据为空，不能用string直接进行转换，否则会出错
                            textBox1.AppendText(type + ":" + id + "\r\n" + message + "\r\n");
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
        }
    }
}
