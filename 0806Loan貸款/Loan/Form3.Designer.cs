namespace WindowsFormsApp5
{
    partial class Form3
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_money3 = new System.Windows.Forms.TextBox();
            this.txt_year3 = new System.Windows.Forms.TextBox();
            this.txt_rate3 = new System.Windows.Forms.TextBox();
            this.txt_monthprice3 = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(114, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(114, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "貸款年限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(114, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(114, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(114, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款";
            // 
            // txt_money3
            // 
            this.txt_money3.Location = new System.Drawing.Point(211, 57);
            this.txt_money3.Name = "txt_money3";
            this.txt_money3.Size = new System.Drawing.Size(167, 22);
            this.txt_money3.TabIndex = 5;
            // 
            // txt_year3
            // 
            this.txt_year3.Location = new System.Drawing.Point(211, 111);
            this.txt_year3.Name = "txt_year3";
            this.txt_year3.Size = new System.Drawing.Size(167, 22);
            this.txt_year3.TabIndex = 6;
            // 
            // txt_rate3
            // 
            this.txt_rate3.Location = new System.Drawing.Point(211, 154);
            this.txt_rate3.Name = "txt_rate3";
            this.txt_rate3.Size = new System.Drawing.Size(167, 22);
            this.txt_rate3.TabIndex = 7;
            // 
            // txt_monthprice3
            // 
            this.txt_monthprice3.Location = new System.Drawing.Point(211, 196);
            this.txt_monthprice3.Name = "txt_monthprice3";
            this.txt_monthprice3.Size = new System.Drawing.Size(167, 22);
            this.txt_monthprice3.TabIndex = 8;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(211, 239);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(167, 22);
            this.txt_total.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_monthprice3);
            this.Controls.Add(this.txt_rate3);
            this.Controls.Add(this.txt_year3);
            this.Controls.Add(this.txt_money3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_money3;
        private System.Windows.Forms.TextBox txt_year3;
        private System.Windows.Forms.TextBox txt_rate3;
        private System.Windows.Forms.TextBox txt_monthprice3;
        private System.Windows.Forms.TextBox txt_total;
    }
}