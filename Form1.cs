
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        private string connectionString =
            "server=localhost;user=root;password=belajar123;database=pi_school";

        private int studentId = 0;
        private int visitorId = 0;

        public Form1()
        {
            InitializeComponent();

            btnSave.Click += btnSave_Click;
            btnSaveVisitors.Click += btnSaveVisitors_Click;

            btnUpdateStudent.Click += btnUpdateStudent_Click;
            btnDeleteStudent.Click += btnDeleteStudent_Click;

            btnUpdateVisitors.Click += btnUpdateVisitors_Click;
            btnDeleteVisitors.Click += btnDeleteVisitors_Click;

            dgvData.CellClick += dgvData_CellClick;
            dgvVisitors.CellClick += dgvVisitors_CellClick;

            ShowData();
            ShowVisitors();
        }

        private void ShowVisitors()
        {
            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "SELECT id, visitors, institution FROM visitors";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                dgvVisitors.DataSource = tabel;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void ShowData()
        {
            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query = "SELECT id, nis, name FROM students";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                dgvData.DataSource = tabel;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nama = txtName.Text.Trim();
            string nis = txtNIS.Text.Trim();

            if (nama == "" || nis == "")
            {
                MessageBox.Show("Nama dan NIS tidak boleh kosong");
                return;
            }

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "INSERT INTO students (name, nis) VALUES (@name, @nis)";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", nama);
                cmd.Parameters.AddWithValue("@nis", nis);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data student berhasil disimpan");

                txtName.Clear();
                txtNIS.Clear();

                studentId = 0;
                ShowData();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void dgvData_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];

            studentId = Convert.ToInt32(row.Cells["id"].Value);
            txtNIS.Text = row.Cells["nis"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            string nama = txtName.Text.Trim();
            string nis = txtNIS.Text.Trim();

            if (studentId == 0)
            {
                MessageBox.Show("Pilih student dari tabel terlebih dahulu");
                return;
            }

            if (nama == "" || nis == "")
            {
                MessageBox.Show("Nama dan NIS tidak boleh kosong");
                return;
            }

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "UPDATE students SET name = @name, nis = @nis WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", nama);
                cmd.Parameters.AddWithValue("@nis", nis);
                cmd.Parameters.AddWithValue("@id", studentId);

                conn.Open();
                int hasil = cmd.ExecuteNonQuery();

                if (hasil > 0)
                    MessageBox.Show("Data student berhasil diupdate");
                else
                    MessageBox.Show("Data student tidak ditemukan");

                txtName.Clear();
                txtNIS.Clear();
                studentId = 0;

                ShowData();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (studentId == 0)
            {
                MessageBox.Show("Pilih student dari tabel terlebih dahulu");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data student ini?",
                "Konfirmasi Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi != DialogResult.Yes)
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query = "DELETE FROM students WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", studentId);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data student berhasil dihapus");

                txtName.Clear();
                txtNIS.Clear();
                studentId = 0;

                ShowData();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        

        private void btnSaveVisitors_Click(object sender, EventArgs e)
        {
            string nama = txtVisitors.Text.Trim();
            string instansi = txtInstitution.Text.Trim();

            if (nama == "" || instansi == "")
            {
                MessageBox.Show("Visitor dan institution tidak boleh kosong");
                return;
            }

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "INSERT INTO visitors (visitors, institution) " +
                    "VALUES (@visitors, @institution)";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@visitors", nama);
                cmd.Parameters.AddWithValue("@institution", instansi);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data visitor berhasil disimpan");

                txtVisitors.Clear();
                txtInstitution.Clear();

                visitorId = 0;
                ShowVisitors();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void dgvVisitors_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvVisitors.Rows[e.RowIndex];

            visitorId = Convert.ToInt32(row.Cells["id"].Value);
            txtVisitors.Text = row.Cells["visitors"].Value.ToString();
            txtInstitution.Text = row.Cells["institution"].Value.ToString();
        }

        private void btnUpdateVisitors_Click(object sender, EventArgs e)
        {
            string nama = txtVisitors.Text.Trim();
            string instansi = txtInstitution.Text.Trim();

            if (visitorId == 0)
            {
                MessageBox.Show("Pilih visitor dari tabel terlebih dahulu");
                return;
            }

            if (nama == "" || instansi == "")
            {
                MessageBox.Show("Visitor dan institution tidak boleh kosong");
                return;
            }

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query =
                    "UPDATE visitors SET visitors = @visitors, " +
                    "institution = @institution WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@visitors", nama);
                cmd.Parameters.AddWithValue("@institution", instansi);
                cmd.Parameters.AddWithValue("@id", visitorId);

                conn.Open();
                int hasil = cmd.ExecuteNonQuery();

                if (hasil > 0)
                    MessageBox.Show("Data visitor berhasil diupdate");
                else
                    MessageBox.Show("Data visitor tidak ditemukan");

                txtVisitors.Clear();
                txtInstitution.Clear();
                visitorId = 0;

                ShowVisitors();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }

        private void btnDeleteVisitors_Click(object sender, EventArgs e)
        {
            if (visitorId == 0)
            {
                MessageBox.Show("Pilih visitor dari tabel terlebih dahulu");
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data visitor ini?",
                "Konfirmasi Delete Visitor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi != DialogResult.Yes)
                return;

            try
            {
                using MySqlConnection conn =
                    new MySqlConnection(connectionString);

                string query = "DELETE FROM visitors WHERE id = @id";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", visitorId);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data visitor berhasil dihapus");

                txtVisitors.Clear();
                txtInstitution.Clear();
                visitorId = 0;

                ShowVisitors();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database bermasalah: " + ex.Message);
            }
        }
    }
}
