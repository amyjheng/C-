namespace _0807POS機系統
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
            this.labmenu = new System.Windows.Forms.Label();
            this.beer = new System.Windows.Forms.Button();
            this.teqi = new System.Windows.Forms.Button();
            this.whis = new System.Windows.Forms.Button();
            this.wine = new System.Windows.Forms.Button();
            this.lablist1 = new System.Windows.Forms.Label();
            this.labTotalprice = new System.Windows.Forms.Label();
            this.labPayment = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lablist = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labmenu
            // 
            this.labmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labmenu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmenu.Location = new System.Drawing.Point(20, 44);
            this.labmenu.Name = "labmenu";
            this.labmenu.Size = new System.Drawing.Size(280, 306);
            this.labmenu.TabIndex = 0;
            this.labmenu.Text = "菜單Menu";
            // 
            // beer
            // 
            this.beer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beer.BackgroundImage")));
            this.beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.beer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.beer.Location = new System.Drawing.Point(32, 77);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(114, 112);
            this.beer.TabIndex = 1;
            this.beer.Text = "啤酒\r\nBEER\r\nNT$120";
            this.beer.UseVisualStyleBackColor = true;
            this.beer.Click += new System.EventHandler(this.beer_Click);
            // 
            // teqi
            // 
            this.teqi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teqi.BackgroundImage")));
            this.teqi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.teqi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.teqi.Location = new System.Drawing.Point(173, 77);
            this.teqi.Name = "teqi";
            this.teqi.Size = new System.Drawing.Size(114, 112);
            this.teqi.TabIndex = 2;
            this.teqi.Text = "龍舌蘭\r\nTequila\r\nNT$180\r\n";
            this.teqi.UseVisualStyleBackColor = true;
            this.teqi.Click += new System.EventHandler(this.teqi_Click);
            // 
            // whis
            // 
            this.whis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("whis.BackgroundImage")));
            this.whis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.whis.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.whis.Location = new System.Drawing.Point(32, 205);
            this.whis.Name = "whis";
            this.whis.Size = new System.Drawing.Size(114, 112);
            this.whis.TabIndex = 3;
            this.whis.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.whis.UseVisualStyleBackColor = true;
            this.whis.Click += new System.EventHandler(this.whis_Click);
            // 
            // wine
            // 
            this.wine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wine.BackgroundImage")));
            this.wine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wine.Location = new System.Drawing.Point(173, 205);
            this.wine.Name = "wine";
            this.wine.Size = new System.Drawing.Size(114, 112);
            this.wine.TabIndex = 4;
            this.wine.Text = "紅酒\r\nWine\r\nNT$320";
            this.wine.UseVisualStyleBackColor = true;
            this.wine.Click += new System.EventHandler(this.wine_Click);
            // 
            // lablist1
            // 
            this.lablist1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lablist1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lablist1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lablist1.Location = new System.Drawing.Point(590, 44);
            this.lablist1.Name = "lablist1";
            this.lablist1.Size = new System.Drawing.Size(280, 306);
            this.lablist1.TabIndex = 5;
            this.lablist1.Text = "購物清單List";
            // 
            // labTotalprice
            // 
            this.labTotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalprice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labTotalprice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalprice.Location = new System.Drawing.Point(304, 44);
            this.labTotalprice.Name = "labTotalprice";
            this.labTotalprice.Size = new System.Drawing.Size(280, 145);
            this.labTotalprice.TabIndex = 6;
            this.labTotalprice.Text = "總金額Total Price";
            // 
            // labPayment
            // 
            this.labPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPayment.Location = new System.Drawing.Point(306, 205);
            this.labPayment.Name = "labPayment";
            this.labPayment.Size = new System.Drawing.Size(280, 145);
            this.labPayment.TabIndex = 7;
            this.labPayment.Text = "付款方式 Payment";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Black;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(319, 106);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(244, 36);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(329, 243);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(104, 73);
            this.btnCash.TabIndex = 9;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCredit.Location = new System.Drawing.Point(459, 243);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(104, 73);
            this.btnCredit.TabIndex = 10;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(472, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "信用卡享9折!";
            // 
            // lablist
            // 
            this.lablist.BackColor = System.Drawing.Color.White;
            this.lablist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lablist.Location = new System.Drawing.Point(612, 67);
            this.lablist.Name = "lablist";
            this.lablist.Size = new System.Drawing.Size(234, 234);
            this.lablist.TabIndex = 12;
            this.lablist.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(738, 304);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(119, 36);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "清除清單";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lablist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labPayment);
            this.Controls.Add(this.labTotalprice);
            this.Controls.Add(this.lablist1);
            this.Controls.Add(this.wine);
            this.Controls.Add(this.whis);
            this.Controls.Add(this.teqi);
            this.Controls.Add(this.beer);
            this.Controls.Add(this.labmenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labmenu;
        private System.Windows.Forms.Button beer;
        private System.Windows.Forms.Button teqi;
        private System.Windows.Forms.Button whis;
        private System.Windows.Forms.Button wine;
        private System.Windows.Forms.Label lablist1;
        private System.Windows.Forms.Label labTotalprice;
        private System.Windows.Forms.Label labPayment;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lablist;
        private System.Windows.Forms.Button btnclear;
    }
}

