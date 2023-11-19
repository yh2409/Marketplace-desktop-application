using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pfa
{
    public partial class adminInterface : Form
    {
        public adminInterface()
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

        private void button2_Click(object sender, EventArgs e)
        {
            adminInterface admin = new adminInterface();
            admin.Location = this.Location;
            admin.Show();
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
            index index = new index();
            index.Location = this.Location;
            index.Show();
            this.Hide();
        }

        private void admin_updateuser_1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            admincs1.BringToFront();
            admincs1.Show();
            admin_updateuser_1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin_updateuser_1.BringToFront();
            admin_updateuser_1.Show();
            admincs1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contact contact = new contact();
            contact.Location = this.Location;
            contact.Show();
            this.Hide();
        }

        private void adminInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
