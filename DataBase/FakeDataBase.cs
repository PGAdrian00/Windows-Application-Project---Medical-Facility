using ProiectPAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.DataBase
{
    public static class FakeDataBase
    {
        public static BindingList<Doctor> Doctori = new BindingList<Doctor>()
        {
            new Doctor() { id_Doctor= Guid.NewGuid(), Nume_Doctor = "Pascale ", Prenume_Doctor="George-Adrian", SectieDoctor = SectieDoctor.ORL , AdresaMail="pga@aigrijamedical.com "},
            new Doctor() { id_Doctor= Guid.NewGuid(), Nume_Doctor = "Ionescu ", Prenume_Doctor="Vlad", SectieDoctor = SectieDoctor.Cardiologie , AdresaMail="iv@aigrijamedical.com "},
            new Doctor() { id_Doctor= Guid.NewGuid(), Nume_Doctor = "Zavera ", Prenume_Doctor="Adrian", SectieDoctor = SectieDoctor.Ortopedie , AdresaMail="za@aigrijamedical.com "},
            new Doctor() { id_Doctor= Guid.NewGuid(), Nume_Doctor = "Leonida ", Prenume_Doctor="Vlad", SectieDoctor = SectieDoctor.Chirurgie , AdresaMail="lv@aigrijamedical.com "},
            new Doctor() { id_Doctor= Guid.NewGuid(), Nume_Doctor = "Andrei ", Prenume_Doctor="Catalin", SectieDoctor = SectieDoctor.Oftalmologie , AdresaMail="ac@aigrijamedical.com "},
            new Doctor() { id_Doctor= Guid.NewGuid(), Nume_Doctor = "Doctorescu ", Prenume_Doctor="Doctoricescu", SectieDoctor = SectieDoctor.RMN , AdresaMail="dd@aigrijamedical.com "},
        };

        public static BindingList<Pacient> Pacienti = new BindingList<Pacient>()
        {
            new Pacient() {id_Pacient= Guid.NewGuid(), Nume_Pacient = "Andreescu", Prenume_Pacient="Giulia", telefon_pacient="0755142369"},
            new Pacient() {id_Pacient= Guid.NewGuid(), Nume_Pacient = "Boteanu", Prenume_Pacient="Cristian", telefon_pacient="0755144159"},
            new Pacient() {id_Pacient= Guid.NewGuid(), Nume_Pacient = "Grigorescu", Prenume_Pacient="Georgiana", telefon_pacient="0755169569"},
            new Pacient() {id_Pacient= Guid.NewGuid(), Nume_Pacient = "Macaveiu", Prenume_Pacient="Matei", telefon_pacient="0775342369"},
            new Pacient() {id_Pacient= Guid.NewGuid(), Nume_Pacient = "Dumitru", Prenume_Pacient="Sabin", telefon_pacient="0795621369"},
            new Pacient() {id_Pacient= Guid.NewGuid(), Nume_Pacient = "Agapie", Prenume_Pacient="Ana", telefon_pacient="0730248369"},
        };

        public static List<Programare> Programari = new List<Programare>()
        {
            new Programare() { Nume_Pacient ="Andreescu", Prenume_Pacient="Giulia", SectieDoctor=SectieDoctor.Chirurgie, Data_programare="yyyy-mm-dd"},
            new Programare() { Nume_Pacient ="Boteanu", Prenume_Pacient="Cristian", SectieDoctor=SectieDoctor.Cardiologie, Data_programare="yyyy-mm-dd"},
            new Programare() { Nume_Pacient ="Grigorescu", Prenume_Pacient="Georgiana", SectieDoctor=SectieDoctor.Oftalmologie, Data_programare="yyyy-mm-dd"},
            new Programare() { Nume_Pacient ="Macaveiu", Prenume_Pacient="Matei", SectieDoctor=SectieDoctor.ORL, Data_programare="yyyy-mm-dd"},
            new Programare() { Nume_Pacient ="Dumitru", Prenume_Pacient="Sabin", SectieDoctor=SectieDoctor.Ortopedie, Data_programare="yyyy-mm-dd"},
            new Programare() { Nume_Pacient ="Agapie", Prenume_Pacient="Ana", SectieDoctor=SectieDoctor.RMN, Data_programare="yyyy-mm-dd"},
        };
    }
}
