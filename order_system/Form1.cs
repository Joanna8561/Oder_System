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
using System.IO;

namespace order_system
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string saveFilePath = "";
        public Form1()
        {
            InitializeComponent();
           
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabPage1.Parent = this.tabControl1;//顯示
            this.tabPage2.Parent = null;//隱藏
            this.tabPage3.Parent = null;//隱藏

            radioStudent.Checked = true;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            //scsb.UserID = "";
            //scsb.Password = "";

            //-------- 店家查詢ComboBox --------
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select storename from StoreInfo";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                comboB店家查詢.Items.Add(reader["storename"]);
                cbB商品店家.Items.Add(reader["storename"]);
                cB商品店家.Items.Add(reader["storename"]);
            }
            reader.Close();
            //-------- 學生查詢ComboBox --------
            string strSQL1 = "SELECT  DISTINCT classroom FROM StudentInfo";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read() == true)
            {
                cbB教室查詢.Items.Add(reader1["classroom"]);
                cbB班級.Items.Add(reader1["classroom"]);
            }
            reader1.Close();           
            con.Close();

        }

        private void btn新增店家_Click(object sender, EventArgs e)
        {
            lbl店家序號.Text = "";
            tb店名.Text = "";
            tb電話.Text = "";
            tb電話2.Text = "";
            tb地址.Text = "";
            tb外送數量.Text = "";

        }

        private void btn店儲存_Click(object sender, EventArgs e)
        {
            if (tb店名.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into StoreInfo values(@NewName,@NewPhone,@NewPhone2,@NewAddress,@Newdelinum,@Newimg)";
                SqlCommand cmd = new SqlCommand(strSQL, con);           
                cmd.Parameters.AddWithValue("@NewName", tb店名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", tb電話.Text);
                cmd.Parameters.AddWithValue("@NewPhone2", tb電話2.Text);
                cmd.Parameters.AddWithValue("@NewAddress", tb地址.Text);
                int int數量 = 0;
                Int32.TryParse(tb外送數量.Text, out int數量);
                cmd.Parameters.AddWithValue("@Newdelinum", int數量);
                cmd.Parameters.AddWithValue("@Newimg", saveFilePath);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料新增完畢,筆數:" + rows.ToString());
            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }
        }

        private void btn更新_Click(object sender, EventArgs e)
        {
            comboB店家查詢.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select storename from StoreInfo";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                comboB店家查詢.Items.Add(reader["storename"]);
            }
            reader.Close();
            con.Close();

            MessageBox.Show("更新已完成");
        }

        private void btn店家修改_Click(object sender, EventArgs e)
        {
            int int序號 = 0;
            Int32.TryParse(lbl店家序號.Text, out int序號);
            if (int序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update StoreInfo set storename=@NewName, storephone=@NewPhone, storephone2=@NewPhone2, storeaddress=@NewAddress, deliverynum=@Newdelinum,img=@Newimg  WHERE storeId=@SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", int序號);
                cmd.Parameters.AddWithValue("@NewName", tb店名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", tb電話.Text);
                cmd.Parameters.AddWithValue("@NewPhone2", tb電話2.Text);
                cmd.Parameters.AddWithValue("@NewAddress", tb地址.Text);
                int int數量 = 0;
                Int32.TryParse(tb外送數量.Text, out int數量);
                cmd.Parameters.AddWithValue("@Newdelinum", int數量);
                cmd.Parameters.AddWithValue("@Newimg", saveFilePath);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改完畢,筆數:" + rows.ToString());
            }
        }

        private void btn店家刪除_Click(object sender, EventArgs e)
        {
            int int序號 = 0;
            Int32.TryParse(lbl店家序號.Text, out int序號);

            if (int序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();

                string strSQL1 = "DELETE FROM ProductInfo WHERE storeId=@SearchId";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@SearchId", int序號);
                cmd1.ExecuteNonQuery();             
             
                string strSQL = "delete from StoreInfo where storeId = @SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", int序號);
                int rows = cmd.ExecuteNonQuery();               
                
                lbl店家序號.Text = "";
                tb店名.Text = "";
                tb電話.Text = "";
                tb電話2.Text = "";
                tb地址.Text = "";
                tb外送數量.Text = "";

                MessageBox.Show("店家資料刪除完畢,筆數:" + rows.ToString());
                con.Close();
            }
        }

        private void comboB店家查詢_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboB店家查詢.SelectedIndex != -1)
            { //搜尋姓名
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "select * from StoreInfo where Storename like @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", comboB店家查詢.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lbl店家序號.Text = string.Format("{0}", (int)reader["storeId"]);
                    tb店名.Text = string.Format("{0}", (string)reader["storename"]);
                    tb電話.Text = string.Format("{0}", (string)reader["storephone"]);

                    if (reader["storephone2"] != null)
                    {
                        tb電話2.Text = string.Format("{0}", (string)reader["storephone2"]);
                    }
                    else
                    {
                        tb電話2.Text = "";
                    }

                    tb地址.Text = string.Format("{0}", (string)reader["storeaddress"]);
                    tb外送數量.Text = string.Format("{0}", (int)reader["deliverynum"]);

                    if (reader["img"] != null)
                    {
                        picBox圖片.ImageLocation = reader["img"].ToString();
                    }
                    else
                    {

                    }

                }

                reader.Close();
                con.Close();
            }
        }

        private void cbB教室查詢_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBox學員.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "SELECT studentname  FROM StudentInfo WHERE classroom = @SearchRoom ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchRoom", cbB教室查詢.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                lBox學員.Items.Add((string)reader["studentname"]);
            }
            reader.Close();
            con.Close();
        }

        private void lBox學員_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "SELECT * FROM StudentInfo WHERE studentname = @SearchName ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", lBox學員.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                lbl學生序號.Text = string.Format("{0}", (int)reader["studentId"]);
                cbB班級.SelectedItem = reader["classroom"];
                tb學員姓名.Text = string.Format("{0}", (string)reader["studentname"]);          
                tb學員電話.Text =string.Format("{0}",(string)reader["studentphone"]);
                cbB班級.Enabled = false;
            }

            reader.Close();
            con.Close();
        }

        private void btn新增學員_Click(object sender, EventArgs e)
        {
            lbl學生序號.Text = "";
            cbB班級.Enabled = true;
            tb學員姓名.Text = "";
            tb學員電話.Text = "";

            if (cbB教室查詢.SelectedIndex != -1)
            {
                int strId = 0;
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "SELECT MAX(studentId)AS stId FROM StudentInfo WHERE classroom = @Searchroom";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchroom", cbB教室查詢.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    strId = (int)reader["stId"];
                }
                reader.Close();

                lbl學生序號.Text = (strId + 1).ToString(); ;

                con.Close();
            }

            cbB班級.SelectedItem = cbB教室查詢.SelectedItem;

        }

        private void btn學員儲存_Click(object sender, EventArgs e)
        {

            if (tb學員姓名.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into StudentInfo values(@studentId, @NewClass,@NewName,@NewPhone)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@studentId", Convert.ToInt32(lbl學生序號.Text));
                cmd.Parameters.AddWithValue("@NewClass", cbB班級.SelectedItem);
                cmd.Parameters.AddWithValue("@NewName", tb學員姓名.Text);              
                cmd.Parameters.AddWithValue("@NewPhone", tb學員電話.Text);               
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料新增完畢,筆數:" + rows.ToString());
            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }

            if (cbB班級.SelectedItem == cbB教室查詢.SelectedItem)
            {
                lBox學員.Items.Clear();
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "SELECT studentname  FROM StudentInfo WHERE classroom = @SearchRoom ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchRoom", cbB教室查詢.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    lBox學員.Items.Add((string)reader["studentname"]);
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn學員刪除_Click(object sender, EventArgs e)
        {
            int int學生序號 = 0;
            Int32.TryParse(lbl學生序號.Text, out int學生序號);

            if (int學生序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from StudentInfo where studentId = @SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", (int)int學生序號);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料刪除完畢,筆數:" + rows.ToString());

                lbl學生序號.Text = "";
                cbB班級.SelectedIndex = -1;
                tb學員姓名.Text = "";
                tb學員電話.Text = "";
            }

            lBox學員.Items.Clear();
            SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            string strSQL1 = "SELECT studentname  FROM StudentInfo WHERE classroom = @SearchRoom ";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            cmd1.Parameters.AddWithValue("@SearchRoom", cbB教室查詢.SelectedItem);
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read() == true)
            {
                lBox學員.Items.Add((string)reader["studentname"]);
            }
            reader.Close();
            con1.Close();

        }

        private void btn學員修改_Click(object sender, EventArgs e)
        {
            int int學生序號 = 0;
            Int32.TryParse(lbl學生序號.Text, out int學生序號);
            if (int學生序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update StudentInfo set classroom=@NewClass, studentname=@NewName, studentphone=@NewPhone where studentId=@SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", int學生序號);
                cmd.Parameters.AddWithValue("@NewClass", cbB班級.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NewName", tb學員姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", tb學員電話.Text);

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("資料修改完畢,筆數:" + rows.ToString());
                con.Close();
                
            }
        }

        private void cbB商品店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBox商品.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "SELECT productname  FROM ProductInfo WHERE storeId = (SELECT storeId FROM StoreInfo WHERE storename = @SearchName)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", cbB商品店家.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                lBox商品.Items.Add((string)reader["productname"]);
            }
            reader.Close();
            con.Close();
        }

        private void lBox商品_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "SELECT s.storename,p.productname,p.price FROM ProductInfo AS p JOIN StoreInfo AS s ON p.storeId = s.storeId WHERE productname = @SearchName AND storename = @SearchS";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", lBox商品.SelectedItem);
            cmd.Parameters.AddWithValue("@SearchS", cbB商品店家.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {

                cB商品店家.SelectedItem = string.Format("{0}", (string)reader["storename"]);
                tb商品品名.Text = string.Format("{0}", (string)reader["productname"]);

                tb商品售價.Text = string.Format("{0}", (int)reader["price"]);
            }

            reader.Close();
            con.Close();
        }

        private void btn新增品項_Click(object sender, EventArgs e)
        {
            cB商品店家.Enabled = true;
            cB商品店家.SelectedIndex = -1;
            tb商品品名.Text = "";
            tb商品售價.Text = "";

        }

        private void btn商品儲存_Click(object sender, EventArgs e)
        {
            if (tb商品品名.Text.Length > 0 && tb商品售價.Text.Length > 0 && cB商品店家.SelectedIndex != -1)
            {
                int storeId = 0;
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL1 = "SELECT storeId FROM storeInfo WHERE storename = @SearchName";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@SearchName", cB商品店家.SelectedItem);
                SqlDataReader reader = cmd1.ExecuteReader();

                if (reader.Read() == true)
                {
                    storeId = (int)reader["storeId"];
                }
               
                reader.Close();


                string strSQL = "insert into ProductInfo values(@NewstoreId, @Newproductname, @Newprice)";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@NewstoreId", storeId);
                cmd.Parameters.AddWithValue("@Newproductname", tb商品品名.Text);
                cmd.Parameters.AddWithValue("@Newprice", tb商品售價.Text);

                int rows = cmd.ExecuteNonQuery();

                string strSQL3 = "SELECT productname  FROM ProductInfo WHERE storeId = (SELECT storeId FROM StoreInfo WHERE storename = @SearchName)";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@SearchName", cbB商品店家.SelectedItem.ToString());
                SqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read() == true)
                {
                    lBox商品.Items.Add((string)reader3["productname"]);
                }
                reader3.Close();

                con.Close();
                MessageBox.Show("資料新增完畢,筆數:" + rows.ToString());


            }
            else
            {
                if (tb商品品名.Text != "")
                {
                    MessageBox.Show("請輸入商品售價");
                }
                else if (tb商品售價.Text != "")
                {
                    MessageBox.Show("請輸入商品名稱");
                }
                else if (cB商品店家.SelectedIndex == -1)
                {
                    MessageBox.Show("請選擇店家");
                }
            }
        }

        private void btn商品修改_Click(object sender, EventArgs e)
        {
            int storeId = 0, nstoreId = 0;

            if (cB商品店家.SelectedIndex!= -1)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL1 = "SELECT storeId FROM storeInfo WHERE storename = @SearchName";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@SearchName", cbB商品店家.SelectedItem);            
                SqlDataReader reader = cmd1.ExecuteReader();             
                if (reader.Read() == true )
                {
                    storeId = (int)reader["storeId"];
                    
                }
                reader.Close();

                string strSQL2 = "SELECT storeId FROM storeInfo WHERE storename = @SearchName";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@SearchName", cB商品店家.SelectedItem);
                SqlDataReader reader1 = cmd2.ExecuteReader();
                if (reader1.Read() == true)
                {
                    nstoreId = (int)reader1["storeId"];

                }
                reader1.Close();

                string strSQL = "UPDATE  ProductInfo set storeId=@NewId, productname=@NewName, price=@NewPrice where productname=@SearchName AND storeId = @SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", storeId);
                cmd.Parameters.AddWithValue("@SearchName", lBox商品.SelectedItem);
                cmd.Parameters.AddWithValue("@NewId", nstoreId);
                cmd.Parameters.AddWithValue("@NewName", tb商品品名.Text);
                cmd.Parameters.AddWithValue("@Newprice", tb商品售價.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改完畢,筆數:" + rows.ToString());
            }
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            int storeId = 0;
            if (tb商品品名.TextLength > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL2 = "SELECT storeId FROM storeInfo WHERE storename = @SearchName";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@SearchName", cB商品店家.SelectedItem);
                SqlDataReader reader1 = cmd2.ExecuteReader();
                if (reader1.Read() == true)
                {
                    storeId = (int)reader1["storeId"];
                }
                reader1.Close();

                string strSQL = "delete from ProductInfo where productname = @SearchName AND storeId = @SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", tb商品品名.Text);
                cmd.Parameters.AddWithValue("@SearchId", storeId);

                int rows = cmd.ExecuteNonQuery();

                lBox商品.Items.Clear();

                string strSQL3 = "SELECT productname  FROM ProductInfo WHERE storeId = (SELECT storeId FROM StoreInfo WHERE storename = @SearchName)";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                cmd3.Parameters.AddWithValue("@SearchName", cbB商品店家.SelectedItem.ToString());
                SqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read() == true)
                {
                    lBox商品.Items.Add((string)reader3["productname"]);
                }
                reader3.Close();

                con.Close();
                MessageBox.Show("資料刪除完畢,筆數:" + rows.ToString());

                cB商品店家.SelectedIndex = -1;
                tb商品品名.Text = "";
                tb商品售價.Text = "";
            }
        }

        private void radioStudent_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioStudent.Checked)
            {
                this.tabPage1.Parent = this.tabControl1;//顯示
                this.tabPage2.Parent = null;//隱藏
                this.tabPage3.Parent = null;//隱藏
            }

        }

        private void radioStore_CheckedChanged(object sender, EventArgs e)
        {

            if (radioStore.Checked)
            {
                this.tabPage1.Parent = null;//顯示
                this.tabPage2.Parent = this.tabControl1;//隱藏
                this.tabPage3.Parent = null;//隱藏
            }

        }

        private void radioProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProduct.Checked)
            {
                this.tabPage1.Parent = null;//顯示
                this.tabPage2.Parent = null;//隱藏
                this.tabPage3.Parent = this.tabControl1;//隱藏
            }
        }

        private void cbB班級_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void 匯入_Click(object sender, EventArgs e)
        {
            string csharppath = System.Windows.Forms.Application.StartupPath; //取得目前檔案位置
            string localFilePath = "";
           

            OpenFileDialog openFileDialog = new OpenFileDialog();//打開檔案
            if (openFileDialog.ShowDialog() == DialogResult.OK) //當選取完檔案後按下確認時
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName); //讀取該圖片檔案的串流
                localFilePath = openFileDialog.FileName.ToString();//當下圖片的路徑
                saveFilePath = csharppath+ @"\storepictures\" + Path.GetFileName(openFileDialog.FileName)/*只取得檔案名稱*/;
                File.Copy(localFilePath, saveFilePath, true);
                MessageBox.Show(saveFilePath);
                picBox圖片.ImageLocation = saveFilePath;
            }


        }

        
    }
}
