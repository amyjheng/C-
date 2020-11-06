namespace WindowsFormsApp2
{
    partial class homework_hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homework_hello));
            this.name2 = new System.Windows.Forms.TextBox();
            this.englishname1 = new System.Windows.Forms.TextBox();
            this.gender1 = new System.Windows.Forms.TextBox();
            this.starsign1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.Label();
            this.englishname = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.starsign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(328, 67);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(201, 22);
            this.name2.TabIndex = 0;
            // 
            // englishname1
            // 
            this.englishname1.Location = new System.Drawing.Point(328, 107);
            this.englishname1.Name = "englishname1";
            this.englishname1.Size = new System.Drawing.Size(201, 22);
            this.englishname1.TabIndex = 1;
            // 
            // gender1
            // 
            this.gender1.Location = new System.Drawing.Point(328, 153);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(201, 22);
            this.gender1.TabIndex = 2;
            // 
            // starsign1
            // 
            this.starsign1.Location = new System.Drawing.Point(328, 203);
            this.starsign1.Name = "starsign1";
            this.starsign1.Size = new System.Drawing.Size(201, 22);
            this.starsign1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(223, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Say Hello!";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(484, 276);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(147, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "Say Hi!";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.BackColor = System.Drawing.Color.Transparent;
            this.name1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name1.Location = new System.Drawing.Point(230, 70);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(55, 19);
            this.name1.TabIndex = 6;
            this.name1.Text = "姓名:";
            this.name1.Click += new System.EventHandler(this.label1_Click);
            // 
            // englishname
            // 
            this.englishname.AutoSize = true;
            this.englishname.BackColor = System.Drawing.Color.Transparent;
            this.englishname.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.englishname.Location = new System.Drawing.Point(187, 110);
            this.englishname.Name = "englishname";
            this.englishname.Size = new System.Drawing.Size(126, 19);
            this.englishname.TabIndex = 7;
            this.englishname.Text = "English name:";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gender.Location = new System.Drawing.Point(230, 153);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(55, 19);
            this.gender.TabIndex = 8;
            this.gender.Text = "性別:";
            // 
            // starsign
            // 
            this.starsign.AutoSize = true;
            this.starsign.BackColor = System.Drawing.Color.Transparent;
            this.starsign.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.starsign.Location = new System.Drawing.Point(230, 206);
            this.starsign.Name = "starsign";
            this.starsign.Size = new System.Drawing.Size(55, 19);
            this.starsign.TabIndex = 9;
            this.starsign.Text = "星座:";
            // 
            // homework_hello
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.starsign);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.englishname);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.starsign1);
            this.Controls.Add(this.gender1);
            this.Controls.Add(this.englishname1);
            this.Controls.Add(this.name2);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "homework_hello";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox englishname1;
        private System.Windows.Forms.TextBox gender1;
        private System.Windows.Forms.TextBox starsign1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label englishname;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label starsign;
    }
}

