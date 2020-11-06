namespace WindowsFormsApp7
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
            this.lab_calAll = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_math = new System.Windows.Forms.TextBox();
            this.txt_english = new System.Windows.Forms.TextBox();
            this.txt_chiness = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rangemin = new System.Windows.Forms.TextBox();
            this.txt_rangemax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_calAll
            // 
            this.lab_calAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_calAll.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_calAll.Location = new System.Drawing.Point(231, 311);
            this.lab_calAll.Name = "lab_calAll";
            this.lab_calAll.Size = new System.Drawing.Size(555, 103);
            this.lab_calAll.TabIndex = 30;
            // 
            // lab_title
            // 
            this.lab_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_title.Location = new System.Drawing.Point(231, 43);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(555, 250);
            this.lab_title.TabIndex = 29;
            this.lab_title.Text = "姓名           國文          英文          數學          總分          平均          最高      " +
    "    最低";
            this.lab_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_delet
            // 
            this.btn_delet.Location = new System.Drawing.Point(22, 304);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(178, 24);
            this.btn_delet.TabIndex = 27;
            this.btn_delet.Text = "重設所有資料";
            this.btn_delet.UseVisualStyleBackColor = true;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Enabled = false;
            this.btn_cal.Location = new System.Drawing.Point(539, 417);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(178, 24);
            this.btn_cal.TabIndex = 26;
            this.btn_cal.Text = "各科統計";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(21, 205);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(178, 27);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "加入學生資料";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_math
            // 
            this.txt_math.Location = new System.Drawing.Point(76, 162);
            this.txt_math.Name = "txt_math";
            this.txt_math.Size = new System.Drawing.Size(124, 22);
            this.txt_math.TabIndex = 23;
            // 
            // txt_english
            // 
            this.txt_english.Location = new System.Drawing.Point(76, 127);
            this.txt_english.Name = "txt_english";
            this.txt_english.Size = new System.Drawing.Size(124, 22);
            this.txt_english.TabIndex = 22;
            // 
            // txt_chiness
            // 
            this.txt_chiness.Location = new System.Drawing.Point(76, 79);
            this.txt_chiness.Name = "txt_chiness";
            this.txt_chiness.Size = new System.Drawing.Size(124, 22);
            this.txt_chiness.TabIndex = 21;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(76, 39);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(124, 22);
            this.txt_name.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(14, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "數學";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "英文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "國文";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "姓名";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(241, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(530, 194);
            this.listBox1.TabIndex = 32;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(22, 238);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(178, 27);
            this.btn_insert.TabIndex = 33;
            this.btn_insert.Text = "插入儲存資料";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(22, 271);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(178, 27);
            this.btn_remove.TabIndex = 34;
            this.btn_remove.Text = "移除資料";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(20, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "搜尋國文成績範圍";
            // 
            // txt_rangemin
            // 
            this.txt_rangemin.Location = new System.Drawing.Point(38, 375);
            this.txt_rangemin.Name = "txt_rangemin";
            this.txt_rangemin.Size = new System.Drawing.Size(46, 22);
            this.txt_rangemin.TabIndex = 36;
            // 
            // txt_rangemax
            // 
            this.txt_rangemax.Location = new System.Drawing.Point(133, 375);
            this.txt_rangemax.Name = "txt_rangemax";
            this.txt_rangemax.Size = new System.Drawing.Size(46, 22);
            this.txt_rangemax.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "-";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(35, 413);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(143, 27);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "Serch";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_rangemax);
            this.Controls.Add(this.txt_rangemin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lab_calAll);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.btn_delet);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_math);
            this.Controls.Add(this.txt_english);
            this.Controls.Add(this.txt_chiness);
            this.Controls.Add(this.txt_name);
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
        private System.Windows.Forms.Label lab_calAll;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_math;
        private System.Windows.Forms.TextBox txt_english;
        private System.Windows.Forms.TextBox txt_chiness;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_rangemin;
        private System.Windows.Forms.TextBox txt_rangemax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_search;
    }
}