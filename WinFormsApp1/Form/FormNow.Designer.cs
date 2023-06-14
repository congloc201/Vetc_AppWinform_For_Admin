namespace WinFormsApp1
{
    partial class FormNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNow));
            txtten = new TextBox();
            txtemail = new TextBox();
            txtbienso = new TextBox();
            txtloaixe = new TextBox();
            txtquequan = new TextBox();
            txtngaysinh = new TextBox();
            txtrfid = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtten
            // 
            txtten.BackColor = SystemColors.Control;
            txtten.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtten.ForeColor = SystemColors.InfoText;
            txtten.Location = new Point(254, 51);
            txtten.Name = "txtten";
            txtten.ReadOnly = true;
            txtten.Size = new Size(204, 52);
            txtten.TabIndex = 0;
            txtten.TextChanged += txtten_TextChanged;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(254, 163);
            txtemail.Name = "txtemail";
            txtemail.ReadOnly = true;
            txtemail.Size = new Size(204, 52);
            txtemail.TabIndex = 0;
            // 
            // txtbienso
            // 
            txtbienso.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtbienso.Location = new Point(254, 269);
            txtbienso.Name = "txtbienso";
            txtbienso.ReadOnly = true;
            txtbienso.Size = new Size(204, 52);
            txtbienso.TabIndex = 0;
            // 
            // txtloaixe
            // 
            txtloaixe.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtloaixe.Location = new Point(670, 157);
            txtloaixe.Name = "txtloaixe";
            txtloaixe.ReadOnly = true;
            txtloaixe.Size = new Size(204, 52);
            txtloaixe.TabIndex = 1;
            // 
            // txtquequan
            // 
            txtquequan.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtquequan.Location = new Point(254, 369);
            txtquequan.Name = "txtquequan";
            txtquequan.ReadOnly = true;
            txtquequan.Size = new Size(204, 52);
            txtquequan.TabIndex = 2;
            // 
            // txtngaysinh
            // 
            txtngaysinh.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtngaysinh.Location = new Point(670, 52);
            txtngaysinh.Name = "txtngaysinh";
            txtngaysinh.ReadOnly = true;
            txtngaysinh.Size = new Size(204, 52);
            txtngaysinh.TabIndex = 3;
            // 
            // txtrfid
            // 
            txtrfid.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtrfid.Location = new Point(670, 269);
            txtrfid.Name = "txtrfid";
            txtrfid.ReadOnly = true;
            txtrfid.Size = new Size(204, 52);
            txtrfid.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtngaysinh);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(txtrfid);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtbienso);
            groupBox1.Controls.Add(txtloaixe);
            groupBox1.Controls.Add(txtquequan);
            groupBox1.Location = new Point(39, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1050, 475);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(576, 52);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(74, 53);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(160, 368);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(74, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(160, 268);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(74, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(576, 157);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(576, 270);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(160, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormNow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 556);
            Controls.Add(groupBox1);
            Name = "FormNow";
            Text = "FormNow";
            Load += FormNow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtten;
        private TextBox txtemail;
        private TextBox txtbienso;
        private TextBox txtloaixe;
        private TextBox txtquequan;
        private TextBox txtngaysinh;
        private TextBox txtrfid;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}