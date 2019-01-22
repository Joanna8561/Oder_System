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
using System.Collections;

namespace order_system
{
    public partial class 訂單 : Form
    {
        SqlConnectionStringBuilder scsb;
        string receive = "";
        string reclass = "";
        string strOdetai = "";
        int biandangNum = 1;
        int Pprice = 0;
        int Ppricetotal = 0;
        int schId = 0;
        int checkId = 0;//付款按鈕中的id

        private string strClass;
        public string StrClass
        {
            set
            {
                strClass = value;
            }
        }

        public void SetValue()
        {
            this.reclass = strClass;
        }

        public 訂單()
        {
            InitializeComponent();
            this.dutyOrder.Parent = null;//顯示
            this.generalOrder.Parent = null;//隱藏
        }
        public void ReceiveValueCallbackFun(string pValue)
        {
            receive = pValue;
        }

        private void 訂單_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            //跳頁的傳值判斷
            if (receive == "dutyman")
            {
                this.dutyOrder.Parent = this.tabControl1;//顯示
                this.generalOrder.Parent = null;//隱藏

            }
            else if (receive == "general")
            {
                this.dutyOrder.Parent = null; //顯示
                this.generalOrder.Parent = this.tabControl1;//隱藏
               

                if (reclass == "CR1")
                {
                    //CR1學員設定   
                    string strSn = "";

                    //取得今日的訂單資訊-CR1---------------------
                    string strSQL2 = "SELECT * FROM temporder WHERE classroom = @Searchroom AND date = @todate";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@Searchroom", reclass);
                    cmd2.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read() == true)
                    {

                        tbdutyman.Text = (string)reader2["dutyname"];
                        strSn = (string)reader2["optstore"];
                        lbldate.Text = reader2["date"].ToString();
                        tbstore.Text = strSn;
                    }

                    reader2.Close();

                    //將店家名稱轉Id--CR1----------------------------
                    int IdwithS = 0;
                    string strSQL3 = "SELECT storeId,img FROM StoreInfo WHERE storename = @Searchname";
                    SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                    cmd3.Parameters.AddWithValue("@Searchname", strSn);
                    SqlDataReader reader3 = cmd3.ExecuteReader();

                    if (reader3.Read() == true)
                    {
                        IdwithS = (int)reader3["storeId"];
                        if (reader3["img"] != null)
                        {
                            pbstore2.ImageLocation = reader3["img"].ToString();
                        }
                    }

                    reader3.Close();

                    //將店家商品找出-CR1--------------------------------
                    string strSQL4 = "SELECT productname FROM ProductInfo WHERE storeId = @SearchId";
                    SqlCommand cmd4 = new SqlCommand(strSQL4, con);
                    cmd4.Parameters.AddWithValue("@SearchId", IdwithS);
                    SqlDataReader reader4 = cmd4.ExecuteReader();
                    while (reader4.Read() == true)
                    {
                        cbCustP.Items.Add((string)reader4["productname"]);
                    }

                    reader4.Close();

                    //lbl今日訂購狀態的輸出-CR1-------------------------------------
                    string SQLstr5 = "SELECT s.studentname,o.prouductname,o.amount,o.price,o.paymoney,o.remark FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate";
                    SqlCommand cmd5 = new SqlCommand(SQLstr5, con);
                    cmd5.Parameters.AddWithValue("@searchClass", reclass);
                    cmd5.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read() == true)
                    {
                        strOdetai += reader5["studentname"] + "\t";
                        strOdetai += reader5["prouductname"] + "     ";
                        strOdetai += reader5["amount"] + "\t";
                        strOdetai += reader5["price"] + "\t";
                        strOdetai += reader5["paymoney"] + "       ";
                        strOdetai += reader5["remark"];

                        lbOdetail.Items.Add(strOdetai);
                        strOdetai = "";
                    }

                    reader5.Close();

                }
                else if (reclass == "CR2")
                { 
                    //CR2學員設定  
                    string strSn = "";

                    //取得今日的訂單資訊-CR2---------------------

                    string strSQL2 = "SELECT * FROM temporder WHERE classroom = @Searchroom AND date = @todate ";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@Searchroom", reclass);
                    cmd2.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read() == true)
                    {
                        tbdutyman.Text = (string)reader2["dutyname"];
                        strSn = (string)reader2["optstore"];
                        lbldate.Text = reader2["date"].ToString();
                        tbstore.Text = strSn;
                    }

                    reader2.Close();

                    //將店家名稱轉Id-CR2-----------------------------

