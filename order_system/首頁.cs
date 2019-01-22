using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_system
{
    public partial class 首頁 : Form
    {
        public 首頁()
        {
            InitializeComponent();
        }

        private void btncounter_Click(object sender, EventArgs e)
        {

            訂單明細 OrderData = new 訂單明細();
            OrderData.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            登入 enter = new 登入();
            enter.ShowDialog();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            Form1 Data = new Form1();
            Data.ShowDialog();
        }
    }
}
