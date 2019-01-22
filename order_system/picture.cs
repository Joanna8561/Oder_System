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
    public partial class picture : Form
    {
        public picture()
        {
            InitializeComponent();
        }
        string file="";

        private string bigp;
        public string bigP
        {
            set
            {
                bigp = value;
            }
        }

        public void SetValue()
        {
            this.file = bigp;
        }

        private void picture_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = file;

        }


    }
}
