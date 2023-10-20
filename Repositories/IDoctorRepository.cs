using ProiectPAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Repositories
{
    public interface IDoctorRepository
    {
        BindingList<Doctor> GetAll();
        Doctor GetById(Guid id_Doctor);
        void Sterge(Guid id_Doctor);
        void Adauga(Doctor doctor);
    }
}
