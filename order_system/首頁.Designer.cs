namespace order_system
{
    partial class 首頁
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(首頁));
            this.btncounter = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncounter
            // 
            this.btncounter.BackColor = System.Drawing.Color.Peru;
            this.btncounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncounter.Location = new System.Drawing.Point(65, 105);
            this.btncounter.Name = "btncounter";
            this.btncounter.Size = new System.Drawing.Size(175, 45);
            this.btncounter.TabIndex = 0;
            this.btncounter.Text = "櫃台";
            this.btncounter.UseVisualStyleBackColor = false;
            this.btncounter.Click += new System.EventHandler(this.btncounter_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Peru;
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUser.Location = new System.Drawing.Point(65, 177);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(175, 45);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "學生";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Peru;
            this.btnData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnData.Location = new System.Drawing.Point(65, 250);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(175, 45);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "資料維護";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "資策會便當訂購系統";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 首頁
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btncounter);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "首頁";
            this.Text = "首頁";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncounter;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Label label1;
    }
}