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

namespace order_system
{
    public partial class 訂單明細 : Form
    {
        SqlConnectionStringBuilder scsb;
      
        public 訂單明細()
        {
            InitializeComponent();
        }

        private void 訂單明細_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;

            string[] array = new string[4];

            tbdatetime.Text = DateTime.Now.ToShortDateString();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "SELECT Distinct classroom FROM final WHERE date = @Searchdate";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchdate", DateTime.Now.ToShortDateString());
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read() == true)
            {               
                array[i] = reader["classroom"].ToString();
                i++;
            }

            reader.Close();

            if (Array.IndexOf(array, "CR1") != -1){             
            string strSQL1 = "SELECT s.storename,s.storephone,o.dutymanId,st.studentphone FROM StoreInfo AS s JOIN OrderInfo AS o ON s.storeId = o.storeId JOIN StudentInfo AS st ON st.studentId = o.studentId WHERE o.classroom = @Searchroom AND o.orderdate = @Seachdate ";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            cmd1.Parameters.AddWithValue("@Searchroom", "CR1");
            cmd1.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read() == true)
            {
                lbldetailS1.Text = reader1["storename"].ToString();
                lbldetailSP1.Text = reader1["storephone"].ToString();
                lbldutyD1.Text = reader1["dutymanId"].ToString();
                lbldutyP1.Text = reader1["studentphone"].ToString();
            }
            reader1.Close();

