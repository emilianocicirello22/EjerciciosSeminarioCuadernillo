using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form3 : Form
    {
        int contGeneral = 0;
        int contMujeres = 0;
        int contMujeresChilenas = 0;
        int contArgentinos = 0;

        private string sexo = "";
        bool validacionDatosTex;
        bool validacionDatosSex;

        public Form3()
        {
            InitializeComponent();
        }

        public void ValidarCampos()
        {


            if (TxtNombre.Text.Equals("") || ComboNacionalidad.Text.Equals(""))
            {

                this.validacionDatosTex = true;
            }
            else
            {
                this.validacionDatosTex = false;
                
            }

            foreach (Control cont in this.groupSexo.Controls)
            {
                if (cont is RadioButton)
                {
                    RadioButton chequear = cont as RadioButton;
                    if (chequear.Checked)
                    {
                        this.sexo = chequear.Text;
                    }

                }
            }

            if (this.sexo.Equals(""))
            {

                this.validacionDatosSex = true;
            }
            else
            {
                this.validacionDatosSex = false;
            }

        }

        public void LimpiarForm()
        {
            TxtNombre.Text = "";            
            this.sexo = "";
            ComboNacionalidad.SelectedIndex = -1;

            foreach (Control ctr in this.groupSexo.Controls)
            {
                if (ctr is RadioButton)
                {
                    RadioButton rad = ctr as RadioButton;
                    if (rad.Checked)
                    {
                        rad.Checked = false;
                    }
                }
            }
            TxtNombre.Focus();
        }

        public void ContabilizarDatos()
        {
            contGeneral++;

            if (radioMujer.Checked)
            {
                contMujeres++;

                if (ComboNacionalidad.SelectedIndex == 2 && radioMujer.Checked)
                {
                    contMujeresChilenas++;
                }
            }

            if(ComboNacionalidad.SelectedIndex == 0)
            {
                contArgentinos++;
            }         
            
        }

        public void CargarDatosGrilla()
        {
            int n = dtgvDatos.Rows.Add();

            dtgvDatos.Rows[n].Cells[0].Value = TxtNombre.Text;
            dtgvDatos.Rows[n].Cells[1].Value = ComboNacionalidad.Text;
            dtgvDatos.Rows[n].Cells[2].Value = this.sexo;
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarPersona_Click(object sender, EventArgs e)
        {
            ValidarCampos();

            if (this.validacionDatosTex || this.validacionDatosSex)
            {
                MessageBox.Show("Cargue todos los datos del formulario", "Datos incompletos",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            else
            {
                CargarDatosGrilla();
                ContabilizarDatos();
                LimpiarForm();
            }
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            LblCantMujTotal.Text = $"{contMujeres}";
            LblTotalArgentinos.Text = $"{(float)(contArgentinos * 100) / contGeneral}";
            LblResultMjChilenas.Text = $"{contMujeresChilenas}";
        }
    }
}
