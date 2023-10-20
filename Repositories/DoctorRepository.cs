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
     public class DoctorRepository : IDoctorRepository
    {
        public BindingList<Doctor> GetAll()
        {
            return FakeDataBase.Doctori;
        }
        public void Adauga(Doctor doctor)
        {
            FakeDataBase.Doctori.Add(doctor);
        }

        
        public Doctor GetById(Guid _id_Doctor)
        {
            foreach(var doctor in FakeDataBase.Doctori)
            {
                if (doctor.id_Doctor == _id_Doctor)
                    return doctor;
            }
            return null;
        }

        public void Sterge(Guid id_Doctor)
        {
            var doctor = GetById(id_Doctor);
            if (doctor != null)
                FakeDataBase.Doctori.Remove(doctor);
        }

      
    }
}
