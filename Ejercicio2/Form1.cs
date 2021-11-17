using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Formulario : Form
    {

        bool extranjero;

        public Formulario()
        {
            InitializeComponent();
        }

        public void Extrangero()
        {
            if (ComboNacionalidad.Text.Equals("Argentina"))
            {
                ChExtrangero.Checked = false;
                this.extranjero = false;
            }
            else
            {
                ChExtrangero.Checked = true;
                this.extranjero = true;

            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            Extrangero();
            MessageBox.Show($"Nombre {TxtNombre.Text} se registro el {dateFechaIngreso.Text} su nacionalidad es {ComboNacionalidad.Text} Es extranjero? {(this.extranjero ? "si" : "no")} ");
        }

        
    }
}
