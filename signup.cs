using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace pfa
{
    public partial class signup : Form
    {
        MySqlConnection connect;
        public signup()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                button6.BringToFront();
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button5.BringToFront();
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button5.BringToFront();
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                button6.BringToFront();
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginform login = new loginform();
            login.Show();
            this.Hide();
        }

        private void signup_Load(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                button6.BringToFront();
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button5.BringToFront();
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (textBox3.UseSystemPasswordChar)
            {
                textBox3.UseSystemPasswordChar = false;
                button8.BringToFront();
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                button7.BringToFront();
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (variables.password == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            index index = new index();
            index.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (variables.password == "")
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
            contact contact = new contact();
            contact.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (variables.password == "")
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
            aboutus aboutus = new aboutus();
            aboutus.Show();
            this.Hide();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql3 = "INSERT INTO members (username, password,email) VALUES ('" + textBox7.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox1.Text.Trim() + "')";
            MySqlCommand command3 = new MySqlCommand(sql3, this.connect);

            try
            {
                int rowsAffected = command3.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    index index = new index();
                    index.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (variables.role == "admin")
            {
                button7.Visible = true;
            }
            else
            {
                button7.Visible = false;
            }
            adminInterface admin = new adminInterface();
            admin.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
