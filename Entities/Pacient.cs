using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Entities
{
    public class Pacient
    {
        public Guid id_Pacient { get; set; }
        public string Nume_Pacient { get; set; }
        public string Prenume_Pacient { get; set; }
        public string telefon_pacient { get; set; }
    }
}
