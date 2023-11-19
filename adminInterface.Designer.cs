namespace pfa
{
    partial class adminInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminInterface));
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            login = new Button();
            admincs1 = new admincs();
            admin_updateuser_1 = new admin_updateuser_();
            button6 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(login);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 458);
            panel1.TabIndex = 30;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.icons8_contact_16__1_;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(34, 106);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 8;
            button4.Text = "contact";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_admin_settings_male_16;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(34, 364);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 22);
            button2.TabIndex = 9;
            button2.Text = "admin panel";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.icons8_about_me_16;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(34, 156);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 7;
            button3.Text = "about us";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.icons8_home_161;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(34, 53);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 2;
            button5.Text = "index";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.FlatAppearance.BorderSize = 0;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = Color.White;
            login.Image = Properties.Resources.icons8_user_161;
            login.ImageAlign = ContentAlignment.MiddleLeft;
            login.Location = new Point(34, 9);
            login.Margin = new Padding(3, 2, 3, 2);
            login.Name = "login";
            login.Size = new Size(82, 22);
            login.TabIndex = 1;
            login.Text = "login";
            login.TextImageRelation = TextImageRelation.ImageBeforeText;
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // admincs1
            // 
            admincs1.BackgroundImage = (Image)resources.GetObject("admincs1.BackgroundImage");
            admincs1.Location = new Point(167, 60);
            admincs1.Margin = new Padding(3, 2, 3, 2);
            admincs1.Name = "admincs1";
            admincs1.Size = new Size(771, 389);
            admincs1.TabIndex = 31;
            // 
            // admin_updateuser_1
            // 
            admin_updateuser_1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            admin_updateuser_1.BackgroundImage = (Image)resources.GetObject("admin_updateuser_1.BackgroundImage");
            admin_updateuser_1.BackgroundImageLayout = ImageLayout.Stretch;
            admin_updateuser_1.Location = new Point(167, 53);
            admin_updateuser_1.Margin = new Padding(3, 2, 3, 2);
            admin_updateuser_1.Name = "admin_updateuser_1";
            admin_updateuser_1.Size = new Size(777, 396);
            admin_updateuser_1.TabIndex = 32;
            admin_updateuser_1.Load += admin_updateuser_1_Load;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Maroon;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(364, 20);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(82, 22);
            button6.TabIndex = 33;
            button6.Text = "delete";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Maroon;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(600, 20);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(82, 22);
            button7.TabIndex = 34;
            button7.Text = "update";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // adminInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4;
            ClientSize = new Size(948, 458);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(admin_updateuser_1);
            Controls.Add(admincs1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "adminInterface";
            Text = "adminInterface";
            Load += adminInterface_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button login;
        private Button button2;
        private admincs admincs1;
        private admin_updateuser_ admin_updateuser_1;
        private Button button6;
        private Button button7;
    }
}