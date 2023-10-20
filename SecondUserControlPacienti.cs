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
    public partial class SecondUserControlPacienti : UserControl
    {
        public SecondUserControlPacienti()
        {
            InitializeComponent();
            
        }

        private void btn_info_pacienti_Click(object sender, EventArgs e)
        {
            var pacientiForm = new PacientiForm();
            pacientiForm.ShowDialog();







        }
    }
}
