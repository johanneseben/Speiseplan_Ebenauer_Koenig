using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Speiseplan_Ebenauer_Koenig
{
    class Datenbank
    {
        string cn;
        OleDbConnection verbindung;
        OleDbCommand cmd;

        //Konstruktor

        public Datenbank()
        {
            cn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Speiseplan.accdb";
            verbindung = new OleDbConnection(cn);

        }

        public OleDbDataReader Einlesen(string sql)
        {
            try
            {
                verbindung.Close();
                verbindung.Open();
                cmd = new OleDbCommand(sql, verbindung);

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen: " + ex.Message);
            }
        }

        internal void executeQuery(OleDbCommand cmd)
        {
            try
            {
                cmd.Connection = verbindung;
                verbindung.Close();
                verbindung.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Ausführen: " + ex.Message);
            }
        }
    
}
}
