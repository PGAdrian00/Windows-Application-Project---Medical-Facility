using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Entities
{
    public class Doctor
    {
        public Guid id_Doctor { get; set; }
        public string Nume_Doctor { get; set; }
        public string Prenume_Doctor { get; set; }

        public SectieDoctor SectieDoctor { get; set; }

        public string AdresaMail { get; set; }
    }
}
