
namespace Ejercicio2
{
    partial class Formulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabNombre = new System.Windows.Forms.Label();
            this.LabFecha = new System.Windows.Forms.Label();
            this.LabNacionalidad = new System.Windows.Forms.Label();
            this.ChExtrangero = new System.Windows.Forms.CheckBox();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.dateFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.ComboNacionalidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabNombre.Location = new System.Drawing.Point(102, 55);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(94, 30);
            this.LabNombre.TabIndex = 0;
            this.LabNombre.Text = "Nombre";
            // 
            // LabFecha
            // 
            this.LabFecha.AutoSize = true;
            this.LabFecha.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabFecha.Location = new System.Drawing.Point(102, 142);
            this.LabFecha.Name = "LabFecha";
            this.LabFecha.Size = new System.Drawing.Size(181, 30);
            this.LabFecha.TabIndex = 7;
            this.LabFecha.Text = "Fecha de registro";
            // 
            // LabNacionalidad
            // 
            this.LabNacionalidad.AutoSize = true;
            this.LabNacionalidad.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabNacionalidad.Location = new System.Drawing.Point(102, 225);
            this.LabNacionalidad.Name = "LabNacionalidad";
            this.LabNacionalidad.Size = new System.Drawing.Size(138, 30);
            this.LabNacionalidad.TabIndex = 8;
            this.LabNacionalidad.Text = "Nacionalidad";
            // 
            // ChExtrangero
            // 
            this.ChExtrangero.AutoSize = true;
            this.ChExtrangero.Enabled = false;
            this.ChExtrangero.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChExtrangero.Location = new System.Drawing.Point(602, 246);
            this.ChExtrangero.Name = "ChExtrangero";
            this.ChExtrangero.Size = new System.Drawing.Size(138, 29);
            this.ChExtrangero.TabIndex = 4;
            this.ChExtrangero.Text = "Es extrangero";
            this.ChExtrangero.UseVisualStyleBackColor = true;
            
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarDatos.Location = new System.Drawing.Point(289, 358);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(224, 52);
            this.btnMostrarDatos.TabIndex = 5;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaIngreso.Location = new System.Drawing.Point(318, 148);
            this.dateFechaIngreso.MaxDate = new System.DateTime(2021, 9, 7, 0, 0, 0, 0);
            this.dateFechaIngreso.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Size = new System.Drawing.Size(154, 34);
            this.dateFechaIngreso.TabIndex = 2;
            this.dateFechaIngreso.Value = new System.DateTime(2021, 9, 7, 0, 0, 0, 0);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(318, 55);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(255, 36);
            this.TxtNombre.TabIndex = 1;
            // 
            // ComboNacionalidad
            // 
            this.ComboNacionalidad.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboNacionalidad.FormattingEnabled = true;
            this.ComboNacionalidad.Items.AddRange(new object[] {
            "Argentina",
            "Brasileña",
            "Chilena",
            "Uruguaya"});
            this.ComboNacionalidad.Location = new System.Drawing.Point(322, 239);
            this.ComboNacionalidad.Name = "ComboNacionalidad";
            this.ComboNacionalidad.Size = new System.Drawing.Size(250, 38);
            this.ComboNacionalidad.TabIndex = 3;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboNacionalidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.dateFechaIngreso);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.ChExtrangero);
            this.Controls.Add(this.LabNacionalidad);
            this.Controls.Add(this.LabFecha);
            this.Controls.Add(this.LabNombre);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.Label LabFecha;
        private System.Windows.Forms.Label LabNacionalidad;
        private System.Windows.Forms.CheckBox ChExtrangero;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.DateTimePicker dateFechaIngreso;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox ComboNacionalidad;
    }
}

