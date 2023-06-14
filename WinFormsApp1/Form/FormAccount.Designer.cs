namespace WinFormsApp1
{
    partial class FormAccount
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
            button3 = new Button();
            button2 = new Button();
            txtquequan = new TextBox();
            txtday = new TextBox();
            txtsodu = new TextBox();
            txtmaubien = new TextBox();
            txtrfid = new TextBox();
            txtbienso = new TextBox();
            txtloaixe = new TextBox();
            txtemail = new TextBox();
            label9 = new Label();
            txtname = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtquequan);
            groupBox1.Controls.Add(txtday);
            groupBox1.Controls.Add(txtsodu);
            groupBox1.Controls.Add(txtmaubien);
            groupBox1.Controls.Add(txtrfid);
            groupBox1.Controls.Add(txtbienso);
            groupBox1.Controls.Add(txtloaixe);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1250, 558);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
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
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // button3
            // 
            button3.Location = new Point(412, 379);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 379);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtquequan
            // 
            txtquequan.Location = new Point(127, 185);
            txtquequan.Name = "txtquequan";
            txtquequan.Size = new Size(165, 27);
            txtquequan.TabIndex = 1;
            // 
            // txtday
            // 
            txtday.Location = new Point(127, 130);
            txtday.Name = "txtday";
            txtday.Size = new Size(165, 27);
            txtday.TabIndex = 1;
            // 
            // txtsodu
            // 
            txtsodu.Location = new Point(412, 239);
            txtsodu.Name = "txtsodu";
            txtsodu.Size = new Size(165, 27);
            txtsodu.TabIndex = 1;
            // 
            // txtmaubien
            // 
            txtmaubien.Location = new Point(412, 75);
            txtmaubien.Name = "txtmaubien";
            txtmaubien.Size = new Size(165, 27);
            txtmaubien.TabIndex = 1;
            // 
            // txtrfid
            // 
            txtrfid.Location = new Point(412, 185);
            txtrfid.Name = "txtrfid";
            txtrfid.Size = new Size(165, 27);
            txtrfid.TabIndex = 1;
            // 
            // txtbienso
            // 
            txtbienso.Location = new Point(127, 293);
            txtbienso.Name = "txtbienso";
            txtbienso.Size = new Size(165, 27);
            txtbienso.TabIndex = 1;
            // 
            // txtloaixe
            // 
            txtloaixe.Location = new Point(412, 130);
            txtloaixe.Name = "txtloaixe";
            txtloaixe.Size = new Size(165, 27);
            txtloaixe.TabIndex = 1;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(127, 235);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(165, 27);
            txtemail.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(301, 238);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 0;
            label9.Text = "Số dư";
            label9.Click += label6_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(127, 75);
            txtname.Name = "txtname";
            txtname.Size = new Size(165, 27);
            txtname.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 188);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 0;
            label8.Text = "RFID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 82);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 0;
            label6.Text = "Màu biển";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 293);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 0;
            label4.Text = "Biển số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 133);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "Ngày sinh";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(301, 133);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 0;
            label7.Text = "Loại xe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 188);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 0;
            label5.Text = "Quên quán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 242);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 0;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 78);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            label1.Click += label1_Click;
            // 
            // FormAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 558);
            Controls.Add(groupBox1);
            Name = "FormAccount";
            Text = "FormAccount";
            Load += FormAccount_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtquequan;
        private TextBox txtday;
        private TextBox txtname;
        private TextBox txtmaubien;
        private TextBox txtbienso;
        private TextBox txtemail;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private TextBox txtsodu;
        private TextBox txtrfid;
        private TextBox txtloaixe;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}