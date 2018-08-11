namespace WindowsFormsApplication1.ModuloReportesEstadisticos
{
    partial class FrmMenuPrincipalReportes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKilometraje = new System.Windows.Forms.TabPage();
            this.tabPageCalificaciones = new System.Windows.Forms.TabPage();
            this.tabPageViajes = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 605);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.313993F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.17747F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(251, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 34);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módulo de Reportes Estadísticos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageKilometraje);
            this.tabControl1.Controls.Add(this.tabPageViajes);
            this.tabControl1.Controls.Add(this.tabPageCalificaciones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1136, 540);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageKilometraje
            // 
            this.tabPageKilometraje.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageKilometraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageKilometraje.Location = new System.Drawing.Point(4, 33);
            this.tabPageKilometraje.Name = "tabPageKilometraje";
            this.tabPageKilometraje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKilometraje.Size = new System.Drawing.Size(1128, 503);
            this.tabPageKilometraje.TabIndex = 1;
            this.tabPageKilometraje.Text = "Reporte de Kilometraje";
            this.tabPageKilometraje.UseVisualStyleBackColor = true;
            // 
            // tabPageCalificaciones
            // 
            this.tabPageCalificaciones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCalificaciones.Location = new System.Drawing.Point(4, 33);
            this.tabPageCalificaciones.Name = "tabPageCalificaciones";
            this.tabPageCalificaciones.Size = new System.Drawing.Size(1128, 503);
            this.tabPageCalificaciones.TabIndex = 2;
            this.tabPageCalificaciones.Text = "Reporte de Calificaciones";
            this.tabPageCalificaciones.UseVisualStyleBackColor = true;
            // 
            // tabPageViajes
            // 
            this.tabPageViajes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageViajes.Location = new System.Drawing.Point(4, 33);
            this.tabPageViajes.Name = "tabPageViajes";
            this.tabPageViajes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViajes.Size = new System.Drawing.Size(1128, 503);
            this.tabPageViajes.TabIndex = 0;
            this.tabPageViajes.Text = "Reporte de Viajes";
            this.tabPageViajes.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipalReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 605);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipalReportes";
            this.Text = "FrmMenuPrincipalReportes";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageKilometraje;
        private System.Windows.Forms.TabPage tabPageCalificaciones;
        private System.Windows.Forms.TabPage tabPageViajes;
    }
}