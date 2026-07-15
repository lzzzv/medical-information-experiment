using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 醫資實驗期末報告
{
    public partial class 偵測系統: Form
    {
        public 偵測系統(string name, string dept, string studentID)
        {
            InitializeComponent();
            label9.Text = string.Format("{0} ", name);
            label10.Text= string.Format("{0} ",dept);
            label11.Text = string.Format("{0} ", studentID);
        }
        int len, i;
        byte[] buf;
        StringBuilder res, resDec;
        int iStart, iEnd, dt, sys, dias;
        List<byte> raw;
        List<byte> bp;
        Bitmap bmp;
        float signal, s0, scaleH;
        Pen pR, pB, myPen;
        SolidBrush sbW, sbR, sbB;
        bool bBP;
        byte[] bpStart = { 0xFF, 0xF4, 0x02, 0x30, 0x31, 0x3B, 0x3B, 0x44, 0x37, 0x03 },
            bpStop = { 0xFF, 0xF4, 0x02, 0x30, 0x33, 0x3B, 0x3B, 0x44, 0x39, 0x03 },
            bpGet = { 0xFF, 0xF4, 0x02, 0x31, 0x38, 0x3B, 0x3B, 0x44, 0x46, 0x03 };
        int data, hr, k, iBP0, iBP1;

        char degSpO2 = '\u00B0';
        int lenSpO2, iSpO2;
        byte[] bufSpO2;
        StringBuilder resSpO2, resDecSpO2;
        int iStartSpO2, iEndSpO2, dtSpO2, countdownSpO2,countdownECG;
        byte tempLo7SpO2, tempHi89SpO2;
        ushort tempSpO2;
        float ftempSpO2;
        List<byte> rawSpO2;
        List<byte> PulseWaveSpO2;
        List<byte> HRSpO2;
        bool isSaved = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            countdownECG--;
            btnECG開始.Text = string.Format("倒數{0}秒!", countdownECG);
            if (countdownECG == 0)
            {
                button2.Enabled = true;
                btn返回.Enabled = false;
                btnECG開始.Text = "心電圖";
                btnECG開始.Enabled = true;
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Measurements for 30 sec:Done!!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show(
                    "尚未儲存資料，返回將會遺失目前的資料，是否仍要返回？",
                    "資料尚未儲存",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    首頁 首頁 = new 首頁();
                    首頁.Show();
                    this.Hide();
                }
            }
            else
            {
                首頁 首頁 = new 首頁();
                首頁.Show();
                this.Hide();
            }
        }

        private void btn儲存_Click(object sender, EventArgs e)
        {
            isSaved = true;
            string 姓名 = label9.Text;
            string 科系 = label10.Text;
            string 學號 = label11.Text;
            string 收縮壓 = lbl收縮壓.Text;
            string 舒張壓 = lbl舒張壓.Text;
            string 血氧 = lblSpO2.Text;
            string 心率 = lblHR.Text;
            string 溫度 = lblTemp.Text;
            string 時間 = lbl測量時間.Text;
            資料紀錄 資料紀錄 = new 資料紀錄(姓名, 科系, 學號, 收縮壓, 舒張壓, 血氧, 心率, 溫度,時間);
            資料紀錄.Show();
            this.Hide();

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decode1();
            displayG1();       
        }
        private double FIRfiltering1(double[] raw1)
        {
            double filtered1 = 0.0;
            for (int i = 0; i < m_a1.Length; i++)
                filtered1 += m_a1[i] * raw1[i];
            return filtered1;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            iStart1 = 0;
            iEnd1 = -1;
            iS1 = 0;
            iE1 = -1;
            x01 = 0;
            x11 = 0;
            y001 = 0;
            y011 = 0;
            y021 = 0;
            raw1.Clear();
            gI1.Clear(Color.White);
            pictureBox1.Image = bmpI1;
            pictureBox2.Image = bmpII1;
            pictureBox3.Image = bmpV1;
            gII1.Clear(Color.White);
            gV1.Clear(Color.White);
            Array.Clear(buf1, 0, buf1.Length);
            if (serialPortR.IsOpen)
                serialPortR.Close();
            serialPortR.PortName = comboBox1.SelectedItem.ToString();
            stopWatch1.Reset();
            stopWatch1.Start();
            serialPortR.Open();
            btnECG開始.Enabled = true;
            btnECG開始.Enabled = false;
            timer1.Start();
            cnt1 = 0;
            countdownECG = 30;
            timer2.Start();
        }

        private void 偵測系統_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortR.IsOpen)
                serialPortR.Close();
        }
        private void timerSpO22_Tick(object sender, EventArgs e)
        {
            countdownSpO2--;
            btnSpO2開始.Text = string.Format("倒數{0}秒!", countdownSpO2);
            if (countdownSpO2 == 0)
            {
                button2.Enabled = true;
                btn返回.Enabled = false;
                btnSpO2開始.Text = "測量血氧、心率及溫度";
                btnSpO2開始.Enabled = true;
                timerSpO21.Stop();
                timerSpO22.Stop();
                MessageBox.Show("Measurements for 30 sec:Done!!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void timerSpO21_Tick(object sender, EventArgs e)
        {
            displaySpO2();
            displayGSpO2();
        }

        private void btnSpO2開始_Click(object sender, EventArgs e)
        {
            iStartSpO2 = 0;
            iEndSpO2 = -1;
            iSSpO2 = 0;
            iESpO2 = -1;
            x0SpO2 = 0;
            x1SpO2 = 0;
            y0SpO2 = bmpSpO2.Height / 2;
            y1SpO2 = bmpSpO2.Height / 2;
            rawSpO2.Clear();
            gSpO2.Clear(Color.White);
            picSpO2.Image = bmpSpO2;
            txtBxSpO2.Text = "";
            Array.Clear(bufSpO2, 0, bufSpO2.Length);
            btn返回.Enabled = false;
            if (serialPortR.IsOpen)
                serialPortR.Close();
            serialPortR.PortName = comboBox1.SelectedItem.ToString();
            serialPortR.Open();
            btnSpO2開始.Enabled = false;
            countdownSpO2 = 30;
            
            timerSpO21.Start();
            timerSpO22.Start();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        List<byte> SpO2SpO2;
        Bitmap bmpSpO2;
        float s0SpO2, scaleHSpO2, fminSpO2, fmaxSpO2 = 110;
        Graphics gSpO2;
        int hrSpO2, wwSpO2 = 500, hhSpO2 = 250, iSSpO2, iESpO2, x0SpO2, x1SpO2, y0SpO2, y1SpO2, dHSpO2, dSSpO2 = 2, iPenSpO2;
        Pen pRSpO2, pBSpO2, myPenSpO2;
        SolidBrush sbWSpO2, sbRSpO2;

        private void pnl包含_Paint(object sender, PaintEventArgs e)
        {

        }

        Graphics g;
        int ww = 1100, hh = 250, iS, iE, x0, x1, y0, y1, dH, dS = 1, iPen;

        private void button4_Click(object sender, EventArgs e)
        {
            pnl包含.Visible = false;
            button2.Enabled = true;
            btn返回.Enabled = true;
            btn返回.Visible = true;
            serialPortR.Close();
            timerPressure.Stop();
            timerSpO21.Stop();
            timerSpO22.Stop();
            timer1.Stop();
            timer2.Stop();
            gI1.Clear(Color.White);
            gII1.Clear(Color.White);
            gV1.Clear(Color.White);
            pictureBox1.Image = bmpI1;
            pictureBox2.Image = bmpII1;
            pictureBox3.Image = bmpV1;
            gSpO2.Clear(Color.White);
            picSpO2.Image = bmpSpO2;
            g.Clear(Color.White);
            picPressure.Image = bmp;
            txtBxSpO2.Text = "";
            txtBxRx.Text = "";
            lblHR.Text = "";
            lblSpO2.Text = "";
            lblTemp.Text = "";
            lbl收縮壓.Text = "";
            lbl血壓.Text = "";
            lbl舒張壓.Text = "";
            btnSpO2開始.Enabled = true;
            btnSpO2開始.Text = "測量血氧、心率及溫度";
            btnECG開始.Enabled = true;
            btnECG開始.Text = "心電圖";
            stopWatch1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl包含.Visible=true;
            DateTime 測量時間 = DateTime.Now;
            lbl測量時間.Text = 測量時間.ToString();
        }

        private void serialPortR_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int bytesAvailable = serialPortR.BytesToRead;
            if (bytesAvailable <= 0) return;

            byte[] tempBuf = new byte[bytesAvailable];
            serialPortR.Read(tempBuf, 0, bytesAvailable);

            // BP
            if (!button2.Enabled)
            {
                raw.AddRange(tempBuf);
            }

            // SpO2
            if (!btnSpO2開始.Enabled)
            {
                rawSpO2.AddRange(tempBuf);
                iEndSpO2 = rawSpO2.Count;
            }

            // ECG
            if (!btnECG開始.Enabled)
            {
                raw1.AddRange(tempBuf);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gSpO2.Clear(Color.White);
            picSpO2.Image = bmpSpO2;
            g.Clear(Color.White);
            picPressure.Image = bmp;
            txtBxSpO2.Text = "";          
            txtBxRx.Text = "";
            lblHR.Text = "";
            lblSpO2.Text = "";
            lblTemp.Text = "";
            lbl收縮壓.Text = "";
            lbl血壓.Text = "";
            lbl舒張壓.Text = "";
            
        }
        public void displayG()
        {
            iE = bp.Count;
            while (iS < iE)
            {
                s0 = bp[iS++];
                x1 = (x1 >= ww) ? 0 : x1;
                y1 = (int)((200 - s0) * scaleH) + dH;
                if (x1 == 0)
                    x0 = 0;
                g.DrawLine(myPen, x0, y0, x1, y1);
                x0 = x1;
                y0 = y1;
                x1 += dS;
            }
            picPressure.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAllPorts();
        }
        private void getAllPorts()
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            foreach (string port in ports)
                comboBox1.Items.Add(port);
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            button2.Enabled = true;
        }

        private void timerPressure_Tick(object sender, EventArgs e)
        {
            decode_display();
            if (bBP)
                displayG();
            Application.DoEvents();
        }



        private void btn開始測量_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            picPressure.Image = bmp;
            //
            iStart = 0;
            iEnd = -1;
            iS = 0;
            iE = -1;
            x0 = 0;
            x1 = 0;
            y0 = bmp.Height / 2;
            raw.Clear();
            g.Clear(Color.White);
            picPressure.Image = bmp;
            txtBxRx.Text = "";
            Array.Clear(buf, 0, buf.Length);
            btn返回.Enabled = false;
            if (serialPortR.IsOpen)
                serialPortR.Close();
            serialPortR.PortName = comboBox1.SelectedItem.ToString();
            serialPortR.Open();
            button2.Enabled = false;
            btn開始測量.Enabled = true;
            bBP = false;
            myPen = pR;
            //
            bBP ^= true;
            if (bBP)
            {
                g.Clear(Color.White);
                picPressure.Image = bmp;
                btn開始測量.Text = "停止測量血壓";
                serialPortR.Write(bpStart, 0, bpStart.Length);
                btn返回.Enabled = false;
                timerPressure.Start();
            }
            else
            {
                btn開始測量.Text = "開始測量血壓";
                serialPortR.Write(bpStop, 0, bpStop.Length);
                button4.Enabled = true;
            }
        }
        public void decode_display()
        {
            if (raw.Count - iEnd < 8)
                return;
            iEnd = raw.Count - 44;
            res.Clear();
            while (iStart <= iEnd)
            {
                dt = raw[iStart];
                res.AppendFormat("{0:X2} ", dt);
                if (raw[iStart] == 0xFF && raw[iStart + 1] == 0xF4)

                {
                    if (raw[iStart + 10] == 3 && raw[iStart + 11] == 0x0D)
                    {
                        data = (raw[iStart + 3] - 48) * 100 + (raw[iStart + 4] - 48) * 10 + (raw[iStart + 5] - 48);
                        bp.Add((byte)data);
                            lbl血壓.Text = string.Format("{0}",data);
                        iStart += 11;
                    }
                    else if (raw[iStart + 6] == 3 && raw[iStart + 7] == 13 && raw[iStart + 3] == 57
                        && raw[iStart + 4] == 57 && raw[iStart + 5] == 57)
                    {
                        serialPortR.Write(bpGet, 0, bpGet.Length);
                        btn開始測量.Text = "開始測量血壓";
                        Text = "Blood Pressure is done!";
                        btn返回.Enabled = true;
                        button4.Visible = true;
                        bBP = false;
                        iStart += 7;
                    }
                    else if (raw[iStart + 42] == 3 && raw[iStart + 43] == 0x0D)
                    {
                        sys = (raw[iStart + 18] - 48) * 100 + (raw[iStart + 19] - 48) * 10 + (raw[iStart + 20] - 48);
                        dias = (raw[iStart + 21] - 48) * 100 + (raw[iStart + 22] - 48) * 10 + (raw[iStart + 23] - 48);
                        lbl收縮壓.Text = string.Format("{0}", sys);
                        lbl舒張壓.Text = string.Format("{0}", dias);
                        iStart += 43;
                        if (data == 0)
                            lbl血壓.Text = string.Format("{0}/{1}mmHg", sys, dias);
                    }
                }
                iStart++;
            }
            txtBxRx.Text = res.ToString();
        }
        public void displaySpO2()
        {
            iEndSpO2 = rawSpO2.Count;
            resSpO2.Clear();
            while (iStartSpO2 < iEndSpO2 - 14)
            {
                dtSpO2 = rawSpO2[iStartSpO2];
                if (dtSpO2 == 0xff)
                    resSpO2.AppendLine();
                resSpO2.AppendFormat("{0:X2} ", dtSpO2);
                if (rawSpO2[iStartSpO2] == 0xFF && rawSpO2[iStartSpO2 + 1] == 0xF3)
                {
                    PulseWaveSpO2.Add(rawSpO2[iStartSpO2 + 3]);
                    hrSpO2 = ((rawSpO2[iStartSpO2 + 4] & 0x40) << 1) | (rawSpO2[iStartSpO2 + 5] & 0x7f);
                    HRSpO2.Add((byte)hrSpO2);
                    SpO2SpO2.Add(rawSpO2[iStartSpO2 + 6]);
                    lblSpO2.Text = string.Format("{0}%", rawSpO2[iStartSpO2 + 6]);
                    lblHR.Text = string.Format("{0}bmp", hrSpO2);
                }
                else if (rawSpO2[iStartSpO2] == 0xFF && rawSpO2[iStartSpO2 + 1] == 0xE2)
                {
                    tempLo7SpO2 = rawSpO2[iStartSpO2 + 12];
                    tempHi89SpO2 = (byte)((rawSpO2[iStartSpO2 + 13] & 0x30) >> 4);
                    tempSpO2 = (ushort)((tempHi89SpO2 << 7) | tempLo7SpO2);
                    ftempSpO2 = tempSpO2 * 45.0f / 512 + 5.0f;
                    lblTemp.Text = string.Format("{0:f1}{1}C", ftempSpO2, degSpO2);
                }
                iStartSpO2++;
            }
            txtBxSpO2.AppendText(resSpO2.ToString());
            Application.DoEvents();
        }

        public void displayGSpO2()
        {
            iESpO2 = PulseWaveSpO2.Count;
            while (iSSpO2 < iESpO2)
            {
                s0SpO2 = PulseWaveSpO2[iSSpO2++];
                x1SpO2 = (x1SpO2 >= wwSpO2) ? 0 : x1SpO2;
                y1SpO2 = (int)((fmaxSpO2 - s0SpO2) * scaleHSpO2) + dHSpO2;
                if (x1SpO2 == 0)
                {
                    fminSpO2 = PulseWaveSpO2.Min();
                    fmaxSpO2 = PulseWaveSpO2.Max();
                    scaleHSpO2 = (bmpSpO2.Height - 2 * dHSpO2) / (fmaxSpO2 - fminSpO2);
                    x0SpO2 = 0;
                    iPenSpO2++;
                    iPenSpO2 %= 2;
                    if (iPenSpO2 == 0)
                        myPenSpO2 = pBSpO2;
                    else
                        myPenSpO2 = pRSpO2;
                }
                gSpO2.FillRectangle(sbWSpO2, x1SpO2, 0, 10, hhSpO2);
                gSpO2.DrawLine(myPenSpO2, x0SpO2, y0SpO2, x1SpO2, y1SpO2);
                x0SpO2 = x1SpO2;
                y0SpO2 = y1SpO2;
                x1SpO2 += dSSpO2;
            }
            picSpO2.Image = bmpSpO2;
        }
        public 偵測系統()
        {
            InitializeComponent();

           
        }
        int len1, i1;
        byte[] buf1;
        int iStart1, iEnd1, dt1;
        List<byte> raw1;
        List<int> Lecg1, Lhr1, Ltemp1;
        Bitmap bmpI1, bmpII1, bmpV1;
        Graphics gI1, gII1, gV1;
        int hr1, temp11, temp21, ecg1, ecgCNT1 = -1;
        int imx1 = 2400, imn1 = 1800, y001 = 0, y011 = 0, y021 = 0, cnt1 = 0;
        float s01, scaleH1;
        int ww1 = 750, hh1 = 250, iS1, iE1, x01, x11, y11, dH1, iPen1;
        Pen pR1, pB1, myPen1;
        SolidBrush sbW1, sbR1;
        double[] m_a1 = {
            0.0024593392459372134, 0.0012694801871167231, -0.0029366492314269123,
            -0.0058732686125919061, -0.0023466957666592328, 0.0064945535372463231,
            0.011336261223662733, 0.0035568045681083839, -0.012655166954118943,
            -0.019960391743576569, -0.0047484627525475782, 0.023622153725863196,
            0.034690356202778876, 0.0057558397338354468, -0.046622431243507879,
            -0.067579936172768709, -0.0064297184128108377, 0.13227920610747901,
            0.27784275491046106, 0.34000000000000002, 0.27784275491046106,
            0.13227920610747901, -0.0064297184128108377, -0.067579936172768709,
            -0.046622431243507879, 0.0057558397338354468, 0.034690356202778876,
            0.023622153725863196, -0.0047484627525475782, -0.019960391743576569,
            -0.012655166954118943, 0.0035568045681083839, 0.011336261223662733,
            0.0064945535372463231, -0.0023466957666592328, -0.0058732686125919061,
            -0.0029366492314269123, 0.0012694801871167231, 0.0024593392459372134
        };
        double[] rawI1, rawII1, rawVI1;
        Color[] clr1 = new Color[] { Color.Red, Color.Magenta, Color.Fuchsia };
        Stopwatch stopWatch1;
        private void 偵測系統_Load(object sender, EventArgs e)
        {
            rawI1 = new double[m_a1.Length];
            rawII1 = new double[m_a1.Length];
            rawVI1 = new double[m_a1.Length];
            picPressure.Width = 742;
            picPressure.Height = 352;
            pnl包含.Visible = false;
            //BP
            picSpO2.Width = 742;
            picSpO2.Height = 352;
            txtBxRx.Visible = false;
            getAllPorts();
            raw = new List<byte>();
            bp = new List<byte>();
            buf = new byte[serialPortR.ReadBufferSize];
            res = new StringBuilder();
            bmp = new Bitmap(ww + 10, hh);
            g = Graphics.FromImage(bmp);
            dH = 25;
            scaleH = (bmp.Height - 2 * dH) / 200.0f;
            pR = new Pen(Color.Red, 2);
            pB = new Pen(Color.Blue, 2);
            sbW = new SolidBrush(Color.White);
            sbR = new SolidBrush(Color.Red);
            sbB = new SolidBrush(Color.Blue);
            iPen = 0;
            //SpO2
            rawSpO2 = new List<byte>();
            PulseWaveSpO2 = new List<byte>();
            HRSpO2 = new List<byte>();
            SpO2SpO2 = new List<byte>();
            bufSpO2 = new byte[serialPortR.ReadBufferSize];
            resSpO2 = new StringBuilder();
            resDecSpO2 = new StringBuilder();
            bmpSpO2 = new Bitmap(wwSpO2 + 10, hhSpO2);
            gSpO2 = Graphics.FromImage(bmpSpO2);
            dHSpO2 = 25;
            scaleHSpO2 = (bmpSpO2.Height - 2 * dHSpO2) / 110.0f;
            pRSpO2 = new Pen(Color.Red, 2);
            pBSpO2 = new Pen(Color.Blue, 2);
            sbWSpO2 = new SolidBrush(Color.White);
            sbRSpO2 = new SolidBrush(Color.Red);
            iPenSpO2 = 0;
            //ECG
            raw1 = new List<byte>();
            Ltemp1 = new List<int>();
            Lecg1 = new List<int>();
            Lhr1 = new List<int>();
            buf1 = new byte[serialPortR.ReadBufferSize];
            dH1 = 25;
            pR1 = new Pen(Color.Red, 2);
            pB1 = new Pen(Color.Blue, 2);
            sbW1 = new SolidBrush(Color.White);
            sbR1 = new SolidBrush(Color.Red);
            iPen1 = 0;
            bmpI1 = new Bitmap(ww1 + 10, hh1);
            bmpII1 = new Bitmap(ww1 + 10, hh1);
            bmpV1 = new Bitmap(ww1 + 10, hh1);
            gI1 = Graphics.FromImage(bmpI1);
            gII1 = Graphics.FromImage(bmpII1);
            gV1 = Graphics.FromImage(bmpV1);
            myPen1 = pB1;
            scaleH1 = (hh1 - 2.0f * dH1) / (imx1 - imn1);
            stopWatch1 = new Stopwatch();
        }
        private void displayG1()
        {
            iE1 = Lecg1.Count;
            while (iS1 < iE1 - 3)
            {
                s01 = Lecg1[iS1++];
                y11 = hh1 - dH1 - (int)((imx1 - s01) * scaleH1);
                x11++;
                if (x11 >= ww1)
                {
                    x01 = 0;
                    x11 = 0;
                    iPen1++;
                    iPen1 %= 2;
                    myPen1 = (iPen1 == 0) ? pB1 : pR1;
                }
                gI1.FillRectangle(sbW1, x11, 0, 10, hh1);
                gI1.DrawLine(myPen1, x01, y001, x11, y11);
                y001 = y11;

                s01 = Lecg1[iS1++];
                y11 = hh1 - dH1 - (int)((imx1 - s01) * scaleH1);
                gII1.FillRectangle(sbW1, x11, 0, 10, hh1);
                gII1.DrawLine(myPen1, x01, y011, x11, y11);
                y011 = y11;

                s01 = Lecg1[iS1++];
                y11 = hh1 - dH1 - (int)((s01 - imn1) * scaleH1);
                gV1.FillRectangle(sbW1, x11, 0, 10, hh1);
                gV1.DrawLine(myPen1, x01, y021, x11, y11);
                y021 = y11;

                x01 = x11;
            }
            pictureBox1.Image = bmpI1;
            pictureBox2.Image = bmpII1;
            pictureBox3.Image = bmpV1;
        }
        private void decode1()
        {
            int ecgCNT1 = 0;
            if (raw1 == null || raw1.Count == 0)
                return;

            while (iStart1 + 15 <= raw1.Count)
            {
                if (raw1[iStart1] == 0xFF && raw1[iStart1 + 1] == 0xE2)
                {
                    int ecg11 = ((raw1[iStart1 + 2] & 0x7F) << 7) | (raw1[iStart1 + 3] & 0x7F);
                    int ecg21 = ((raw1[iStart1 + 4] & 0x7F) << 7) | (raw1[iStart1 + 5] & 0x7F);
                    int ecg31 = ((raw1[iStart1 + 6] & 0x7F) << 7) | (raw1[iStart1 + 7] & 0x7F);

                    if (ecgCNT1 < m_a1.Length - 1)
                    {
                        rawI1[m_a1.Length - 1 - ecgCNT1] = ecg11;
                        rawII1[m_a1.Length - 1 - ecgCNT1] = ecg21;
                        rawVI1[m_a1.Length - 1 - ecgCNT1] = ecg31;
                        ecgCNT1++;
                    }
                    else
                    {
                        rawI1[0] = ecg11;
                        rawII1[0] = ecg21;
                        rawVI1[0] = ecg31;

                        ecg11 = (int)FIRfiltering1(rawI1);
                        ecg21 = (int)FIRfiltering1(rawII1);
                        ecg31 = (int)FIRfiltering1(rawVI1);

                        for (int ii = 0; ii < m_a1.Length - 1; ii++)
                        {
                            rawI1[m_a1.Length - 1 - ii] = rawI1[m_a1.Length - 2 - ii];
                            rawII1[m_a1.Length - 1 - ii] = rawII1[m_a1.Length - 2 - ii];
                            rawVI1[m_a1.Length - 1 - ii] = rawVI1[m_a1.Length - 2 - ii];
                        }
                    }

                    Lecg1.Add(ecg11);
                    Lecg1.Add(ecg21);
                    Lecg1.Add(ecg31);

                    hr1 = ((raw1[iStart1 + 13] & 0x03) << 7) | (raw1[iStart1 + 10] & 0x7F);
                    temp11 = ((raw1[iStart1 + 13] & 0x0C) << 5) | (raw1[iStart1 + 11] & 0x7F);
                    temp21 = ((raw1[iStart1 + 13] & 0x30) << 3) | (raw1[iStart1 + 12] & 0x7F);

                    Ltemp1.Add(temp11);
                    Ltemp1.Add(temp21);

                    label1.Text = $"HR: {hr1} bpm, Temp1: {temp11 / 10.0:F1} °C, Temp2: {temp21 / 10.0:F1} °C";

                    Debug.WriteLine($"ECG I:{ecg11}, II:{ecg21}, V:{ecg31}, HR:{hr1}, Temp1:{temp11 / 10.0:F1}, Temp2:{temp21 / 10.0:F1}");

                    iStart1 += 15;
                }
                else
                {
                    iStart1++;
                }
            }
        }
    }
}
