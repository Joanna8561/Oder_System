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
    
    public partial class 登入 : Form
    {
        public string strControl = "";
        string classroom = "";

        public 登入()
        {
            InitializeComponent();
        }
        public delegate void SendValueDelegate(string pValue);

        public event SendValueDelegate SendValueCallback;

        private void btnDutyMan_Click(object sender, EventArgs e)
        {
            if (cbClasscho.SelectedIndex != -1)
            {
                訂單 order = new 訂單();
                this.strControl = "dutyman";
                this.SendValueCallback += new SendValueDelegate(order.ReceiveValueCallbackFun);
                this.SendValueCallback(strControl);
                order.StrClass = classroom;//設置Form2中string1的值  
                order.SetValue();//設置Form2中Label1的  
                order.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇教室", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            if (cbClasscho.SelectedIndex != -1)
            {
                訂單 order = new 訂單();
                this.strControl = "general";
                this.SendValueCallback += new SendValueDelegate(order.ReceiveValueCallbackFun);
                this.SendValueCallback(strControl);
                order.StrClass = classroom;//設置Form2中string1的值  
                order.SetValue();//設置Form2中Label1的  
                order.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇教室", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void cbClasscho_SelectedIndexChanged(object sender, EventArgs e)
        {
            classroom = "";
            if (cbClasscho.SelectedIndex == 0)
            {
                classroom = "CR1";
            }
            else if (cbClasscho.SelectedIndex == 1)
            {
                classroom = "CR2";
            }
            else if (cbClasscho.SelectedIndex == 2)
            {
                classroom = "CR3";
            }
            else if (cbClasscho.SelectedIndex == 3)
            {
                classroom = "CR4";
            }
        }
    }
}
