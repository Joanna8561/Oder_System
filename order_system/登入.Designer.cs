namespace order_system
{
    partial class 登入
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登入));
            this.btnDutyMan = new System.Windows.Forms.Button();
            this.cbClasscho = new System.Windows.Forms.ComboBox();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDutyMan
            // 
            this.btnDutyMan.BackColor = System.Drawing.Color.Tan;
            this.btnDutyMan.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDutyMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDutyMan.Location = new System.Drawing.Point(65, 150);
            this.btnDutyMan.Margin = new System.Windows.Forms.Padding(7);
            this.btnDutyMan.Name = "btnDutyMan";
            this.btnDutyMan.Size = new System.Drawing.Size(112, 48);
            this.btnDutyMan.TabIndex = 0;
            this.btnDutyMan.Text = "值日生";
            this.btnDutyMan.UseVisualStyleBackColor = false;
            this.btnDutyMan.Click += new System.EventHandler(this.btnDutyMan_Click);
            // 
            // cbClasscho
            // 
            this.cbClasscho.BackColor = System.Drawing.Color.White;
            this.cbClasscho.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbClasscho.ForeColor = System.Drawing.Color.Black;
            this.cbClasscho.FormattingEnabled = true;
            this.cbClasscho.Items.AddRange(new object[] {
            "Classroom1",
            "Classroom2",
            "Classroom3",
            "Classroom4"});
            this.cbClasscho.Location = new System.Drawing.Point(41, 97);
            this.cbClasscho.Margin = new System.Windows.Forms.Padding(7);
            this.cbClasscho.Name = "cbClasscho";
            this.cbClasscho.Size = new System.Drawing.Size(166, 39);
            this.cbClasscho.TabIndex = 1;
            this.cbClasscho.SelectedIndexChanged += new System.EventHandler(this.cbClasscho_SelectedIndexChanged);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGeneral.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGeneral.Location = new System.Drawing.Point(65, 212);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(7);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(112, 48);
            this.btnGeneral.TabIndex = 3;
            this.btnGeneral.Text = "學員";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "請選擇教室";
            // 
            // 登入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(244, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.cbClasscho);
            this.Controls.Add(this.btnDutyMan);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "登入";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDutyMan;
        private System.Windows.Forms.ComboBox cbClasscho;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Label label1;
    }
}