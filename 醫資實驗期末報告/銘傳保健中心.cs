using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 醫資實驗期末報告
{
    public partial class 首頁: Form
    {
        public 首頁()
        {
            InitializeComponent();
        }

        private void 首頁_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            label1.Top = 20;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            labelTime.Left = (this.ClientSize.Width - labelTime.Width) / 2;
            labelTime.Top = label1.Bottom + 60;
            timernowtime.Start();
            btn測量.Left = (this.ClientSize.Width - btn測量.Width) / 2;
            btn測量記錄.Left = (this.ClientSize.Width - btn測量記錄.Width) / 2;
            panel3.Top = labelTime.Bottom + 60;
            panel3.Left = (this.ClientSize.Width - panel3.Width) / 2;
            panel1.Top = labelTime.Bottom + 60;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            textBox2.PasswordChar = '*';
        }

        private void timernowtime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("yyyy/MM/dd tt hh:mm:ss");
        }

        private void btn測量_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void btn進入測量_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBx姓名.Text) ||
               string.IsNullOrWhiteSpace(txtBx學號.Text) ||
               string.IsNullOrWhiteSpace(txtBx科系.Text))
            {
                MessageBox.Show("請完整填寫所有欄位！", "資料未填寫", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtBx姓名.Text;
            string dept = txtBx科系.Text;
            string studentID = txtBx學號.Text;

            偵測系統 f2 = new 偵測系統(name, dept, studentID);
            f2.Show();
            this.Hide();
            
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            txtBx姓名.Text = "";
            txtBx學號.Text = "";
            txtBx科系.Text = "";
            panel3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string 使用者輸入帳號 = textBox1.Text.Trim();
            string 使用者輸入密碼 = textBox2.Text.Trim();
            string 帳號 = "admin";
            string 密碼 = "1234";

            if (使用者輸入帳號 == 帳號 && 使用者輸入密碼 == 密碼)
            {
                MessageBox.Show("登入成功！");
                資料紀錄 資料紀錄 = new 資料紀錄();
                資料紀錄.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤！");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void btn測量記錄_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "隱藏密碼";
                textBox2.PasswordChar = '\0';
            }
            else
            {
                checkBox1.Text = "顯示密碼";                
                    textBox2.PasswordChar = '*';
            }
        }
    }
}
