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
    public partial class Login : Form
    {
        public Login()
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
            } else
            {
                InputEmailError.Text = "";

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

        private void ActionLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Utils.connection.Open();
                using var command = Utils.connection.CreateCommand();
                command.CommandText = @"SELECT * FROM users WHERE email=@email AND password=@password LIMIT 1";
                command.Parameters.AddWithValue("@email", InputEmail.Text);
                command.Parameters.AddWithValue("@password", InputPassword.Text);
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    new Dashboard().Show();
                } else
                {
                    MessageBox.Show("Ups! Username atau Password anda Salah");
                }
                Utils.connection.Close();
            }
        }
    }
}
