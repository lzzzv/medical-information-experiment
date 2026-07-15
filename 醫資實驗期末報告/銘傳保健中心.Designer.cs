namespace 醫資實驗期末報告
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timernowtime = new System.Windows.Forms.Timer(this.components);
            this.btn測量記錄 = new System.Windows.Forms.Button();
            this.btn測量 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn返回 = new System.Windows.Forms.Button();
            this.btn進入測量 = new System.Windows.Forms.Button();
            this.txtBx學號 = new System.Windows.Forms.TextBox();
            this.txtBx姓名 = new System.Windows.Forms.TextBox();
            this.txtBx科系 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(329, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "銘傳保健中心測量程式";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTime.ForeColor = System.Drawing.Color.Blue;
            this.labelTime.Location = new System.Drawing.Point(385, 150);
            this.labelTime.Name = "labelTime";
            this.labelTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTime.Size = new System.Drawing.Size(497, 48);
            this.labelTime.TabIndex = 11;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timernowtime
            // 
            this.timernowtime.Tick += new System.EventHandler(this.timernowtime_Tick);
            // 
            // btn測量記錄
            // 
            this.btn測量記錄.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn測量記錄.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn測量記錄.ForeColor = System.Drawing.Color.White;
            this.btn測量記錄.Location = new System.Drawing.Point(522, 373);
            this.btn測量記錄.Name = "btn測量記錄";
            this.btn測量記錄.Size = new System.Drawing.Size(250, 51);
            this.btn測量記錄.TabIndex = 14;
            this.btn測量記錄.Text = "測量記錄";
            this.btn測量記錄.UseVisualStyleBackColor = false;
            this.btn測量記錄.Click += new System.EventHandler(this.btn測量記錄_Click);
            // 
            // btn測量
            // 
            this.btn測量.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn測量.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn測量.ForeColor = System.Drawing.Color.Red;
            this.btn測量.Location = new System.Drawing.Point(522, 309);
            this.btn測量.Name = "btn測量";
            this.btn測量.Size = new System.Drawing.Size(250, 51);
            this.btn測量.TabIndex = 13;
            this.btn測量.Text = "測量";
            this.btn測量.UseVisualStyleBackColor = false;
            this.btn測量.Click += new System.EventHandler(this.btn測量_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn返回);
            this.panel3.Controls.Add(this.btn進入測量);
            this.panel3.Controls.Add(this.txtBx學號);
            this.panel3.Controls.Add(this.txtBx姓名);
            this.panel3.Controls.Add(this.txtBx科系);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(825, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 276);
            this.panel3.TabIndex = 84;
            // 
            // btn返回
            // 
            this.btn返回.BackColor = System.Drawing.Color.White;
            this.btn返回.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn返回.ForeColor = System.Drawing.Color.Blue;
            this.btn返回.Location = new System.Drawing.Point(181, 207);
            this.btn返回.Name = "btn返回";
            this.btn返回.Size = new System.Drawing.Size(88, 31);
            this.btn返回.TabIndex = 87;
            this.btn返回.Text = "返回";
            this.btn返回.UseVisualStyleBackColor = false;
            this.btn返回.Click += new System.EventHandler(this.btn返回_Click);
            // 
            // btn進入測量
            // 
            this.btn進入測量.BackColor = System.Drawing.Color.White;
            this.btn進入測量.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn進入測量.ForeColor = System.Drawing.Color.Blue;
            this.btn進入測量.Location = new System.Drawing.Point(23, 207);
            this.btn進入測量.Name = "btn進入測量";
            this.btn進入測量.Size = new System.Drawing.Size(88, 31);
            this.btn進入測量.TabIndex = 85;
            this.btn進入測量.Text = "確定";
            this.btn進入測量.UseVisualStyleBackColor = false;
            this.btn進入測量.Click += new System.EventHandler(this.btn進入測量_Click);
            // 
            // txtBx學號
            // 
            this.txtBx學號.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBx學號.Location = new System.Drawing.Point(87, 128);
            this.txtBx學號.Multiline = true;
            this.txtBx學號.Name = "txtBx學號";
            this.txtBx學號.Size = new System.Drawing.Size(158, 33);
            this.txtBx學號.TabIndex = 86;
            // 
            // txtBx姓名
            // 
            this.txtBx姓名.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBx姓名.Location = new System.Drawing.Point(87, 32);
            this.txtBx姓名.Multiline = true;
            this.txtBx姓名.Name = "txtBx姓名";
            this.txtBx姓名.Size = new System.Drawing.Size(158, 33);
            this.txtBx姓名.TabIndex = 84;
            // 
            // txtBx科系
            // 
            this.txtBx科系.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBx科系.Location = new System.Drawing.Point(87, 78);
            this.txtBx科系.Multiline = true;
            this.txtBx科系.Name = "txtBx科系";
            this.txtBx科系.Size = new System.Drawing.Size(158, 33);
            this.txtBx科系.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "姓名:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "科系:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "學號:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(78, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 178);
            this.panel1.TabIndex = 85;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(239, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "顯示密碼";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(19, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 14;
            this.button6.Text = "確定";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(249, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 13;
            this.button5.Text = "取消";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "密碼:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "帳號:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(100, 93);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 28);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(100, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 25);
            this.textBox1.TabIndex = 0;
            // 
            // 首頁
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1293, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn測量記錄);
            this.Controls.Add(this.btn測量);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label1);
            this.Name = "首頁";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.首頁_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timernowtime;
        private System.Windows.Forms.Button btn測量記錄;
        private System.Windows.Forms.Button btn測量;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn返回;
        private System.Windows.Forms.Button btn進入測量;
        private System.Windows.Forms.TextBox txtBx學號;
        private System.Windows.Forms.TextBox txtBx姓名;
        private System.Windows.Forms.TextBox txtBx科系;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}