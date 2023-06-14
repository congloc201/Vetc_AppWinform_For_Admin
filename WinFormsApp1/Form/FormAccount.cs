using FireSharp;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{

    public partial class FormAccount : Form
    {

        FirebaseClient client;
        String key;
        public FormAccount(FirebaseClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormAccount_Load(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var data = new Data
            {
                ten = txtname.Text,
                quequan = txtquequan.Text,
                ngaysinh = txtday.Text,
                bienso = txtbienso.Text,
                email = txtemail.Text,
                maubien = txtmaubien.Text,
                sodu = int.Parse(txtsodu.Text),
                loaixe = txtloaixe.Text,
                rfid = txtrfid.Text,

            };
            var response = await client.PushAsync("users", data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data Inserted");
            getdata();
        }

        private void FormAccount_Load_1(object sender, EventArgs e)
        {
            getdata();
        }


        private void getdata()
        {
            FirebaseResponse response = client.Get(@"users");
            Dictionary<string, Data> data = JsonConvert.DeserializeObject<Dictionary<string, Data>>(response.Body.ToString());
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("key", "Key");
            dataGridView1.Columns.Add("ten", "Tên");
            dataGridView1.Columns.Add("quequan", "Quê Quán");
            dataGridView1.Columns.Add("ngaysinh", "Ngày sinh");
            dataGridView1.Columns.Add("email", "Email");
            dataGridView1.Columns.Add("bienso", "Biển số");
            dataGridView1.Columns.Add("maubien", "Màu biển");
            dataGridView1.Columns.Add("rfid", "RFID");
            dataGridView1.Columns.Add("loaixe", "Loại xe");
            dataGridView1.Columns.Add("sodu", "Số dư");



            if (data != null)
            {
                foreach (var row in data)
                {
                    dataGridView1.Rows.Add(row.Key, row.Value.ten, row.Value.quequan, row.Value.ngaysinh, row.Value.email, row.Value.bienso, row.Value.maubien, row.Value.rfid, row.Value.loaixe, row.Value.sodu);
                }

            }

        }




        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtquequan.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtday.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtemail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtbienso.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtmaubien.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                bool check1, check2;
                check1 = dataGridView1.CurrentRow.Cells[7].Value != null;
                check2 = dataGridView1.CurrentRow.Cells[8].Value != null;
                if (check1)
                {
                    txtrfid.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                }
                else txtrfid.Text = "0";
                if (check2)
                {
                    txtloaixe.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                }
                else txtloaixe.Text = "0";



                txtsodu.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                key = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                ten = txtname.Text,
                quequan = txtquequan.Text,
                ngaysinh = txtday.Text,
                bienso = txtbienso.Text,
                email = txtemail.Text,
                maubien = txtmaubien.Text,
                sodu = int.Parse(txtsodu.Text),
                loaixe = txtloaixe.Text,
                rfid = txtrfid.Text,
            };

            FirebaseResponse response = await client.UpdateAsync("users/" + key, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Update Successfull");
            getdata();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("users/" + key);

            MessageBox.Show("Delete Successfull");
            getdata();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtname.Text = row.Cells[1].Value.ToString();

                txtquequan.Text = row.Cells[2].Value.ToString();
                txtday.Text = row.Cells[3].Value.ToString();
                txtemail.Text = row.Cells[4].Value.ToString();
                txtbienso.Text = row.Cells[5].Value.ToString();
                txtmaubien.Text = row.Cells[6].Value.ToString();
                bool check1, check2;
                check1 = dataGridView1.CurrentRow.Cells[7].Value != null;
                check2 = dataGridView1.CurrentRow.Cells[8].Value != null;
                if (check1)
                {
                    txtrfid.Text = row.Cells[7].Value.ToString();
                }
                else txtrfid.Text = "0";
                if (check2)
                {
                    txtloaixe.Text = row.Cells[8].Value.ToString();
                }
                else txtloaixe.Text = "0";
            }

        }
    }


}
