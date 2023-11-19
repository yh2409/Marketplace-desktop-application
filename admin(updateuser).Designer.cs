namespace pfa
{
    partial class admin_updateuser_
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_updateuser_));
            update = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // update
            // 
            update.AutoSize = true;
            update.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            update.BackColor = Color.Maroon;
            update.BackgroundImage = (Image)resources.GetObject("update.BackgroundImage");
            update.FlatAppearance.BorderSize = 0;
            update.FlatStyle = FlatStyle.Flat;
            update.ForeColor = SystemColors.ButtonHighlight;
            update.Location = new Point(357, 393);
            update.Name = "update";
            update.Size = new Size(66, 30);
            update.TabIndex = 59;
            update.Text = "update";
            update.UseVisualStyleBackColor = false;
            update.Click += signin_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(78, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(651, 342);
            dataGridView1.TabIndex = 60;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // admin_updateuser_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources._4;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(dataGridView1);
            Controls.Add(update);
            DoubleBuffered = true;
            Name = "admin_updateuser_";
            Size = new Size(807, 506);
            Load += admin_updateuser__Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button update;
        private DataGridView dataGridView1;
    }
}
