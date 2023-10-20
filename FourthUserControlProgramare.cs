using ProiectPAW.DataBase;
using ProiectPAW.Entities;
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
    public partial class FourthUserControlProgramare : UserControl
    {
        public FourthUserControlProgramare()
        {
            InitializeComponent();
            comboBox_sectieF.DataSource = Enum.GetValues(typeof(SectieDoctor));
            dgv_programari.DataSource = FakeDataBase.Programari;
        }

        private void btnSalvareF_Click(object sender, EventArgs e)
        {
            var programare = new Programare();
            programare.Nume_Pacient = txtBox_numePacientF.Text;
            programare.Prenume_Pacient = txtBox_prenumePacientF.Text;
            programare.SectieDoctor = (SectieDoctor)comboBox_sectieF.SelectedItem;

            programare.Data_programare = txtBox_dataProgramarePacientF.Text;

            FakeDataBase.Programari.Add(programare);
            dgv_programari.Refresh();
            
           
        }
    }
}
