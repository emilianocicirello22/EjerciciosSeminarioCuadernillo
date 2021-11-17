
namespace Ejercicio2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LabNombre = new System.Windows.Forms.Label();
            this.ComboNacionalidad = new System.Windows.Forms.ComboBox();
            this.LabNacionalidad = new System.Windows.Forms.Label();
            this.groupSexo = new System.Windows.Forms.GroupBox();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.BtnAgregarPersona = new System.Windows.Forms.Button();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblCantMuj = new System.Windows.Forms.Label();
            this.LblPorcArgentinos = new System.Windows.Forms.Label();
            this.LblCantMujChilenas = new System.Windows.Forms.Label();
            this.LblCantMujTotal = new System.Windows.Forms.Label();
            this.LblTotalArgentinos = new System.Windows.Forms.Label();
            this.LblResultMjChilenas = new System.Windows.Forms.Label();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.groupSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(243, 69);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(255, 36);
            this.TxtNombre.TabIndex = 3;
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabNombre.Location = new System.Drawing.Point(19, 73);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(85, 28);
            this.LabNombre.TabIndex = 2;
            this.LabNombre.Text = "Nombre";
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
            this.ComboNacionalidad.Location = new System.Drawing.Point(243, 127);
            this.ComboNacionalidad.Name = "ComboNacionalidad";
            this.ComboNacionalidad.Size = new System.Drawing.Size(250, 38);
            this.ComboNacionalidad.TabIndex = 9;
            // 
            // LabNacionalidad
            // 
            this.LabNacionalidad.AutoSize = true;
            this.LabNacionalidad.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabNacionalidad.Location = new System.Drawing.Point(19, 130);
            this.LabNacionalidad.Name = "LabNacionalidad";
            this.LabNacionalidad.Size = new System.Drawing.Size(138, 30);
            this.LabNacionalidad.TabIndex = 10;
            this.LabNacionalidad.Text = "Nacionalidad";
            // 
            // groupSexo
            // 
            this.groupSexo.Controls.Add(this.radioMujer);
            this.groupSexo.Controls.Add(this.radioHombre);
            this.groupSexo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupSexo.Location = new System.Drawing.Point(19, 189);
            this.groupSexo.Name = "groupSexo";
            this.groupSexo.Size = new System.Drawing.Size(283, 83);
            this.groupSexo.TabIndex = 11;
            this.groupSexo.TabStop = false;
            this.groupSexo.Text = "Sexo";
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Location = new System.Drawing.Point(189, 33);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(81, 32);
            this.radioMujer.TabIndex = 14;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "Mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Location = new System.Drawing.Point(36, 33);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(102, 32);
            this.radioHombre.TabIndex = 13;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "Hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarPersona
            // 
            this.BtnAgregarPersona.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnAgregarPersona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarPersona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregarPersona.Location = new System.Drawing.Point(325, 220);
            this.BtnAgregarPersona.Name = "BtnAgregarPersona";
            this.BtnAgregarPersona.Size = new System.Drawing.Size(211, 41);
            this.BtnAgregarPersona.TabIndex = 12;
            this.BtnAgregarPersona.Text = "Agregar persona";
            this.BtnAgregarPersona.UseVisualStyleBackColor = false;
            this.BtnAgregarPersona.Click += new System.EventHandler(this.BtnAgregarPersona_Click);
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Nacionalidad,
            this.Sexo});
            this.dtgvDatos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDatos.Location = new System.Drawing.Point(130, 291);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.RowTemplate.Height = 25;
            this.dtgvDatos.Size = new System.Drawing.Size(343, 121);
            this.dtgvDatos.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCerrar.Location = new System.Drawing.Point(433, 598);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(103, 37);
            this.BtnCerrar.TabIndex = 14;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblCantMuj
            // 
            this.LblCantMuj.AutoSize = true;
            this.LblCantMuj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantMuj.Location = new System.Drawing.Point(19, 442);
            this.LblCantMuj.Name = "LblCantMuj";
            this.LblCantMuj.Size = new System.Drawing.Size(156, 21);
            this.LblCantMuj.TabIndex = 15;
            this.LblCantMuj.Text = "Cantidad de mujeres:";
            // 
            // LblPorcArgentinos
            // 
            this.LblPorcArgentinos.AutoSize = true;
            this.LblPorcArgentinos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPorcArgentinos.Location = new System.Drawing.Point(19, 491);
            this.LblPorcArgentinos.Name = "LblPorcArgentinos";
            this.LblPorcArgentinos.Size = new System.Drawing.Size(129, 21);
            this.LblPorcArgentinos.TabIndex = 16;
            this.LblPorcArgentinos.Text = "% De Argentinos:";
            // 
            // LblCantMujChilenas
            // 
            this.LblCantMujChilenas.AutoSize = true;
            this.LblCantMujChilenas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantMujChilenas.Location = new System.Drawing.Point(19, 534);
            this.LblCantMujChilenas.Name = "LblCantMujChilenas";
            this.LblCantMujChilenas.Size = new System.Drawing.Size(219, 21);
            this.LblCantMujChilenas.TabIndex = 17;
            this.LblCantMujChilenas.Text = "Cantidad de mujeres Chilenas:";
            // 
            // LblCantMujTotal
            // 
            this.LblCantMujTotal.AutoSize = true;
            this.LblCantMujTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantMujTotal.Location = new System.Drawing.Point(253, 442);
            this.LblCantMujTotal.Name = "LblCantMujTotal";
            this.LblCantMujTotal.Size = new System.Drawing.Size(19, 21);
            this.LblCantMujTotal.TabIndex = 18;
            this.LblCantMujTotal.Text = "0";
            // 
            // LblTotalArgentinos
            // 
            this.LblTotalArgentinos.AutoSize = true;
            this.LblTotalArgentinos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalArgentinos.Location = new System.Drawing.Point(253, 491);
            this.LblTotalArgentinos.Name = "LblTotalArgentinos";
            this.LblTotalArgentinos.Size = new System.Drawing.Size(19, 21);
            this.LblTotalArgentinos.TabIndex = 19;
            this.LblTotalArgentinos.Text = "0";
            // 
            // LblResultMjChilenas
            // 
            this.LblResultMjChilenas.AutoSize = true;
            this.LblResultMjChilenas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResultMjChilenas.Location = new System.Drawing.Point(253, 534);
            this.LblResultMjChilenas.Name = "LblResultMjChilenas";
            this.LblResultMjChilenas.Size = new System.Drawing.Size(19, 21);
            this.LblResultMjChilenas.TabIndex = 20;
            this.LblResultMjChilenas.Text = "0";
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.BackColor = System.Drawing.Color.Teal;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEstadisticas.Location = new System.Drawing.Point(424, 467);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Size = new System.Drawing.Size(112, 69);
            this.BtnEstadisticas.TabIndex = 21;
            this.BtnEstadisticas.Text = "Calcular estadisticas";
            this.BtnEstadisticas.UseVisualStyleBackColor = false;
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 647);
            this.Controls.Add(this.BtnEstadisticas);
            this.Controls.Add(this.LblResultMjChilenas);
            this.Controls.Add(this.LblTotalArgentinos);
            this.Controls.Add(this.LblCantMujTotal);
            this.Controls.Add(this.LblCantMujChilenas);
            this.Controls.Add(this.LblPorcArgentinos);
            this.Controls.Add(this.LblCantMuj);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.BtnAgregarPersona);
            this.Controls.Add(this.groupSexo);
            this.Controls.Add(this.ComboNacionalidad);
            this.Controls.Add(this.LabNacionalidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LabNombre);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupSexo.ResumeLayout(false);
            this.groupSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.ComboBox ComboNacionalidad;
        private System.Windows.Forms.Label LabNacionalidad;
        private System.Windows.Forms.GroupBox groupSexo;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.Button BtnAgregarPersona;
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblCantMuj;
        private System.Windows.Forms.Label LblPorcArgentinos;
        private System.Windows.Forms.Label LblCantMujChilenas;
        private System.Windows.Forms.Label LblCantMujTotal;
        private System.Windows.Forms.Label LblTotalArgentinos;
        private System.Windows.Forms.Label LblResultMjChilenas;
        private System.Windows.Forms.Button BtnEstadisticas;
    }
}