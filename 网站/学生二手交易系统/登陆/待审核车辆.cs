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
    public partial class 问题说明 : Form
    {
        public 问题说明()
        {
            InitializeComponent();
        }

        private void 待审核车辆_Load(object sender, EventArgs e)
        {
           
        }

        private void 提交_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                string str = @" Data Source=DESKTOP-781JML6\SQL;Initial Catalog=bike;Integrated Security=SSPI";
                SqlConnection connection1 = new SqlConnection(str);
                string sql = string.Format("insert into 未通过原因(车辆编号,未通过原因) values('{0}','{1}')",UserHelp.num,textBox1.Text);

                SqlCommand command = new SqlCommand(sql, connection1);
                connection1.Open();

                result = command.ExecuteNonQuery();
                if (result < 1)
                {
                    MessageBox.Show("提交失败");
                }
                else
                {
                    MessageBox.Show("提交成功");

                }
                connection1.Close();


            }
            catch
            {
            }
            finally
            {
               
            }
            this.Close();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
