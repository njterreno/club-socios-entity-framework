using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados
{
    public partial class cbxComboSinModif : ComboBox
    {
        public cbxComboSinModif()
        {
            InitializeComponent();
        }
        

        private void cbxComboSinModif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void cbxComboSinModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
