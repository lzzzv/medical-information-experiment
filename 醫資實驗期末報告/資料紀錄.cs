using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 醫資實驗期末報告
{
    public partial class 資料紀錄: Form
    {
  
        public 資料紀錄()
        {
            InitializeComponent();
        }

        public 資料紀錄(string 姓名,string 科系,string 學號,string 收縮壓,string 舒張壓,string 血氧,string 心率,string 溫度,string 時間)
        {
            InitializeComponent();
          
            string 新資料 = $"時間:{時間} 姓名:{姓名} 科系:{科系} 學號:{學號} 收縮壓:{收縮壓} 舒張壓:{舒張壓}\r\n 血氧:{血氧} 心率:{心率} 體溫:{溫度}\r\n";
            textBox1.AppendText(新資料);
            File.AppendAllText("data.txt", 新資料);
        }

        private void 資料紀錄_Load(object sender, EventArgs e)
        {
            
            if (File.Exists("data.txt"))
            {
                string 所有資料 = File.ReadAllText("data.txt");
                textBox1.Text = 所有資料;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            首頁 首頁 = new 首頁();
            首頁.Show();
            this.Hide();
            return;
        }
    }
   }

