
namespace Ejercicio2
{
    partial class Form2
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
            this.LabTitulo = new System.Windows.Forms.Label();
            this.LabNombre = new System.Windows.Forms.Label();
            this.LabFecha = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.dateFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.ChExtrangero = new System.Windows.Forms.CheckBox();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.groupSexo = new System.Windows.Forms.GroupBox();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.LabEstadoCivil = new System.Windows.Forms.Label();
            this.ComboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.BtnAgregarPersona = new System.Windows.Forms.Button();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstadociv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExtranjero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabEstado = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.groupSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // LabTitulo
            // 
            this.LabTitulo.AutoSize = true;
            this.LabTitulo.BackColor = System.Drawing.Color.Red;
            this.LabTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabTitulo.ForeColor = System.Drawing.Color.White;
            this.LabTitulo.Location = new System.Drawing.Point(193, 9);
            this.LabTitulo.Name = "LabTitulo";
            this.LabTitulo.Size = new System.Drawing.Size(246, 39);
            this.LabTitulo.TabIndex = 0;
            this.LabTitulo.Text = "Bienvenidos IFTS11";
            this.LabTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabNombre.Location = new System.Drawing.Point(30, 71);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(85, 28);
            this.LabNombre.TabIndex = 0;
            this.LabNombre.Text = "Nombre";
            // 
            // LabFecha
            // 
            this.LabFecha.AutoSize = true;
            this.LabFecha.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabFecha.Location = new System.Drawing.Point(30, 130);
            this.LabFecha.Name = "LabFecha";
            this.LabFecha.Size = new System.Drawing.Size(181, 30);
            this.LabFecha.TabIndex = 0;
            this.LabFecha.Text = "Fecha de registro";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(299, 67);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(255, 36);
            this.TxtNombre.TabIndex = 1;
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaIngreso.Location = new System.Drawing.Point(299, 126);
            this.dateFechaIngreso.MaxDate = new System.DateTime(2099, 9, 8, 14, 11, 0, 0);
            this.dateFechaIngreso.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Size = new System.Drawing.Size(154, 34);
            this.dateFechaIngreso.TabIndex = 2;
            this.dateFechaIngreso.TabStop = false;
            this.dateFechaIngreso.Value = new System.DateTime(2021, 9, 8, 0, 0, 0, 0);
            // 
            // ChExtrangero
            // 
            this.ChExtrangero.AutoSize = true;
            this.ChExtrangero.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChExtrangero.Location = new System.Drawing.Point(299, 357);
            this.ChExtrangero.Name = "ChExtrangero";
            this.ChExtrangero.Size = new System.Drawing.Size(138, 29);
            this.ChExtrangero.TabIndex = 5;
            this.ChExtrangero.Text = "Es extrangero";
            this.ChExtrangero.UseVisualStyleBackColor = true;
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
            // groupSexo
            // 
            this.groupSexo.Controls.Add(this.radioMujer);
            this.groupSexo.Controls.Add(this.radioHombre);
            this.groupSexo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupSexo.Location = new System.Drawing.Point(299, 268);
            this.groupSexo.Name = "groupSexo";
            this.groupSexo.Size = new System.Drawing.Size(283, 83);
            this.groupSexo.TabIndex = 4;
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
            // LabEstadoCivil
            // 
            this.LabEstadoCivil.AutoSize = true;
            this.LabEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabEstadoCivil.Location = new System.Drawing.Point(30, 201);
            this.LabEstadoCivil.Name = "LabEstadoCivil";
            this.LabEstadoCivil.Size = new System.Drawing.Size(119, 30);
            this.LabEstadoCivil.TabIndex = 0;
            this.LabEstadoCivil.Text = "Estado civil";
            // 
            // ComboEstadoCivil
            // 
            this.ComboEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboEstadoCivil.FormattingEnabled = true;
            this.ComboEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Soltero",
            "Divorciado",
            "Viudo"});
            this.ComboEstadoCivil.Location = new System.Drawing.Point(299, 193);
            this.ComboEstadoCivil.Name = "ComboEstadoCivil";
            this.ComboEstadoCivil.Size = new System.Drawing.Size(250, 38);
            this.ComboEstadoCivil.TabIndex = 3;
            // 
            // BtnAgregarPersona
            // 
            this.BtnAgregarPersona.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnAgregarPersona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarPersona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregarPersona.Location = new System.Drawing.Point(30, 292);
            this.BtnAgregarPersona.Name = "BtnAgregarPersona";
            this.BtnAgregarPersona.Size = new System.Drawing.Size(211, 41);
            this.BtnAgregarPersona.TabIndex = 6;
            this.BtnAgregarPersona.Text = "Agregar persona";
            this.BtnAgregarPersona.UseVisualStyleBackColor = false;
            this.BtnAgregarPersona.Click += new System.EventHandler(this.BtnAgregarPersona_Click_1);
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColFecha,
            this.ColEstadociv,
            this.ColSexo,
            this.ColExtranjero});
            this.dtgvDatos.Location = new System.Drawing.Point(40, 416);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.RowTemplate.Height = 25;
            this.dtgvDatos.Size = new System.Drawing.Size(542, 164);
            this.dtgvDatos.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha Creacion";
            this.ColFecha.Name = "ColFecha";
            // 
            // ColEstadociv
            // 
            this.ColEstadociv.HeaderText = "Estado civil";
            this.ColEstadociv.Name = "ColEstadociv";
            // 
            // ColSexo
            // 
            this.ColSexo.HeaderText = "Sexo";
            this.ColSexo.Name = "ColSexo";
            // 
            // ColExtranjero
            // 
            this.ColExtranjero.HeaderText = "Extranjero";
            this.ColExtranjero.Name = "ColExtranjero";
            // 
            // LabEstado
            // 
            this.LabEstado.AutoSize = true;
            this.LabEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabEstado.ForeColor = System.Drawing.Color.Blue;
            this.LabEstado.Location = new System.Drawing.Point(80, 357);
            this.LabEstado.Name = "LabEstado";
            this.LabEstado.Size = new System.Drawing.Size(131, 21);
            this.LabEstado.TabIndex = 0;
            this.LabEstado.Text = "Carga en proceso";
           
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCerrar.Location = new System.Drawing.Point(479, 599);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(103, 37);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 648);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LabEstado);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.BtnAgregarPersona);
            this.Controls.Add(this.ComboEstadoCivil);
            this.Controls.Add(this.LabEstadoCivil);
            this.Controls.Add(this.groupSexo);
            this.Controls.Add(this.ChExtrangero);
            this.Controls.Add(this.dateFechaIngreso);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LabFecha);
            this.Controls.Add(this.LabNombre);
            this.Controls.Add(this.LabTitulo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupSexo.ResumeLayout(false);
            this.groupSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabTitulo;
        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.Label LabFecha;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DateTimePicker dateFechaIngreso;
        private System.Windows.Forms.CheckBox ChExtrangero;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.GroupBox groupSexo;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.Label LabEstadoCivil;
        private System.Windows.Forms.ComboBox ComboEstadoCivil;
        private System.Windows.Forms.Button BtnAgregarPersona;
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstadociv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExtranjero;
        private System.Windows.Forms.Label LabEstado;
        private System.Windows.Forms.Button BtnCerrar;
    }
}