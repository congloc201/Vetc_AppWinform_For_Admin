using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Response;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class FormHistory : Form
    {
        FirebaseClient client;
        String key;
        public FormHistory(FirebaseClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {

            getdata();


        }
        private async void testdata()
        {
            var data1 = new History
            {
                email = "pentakillhy",
                loaive = "Luot",
                loaixe = "1",
                ngay = DateTime.Now.ToString(),
                sotien = 29000
            };
            var data2 = new History
            {
                email = "pentakillhy",
                loaive = "Luot",
                loaixe = "2",
                ngay = DateTime.Now.ToString(),
                sotien = 39000
            };
            var data3 = new History
            {
                email = "pentakillhy",
                loaive = "Luot",
                loaixe = "3",
                ngay = DateTime.Now.ToString(),
                sotien = 59000
            };
            List<History> history = new List<History>();
            history.Add(data1);
            history.Add(data2);
            history.Add(data3);
            foreach (var item in history)
            {
                var response = await client.PushAsync("Lichsu", item);
                Data result = response.ResultAs<Data>();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void getdata()
        {
            FirebaseResponse response = client.Get(@"Lichsu");
            Dictionary<string, History> data = JsonConvert.DeserializeObject<Dictionary<string, History>>(response.Body.ToString());
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("key", "Key");
            dataGridView1.Columns.Add("email", "Email");
            dataGridView1.Columns.Add("loaive", "Loại vé");
            dataGridView1.Columns.Add("loaixe", "Loại xe");
            dataGridView1.Columns.Add("ngay", "Ngày");
            dataGridView1.Columns.Add("sotien", "Số tiền");



            if (data != null)
            {
                foreach (var row in data)
                {

                    dataGridView1.Rows.Add(row.Key, row.Value.email, row.Value.loaive, row.Value.loaixe, row.Value.ngay, row.Value.sotien);
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtemail.Text = row.Cells[1].Value.ToString();
                txtloaive.Text = row.Cells[2].Value.ToString();
                txtloaixe.Text = row.Cells[3].Value.ToString();
                txtngay.Text = row.Cells[4].Value.ToString();
                txtsotien.Text = row.Cells[5].Value.ToString();

                key = row.Cells[0].Value.ToString();
            }
        }
    }
}
