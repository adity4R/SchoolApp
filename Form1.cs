using MySql.Data.MySqlClient;
using System.Data;

namespace NSchoolApp
{
    public partial class Form1 : Form
    {

        private int selectedId = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private string Connection()
        {
            return "Server=localhost;Database=pi_school;Uid=root;Pwd=;";
        }

        private void ShowData()
        {
            using (MySqlConnection connection = new MySqlConnection(Connection()))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM visitors";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvData.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtInstitution.Text != "")
            {
                using (MySqlConnection connection = new MySqlConnection(Connection()))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO visitors (visitor_name, institution) VALUES (@name, @institution)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@institution", txtInstitution.Text);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data tersimpan.");
                                ShowData();
                                txtName.Clear();
                                txtInstitution.Clear();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Pilih data dulu woi!.");
                return;
            }

            if (txtName.Text != "" && txtInstitution.Text != "")
            {
                using (MySqlConnection connection = new MySqlConnection(Connection()))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE visitors SET visitor_name = @name, institution = @institution WHERE id = @id";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@institution", txtInstitution.Text);
                            command.Parameters.AddWithValue("@id", selectedId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data ter-update.");

                                ShowData();

                                txtName.Clear();
                                txtInstitution.Clear();

                                selectedId = 0;
                            }
                            else
                            {
                                MessageBox.Show("Data tidak ditemukan.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan isi semua kolom.");
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                Console.Write($"{row}");

                selectedId = Convert.ToInt32(row.Cells["id"].Value);
                txtName.Text = row.Cells["visitor_name"].Value.ToString();
                txtInstitution.Text = row.Cells["institution"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Pilih data dulu woi!.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Asli mau delete data?",
                "konfirmasi Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(Connection()))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM visitors WHERE id = @id";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data terhapus.");

                                ShowData();

                                txtName.Clear();
                                txtInstitution.Clear();

                                selectedId = 0;
                            }
                            else
                            {
                                MessageBox.Show("Data tidak ditemukan.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
        }
    }
}