namespace TrabajoIntegrador
    {
    partial class rprtVIEWpeliculas
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPeliculas1 = new TrabajoIntegrador.rptPeliculas();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImpFiltro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptPeliculas1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1012, 379);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(249, 412);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnImpFiltro
            // 
            this.btnImpFiltro.Location = new System.Drawing.Point(615, 412);
            this.btnImpFiltro.Name = "btnImpFiltro";
            this.btnImpFiltro.Size = new System.Drawing.Size(104, 23);
            this.btnImpFiltro.TabIndex = 2;
            this.btnImpFiltro.Text = "Imprimir Filtro";
            this.btnImpFiltro.UseVisualStyleBackColor = true;
            // 
            // rprtVIEWpeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 514);
            this.Controls.Add(this.btnImpFiltro);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "rprtVIEWpeliculas";
            this.Text = "rprtVIEWpeliculas";
            this.Load += new System.EventHandler(this.rprtVIEWpeliculas_Load);
            this.ResumeLayout(false);

            }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptPeliculas rptPeliculas1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImpFiltro;
        }
    }