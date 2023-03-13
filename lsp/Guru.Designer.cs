namespace lsp
{
    partial class Guru
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
            DataGridViewGuru = new DataGridView();
            GuruId = new DataGridViewTextBoxColumn();
            GuruName = new DataGridViewTextBoxColumn();
            NoNip = new DataGridViewTextBoxColumn();
            InputNamaLabel = new Label();
            InputNama = new TextBox();
            InputNamaError = new Label();
            InputNipError = new Label();
            InputNip = new TextBox();
            InputNipLabel = new Label();
            ActionInsert = new Button();
            ActionCancel = new Button();
            ActionDelete = new Button();
            ActionUpdate = new Button();
            InputSearchLabel = new Label();
            InputSearch = new TextBox();
            ActionReset = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewGuru).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewGuru
            // 
            DataGridViewGuru.AllowUserToAddRows = false;
            DataGridViewGuru.AllowUserToDeleteRows = false;
            DataGridViewGuru.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewGuru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewGuru.Columns.AddRange(new DataGridViewColumn[] { GuruId, GuruName, NoNip });
            DataGridViewGuru.Location = new Point(0, 243);
            DataGridViewGuru.Name = "DataGridViewGuru";
            DataGridViewGuru.RowTemplate.Height = 25;
            DataGridViewGuru.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewGuru.Size = new Size(786, 225);
            DataGridViewGuru.TabIndex = 0;
            DataGridViewGuru.CellDoubleClick += DataGridViewGuru_CellContentDoubleClick;
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
            // NoNip
            // 
            NoNip.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NoNip.HeaderText = "No Nip";
            NoNip.Name = "NoNip";
            NoNip.ReadOnly = true;
            // 
            // InputNamaLabel
            // 
            InputNamaLabel.Location = new Point(38, 41);
            InputNamaLabel.Name = "InputNamaLabel";
            InputNamaLabel.Size = new Size(39, 15);
            InputNamaLabel.TabIndex = 1;
            InputNamaLabel.Text = "Nama";
            // 
            // InputNama
            // 
            InputNama.Location = new Point(93, 38);
            InputNama.MinimumSize = new Size(100, 23);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(100, 23);
            InputNama.TabIndex = 2;
            // 
            // InputNamaError
            // 
            InputNamaError.AutoSize = true;
            InputNamaError.BackColor = Color.Transparent;
            InputNamaError.ForeColor = Color.Red;
            InputNamaError.Location = new Point(66, 74);
            InputNamaError.Name = "InputNamaError";
            InputNamaError.Size = new Size(0, 15);
            InputNamaError.TabIndex = 3;
            // 
            // InputNipError
            // 
            InputNipError.AutoSize = true;
            InputNipError.BackColor = Color.Transparent;
            InputNipError.ForeColor = Color.Red;
            InputNipError.Location = new Point(66, 141);
            InputNipError.Name = "InputNipError";
            InputNipError.Size = new Size(0, 15);
            InputNipError.TabIndex = 6;
            // 
            // InputNip
            // 
            InputNip.Location = new Point(93, 105);
            InputNip.MinimumSize = new Size(100, 23);
            InputNip.Name = "InputNip";
            InputNip.Size = new Size(100, 23);
            InputNip.TabIndex = 5;
            // 
            // InputNipLabel
            // 
            InputNipLabel.Location = new Point(38, 108);
            InputNipLabel.Name = "InputNipLabel";
            InputNipLabel.Size = new Size(48, 15);
            InputNipLabel.TabIndex = 4;
            InputNipLabel.Text = "No .NIP";
            // 
            // ActionInsert
            // 
            ActionInsert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActionInsert.AutoSize = true;
            ActionInsert.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ActionInsert.BackColor = Color.FromArgb(157, 192, 139);
            ActionInsert.ForeColor = Color.Black;
            ActionInsert.Location = new Point(12, 202);
            ActionInsert.MinimumSize = new Size(75, 25);
            ActionInsert.Name = "ActionInsert";
            ActionInsert.Size = new Size(75, 25);
            ActionInsert.TabIndex = 7;
            ActionInsert.Text = "Insert";
            ActionInsert.UseVisualStyleBackColor = false;
            ActionInsert.Click += ActionInsert_Click;
            // 
            // ActionCancel
            // 
            ActionCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ActionCancel.AutoSize = true;
            ActionCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ActionCancel.BackColor = Color.FromArgb(157, 192, 139);
            ActionCancel.Enabled = false;
            ActionCancel.ForeColor = Color.Black;
            ActionCancel.Location = new Point(255, 202);
            ActionCancel.Name = "ActionCancel";
            ActionCancel.Size = new Size(53, 25);
            ActionCancel.TabIndex = 8;
            ActionCancel.Text = "Cancel";
            ActionCancel.UseVisualStyleBackColor = false;
            ActionCancel.Click += ActionCancel_Click;
            // 
            // ActionDelete
            // 
            ActionDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ActionDelete.AutoSize = true;
            ActionDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ActionDelete.BackColor = Color.FromArgb(157, 192, 139);
            ActionDelete.Enabled = false;
            ActionDelete.ForeColor = Color.Black;
            ActionDelete.Location = new Point(174, 202);
            ActionDelete.Name = "ActionDelete";
            ActionDelete.Size = new Size(50, 25);
            ActionDelete.TabIndex = 9;
            ActionDelete.Text = "Delete";
            ActionDelete.UseVisualStyleBackColor = false;
            ActionDelete.Click += ActionDelete_Click;
            // 
            // ActionUpdate
            // 
            ActionUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActionUpdate.AutoSize = true;
            ActionUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ActionUpdate.BackColor = Color.FromArgb(157, 192, 139);
            ActionUpdate.Enabled = false;
            ActionUpdate.ForeColor = Color.Black;
            ActionUpdate.Location = new Point(93, 202);
            ActionUpdate.MinimumSize = new Size(75, 25);
            ActionUpdate.Name = "ActionUpdate";
            ActionUpdate.Size = new Size(75, 25);
            ActionUpdate.TabIndex = 10;
            ActionUpdate.Text = "Update";
            ActionUpdate.UseVisualStyleBackColor = false;
            ActionUpdate.Click += ActionUpdate_Click;
            // 
            // InputSearchLabel
            // 
            InputSearchLabel.Location = new Point(359, 206);
            InputSearchLabel.Name = "InputSearchLabel";
            InputSearchLabel.Size = new Size(42, 15);
            InputSearchLabel.TabIndex = 11;
            InputSearchLabel.Text = "Search";
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(418, 202);
            InputSearch.Name = "InputSearch";
            InputSearch.PlaceholderText = "Nama / NIP";
            InputSearch.Size = new Size(100, 23);
            InputSearch.TabIndex = 12;
            InputSearch.TextChanged += InputSearch_TextChanged;
            // 
            // ActionReset
            // 
            ActionReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActionReset.AutoSize = true;
            ActionReset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ActionReset.BackColor = Color.Red;
            ActionReset.ForeColor = Color.White;
            ActionReset.Location = new Point(528, 202);
            ActionReset.MaximumSize = new Size(50, 50);
            ActionReset.Name = "ActionReset";
            ActionReset.Size = new Size(24, 25);
            ActionReset.TabIndex = 13;
            ActionReset.Text = "X";
            ActionReset.UseVisualStyleBackColor = false;
            ActionReset.Click += ActionReset_Click;
            // 
            // Guru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 461);
            ControlBox = false;
            Controls.Add(ActionReset);
            Controls.Add(InputSearch);
            Controls.Add(InputSearchLabel);
            Controls.Add(ActionUpdate);
            Controls.Add(ActionDelete);
            Controls.Add(ActionCancel);
            Controls.Add(ActionInsert);
            Controls.Add(InputNipError);
            Controls.Add(InputNip);
            Controls.Add(InputNipLabel);
            Controls.Add(InputNamaError);
            Controls.Add(InputNama);
            Controls.Add(InputNamaLabel);
            Controls.Add(DataGridViewGuru);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Guru";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Guru";
            WindowState = FormWindowState.Maximized;
            Load += Guru_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewGuru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewGuru;
        private Label InputNamaLabel;
        private TextBox InputNama;
        private Label InputNamaError;
        private Label InputNipError;
        private TextBox InputNip;
        private Label InputNipLabel;
        private Button ActionInsert;
        private Button ActionCancel;
        private Button ActionDelete;
        private Button ActionUpdate;
        private Label InputSearchLabel;
        private TextBox InputSearch;
        private Button ActionReset;
        private DataGridViewTextBoxColumn GuruId;
        private DataGridViewTextBoxColumn GuruName;
        private DataGridViewTextBoxColumn NoNip;
    }
}