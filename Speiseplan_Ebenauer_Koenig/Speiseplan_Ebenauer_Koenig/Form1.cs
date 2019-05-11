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
        }

        private void btnshutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnHome.Top;
        }

        private void btnSpeiseplan_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnSpeiseplan.Top;
        }

        private void btnNeuanlage_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnNeuanlage.Top;
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnBearbeiten.Top;
        }
    }
}
