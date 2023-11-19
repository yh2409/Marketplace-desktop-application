using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace pfa
{
    public partial class loginform : Form
    {
        MySqlConnection connect;
        public loginform()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginform login = new loginform();
            login.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
                button2.BringToFront();
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (variables.password == "")
            {
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
            }
            index index = new index();
            index.Show();
            this.Hide();
        }

        private void login_Click_1(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (variables.password == "")
            {
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
            }
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
            try
            {
                string sql = "SELECT Email, Password, role FROM members WHERE email = @Email AND password = @Password";
                MySqlCommand command = new MySqlCommand(sql, this.connect);
                command.Parameters.AddWithValue("@Email", textBox1.Text.Trim());
                command.Parameters.AddWithValue("@Password", textBox2.Text.Trim());

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    variables.password = textBox2.Text.Trim();
                    variables.role = reader.GetString("role");
                    reader.Close();
                    if (variables.role == "admin")
                    {
                        adminInterface admin = new adminInterface();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        index index = new index();
                        index.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button7_Click(object sender, EventArgs e)
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
    }
}