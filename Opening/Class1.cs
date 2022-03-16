using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opening
{
    class Class1
    {
        public string EredetiCím { get; set; }
        public string MagyarCím { get; set; }
        public DateTime bemutato { get; set; }
        public string forgalmazó { get; set; }
        public int bevel { get; set; }
        public int latogato { get; set; }


        public Class1(string sor)
        {
            string[] t= sor.Split(';');
            EredetiCím = t[0];
            MagyarCím = t[1];
            bemutato = Convert.ToDateTime(t[2]);
            forgalmazó = t[3];
            bevel = int.Parse(t[4]);
            latogato = int.Parse(t[5]);

        }
    }
}
