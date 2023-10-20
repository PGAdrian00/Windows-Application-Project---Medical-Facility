using ProiectPAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Repositories
{
    public interface IPacientRepository
    {
        BindingList<Pacient> GetAll();
        Pacient GetById(Guid id_Pacient);
        void Sterge(Guid id_Pacient);
        void Adauga(Pacient pacient);
    }
}
