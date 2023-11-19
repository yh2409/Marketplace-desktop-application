using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pfa
{
    public partial class admin_updateuser_ : UserControl
    {
        MySqlConnection connect;
        public admin_updateuser_()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if at least one row is selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the values from the selected row in the DataGridView
                    string password = (string)dataGridView1.SelectedRows[0].Cells["password"].Value;
                    string username = dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();
                    string email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                    string role = dataGridView1.SelectedRows[0].Cells["role"].Value.ToString();
                    int PrivilegeLevel = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PrivilegeLevel"].Value);

                    // Construct the SQL update statement
                    string sql = "UPDATE members SET username = @username, email = @email, password = @password, role = @role,privilegelevel = @privilegelevel WHERE username = @username";
                    MySqlCommand command = new MySqlCommand(sql, this.connect);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@privilegelevel", PrivilegeLevel);

                    // Execute the update statement
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Database updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void admin_updateuser__Load(object sender, EventArgs e)
        {
            this.connect = new MySqlConnection();
            this.connect.ConnectionString = "server = localhost;uid = root; pwd = ;database = gamingX";
            try
            {
                this.connect.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("connection failed");
            }

            try
            {
                string sql = "SELECT * FROM members";
                MySqlCommand command = new MySqlCommand(sql, this.connect);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

