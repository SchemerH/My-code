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

    public partial class tiku : Form
    {
        private DataSet dataset = new DataSet();
        private SqlDataAdapter dataadapter;
        public tiku()
        {
            InitializeComponent();
        }

        private void tiku_Load(object sender, EventArgs e)
        {

           
        }
    }
}
