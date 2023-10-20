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
    public partial class Form1 : Form
    {
      

        
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = btn_acasa.Height;
            sidePanel.Top = btn_acasa.Top;
            firstUserControlAcasa1.BringToFront();
        }

        private void btn_acasa_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_acasa.Height;
            sidePanel.Top = btn_acasa.Top;
            firstUserControlAcasa1.BringToFront();
        }

        private void btn_pacienti_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_pacienti.Height;
            sidePanel.Top = btn_pacienti.Top;
            secondUserControlPacienti1.BringToFront();
        }

        private void btn_doctori_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_doctori.Height;
            sidePanel.Top = btn_doctori.Top;
            thirdUserControlDoctori1.BringToFront();
        }

        

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_programare_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_programare.Height;
            sidePanel.Top = btn_programare.Top;
            fourthUserControlProgramare1.BringToFront();
        }
    }
}
