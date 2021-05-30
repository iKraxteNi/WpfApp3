using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int NrIndeksu { get; set; }
        public string wydzial { get; set; }
        public List<COcena> Oceny { get; set; }
       

        
        

        public Student(string imie,string nazwisko, int NrIndeksu, string wydzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.NrIndeksu = NrIndeksu;
            this.wydzial = wydzial;
            this.Oceny = new List<COcena>();
             



        }

        public Student()
        
            : this("", "", 0,"")
         { }

       
        
    }
}

