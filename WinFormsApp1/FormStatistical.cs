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

using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Legends;
using System.Collections.ObjectModel;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class FormStatistical : Form
    {
        FirebaseClient client;
        Dictionary<string, History> data;
        List<History> historys = new List<History>();
        int sum_1, sum_2, sum_3, sum_4;
        int sum_car1 = 0, sum_car2 = 0, sum_car3 = 0, sum_car4 = 0;
        public FormStatistical(FirebaseClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void FormStatistical_Load(object sender, EventArgs e)
        {
            get_all_data();

        }

        public static PlotModel BindingItemsSource1(int sum_1, int sum_2, int sum_3, int sum_4)
        {
            var items = new Collection<Item>
                            {
                             new Item { Label = "Loại 1", Value1 = sum_1 },
                                new Item { Label = "Loại 2", Value1 = sum_2 },
                                new Item { Label = "Loại 3", Value1 = sum_3 },
                                new Item { Label = "Loại 4", Value1 = sum_4}
                            };

            var plotModel1 = new PlotModel { Title = "Doanh số" };
            var l = new Legend
            {
                LegendPlacement = LegendPlacement.Outside
            };

            plotModel1.Legends.Add(l);

            var categoryAxis1 = new CategoryAxis { Position = AxisPosition.Left, LabelField = "Label", ItemsSource = items, MajorStep = 1, MinorStep = 1 };
            plotModel1.Axes.Add(categoryAxis1);
            var linearAxis1 = new LinearAxis { Position = AxisPosition.Bottom, AbsoluteMinimum = 0, MinimumPadding = 0 };
            plotModel1.Axes.Add(linearAxis1);
            var series1 = new BarSeries
            {
                FillColor = OxyColor.FromArgb(255, 78, 154, 6),
                ValueField = "Value1",
                Title = "Số tiền",
                ItemsSource = items
            };
            plotModel1.Series.Add(series1);

            return plotModel1;
        }




        private async void get_all_data()
        {

            FirebaseResponse response = client.Get(@"Lichsu");
            data = JsonConvert.DeserializeObject<Dictionary<string, History>>(response.Body.ToString());
            //foreach (KeyValuePair<string, History> kvp in data)
            //{
            //    string key = kvp.Key;
            //    History value = kvp.Value;
            //    // hiển thị giá trị của key và value trong TextBox
            //    historys.Add(value);
            //}
        }
        private void setupchart()
        {


        }
        private void get_sum(DateTime startday, DateTime endday)
        {
            sum_1 = 0;
            sum_2 = 0;
            sum_3 = 0;
            sum_4 = 0;
            sum_car1 = 0;   
            sum_car2 = 0;
            sum_car3 = 0;
            sum_car4 = 0;
            foreach (KeyValuePair<string, History> kvp in data)
            {
                string key = kvp.Key;
                History value = kvp.Value;
                var date = DateTime.Parse(value.ngay);
                var result1 = date.CompareTo(startday);
                var result2 = date.CompareTo(endday);
                if (result1 > 0 && result2 < 0)
                {
                    switch (value.loaixe)
                    {
                        case "1":
                            sum_1 += value.sotien;
                            sum_car1 += 1;
                            break;
                        case "2":
                            sum_2 += value.sotien;
                            sum_car2 += 1;
                            break;
                        case "3":
                            sum_3 += value.sotien;
                            sum_car3 +=1;
                            break;
                        case "4":
                            sum_4 += value.sotien;
                            sum_car4 += 1;
                            break;

                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //String thang = comboBox1.SelectedItem.ToString();
            //String nam = comboBox2.SelectedItem.ToString();
            var start_day = dateTimePicker1.Value;
            var end_day = dateTimePicker2.Value;
            get_sum(start_day, end_day);

            plotView1.Model = BindingItemsSource1(sum_1, sum_2, sum_3, sum_4);
            plotView2.Model = piemodel(sum_1, sum_2, sum_3, sum_4);

        }

        private PlotModel piemodel(int sum_1, int sum_2, int sum_3, int sum_4)
        {
            // Tạo một đối tượng PlotModel
            var plotModel = new PlotModel { Title = "Tỉ lệ" };

            // Tạo một đối tượng PieSeries và thiết lập giá trị dữ liệu và màu sắc cho từng phần tử
            var pieSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0,
                InnerDiameter = 0.7,
                Diameter = 1.0
            };
            pieSeries.Slices.Add(new PieSlice("Loại 1", sum_1) { IsExploded = true, Fill = OxyColor.Parse("#ff0000") });
            pieSeries.Slices.Add(new PieSlice("Loại 2", sum_2) { Fill = OxyColor.Parse("#00ff00") });
            pieSeries.Slices.Add(new PieSlice("Loại 3", sum_3) { Fill = OxyColor.Parse("#0000ff") });
            pieSeries.Slices.Add(new PieSlice("Loại 4", sum_4) { Fill = OxyColor.Parse("#ffff00") });
            plotModel.Series.Add(pieSeries);

            // Thiết lập PlotView.Model bằng đối tượng PlotModel
            return plotModel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var start_day = dateTimePicker1.Value;
            var end_day = dateTimePicker2.Value;
            get_sum(start_day, end_day);

            plotView1.Model = BindingItemsSource1(sum_car1, sum_car2, sum_car3, sum_car4);
            plotView2.Model = piemodel(sum_car1, sum_car2, sum_car3, sum_car4);
        }
    }
}
