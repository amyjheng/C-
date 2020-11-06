namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_chiness = new System.Windows.Forms.TextBox();
            this.txt_english = new System.Windows.Forms.TextBox();
            this.txt_math = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_addRandom = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_twentyAdd = new System.Windows.Forms.Button();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_allCal = new System.Windows.Forms.Label();
            this.lab_print = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(78, 25);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(124, 22);
            this.txt_name.TabIndex = 4;
            // 
            // txt_chiness
            // 
            this.txt_chiness.Location = new System.Drawing.Point(78, 65);
            this.txt_chiness.Name = "txt_chiness";
            this.txt_chiness.Size = new System.Drawing.Size(124, 22);
            this.txt_chiness.TabIndex = 5;
            // 
            // txt_english
            // 
            this.txt_english.Location = new System.Drawing.Point(78, 113);
            this.txt_english.Name = "txt_english";
            this.txt_english.Size = new System.Drawing.Size(124, 22);
            this.txt_english.TabIndex = 6;
            // 
            // txt_math
            // 
            this.txt_math.Location = new System.Drawing.Point(78, 148);
            this.txt_math.Name = "txt_math";
            this.txt_math.Size = new System.Drawing.Size(124, 22);
            this.txt_math.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(23, 191);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(178, 27);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "加入學生資料";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_addRandom
            // 
            this.btn_addRandom.Location = new System.Drawing.Point(23, 224);
            this.btn_addRandom.Name = "btn_addRandom";
            this.btn_addRandom.Size = new System.Drawing.Size(178, 23);
            this.btn_addRandom.TabIndex = 9;
            this.btn_addRandom.Text = "隨機加入資料";
            this.btn_addRandom.UseVisualStyleBackColor = true;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(23, 284);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(178, 24);
            this.btn_cal.TabIndex = 10;
            this.btn_cal.Text = "各科統計";
            this.btn_cal.UseVisualStyleBackColor = true;
            // 
            // btn_delet
            // 
            this.btn_delet.Location = new System.Drawing.Point(23, 314);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(178, 24);
            this.btn_delet.TabIndex = 11;
            this.btn_delet.Text = "刪除所有資料";
            this.btn_delet.UseVisualStyleBackColor = true;
            // 
            // btn_twentyAdd
            // 
            this.btn_twentyAdd.Location = new System.Drawing.Point(23, 344);
            this.btn_twentyAdd.Name = "btn_twentyAdd";
            this.btn_twentyAdd.Size = new System.Drawing.Size(178, 24);
            this.btn_twentyAdd.TabIndex = 12;
            this.btn_twentyAdd.Text = "隨機加入20筆";
            this.btn_twentyAdd.UseVisualStyleBackColor = true;
            // 
            // lab_title
            // 
            this.lab_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_title.Location = new System.Drawing.Point(233, 29);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(555, 250);
            this.lab_title.TabIndex = 13;
            // 
            // lab_allCal
            // 
            this.lab_allCal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_allCal.Location = new System.Drawing.Point(233, 297);
            this.lab_allCal.Name = "lab_allCal";
            this.lab_allCal.Size = new System.Drawing.Size(555, 103);
            this.lab_allCal.TabIndex = 14;
            // 
            // lab_print
            // 
            this.lab_print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_print.Location = new System.Drawing.Point(248, 63);
            this.lab_print.Name = "lab_print";
            this.lab_print.Size = new System.Drawing.Size(527, 212);
            this.lab_print.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.lab_print);
            this.Controls.Add(this.lab_allCal);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.btn_twentyAdd);
            this.Controls.Add(this.btn_delet);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_addRandom);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_math);
            this.Controls.Add(this.txt_english);
            this.Controls.Add(this.txt_chiness);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_chiness;
        private System.Windows.Forms.TextBox txt_english;
        private System.Windows.Forms.TextBox txt_math;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_addRandom;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_twentyAdd;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_allCal;
        private System.Windows.Forms.Label lab_print;
    }
}

