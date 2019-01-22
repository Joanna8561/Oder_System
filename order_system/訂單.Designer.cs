namespace order_system
{
    partial class 訂單
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(訂單));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dutyOrder = new System.Windows.Forms.TabPage();
            this.btnbuy = new System.Windows.Forms.Button();
            this.btncounter = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.tbPprice = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbremark = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOrderdelete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnOrderSetup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbReceiptM = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cbmoneyName = new System.Windows.Forms.ComboBox();
            this.radioN = new System.Windows.Forms.RadioButton();
            this.radioY = new System.Windows.Forms.RadioButton();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOptP = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbstore1 = new System.Windows.Forms.PictureBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.tbReceipt = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbOptS = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbDutyMan = new System.Windows.Forms.ComboBox();
            this.generalOrder = new System.Windows.Forms.TabPage();
            this.pbstore2 = new System.Windows.Forms.PictureBox();
            this.btnchangeC = new System.Windows.Forms.Button();
            this.tbRemarkC = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbtotalC = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnrefreshC = new System.Windows.Forms.Button();
            this.btndeleteC = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnminiC = new System.Windows.Forms.Button();
            this.btnPlusC = new System.Windows.Forms.Button();
            this.tbNumC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCustP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOdetail = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldayline = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbltimenow = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.tbstore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdutyman = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderSystemDataSet = new order_system.OrderSystemDataSet();
            this.orderSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new order_system.OrderSystemDataSetTableAdapters.StudentInfoTableAdapter();
            this.studentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.dutyOrder.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstore1)).BeginInit();
            this.generalOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstore2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dutyOrder);
            this.tabControl1.Controls.Add(this.generalOrder);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // dutyOrder
            // 
            this.dutyOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dutyOrder.BackgroundImage")));
            this.dutyOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dutyOrder.Controls.Add(this.btnbuy);
            this.dutyOrder.Controls.Add(this.btncounter);
            this.dutyOrder.Controls.Add(this.btnupdate);
            this.dutyOrder.Controls.Add(this.tbPprice);
            this.dutyOrder.Controls.Add(this.label27);
            this.dutyOrder.Controls.Add(this.tbremark);
            this.dutyOrder.Controls.Add(this.label12);
            this.dutyOrder.Controls.Add(this.btnOrderdelete);
            this.dutyOrder.Controls.Add(this.btnDelete);
            this.dutyOrder.Controls.Add(this.btnModify);
            this.dutyOrder.Controls.Add(this.btnOrderSetup);
            this.dutyOrder.Controls.Add(this.groupBox3);
            this.dutyOrder.Controls.Add(this.btnMinus);
            this.dutyOrder.Controls.Add(this.btnPlus);
            this.dutyOrder.Controls.Add(this.tbNum);
            this.dutyOrder.Controls.Add(this.label7);
            this.dutyOrder.Controls.Add(this.label10);
            this.dutyOrder.Controls.Add(this.cbOptP);
            this.dutyOrder.Controls.Add(this.label11);
            this.dutyOrder.Controls.Add(this.lbOrder);
            this.dutyOrder.Controls.Add(this.groupBox2);
            this.dutyOrder.Location = new System.Drawing.Point(4, 33);
            this.dutyOrder.Name = "dutyOrder";
            this.dutyOrder.Padding = new System.Windows.Forms.Padding(3);
            this.dutyOrder.Size = new System.Drawing.Size(773, 490);
            this.dutyOrder.TabIndex = 0;
            this.dutyOrder.Text = "值日生";
            this.dutyOrder.UseVisualStyleBackColor = true;
            // 
            // btnbuy
            // 
            this.btnbuy.BackColor = System.Drawing.Color.Tan;
            this.btnbuy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbuy.Location = new System.Drawing.Point(477, 238);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(85, 35);
            this.btnbuy.TabIndex = 42;
            this.btnbuy.Text = "訂購";
            this.btnbuy.UseVisualStyleBackColor = false;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // btncounter
            // 
            this.btncounter.BackColor = System.Drawing.Color.Tan;
            this.btncounter.Location = new System.Drawing.Point(608, 414);
            this.btncounter.Name = "btncounter";
            this.btncounter.Size = new System.Drawing.Size(117, 34);
            this.btncounter.TabIndex = 41;
            this.btncounter.Text = "送出訂單";
            this.btncounter.UseVisualStyleBackColor = false;
            this.btncounter.Click += new System.EventHandler(this.btncounter_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Tan;
            this.btnupdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnupdate.Location = new System.Drawing.Point(477, 414);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(85, 32);
            this.btnupdate.TabIndex = 40;
            this.btnupdate.Text = "更新";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // tbPprice
            // 
            this.tbPprice.Location = new System.Drawing.Point(324, 190);
            this.tbPprice.Name = "tbPprice";
            this.tbPprice.Size = new System.Drawing.Size(85, 33);
            this.tbPprice.TabIndex = 39;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(270, 193);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 24);
            this.label27.TabIndex = 38;
            this.label27.Text = "金額";
            // 
            // tbremark
            // 
            this.tbremark.Location = new System.Drawing.Point(111, 190);
            this.tbremark.Name = "tbremark";
            this.tbremark.Size = new System.Drawing.Size(153, 33);
            this.tbremark.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "備註";
            // 
            // btnOrderdelete
            // 
            this.btnOrderdelete.BackColor = System.Drawing.Color.Tan;
            this.btnOrderdelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderdelete.Location = new System.Drawing.Point(676, 146);
            this.btnOrderdelete.Name = "btnOrderdelete";
            this.btnOrderdelete.Size = new System.Drawing.Size(84, 35);
            this.btnOrderdelete.TabIndex = 35;
            this.btnOrderdelete.Text = "刪除訂單";
            this.btnOrderdelete.UseVisualStyleBackColor = false;
            this.btnOrderdelete.Click += new System.EventHandler(this.btnOrderdelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tan;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(477, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 37);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "刪除訂購";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Tan;
            this.btnModify.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModify.Location = new System.Drawing.Point(477, 293);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 35);
            this.btnModify.TabIndex = 32;
            this.btnModify.Text = "修改訂購";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnOrderSetup
            // 
            this.btnOrderSetup.BackColor = System.Drawing.Color.Tan;
            this.btnOrderSetup.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderSetup.Location = new System.Drawing.Point(578, 146);
            this.btnOrderSetup.Name = "btnOrderSetup";
            this.btnOrderSetup.Size = new System.Drawing.Size(92, 36);
            this.btnOrderSetup.TabIndex = 30;
            this.btnOrderSetup.Text = "建立訂單";
            this.btnOrderSetup.UseVisualStyleBackColor = false;
            this.btnOrderSetup.Click += new System.EventHandler(this.btnOrderSetup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbReceiptM);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cbmoneyName);
            this.groupBox3.Controls.Add(this.radioN);
            this.groupBox3.Controls.Add(this.radioY);
            this.groupBox3.Location = new System.Drawing.Point(578, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 204);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "收款";
            // 
            // tbReceiptM
            // 
            this.tbReceiptM.Location = new System.Drawing.Point(64, 71);
            this.tbReceiptM.Name = "tbReceiptM";
            this.tbReceiptM.Size = new System.Drawing.Size(90, 33);
            this.tbReceiptM.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 24);
            this.label21.TabIndex = 37;
            this.label21.Text = "金額";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Tan;
            this.btnSend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSend.Location = new System.Drawing.Point(41, 159);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 35);
            this.btnSend.TabIndex = 34;
            this.btnSend.Text = "確認";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 9;
            this.label16.Text = "姓名";
            // 
            // cbmoneyName
            // 
            this.cbmoneyName.FormattingEnabled = true;
            this.cbmoneyName.Location = new System.Drawing.Point(64, 32);
            this.cbmoneyName.Name = "cbmoneyName";
            this.cbmoneyName.Size = new System.Drawing.Size(101, 32);
            this.cbmoneyName.TabIndex = 2;
            this.cbmoneyName.SelectedIndexChanged += new System.EventHandler(this.cbmoneyName_SelectedIndexChanged);
            // 
            // radioN
            // 
            this.radioN.AutoSize = true;
            this.radioN.BackColor = System.Drawing.Color.Transparent;
            this.radioN.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioN.Location = new System.Drawing.Point(94, 121);
            this.radioN.Name = "radioN";
            this.radioN.Size = new System.Drawing.Size(72, 30);
            this.radioN.TabIndex = 1;
            this.radioN.TabStop = true;
            this.radioN.Text = "未付";
            this.radioN.UseVisualStyleBackColor = false;
            // 
            // radioY
            // 
            this.radioY.AutoSize = true;
            this.radioY.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioY.Location = new System.Drawing.Point(14, 121);
            this.radioY.Name = "radioY";
            this.radioY.Size = new System.Drawing.Size(72, 30);
            this.radioY.TabIndex = 0;
            this.radioY.TabStop = true;
            this.radioY.Text = "已付";
            this.radioY.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Tan;
            this.btnMinus.Location = new System.Drawing.Point(324, 146);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(41, 35);
            this.btnMinus.TabIndex = 28;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Tan;
            this.btnPlus.Location = new System.Drawing.Point(437, 144);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(41, 35);
            this.btnPlus.TabIndex = 27;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(371, 146);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(60, 33);
            this.tbNum.TabIndex = 26;
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "數量";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SandyBrown;
            this.label10.Location = new System.Drawing.Point(14, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(452, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "姓名        訂購項目      數量   金額   付款  備註 \r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbOptP
            // 
            this.cbOptP.FormattingEnabled = true;
            this.cbOptP.Location = new System.Drawing.Point(111, 148);
            this.cbOptP.Name = "cbOptP";
            this.cbOptP.Size = new System.Drawing.Size(153, 32);
            this.cbOptP.TabIndex = 23;
            this.cbOptP.SelectedIndexChanged += new System.EventHandler(this.cbOptP_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "選擇品項";
            // 
            // lbOrder
            // 
            this.lbOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 21;
            this.lbOrder.Location = new System.Drawing.Point(14, 278);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(452, 193);
            this.lbOrder.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbstore1);
            this.groupBox2.Controls.Add(this.lbltime);
            this.groupBox2.Controls.Add(this.tbReceipt);
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cbOptS);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbDutyMan);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(755, 124);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "訂購資訊";
            // 
            // pbstore1
            // 
            this.pbstore1.Location = new System.Drawing.Point(485, 26);
            this.pbstore1.Name = "pbstore1";
            this.pbstore1.Size = new System.Drawing.Size(89, 84);
            this.pbstore1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbstore1.TabIndex = 43;
            this.pbstore1.TabStop = false;
            this.pbstore1.Click += new System.EventHandler(this.pbstore1_Click);
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbltime.Location = new System.Drawing.Point(591, 50);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(143, 60);
            this.lbltime.TabIndex = 38;
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbReceipt
            // 
            this.tbReceipt.Location = new System.Drawing.Point(305, 72);
            this.tbReceipt.Name = "tbReceipt";
            this.tbReceipt.Size = new System.Drawing.Size(128, 33);
            this.tbReceipt.TabIndex = 36;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(97, 75);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(102, 33);
            this.tbTotal.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(232, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 24);
            this.label20.TabIndex = 11;
            this.label20.Text = "已收款";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 24);
            this.label17.TabIndex = 9;
            this.label17.Text = "總額";
            // 
            // cbOptS
            // 
            this.cbOptS.FormattingEnabled = true;
            this.cbOptS.Location = new System.Drawing.Point(305, 32);
            this.cbOptS.Name = "cbOptS";
            this.cbOptS.Size = new System.Drawing.Size(165, 32);
            this.cbOptS.TabIndex = 8;
            this.cbOptS.SelectedIndexChanged += new System.EventHandler(this.cbOptS_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "店家";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(591, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "時間";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "值日生";
            // 
            // cbDutyMan
            // 
            this.cbDutyMan.FormattingEnabled = true;
            this.cbDutyMan.Location = new System.Drawing.Point(97, 32);
            this.cbDutyMan.Name = "cbDutyMan";
            this.cbDutyMan.Size = new System.Drawing.Size(148, 32);
            this.cbDutyMan.TabIndex = 1;
            // 
            // generalOrder
            // 
            this.generalOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generalOrder.BackgroundImage")));
            this.generalOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generalOrder.Controls.Add(this.pbstore2);
            this.generalOrder.Controls.Add(this.btnchangeC);
            this.generalOrder.Controls.Add(this.tbRemarkC);
            this.generalOrder.Controls.Add(this.label26);
            this.generalOrder.Controls.Add(this.tbtotalC);
            this.generalOrder.Controls.Add(this.label19);
            this.generalOrder.Controls.Add(this.btnrefreshC);
            this.generalOrder.Controls.Add(this.btndeleteC);
            this.generalOrder.Controls.Add(this.btnOK);
            this.generalOrder.Controls.Add(this.btnminiC);
            this.generalOrder.Controls.Add(this.btnPlusC);
            this.generalOrder.Controls.Add(this.tbNumC);
            this.generalOrder.Controls.Add(this.label9);
            this.generalOrder.Controls.Add(this.label8);
            this.generalOrder.Controls.Add(this.cbCustP);
            this.generalOrder.Controls.Add(this.label6);
            this.generalOrder.Controls.Add(this.lbOdetail);
            this.generalOrder.Controls.Add(this.groupBox1);
            this.generalOrder.Location = new System.Drawing.Point(4, 33);
            this.generalOrder.Name = "generalOrder";
            this.generalOrder.Padding = new System.Windows.Forms.Padding(3);
            this.generalOrder.Size = new System.Drawing.Size(773, 490);
            this.generalOrder.TabIndex = 1;
            this.generalOrder.Text = "學員";
            this.generalOrder.UseVisualStyleBackColor = true;
            // 
            // pbstore2
            // 
            this.pbstore2.Location = new System.Drawing.Point(556, 147);
            this.pbstore2.Name = "pbstore2";
            this.pbstore2.Size = new System.Drawing.Size(96, 88);
            this.pbstore2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbstore2.TabIndex = 25;
            this.pbstore2.TabStop = false;
            this.pbstore2.Click += new System.EventHandler(this.pbstore2_Click);
            // 
            // btnchangeC
            // 
            this.btnchangeC.BackColor = System.Drawing.Color.Tan;
            this.btnchangeC.Location = new System.Drawing.Point(592, 310);
            this.btnchangeC.Name = "btnchangeC";
            this.btnchangeC.Size = new System.Drawing.Size(99, 35);
            this.btnchangeC.TabIndex = 24;
            this.btnchangeC.Text = "修改";
            this.btnchangeC.UseVisualStyleBackColor = false;
            this.btnchangeC.Click += new System.EventHandler(this.btnchangeC_Click);
            // 
            // tbRemarkC
            // 
            this.tbRemarkC.Location = new System.Drawing.Point(106, 202);
            this.tbRemarkC.Name = "tbRemarkC";
            this.tbRemarkC.Size = new System.Drawing.Size(162, 33);
            this.tbRemarkC.TabIndex = 23;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(47, 205);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 24);
            this.label26.TabIndex = 22;
            this.label26.Text = "備註";
            // 
            // tbtotalC
            // 
            this.tbtotalC.Location = new System.Drawing.Point(356, 208);
            this.tbtotalC.Name = "tbtotalC";
            this.tbtotalC.Size = new System.Drawing.Size(104, 33);
            this.tbtotalC.TabIndex = 21;
            this.tbtotalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(293, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 24);
            this.label19.TabIndex = 20;
            this.label19.Text = "總額";
            // 
            // btnrefreshC
            // 
            this.btnrefreshC.BackColor = System.Drawing.Color.Tan;
            this.btnrefreshC.Location = new System.Drawing.Point(592, 417);
            this.btnrefreshC.Name = "btnrefreshC";
            this.btnrefreshC.Size = new System.Drawing.Size(99, 35);
            this.btnrefreshC.TabIndex = 19;
            this.btnrefreshC.Text = "更新";
            this.btnrefreshC.UseVisualStyleBackColor = false;
            this.btnrefreshC.Click += new System.EventHandler(this.btnrefreshC_Click);
            // 
            // btndeleteC
            // 
            this.btndeleteC.BackColor = System.Drawing.Color.Tan;
            this.btndeleteC.Location = new System.Drawing.Point(592, 363);
            this.btndeleteC.Name = "btndeleteC";
            this.btndeleteC.Size = new System.Drawing.Size(99, 35);
            this.btndeleteC.TabIndex = 18;
            this.btndeleteC.Text = "刪除訂購";
            this.btndeleteC.UseVisualStyleBackColor = false;
            this.btndeleteC.Click += new System.EventHandler(this.btndeleteC_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Tan;
            this.btnOK.Location = new System.Drawing.Point(592, 256);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 35);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "確認";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnminiC
            // 
            this.btnminiC.BackColor = System.Drawing.Color.Tan;
            this.btnminiC.Location = new System.Drawing.Point(359, 153);
            this.btnminiC.Name = "btnminiC";
            this.btnminiC.Size = new System.Drawing.Size(43, 37);
            this.btnminiC.TabIndex = 16;
            this.btnminiC.Text = "-";
            this.btnminiC.UseVisualStyleBackColor = false;
            this.btnminiC.Click += new System.EventHandler(this.btnminiC_Click);
            // 
            // btnPlusC
            // 
            this.btnPlusC.BackColor = System.Drawing.Color.Tan;
            this.btnPlusC.Location = new System.Drawing.Point(481, 153);
            this.btnPlusC.Name = "btnPlusC";
            this.btnPlusC.Size = new System.Drawing.Size(43, 37);
            this.btnPlusC.TabIndex = 15;
            this.btnPlusC.Text = "+";
            this.btnPlusC.UseVisualStyleBackColor = false;
            this.btnPlusC.Click += new System.EventHandler(this.btnPlusC_Click);
            // 
            // tbNumC
            // 
            this.tbNumC.Location = new System.Drawing.Point(408, 156);
            this.tbNumC.Name = "tbNumC";
            this.tbNumC.Size = new System.Drawing.Size(67, 33);
            this.tbNumC.TabIndex = 14;
            this.tbNumC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumC.TextChanged += new System.EventHandler(this.tbNumC_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "數量";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SandyBrown;
            this.label8.CausesValidation = false;
            this.label8.Location = new System.Drawing.Point(15, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(550, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = " 姓名          訂購項目         數量      金額            付款       備註";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCustP
            // 
            this.cbCustP.FormattingEnabled = true;
            this.cbCustP.Location = new System.Drawing.Point(106, 156);
            this.cbCustP.Name = "cbCustP";
            this.cbCustP.Size = new System.Drawing.Size(162, 32);
            this.cbCustP.TabIndex = 10;
            this.cbCustP.SelectedIndexChanged += new System.EventHandler(this.cbCustP_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "選擇品項";
            // 
            // lbOdetail
            // 
            this.lbOdetail.FormattingEnabled = true;
            this.lbOdetail.ItemHeight = 24;
            this.lbOdetail.Location = new System.Drawing.Point(18, 299);
            this.lbOdetail.Name = "lbOdetail";
            this.lbOdetail.Size = new System.Drawing.Size(547, 172);
            this.lbOdetail.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldayline);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.lbltimenow);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.tbstore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbdutyman);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbcustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(740, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂購資訊";
            // 
            // lbldayline
            // 
            this.lbldayline.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbldayline.Location = new System.Drawing.Point(579, 73);
            this.lbldayline.Name = "lbldayline";
            this.lbldayline.Size = new System.Drawing.Size(137, 32);
            this.lbldayline.TabIndex = 11;
            this.lbldayline.Text = "10:30 am";
            this.lbldayline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(487, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 24);
            this.label24.TabIndex = 10;
            this.label24.Text = "截止時間";
            // 
            // lbltimenow
            // 
            this.lbltimenow.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbltimenow.Location = new System.Drawing.Point(573, 27);
            this.lbltimenow.Name = "lbltimenow";
            this.lbltimenow.Size = new System.Drawing.Size(143, 32);
            this.lbltimenow.TabIndex = 9;
            this.lbltimenow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(508, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 24);
            this.label22.TabIndex = 8;
            this.label22.Text = "時間";
            // 
            // lbldate
            // 
            this.lbldate.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbldate.Location = new System.Drawing.Point(111, 73);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(130, 32);
            this.lbldate.TabIndex = 7;
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbstore
            // 
            this.tbstore.Location = new System.Drawing.Point(314, 72);
            this.tbstore.Name = "tbstore";
            this.tbstore.Size = new System.Drawing.Size(161, 33);
            this.tbstore.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "店家";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "訂單日期";
            // 
            // tbdutyman
            // 
            this.tbdutyman.Location = new System.Drawing.Point(314, 27);
            this.tbdutyman.Name = "tbdutyman";
            this.tbdutyman.Size = new System.Drawing.Size(161, 33);
            this.tbdutyman.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "值日生";
            // 
            // cbcustomer
            // 
            this.cbcustomer.FormattingEnabled = true;
            this.cbcustomer.Location = new System.Drawing.Point(111, 28);
            this.cbcustomer.Name = "cbcustomer";
            this.cbcustomer.Size = new System.Drawing.Size(115, 32);
            this.cbcustomer.TabIndex = 1;
            this.cbcustomer.SelectedIndexChanged += new System.EventHandler(this.cbcustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購人";
            // 
            // orderSystemDataSet
            // 
            this.orderSystemDataSet.DataSetName = "OrderSystemDataSet";
            this.orderSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderSystemDataSetBindingSource
            // 
            this.orderSystemDataSetBindingSource.DataSource = this.orderSystemDataSet;
            this.orderSystemDataSetBindingSource.Position = 0;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.orderSystemDataSet;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // studentInfoBindingSource1
            // 
            this.studentInfoBindingSource1.DataMember = "StudentInfo";
            this.studentInfoBindingSource1.DataSource = this.orderSystemDataSetBindingSource;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 訂單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(805, 543);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "訂單";
            this.Text = "訂單";
            this.Load += new System.EventHandler(this.訂單_Load);
            this.tabControl1.ResumeLayout(false);
            this.dutyOrder.ResumeLayout(false);
            this.dutyOrder.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstore1)).EndInit();
            this.generalOrder.ResumeLayout(false);
            this.generalOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbstore2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dutyOrder;
        private System.Windows.Forms.TabPage generalOrder;
        private System.Windows.Forms.Button btnminiC;
        private System.Windows.Forms.Button btnPlusC;
        private System.Windows.Forms.TextBox tbNumC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCustP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbOdetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox tbstore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbdutyman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOptP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbOptS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbDutyMan;
        private System.Windows.Forms.Button btnrefreshC;
        private System.Windows.Forms.Button btndeleteC;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbmoneyName;
        private System.Windows.Forms.RadioButton radioN;
        private System.Windows.Forms.RadioButton radioY;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnOrderSetup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbtotalC;
        private System.Windows.Forms.TextBox tbReceipt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbReceiptM;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbldayline;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbltimenow;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.BindingSource orderSystemDataSetBindingSource;
        private OrderSystemDataSet orderSystemDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private OrderSystemDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.BindingSource studentInfoBindingSource1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbremark;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOrderdelete;
        private System.Windows.Forms.TextBox tbRemarkC;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbPprice;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnchangeC;
        private System.Windows.Forms.Button btncounter;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.PictureBox pbstore1;
        private System.Windows.Forms.PictureBox pbstore2;
    }
}