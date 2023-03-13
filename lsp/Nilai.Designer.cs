namespace lsp
{
    partial class Nilai
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
            DataGridViewNilai = new DataGridView();
            IdSiswa = new DataGridViewTextBoxColumn();
            IdNilai = new DataGridViewTextBoxColumn();
            IdMapel = new DataGridViewTextBoxColumn();
            IdGuru = new DataGridViewTextBoxColumn();
            SiswaName = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            MapelName = new DataGridViewTextBoxColumn();
            GuruName = new DataGridViewTextBoxColumn();
            ActionReset = new Button();
            InputSearch = new TextBox();
            InputSearchLabel = new Label();
            ActionUpdate = new Button();
            ActionDelete = new Button();
            ActionCancel = new Button();
            ActionInsert = new Button();
            InputSiswa = new ComboBox();
            InputSiswaError = new Label();
            InputSiswaLabel = new Label();
            InputMapel = new ComboBox();
            InputMapelError = new Label();
            InputMapelLabel = new Label();
            InputNilaiLabel = new Label();
            InputNilai = new TextBox();
            InputNilaiError = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewNilai).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewNilai
            // 
            DataGridViewNilai.AllowUserToAddRows = false;
            DataGridViewNilai.AllowUserToDeleteRows = false;
            DataGridViewNilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewNilai.Columns.AddRange(new DataGridViewColumn[] { IdSiswa, IdNilai, IdMapel, IdGuru, SiswaName, dataGridViewTextBoxColumn1, MapelName, GuruName });
            DataGridViewNilai.Location = new Point(0, 311);
            DataGridViewNilai.Margin = new Padding(10);
            DataGridViewNilai.Name = "DataGridViewNilai";
            DataGridViewNilai.RowTemplate.Height = 25;
            DataGridViewNilai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewNilai.Size = new Size(784, 150);
            DataGridViewNilai.TabIndex = 1;
            DataGridViewNilai.CellDoubleClick += DataGridViewNilai_CellDoubleClick;
            // 
            // IdSiswa
            // 
            IdSiswa.HeaderText = "IdSiswa";
            IdSiswa.Name = "IdSiswa";
            IdSiswa.ReadOnly = true;
            IdSiswa.Visible = false;
            // 
            // IdNilai
            // 
            IdNilai.HeaderText = "IdNilai";
            IdNilai.Name = "IdNilai";
            IdNilai.ReadOnly = true;
            IdNilai.Visible = false;
            // 
            // IdMapel
            // 
            IdMapel.HeaderText = "IdMapel";
            IdMapel.Name = "IdMapel";
            IdMapel.ReadOnly = true;
            IdMapel.Visible = false;
            // 
            // IdGuru
            // 
            IdGuru.HeaderText = "IdGuru";
            IdGuru.Name = "IdGuru";
            IdGuru.ReadOnly = true;
            IdGuru.Visible = false;
            // 
            // SiswaName
            // 
            SiswaName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SiswaName.HeaderText = "Nama Siswa";
            SiswaName.Name = "SiswaName";
            SiswaName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Nilai";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MapelName
            // 
            MapelName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MapelName.HeaderText = "Nama Mapel";
            MapelName.Name = "MapelName";
            MapelName.ReadOnly = true;
            // 
            // GuruName
            // 
            GuruName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GuruName.HeaderText = "Nama Guru";
            GuruName.Name = "GuruName";
            GuruName.ReadOnly = true;
            // 
            // ActionReset
            // 
            ActionReset.BackColor = Color.Red;
            ActionReset.ForeColor = Color.White;
            ActionReset.Location = new Point(625, 275);
            ActionReset.Name = "ActionReset";
            ActionReset.Size = new Size(30, 23);
            ActionReset.TabIndex = 34;
            ActionReset.Text = "X";
            ActionReset.UseVisualStyleBackColor = false;
            ActionReset.Click += ActionReset_Click;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(429, 275);
            InputSearch.Name = "InputSearch";
            InputSearch.PlaceholderText = "Siswa / Guru / Mapel";
            InputSearch.Size = new Size(184, 23);
            InputSearch.TabIndex = 33;
            InputSearch.TextChanged += InputSearch_TextChanged;
            // 
            // InputSearchLabel
            // 
            InputSearchLabel.AutoSize = true;
            InputSearchLabel.Location = new Point(370, 279);
            InputSearchLabel.Name = "InputSearchLabel";
            InputSearchLabel.Size = new Size(42, 15);
            InputSearchLabel.TabIndex = 32;
            InputSearchLabel.Text = "Search";
            // 
            // ActionUpdate
            // 
            ActionUpdate.BackColor = Color.FromArgb(157, 192, 139);
            ActionUpdate.Enabled = false;
            ActionUpdate.ForeColor = Color.Black;
            ActionUpdate.Location = new Point(104, 275);
            ActionUpdate.Name = "ActionUpdate";
            ActionUpdate.Size = new Size(75, 23);
            ActionUpdate.TabIndex = 31;
            ActionUpdate.Text = "Update";
            ActionUpdate.UseVisualStyleBackColor = false;
            ActionUpdate.Click += ActionUpdate_Click;
            // 
            // ActionDelete
            // 
            ActionDelete.BackColor = Color.FromArgb(157, 192, 139);
            ActionDelete.Enabled = false;
            ActionDelete.ForeColor = Color.Black;
            ActionDelete.Location = new Point(185, 275);
            ActionDelete.Name = "ActionDelete";
            ActionDelete.Size = new Size(75, 23);
            ActionDelete.TabIndex = 30;
            ActionDelete.Text = "Delete";
            ActionDelete.UseVisualStyleBackColor = false;
            ActionDelete.Click += ActionDelete_Click;
            // 
            // ActionCancel
            // 
            ActionCancel.BackColor = Color.FromArgb(157, 192, 139);
            ActionCancel.Enabled = false;
            ActionCancel.ForeColor = Color.Black;
            ActionCancel.Location = new Point(266, 275);
            ActionCancel.Name = "ActionCancel";
            ActionCancel.Size = new Size(75, 23);
            ActionCancel.TabIndex = 29;
            ActionCancel.Text = "Cancel";
            ActionCancel.UseVisualStyleBackColor = false;
            ActionCancel.Click += ActionCancel_Click;
            // 
            // ActionInsert
            // 
            ActionInsert.BackColor = Color.FromArgb(157, 192, 139);
            ActionInsert.ForeColor = Color.Black;
            ActionInsert.Location = new Point(23, 275);
            ActionInsert.Name = "ActionInsert";
            ActionInsert.Size = new Size(75, 23);
            ActionInsert.TabIndex = 28;
            ActionInsert.Text = "Insert";
            ActionInsert.UseVisualStyleBackColor = false;
            ActionInsert.Click += ActionInsert_Click;
            // 
            // InputSiswa
            // 
            InputSiswa.DropDownStyle = ComboBoxStyle.DropDownList;
            InputSiswa.FormattingEnabled = true;
            InputSiswa.Location = new Point(139, 115);
            InputSiswa.Name = "InputSiswa";
            InputSiswa.Size = new Size(140, 23);
            InputSiswa.TabIndex = 43;
            // 
            // InputSiswaError
            // 
            InputSiswaError.AutoSize = true;
            InputSiswaError.BackColor = Color.Transparent;
            InputSiswaError.ForeColor = Color.Red;
            InputSiswaError.Location = new Point(51, 142);
            InputSiswaError.Name = "InputSiswaError";
            InputSiswaError.Size = new Size(0, 15);
            InputSiswaError.TabIndex = 42;
            // 
            // InputSiswaLabel
            // 
            InputSiswaLabel.AutoSize = true;
            InputSiswaLabel.Location = new Point(51, 118);
            InputSiswaLabel.Name = "InputSiswaLabel";
            InputSiswaLabel.Size = new Size(36, 15);
            InputSiswaLabel.TabIndex = 41;
            InputSiswaLabel.Text = "Siswa";
            // 
            // InputMapel
            // 
            InputMapel.DropDownStyle = ComboBoxStyle.DropDownList;
            InputMapel.FormattingEnabled = true;
            InputMapel.Items.AddRange(new object[] { "Laki - Laki", "Perempuan" });
            InputMapel.Location = new Point(139, 164);
            InputMapel.Name = "InputMapel";
            InputMapel.Size = new Size(140, 23);
            InputMapel.TabIndex = 46;
            // 
            // InputMapelError
            // 
            InputMapelError.AutoSize = true;
            InputMapelError.BackColor = Color.Transparent;
            InputMapelError.ForeColor = Color.Red;
            InputMapelError.Location = new Point(51, 191);
            InputMapelError.Name = "InputMapelError";
            InputMapelError.Size = new Size(0, 15);
            InputMapelError.TabIndex = 45;
            // 
            // InputMapelLabel
            // 
            InputMapelLabel.AutoSize = true;
            InputMapelLabel.Location = new Point(51, 167);
            InputMapelLabel.Name = "InputMapelLabel";
            InputMapelLabel.Size = new Size(40, 15);
            InputMapelLabel.TabIndex = 44;
            InputMapelLabel.Text = "Mapel";
            // 
            // InputNilaiLabel
            // 
            InputNilaiLabel.AutoSize = true;
            InputNilaiLabel.Location = new Point(51, 70);
            InputNilaiLabel.Name = "InputNilaiLabel";
            InputNilaiLabel.Size = new Size(31, 15);
            InputNilaiLabel.TabIndex = 47;
            InputNilaiLabel.Text = "Nilai";
            // 
            // InputNilai
            // 
            InputNilai.Location = new Point(139, 67);
            InputNilai.Name = "InputNilai";
            InputNilai.Size = new Size(140, 23);
            InputNilai.TabIndex = 48;
            // 
            // InputNilaiError
            // 
            InputNilaiError.AutoSize = true;
            InputNilaiError.BackColor = Color.Transparent;
            InputNilaiError.ForeColor = Color.Red;
            InputNilaiError.Location = new Point(50, 92);
            InputNilaiError.Name = "InputNilaiError";
            InputNilaiError.Size = new Size(0, 15);
            InputNilaiError.TabIndex = 49;
            // 
            // Nilai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(InputNilaiError);
            Controls.Add(InputNilai);
            Controls.Add(InputNilaiLabel);
            Controls.Add(InputMapel);
            Controls.Add(InputMapelError);
            Controls.Add(InputMapelLabel);
            Controls.Add(InputSiswa);
            Controls.Add(InputSiswaError);
            Controls.Add(InputSiswaLabel);
            Controls.Add(ActionReset);
            Controls.Add(InputSearch);
            Controls.Add(InputSearchLabel);
            Controls.Add(ActionUpdate);
            Controls.Add(ActionDelete);
            Controls.Add(ActionCancel);
            Controls.Add(ActionInsert);
            Controls.Add(DataGridViewNilai);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Nilai";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Nilai";
            WindowState = FormWindowState.Maximized;
            Load += Nilai_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewNilai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewNilai;
        private Button ActionReset;
        private TextBox InputSearch;
        private Label InputSearchLabel;
        private Button ActionUpdate;
        private Button ActionDelete;
        private Button ActionCancel;
        private Button ActionInsert;
        private TextBox InputNilai;
        private Label InputNilaiError;
        private ComboBox InputSiswa;
        private Label InputSiswaError;
        private Label InputSiswaLabel;
        private ComboBox InputMapel;
        private Label InputMapelError;
        private Label InputMapelLabel;
        private DataGridViewTextBoxColumn IdSiswa;
        private DataGridViewTextBoxColumn IdNilai;
        private DataGridViewTextBoxColumn IdMapel;
        private DataGridViewTextBoxColumn IdGuru;
        private DataGridViewTextBoxColumn SiswaName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn MapelName;
        private DataGridViewTextBoxColumn GuruName;
        private Label InputNilaiLabel;
    }
}