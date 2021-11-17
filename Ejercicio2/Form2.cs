using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form2 : Form
    {
        private string sexo = "";
        private string estadoCivil = "";

        bool validacionDatosTex;
        bool validacionDatosSex;
        public Form2()
        {
            InitializeComponent();
        }

        

        private void BtnAgregarPersona_Click_1(object sender, EventArgs e)
        {
            ValidarCampos();
            if (this.validacionDatosTex || this.validacionDatosSex)
            {
                LabEstado.ForeColor = System.Drawing.Color.Red;
                LabEstado.Text = "Olvido Cargar Datos";
            }
            else
            {
                //funcion de cargar datos en la grilla
                LabEstado.ForeColor = System.Drawing.Color.Blue;
                LabEstado.Text = "Carga en proceso";
                CargarDatosGrilla();
                LimpiarForm();

                
            }
        }

        public void CargarDatosGrilla()
        {
            int n = dtgvDatos.Rows.Add();

            dtgvDatos.Rows[n].Cells[0].Value = TxtNombre.Text;
            dtgvDatos.Rows[n].Cells[1].Value = dateFechaIngreso.Text;
            dtgvDatos.Rows[n].Cells[2].Value = this.estadoCivil;
            dtgvDatos.Rows[n].Cells[3].Value = this.sexo;
            dtgvDatos.Rows[n].Cells[4].Value = (ChExtrangero.Checked ? "Si" : "No");
        }

        public void ValidarCampos()
        {


            if (TxtNombre.Text.Equals("") || ComboEstadoCivil.Text.Equals(""))
            {

                this.validacionDatosTex = true;
            }
            else
            {
                this.validacionDatosTex = false;
                this.estadoCivil = ComboEstadoCivil.Text;
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
            dateFechaIngreso.Value = DateTime.Now;
            this.estadoCivil = "";
            this.sexo = "";
            ChExtrangero.Checked = false;
            ComboEstadoCivil.SelectedIndex = -1;

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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
