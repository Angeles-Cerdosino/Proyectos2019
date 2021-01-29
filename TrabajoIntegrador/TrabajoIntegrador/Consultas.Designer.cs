namespace TrabajoIntegrador
    {
    partial class Consultas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.rbtnombre = new System.Windows.Forms.RadioButton();
            this.rbtidpelicula = new System.Windows.Forms.RadioButton();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(858, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(462, 262);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 1;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // rbtnombre
            // 
            this.rbtnombre.AutoSize = true;
            this.rbtnombre.Location = new System.Drawing.Point(180, 262);
            this.rbtnombre.Name = "rbtnombre";
            this.rbtnombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnombre.TabIndex = 7;
            this.rbtnombre.TabStop = true;
            this.rbtnombre.Text = "Nombre";
            this.rbtnombre.UseVisualStyleBackColor = true;
            // 
            // rbtidpelicula
            // 
            this.rbtidpelicula.AutoSize = true;
            this.rbtidpelicula.Location = new System.Drawing.Point(54, 262);
            this.rbtidpelicula.Name = "rbtidpelicula";
            this.rbtidpelicula.Size = new System.Drawing.Size(77, 17);
            this.rbtidpelicula.TabIndex = 6;
            this.rbtidpelicula.TabStop = true;
            this.rbtidpelicula.Text = "Id_Pelicula";
            this.rbtidpelicula.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(315, 262);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(715, 262);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(575, 262);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 10;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 330);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.rbtnombre);
            this.Controls.Add(this.rbtidpelicula);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultas_FormClosing);
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.RadioButton rbtnombre;
        private System.Windows.Forms.RadioButton rbtidpelicula;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnborrar;
        }
    }