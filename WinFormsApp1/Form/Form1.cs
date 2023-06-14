using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.IO.Ports;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mEjtR6QJwYz73ijH6FwvJEdZxrDvlUMj5lqZE5fV",
            BasePath = "https://auto-etc-e3850-default-rtdb.firebaseio.com/"


        };
        FirebaseClient client;
        public Form1()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("OK");
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            FormNow frmm = new FormNow(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmm.FormBorderStyle = FormBorderStyle.None;
            this.pancontent.Controls.Add(frmm);
            frmm.Show();

        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ?óng Serial Port khi ?ng d?ng b? ?óng
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            FormAccount frmm = new FormAccount(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmm.FormBorderStyle = FormBorderStyle.None;
            this.pancontent.Controls.Clear();
            this.pancontent.Controls.Add(frmm);
            frmm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl_title.Text = "NOW";
            FormNow frmm = new FormNow(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmm.FormBorderStyle = FormBorderStyle.None;
            this.pancontent.Controls.Clear();
            this.pancontent.Controls.Add(frmm);
            frmm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "Tài khoản";
            FormAccount frmm = new FormAccount(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmm.FormBorderStyle = FormBorderStyle.None;
            this.pancontent.Controls.Clear();
            this.pancontent.Controls.Add(frmm);
            frmm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "Vé";
            FormTicket frmm = new FormTicket(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmm.FormBorderStyle = FormBorderStyle.None;
            this.pancontent.Controls.Clear();
            this.pancontent.Controls.Add(frmm);
            frmm.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "Lịch sử";
            FormHistory frmm = new FormHistory(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmm.FormBorderStyle = FormBorderStyle.None;
            this.pancontent.Controls.Clear();
            this.pancontent.Controls.Add(frmm);
            frmm.Show();
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "Thống kê";
            FormStatistical frmm = new FormStatistical(client) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmm.FormBorderStyle = FormBorderStyle.None;
            this.pancontent.Controls.Clear();
            this.pancontent.Controls.Add(frmm);
            frmm.Show();
        }
    }
}