namespace lsp
{
    partial class Mapel
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
            DataGridViewMapel = new DataGridView();
            MapelId = new DataGridViewTextBoxColumn();
            MapelName = new DataGridViewTextBoxColumn();
            GuruId = new DataGridViewTextBoxColumn();
            GuruName = new DataGridViewTextBoxColumn();
            InputNamaLabel = new Label();
            InputNama = new TextBox();
            InputNamaError = new Label();
            SelectGuruError = new Label();
            SelectGuruLabel = new Label();
            SelectGuru = new ComboBox();
            ActionReset = new Button();
            InputSearch = new TextBox();
            InputSearchLabel = new Label();
            ActionUpdate = new Button();
            ActionDelete = new Button();
            ActionCancel = new Button();
            ActionInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMapel).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewMapel
            // 
            DataGridViewMapel.AllowUserToAddRows = false;
            DataGridViewMapel.AllowUserToDeleteRows = false;
            DataGridViewMapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMapel.Columns.AddRange(new DataGridViewColumn[] { MapelId, MapelName, GuruId, GuruName });
            DataGridViewMapel.Location = new Point(12, 219);
            DataGridViewMapel.Name = "DataGridViewMapel";
            DataGridViewMapel.RowTemplate.Height = 25;
            DataGridViewMapel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMapel.Size = new Size(760, 233);
            DataGridViewMapel.TabIndex = 0;
            DataGridViewMapel.CellDoubleClick += DataGridViewMapel_CellDoubleClick;
            // 
            // MapelId
            // 
            MapelId.HeaderText = "Mapel Id";
            MapelId.Name = "MapelId";
            MapelId.ReadOnly = true;
            MapelId.Visible = false;
            // 
            // MapelName
            // 
            MapelName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MapelName.HeaderText = "Nama Mapel";
            MapelName.Name = "MapelName";
            MapelName.ReadOnly = true;
            // 
            // GuruId
            // 
            GuruId.HeaderText = "Id Guru";
            GuruId.Name = "GuruId";
            GuruId.ReadOnly = true;
            GuruId.Visible = false;
            // 
            // GuruName
            // 
            GuruName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GuruName.HeaderText = "Nama Guru";
            GuruName.Name = "GuruName";
            GuruName.ReadOnly = true;
            // 
            // InputNamaLabel
            // 
            InputNamaLabel.AutoSize = true;
            InputNamaLabel.Location = new Point(12, 27);
            InputNamaLabel.Name = "InputNamaLabel";
            InputNamaLabel.Size = new Size(75, 15);
            InputNamaLabel.TabIndex = 1;
            InputNamaLabel.Text = "Nama Mapel";
            // 
            // InputNama
            // 
            InputNama.Location = new Point(121, 24);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(121, 23);
            InputNama.TabIndex = 2;
            // 
            // InputNamaError
            // 
            InputNamaError.AutoSize = true;
            InputNamaError.BackColor = Color.Transparent;
            InputNamaError.ForeColor = Color.Red;
            InputNamaError.Location = new Point(58, 55);
            InputNamaError.Name = "InputNamaError";
            InputNamaError.Size = new Size(0, 15);
            InputNamaError.TabIndex = 3;
            // 
            // SelectGuruError
            // 
            SelectGuruError.AutoSize = true;
            SelectGuruError.BackColor = Color.Transparent;
            SelectGuruError.ForeColor = Color.Red;
            SelectGuruError.Location = new Point(58, 109);
            SelectGuruError.Name = "SelectGuruError";
            SelectGuruError.Size = new Size(0, 15);
            SelectGuruError.TabIndex = 6;
            // 
            // SelectGuruLabel
            // 
            SelectGuruLabel.AutoSize = true;
            SelectGuruLabel.Location = new Point(12, 81);
            SelectGuruLabel.Name = "SelectGuruLabel";
            SelectGuruLabel.Size = new Size(59, 15);
            SelectGuruLabel.TabIndex = 4;
            SelectGuruLabel.Text = "Pilih Guru";
            // 
            // SelectGuru
            // 
            SelectGuru.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectGuru.FormattingEnabled = true;
            SelectGuru.Location = new Point(121, 78);
            SelectGuru.Name = "SelectGuru";
            SelectGuru.Size = new Size(121, 23);
            SelectGuru.TabIndex = 7;
            // 
            // ActionReset
            // 
            ActionReset.BackColor = Color.Red;
            ActionReset.ForeColor = Color.White;
            ActionReset.Location = new Point(527, 190);
            ActionReset.Name = "ActionReset";
            ActionReset.Size = new Size(30, 23);
            ActionReset.TabIndex = 20;
            ActionReset.Text = "X";
            ActionReset.UseVisualStyleBackColor = false;
            ActionReset.Click += ActionReset_Click;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(417, 190);
            InputSearch.Name = "InputSearch";
            InputSearch.PlaceholderText = "Mapel / Guru";
            InputSearch.Size = new Size(100, 23);
            InputSearch.TabIndex = 19;
            InputSearch.TextChanged += InputSearch_TextChanged;
            // 
            // InputSearchLabel
            // 
            InputSearchLabel.AutoSize = true;
            InputSearchLabel.Location = new Point(358, 194);
            InputSearchLabel.Name = "InputSearchLabel";
            InputSearchLabel.Size = new Size(42, 15);
            InputSearchLabel.TabIndex = 18;
            InputSearchLabel.Text = "Search";
            // 
            // ActionUpdate
            // 
            ActionUpdate.BackColor = Color.FromArgb(157, 192, 139);
            ActionUpdate.Enabled = false;
            ActionUpdate.ForeColor = Color.Black;
            ActionUpdate.Location = new Point(92, 190);
            ActionUpdate.Name = "ActionUpdate";
            ActionUpdate.Size = new Size(75, 23);
            ActionUpdate.TabIndex = 17;
            ActionUpdate.Text = "Update";
            ActionUpdate.UseVisualStyleBackColor = false;
            ActionUpdate.Click += ActionUpdate_Click;
            // 
            // ActionDelete
            // 
            ActionDelete.BackColor = Color.FromArgb(157, 192, 139);
            ActionDelete.Enabled = false;
            ActionDelete.ForeColor = Color.Black;
            ActionDelete.Location = new Point(173, 190);
            ActionDelete.Name = "ActionDelete";
            ActionDelete.Size = new Size(75, 23);
            ActionDelete.TabIndex = 16;
            ActionDelete.Text = "Delete";
            ActionDelete.UseVisualStyleBackColor = false;
            ActionDelete.Click += ActionDelete_Click;
            // 
            // ActionCancel
            // 
            ActionCancel.BackColor = Color.FromArgb(157, 192, 139);
            ActionCancel.Enabled = false;
            ActionCancel.ForeColor = Color.Black;
            ActionCancel.Location = new Point(254, 190);
            ActionCancel.Name = "ActionCancel";
            ActionCancel.Size = new Size(75, 23);
            ActionCancel.TabIndex = 15;
            ActionCancel.Text = "Cancel";
            ActionCancel.UseVisualStyleBackColor = false;
            ActionCancel.Click += ActionCancel_Click;
            // 
            // ActionInsert
            // 
            ActionInsert.BackColor = Color.FromArgb(157, 192, 139);
            ActionInsert.ForeColor = Color.Black;
            ActionInsert.Location = new Point(11, 190);
            ActionInsert.Name = "ActionInsert";
            ActionInsert.Size = new Size(75, 23);
            ActionInsert.TabIndex = 14;
            ActionInsert.Text = "Insert";
            ActionInsert.UseVisualStyleBackColor = false;
            ActionInsert.Click += ActionInsert_Click;
            // 
            // Mapel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            ControlBox = false;
            Controls.Add(ActionReset);
            Controls.Add(InputSearch);
            Controls.Add(InputSearchLabel);
            Controls.Add(ActionUpdate);
            Controls.Add(ActionDelete);
            Controls.Add(ActionCancel);
            Controls.Add(ActionInsert);
            Controls.Add(SelectGuru);
            Controls.Add(SelectGuruError);
            Controls.Add(SelectGuruLabel);
            Controls.Add(InputNamaError);
            Controls.Add(InputNama);
            Controls.Add(InputNamaLabel);
            Controls.Add(DataGridViewMapel);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Mapel";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Mapel";
            WindowState = FormWindowState.Maximized;
            Load += Mapel_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewMapel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewMapel;
        private Label InputNamaLabel;
        private TextBox InputNama;
        private Label InputNamaError;
        private Label SelectGuruError;
        private Label SelectGuruLabel;
        private ComboBox SelectGuru;
        private Button ActionReset;
        private TextBox InputSearch;
        private Label InputSearchLabel;
        private Button ActionUpdate;
        private Button ActionDelete;
        private Button ActionCancel;
        private Button ActionInsert;
        private DataGridViewTextBoxColumn MapelId;
        private DataGridViewTextBoxColumn MapelName;
        private DataGridViewTextBoxColumn GuruId;
        private DataGridViewTextBoxColumn GuruName;
    }
}