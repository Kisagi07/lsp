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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            bool result = true;
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
                    command.CommandText = @"SELECT COUNT(*) FROM users WHERE email=@email;";
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
            if(InputNama.Text.Length <= 0)
            {
                InputNamaError.Text = "Masukkan Nama";
                result = false;
            } else
            {
                InputNamaError.Text = "";
            }
            if (InputPassword.Text.Length <= 0)
            {
                InputPasswordError.Text = "Masukkan Password";
                result = false;
            }
            else
            {
                InputPasswordError.Text = "";
            }
            return result;
           
        }
        private void ActionRegister_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                Utils.connection.Open();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"INSERT INTO users (name,email,password) values(@name,@email,@password)";
                command.Parameters.AddWithValue("@email", InputEmail.Text.Trim());
                command.Parameters.AddWithValue("@name", InputNama.Text);
                command.Parameters.AddWithValue("@password", InputPassword.Text);
                var result = command.ExecuteNonQuery();
                if(result > 0)
                {
                    MessageBox.Show("Berhasil Daftar", "Success");
                    this.Hide();
                    new Login().Show();
                } else
                {
                    MessageBox.Show("Gagal Daftar", "Error");
                }
               
                Utils.connection.Close();
            }
        }
    }
}
