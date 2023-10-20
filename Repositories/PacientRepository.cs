using ProiectPAW.DataBase;
using ProiectPAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Repositories
{
    public class PacientRepository : IPacientRepository
    {
        public void Adauga(Pacient pacient)
        {
            FakeDataBase.Pacienti.Add(pacient);
        }

        public BindingList<Pacient> GetAll()
        {
            return FakeDataBase.Pacienti;
        }

        public Pacient GetById(Guid _id_Pacient)
        {
            foreach (var pacient in FakeDataBase.Pacienti)
            {
                if (pacient.id_Pacient == _id_Pacient)
                    return pacient;
            }
            return null;
        }

        public void Sterge(Guid id_Pacient)
        {
            var pacient = GetById(id_Pacient);
            if (pacient != null)
                FakeDataBase.Pacienti.Remove(pacient);
        }
    }
}
