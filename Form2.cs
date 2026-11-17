
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Login gagal! Username dan password wajib diisi!");
                return;
            }

            Connection conn = new Connection();

            using (MySqlConnection connection = conn.ConnectionToSql())
            {
                connection.Open();

                string query = "SELECT password FROM users WHERE username = @user";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@user", txtUserName.Text);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Login gagal! Username tidak ditemukan!");
                        return;
                    }

                    string passwordHashed = SecurityHelper.HashingPassword(txtPassword.Text);

                    if (passwordHashed != result.ToString())
                    {
                        MessageBox.Show("Login gagal! Password salah!");
                        return;
                    }
                }
            }

            MessageBox.Show("Login berhasil!");

            this.Hide();

            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnNavToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegister frmRegister = new FormRegister();
            frmRegister.Show();
        }
    }
}
