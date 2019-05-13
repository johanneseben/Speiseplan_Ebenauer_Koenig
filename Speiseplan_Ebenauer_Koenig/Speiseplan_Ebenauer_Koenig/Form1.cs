using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speiseplan_Ebenauer_Koenig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            benutzersteuerelement_Home1.BringToFront();
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnHome.Top;
            benutzersteuerelement_Home1.BringToFront();
            
        }

        private void btnSpeiseplan_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnSpeiseplan.Top;
            benutzersteuerelement_Speiseplan1.BringToFront();

        }

        private void btnNeuanlage_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnNeuanlage.Top;
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnBearbeiten.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = new Point(0, 0);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=W7oeoOAxpSs/");
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gesundheit.gv.at/leben/ernaehrung/gesunde-rezepte/inhalt/");
        }
    }
}
