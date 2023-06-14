namespace WinFormsApp1
{
    partial class FormHistory
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtloaixe = new TextBox();
            txtemail = new TextBox();
            txtloaive = new TextBox();
            txtsotien = new TextBox();
            txtngay = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtloaixe);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtloaive);
            groupBox1.Controls.Add(txtsotien);
            groupBox1.Controls.Add(txtngay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1339, 505);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(640, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(604, 497);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtloaixe
            // 
            txtloaixe.Location = new Point(127, 185);
            txtloaixe.Name = "txtloaixe";
            txtloaixe.ReadOnly = true;
            txtloaixe.Size = new Size(165, 27);
            txtloaixe.TabIndex = 1;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(127, 79);
            txtemail.Name = "txtemail";
            txtemail.ReadOnly = true;
            txtemail.Size = new Size(165, 27);
            txtemail.TabIndex = 1;
            // 
            // txtloaive
            // 
            txtloaive.Location = new Point(127, 130);
            txtloaive.Name = "txtloaive";
            txtloaive.ReadOnly = true;
            txtloaive.Size = new Size(165, 27);
            txtloaive.TabIndex = 1;
            // 
            // txtsotien
            // 
            txtsotien.Location = new Point(412, 130);
            txtsotien.Name = "txtsotien";
            txtsotien.ReadOnly = true;
            txtsotien.Size = new Size(165, 27);
            txtsotien.TabIndex = 1;
            // 
            // txtngay
            // 
            txtngay.Location = new Point(412, 71);
            txtngay.Name = "txtngay";
            txtngay.ReadOnly = true;
            txtngay.Size = new Size(165, 27);
            txtngay.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 133);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "Loại vé";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(301, 133);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 0;
            label7.Text = "Số tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 188);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 0;
            label5.Text = "Loại xe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 78);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 0;
            label3.Text = "Ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 78);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 505);
            Controls.Add(groupBox1);
            Name = "FormHistory";
            Text = "FormHistory";
            Load += FormHistory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtloaixe;
        private TextBox txtloaive;
        private TextBox txtsotien;
        private TextBox txtngay;
        private Label label2;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtemail;
    }
}