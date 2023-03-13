namespace lsp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            TitleLabel = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            OpenNilai = new Button();
            OpenSiswa = new Button();
            OpenMapel = new Button();
            OpenGuru = new Button();
            MainContentPanel = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            MainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 241, 214);
            panel1.Controls.Add(TitleLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 50);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            TitleLabel.Location = new Point(235, 12);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(246, 28);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Pendatatan SMK N1 Bangil";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(96, 153, 102);
            panel2.Controls.Add(OpenNilai);
            panel2.Controls.Add(OpenSiswa);
            panel2.Controls.Add(OpenMapel);
            panel2.Controls.Add(OpenGuru);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 461);
            panel2.TabIndex = 2;
            // 
            // OpenNilai
            // 
            OpenNilai.BackColor = Color.FromArgb(237, 241, 214);
            OpenNilai.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Pixel);
            OpenNilai.Location = new Point(32, 173);
            OpenNilai.Name = "OpenNilai";
            OpenNilai.Size = new Size(138, 30);
            OpenNilai.TabIndex = 3;
            OpenNilai.Text = "Nilai";
            OpenNilai.UseVisualStyleBackColor = false;
            OpenNilai.Click += OpenNilai_Click;
            // 
            // OpenSiswa
            // 
            OpenSiswa.BackColor = Color.FromArgb(237, 241, 214);
            OpenSiswa.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Pixel);
            OpenSiswa.Location = new Point(32, 127);
            OpenSiswa.Name = "OpenSiswa";
            OpenSiswa.Size = new Size(138, 30);
            OpenSiswa.TabIndex = 2;
            OpenSiswa.Text = "Siswa";
            OpenSiswa.UseVisualStyleBackColor = false;
            OpenSiswa.Click += OpenSiswa_Click;
            // 
            // OpenMapel
            // 
            OpenMapel.BackColor = Color.FromArgb(237, 241, 214);
            OpenMapel.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Pixel);
            OpenMapel.Location = new Point(32, 78);
            OpenMapel.Name = "OpenMapel";
            OpenMapel.Size = new Size(138, 30);
            OpenMapel.TabIndex = 1;
            OpenMapel.Text = "Mapel";
            OpenMapel.UseVisualStyleBackColor = false;
            OpenMapel.Click += OpenMapel_Click;
            // 
            // OpenGuru
            // 
            OpenGuru.BackColor = Color.FromArgb(237, 241, 214);
            OpenGuru.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Pixel);
            OpenGuru.Location = new Point(32, 33);
            OpenGuru.Name = "OpenGuru";
            OpenGuru.Size = new Size(138, 30);
            OpenGuru.TabIndex = 0;
            OpenGuru.Text = "Guru";
            OpenGuru.UseVisualStyleBackColor = false;
            OpenGuru.Click += OpenGuru_Click;
            // 
            // MainContentPanel
            // 
            MainContentPanel.AutoSize = true;
            MainContentPanel.Controls.Add(pictureBox2);
            MainContentPanel.Dock = DockStyle.Fill;
            MainContentPanel.Location = new Point(200, 50);
            MainContentPanel.Name = "MainContentPanel";
            MainContentPanel.Size = new Size(784, 461);
            MainContentPanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(784, 461);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(984, 511);
            Controls.Add(MainContentPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 550);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Dashboard";
            ShowIcon = false;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            MainContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label TitleLabel;
        private Button OpenGuru;
        private Panel MainContentPanel;
        private PictureBox pictureBox2;
        private Button OpenMapel;
        private Button OpenSiswa;
        private Button OpenNilai;
    }
}