using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplan_Ebenauer_Koenig
{
    class Nachspeise
    {
        public long NID;
        public string Nachspeisename;
        


        public Nachspeise(long nid, string nachspeisename)
        {
            NID = nid;
            Nachspeisename = nachspeisename;
            

        }

        public long NachspeiseID
        {
            get { return NID; }
            set { NID = value; }
        }
    }
}
