using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8
{
    public partial class t : Form
    {
        public t()
        {
            InitializeComponent();
        }

        private void t_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“testDataSet.student”中。您可以根据需要移动或移除它。
            this.studentTableAdapter.Fill(this.testDataSet.student);

        }
    }
}
