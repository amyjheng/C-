namespace _0806xogame
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
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Xwin = new System.Windows.Forms.Label();
            this.Owin = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(273, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "XO GAME 井字遊戲";
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(277, 66);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(64, 60);
            this.A00.TabIndex = 1;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.btnclick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(358, 66);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(64, 60);
            this.A01.TabIndex = 2;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.btnclick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(438, 66);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(64, 60);
            this.A02.TabIndex = 3;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.btnclick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(277, 149);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(64, 60);
            this.A10.TabIndex = 4;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.btnclick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(358, 149);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(64, 60);
            this.A11.TabIndex = 5;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.btnclick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(438, 149);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(64, 60);
            this.A12.TabIndex = 6;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.btnclick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(277, 243);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(64, 60);
            this.A20.TabIndex = 7;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.btnclick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(358, 243);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(64, 60);
            this.A21.TabIndex = 8;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.btnclick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(438, 243);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(64, 60);
            this.A22.TabIndex = 9;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.btnclick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(300, 334);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 60);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset(R)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit(Esc)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Xwin
            // 
            this.Xwin.AutoSize = true;
            this.Xwin.Location = new System.Drawing.Point(562, 90);
            this.Xwin.Name = "Xwin";
            this.Xwin.Size = new System.Drawing.Size(28, 12);
            this.Xwin.TabIndex = 12;
            this.Xwin.Text = "X勝:";
            // 
            // Owin
            // 
            this.Owin.AutoSize = true;
            this.Owin.Location = new System.Drawing.Point(562, 173);
            this.Owin.Name = "Owin";
            this.Owin.Size = new System.Drawing.Size(28, 12);
            this.Owin.TabIndex = 13;
            this.Owin.Text = "O勝:";
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Location = new System.Drawing.Point(562, 267);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(32, 12);
            this.Draw.TabIndex = 14;
            this.Draw.Text = "平手:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Owin);
            this.Controls.Add(this.Xwin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Xwin;
        private System.Windows.Forms.Label Owin;
        private System.Windows.Forms.Label Draw;
    }
}

