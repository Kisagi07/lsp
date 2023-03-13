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
    public partial class Guru : Form
    {
        int id;
        public Guru()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            if (InputNama.Text.Length <= 0)
            {
                InputNamaError.Text = "Tolong Masukkan Nama Guru";
                return false;
            }
            else
            {
                InputNamaError.Text = "";
            }
            if (InputNip.Text.Length <= 0)
            {
                InputNipError.Text = "Tolong Masukkkan No Nip Guru";
                return false;
            }
            else
            {
                InputNipError.Text = "";
            }
            Match match = Regex.Match(InputNip.Text, "^[0-9]*$");
            if (!match.Success)
            {
                InputNipError.Text = "Hanya Masukkan Nomer di NIP";
                return false;
            }
            else
            {
                InputNipError.Text = "";
            }
            return true;
        }
        private void clear()
        {
            InputNama.Clear();
            InputNip.Clear();
            InputSearch.Clear();
            ActionInsert.Enabled = true;
            ActionCancel.Enabled = false;
            ActionUpdate.Enabled = false;
            ActionDelete.Enabled = false;
        }

        private async void loadData()
        {
            await Utils.connection.OpenAsync();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"SELECT * FROM gurus";
            using var reader = await command.ExecuteReaderAsync();
            DataGridViewGuru.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DataGridViewGuru);
                newRow.Cells[0].Value = reader.GetInt32("id");
                newRow.Cells[1].Value = reader.GetString("name");
                newRow.Cells[2].Value = reader.GetString("nip");
                DataGridViewGuru.Rows.Add(newRow);
            }
            DataGridViewGuru.ClearSelection();
            await Utils.connection.CloseAsync();
        }

        private void Guru_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private async void InputSearch_TextChanged(object sender, EventArgs e)
        {
            var search = "%" + InputSearch.Text + "%";
            await Utils.connection.OpenAsync();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"SELECT * FROM gurus WHERE name LIKE @search OR nip LIKE @search;";
            command.Parameters.AddWithValue("@search", search);
            using var reader = await command.ExecuteReaderAsync();
            DataGridViewGuru.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DataGridViewGuru);
                newRow.Cells[0].Value = reader.GetInt32("id");
                newRow.Cells[1].Value = reader.GetString("name");
                newRow.Cells[2].Value = reader.GetString("nip");
                DataGridViewGuru.Rows.Add(newRow);
            }
            DataGridViewGuru.ClearSelection();
            await Utils.connection.CloseAsync();
        }

        private void ActionReset_Click(object sender, EventArgs e)
        {
            InputSearch.Clear();
        }

        private async void ActionInsert_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var name = InputNama.Text;
                var nip = InputNip.Text;
                await Utils.connection.OpenAsync();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"INSERT INTO gurus (name,nip) values(@name,@nip)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@nip", nip);
                var result = await command.ExecuteNonQueryAsync();
                if (result > 0)
                {
                    MessageBox.Show("Data Berhasil Ditambahkan", "Success");
                }
                else
                {
                    MessageBox.Show("Data Gagal Ditambahkan", "Error");
                }
                await Utils.connection.CloseAsync();
                clear();
                loadData();
            }
        }

        private void DataGridViewGuru_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActionInsert.Enabled = false;
            ActionCancel.Enabled = true;
            ActionUpdate.Enabled = true;
            ActionDelete.Enabled = true;
            id = (int)DataGridViewGuru.SelectedRows[0].Cells[0].Value;
            InputNama.Text = DataGridViewGuru.SelectedRows[0].Cells[1].Value.ToString();
            InputNip.Text = DataGridViewGuru.SelectedRows[0].Cells[2].Value.ToString();

        }

        private async void ActionUpdate_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var name = InputNama.Text;
                var nip = InputNip.Text;
                await Utils.connection.OpenAsync();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"UPDATE gurus SET name=@name, nip=@nip WHERE id=@id;";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@nip", nip);
                command.Parameters.AddWithValue("@id", id);
                var result = await command.ExecuteNonQueryAsync();
                if (result > 0)
                {
                    MessageBox.Show("Data Berhasil Update", "Success");
                }
                else
                {
                    MessageBox.Show("Data Gagal Update", "Error");
                }
                await Utils.connection.CloseAsync();
                clear();
                loadData();
            }
        }

        private void ActionCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private async void ActionDelete_Click(object sender, EventArgs e)
        {
            await Utils.connection.OpenAsync();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"DELETE FROM gurus WHERE id=@id;";
            command.Parameters.AddWithValue("@id", id);
            var result = await command.ExecuteNonQueryAsync();
            if (result > 0)
            {
                MessageBox.Show("Data Berhasil Dihapus", "Success");
            }
            else
            {
                MessageBox.Show("Data Gagal Dihapus", "Error");
            }
            await Utils.connection.CloseAsync();
            clear();
            loadData();
        }
    }
}
