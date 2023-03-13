using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsp
{
    public partial class Nilai : Form
    {
        int id;
        public Nilai()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            InputNilai.Clear();
            InputMapel.SelectedItem = null;
            InputSiswa.SelectedItem = null;
            ActionInsert.Enabled = true;
            ActionCancel.Enabled = false;
            ActionUpdate.Enabled = false;
            ActionDelete.Enabled = false;
        }
        private bool ValidateInput()
        {
            var result = true;
            if (InputNilai.Text.Length <= 0)
            {
                InputNilaiError.Text = "Masukkan Nilai";
                result = false;
            }
            else
            {
                Match match = Regex.Match(InputNilai.Text, "^[0-9]*$");
                if (!match.Success)
                {
                    InputNilaiError.Text = "Nilai Hanya Menerima Angka";
                    result = false;
                }
                else
                {
                    InputNilaiError.Text = "";
                }
            }
            if (InputMapel.SelectedIndex < 0)
            {
                InputMapelError.Text = "Pilih Mapel";
                result = false;
            }
            else
            {
                InputMapelError.Text = "";

            }
            if (InputSiswa.SelectedIndex < 0)
            {
                InputSiswaError.Text = "Pilih Siswa";
                result = false;
            }
            else
            {
                InputSiswaError.Text = "";

            }
            return result;
        }
        private void LoadData()
        {
            Utils.connection.Open();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"SELECT nilais.id as nilai_id,nilais.nilai as nilai,mapels.id as mapel_id, mapels.name as mapel_name, siswas.id as siswa_id, siswas.name as siswa_name, gurus.id as guru_id, gurus.name as guru_name FROM nilais LEFT JOIN mapels ON mapels.id=nilais.mapel_id LEFT JOIN siswas ON siswas.id=nilais.siswa_id LEFT JOIN gurus ON gurus.id=mapels.guru_id";
            using var reader = command.ExecuteReader();
            DataGridViewNilai.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DataGridViewNilai);
                newRow.Cells[0].Value = reader.GetInt32("siswa_id");
                newRow.Cells[1].Value = reader.GetInt32("nilai_id");
                newRow.Cells[2].Value = reader.GetInt32("mapel_id");
                if (reader.IsDBNull("guru_id"))
                {
                    newRow.Cells[3].Value = null;
                    newRow.Cells[7].Value = "Guru Belum Dipilih";
                }
                else
                {
                    newRow.Cells[3].Value = reader.GetInt32("guru_id");
                    newRow.Cells[7].Value = reader.GetString("guru_name");
                }
                newRow.Cells[4].Value = reader.GetString("siswa_name");
                newRow.Cells[5].Value = reader.GetString("nilai");
                newRow.Cells[6].Value = reader.GetString("mapel_name");
                DataGridViewNilai.Rows.Add(newRow);
            }
            DataGridViewNilai.ClearSelection();
            Utils.connection.Close();
        }
        private void LoadCombo()
        {
            Utils.connection.Open();
            MySqlDataAdapter adapterMapel = new MySqlDataAdapter("SELECT * FROM mapels", Utils.connection);
            DataTable tableMapel = new DataTable();
            adapterMapel.Fill(tableMapel);
            InputMapel.DataSource = tableMapel;
            InputMapel.DisplayMember = "name";
            InputMapel.ValueMember = "id";

            MySqlDataAdapter adapterSiswa = new MySqlDataAdapter("SELECT * FROM siswas", Utils.connection);
            DataTable tableSiswa = new DataTable();
            adapterSiswa.Fill(tableSiswa);
            InputSiswa.DataSource = tableSiswa;
            InputSiswa.DisplayMember = "name";
            InputSiswa.ValueMember = "id";
            Utils.connection.Close();
        }

        private void Nilai_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombo();
            InputMapel.SelectedItem = null;
            InputSiswa.SelectedItem = null;
        }

        private void ActionInsert_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var nilai = InputNilai.Text;
                Utils.connection.Open();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"INSERT INTO nilais (nilai,siswa_id,mapel_id) values(@nilai,@siswa_id,@mapel_id)";
                command.Parameters.AddWithValue("@nilai", nilai);
                command.Parameters.AddWithValue("@mapel_id", InputMapel.SelectedValue);
                command.Parameters.AddWithValue("@siswa_id", InputSiswa.SelectedValue);
                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Berhasil Dimasukkan", "Success");
                }
                else
                {
                    MessageBox.Show("Data Gagal Dimasukkan", "Error");
                }
                Utils.connection.Close();
                Clear();
                LoadData();
            }
        }

        private void InputSearch_TextChanged(object sender, EventArgs e)
        {
            var search = "%" + InputSearch.Text + "%";
            Utils.connection.Open();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"SELECT nilais.id as nilai_id,nilais.nilai as nilai,mapels.id as mapel_id, mapels.name as mapel_name, siswas.id as siswa_id, siswas.name as siswa_name, gurus.id as guru_id, gurus.name as guru_name FROM nilais LEFT JOIN mapels ON mapels.id=nilais.mapel_id LEFT JOIN siswas ON siswas.id=nilais.siswa_id LEFT JOIN gurus ON gurus.id=mapels.guru_id WHERE siswas.name LIKE @search OR mapels.name LIKE @search OR gurus.name LIKE @search;";
            command.Parameters.AddWithValue("@search", search);
            using var reader = command.ExecuteReader();
            DataGridViewNilai.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Cells[0].Value = reader.GetInt32("siswa_id");
                newRow.Cells[1].Value = reader.GetInt32("nilai_id");
                newRow.Cells[2].Value = reader.GetInt32("mapel_id");
                newRow.Cells[3].Value = reader.GetInt32("guru_id");
                newRow.Cells[4].Value = reader.GetString("siswa_name");
                newRow.Cells[5].Value = reader.GetString("nilai");
                newRow.Cells[6].Value = reader.GetString("mapel_name");
                newRow.Cells[7].Value = reader.GetString("guru_name");
                DataGridViewNilai.Rows.Add(newRow);
            }
            DataGridViewNilai.ClearSelection();
            Utils.connection.Close();
        }

        private void ActionUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var nilai = InputNilai.Text;
                Utils.connection.Open();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"UPDATE nilais SET nilai=@nilai, mapel_id=@mapel_id,siswa_id=@siswa_id WHERE id=@id";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nilai", nilai);
                command.Parameters.AddWithValue("@mapel_id", InputMapel.SelectedValue);
                command.Parameters.AddWithValue("@siswa_id", InputSiswa.SelectedValue);
                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Berhasil Dimasukkan", "Success");
                }
                else
                {
                    MessageBox.Show("Data Gagal Dimasukkan", "Error");
                }
                Utils.connection.Close();
                Clear();
                LoadData();
            }

        }

        private void DataGridViewNilai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActionInsert.Enabled = false;
            ActionCancel.Enabled = true;
            ActionUpdate.Enabled = true;
            ActionDelete.Enabled = true;
            id = (int)DataGridViewNilai.SelectedRows[0].Cells[1].Value;
            InputNilai.Text = DataGridViewNilai.SelectedRows[0].Cells[5].Value.ToString();
            InputMapel.SelectedValue = DataGridViewNilai.SelectedRows[0].Cells[2].Value;
            InputSiswa.SelectedValue = DataGridViewNilai.SelectedRows[0].Cells[0].Value;
        }

        private void ActionCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ActionDelete_Click(object sender, EventArgs e)
        {
            Utils.connection.Open();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"DELETE FROM nilais WHERE id=@id;";
            command.Parameters.AddWithValue("@id", id);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Data Berhasil Dihapus", "Success");
            }
            else
            {
                MessageBox.Show("Data Gagal Dihapus", "Error");
            }
            Utils.connection.Close();
            Clear();
            LoadData();
        }

        private void ActionReset_Click(object sender, EventArgs e)
        {
            InputSearch.Clear();
        }
    }
}
