namespace Dijkstra
{
    partial class datKilometraje
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
            this.historialKilometrajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialKilometrajeTableAdapter = new Dijkstra.DataBase.RutaTableAdapters.HistorialKilometrajeTableAdapter();
            this.tableAdapterManager = new Dijkstra.DataBase.RutaTableAdapters.TableAdapterManager();
            this.historialKilometrajeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.historialKilometrajeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ruta
            // 
            this.ruta.DataSetName = "Ruta";
            this.ruta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialKilometrajeBindingSource
            // 
            this.historialKilometrajeBindingSource.DataMember = "HistorialKilometraje";
            this.historialKilometrajeBindingSource.DataSource = this.ruta;
            // 
            // historialKilometrajeTableAdapter
            // 
            this.historialKilometrajeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistorialKilometrajeTableAdapter = this.historialKilometrajeTableAdapter;
            this.tableAdapterManager.incidenciaTableAdapter = null;
            this.tableAdapterManager.LugarTableAdapter = null;
            this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dijkstra.DataBase.RutaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // historialKilometrajeBindingNavigator
            // 
            this.historialKilometrajeBindingNavigator.AddNewItem = null;
            this.historialKilometrajeBindingNavigator.BindingSource = this.historialKilometrajeBindingSource;
            this.historialKilometrajeBindingNavigator.CountItem = null;
            this.historialKilometrajeBindingNavigator.DeleteItem = null;
            this.historialKilometrajeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.historialKilometrajeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.historialKilometrajeBindingNavigator.MoveFirstItem = null;
            this.historialKilometrajeBindingNavigator.MoveLastItem = null;
            this.historialKilometrajeBindingNavigator.MoveNextItem = null;
            this.historialKilometrajeBindingNavigator.MovePreviousItem = null;
            this.historialKilometrajeBindingNavigator.Name = "historialKilometrajeBindingNavigator";
            this.historialKilometrajeBindingNavigator.PositionItem = null;
            this.historialKilometrajeBindingNavigator.Size = new System.Drawing.Size(1108, 25);
            this.historialKilometrajeBindingNavigator.TabIndex = 0;
            this.historialKilometrajeBindingNavigator.Text = "bindingNavigator1";
            this.historialKilometrajeBindingNavigator.RefreshItems += new System.EventHandler(this.historialKilometrajeBindingNavigator_RefreshItems);
            // 
            // historialKilometrajeDataGridView
            // 
            this.historialKilometrajeDataGridView.AutoGenerateColumns = false;
            this.historialKilometrajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialKilometrajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.historialKilometrajeDataGridView.DataSource = this.historialKilometrajeBindingSource;
            this.historialKilometrajeDataGridView.Location = new System.Drawing.Point(41, 28);
            this.historialKilometrajeDataGridView.Name = "historialKilometrajeDataGridView";
            this.historialKilometrajeDataGridView.RowTemplate.Height = 24;
            this.historialKilometrajeDataGridView.Size = new System.Drawing.Size(1034, 430);
            this.historialKilometrajeDataGridView.TabIndex = 1;
            this.historialKilometrajeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historialKilometrajeDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idHistorial";
            this.dataGridViewTextBoxColumn1.FillWeight = 260F;
            this.dataGridViewTextBoxColumn1.HeaderText = "idHistorial";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 260;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn2.FillWeight = 260F;
            this.dataGridViewTextBoxColumn2.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kilometraje";
            this.dataGridViewTextBoxColumn3.FillWeight = 280F;
            this.dataGridViewTextBoxColumn3.HeaderText = "kilometraje";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 280;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idVehiculo";
            this.dataGridViewTextBoxColumn4.FillWeight = 280F;
            this.dataGridViewTextBoxColumn4.HeaderText = "idVehiculo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 280;
            // 
            // datKilometraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.historialKilometrajeDataGridView);
            this.Controls.Add(this.historialKilometrajeBindingNavigator);
            this.Name = "datKilometraje";
            this.Text = "datKilometraje";
            this.Load += new System.EventHandler(this.datKilometraje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBase.Ruta ruta;
        private System.Windows.Forms.BindingSource historialKilometrajeBindingSource;
        private DataBase.RutaTableAdapters.HistorialKilometrajeTableAdapter historialKilometrajeTableAdapter;
        private DataBase.RutaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator historialKilometrajeBindingNavigator;
        private System.Windows.Forms.DataGridView historialKilometrajeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}