                string strSQL2 = "SELECT prouductname,SUM(amount)AS allnum,SUM(price)AS allprice FROM OrderInfo WHERE classroom = 'CR1'AND orderdate = @Seachdate AND paymoney = '已付' GROUP BY prouductname";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read() == true)
                {
                    string allfood = "";
                    allfood = "";
                    allfood += reader2["prouductname"].ToString() + "\t";
                    allfood += reader2["allnum"].ToString() + "\t";
                    allfood += reader2["allprice"].ToString();

                    lbOd1.Items.Add(allfood);
                }
                reader2.Close();
                string strSQL3 = "SELECT SUM(amount)AS totalnum,SUM(price)AS totalprice FROM OrderInfo WHERE classroom = 'CR1'AND orderdate = @Seachdate AND paymoney = '已付' ";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read() == true)
                {
                    lbltotalN1.Text = reader3["totalnum"].ToString();
                    lbltotalP1.Text = reader3["totalprice"].ToString();
                }
                reader3.Close();

            }
            if (Array.IndexOf(array, "CR2") != -1)
            {
                string strSQL1 = "SELECT s.storename,s.storephone,o.dutymanId,st.studentphone FROM StoreInfo AS s JOIN OrderInfo AS o ON s.storeId = o.storeId JOIN StudentInfo AS st ON st.studentId = o.studentId WHERE o.classroom = @Searchroom AND o.orderdate = @Seachdate ";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@Searchroom", "CR2");
                cmd1.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read() == true)
                {
                    lbldetailS2.Text = reader1["storename"].ToString();
                    lbldetailSP2.Text = reader1["storephone"].ToString();
                    lbldutyD2.Text = reader1["dutymanId"].ToString();
                    lbldutyP2.Text = reader1["studentphone"].ToString();
                }
                reader1.Close();

                string strSQL2 = "SELECT prouductname,SUM(amount)AS allnum,SUM(price)AS allprice FROM OrderInfo WHERE classroom = 'CR2'AND orderdate = @Seachdate AND paymoney = '已付' GROUP BY prouductname";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read() == true)
                {
                    string allfood = "";
                    allfood = "";
                    allfood += reader2["prouductname"].ToString() + "\t";
                    allfood += reader2["allnum"].ToString() + "\t";
                    allfood += reader2["allprice"].ToString();

                    lbOd2.Items.Add(allfood);
                }
                reader2.Close();
                string strSQL3 = "SELECT SUM(amount)AS totalnum,SUM(price)AS totalprice FROM OrderInfo WHERE classroom = 'CR2'AND orderdate = @Seachdate AND paymoney = '已付' ";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read() == true)
                {
                    lbltotalN2.Text = reader3["totalnum"].ToString();
                    lbltotalP2.Text = reader3["totalprice"].ToString();
                }
                reader3.Close();
            }
            if (Array.IndexOf(array, "CR3") != -1)
            {
                string strSQL1 = "SELECT s.storename,s.storephone,o.dutymanId,st.studentphone FROM StoreInfo AS s JOIN OrderInfo AS o ON s.storeId = o.storeId JOIN StudentInfo AS st ON st.studentId = o.studentId WHERE o.classroom = @Searchroom AND o.orderdate = @Seachdate";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@Searchroom", "CR3");
                cmd1.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read() == true)
                {
                    lbldetailS3.Text = reader1["storename"].ToString();
                    lbldetailSP3.Text = reader1["storephone"].ToString();
                    lbldutyD3.Text = reader1["dutymanId"].ToString();
                    lbldutyP3.Text = reader1["studentphone"].ToString();
                }
                reader1.Close();

                string strSQL2 = "SELECT prouductname,SUM(amount)AS allnum,SUM(price)AS allprice FROM OrderInfo WHERE classroom = 'CR3'AND orderdate = @Seachdate AND paymoney = '已付' GROUP BY prouductname";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read() == true)
                {
                    string allfood = "";
                    allfood = "";
                    allfood += reader2["prouductname"].ToString() + "\t";
                    allfood += reader2["allnum"].ToString() + "\t";
                    allfood += reader2["allprice"].ToString();
                    lbOd3.Items.Add(allfood);
                }
                reader2.Close();

                string strSQL3 = "SELECT SUM(amount)AS totalnum,SUM(price)AS totalprice FROM OrderInfo WHERE classroom = 'CR3'AND orderdate = @Seachdate AND paymoney = '已付' ";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read() == true)
                {
                    lbltotalN3.Text = reader3["totalnum"].ToString();
                    lbltotalP3.Text = reader3["totalprice"].ToString();
                }
                reader3.Close();
            }
            if (Array.IndexOf(array, "CR4") != -1)
            {
                string strSQL1 = "SELECT s.storename,s.storephone,o.dutymanId,st.studentphone FROM StoreInfo AS s JOIN OrderInfo AS o ON s.storeId = o.storeId JOIN StudentInfo AS st ON st.studentId = o.studentId WHERE o.classroom = @Searchroom AND o.orderdate = @Seachdate ";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@Searchroom", "CR4");
                cmd1.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read() == true)
                {
                    lbldetailS4.Text = reader1["storename"].ToString();
                    lbldetailSP4.Text = reader1["storephone"].ToString();
                    lbldutyD4.Text = reader1["dutymanId"].ToString();
                    lbldutyP4.Text = reader1["studentphone"].ToString();
                }
                reader1.Close();

                string strSQL2 = "SELECT prouductname,SUM(amount)AS allnum,SUM(price)AS allprice FROM OrderInfo WHERE classroom = 'CR4'AND orderdate = @Seachdate AND paymoney = '已付' GROUP BY prouductname";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read() == true)
                {
                    string allfood = "";
                    allfood = "";
                    allfood += reader2["prouductname"].ToString()+"\t";
                    allfood += reader2["allnum"].ToString() + "\t";
                    allfood += reader2["allprice"].ToString();

                    lbOd4.Items.Add(allfood);                
                }
                reader2.Close();

                string strSQL3 = "SELECT SUM(amount)AS totalnum,SUM(price)AS totalprice FROM OrderInfo WHERE classroom = 'CR4'AND orderdate = @Seachdate AND paymoney = '已付' ";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@Seachdate", DateTime.Now.ToShortDateString());
                SqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read() == true)
                {
                    lbltotalN4.Text = reader3["totalnum"].ToString();
                    lbltotalP4.Text = reader3["totalprice"].ToString();
                }
                reader3.Close();
            }

            con.Close();



        }

    }
}
