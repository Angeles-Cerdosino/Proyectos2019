namespace FinalProducto
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.combomarca = new System.Windows.Forms.ComboBox();
            this.btnnetbook = new System.Windows.Forms.RadioButton();
            this.btnnotebook = new System.Windows.Forms.RadioButton();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.lstproducto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(20, 21);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(45, 15);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(20, 88);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(41, 15);
            this.lblmarca.TabIndex = 2;
            this.lblmarca.Text = "Marca";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(22, 127);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(31, 15);
            this.lbltipo.TabIndex = 3;
            this.lbltipo.Text = "Tipo";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(18, 189);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(42, 15);
            this.lblprecio.TabIndex = 4;
            this.lblprecio.Text = "Precio";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(18, 228);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(39, 15);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "Fecha";
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.Location = new System.Drawing.Point(20, 49);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(46, 15);
            this.lbldetalle.TabIndex = 6;
            this.lbldetalle.Text = "Detalle";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(65, 232);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 14;
            // 
            // combomarca
            // 
            this.combomarca.FormattingEnabled = true;
            this.combomarca.Location = new System.Drawing.Point(96, 90);
            this.combomarca.Name = "combomarca";
            this.combomarca.Size = new System.Drawing.Size(121, 21);
            this.combomarca.TabIndex = 10;
            // 
            // btnnetbook
            // 
            this.btnnetbook.AutoSize = true;
            this.btnnetbook.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnetbook.Location = new System.Drawing.Point(98, 154);
            this.btnnetbook.Name = "btnnetbook";
            this.btnnetbook.Size = new System.Drawing.Size(82, 19);
            this.btnnetbook.TabIndex = 12;
            this.btnnetbook.TabStop = true;
            this.btnnetbook.Text = "2-Netbook";
            this.btnnetbook.UseVisualStyleBackColor = true;
            // 
            // btnnotebook
            // 
            this.btnnotebook.AutoSize = true;
            this.btnnotebook.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotebook.Location = new System.Drawing.Point(98, 131);
            this.btnnotebook.Name = "btnnotebook";
            this.btnnotebook.Size = new System.Drawing.Size(88, 19);
            this.btnnotebook.TabIndex = 11;
            this.btnnotebook.TabStop = true;
            this.btnnotebook.Text = "1-Notebook";
            this.btnnotebook.UseVisualStyleBackColor = true;
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(65, 190);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 23);
            this.txtprecio.TabIndex = 13;
            // 
            // txtdetalle
            // 
            this.txtdetalle.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetalle.Location = new System.Drawing.Point(96, 53);
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(153, 23);
            this.txtdetalle.TabIndex = 9;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(96, 18);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(153, 23);
            this.txtcodigo.TabIndex = 8;
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(523, 285);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 26;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btngrabar
            // 
            this.btngrabar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrabar.Location = new System.Drawing.Point(408, 285);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 23);
            this.btngrabar.TabIndex = 25;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(290, 285);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 24;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(174, 285);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 23;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(642, 285);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 22;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(57, 285);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 21;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // lstproducto
            // 
            this.lstproducto.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstproducto.FormattingEnabled = true;
            this.lstproducto.ItemHeight = 15;
            this.lstproducto.Location = new System.Drawing.Point(313, 23);
            this.lstproducto.Name = "lstproducto";
            this.lstproducto.Size = new System.Drawing.Size(576, 229);
            this.lstproducto.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 342);
            this.Controls.Add(this.lstproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.combomarca);
            this.Controls.Add(this.btnnetbook);
            this.Controls.Add(this.btnnotebook);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdetalle);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.lblcodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.ComboBox combomarca;
        private System.Windows.Forms.RadioButton btnnetbook;
        private System.Windows.Forms.RadioButton btnnotebook;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ListBox lstproducto;
        }
    }

