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
    public partial class 审查结果查询 : Form
    {
        public 审查结果查询()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @" Data Source=DESKTOP-RL51JAQ\SQLSERVER;Initial Catalog=bike;Integrated Security=SSPI";
            SqlConnection connection1 = new SqlConnection(str);


            try
            {
                string sql = string.Format("select * from 待审核车辆 where 车辆编号='{0}'", textBox1.Text);
                connection1.Open();
                SqlCommand command = new SqlCommand(sql, connection1);


                
                SqlDataReader mysdr = command.ExecuteReader();
                if (mysdr.HasRows)
                {
                    MessageBox.Show("车辆尚未被审核！");
                    mysdr.Close();
                    connection1.Close();
                    
                }
                
            
                else
                  {
                    mysdr.Close();
                    
                    string sql1 = string.Format("select * from 库存车辆 where 车辆编号='{0}'", textBox1.Text);
                    
                    SqlCommand command1 = new SqlCommand(sql1, connection1);
                      
                    SqlDataReader mysdr1 = command1.ExecuteReader();
                    if (mysdr1.HasRows)
                    {
                        MessageBox.Show("已通过审核！");
                        mysdr1.Close();
                        connection1.Close();
                    }


                         else
                         {
                        
                        mysdr1.Close();
                        string sql2 = string.Format("select 未通过原因 from 未通过原因 where 车辆编号='{0}'", textBox1.Text);
                             SqlCommand command2 = new SqlCommand(sql2, connection1);
                             
                           SqlDataReader mysdr2 = command2.ExecuteReader();
                           if (mysdr2.HasRows)
                           {
                               MessageBox.Show("未通过审核！");

                               string reason;
                               while (mysdr2.Read())
                               {
                                   reason = mysdr2["未通过原因"].ToString();
                                   string message = string.Format("您的申请不合要求，原因如下：{0}", reason);
                                   MessageBox.Show(message);
                               }

                               connection1.Close();
                               mysdr2.Close();
                           }

                             else
                             {
                                 MessageBox.Show("不存在的编号！");
                             }

                         }
                          


                }
               
              
            }
            catch (Exception)
            {
                MessageBox.Show("操作数据库出错");
            }
            connection1.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
