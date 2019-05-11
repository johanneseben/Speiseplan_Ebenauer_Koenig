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
            this.Seitenpanel = new System.Windows.Forms.Panel();
            this.btnNeuanlage = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnSpeiseplan = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnshutdown = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
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
            // Seitenpanel
            // 
            this.Seitenpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Seitenpanel.Location = new System.Drawing.Point(3, 170);
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
            this.btnNeuanlage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNeuanlage.Location = new System.Drawing.Point(23, 325);
            this.btnNeuanlage.Name = "btnNeuanlage";
            this.btnNeuanlage.Size = new System.Drawing.Size(184, 59);
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
            this.btnBearbeiten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBearbeiten.Location = new System.Drawing.Point(23, 402);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(170, 59);
            this.btnBearbeiten.TabIndex = 5;
            this.btnBearbeiten.Text = "   Bearbeiten";
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
            this.btnSpeiseplan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeiseplan.Location = new System.Drawing.Point(17, 245);
            this.btnSpeiseplan.Name = "btnSpeiseplan";
            this.btnSpeiseplan.Size = new System.Drawing.Size(177, 59);
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
            this.btnHome.Location = new System.Drawing.Point(12, 171);
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
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 21);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(251, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 164);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
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
            this.label1.Location = new System.Drawing.Point(11, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speiseplan";
            // 
            // btnshutdown
            // 
            this.btnshutdown.FlatAppearance.BorderSize = 0;
            this.btnshutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshutdown.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshutdown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnshutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnshutdown.Image")));
            this.btnshutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshutdown.Location = new System.Drawing.Point(997, 27);
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.Size = new System.Drawing.Size(58, 51);
            this.btnshutdown.TabIndex = 7;
            this.btnshutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnshutdown.UseVisualStyleBackColor = true;
            this.btnshutdown.Click += new System.EventHandler(this.btnshutdown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 672);
            this.Controls.Add(this.btnshutdown);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speiseplan";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnshutdown;
    }
}

