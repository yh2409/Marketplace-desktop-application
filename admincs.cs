using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace pfa
{

    public partial class admincs : UserControl
    {
        MySqlConnection connect;
        public admincs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM orders WHERE MemberID = '" + textBox1.Text.ToString() + "'";
                MySqlCommand command = new MySqlCommand(sql, this.connect);
                int rowsAffected = command.ExecuteNonQuery();

                sql = "DELETE FROM members WHERE MemberID = '" + textBox1.Text.ToString() + "'";
                command = new MySqlCommand(sql, this.connect);
                rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No user found with the given username.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void admincs_Load(object sender, EventArgs e)
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
        }
    }
}
