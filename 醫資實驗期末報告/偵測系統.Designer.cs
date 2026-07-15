namespace 醫資實驗期末報告
{
    partial class 偵測系統
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
            this.components = new System.ComponentModel.Container();
            this.serialPortR = new System.IO.Ports.SerialPort(this.components);
            this.timerPressure = new System.Windows.Forms.Timer(this.components);
            this.pnl包含 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnECG開始 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl收縮壓 = new System.Windows.Forms.Label();
            this.lbl血壓 = new System.Windows.Forms.Label();
            this.lbl舒張壓 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSpO2 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.btnSpO2開始 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picSpO2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPressure = new System.Windows.Forms.PictureBox();
            this.txtBxRx = new System.Windows.Forms.TextBox();
            this.txtBxSpO2 = new System.Windows.Forms.TextBox();
            this.btn開始測量 = new System.Windows.Forms.Button();
            this.lbl測量時間 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timerSpO22 = new System.Windows.Forms.Timer(this.components);
            this.timerSpO21 = new System.Windows.Forms.Timer(this.components);
            this.btn返回 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btn儲存 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnl包含.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpO2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPressure)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPortR
            // 
            this.serialPortR.BaudRate = 115200;
            this.serialPortR.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortR_DataReceived);
            // 
            // timerPressure
            // 
            this.timerPressure.Tick += new System.EventHandler(this.timerPressure_Tick);
            // 
            // pnl包含
            // 
            this.pnl包含.BackColor = System.Drawing.Color.Black;
            this.pnl包含.Controls.Add(this.label2);
            this.pnl包含.Controls.Add(this.label1);
            this.pnl包含.Controls.Add(this.btnECG開始);
            this.pnl包含.Controls.Add(this.pictureBox3);
            this.pnl包含.Controls.Add(this.pictureBox2);
            this.pnl包含.Controls.Add(this.pictureBox1);
            this.pnl包含.Controls.Add(this.tableLayoutPanel2);
            this.pnl包含.Controls.Add(this.tableLayoutPanel1);
            this.pnl包含.Controls.Add(this.btnSpO2開始);
            this.pnl包含.Controls.Add(this.panel2);
            this.pnl包含.Controls.Add(this.panel1);
            this.pnl包含.Controls.Add(this.btn開始測量);
            this.pnl包含.Location = new System.Drawing.Point(12, 79);
            this.pnl包含.Name = "pnl包含";
            this.pnl包含.Size = new System.Drawing.Size(2096, 1037);
            this.pnl包含.TabIndex = 83;
            this.pnl包含.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl包含_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(1468, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 103;
            this.label2.Text = "Templ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(1137, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 102;
            this.label1.Text = "Heart rate (From ECG):";
            // 
            // btnECG開始
            // 
            this.btnECG開始.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnECG開始.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnECG開始.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnECG開始.Location = new System.Drawing.Point(778, 14);
            this.btnECG開始.Name = "btnECG開始";
            this.btnECG開始.Size = new System.Drawing.Size(329, 53);
            this.btnECG開始.TabIndex = 101;
            this.btnECG開始.Text = "心電圖";
            this.btnECG開始.UseVisualStyleBackColor = false;
            this.btnECG開始.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(778, 732);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1297, 218);
            this.pictureBox3.TabIndex = 100;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(781, 432);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1297, 218);
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(778, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1297, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.CausesValidation = false;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.84195F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.15993F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.99813F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl收縮壓, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl血壓, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl舒張壓, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(299, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.91304F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.08696F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 115);
            this.tableLayoutPanel2.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(313, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 35);
            this.label6.TabIndex = 96;
            this.label6.Text = "血壓";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(161, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 35);
            this.label7.TabIndex = 95;
            this.label7.Text = "舒張壓";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 35);
            this.label8.TabIndex = 94;
            this.label8.Text = "收縮壓";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl收縮壓
            // 
            this.lbl收縮壓.AutoSize = true;
            this.lbl收縮壓.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl收縮壓.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl收縮壓.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl收縮壓.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl收縮壓.Location = new System.Drawing.Point(6, 41);
            this.lbl收縮壓.Name = "lbl收縮壓";
            this.lbl收縮壓.Size = new System.Drawing.Size(146, 71);
            this.lbl收縮壓.TabIndex = 88;
            this.lbl收縮壓.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl血壓
            // 
            this.lbl血壓.AutoSize = true;
            this.lbl血壓.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl血壓.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl血壓.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl血壓.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl血壓.Location = new System.Drawing.Point(313, 41);
            this.lbl血壓.Name = "lbl血壓";
            this.lbl血壓.Size = new System.Drawing.Size(143, 71);
            this.lbl血壓.TabIndex = 90;
            this.lbl血壓.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl舒張壓
            // 
            this.lbl舒張壓.AutoSize = true;
            this.lbl舒張壓.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl舒張壓.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl舒張壓.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl舒張壓.ForeColor = System.Drawing.Color.Red;
            this.lbl舒張壓.Location = new System.Drawing.Point(161, 41);
            this.lbl舒張壓.Name = "lbl舒張壓";
            this.lbl舒張壓.Size = new System.Drawing.Size(143, 71);
            this.lbl舒張壓.TabIndex = 89;
            this.lbl舒張壓.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.84195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.15993F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.99813F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSpO2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTemp, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHR, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(403, 491);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.91304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.08696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 115);
            this.tableLayoutPanel1.TabIndex = 95;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(245, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 35);
            this.label5.TabIndex = 96;
            this.label5.Text = "溫度";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 35);
            this.label4.TabIndex = 95;
            this.label4.Text = "心率";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 35);
            this.label3.TabIndex = 94;
            this.label3.Text = "血氧";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpO2
            // 
            this.lblSpO2.AutoSize = true;
            this.lblSpO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSpO2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpO2.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSpO2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSpO2.Location = new System.Drawing.Point(6, 41);
            this.lblSpO2.Name = "lblSpO2";
            this.lblSpO2.Size = new System.Drawing.Size(112, 71);
            this.lblSpO2.TabIndex = 88;
            this.lblSpO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemp.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTemp.Location = new System.Drawing.Point(245, 41);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(110, 71);
            this.lblTemp.TabIndex = 90;
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHR.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHR.ForeColor = System.Drawing.Color.Red;
            this.lblHR.Location = new System.Drawing.Point(127, 41);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(109, 71);
            this.lblHR.TabIndex = 89;
            this.lblHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSpO2開始
            // 
            this.btnSpO2開始.BackColor = System.Drawing.Color.Blue;
            this.btnSpO2開始.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSpO2開始.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSpO2開始.Location = new System.Drawing.Point(16, 491);
            this.btnSpO2開始.Name = "btnSpO2開始";
            this.btnSpO2開始.Size = new System.Drawing.Size(372, 53);
            this.btnSpO2開始.TabIndex = 91;
            this.btnSpO2開始.Text = "開始測量血氧、心率及溫度";
            this.btnSpO2開始.UseVisualStyleBackColor = false;
            this.btnSpO2開始.Click += new System.EventHandler(this.btnSpO2開始_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picSpO2);
            this.panel2.Location = new System.Drawing.Point(19, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 361);
            this.panel2.TabIndex = 79;
            // 
            // picSpO2
            // 
            this.picSpO2.BackColor = System.Drawing.Color.White;
            this.picSpO2.Location = new System.Drawing.Point(3, 6);
            this.picSpO2.Name = "picSpO2";
            this.picSpO2.Size = new System.Drawing.Size(742, 352);
            this.picSpO2.TabIndex = 0;
            this.picSpO2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picPressure);
            this.panel1.Controls.Add(this.txtBxRx);
            this.panel1.Controls.Add(this.txtBxSpO2);
            this.panel1.Location = new System.Drawing.Point(16, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 361);
            this.panel1.TabIndex = 78;
            // 
            // picPressure
            // 
            this.picPressure.BackColor = System.Drawing.Color.White;
            this.picPressure.Location = new System.Drawing.Point(3, 3);
            this.picPressure.Name = "picPressure";
            this.picPressure.Size = new System.Drawing.Size(742, 352);
            this.picPressure.TabIndex = 0;
            this.picPressure.TabStop = false;
            // 
            // txtBxRx
            // 
            this.txtBxRx.Font = new System.Drawing.Font("標楷體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBxRx.Location = new System.Drawing.Point(21, 33);
            this.txtBxRx.Multiline = true;
            this.txtBxRx.Name = "txtBxRx";
            this.txtBxRx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxRx.Size = new System.Drawing.Size(32, 34);
            this.txtBxRx.TabIndex = 87;
            this.txtBxRx.Visible = false;
            // 
            // txtBxSpO2
            // 
            this.txtBxSpO2.Font = new System.Drawing.Font("標楷體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBxSpO2.Location = new System.Drawing.Point(81, 30);
            this.txtBxSpO2.Multiline = true;
            this.txtBxSpO2.Name = "txtBxSpO2";
            this.txtBxSpO2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxSpO2.Size = new System.Drawing.Size(42, 37);
            this.txtBxSpO2.TabIndex = 84;
            this.txtBxSpO2.Visible = false;
            // 
            // btn開始測量
            // 
            this.btn開始測量.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn開始測量.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn開始測量.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn開始測量.Location = new System.Drawing.Point(16, 14);
            this.btn開始測量.Name = "btn開始測量";
            this.btn開始測量.Size = new System.Drawing.Size(277, 53);
            this.btn開始測量.TabIndex = 75;
            this.btn開始測量.Text = "開始測量血壓";
            this.btn開始測量.UseVisualStyleBackColor = false;
            this.btn開始測量.Click += new System.EventHandler(this.btn開始測量_Click);
            // 
            // lbl測量時間
            // 
            this.lbl測量時間.AutoSize = true;
            this.lbl測量時間.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl測量時間.ForeColor = System.Drawing.Color.White;
            this.lbl測量時間.Location = new System.Drawing.Point(928, 37);
            this.lbl測量時間.Name = "lbl測量時間";
            this.lbl測量時間.Size = new System.Drawing.Size(0, 23);
            this.lbl測量時間.TabIndex = 84;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(516, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 44);
            this.button4.TabIndex = 86;
            this.button4.Text = "結束";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(383, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 44);
            this.button2.TabIndex = 73;
            this.button2.Text = "進入";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(13, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 44);
            this.button1.TabIndex = 71;
            this.button1.Text = "取得連接";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 41);
            this.comboBox1.TabIndex = 72;
            // 
            // timerSpO22
            // 
            this.timerSpO22.Interval = 1000;
            this.timerSpO22.Tick += new System.EventHandler(this.timerSpO22_Tick);
            // 
            // timerSpO21
            // 
            this.timerSpO21.Tick += new System.EventHandler(this.timerSpO21_Tick);
            // 
            // btn返回
            // 
            this.btn返回.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn返回.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn返回.ForeColor = System.Drawing.Color.Purple;
            this.btn返回.Location = new System.Drawing.Point(782, 28);
            this.btn返回.Name = "btn返回";
            this.btn返回.Size = new System.Drawing.Size(127, 44);
            this.btn返回.TabIndex = 87;
            this.btn返回.Text = "返回";
            this.btn返回.UseVisualStyleBackColor = false;
            this.btn返回.Click += new System.EventHandler(this.btn返回_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1353, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 89;
            this.label9.Text = "姓名:";
            // 
            // btn儲存
            // 
            this.btn儲存.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn儲存.Font = new System.Drawing.Font("標楷體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存.ForeColor = System.Drawing.Color.Purple;
            this.btn儲存.Location = new System.Drawing.Point(649, 28);
            this.btn儲存.Name = "btn儲存";
            this.btn儲存.Size = new System.Drawing.Size(127, 44);
            this.btn儲存.TabIndex = 90;
            this.btn儲存.Text = "儲存資料";
            this.btn儲存.UseVisualStyleBackColor = false;
            this.btn儲存.Click += new System.EventHandler(this.btn儲存_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1569, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 91;
            this.label10.Text = "姓名:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1851, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 23);
            this.label11.TabIndex = 92;
            this.label11.Text = "姓名:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1268, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 23);
            this.label12.TabIndex = 93;
            this.label12.Text = "姓名:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1479, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 23);
            this.label13.TabIndex = 94;
            this.label13.Text = "科系:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1763, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 23);
            this.label14.TabIndex = 95;
            this.label14.Text = "學號:";
            // 
            // 偵測系統
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2120, 1055);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn儲存);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn返回);
            this.Controls.Add(this.pnl包含);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbl測量時間);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "偵測系統";
            this.Text = "銘傳健康中心";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.偵測系統_FormClosing);
            this.Load += new System.EventHandler(this.偵測系統_Load);
            this.pnl包含.ResumeLayout(false);
            this.pnl包含.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSpO2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPressure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortR;
        private System.Windows.Forms.Timer timerPressure;
        private System.Windows.Forms.Panel pnl包含;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl測量時間;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPressure;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn開始測量;
        private System.Windows.Forms.TextBox txtBxRx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picSpO2;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label lblSpO2;
        private System.Windows.Forms.TextBox txtBxSpO2;
        private System.Windows.Forms.Timer timerSpO22;
        private System.Windows.Forms.Timer timerSpO21;
        private System.Windows.Forms.Button btnSpO2開始;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl收縮壓;
        private System.Windows.Forms.Label lbl血壓;
        private System.Windows.Forms.Label lbl舒張壓;
        private System.Windows.Forms.Button btn返回;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnECG開始;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn儲存;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

