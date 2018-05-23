using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登陆
{
    public partial class about1 : Form
    {
        int index=0;
        public about1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < imageList1.Images.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            pictureBox2.Image = imageList1.Images[index];
        }

       

        private void about1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