                    int IdwithS = 0;
                    string strSQL3 = "SELECT storeId,img FROM StoreInfo WHERE storename = @Searchname";
                    SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                    cmd3.Parameters.AddWithValue("@Searchname", strSn);
                    SqlDataReader reader3 = cmd3.ExecuteReader();

                    if (reader3.Read() == true)
                    {
                        IdwithS = (int)reader3["storeId"];
                        if (reader3["img"] != null)
                        {
                            pbstore2.ImageLocation = reader3["img"].ToString();
                        }
                    }

                    reader3.Close();

                    //將店家商品找出-CR2--------------------------------

                    string strSQL4 = "SELECT productname FROM ProductInfo WHERE storeId = @SearchId";
                    SqlCommand cmd4 = new SqlCommand(strSQL4, con);
                    cmd4.Parameters.AddWithValue("@SearchId", IdwithS);
                    SqlDataReader reader4 = cmd4.ExecuteReader();
                    while (reader4.Read() == true)
                    {
                        cbCustP.Items.Add((string)reader4["productname"]);
                    }

                    reader4.Close();

                    //lbl今日訂購狀態的輸出-CR2-------------------------------------

                    string SQLstr5 = "SELECT s.studentname,o.prouductname,o.amount,o.price,o.paymoney,o.remark FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate";
                    SqlCommand cmd5 = new SqlCommand(SQLstr5, con);
                    cmd5.Parameters.AddWithValue("@searchClass", reclass);
                    cmd5.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read() == true)
                    {
                        strOdetai += reader5["studentname"] + "\t";
                        strOdetai += reader5["prouductname"] + "     ";
                        strOdetai += reader5["amount"] + "\t";
                        strOdetai += reader5["price"] + "\t";
                        strOdetai += reader5["paymoney"] + "       ";
                        strOdetai += reader5["remark"];

                        lbOdetail.Items.Add(strOdetai);
                        strOdetai = "";
                    }

                    reader5.Close();
                }
                else if (reclass == "CR3")
                {
                    //CR3學員設定  
                    string strSn = "";

                    //取得今日的訂單資訊-CR3---------------------

                    string strSQL2 = "SELECT * FROM temporder WHERE classroom = @Searchroom AND date = @todate";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@Searchroom", reclass);
                    cmd2.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read() == true)
                    {
                        tbdutyman.Text = (string)reader2["dutyname"];
                        strSn = (string)reader2["optstore"];
                        lbldate.Text = reader2["date"].ToString();
                        tbstore.Text = strSn;
                    }

                    reader2.Close();

                    //將店家名稱轉Id-CR3-----------------------------

                    int IdwithS = 0;
                    string strSQL3 = "SELECT storeId,img FROM StoreInfo WHERE storename = @Searchname";
                    SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                    cmd3.Parameters.AddWithValue("@Searchname", strSn);
                    SqlDataReader reader3 = cmd3.ExecuteReader();

                    if (reader3.Read() == true)
                    {
                        IdwithS = (int)reader3["storeId"];
                        if (reader3["img"] != null)
                        {
                            pbstore2.ImageLocation = reader3["img"].ToString();
                        }
                    }

                    reader3.Close();

                    //將店家商品找出-CR3--------------------------------

                    string strSQL4 = "SELECT productname FROM ProductInfo WHERE storeId = @SearchId";
                    SqlCommand cmd4 = new SqlCommand(strSQL4, con);
                    cmd4.Parameters.AddWithValue("@SearchId", IdwithS);
                    SqlDataReader reader4 = cmd4.ExecuteReader();
                    while (reader4.Read() == true)
                    {
                        cbCustP.Items.Add((string)reader4["productname"]);
                    }

                    reader4.Close();

                    //lbl今日訂購狀態的輸出-CR3-------------------------------------

                    string SQLstr5 = "SELECT s.studentname,o.prouductname,o.amount,o.price,o.paymoney,o.remark FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate";
                    SqlCommand cmd5 = new SqlCommand(SQLstr5, con);
                    cmd5.Parameters.AddWithValue("@searchClass", reclass);
                    cmd5.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read() == true)
                    {
                        strOdetai += reader5["studentname"] + "\t";
                        strOdetai += reader5["prouductname"] + "     ";
                        strOdetai += reader5["amount"] + "\t";
                        strOdetai += reader5["price"] + "\t";
                        strOdetai += reader5["paymoney"] + "       ";
                        strOdetai += reader5["remark"];

                        lbOdetail.Items.Add(strOdetai);
                        strOdetai = "";
                    }

                    reader5.Close();
                }
                else if (reclass == "CR4")
                {
                    //CR4學員設定  
                    string strSn = "";

                    //取得今日的訂單資訊-CR4---------------------

                    string strSQL2 = "SELECT * FROM temporder WHERE classroom = @Searchroom AND date = @todate";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@Searchroom", reclass);
                    cmd2.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read() == true)
                    {
                        tbdutyman.Text = (string)reader2["dutyname"];
                        strSn = (string)reader2["optstore"];
                        lbldate.Text = reader2["date"].ToString();
                        tbstore.Text = strSn;
                    }

                    reader2.Close();

                    //將店家名稱轉Id-CR4-----------------------------

                    int IdwithS = 0;
                    string strSQL3 = "SELECT storeId,img FROM StoreInfo WHERE storename = @Searchname";
                    SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                    cmd3.Parameters.AddWithValue("@Searchname", strSn);
                    SqlDataReader reader3 = cmd3.ExecuteReader();

                    if (reader3.Read() == true)
                    {
                        IdwithS = (int)reader3["storeId"];
                        if (reader3["img"] != null)
                        {
                            pbstore2.ImageLocation = reader3["img"].ToString();
                        }
                    }

                    reader3.Close();

                    //將店家商品找出-CR4--------------------------------

                    string strSQL4 = "SELECT productname FROM ProductInfo WHERE storeId = @SearchId";
                    SqlCommand cmd4 = new SqlCommand(strSQL4, con);
                    cmd4.Parameters.AddWithValue("@SearchId", IdwithS);
                    SqlDataReader reader4 = cmd4.ExecuteReader();
                    while (reader4.Read() == true)
                    {
                        cbCustP.Items.Add((string)reader4["productname"]);
                    }

                    reader4.Close();

                    //lbl今日訂購狀態的輸出-CR4-------------------------------------

                    string SQLstr5 = "SELECT s.studentname,o.prouductname,o.amount,o.price,o.paymoney,o.remark FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate ";
                    SqlCommand cmd5 = new SqlCommand(SQLstr5, con);
                    cmd5.Parameters.AddWithValue("@searchClass", reclass);
                    cmd5.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read() == true)
                    {
                        strOdetai += reader5["studentname"] + "\t";
                        strOdetai += reader5["prouductname"] + "     ";
                        strOdetai += reader5["amount"] + "\t";
                        strOdetai += reader5["price"] + "\t";
                        strOdetai += reader5["paymoney"] + "       ";
                        strOdetai += reader5["remark"];

                        lbOdetail.Items.Add(strOdetai);
                        strOdetai = "";
                    }

                    reader5.Close();
                }

            }

            //時間計數器
            timer1.Interval = 33;
            timer1.Enabled = true;

            // 值日生，學生的comboBox選單 
            string strSQL = "SELECT StudentName FROM studentInfo WHERE classroom = @Searchroom Order BY studentId ASC";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchroom", reclass);
            SqlDataReader reader = cmd.ExecuteReader();
            string ss = "";
            while (reader.Read() == true)
            {
               
                ss += (string)reader["studentName"];
                cbDutyMan.Items.Add(ss);
                cbcustomer.Items.Add(ss);
                ss = "";
            }

            reader.Close();

            //值日生端 店家選單
            string strSQL1 = "SELECT storename FROM StoreInfo";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read() == true)
            {
                cbOptS.Items.Add(reader1["storename"]);
            }

            reader1.Close();

            //讀出值日生是否已建立訂單

            string strSQLfind = "SELECT dutyname,optstore FROM temporder WHERE date =@SearchDate AND  classroom = @Searchroom";
            SqlCommand cmdf = new SqlCommand(strSQLfind, con);
            cmdf.Parameters.AddWithValue("@Searchroom", reclass);
            cmdf.Parameters.AddWithValue("@SearchDate", DateTime.Now.ToShortDateString());
            SqlDataReader readerf = cmdf.ExecuteReader();

            
            if (readerf.Read() == true)
            {
                cbDutyMan.SelectedItem = readerf["dutyname"].ToString();
                cbOptS.SelectedItem = readerf["optstore"].ToString();
                transfer();
            }

            readerf.Close();

            string strSQLfind1 = "SELECT prouductname, amount, price, remark FROM OrderInfo  WHERE orderdate =@SearchDate AND classroom = @Searchroom AND studentId = @SearchId";
            SqlCommand cmdf1 = new SqlCommand(strSQLfind1, con);
            cmdf1.Parameters.AddWithValue("@Searchroom", reclass);
            cmdf1.Parameters.AddWithValue("@SearchDate", DateTime.Now.ToShortDateString());
            cmdf1.Parameters.AddWithValue("@SearchId", schId);
            SqlDataReader readerf1 = cmdf1.ExecuteReader();

            if (readerf1.Read() == true)                
            {
                cbOptP.SelectedItem = readerf1["prouductname"].ToString();
                tbNum.Text = readerf1["amount"].ToString();
                tbPprice.Text= readerf1["price"].ToString();
                tbremark.Text = readerf1["remark"].ToString();
                
            }

            readerf1.Close();

            //值日生端訂單狀態

            string SQLstrlbl = "SELECT s.studentname,o.prouductname,o.amount,o.price,o.paymoney,o.remark FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate ";
            SqlCommand cmdlbl = new SqlCommand(SQLstrlbl, con);
            cmdlbl.Parameters.AddWithValue("@searchClass", reclass);
            cmdlbl.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
            SqlDataReader readerlbl = cmdlbl.ExecuteReader();

            while (readerlbl.Read() == true)
            {
                strOdetai += readerlbl["studentname"] + "\t";
                strOdetai += readerlbl["prouductname"] + "          ";
                strOdetai += readerlbl["amount"] + "\t";
                strOdetai += readerlbl["price"] + "     ";
                strOdetai += readerlbl["paymoney"] + "    ";
                strOdetai += readerlbl["remark"];

                lbOrder.Items.Add(strOdetai);
                strOdetai = "";
            }

            readerlbl.Close();

            //付錢combBOX 

            string strSQLpay = "SELECT s.studentname FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate ";
            SqlCommand cmdp = new SqlCommand(strSQLpay, con);
            cmdp.Parameters.AddWithValue("@searchClass", reclass);
            cmdp.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
            SqlDataReader readerp = cmdp.ExecuteReader();
            while (readerp.Read() == true)
            {
                cbmoneyName.Items.Add(readerp["studentname"]);
            }

            readerp.Close();

            con.Close();

            Sum_price();

            paymoney();          

        }//訂單_Load END

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lbltimenow.Text = System.DateTime.Now.ToString("HH:mm:ss");
        }


        private void cbOptS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //店家選擇comboBox --> 商品ComboBox清單

            if (cbOptS.SelectedIndex != -1)
            {
                int storeId = 0;
                cbOptP.Items.Clear();
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string SQLstr = "SELECT storeId,img FROM StoreInfo WHERE storename = @optStore";
                SqlCommand cmd = new SqlCommand(SQLstr, con);
                cmd.Parameters.AddWithValue("@optStore", cbOptS.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    storeId = (int)reader["storeId"];

                    if (reader["img"] != null)
                    {
                        pbstore1.ImageLocation = reader["img"].ToString();
                    }
                   
                }
                reader.Close();
                string SQLstr1 = "SELECT productname FROM ProductInfo WHERE storeId = @SearchId";
                SqlCommand cmd1 = new SqlCommand(SQLstr1, con);
                cmd1.Parameters.AddWithValue("@SearchId", storeId);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read() == true)
                {
                    cbOptP.Items.Add(reader1["productname"]);
                }
                reader1.Close();
                con.Close();
            }
            
        }

        private void cbOptP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOptP.SelectedIndex != -1)
            {
                Pprice = 0;
                Ppricetotal = 0;
                tbNum.Text = "1";
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                String SQLstr = "SELECT price FROM ProductInfo WHERE productname = @SearchPname";
                SqlCommand cmd = new SqlCommand(SQLstr, con);
                cmd.Parameters.AddWithValue("@SearchPname", cbOptP.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    tbPprice.Text = reader["price"].ToString();
                }

                Pprice = Convert.ToInt32(tbPprice.Text);
                Ppricetotal = Pprice;

                reader.Close();
                con.Close();
            }
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //加號按鈕
            btnPlus.Enabled = true;
            if (biandangNum > 0)
            {
                biandangNum--;
                Ppricetotal -= Pprice;
                
            }
            else {

                btnMinus.Enabled = false;
                MessageBox.Show("已為最小數量", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tbNum.Text = biandangNum.ToString();
            tbPprice.Text = Ppricetotal.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //減號按鈕
            btnMinus.Enabled = true;
            if (biandangNum < 99)
            {
                biandangNum++;
                Ppricetotal +=Pprice ;

            }
            else {
                btnPlus.Enabled = false;
                MessageBox.Show("已為最小值", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tbNum.Text = biandangNum.ToString();
            tbPprice.Text = Ppricetotal.ToString();
        }

        private void tbNum_TextChanged(object sender, EventArgs e)
        {
            if (tbNum.Text != "")
            {
                bool ifNum = Int32.TryParse(tbNum.Text, out biandangNum);

                if (ifNum == true && biandangNum >= 0)
                {
                }
                else
                {
                    MessageBox.Show("請輸入正確數量", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tbNum.Text = "";
            }
        }

        private void btnOrderSetup_Click(object sender, EventArgs e)
        {
            if ((cbDutyMan.SelectedIndex != -1) && (cbOptS.SelectedIndex != -1))
            {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string SQLstr = "INSERT INTO temporder VALUES (@name,@class,@store,@date)";
                    SqlCommand cmd = new SqlCommand(SQLstr, con);
                    cmd.Parameters.AddWithValue("@name", cbDutyMan.SelectedItem);
                    cmd.Parameters.AddWithValue("@class", reclass);
                    cmd.Parameters.AddWithValue("@store", cbOptS.SelectedItem);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                    cmd.ExecuteNonQuery();//異動資料的筆數
                    MessageBox.Show("訂單新增成功");
                    con.Close();
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            int OstudentId = 0;
            if (cbOptP.SelectedIndex != -1 && tbNum.Text != "0")
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();

                string strSQL = "SELECT studentId FROM studentInfo WHERE studentname = @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", cbDutyMan.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    OstudentId = (int)reader["studentId"];
                }
                reader.Close();

                string strSQL1 = "update OrderInfo set prouductname = @newproduct,amount = @newamount, price = @newprice, remark = @newremark where studentId=@SearchId AND orderdate=@today";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@today",DateTime.Now.ToShortDateString());
                cmd1.Parameters.AddWithValue("@SearchId", OstudentId);
                cmd1.Parameters.AddWithValue("@newproduct", cbOptP.SelectedItem);
                cmd1.Parameters.AddWithValue("@newamount", tbNum.Text);
                cmd1.Parameters.AddWithValue("@newprice", tbPprice.Text);
                cmd1.Parameters.AddWithValue("@newremark", tbremark.Text);
                int rows = cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改完畢,筆數:" + rows.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int OstudentId = 0;
            if (cbOptP.SelectedIndex != -1 && cbDutyMan.SelectedIndex != -1)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "SELECT studentId FROM studentInfo WHERE studentname = @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", cbDutyMan.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    OstudentId = (int)reader["studentId"];
                }
                reader.Close();

                string strSQL1 = "delete from OrderInfo where studentId = @SearchId AND orderdate = @today";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@SearchId", OstudentId);
                cmd1.Parameters.AddWithValue("@today", DateTime.Now.ToShortDateString());

                int rows = cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料刪除完畢,筆數:" + rows.ToString());

                cbOptP.SelectedIndex = -1;
                tbNum.Text = "";
                tbPprice.Text = "";
                tbremark.Text = "";
            }
        }

        private void cbmoneyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "SELECT o.studentId,o.price FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate AND s.studentname = @Searchname";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@searchClass", reclass);
            cmd.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@Searchname", cbmoneyName.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                checkId = (int)reader["studentId"];
                tbReceiptM.Text = reader["price"].ToString();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string checkmoney = "";
            if (radioY.Checked == true)
            {
                checkmoney = "已付";
            }
            else if (radioN.Checked == true)
            {
                checkmoney = "未付";            
            }
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "UPDATE OrderInfo set paymoney = @NewPay where studentId=@SearchId AND orderdate = @today";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", checkId);
            cmd.Parameters.AddWithValue("@today", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("@NewPay", checkmoney);
            int rows = cmd.ExecuteNonQuery();

            paymoney();
         
            MessageBox.Show("繳款完成");

            strOdetai = "";
            lbOrder.Items.Clear();

            string strSQL1 = "SELECT s.studentname,o.prouductname,o.amount,o.price,o.paymoney,o.remark FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate ";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            cmd1.Parameters.AddWithValue("@searchClass", reclass);
            cmd1.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read() == true)
            {
                strOdetai += reader1["studentname"] + "\t";
                strOdetai += reader1["prouductname"] + "          ";
                strOdetai += reader1["amount"] + "\t";
                strOdetai += reader1["price"] + "     ";
                strOdetai += reader1["paymoney"] + "    ";
                strOdetai += reader1["remark"];

                lbOrder.Items.Add(strOdetai);
                strOdetai = "";
            }
            reader1.Close();



            con.Close();
        }

        //---------------------  學生訂單 ------------------------------

        private void btnminiC_Click(object sender, EventArgs e)
        {
            btnPlusC.Enabled = true;
            if (biandangNum > 0)
            {
                biandangNum--;
                Ppricetotal -= Pprice;

            }
            else
            {
                btnminiC.Enabled = false;
                MessageBox.Show("已為最小數量", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tbNumC.Text = biandangNum.ToString();
            tbtotalC.Text = Ppricetotal.ToString();
        }

        private void tbNumC_TextChanged(object sender, EventArgs e)
        {
            if (tbNumC.Text != "")
            {
                bool ifNum = Int32.TryParse(tbNumC.Text, out biandangNum);

                if (ifNum == true && biandangNum >= 0)
                {
                }
                else
                {
                    MessageBox.Show("請輸入正確數量", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tbNumC.Text = "";
            }
        }

        private void btnPlusC_Click(object sender, EventArgs e)
        {
            btnminiC.Enabled = true;
            if (biandangNum < 99)
            {
                biandangNum++;
                Ppricetotal += Pprice;

            }
            else
            {
                btnPlus.Enabled = false;
                MessageBox.Show("已為最小值", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tbNumC.Text = biandangNum.ToString();
            tbtotalC.Text = Ppricetotal.ToString();
        }

        private void cbCustP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustP.SelectedIndex != -1)
            {
                Pprice = 0;
                
                tbNumC.Text = "1";
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                String SQLstr = "SELECT price FROM ProductInfo WHERE productname = @SearchPname";
                SqlCommand cmd = new SqlCommand(SQLstr, con);
                cmd.Parameters.AddWithValue("@SearchPname", cbCustP.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    tbtotalC.Text = reader["price"].ToString();
                }

                Pprice = Convert.ToInt32(tbtotalC.Text);
                Ppricetotal = Pprice;

                reader.Close();
                con.Close();
            }
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int studentId = 0;
            int storeId = 0;
            string classroom = "";
            if ((cbcustomer.SelectedIndex != -1) && (cbCustP.SelectedIndex != -1) && (tbNumC.Text != ""))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string SQLstr = "SELECT storeId FROM StoreInfo WHERE storename = @SearchStore";
                SqlCommand cmd = new SqlCommand(SQLstr, con);
                cmd.Parameters.AddWithValue("@SearchStore", tbstore.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    storeId = Convert.ToInt32(reader["storeId"]);
                }

                reader.Close();

                string SQLstr2 = "SELECT studentId,classroom  FROM StudentInfo WHERE studentname = @Searchname";
                SqlCommand cmd2 = new SqlCommand(SQLstr2, con);
                cmd2.Parameters.AddWithValue("@Searchname", cbcustomer.SelectedItem);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read() == true)
                {
                    studentId = (int)reader2["studentId"];
                    classroom = (string)reader2["classroom"];

                }
                reader2.Close();

                string SQLstr3 = "INSERT INTO OrderInfo VALUES (@NewstoreId,@NewstudentId,@classroom,@newproductname,@newamount,@newprice,@newremark,@paymoney,@dutymanId,@orderdate)";
                SqlCommand cmd3 = new SqlCommand(SQLstr3, con);

                cmd3.Parameters.AddWithValue("@NewstoreId", storeId);
                cmd3.Parameters.AddWithValue("@NewstudentId", studentId);
                cmd3.Parameters.AddWithValue("@classroom", classroom);
                cmd3.Parameters.AddWithValue("@newproductname", cbCustP.SelectedItem);
                cmd3.Parameters.AddWithValue("@newamount", Convert.ToInt32(tbNumC.Text));
                cmd3.Parameters.AddWithValue("@newprice", Convert.ToInt32(tbtotalC.Text));
                cmd3.Parameters.AddWithValue("@newremark", tbRemarkC.Text);
                cmd3.Parameters.AddWithValue("@paymoney", radioN.Text);
                cmd3.Parameters.AddWithValue("@dutymanId", tbdutyman.Text);
                cmd3.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());

                int rows = cmd3.ExecuteNonQuery();//異動資料的筆數

                MessageBox.Show("資料新增成功,筆數:" + rows.ToString());
                con.Close();

            }
            else
            {
                MessageBox.Show("請輸入完整資訊");
            }
        }

        private void btnrefreshC_Click(object sender, EventArgs e)
        {
            strOdetai = "";
            lbOdetail.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string SQLstr = "SELECT s.studentname,o.prouductname,o.amount,o.price,o.paymoney,o.remark FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND orderdate = @todate";
            SqlCommand cmd = new SqlCommand(SQLstr, con);
            cmd.Parameters.AddWithValue("@searchClass", reclass);
            cmd.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                strOdetai += reader["studentname"]+"\t";
                strOdetai += reader["prouductname"] + "     ";
                strOdetai += reader["amount"] + "\t";
                strOdetai += reader["price"] + "\t";
                strOdetai += reader["paymoney"]+"       ";
                strOdetai += reader["remark"];

                lbOdetail.Items.Add(strOdetai);
                strOdetai = "";
            }

            reader.Close();
            con.Close();
        }

        private void cbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCustP.SelectedIndex = -1;
            tbNumC.Text = "";
            tbtotalC.Text = "";
            tbRemarkC.Text = "";

            if (cbcustomer.SelectedIndex != -1)
            {
                int OstudentId = 0;
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "SELECT studentId FROM StudentInfo Where studentname = @Searchname";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchname", cbcustomer.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    OstudentId = (int)reader["studentId"];
                }

                reader.Close();
                string strSQL1 = "SELECT prouductname,amount,price,remark FROM OrderInfo Where studentId = @SearchId AND orderdate = @today";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@SearchId", OstudentId);
                cmd1.Parameters.AddWithValue("@today", DateTime.Now.ToShortDateString());
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read() == true)
                {
                    cbCustP.SelectedItem = (string)reader1["prouductname"];
                    tbNumC.Text = reader1["amount"].ToString();
                    tbtotalC.Text = reader1["price"].ToString();
                    tbRemarkC.Text = (string)reader1["remark"];
                    biandangNum = Convert.ToInt32(tbNumC.Text);
                    Ppricetotal = Convert.ToInt32(tbtotalC.Text);
                    
                }

              
                reader1.Close();
                con.Close();
            }
        }

        private void btndeleteC_Click(object sender, EventArgs e)
        {
            int OstudentId = 0;
            if (cbCustP.SelectedIndex != -1 && cbcustomer.SelectedIndex !=-1)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "SELECT studentId FROM studentInfo WHERE studentname = @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName",cbcustomer.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    OstudentId = (int)reader["studentId"];
                }
                reader.Close();

                string strSQL1 = "delete from OrderInfo where studentId = @SearchId AND orderdate = @today";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@SearchId", OstudentId);
                cmd1.Parameters.AddWithValue("@today", DateTime.Now.ToShortDateString());

                int rows = cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料刪除完畢,筆數:" + rows.ToString());

                cbCustP.SelectedIndex = -1;
                tbNumC.Text = "";
                tbtotalC.Text = "";
                tbRemarkC.Text = "";
            }
        }

        private void btnchangeC_Click(object sender, EventArgs e)
        {
            int OstudentId = 0;
            if (cbCustP.SelectedIndex != -1 && tbNumC.Text != "0")
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();

                string strSQL = "SELECT studentId FROM studentInfo WHERE studentname = @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", cbcustomer.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    OstudentId = (int)reader["studentId"];
                }
                reader.Close();

                string strSQL1= "update OrderInfo set prouductname = @newproduct,amount = @newamount, price = @newprice, remark = @newremark where studentId=@SearchId";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con);
                cmd1.Parameters.AddWithValue("@SearchId", OstudentId);
                cmd1.Parameters.AddWithValue("@newproduct", cbCustP.SelectedItem);
                cmd1.Parameters.AddWithValue("@newamount", tbNumC.Text);
                cmd1.Parameters.AddWithValue("@newprice", tbtotalC.Text);
                cmd1.Parameters.AddWithValue("@newremark", tbRemarkC.Text);
                int rows = cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改完畢,筆數:" + rows.ToString());
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        { //值日生端更新
            strOdetai = "";
            lbOrder.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "SELECT s.studentname,o.prouductname,o.amount,o.price,o.paymoney,o.remark FROM StudentInfo AS s JOIN OrderInfo AS o ON s.studentId = o.studentId WHERE s.classroom = @searchClass AND o.orderdate = @todate ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@searchClass", reclass);
            cmd.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                strOdetai += reader["studentname"] + "\t";
                strOdetai += reader["prouductname"] + "          ";
                strOdetai += reader["amount"] + "\t";
                strOdetai += reader["price"] + "     ";
                strOdetai += reader["paymoney"] + "    ";
                strOdetai += reader["remark"];

                lbOrder.Items.Add(strOdetai);
                strOdetai = "";
            }
            con.Close();
        }

        public void Sum_price()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "SELECT  SUM(price)AS total FROM OrderInfo WHERE classroom = @Searchroom AND orderdate= @todate";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchroom", reclass);
            cmd.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                tbTotal.Text = reader["total"].ToString();
            }
            reader.Close();
            con.Close();
        }

        public void transfer()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQLId = "SELECT studentId FROM StudentInfo WHERE studentname = @Searchname";
            SqlCommand cmdId = new SqlCommand(strSQLId, con);
            cmdId.Parameters.AddWithValue("@Searchname", cbDutyMan.SelectedItem);
            SqlDataReader readerId = cmdId.ExecuteReader();
            if (readerId.Read() == true)
            {
                schId = (int)readerId["studentId"];
            }

            readerId.Close();
            con.Close();
        }

        public void paymoney() {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL1 = "SELECT  SUM(price)AS paytotal FROM OrderInfo WHERE classroom = @Searchroom AND orderdate= @todate AND paymoney = @pay";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            cmd1.Parameters.AddWithValue("@Searchroom", reclass);
            cmd1.Parameters.AddWithValue("@todate", DateTime.Now.ToShortDateString());
            cmd1.Parameters.AddWithValue("@pay","已付");
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read() == true)
            {
                tbReceipt.Text = reader1["paytotal"].ToString();
            }
            reader1.Close();
            con.Close();
        }

        private void btncounter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "INSERT INTO final VALUES(@newclass,@newdate)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@newclass", reclass);
            cmd.Parameters.AddWithValue("@newdate", DateTime.Now.ToShortDateString());
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("送出訂單");

        }

        private void btnOrderdelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "delete from OrderInfo where classroom = @Searchroom AND orderdate = @today";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchroom",reclass);
            cmd.Parameters.AddWithValue("@today", DateTime.Now.ToShortDateString());
            cmd.ExecuteNonQuery();


            string strSQL2 = "delete from temporder where classroom = @Searchroom AND date = @today";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
            cmd2.Parameters.AddWithValue("@Searchroom", reclass);
            cmd2.Parameters.AddWithValue("@today", DateTime.Now.ToShortDateString());
            cmd2.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("訂單刪除完畢");

            cbOptS.SelectedIndex= -1;
            tbTotal.Text = "";
            tbReceipt.Text = "";
            cbOptP.SelectedIndex = -1;
            tbNum.Text = "";
            tbremark.Text = "";
            tbPprice.Text = "";
            lbOrder.Items.Clear();

        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            int studentId = 0;
            int storeId = 0;
            string classroom = "";
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            string SQLstr = "SELECT storeId FROM StoreInfo WHERE storename = @SearchStore";
            SqlCommand cmd = new SqlCommand(SQLstr, con);
            cmd.Parameters.AddWithValue("@SearchStore", cbOptS.SelectedItem);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                storeId = Convert.ToInt32(reader["storeId"]);
            }

            reader.Close();
            string SQLstr2 = "SELECT studentId,classroom  FROM StudentInfo WHERE studentname = @Searchname";
            SqlCommand cmd2 = new SqlCommand(SQLstr2, con);
            cmd2.Parameters.AddWithValue("@Searchname", cbDutyMan.SelectedItem);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                studentId = (int)reader2["studentId"];
                classroom = (string)reader2["classroom"];

            }
            reader2.Close();

            string SQLstr3 = "INSERT INTO OrderInfo VALUES (@NewstoreId,@NewstudentId,@classroom,@newproductname,@newamount,@newprice,@newremark,@paymoney,@dutymanId,@orderdate)";
            SqlCommand cmd3 = new SqlCommand(SQLstr3, con);

            cmd3.Parameters.AddWithValue("@NewstoreId", storeId);
            cmd3.Parameters.AddWithValue("@NewstudentId", studentId);
            cmd3.Parameters.AddWithValue("@classroom", classroom);
            cmd3.Parameters.AddWithValue("@newproductname", cbOptP.SelectedItem);
            cmd3.Parameters.AddWithValue("@newamount", Convert.ToInt32(tbNum.Text));
            cmd3.Parameters.AddWithValue("@newprice", Convert.ToInt32(tbPprice.Text));
            cmd3.Parameters.AddWithValue("@newremark", tbremark.Text);
            cmd3.Parameters.AddWithValue("@paymoney", radioN.Text);
            cmd3.Parameters.AddWithValue("@dutymanId", cbDutyMan.SelectedItem);
            cmd3.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
            int rows = cmd3.ExecuteNonQuery();//異動資料的筆數
            MessageBox.Show("資料新增成功,筆數:" + rows.ToString());
            con.Close();
        }

        private void pbstore1_Click(object sender, EventArgs e)
        {
            picture p = new picture();

            string a = pbstore1.ImageLocation;
            p.bigP = a;
            p.SetValue();
            p.ShowDialog();
        }

        private void pbstore2_Click(object sender, EventArgs e)
        {
            picture p = new picture();
            string a = pbstore1.ImageLocation;
            p.bigP = a;
            p.SetValue();
            p.ShowDialog();
        }
    }
}
