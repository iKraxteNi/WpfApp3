using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class COcena
    {
        public string info { get; set; }
        public float ocena { get; set; }

        public COcena (string info,int ocena)
        {
            this.info = info;
            this.ocena = ocena;
        }
        public COcena()

           : this("",0)
        { }
    }
}
