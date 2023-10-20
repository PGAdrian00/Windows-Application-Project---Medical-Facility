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
    public partial class ThirdUserControlDoctori : UserControl
    {
        private readonly IDoctorRepository _doctorRepository;
        public ThirdUserControlDoctori()
        {
            InitializeComponent();

            dgv_doctori.DataSource = FakeDataBase.Doctori;

            _doctorRepository = new DoctorRepository();

            dgv_doctori.AutoGenerateColumns = false;

            //dgv_doctori.ColumnCount = 4;

           // AddColumn(0, "Nume Doctor ", "Nume Doctor ");
            //AddColumn(1, "Prenume Doctor ", " Prenume Doctor ");
            //AddColumn(2, "Sectie Doctor ", "Sectie Doctor ");
            //AddColumn(3, "Adresa Mail ", "Adresa Mail ");

            AddButtonColumn("editColumn", "", "Edit");
            AddButtonColumn("deleteColumn", "", "Delete");

            dgv_doctori.CellClick += dgv_doctori_CellClick;
        }
        private void AddColumn(int index, string headerText, string propertyName)
        {
            dgv_doctori.Columns[index].HeaderText = headerText;
            dgv_doctori.Columns[index].DataPropertyName = propertyName;
        }

        private void AddButtonColumn(string name, string headerText, string buttonText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = name;
            buttonColumn.Text = buttonText;
            buttonColumn.HeaderText = headerText;
            buttonColumn.UseColumnTextForButtonValue = true;
            dgv_doctori.Columns.Add(buttonColumn);
        }

        private void dgv_doctori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_doctori.Columns["deleteColumn"].Index)
            {
                Doctor currentObject = (Doctor)dgv_doctori.CurrentRow.DataBoundItem;

                _doctorRepository.Sterge(currentObject.id_Doctor);
            }

            if (e.ColumnIndex == dgv_doctori.Columns["editColumn"].Index)
            {
                Doctor currentObject = (Doctor)dgv_doctori.CurrentRow.DataBoundItem;
                var editForm = new EditForm(currentObject.id_Doctor);
                editForm.ShowDialog();
                dgv_doctori.Refresh();
            }
        }
    }
}
