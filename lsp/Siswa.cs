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
    public partial class Siswa : Form
    {
        int id;
        public Siswa()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            ActionInsert.Enabled = true;
            ActionCancel.Enabled = false;
            ActionUpdate.Enabled = false;
            ActionDelete.Enabled = false;
            InputAlamat.Clear();
            InputEmail.Clear();
            InputJenkel.SelectedItem = null;
            InputJurusan.SelectedItem = null;
            InputNama.Clear();
            InputNoHp.Clear();
            InputSearch.Clear();
        }

        private bool ValidateInput()
        {
            bool result = true;
            if (InputAlamat.Text.Length <= 0)
            {
                InputAlamatError.Text = "Masukkan Alamat";
                result = false;
            }
            else
            {
                InputAlamatError.Text = "";
            }
            if (InputEmail.Text.Length <= 0)
            {
                InputEmailError.Text = "Masukkan Email";
                result = false;
            }
            else
            {
                Match match = Regex.Match(InputEmail.Text, "^.+@.+\\.[a-zA-Z]{2,3}$");
                if (!match.Success)
                {
                    InputEmailError.Text = "Masukkan Email Yang Benar";
                    result = false;
                }
                else
                {
                    Utils.connection.Open();
                    using var command = Utils.connection.CreateCommand();
                    command.CommandText = @"SELECT COUNT(*) FROM siswas WHERE email=@email;";
                    command.Parameters.AddWithValue("@email", InputEmail.Text.Trim());
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        InputEmailError.Text = "Email Sudah Ada";
                    }
                    else
                    {
                        InputEmailError.Text = "";
                    }
                    Utils.connection.Close();
                }
            }
            if (InputNama.Text.Length <= 0)
            {
                InputNamaError.Text = "Masukkan Nama";
                result = false;
            }
            else
            {
                InputNamaError.Text = "";
            }
            if (InputNoHp.Text.Length <= 0)
            {
                InputNoHpError.Text = "Masukkan No Hp";
                result = false;
            }
            else
            {
                Match match = Regex.Match(InputNoHp.Text, "^[0-9]*$");
                if (!match.Success)
                {
                    InputNoHpError.Text = "Hanya Masukkan Angka Untuk No Hp";
                    result = false;
                }
                else
                {
                    InputNoHpError.Text = "";
                }

            }
            if (InputJurusan.SelectedIndex < 0)
            {
                InputJurusanError.Text = "Pilih Jurusan";
                result = false;
            }
            else
            {
                InputJurusanError.Text = "";
            }
            if (InputJenkel.SelectedIndex < 0)
            {
                InputJenkelError.Text = "Pilih Jenis Kelamin";
                result = false;
            }
            else
            {
                InputJenkelError.Text = "";
            }
            return result;
        }
        private bool ValidateInputEdit()
        {
            bool result = true;
            if (InputAlamat.Text.Length <= 0)
            {
                InputAlamatError.Text = "Masukkan Alamat";
                result = false;
            }
            else
            {
                InputAlamatError.Text = "";
            }
            if (InputEmail.Text.Length <= 0)
            {
                InputEmailError.Text = "Masukkan Email";
                result = false;
            }
            else
            {
                Match match = Regex.Match(InputEmail.Text, "^.+@.+\\.[a-zA-Z]{2,3}$");
                if (!match.Success)
                {
                    InputEmailError.Text = "Masukkan Email Yang Benar";
                    result = false;
                }
                else
                {
                    Utils.connection.Open();
                    using var command = Utils.connection.CreateCommand();
                    command.CommandText = @"SELECT COUNT(*) FROM siswas WHERE email=@email AND id!=@id;";
                    command.Parameters.AddWithValue("@email", InputEmail.Text.Trim());
                    command.Parameters.AddWithValue("@id", id);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        InputEmailError.Text = "Email Sudah Ada";
                    }
                    else
                    {
                        InputEmailError.Text = "";
                    }
                    Utils.connection.Close();
                }
            }
            if (InputNama.Text.Length <= 0)
            {
                InputNamaError.Text = "Masukkan Nama";
                result = false;
            }
            else
            {
                InputNamaError.Text = "";
            }
            if (InputNoHp.Text.Length <= 0)
            {
                InputNoHpError.Text = "Masukkan No Hp";
                result = false;
            }
            else
            {
                Match match = Regex.Match(InputNoHp.Text, "^[0-9]*$");
                if (!match.Success)
                {
                    InputNoHpError.Text = "Hanya Masukkan Angka Untuk No Hp";
                    result = false;
                }
                else
                {
                    InputNoHpError.Text = "";
                }

            }
            if (InputJurusan.SelectedIndex < 0)
            {
                InputJurusanError.Text = "Pilih Jurusan";
                result = false;
            }
            else
            {
                InputJurusanError.Text = "";
            }
            if (InputJenkel.SelectedIndex < 0)
            {
                InputJenkelError.Text = "Pilih Jenis Kelamin";
                result = false;
            }
            else
            {
                InputJenkelError.Text = "";
            }
            return result;
        }
        private void LoadData()
        {
            Utils.connection.Open();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"SELECT * FROM siswas;";
            using var reader = command.ExecuteReader();
            DataGridViewSiswa.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DataGridViewSiswa);
                newRow.Cells[0].Value = reader.GetInt32("id");
                newRow.Cells[1].Value = reader.GetString("name");
                newRow.Cells[2].Value = reader.GetString("no_hp");
                newRow.Cells[3].Value = reader.GetString("email");
                newRow.Cells[4].Value = reader.GetString("jenkel");
                newRow.Cells[5].Value = reader.GetString("jurusan");
                newRow.Cells[6].Value = reader.GetString("alamat");
                DataGridViewSiswa.Rows.Add(newRow);
            }
            DataGridViewSiswa.ClearSelection();
            Utils.connection.Close();
        }

        private void Siswa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ActionInsert_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Utils.connection.Open();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"INSERT INTO siswas (name,no_hp,email,jenkel,jurusan,alamat) values(@name,@no_hp,@email,@jenkel,@jurusan,@alamat);";
                command.Parameters.AddWithValue("@name", InputNama.Text);
                command.Parameters.AddWithValue("@no_hp", InputNoHp.Text);
                command.Parameters.AddWithValue("@email", InputEmail.Text.Trim());
                command.Parameters.AddWithValue("@jenkel", InputJenkel.SelectedItem);
                command.Parameters.AddWithValue("@jurusan", InputJurusan.SelectedItem);
                command.Parameters.AddWithValue("@alamat", InputAlamat.Text);
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

        private void ActionCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void InputSearch_TextChanged(object sender, EventArgs e)
        {
            var search = "%" + InputSearch.Text + "%";
            Utils.connection.Open();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"SELECT * FROM siswas WHERE name LIKE @search OR jurusan LIKE @search OR alamat LIKE @search OR email LIKE @search;";
            command.Parameters.AddWithValue("@search", search);
            using var reader = command.ExecuteReader();
            DataGridViewSiswa.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DataGridViewSiswa);
                newRow.Cells[0].Value = reader.GetInt32("id");
                newRow.Cells[1].Value = reader.GetString("name");
                newRow.Cells[2].Value = reader.GetString("no_hp");
                newRow.Cells[3].Value = reader.GetString("email");
                newRow.Cells[4].Value = reader.GetString("jenkel");
                newRow.Cells[5].Value = reader.GetString("jurusan");
                newRow.Cells[6].Value = reader.GetString("alamat");
                DataGridViewSiswa.Rows.Add(newRow);
            }
            DataGridViewSiswa.ClearSelection();
            Utils.connection.Close();
        }

        private void ActionReset_Click(object sender, EventArgs e)
        {
            InputSearch.Clear();
        }

        private void DataGridViewSiswa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)DataGridViewSiswa.SelectedRows[0].Cells[0].Value;
            ActionInsert.Enabled = false;
            ActionCancel.Enabled = true;
            ActionUpdate.Enabled = true;
            ActionDelete.Enabled = true;
            InputNama.Text = DataGridViewSiswa.SelectedRows[0].Cells[1].Value.ToString();
            InputNoHp.Text = DataGridViewSiswa.SelectedRows[0].Cells[2].Value.ToString();
            InputEmail.Text = DataGridViewSiswa.SelectedRows[0].Cells[3].Value.ToString();
            InputJenkel.SelectedItem = DataGridViewSiswa.SelectedRows[0].Cells[4].Value;
            InputJurusan.SelectedItem = DataGridViewSiswa.SelectedRows[0].Cells[5].Value;
            InputAlamat.Text = DataGridViewSiswa.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void ActionUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputEdit())
            {
                Utils.connection.Open();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"UPDATE siswas SET name=@name, no_hp=@no_hp,email=@email,jenkel=@jenkel,jurusan=@jurusan,alamat=@alamat WHERE id=@id;";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", InputNama.Text);
                command.Parameters.AddWithValue("@no_hp", InputNoHp.Text);
                command.Parameters.AddWithValue("@email", InputEmail.Text.Trim());
                command.Parameters.AddWithValue("@jenkel", InputJenkel.SelectedItem);
                command.Parameters.AddWithValue("@jurusan", InputJurusan.SelectedItem);
                command.Parameters.AddWithValue("@alamat", InputAlamat.Text);
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

        private void ActionDelete_Click(object sender, EventArgs e)
        {
            Utils.connection.Open();
            using var command = Utils.connection.CreateCommand();
            command.CommandText = @"DELETE FROM siswas WHERE id=@id;";
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
    }
}
