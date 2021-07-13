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
    public partial class cbxBusqueda : ComboBox
    {
        public cbxBusqueda()
        {
            InitializeComponent();
        }

        private void cbxBusqueda_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode != Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                cbxBusqueda cbx = new cbxBusqueda();
                cbx.Text = "";
            }
        }

        private void cbxBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar( Keys.Back))
            {
                e.Handled = true;
            }
            
        }

        
    }
}
