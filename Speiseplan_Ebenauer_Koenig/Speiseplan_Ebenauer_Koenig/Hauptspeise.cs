using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplan_Ebenauer_Koenig
{
    class Hauptspeise
    {
        public long HID;
        public string Hauptspeisename;
        



        public Hauptspeise(long hid, string hauptspeisename)
        {
            HID = hid;
            Hauptspeisename = hauptspeisename;

            

        }

        public long HauptspeiseID
        {
            get { return HID; }
            set { HID = value; }
        }
    }
}
