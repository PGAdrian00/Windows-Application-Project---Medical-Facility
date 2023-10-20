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
    public partial class EditPacientForm : Form
    {
        private IPacientRepository _pacientRepository;
        private readonly Guid _idPacient;
        public EditPacientForm(Guid id_Pacient)
        {
            InitializeComponent();

            _pacientRepository = new PacientRepository();
            _idPacient = id_Pacient;

            //var entity = _pacientRepository.GetById(_idPacient);
        }

        private void btnSalvare_Pacient_Click(object sender, EventArgs e)
        {
            var entity = _pacientRepository.GetById(_idPacient);
            entity.Nume_Pacient = txtBox_numePacient.Text;
            entity.Prenume_Pacient = txtBox_prenumePacient.Text;
            entity.telefon_pacient = txtBox_telefon_Pacient.Text;
            this.Hide();
        }
    }
}
