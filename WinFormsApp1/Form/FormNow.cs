using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Response;

using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class FormNow : Form
    {
        String previous = "";
        String bienso;
        private SerialPort serialPort1;
        FirebaseClient client;
        int check;
        Dictionary<string, User> users;
        Dictionary<string, Goi> packes;
        Dictionary<string, Loaigoi> typpackages;
        List<Goi> listgoi = new List<Goi>();
        List<Loaigoi> listloaigoi = new List<Loaigoi>();
        int giaveluot;
        string loaive;

        public FormNow(FirebaseClient client)
        {
            InitializeComponent();
            this.client = client;
            get_all_data();
            get_all_package();
            get_all_loaigoi();

        }

        private void FormNow_Load(object sender, EventArgs e)
        {
            //String id = "5046421A";
            //getdata(id);

            serialPort1 = new SerialPort();
            serialPort1.PortName = "COM5"; // Thay đổi PortName tương ứng với cổng Serial kết nối với Arduino
            serialPort1.BaudRate = 9600; // Thay đổi BaudRate tương ứng với tốc độ baud của kết nối Serial
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();

            }
            try
            {
                serialPort1.Open(); // Mở kết nối Serial
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tồn tại cổng");
            }


        }



        private void getdata(String id)
        {

            User user;
            int check = 0;
            foreach (KeyValuePair<String, User> pair in users)
            {
                user = pair.Value;
                String key = pair.Key;
                if (user.rfid == id)
                {

                    txtten.Text = user.ten;
                    txtbienso.Text = user.bienso;
                    txtemail.Text = user.email;

                    txtngaysinh.Text = user.ngaysinh;
                    txtrfid.Text = user.rfid;

                    txtquequan.Text = user.quequan;
                    txtloaixe.Text = user.loaixe.ToString();
                    if (get_package(user.email))
                    {
                        bienso = user.bienso;
                        History history = new History();
                        history.email = user.email;
                        history.sotien = 0;
                        history.ngay = DateTime.Now.ToString("dd/MM/yyyy");
                        history.loaixe = user.loaixe;
                        history.loaive = loaive;
                        add_history(history);
                        return;

                    }
                    else
                    {

                        get_veluot(user.loaixe);
                        int soduhientai = user.sodu - giaveluot;
                        if (soduhientai > 0)
                        {

                            users[key].sodu = soduhientai;
                            soduhientai = users[key].sodu;
                            update_sodu(key, users[key]);
                            History history = new History();
                            history.email = user.email;
                            history.sotien = 29000;
                            history.ngay = DateTime.Now.ToString("dd/MM/yyyy");
                            history.loaixe = user.loaixe;
                            history.loaive = "Luot";
                            bienso = user.bienso;
                            add_history(history);
                            return;
                        }



                    }

                }

            }
            check = 0;
            return;
            //if (check == 1)
            //{
            //    return 1;
            //}
            //return 0;



        }
        private async void get_all_data()
        {

            var response = await client.GetAsync("users");
            users = response.ResultAs<Dictionary<string, User>>();
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // ??c d? li?u t? Serial Port và hi?n th? lên TextBox

            string data = serialPort1.ReadLine();

            data = data.TrimEnd('\r');

            Invoke(new Action(() =>
            {
                //int result = getdata(data);
                //if (result == 1)
                //{
                //    serialPort1.Write(bienso);

                //}
                //else
                //    serialPort1.Write("false");
                getdata(data);
                if (check == 1)
                    serialPort1.Write(bienso);
                else serialPort1.Write("false");

            }));


        }
        private async void get_all_package()
        {
            DateTime now = DateTime.Now.ToUniversalTime();
            long timestamp = now.Ticks;

            var response = await client.GetAsync("Goi", queryBuilder: QueryBuilder.New().OrderBy("trangthai").StartAt("true"));

            packes = response.ResultAs<Dictionary<string, Goi>>();
            foreach (KeyValuePair<String, Goi> pair in packes)
            {
                Goi goi = pair.Value;

                if (goi.ngayketthuc >= timestamp)
                {
                    goi.trangthai = "false";
                    update_package(pair.Key, goi);

                }
                else listgoi.Add(goi);
            }



        }
        private bool get_package(String email)
        {
            foreach (Goi goi in listgoi)
            {
                if (goi.email.Equals(email))
                {
                    loaive = goi.loaive;
                    return true;
                }

            }
            return false;

        }

        private async void update_package(String key, Goi data)
        {
            var response = await client.UpdateAsync("Goi/" + key, data);
            Data result = response.ResultAs<Data>();
        }


        private async void get_all_loaigoi()
        {

            var response = await client.GetAsync("Loaigoi");
            typpackages = response.ResultAs<Dictionary<string, Loaigoi>>();
            foreach (KeyValuePair<String, Loaigoi> pair in typpackages)
            {
                Loaigoi loaigoi = pair.Value;
                listloaigoi.Add(loaigoi);

            }

        }
        private void get_veluot(String loaixe)
        {
            foreach (Loaigoi loaigoi in listloaigoi)
            {
                if (loaigoi.loaixe.Equals(loaixe) && loaigoi.loaive.Equals("Luot"))
                {
                    giaveluot = loaigoi.gia;
                }
            }
        }

        private async void update_sodu(String key, User data)
        {
            var response = await client.UpdateAsync("users/" + key, data);
            Data result = response.ResultAs<Data>();

        }



        private async void add_history(History data)
        {


            //var response = await client.PushAsync("Lichsu", data);
            //Data result = response.ResultAs<Data>();

            try
            {
                var response = await client.PushAsync("Lichsu", data);
                check = 1;

            }
            catch (Exception ex)
            {
                check = 0;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
