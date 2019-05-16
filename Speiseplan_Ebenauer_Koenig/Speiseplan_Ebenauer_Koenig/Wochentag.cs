using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplan_Ebenauer_Koenig
{
    class Wochentag
    {

        public long WID;
        public string Wochtentagname;




        public Wochentag(long wid, string wochentagname)
        {
            WID = wid;
            Wochtentagname = wochentagname;



        }

        public long WochtenagID
        {
            get { return WID; }
            set { WID = value; }
        }
    }
}
