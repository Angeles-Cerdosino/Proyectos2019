namespace FrmAlumno
    {
    partial class Form1
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
            this.Total = new System.Windows.Forms.Label();
            this.ContLibre = new System.Windows.Forms.Label();
            this.ContRegular = new System.Windows.Forms.Label();
            this.ContPromocion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.txtPromGral = new System.Windows.Forms.TextBox();
            this.lblPromGral = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPorcLibre = new System.Windows.Forms.Label();
            this.lblPorcReg = new System.Windows.Forms.Label();
            this.lblPorcProm = new System.Windows.Forms.Label();
            this.lblContLibre = new System.Windows.Forms.Label();
            this.lblContRegular = new System.Windows.Forms.Label();
            this.lblContPromocion = new System.Windows.Forms.Label();
            this.lblcontador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(307, 361);
            this.Total.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 48;
            this.Total.Text = "Total";
            // 
            // ContLibre
            // 
            this.ContLibre.AutoSize = true;
            this.ContLibre.Location = new System.Drawing.Point(229, 361);
            this.ContLibre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ContLibre.Name = "ContLibre";
            this.ContLibre.Size = new System.Drawing.Size(35, 13);
            this.ContLibre.TabIndex = 47;
            this.ContLibre.Text = "Libres";
            // 
            // ContRegular
            // 
            this.ContRegular.AutoSize = true;
            this.ContRegular.Location = new System.Drawing.Point(135, 361);
            this.ContRegular.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ContRegular.Name = "ContRegular";
            this.ContRegular.Size = new System.Drawing.Size(55, 13);
            this.ContRegular.TabIndex = 46;
            this.ContRegular.Text = "Regulares";
            // 
            // ContPromocion
            // 
            this.ContPromocion.AutoSize = true;
            this.ContPromocion.Location = new System.Drawing.Point(21, 361);
            this.ContPromocion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ContPromocion.Name = "ContPromocion";
            this.ContPromocion.Size = new System.Drawing.Size(80, 13);
            this.ContPromocion.TabIndex = 45;
            this.ContPromocion.Text = "Promocionados";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(418, 269);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 44;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(346, 269);
            this.Estado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 43;
            this.Estado.Text = "Estado";
            // 
            // txtPromGral
            // 
            this.txtPromGral.Enabled = false;
            this.txtPromGral.Location = new System.Drawing.Point(121, 312);
            this.txtPromGral.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPromGral.Name = "txtPromGral";
            this.txtPromGral.Size = new System.Drawing.Size(180, 20);
            this.txtPromGral.TabIndex = 42;
            // 
            // lblPromGral
            // 
            this.lblPromGral.AutoSize = true;
            this.lblPromGral.Location = new System.Drawing.Point(18, 315);
            this.lblPromGral.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPromGral.Name = "lblPromGral";
            this.lblPromGral.Size = new System.Drawing.Size(91, 13);
            this.lblPromGral.TabIndex = 41;
            this.lblPromGral.Text = "Promedio General";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(121, 269);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(180, 20);
            this.txtPromedio.TabIndex = 40;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(116, 189);
            this.txtNota3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(74, 20);
            this.txtNota3.TabIndex = 39;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(116, 152);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(74, 20);
            this.txtNota2.TabIndex = 38;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(116, 111);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(74, 20);
            this.txtNota1.TabIndex = 37;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(100, 68);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(180, 20);
            this.txtLegajo.TabIndex = 36;
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 29);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 35;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(85, 217);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 36);
            this.btnCalcular.TabIndex = 34;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(30, 269);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 33;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(33, 193);
            this.lblNota3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 13);
            this.lblNota3.TabIndex = 32;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(34, 156);
            this.lblNota2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 31;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(34, 115);
            this.lblNota1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 30;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(27, 68);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 29;
            this.lblLegajo.Text = "Legajo";
            this.lblLegajo.Click += new System.EventHandler(this.lblLegajo_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 29);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 444);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "%";
            // 
            // lblPorcLibre
            // 
            this.lblPorcLibre.AutoSize = true;
            this.lblPorcLibre.Location = new System.Drawing.Point(222, 444);
            this.lblPorcLibre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPorcLibre.Name = "lblPorcLibre";
            this.lblPorcLibre.Size = new System.Drawing.Size(13, 13);
            this.lblPorcLibre.TabIndex = 55;
            this.lblPorcLibre.Text = "0";
            // 
            // lblPorcReg
            // 
            this.lblPorcReg.AutoSize = true;
            this.lblPorcReg.Location = new System.Drawing.Point(141, 444);
            this.lblPorcReg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPorcReg.Name = "lblPorcReg";
            this.lblPorcReg.Size = new System.Drawing.Size(13, 13);
            this.lblPorcReg.TabIndex = 54;
            this.lblPorcReg.Text = "0";
            // 
            // lblPorcProm
            // 
            this.lblPorcProm.AutoSize = true;
            this.lblPorcProm.Location = new System.Drawing.Point(33, 444);
            this.lblPorcProm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPorcProm.Name = "lblPorcProm";
            this.lblPorcProm.Size = new System.Drawing.Size(13, 13);
            this.lblPorcProm.TabIndex = 53;
            this.lblPorcProm.Text = "0";
            // 
            // lblContLibre
            // 
            this.lblContLibre.AutoSize = true;
            this.lblContLibre.Location = new System.Drawing.Point(222, 407);
            this.lblContLibre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContLibre.Name = "lblContLibre";
            this.lblContLibre.Size = new System.Drawing.Size(13, 13);
            this.lblContLibre.TabIndex = 52;
            this.lblContLibre.Text = "0";
            // 
            // lblContRegular
            // 
            this.lblContRegular.AutoSize = true;
            this.lblContRegular.Location = new System.Drawing.Point(141, 407);
            this.lblContRegular.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContRegular.Name = "lblContRegular";
            this.lblContRegular.Size = new System.Drawing.Size(13, 13);
            this.lblContRegular.TabIndex = 51;
            this.lblContRegular.Text = "0";
            // 
            // lblContPromocion
            // 
            this.lblContPromocion.AutoSize = true;
            this.lblContPromocion.Location = new System.Drawing.Point(33, 407);
            this.lblContPromocion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContPromocion.Name = "lblContPromocion";
            this.lblContPromocion.Size = new System.Drawing.Size(13, 13);
            this.lblContPromocion.TabIndex = 50;
            this.lblContPromocion.Text = "0";
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Location = new System.Drawing.Point(326, 407);
            this.lblcontador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(13, 13);
            this.lblcontador.TabIndex = 49;
            this.lblcontador.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPorcLibre);
            this.Controls.Add(this.lblPorcReg);
            this.Controls.Add(this.lblPorcProm);
            this.Controls.Add(this.lblContLibre);
            this.Controls.Add(this.lblContRegular);
            this.Controls.Add(this.lblContPromocion);
            this.Controls.Add(this.lblcontador);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.ContLibre);
            this.Controls.Add(this.ContRegular);
            this.Controls.Add(this.ContPromocion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.txtPromGral);
            this.Controls.Add(this.lblPromGral);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label ContLibre;
        private System.Windows.Forms.Label ContRegular;
        private System.Windows.Forms.Label ContPromocion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.TextBox txtPromGral;
        private System.Windows.Forms.Label lblPromGral;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPorcLibre;
        private System.Windows.Forms.Label lblPorcReg;
        private System.Windows.Forms.Label lblPorcProm;
        private System.Windows.Forms.Label lblContLibre;
        private System.Windows.Forms.Label lblContRegular;
        private System.Windows.Forms.Label lblContPromocion;
        private System.Windows.Forms.Label lblcontador;
        }
    }

