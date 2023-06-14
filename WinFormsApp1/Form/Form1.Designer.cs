namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btn_statistical = new Button();
            btn_history = new Button();
            btn_ticket = new Button();
            btn_account = new Button();
            btn_now = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            lbl_title = new Label();
            pancontent = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btn_statistical);
            panel1.Controls.Add(btn_history);
            panel1.Controls.Add(btn_ticket);
            panel1.Controls.Add(btn_account);
            panel1.Controls.Add(btn_now);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 681);
            panel1.TabIndex = 0;
            // 
            // btn_statistical
            // 
            btn_statistical.Dock = DockStyle.Top;
            btn_statistical.FlatAppearance.BorderSize = 0;
            btn_statistical.FlatStyle = FlatStyle.Flat;
            btn_statistical.ForeColor = SystemColors.ButtonHighlight;
            btn_statistical.Image = (Image)resources.GetObject("btn_statistical.Image");
            btn_statistical.ImageAlign = ContentAlignment.MiddleLeft;
            btn_statistical.Location = new Point(0, 361);
            btn_statistical.Name = "btn_statistical";
            btn_statistical.Size = new Size(248, 59);
            btn_statistical.TabIndex = 5;
            btn_statistical.Text = "Thống kê";
            btn_statistical.UseVisualStyleBackColor = true;
            btn_statistical.Click += btn_statistical_Click;
            // 
            // btn_history
            // 
            btn_history.Dock = DockStyle.Top;
            btn_history.FlatAppearance.BorderSize = 0;
            btn_history.FlatStyle = FlatStyle.Flat;
            btn_history.ForeColor = SystemColors.ButtonHighlight;
            btn_history.Image = (Image)resources.GetObject("btn_history.Image");
            btn_history.ImageAlign = ContentAlignment.MiddleLeft;
            btn_history.Location = new Point(0, 302);
            btn_history.Name = "btn_history";
            btn_history.Size = new Size(248, 59);
            btn_history.TabIndex = 4;
            btn_history.Text = "Lịch sử";
            btn_history.UseVisualStyleBackColor = true;
            btn_history.Click += btn_history_Click;
            // 
            // btn_ticket
            // 
            btn_ticket.Dock = DockStyle.Top;
            btn_ticket.FlatAppearance.BorderSize = 0;
            btn_ticket.FlatStyle = FlatStyle.Flat;
            btn_ticket.ForeColor = SystemColors.ButtonHighlight;
            btn_ticket.Image = (Image)resources.GetObject("btn_ticket.Image");
            btn_ticket.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ticket.Location = new Point(0, 243);
            btn_ticket.Name = "btn_ticket";
            btn_ticket.Size = new Size(248, 59);
            btn_ticket.TabIndex = 3;
            btn_ticket.Text = "Vé";
            btn_ticket.UseVisualStyleBackColor = true;
            btn_ticket.Click += button3_Click;
            // 
            // btn_account
            // 
            btn_account.Dock = DockStyle.Top;
            btn_account.FlatAppearance.BorderSize = 0;
            btn_account.FlatStyle = FlatStyle.Flat;
            btn_account.ForeColor = SystemColors.ButtonHighlight;
            btn_account.Image = (Image)resources.GetObject("btn_account.Image");
            btn_account.ImageAlign = ContentAlignment.MiddleLeft;
            btn_account.Location = new Point(0, 184);
            btn_account.Name = "btn_account";
            btn_account.Size = new Size(248, 59);
            btn_account.TabIndex = 2;
            btn_account.Text = "Tài khoản";
            btn_account.UseVisualStyleBackColor = true;
            btn_account.Click += button2_Click;
            // 
            // btn_now
            // 
            btn_now.Dock = DockStyle.Top;
            btn_now.FlatAppearance.BorderSize = 0;
            btn_now.FlatStyle = FlatStyle.Flat;
            btn_now.ForeColor = SystemColors.ButtonHighlight;
            btn_now.Image = (Image)resources.GetObject("btn_now.Image");
            btn_now.ImageAlign = ContentAlignment.MiddleLeft;
            btn_now.Location = new Point(0, 125);
            btn_now.Name = "btn_now";
            btn_now.Size = new Size(248, 59);
            btn_now.TabIndex = 1;
            btn_now.Text = "Hiện tại";
            btn_now.UseVisualStyleBackColor = true;
            btn_now.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 125);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(84, 43);
            label1.Name = "label1";
            label1.Size = new Size(75, 35);
            label1.TabIndex = 0;
            label1.Text = "VETC";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(lbl_title);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(248, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1199, 125);
            panel3.TabIndex = 1;
            // 
            // lbl_title
            // 
            lbl_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.ForeColor = SystemColors.ButtonHighlight;
            lbl_title.Location = new Point(554, 35);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(107, 46);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "NOW";
            // 
            // pancontent
            // 
            pancontent.Dock = DockStyle.Fill;
            pancontent.Location = new Point(248, 125);
            pancontent.Name = "pancontent";
            pancontent.Size = new Size(1199, 556);
            pancontent.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 681);
            Controls.Add(pancontent);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_now;
        private Panel panel2;
        private Label label1;
        private Button btn_statistical;
        private Button btn_history;
        private Button btn_ticket;
        private Button btn_account;
        private Panel panel3;
        private Label lbl_title;
        private Panel pancontent;
    }
}