using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace _8
{
    public partial class infolist : Form
    {
        private DataSet dataset = new DataSet();
        private SqlDataAdapter dataadapter;

        public infolist()
        {
            InitializeComponent();
        }

        private void infolist_Load(object sender, EventArgs e)
        {
            string sql = "select 姓名,性别,班级,年级,政治面貌 from student";
           
            dataadapter = new SqlDataAdapter(sql, DBHelper.connection);
            //填充数据集
            dataadapter.Fill(dataset,"student");

            dataGridView1.DataSource =dataset.Tables ["student"];
            //foreach (DataRow row in dataset.Tables[0].Rows)
           // {
                //Console.WriteLine("{0}\t{1}\t{2}",row["姓名"],row["性别"],row["政治面貌"]);
               
           // }
        }
    }
}
