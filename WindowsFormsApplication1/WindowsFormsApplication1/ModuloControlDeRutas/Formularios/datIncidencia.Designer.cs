namespace Dijkstra.Formularios
{
    partial class datIncidencia
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
            this.components = new System.ComponentModel.Container();
            this.ruta = new Dijkstra.DataBase.Ruta();
            this.incidenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenciaTableAdapter = new Dijkstra.DataBase.RutaTableAdapters.incidenciaTableAdapter();
            this.tableAdapterManager = new Dijkstra.DataBase.RutaTableAdapters.TableAdapterManager();
            this.incidenciaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.incidenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ruta
            // 
            this.ruta.DataSetName = "Ruta";
            this.ruta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidenciaBindingSource
            // 
            this.incidenciaBindingSource.DataMember = "incidencia";
            this.incidenciaBindingSource.DataSource = this.ruta;
            // 
            // incidenciaTableAdapter
            // 
            this.incidenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            this.tableAdapterManager.incidenciaTableAdapter = this.incidenciaTableAdapter;
            this.tableAdapterManager.LugarTableAdapter = null;
            this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dijkstra.DataBase.RutaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // incidenciaBindingNavigator
            // 
            this.incidenciaBindingNavigator.AddNewItem = null;
            this.incidenciaBindingNavigator.BindingSource = this.incidenciaBindingSource;
            this.incidenciaBindingNavigator.CountItem = null;
            this.incidenciaBindingNavigator.DeleteItem = null;
            this.incidenciaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.incidenciaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.incidenciaBindingNavigator.MoveFirstItem = null;
            this.incidenciaBindingNavigator.MoveLastItem = null;
            this.incidenciaBindingNavigator.MoveNextItem = null;
            this.incidenciaBindingNavigator.MovePreviousItem = null;
            this.incidenciaBindingNavigator.Name = "incidenciaBindingNavigator";
            this.incidenciaBindingNavigator.PositionItem = null;
            this.incidenciaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.incidenciaBindingNavigator.TabIndex = 0;
            this.incidenciaBindingNavigator.Text = "bindingNavigator1";
            // 
            // incidenciaDataGridView
            // 
            this.incidenciaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incidenciaDataGridView.AutoGenerateColumns = false;
            this.incidenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.incidenciaDataGridView.DataSource = this.incidenciaBindingSource;
            this.incidenciaDataGridView.Location = new System.Drawing.Point(41, 63);
            this.incidenciaDataGridView.Name = "incidenciaDataGridView";
            this.incidenciaDataGridView.RowTemplate.Height = 24;
            this.incidenciaDataGridView.Size = new System.Drawing.Size(715, 267);
            this.incidenciaDataGridView.TabIndex = 1;
            this.incidenciaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incidenciaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "incidenciaID";
            this.dataGridViewTextBoxColumn1.FillWeight = 260F;
            this.dataGridViewTextBoxColumn1.HeaderText = "incidenciaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 260;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "horaIncidencia";
            this.dataGridViewTextBoxColumn2.FillWeight = 260F;
            this.dataGridViewTextBoxColumn2.HeaderText = "horaIncidencia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fechaIncidencia";
            this.dataGridViewTextBoxColumn3.FillWeight = 260F;
            this.dataGridViewTextBoxColumn3.HeaderText = "fechaIncidencia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 260;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn4.FillWeight = 280F;
            this.dataGridViewTextBoxColumn4.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 280;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PLACAVEHICULO";
            this.dataGridViewTextBoxColumn5.FillWeight = 220F;
            this.dataGridViewTextBoxColumn5.HeaderText = "PLACAVEHICULO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 220;
            // 
            // datIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incidenciaDataGridView);
            this.Controls.Add(this.incidenciaBindingNavigator);
            this.Name = "datIncidencia";
            this.Text = "datIncidencia";
            this.Load += new System.EventHandler(this.datIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBase.Ruta ruta;
        private System.Windows.Forms.BindingSource incidenciaBindingSource;
        private DataBase.RutaTableAdapters.incidenciaTableAdapter incidenciaTableAdapter;
        private DataBase.RutaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator incidenciaBindingNavigator;
        private System.Windows.Forms.DataGridView incidenciaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}