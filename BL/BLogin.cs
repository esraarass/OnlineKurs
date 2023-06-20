using OnlineKurs.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKurs.BL
{
    public static class BLogin
    {

        public static int UyeEkle(Uye m)

        {
            return DataLayer.UyeEkle(m);

        }
    }
}
