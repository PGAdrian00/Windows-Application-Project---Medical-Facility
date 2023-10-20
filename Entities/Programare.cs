using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Entities
{
    public class Programare
    {
        public string Nume_Pacient { get; set; }
        public string Prenume_Pacient { get; set; }
        public SectieDoctor SectieDoctor { get; set; }
        public string Data_programare {get; set;}
    }
}
