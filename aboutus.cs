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
using MySql.Data.MySqlClient;

namespace pfa
{

    public partial class aboutus : Form
    {
        MySqlConnection connect;
        public aboutus()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contact contact = new contact();
            contact.Location = this.Location;
            contact.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Location = this.Location;
            loginform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index index = new index();
            index.Location = this.Location;
            index.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aboutus aboutus = new aboutus();
            aboutus.Location = this.Location;
            aboutus.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutus_Load(object sender, EventArgs e)
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
            if (variables.role == "admin")
            {
                button5.Visible = true;
            }
            else
            {
                button5.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                adminInterface admin = new adminInterface();
                admin.Location = this.Location;
                admin.Show();
                this.Hide();
            }
        }

        
    }
}
