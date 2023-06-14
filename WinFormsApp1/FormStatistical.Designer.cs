namespace WinFormsApp1
{
    partial class FormStatistical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            button2 = new Button();
            SuspendLayout();
            // 
            // plotView1
            // 
            plotView1.Location = new Point(41, 156);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(650, 419);
            plotView1.TabIndex = 2;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // button1
            // 
            button1.Location = new Point(865, 49);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 3;
            button1.Text = "Thống kê doanh số";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(133, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 6;
            label1.Text = "Ngày bắt đầu";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(545, 47);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 51);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 6;
            label2.Text = "Ngày kết thúc";
            // 
            // plotView2
            // 
            plotView2.Location = new Point(781, 156);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(471, 372);
            plotView2.TabIndex = 7;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // button2
            // 
            button2.Location = new Point(1048, 49);
            button2.Name = "button2";
            button2.Size = new Size(146, 29);
            button2.TabIndex = 8;
            button2.Text = "Thống kê lưu lượng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormStatistical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 629);
            Controls.Add(button2);
            Controls.Add(plotView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(plotView1);
            Name = "FormStatistical";
            Text = "FormStatistical";
            Load += FormStatistical_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private Button button2;
    }
}