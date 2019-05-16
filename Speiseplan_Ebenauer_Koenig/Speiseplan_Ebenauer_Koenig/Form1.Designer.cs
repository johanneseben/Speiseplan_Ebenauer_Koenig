namespace Speiseplan_Ebenauer_Koenig
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.Seitenpanel = new System.Windows.Forms.Panel();
            this.btnNeuanlage = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnSpeiseplan = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.panelSpeiseplan = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbVorspeise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbHauptspeise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbNachspeise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.benutzersteuerelement_Home1 = new Speiseplan_Ebenauer_Koenig.Benutzersteuerelement_Home();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSpeiseplan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.btnShutdown);
            this.panel1.Controls.Add(this.Seitenpanel);
            this.panel1.Controls.Add(this.btnNeuanlage);
            this.panel1.Controls.Add(this.btnBearbeiten);
            this.panel1.Controls.Add(this.btnSpeiseplan);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 672);
            this.panel1.TabIndex = 0;
            // 
            // btnShutdown
            // 
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown.Location = new System.Drawing.Point(12, 920);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(170, 59);
            this.btnShutdown.TabIndex = 7;
            this.btnShutdown.Text = " Beenden";
            this.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // Seitenpanel
            // 
            this.Seitenpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Seitenpanel.Location = new System.Drawing.Point(3, 188);
            this.Seitenpanel.Name = "Seitenpanel";
            this.Seitenpanel.Size = new System.Drawing.Size(10, 60);
            this.Seitenpanel.TabIndex = 3;
            // 
            // btnNeuanlage
            // 
            this.btnNeuanlage.FlatAppearance.BorderSize = 0;
            this.btnNeuanlage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeuanlage.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuanlage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNeuanlage.Image = ((System.Drawing.Image)(resources.GetObject("btnNeuanlage.Image")));
            this.btnNeuanlage.Location = new System.Drawing.Point(12, 343);
            this.btnNeuanlage.Name = "btnNeuanlage";
            this.btnNeuanlage.Size = new System.Drawing.Size(201, 59);
            this.btnNeuanlage.TabIndex = 6;
            this.btnNeuanlage.Text = "   Neuanlage";
            this.btnNeuanlage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNeuanlage.UseVisualStyleBackColor = true;
            this.btnNeuanlage.Click += new System.EventHandler(this.btnNeuanlage_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.FlatAppearance.BorderSize = 0;
            this.btnBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBearbeiten.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBearbeiten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBearbeiten.Image = ((System.Drawing.Image)(resources.GetObject("btnBearbeiten.Image")));
            this.btnBearbeiten.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBearbeiten.Location = new System.Drawing.Point(15, 420);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(176, 59);
            this.btnBearbeiten.TabIndex = 5;
            this.btnBearbeiten.Text = "  Bearbeiten";
            this.btnBearbeiten.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnSpeiseplan
            // 
            this.btnSpeiseplan.FlatAppearance.BorderSize = 0;
            this.btnSpeiseplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeiseplan.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeiseplan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpeiseplan.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeiseplan.Image")));
            this.btnSpeiseplan.Location = new System.Drawing.Point(12, 266);
            this.btnSpeiseplan.Name = "btnSpeiseplan";
            this.btnSpeiseplan.Size = new System.Drawing.Size(186, 59);
            this.btnSpeiseplan.TabIndex = 4;
            this.btnSpeiseplan.Text = "Speiseplan";
            this.btnSpeiseplan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpeiseplan.UseVisualStyleBackColor = true;
            this.btnSpeiseplan.Click += new System.EventHandler(this.btnSpeiseplan_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 189);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(182, 59);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = " Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 29);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(251, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 164);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speiseplan";
            // 
            // btnYoutube
            // 
            this.btnYoutube.FlatAppearance.BorderSize = 0;
            this.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutube.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYoutube.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYoutube.Image = ((System.Drawing.Image)(resources.GetObject("btnYoutube.Image")));
            this.btnYoutube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoutube.Location = new System.Drawing.Point(521, 84);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(234, 71);
            this.btnYoutube.TabIndex = 6;
            this.btnYoutube.Text = " Gesunde Ernährung";
            this.btnYoutube.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYoutube.UseVisualStyleBackColor = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.FlatAppearance.BorderSize = 0;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogle.Image")));
            this.btnGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoogle.Location = new System.Drawing.Point(843, 84);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(234, 71);
            this.btnGoogle.TabIndex = 7;
            this.btnGoogle.Text = " Gesunde Rezepte";
            this.btnGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // panelSpeiseplan
            // 
            this.panelSpeiseplan.Controls.Add(this.listView1);
            this.panelSpeiseplan.Controls.Add(this.label2);
            this.panelSpeiseplan.Location = new System.Drawing.Point(194, 189);
            this.panelSpeiseplan.Name = "panelSpeiseplan";
            this.panelSpeiseplan.Size = new System.Drawing.Size(1230, 629);
            this.panelSpeiseplan.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.cbVorspeise,
            this.cbHauptspeise,
            this.cbNachspeise});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(199, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(809, 333);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "      Wochentag";
            this.columnHeader1.Width = 200;
            // 
            // cbVorspeise
            // 
            this.cbVorspeise.Text = "Vorspeise";
            this.cbVorspeise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbVorspeise.Width = 200;
            // 
            // cbHauptspeise
            // 
            this.cbHauptspeise.Text = "Hauptspeise";
            this.cbHauptspeise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbHauptspeise.Width = 200;
            // 
            // cbNachspeise
            // 
            this.cbNachspeise.Text = "Nachspeise";
            this.cbNachspeise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbNachspeise.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 55);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dein Speiseplan";
            // 
            // benutzersteuerelement_Home1
            // 
            this.benutzersteuerelement_Home1.Location = new System.Drawing.Point(194, 189);
            this.benutzersteuerelement_Home1.Name = "benutzersteuerelement_Home1";
            this.benutzersteuerelement_Home1.Size = new System.Drawing.Size(1230, 629);
            this.benutzersteuerelement_Home1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 672);
            this.Controls.Add(this.panelSpeiseplan);
            this.Controls.Add(this.benutzersteuerelement_Home1);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.btnYoutube);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speiseplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSpeiseplan.ResumeLayout(false);
            this.panelSpeiseplan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnSpeiseplan;
        private System.Windows.Forms.Button btnNeuanlage;
        private System.Windows.Forms.Panel Seitenpanel;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Button btnGoogle;
        private Benutzersteuerelement_Home benutzersteuerelement_Home1;
        private System.Windows.Forms.Panel panelSpeiseplan;
        internal System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cbVorspeise;
        private System.Windows.Forms.ColumnHeader cbHauptspeise;
        private System.Windows.Forms.ColumnHeader cbNachspeise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

