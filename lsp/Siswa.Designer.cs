namespace lsp
{
    partial class Siswa
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
            DataGridViewSiswa = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            NoHp = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Jenkel = new DataGridViewTextBoxColumn();
            Jurusan = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            ActionReset = new Button();
            InputSearch = new TextBox();
            InputSearchLabel = new Label();
            ActionUpdate = new Button();
            ActionDelete = new Button();
            ActionCancel = new Button();
            ActionInsert = new Button();
            InputNamaLabel = new Label();
            InputNama = new TextBox();
            InputNamaError = new Label();
            InputNoHpError = new Label();
            InputNoHp = new TextBox();
            InputNoHpLabel = new Label();
            InputEmailError = new Label();
            InputEmail = new TextBox();
            InputEmailLabel = new Label();
            InputJenkelLabel = new Label();
            InputJenkelError = new Label();
            InputJenkel = new ComboBox();
            InputJurusan = new ComboBox();
            InputJurusanError = new Label();
            InputJurusanLabel = new Label();
            InputAlamatLabel = new Label();
            InputAlamatError = new Label();
            InputAlamat = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewSiswa).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewSiswa
            // 
            DataGridViewSiswa.AllowUserToAddRows = false;
            DataGridViewSiswa.AllowUserToDeleteRows = false;
            DataGridViewSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewSiswa.Columns.AddRange(new DataGridViewColumn[] { Id, Nama, NoHp, Email, Jenkel, Jurusan, Alamat });
            DataGridViewSiswa.Location = new Point(0, 311);
            DataGridViewSiswa.Margin = new Padding(10);
            DataGridViewSiswa.Name = "DataGridViewSiswa";
            DataGridViewSiswa.RowTemplate.Height = 25;
            DataGridViewSiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewSiswa.Size = new Size(784, 150);
            DataGridViewSiswa.TabIndex = 0;
            DataGridViewSiswa.CellDoubleClick += DataGridViewSiswa_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama";
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            // 
            // NoHp
            // 
            NoHp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NoHp.HeaderText = "No Hp";
            NoHp.Name = "NoHp";
            NoHp.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Jenkel
            // 
            Jenkel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jenkel.HeaderText = "Kelamin";
            Jenkel.Name = "Jenkel";
            Jenkel.ReadOnly = true;
            // 
            // Jurusan
            // 
            Jurusan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jurusan.HeaderText = "Jurusan";
            Jurusan.Name = "Jurusan";
            Jurusan.ReadOnly = true;
            // 
            // Alamat
            // 
            Alamat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Alamat.HeaderText = "Alamat";
            Alamat.Name = "Alamat";
            Alamat.ReadOnly = true;
            // 
            // ActionReset
            // 
            ActionReset.BackColor = Color.Red;
            ActionReset.ForeColor = Color.White;
            ActionReset.Location = new Point(621, 282);
            ActionReset.Name = "ActionReset";
            ActionReset.Size = new Size(30, 23);
            ActionReset.TabIndex = 27;
            ActionReset.Text = "X";
            ActionReset.UseVisualStyleBackColor = false;
            ActionReset.Click += ActionReset_Click;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(425, 282);
            InputSearch.Name = "InputSearch";
            InputSearch.PlaceholderText = "Nama / Email / Jurusan / Alamat";
            InputSearch.Size = new Size(184, 23);
            InputSearch.TabIndex = 26;
            InputSearch.TextChanged += InputSearch_TextChanged;
            // 
            // InputSearchLabel
            // 
            InputSearchLabel.AutoSize = true;
            InputSearchLabel.Location = new Point(366, 286);
            InputSearchLabel.Name = "InputSearchLabel";
            InputSearchLabel.Size = new Size(42, 15);
            InputSearchLabel.TabIndex = 25;
            InputSearchLabel.Text = "Search";
            // 
            // ActionUpdate
            // 
            ActionUpdate.BackColor = Color.FromArgb(157, 192, 139);
            ActionUpdate.Enabled = false;
            ActionUpdate.ForeColor = Color.Black;
            ActionUpdate.Location = new Point(100, 282);
            ActionUpdate.Name = "ActionUpdate";
            ActionUpdate.Size = new Size(75, 23);
            ActionUpdate.TabIndex = 24;
            ActionUpdate.Text = "Update";
            ActionUpdate.UseVisualStyleBackColor = false;
            ActionUpdate.Click += ActionUpdate_Click;
            // 
            // ActionDelete
            // 
            ActionDelete.BackColor = Color.FromArgb(157, 192, 139);
            ActionDelete.Enabled = false;
            ActionDelete.ForeColor = Color.Black;
            ActionDelete.Location = new Point(181, 282);
            ActionDelete.Name = "ActionDelete";
            ActionDelete.Size = new Size(75, 23);
            ActionDelete.TabIndex = 23;
            ActionDelete.Text = "Delete";
            ActionDelete.UseVisualStyleBackColor = false;
            ActionDelete.Click += ActionDelete_Click;
            // 
            // ActionCancel
            // 
            ActionCancel.BackColor = Color.FromArgb(157, 192, 139);
            ActionCancel.Enabled = false;
            ActionCancel.ForeColor = Color.Black;
            ActionCancel.Location = new Point(262, 282);
            ActionCancel.Name = "ActionCancel";
            ActionCancel.Size = new Size(75, 23);
            ActionCancel.TabIndex = 22;
            ActionCancel.Text = "Cancel";
            ActionCancel.UseVisualStyleBackColor = false;
            ActionCancel.Click += ActionCancel_Click;
            // 
            // ActionInsert
            // 
            ActionInsert.BackColor = Color.FromArgb(157, 192, 139);
            ActionInsert.ForeColor = Color.Black;
            ActionInsert.Location = new Point(19, 282);
            ActionInsert.Name = "ActionInsert";
            ActionInsert.Size = new Size(75, 23);
            ActionInsert.TabIndex = 21;
            ActionInsert.Text = "Insert";
            ActionInsert.UseVisualStyleBackColor = false;
            ActionInsert.Click += ActionInsert_Click;
            // 
            // InputNamaLabel
            // 
            InputNamaLabel.AutoSize = true;
            InputNamaLabel.Location = new Point(74, 52);
            InputNamaLabel.Name = "InputNamaLabel";
            InputNamaLabel.Size = new Size(71, 15);
            InputNamaLabel.TabIndex = 28;
            InputNamaLabel.Text = "Nama Siswa";
            // 
            // InputNama
            // 
            InputNama.Location = new Point(162, 49);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(114, 23);
            InputNama.TabIndex = 29;
            // 
            // InputNamaError
            // 
            InputNamaError.AutoSize = true;
            InputNamaError.BackColor = Color.Transparent;
            InputNamaError.ForeColor = Color.Red;
            InputNamaError.Location = new Point(76, 76);
            InputNamaError.Name = "InputNamaError";
            InputNamaError.Size = new Size(0, 15);
            InputNamaError.TabIndex = 30;
            // 
            // InputNoHpError
            // 
            InputNoHpError.AutoSize = true;
            InputNoHpError.BackColor = Color.Transparent;
            InputNoHpError.ForeColor = Color.Red;
            InputNoHpError.Location = new Point(74, 123);
            InputNoHpError.Name = "InputNoHpError";
            InputNoHpError.Size = new Size(0, 15);
            InputNoHpError.TabIndex = 33;
            // 
            // InputNoHp
            // 
            InputNoHp.Location = new Point(162, 96);
            InputNoHp.Name = "InputNoHp";
            InputNoHp.Size = new Size(114, 23);
            InputNoHp.TabIndex = 32;
            // 
            // InputNoHpLabel
            // 
            InputNoHpLabel.AutoSize = true;
            InputNoHpLabel.Location = new Point(74, 99);
            InputNoHpLabel.Name = "InputNoHpLabel";
            InputNoHpLabel.Size = new Size(42, 15);
            InputNoHpLabel.TabIndex = 31;
            InputNoHpLabel.Text = "No Hp";
            // 
            // InputEmailError
            // 
            InputEmailError.AutoSize = true;
            InputEmailError.BackColor = Color.Transparent;
            InputEmailError.ForeColor = Color.Red;
            InputEmailError.Location = new Point(74, 173);
            InputEmailError.Name = "InputEmailError";
            InputEmailError.Size = new Size(0, 15);
            InputEmailError.TabIndex = 36;
            // 
            // InputEmail
            // 
            InputEmail.Location = new Point(162, 146);
            InputEmail.Name = "InputEmail";
            InputEmail.Size = new Size(114, 23);
            InputEmail.TabIndex = 35;
            // 
            // InputEmailLabel
            // 
            InputEmailLabel.AutoSize = true;
            InputEmailLabel.Location = new Point(74, 149);
            InputEmailLabel.Name = "InputEmailLabel";
            InputEmailLabel.Size = new Size(36, 15);
            InputEmailLabel.TabIndex = 34;
            InputEmailLabel.Text = "Email";
            // 
            // InputJenkelLabel
            // 
            InputJenkelLabel.AutoSize = true;
            InputJenkelLabel.Location = new Point(381, 52);
            InputJenkelLabel.Name = "InputJenkelLabel";
            InputJenkelLabel.Size = new Size(78, 15);
            InputJenkelLabel.TabIndex = 37;
            InputJenkelLabel.Text = "Jenis Kelamin";
            // 
            // InputJenkelError
            // 
            InputJenkelError.AutoSize = true;
            InputJenkelError.BackColor = Color.Transparent;
            InputJenkelError.ForeColor = Color.Red;
            InputJenkelError.Location = new Point(381, 76);
            InputJenkelError.Name = "InputJenkelError";
            InputJenkelError.Size = new Size(0, 15);
            InputJenkelError.TabIndex = 39;
            // 
            // InputJenkel
            // 
            InputJenkel.DropDownStyle = ComboBoxStyle.DropDownList;
            InputJenkel.FormattingEnabled = true;
            InputJenkel.Items.AddRange(new object[] { "Laki - Laki", "Perempuan" });
            InputJenkel.Location = new Point(469, 49);
            InputJenkel.Name = "InputJenkel";
            InputJenkel.Size = new Size(140, 23);
            InputJenkel.TabIndex = 40;
            // 
            // InputJurusan
            // 
            InputJurusan.DropDownStyle = ComboBoxStyle.DropDownList;
            InputJurusan.FormattingEnabled = true;
            InputJurusan.Items.AddRange(new object[] { "RPL", "MM", "TKJ", "Listrik", "Broadcast" });
            InputJurusan.Location = new Point(469, 96);
            InputJurusan.Name = "InputJurusan";
            InputJurusan.Size = new Size(140, 23);
            InputJurusan.TabIndex = 43;
            // 
            // InputJurusanError
            // 
            InputJurusanError.AutoSize = true;
            InputJurusanError.BackColor = Color.Transparent;
            InputJurusanError.ForeColor = Color.Red;
            InputJurusanError.Location = new Point(381, 123);
            InputJurusanError.Name = "InputJurusanError";
            InputJurusanError.Size = new Size(0, 15);
            InputJurusanError.TabIndex = 42;
            // 
            // InputJurusanLabel
            // 
            InputJurusanLabel.AutoSize = true;
            InputJurusanLabel.Location = new Point(381, 99);
            InputJurusanLabel.Name = "InputJurusanLabel";
            InputJurusanLabel.Size = new Size(47, 15);
            InputJurusanLabel.TabIndex = 41;
            InputJurusanLabel.Text = "Jurusan";
            // 
            // InputAlamatLabel
            // 
            InputAlamatLabel.AutoSize = true;
            InputAlamatLabel.Location = new Point(381, 144);
            InputAlamatLabel.Name = "InputAlamatLabel";
            InputAlamatLabel.Size = new Size(45, 15);
            InputAlamatLabel.TabIndex = 44;
            InputAlamatLabel.Text = "Alamat";
            // 
            // InputAlamatError
            // 
            InputAlamatError.AutoSize = true;
            InputAlamatError.BackColor = Color.Transparent;
            InputAlamatError.ForeColor = Color.Red;
            InputAlamatError.Location = new Point(381, 208);
            InputAlamatError.Name = "InputAlamatError";
            InputAlamatError.Size = new Size(0, 15);
            InputAlamatError.TabIndex = 45;
            // 
            // InputAlamat
            // 
            InputAlamat.BorderStyle = BorderStyle.FixedSingle;
            InputAlamat.Location = new Point(469, 141);
            InputAlamat.Name = "InputAlamat";
            InputAlamat.Size = new Size(140, 60);
            InputAlamat.TabIndex = 46;
            InputAlamat.Text = "";
            // 
            // Siswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            ControlBox = false;
            Controls.Add(InputAlamat);
            Controls.Add(InputAlamatError);
            Controls.Add(InputAlamatLabel);
            Controls.Add(InputJurusan);
            Controls.Add(InputJurusanError);
            Controls.Add(InputJurusanLabel);
            Controls.Add(InputJenkel);
            Controls.Add(InputJenkelError);
            Controls.Add(InputJenkelLabel);
            Controls.Add(InputEmailError);
            Controls.Add(InputEmail);
            Controls.Add(InputEmailLabel);
            Controls.Add(InputNoHpError);
            Controls.Add(InputNoHp);
            Controls.Add(InputNoHpLabel);
            Controls.Add(InputNamaError);
            Controls.Add(InputNama);
            Controls.Add(InputNamaLabel);
            Controls.Add(ActionReset);
            Controls.Add(InputSearch);
            Controls.Add(InputSearchLabel);
            Controls.Add(ActionUpdate);
            Controls.Add(ActionDelete);
            Controls.Add(ActionCancel);
            Controls.Add(ActionInsert);
            Controls.Add(DataGridViewSiswa);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Siswa";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Siswa";
            WindowState = FormWindowState.Maximized;
            Load += Siswa_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewSiswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewSiswa;
        private Button ActionReset;
        private TextBox InputSearch;
        private Label InputSearchLabel;
        private Button ActionUpdate;
        private Button ActionDelete;
        private Button ActionCancel;
        private Button ActionInsert;
        private Label InputNamaLabel;
        private TextBox InputNama;
        private Label InputNamaError;
        private Label InputNoHpError;
        private TextBox InputNoHp;
        private Label InputNoHpLabel;
        private Label InputEmailError;
        private TextBox InputEmail;
        private Label InputEmailLabel;
        private Label InputJenkelLabel;
        private Label InputJenkelError;
        private ComboBox InputJenkel;
        private ComboBox InputJurusan;
        private Label InputJurusanError;
        private Label InputJurusanLabel;
        private Label InputAlamatLabel;
        private Label InputAlamatError;
        private RichTextBox InputAlamat;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn NoHp;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Jenkel;
        private DataGridViewTextBoxColumn Jurusan;
        private DataGridViewTextBoxColumn Alamat;
    }
}