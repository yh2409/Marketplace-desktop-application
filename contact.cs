using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing;

namespace pfa
{
    public partial class contact : Form
    {
        MySqlConnection connect;
        public contact()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aboutus aboutus = new aboutus();
            aboutus.Location = this.Location;
            aboutus.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contact contact = new contact();
            contact.Location = this.Location;
            contact.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index index = new index();
            index.Location = this.Location;
            index.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Location = this.Location;
            loginform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminInterface admin = new adminInterface();
            admin.Location = this.Location;
            admin.Show();
            this.Hide();
        }

        private void contact_Load(object sender, EventArgs e)
        {
            this.connect = new MySqlConnection();
            this.connect.ConnectionString = "server = localhost;uid = root; pwd = ;database = test";
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "C:\\Users\\Yassine\\AppData\\Local\\Programs\\Opera\\launcher.exe",
                Arguments = "mailto:name@email.com"
            });
        }
    }
}
