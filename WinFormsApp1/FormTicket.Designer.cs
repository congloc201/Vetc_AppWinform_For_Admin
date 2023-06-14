namespace WinFormsApp1
{
    partial class FormTicket
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
            txtgia = new TextBox();
            label3 = new Label();
            txtloaixe = new TextBox();
            label2 = new Label();
            txtloaive = new TextBox();
            label1 = new Label();
            btn_update = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtgia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtloaixe);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtloaive);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1353, 575);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(409, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(565, 515);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtgia
            // 
            txtgia.Location = new Point(147, 188);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(165, 27);
            txtgia.TabIndex = 7;
            txtgia.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 191);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 6;
            label3.Text = "Giá";
            // 
            // txtloaixe
            // 
            txtloaixe.Location = new Point(147, 124);
            txtloaixe.Name = "txtloaixe";
            txtloaixe.ReadOnly = true;
            txtloaixe.Size = new Size(165, 27);
            txtloaixe.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 127);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "Loại xe";
            // 
            // txtloaive
            // 
            txtloaive.Location = new Point(147, 59);
            txtloaive.Name = "txtloaive";
            txtloaive.ReadOnly = true;
            txtloaive.Size = new Size(165, 27);
            txtloaive.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 61);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Loại vé";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(162, 279);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 575);
            Controls.Add(groupBox1);
            Name = "FormTicket";
            Text = "FormTicket";
            Load += FormTicket_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtgia;
        private Label label3;
        private TextBox txtloaixe;
        private Label label2;
        private TextBox txtloaive;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_update;
    }
}