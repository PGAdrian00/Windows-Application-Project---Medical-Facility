using ProiectPAW.DataBase;
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
    public partial class PacientiForm : Form
    {
        private readonly IPacientRepository _pacientRepository;
        public PacientiForm()
        {
            InitializeComponent();
            dgv_pacienti.DataSource = FakeDataBase.Pacienti;

            _pacientRepository = new PacientRepository();

            dgv_pacienti.AutoGenerateColumns = false;

            //dgv_pacienti.ColumnCount = 3;

            AddColumn(0, "Nume_Pacient", "Nume_Pacient");
            AddColumn(1, "Prenume_Pacient", "Prenume_Pacient");
            AddColumn(2, "Telefon_Pacient", "Telefon_Pacient");

            AddButtonColumn("editColumn_pacient", "", "Edit");
            AddButtonColumn("deleteColumn_pacient", "", "Delete");

        }
        private void AddColumn(int index, string headerText, string propertyName)
        {
            dgv_pacienti.Columns[index].HeaderText = headerText;
            dgv_pacienti.Columns[index].DataPropertyName = propertyName;
        }

        private void AddButtonColumn(string name, string headerText, string buttonText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = name;
            buttonColumn.Text = buttonText;
            buttonColumn.HeaderText = headerText;
            buttonColumn.UseColumnTextForButtonValue = true;
            dgv_pacienti.Columns.Add(buttonColumn);
        }

        private void dgv_pacienti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_pacienti.Columns["deleteColumn_pacient"].Index)
            {
                Pacient currentObject = (Pacient)dgv_pacienti.CurrentRow.DataBoundItem;

                _pacientRepository.Sterge(currentObject.id_Pacient);
            }

            if (e.ColumnIndex == dgv_pacienti.Columns["editColumn_pacient"].Index)
            {
                Pacient currentObject = (Pacient)dgv_pacienti.CurrentRow.DataBoundItem;
                var editPacientForm = new EditPacientForm(currentObject.id_Pacient);
                editPacientForm.ShowDialog();
                dgv_pacienti.Refresh();
            }
        }
    }
}
