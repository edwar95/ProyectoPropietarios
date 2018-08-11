namespace Dijkstra.Formularios
{
    partial class frmKilometraje
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
            System.Windows.Forms.Label idHistorialLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label kilometrajeLabel;
            System.Windows.Forms.Label pLACAVEHICULOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKilometraje));
            this.ruta = new Dijkstra.DataBase.Ruta();
            this.historialKilometrajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialKilometrajeTableAdapter = new Dijkstra.DataBase.RutaTableAdapters.HistorialKilometrajeTableAdapter();
            this.tableAdapterManager = new Dijkstra.DataBase.RutaTableAdapters.TableAdapterManager();
            this.vEHICULOTableAdapter = new Dijkstra.DataBase.RutaTableAdapters.VEHICULOTableAdapter();
            this.historialKilometrajeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historialKilometrajeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idHistorialTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kilometrajeTextBox = new System.Windows.Forms.TextBox();
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLACAVEHICULOComboBox = new System.Windows.Forms.ComboBox();
            idHistorialLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            kilometrajeLabel = new System.Windows.Forms.Label();
            pLACAVEHICULOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingNavigator)).BeginInit();
            this.historialKilometrajeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idHistorialLabel
            // 
            idHistorialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            idHistorialLabel.AutoSize = true;
            idHistorialLabel.Location = new System.Drawing.Point(130, 105);
            idHistorialLabel.Name = "idHistorialLabel";
            idHistorialLabel.Size = new System.Drawing.Size(78, 17);
            idHistorialLabel.TabIndex = 1;
            idHistorialLabel.Text = "id Historial:";
            // 
            // fechaLabel
            // 
            fechaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(130, 134);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(47, 17);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "fecha:";
            // 
            // kilometrajeLabel
            // 
            kilometrajeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            kilometrajeLabel.AutoSize = true;
            kilometrajeLabel.Location = new System.Drawing.Point(130, 161);
            kilometrajeLabel.Name = "kilometrajeLabel";
            kilometrajeLabel.Size = new System.Drawing.Size(80, 17);
            kilometrajeLabel.TabIndex = 5;
            kilometrajeLabel.Text = "kilometraje:";
            // 
            // pLACAVEHICULOLabel
            // 
            pLACAVEHICULOLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pLACAVEHICULOLabel.AutoSize = true;
            pLACAVEHICULOLabel.Location = new System.Drawing.Point(85, 186);
            pLACAVEHICULOLabel.Name = "pLACAVEHICULOLabel";
            pLACAVEHICULOLabel.Size = new System.Drawing.Size(125, 17);
            pLACAVEHICULOLabel.TabIndex = 9;
            pLACAVEHICULOLabel.Text = "PLACAVEHICULO:";
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
            this.tableAdapterManager.VEHICULOTableAdapter = this.vEHICULOTableAdapter;
            // 
            // vEHICULOTableAdapter
            // 
            this.vEHICULOTableAdapter.ClearBeforeFill = true;
            // 
            // historialKilometrajeBindingNavigator
            // 
            this.historialKilometrajeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.historialKilometrajeBindingNavigator.BindingSource = this.historialKilometrajeBindingSource;
            this.historialKilometrajeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.historialKilometrajeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.historialKilometrajeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.historialKilometrajeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.historialKilometrajeBindingNavigatorSaveItem});
            this.historialKilometrajeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.historialKilometrajeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.historialKilometrajeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.historialKilometrajeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.historialKilometrajeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.historialKilometrajeBindingNavigator.Name = "historialKilometrajeBindingNavigator";
            this.historialKilometrajeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.historialKilometrajeBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.historialKilometrajeBindingNavigator.TabIndex = 0;
            this.historialKilometrajeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // historialKilometrajeBindingNavigatorSaveItem
            // 
            this.historialKilometrajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.historialKilometrajeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("historialKilometrajeBindingNavigatorSaveItem.Image")));
            this.historialKilometrajeBindingNavigatorSaveItem.Name = "historialKilometrajeBindingNavigatorSaveItem";
            this.historialKilometrajeBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.historialKilometrajeBindingNavigatorSaveItem.Text = "Guardar datos";
            this.historialKilometrajeBindingNavigatorSaveItem.Click += new System.EventHandler(this.historialKilometrajeBindingNavigatorSaveItem_Click);
            // 
            // idHistorialTextBox
            // 
            this.idHistorialTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idHistorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialKilometrajeBindingSource, "idHistorial", true));
            this.idHistorialTextBox.Location = new System.Drawing.Point(217, 102);
            this.idHistorialTextBox.Name = "idHistorialTextBox";
            this.idHistorialTextBox.Size = new System.Drawing.Size(200, 22);
            this.idHistorialTextBox.TabIndex = 2;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.historialKilometrajeBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(217, 130);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaDateTimePicker.TabIndex = 4;
            // 
            // kilometrajeTextBox
            // 
            this.kilometrajeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kilometrajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialKilometrajeBindingSource, "kilometraje", true));
            this.kilometrajeTextBox.Location = new System.Drawing.Point(217, 158);
            this.kilometrajeTextBox.Name = "kilometrajeTextBox";
            this.kilometrajeTextBox.Size = new System.Drawing.Size(200, 22);
            this.kilometrajeTextBox.TabIndex = 6;
            this.kilometrajeTextBox.TextChanged += new System.EventHandler(this.kilometrajeTextBox_TextChanged);
            // 
            // vEHICULOBindingSource
            // 
            this.vEHICULOBindingSource.DataMember = "VEHICULO";
            this.vEHICULOBindingSource.DataSource = this.ruta;
            // 
            // pLACAVEHICULOComboBox
            // 
            this.pLACAVEHICULOComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLACAVEHICULOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEHICULOBindingSource, "PLACAVEHICULO", true));
            this.pLACAVEHICULOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.historialKilometrajeBindingSource, "idVehiculo", true));
            this.pLACAVEHICULOComboBox.DataSource = this.vEHICULOBindingSource;
            this.pLACAVEHICULOComboBox.DisplayMember = "PLACAVEHICULO";
            this.pLACAVEHICULOComboBox.FormattingEnabled = true;
            this.pLACAVEHICULOComboBox.Location = new System.Drawing.Point(217, 186);
            this.pLACAVEHICULOComboBox.Name = "pLACAVEHICULOComboBox";
            this.pLACAVEHICULOComboBox.Size = new System.Drawing.Size(121, 24);
            this.pLACAVEHICULOComboBox.TabIndex = 10;
            this.pLACAVEHICULOComboBox.ValueMember = "IDVEHICULO";
            // 
            // frmKilometraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(pLACAVEHICULOLabel);
            this.Controls.Add(this.pLACAVEHICULOComboBox);
            this.Controls.Add(idHistorialLabel);
            this.Controls.Add(this.idHistorialTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(kilometrajeLabel);
            this.Controls.Add(this.kilometrajeTextBox);
            this.Controls.Add(this.historialKilometrajeBindingNavigator);
            this.Name = "frmKilometraje";
            this.Text = "frmKilometraje";
            this.Load += new System.EventHandler(this.frmKilometraje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialKilometrajeBindingNavigator)).EndInit();
            this.historialKilometrajeBindingNavigator.ResumeLayout(false);
            this.historialKilometrajeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBase.Ruta ruta;
        private System.Windows.Forms.BindingSource historialKilometrajeBindingSource;
        private DataBase.RutaTableAdapters.HistorialKilometrajeTableAdapter historialKilometrajeTableAdapter;
        private DataBase.RutaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator historialKilometrajeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton historialKilometrajeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idHistorialTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox kilometrajeTextBox;
        private DataBase.RutaTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        private System.Windows.Forms.ComboBox pLACAVEHICULOComboBox;
    }
}