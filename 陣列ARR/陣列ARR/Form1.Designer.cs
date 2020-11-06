namespace 陣列ARR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1010 = new System.Windows.Forms.Button();
            this.btntwoArrayside0 = new System.Windows.Forms.Button();
            this.btntwoArrayside1 = new System.Windows.Forms.Button();
            this.btnLongname = new System.Windows.Forms.Button();
            this.btArrXueC = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnArrtotal = new System.Windows.Forms.Button();
            this.btnArr0711MaxMin = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNumber = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1010
            // 
            this.btn1010.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1010.Location = new System.Drawing.Point(592, 160);
            this.btn1010.Margin = new System.Windows.Forms.Padding(2);
            this.btn1010.Name = "btn1010";
            this.btn1010.Size = new System.Drawing.Size(154, 57);
            this.btn1010.TabIndex = 33;
            this.btn1010.Text = "[10,10]二維陣列\r\n1,0,1,0,1,0,1\r\n0,1,0,1,0,1,0\r\n1,0,1,0,1,0,1\r\n0,1,0,1,0,1,0";
            this.btn1010.UseVisualStyleBackColor = true;
            this.btn1010.Click += new System.EventHandler(this.btn1010_Click);
            // 
            // btntwoArrayside0
            // 
            this.btntwoArrayside0.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntwoArrayside0.Location = new System.Drawing.Point(398, 72);
            this.btntwoArrayside0.Margin = new System.Windows.Forms.Padding(2);
            this.btntwoArrayside0.Name = "btntwoArrayside0";
            this.btntwoArrayside0.Size = new System.Drawing.Size(177, 38);
            this.btntwoArrayside0.TabIndex = 32;
            this.btntwoArrayside0.Text = "[10,10]二維陣列-邊0,內1";
            this.btntwoArrayside0.UseVisualStyleBackColor = true;
            this.btntwoArrayside0.Click += new System.EventHandler(this.btntwoArrayside0_Click);
            // 
            // btntwoArrayside1
            // 
            this.btntwoArrayside1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntwoArrayside1.Location = new System.Drawing.Point(398, 30);
            this.btntwoArrayside1.Margin = new System.Windows.Forms.Padding(2);
            this.btntwoArrayside1.Name = "btntwoArrayside1";
            this.btntwoArrayside1.Size = new System.Drawing.Size(177, 38);
            this.btntwoArrayside1.TabIndex = 31;
            this.btntwoArrayside1.Text = "[10,10]二維陣列-邊1,內0";
            this.btntwoArrayside1.UseVisualStyleBackColor = true;
            this.btntwoArrayside1.Click += new System.EventHandler(this.btntwoArrayside1_Click);
            // 
            // btnLongname
            // 
            this.btnLongname.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLongname.Location = new System.Drawing.Point(203, 114);
            this.btnLongname.Margin = new System.Windows.Forms.Padding(2);
            this.btnLongname.Name = "btnLongname";
            this.btnLongname.Size = new System.Drawing.Size(182, 44);
            this.btnLongname.TabIndex = 30;
            this.btnLongname.Text = "陣列arr0711_str[ ] 最長的名字";
            this.btnLongname.UseVisualStyleBackColor = true;
            this.btnLongname.Click += new System.EventHandler(this.btnLongname_Click);
            // 
            // btArrXueC
            // 
            this.btArrXueC.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btArrXueC.Location = new System.Drawing.Point(262, 174);
            this.btArrXueC.Margin = new System.Windows.Forms.Padding(2);
            this.btArrXueC.Name = "btArrXueC";
            this.btArrXueC.Size = new System.Drawing.Size(264, 33);
            this.btArrXueC.TabIndex = 29;
            this.btArrXueC.Text = "陣列arr0711_str[ ] xue C or c的字樣有幾個";
            this.btArrXueC.UseVisualStyleBackColor = true;
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwap.Location = new System.Drawing.Point(592, 30);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(154, 28);
            this.btnSwap.TabIndex = 28;
            this.btnSwap.Text = "Swap[int,int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMin.Location = new System.Drawing.Point(592, 128);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(154, 28);
            this.btnMin.TabIndex = 27;
            this.btnMin.Text = "Min(陣列arr0711[ ])";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMax.Location = new System.Drawing.Point(592, 96);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(154, 28);
            this.btnMax.TabIndex = 26;
            this.btnMax.Text = "Max(陣列arr0711[ ])";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSum.Location = new System.Drawing.Point(592, 62);
            this.btnSum.Margin = new System.Windows.Forms.Padding(2);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(154, 28);
            this.btnSum.TabIndex = 25;
            this.btnSum.Text = "Sum(陣列arr0711[ ])";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnArrtotal
            // 
            this.btnArrtotal.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrtotal.Location = new System.Drawing.Point(203, 71);
            this.btnArrtotal.Margin = new System.Windows.Forms.Padding(2);
            this.btnArrtotal.Name = "btnArrtotal";
            this.btnArrtotal.Size = new System.Drawing.Size(182, 39);
            this.btnArrtotal.TabIndex = 24;
            this.btnArrtotal.Text = "陣列arr0711[ ]統計奇偶數的";
            this.btnArrtotal.UseVisualStyleBackColor = true;
            this.btnArrtotal.Click += new System.EventHandler(this.btnArrtotal_Click);
            // 
            // btnArr0711MaxMin
            // 
            this.btnArr0711MaxMin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArr0711MaxMin.Location = new System.Drawing.Point(398, 114);
            this.btnArr0711MaxMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnArr0711MaxMin.Name = "btnArr0711MaxMin";
            this.btnArr0711MaxMin.Size = new System.Drawing.Size(177, 41);
            this.btnArr0711MaxMin.TabIndex = 23;
            this.btnArr0711MaxMin.Text = "陣列arr0711[ ]最大/小值";
            this.btnArr0711MaxMin.UseVisualStyleBackColor = true;
            this.btnArr0711MaxMin.Click += new System.EventHandler(this.btnArr0711MaxMin_Click);
            // 
            // labResult
            // 
            this.labResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labResult.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.ForeColor = System.Drawing.Color.Black;
            this.labResult.Location = new System.Drawing.Point(394, 219);
            this.labResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(274, 222);
            this.labResult.TabIndex = 22;
            this.labResult.Text = "結果";
            this.labResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(22, 95);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 60);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Transparent;
            this.lab.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab.Location = new System.Drawing.Point(315, 316);
            this.lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(72, 24);
            this.lab.TabIndex = 20;
            this.lab.Text = "Result:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "輸入數字:";
            // 
            // btnNumber
            // 
            this.btnNumber.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNumber.Location = new System.Drawing.Point(203, 30);
            this.btnNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(182, 37);
            this.btnNumber.TabIndex = 18;
            this.btnNumber.Text = "輸入的數字為奇數或偶數?";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(45, 46);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(101, 22);
            this.txtNumber.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1010);
            this.Controls.Add(this.btntwoArrayside0);
            this.Controls.Add(this.btntwoArrayside1);
            this.Controls.Add(this.btnLongname);
            this.Controls.Add(this.btArrXueC);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnArrtotal);
            this.Controls.Add(this.btnArr0711MaxMin);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1010;
        private System.Windows.Forms.Button btntwoArrayside0;
        private System.Windows.Forms.Button btntwoArrayside1;
        private System.Windows.Forms.Button btnLongname;
        private System.Windows.Forms.Button btArrXueC;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnArrtotal;
        private System.Windows.Forms.Button btnArr0711MaxMin;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

