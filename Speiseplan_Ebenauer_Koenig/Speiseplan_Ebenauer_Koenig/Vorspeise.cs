using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplan_Ebenauer_Koenig
{
    class Vorspeise
    {
        public long VID;
        public string Vorspeisename;

        public Vorspeise(long vid, string vorspeisename)
        {
            VID = vid;
            Vorspeisename = vorspeisename;
           

        }

        public long VorspeiseID
        {
            get { return VID; }
            set { VID = value; }
        }


    }
}
