using FireSharp;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class FormTicket : Form
    {
        FirebaseClient client;
        String key;
        public FormTicket(FirebaseClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void getdata()
        {
            FirebaseResponse response = client.Get(@"Loaigoi");
            Dictionary<string, Loaigoi> data = JsonConvert.DeserializeObject<Dictionary<string, Loaigoi>>(response.Body.ToString());
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("key", "Key");
            dataGridView1.Columns.Add("loaive", "Loại vé");
            dataGridView1.Columns.Add("loaixe", "Loại xe");
            dataGridView1.Columns.Add("gia", "Giá");
            if (data != null)
            {
                foreach (var row in data)
                {
                    dataGridView1.Rows.Add(row.Key, row.Value.loaive, row.Value.loaixe, row.Value.gia);
                }

            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, loại bỏ ký tự đó
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtloaive.Text = row.Cells[1].Value.ToString();
                txtloaixe.Text = row.Cells[2].Value.ToString();
                txtgia.Text = row.Cells[3].Value.ToString();
                key = row.Cells[0].Value.ToString();
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            var loaigoi = new Loaigoi
            {
                loaive = txtloaive.Text,
                gia = int.Parse(txtgia.Text),
                loaixe = txtloaixe.Text,
                
            };

            FirebaseResponse response = await client.UpdateAsync("Loaigoi/" + key, loaigoi);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Update Successfull");
            getdata();
        }
    }
}