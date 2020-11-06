namespace WindowsFormsApp5
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_per = new System.Windows.Forms.TextBox();
            this.txt_firstMoney = new System.Windows.Forms.TextBox();
            this.btn_montth = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.bnt_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(104, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(104, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(104, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(104, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭期款";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(204, 78);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 22);
            this.txt_price.TabIndex = 4;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(204, 116);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(100, 22);
            this.txt_year.TabIndex = 5;
            // 
            // txt_per
            // 
            this.txt_per.Location = new System.Drawing.Point(204, 151);
            this.txt_per.Name = "txt_per";
            this.txt_per.Size = new System.Drawing.Size(100, 22);
            this.txt_per.TabIndex = 6;
            // 
            // txt_firstMoney
            // 
            this.txt_firstMoney.Location = new System.Drawing.Point(204, 191);
            this.txt_firstMoney.Name = "txt_firstMoney";
            this.txt_firstMoney.Size = new System.Drawing.Size(100, 22);
            this.txt_firstMoney.TabIndex = 7;
            // 
            // btn_montth
            // 
            this.btn_montth.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_montth.Location = new System.Drawing.Point(98, 241);
            this.btn_montth.Name = "btn_montth";
            this.btn_montth.Size = new System.Drawing.Size(75, 23);
            this.btn_montth.TabIndex = 8;
            this.btn_montth.Text = "月付";
            this.btn_montth.UseVisualStyleBackColor = true;
            this.btn_montth.Click += new System.EventHandler(this.btn_montth_Click);
            // 
            // btn_total
            // 
            this.btn_total.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_total.Location = new System.Drawing.Point(204, 241);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(75, 23);
            this.btn_total.TabIndex = 9;
            this.btn_total.Text = "總金額";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // bnt_report
            // 
            this.bnt_report.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bnt_report.Location = new System.Drawing.Point(304, 241);
            this.bnt_report.Name = "bnt_report";
            this.bnt_report.Size = new System.Drawing.Size(75, 23);
            this.bnt_report.TabIndex = 10;
            this.bnt_report.Text = "Report";
            this.bnt_report.UseVisualStyleBackColor = true;
            this.bnt_report.Click += new System.EventHandler(this.bnt_report_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_report);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_montth);
            this.Controls.Add(this.txt_firstMoney);
            this.Controls.Add(this.txt_per);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_per;
        private System.Windows.Forms.TextBox txt_firstMoney;
        private System.Windows.Forms.Button btn_montth;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button bnt_report;
    }
}