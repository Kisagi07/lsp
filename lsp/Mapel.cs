using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsp
{
    public partial class Mapel : Form
    {
        int id;
        int guru_id;
        public Mapel()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            InputNama.Clear();
            SelectGuru.SelectedItem = null;
            InputSearch.Clear();
            ActionInsert.Enabled = true;
            ActionCancel.Enabled = false;
            ActionUpdate.Enabled = false;
            ActionDelete.Enabled = false;
        }

        private bool ValidateInput()
        {
            if (InputNama.Text.Length <= 0)
            {
                InputNamaError.Text = "Masukkan Nama Mapel";
                return false;
            }
            else
            {
                InputNamaError.Text = "";
            }
            return true;
        }

        private void LoadData()
        {
            Utils.connection.Open();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"SELECT mapels.id as mapel_id, mapels.name as mapel_name, gurus.id as guru_id, gurus.name as guru_name FROM mapels LEFT JOIN gurus ON gurus.id=mapels.guru_id;";
            using var reader = command.ExecuteReader();
            DataGridViewMapel.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DataGridViewMapel);
                newRow.Cells[0].Value = reader.GetInt32("mapel_id");
                newRow.Cells[1].Value = reader.GetString("mapel_name");
                if (reader.IsDBNull("guru_id"))
                {
                    newRow.Cells[2].Value = null;
                    newRow.Cells[3].Value = "Guru Belum Dipilih";
                }
                else
                {
                    newRow.Cells[2].Value = reader.GetInt32("guru_id");
                    newRow.Cells[3].Value = reader.GetString("guru_name");
                }
                DataGridViewMapel.Rows.Add(newRow);
            }
            DataGridViewMapel.ClearSelection();
            Utils.connection.Close();
        }
        public void LoadCombo()
        {
            Utils.connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM gurus", Utils.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SelectGuru.DataSource = table;
            SelectGuru.DisplayMember = "name";
            SelectGuru.ValueMember = "id";
            Utils.connection.Close();
        }
        private void Mapel_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombo();
            SelectGuru.SelectedItem = null;
        }

        private void ActionInsert_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var name = InputNama.Text;
                Utils.connection.Open();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"INSERT INTO mapels (name,guru_id) values(@name,@guru_id)";
                command.Parameters.AddWithValue("@name", name);
                if (SelectGuru.SelectedIndex > -1)
                {
                    command.Parameters.AddWithValue("@guru_id", SelectGuru.SelectedValue);
                }
                else
                {
                    command.Parameters.AddWithValue("@guru_id", null);

                }
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
            command.CommandText = @"SELECT mapels.id as mapel_id, mapels.name as mapel_name, gurus.id as guru_id, gurus.name as guru_name FROM mapels LEFT JOIN gurus ON gurus.id=mapels.guru_id WHERE mapels.name LIKE @search OR gurus.name LIKE @search;";
            command.Parameters.AddWithValue("@search", search);
            using var reader = command.ExecuteReader();
            DataGridViewMapel.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DataGridViewMapel);
                newRow.Cells[0].Value = reader.GetInt32("mapel_id");
                newRow.Cells[1].Value = reader.GetString("mapel_name");
                if (reader.IsDBNull("guru_id"))
                {
                    newRow.Cells[2].Value = null;
                    newRow.Cells[3].Value = "Guru Belum Dipilih";
                }
                else
                {
                    newRow.Cells[2].Value = reader.GetInt32("guru_id");
                    newRow.Cells[3].Value = reader.GetString("guru_name");
                }
                DataGridViewMapel.Rows.Add(newRow);
            }
            DataGridViewMapel.ClearSelection();
            Utils.connection.Close();
        }

        private void ActionUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var name = InputNama.Text;
                Utils.connection.Open();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"UPDATE mapels SET name=@name, guru_id=@guru_id WHERE id=@id";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@id", id);
                if (SelectGuru.SelectedIndex > -1)
                {
                    command.Parameters.AddWithValue("@guru_id", SelectGuru.SelectedValue);
                }
                else
                {
                    command.Parameters.AddWithValue("@guru_id", null);

                }
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

        private void DataGridViewMapel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActionInsert.Enabled = false;
            ActionCancel.Enabled = true;
            ActionUpdate.Enabled = true;
            ActionDelete.Enabled = true;
            id = (int)DataGridViewMapel.SelectedRows[0].Cells[0].Value;
            InputNama.Text = DataGridViewMapel.SelectedRows[0].Cells[1].Value.ToString();
            if (DataGridViewMapel.SelectedRows[0].Cells[2].Value == null)
            {
                SelectGuru.SelectedItem = null;
            }
            else
            {
                SelectGuru.SelectedValue = DataGridViewMapel.SelectedRows[0].Cells[2].Value;

            }
        }

        private void ActionCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ActionDelete_Click(object sender, EventArgs e)
        {
            Utils.connection.Open();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"DELETE FROM mapels WHERE id=@id;";
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
