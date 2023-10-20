using ProiectPAW.Entities;
using ProiectPAW.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class EditForm : Form
    {
        private IDoctorRepository _doctorRepository;
        private readonly Guid _idDoctor;

        public EditForm(Guid _id_Doctor)
        {
            InitializeComponent();

            comboBox_sectie.DataSource = Enum.GetValues(typeof(SectieDoctor));


            _doctorRepository = new DoctorRepository();
            _idDoctor = _id_Doctor;

            //var entity = _doctorRepository.GetById(_idDoctor);

            //Text = "Modificare " + entity.Nume_Doctor + " " + entity.Prenume_Doctor + " " + entity.AdresaMail + "...";

            //txtBox_numeDoctor.Text = entity.Nume_Doctor;
            //txtBox_prenumeDoctor.Text = entity.Prenume_Doctor;
            //txtBox_adresaMail.Text = entity.AdresaMail;
            
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {

            var entity = _doctorRepository.GetById(_idDoctor);
            entity.Nume_Doctor = txtBox_numeDoctor.Text;
            entity.Prenume_Doctor = txtBox_prenumeDoctor.Text;
            entity.AdresaMail = txtBox_adresaMail.Text;
            entity.SectieDoctor = (SectieDoctor)comboBox_sectie.SelectedItem;
            this.Hide();
        }
    }
}
