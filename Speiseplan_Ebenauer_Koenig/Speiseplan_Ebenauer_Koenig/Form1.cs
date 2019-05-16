using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace Speiseplan_Ebenauer_Koenig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            benutzersteuerelement_Home1.BringToFront();
        }


        ListViewItem lvItem;
        Datenbank db;
        internal OleDbDataReader dr;
        internal OleDbCommand cmd;
        string sql;
        internal OleDbConnection verbindung;

        List<Vorspeise> vorspeiseliste;
        List<Hauptspeise> hauptspeiseliste;
        List<Nachspeise> nachspeiseliste;
        List<Wochentag> wochentagliste;
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnHome.Top;
            benutzersteuerelement_Home1.BringToFront();
            
        }

        private void btnSpeiseplan_Click(object sender, EventArgs e)
        {
            Seitenpanel.Top = btnSpeiseplan.Top;
            panelSpeiseplan.BringToFront();
            einlesenVorspeisenausDatenbankinVorspeiseliste();
            einlesenHauptspeisenausDatenbankinHauptspeiseliste();
            einlesenNachspeisenausDatenbankinNachspeiseliste();
            einlesenWochentagausDatenbankinWochtenagliste();
            einlesenderDateninListView();
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


            vorspeiseliste = new List<Vorspeise>();
            hauptspeiseliste = new List<Hauptspeise>();
            nachspeiseliste = new List<Nachspeise>();
            wochentagliste = new List<Wochentag>();
            db = new Datenbank();

            
        }

        internal void einlesenVorspeisenausDatenbankinVorspeiseliste()
        {
            dr = db.Einlesen("Select * from Vorspeise");
            cmd = new OleDbCommand();
            vorspeiseliste.Clear();
            while (dr.Read())
            {
                vorspeiseliste.Add(new Vorspeise(Convert.ToInt64(dr[0]), dr[1].ToString()));
            }
        }

        internal void einlesenHauptspeisenausDatenbankinHauptspeiseliste()
        {
            dr = db.Einlesen("Select * from Hauptspeise");
            cmd = new OleDbCommand();
            hauptspeiseliste.Clear();
            while (dr.Read())
            {
                hauptspeiseliste.Add(new Hauptspeise(Convert.ToInt64(dr[0]), dr[1].ToString()));
            }
        }

        internal void einlesenNachspeisenausDatenbankinNachspeiseliste()
        {
            dr = db.Einlesen("Select * from Nachspeise");
            cmd = new OleDbCommand();
            nachspeiseliste.Clear();
            while (dr.Read())
            {
                nachspeiseliste.Add(new Nachspeise(Convert.ToInt64(dr[0]), dr[1].ToString()));
            }
        }

        internal void einlesenWochentagausDatenbankinWochtenagliste()
        {
            dr = db.Einlesen("Select * from Wochentage");
            cmd = new OleDbCommand();
            wochentagliste.Clear();
            while (dr.Read())
            {
                wochentagliste.Add(new Wochentag(Convert.ToInt64(dr[0]), dr[1].ToString()));
            }
        }

        internal void einlesenderDateninListView()
        {

            listView1.Items.Clear();
            
            int i = 0;
            while (i < 5)
            {


                //lvItem = new ListViewItem(.ToString());
                //lvItem.SubItems.Add(dr[1].ToString());             //Spalten in der Datenbank (1: vid, 2: vorspeisename, 3: hid ...)
                //lvItem.SubItems.Add(dr[3].ToString());
                //lvItem.SubItems.Add(dr[5].ToString());
                lvItem = new ListViewItem(wochentagliste[i].Wochtentagname);
                lvItem.SubItems.Add(vorspeiseliste[i].Vorspeisename);
                lvItem.SubItems.Add(hauptspeiseliste[i].Hauptspeisename);
            lvItem.SubItems.Add(nachspeiseliste[i].Nachspeisename);


            listView1.FullRowSelect = true;
            listView1.Items.Add(lvItem);
                i++;

        }

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
