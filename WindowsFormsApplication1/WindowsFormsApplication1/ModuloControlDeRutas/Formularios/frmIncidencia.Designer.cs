namespace Dijkstra.Formularios
{
    partial class frmIncidencia
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
            System.Windows.Forms.Label incidenciaIDLabel;
            System.Windows.Forms.Label horaIncidenciaLabel;
            System.Windows.Forms.Label fechaIncidenciaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label pLACAVEHICULOLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncidencia));
            this.ruta = new Dijkstra.DataBase.Ruta();
            this.incidenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidenciaTableAdapter = new Dijkstra.DataBase.RutaTableAdapters.incidenciaTableAdapter();
            this.tableAdapterManager = new Dijkstra.DataBase.RutaTableAdapters.TableAdapterManager();
            this.vEHICULOTableAdapter = new Dijkstra.DataBase.RutaTableAdapters.VEHICULOTableAdapter();
            this.incidenciaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.incidenciaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.incidenciaIDTextBox = new System.Windows.Forms.TextBox();
            this.horaIncidenciaTextBox = new System.Windows.Forms.TextBox();
            this.fechaIncidenciaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.vEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLACAVEHICULOComboBox = new System.Windows.Forms.ComboBox();
            incidenciaIDLabel = new System.Windows.Forms.Label();
            horaIncidenciaLabel = new System.Windows.Forms.Label();
            fechaIncidenciaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            pLACAVEHICULOLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingNavigator)).BeginInit();
            this.incidenciaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // incidenciaIDLabel
            // 
            incidenciaIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            incidenciaIDLabel.AutoSize = true;
            incidenciaIDLabel.Location = new System.Drawing.Point(125, 91);
            incidenciaIDLabel.Name = "incidenciaIDLabel";
            incidenciaIDLabel.Size = new System.Drawing.Size(92, 17);
            incidenciaIDLabel.TabIndex = 1;
            incidenciaIDLabel.Text = "incidencia ID:";
            // 
            // horaIncidenciaLabel
            // 
            horaIncidenciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            horaIncidenciaLabel.AutoSize = true;
            horaIncidenciaLabel.Location = new System.Drawing.Point(125, 119);
            horaIncidenciaLabel.Name = "horaIncidenciaLabel";
            horaIncidenciaLabel.Size = new System.Drawing.Size(108, 17);
            horaIncidenciaLabel.TabIndex = 3;
            horaIncidenciaLabel.Text = "hora Incidencia:";
            // 
            // fechaIncidenciaLabel
            // 
            fechaIncidenciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fechaIncidenciaLabel.AutoSize = true;
            fechaIncidenciaLabel.Location = new System.Drawing.Point(125, 148);
            fechaIncidenciaLabel.Name = "fechaIncidenciaLabel";
            fechaIncidenciaLabel.Size = new System.Drawing.Size(114, 17);
            fechaIncidenciaLabel.TabIndex = 5;
            fechaIncidenciaLabel.Text = "fecha Incidencia:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(125, 175);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(84, 17);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "descripcion:";
            // 
            // pLACAVEHICULOLabel1
            // 
            pLACAVEHICULOLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pLACAVEHICULOLabel1.AutoSize = true;
            pLACAVEHICULOLabel1.Location = new System.Drawing.Point(125, 202);
            pLACAVEHICULOLabel1.Name = "pLACAVEHICULOLabel1";
            pLACAVEHICULOLabel1.Size = new System.Drawing.Size(125, 17);
            pLACAVEHICULOLabel1.TabIndex = 11;
            pLACAVEHICULOLabel1.Text = "PLACAVEHICULO:";
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
            this.tableAdapterManager.VEHICULOTableAdapter = this.vEHICULOTableAdapter;
            // 
            // vEHICULOTableAdapter
            // 
            this.vEHICULOTableAdapter.ClearBeforeFill = true;
            // 
            // incidenciaBindingNavigator
            // 
            this.incidenciaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.incidenciaBindingNavigator.BindingSource = this.incidenciaBindingSource;
            this.incidenciaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.incidenciaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.incidenciaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.incidenciaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.incidenciaBindingNavigatorSaveItem});
            this.incidenciaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.incidenciaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.incidenciaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.incidenciaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.incidenciaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.incidenciaBindingNavigator.Name = "incidenciaBindingNavigator";
            this.incidenciaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.incidenciaBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.incidenciaBindingNavigator.TabIndex = 0;
            this.incidenciaBindingNavigator.Text = "bindingNavigator1";
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
            // incidenciaBindingNavigatorSaveItem
            // 
            this.incidenciaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incidenciaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("incidenciaBindingNavigatorSaveItem.Image")));
            this.incidenciaBindingNavigatorSaveItem.Name = "incidenciaBindingNavigatorSaveItem";
            this.incidenciaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.incidenciaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.incidenciaBindingNavigatorSaveItem.Click += new System.EventHandler(this.incidenciaBindingNavigatorSaveItem_Click);
            // 
            // incidenciaIDTextBox
            // 
            this.incidenciaIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incidenciaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "incidenciaID", true));
            this.incidenciaIDTextBox.Location = new System.Drawing.Point(256, 88);
            this.incidenciaIDTextBox.Name = "incidenciaIDTextBox";
            this.incidenciaIDTextBox.Size = new System.Drawing.Size(319, 22);
            this.incidenciaIDTextBox.TabIndex = 2;
            // 
            // horaIncidenciaTextBox
            // 
            this.horaIncidenciaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horaIncidenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "horaIncidencia", true));
            this.horaIncidenciaTextBox.Location = new System.Drawing.Point(256, 116);
            this.horaIncidenciaTextBox.Name = "horaIncidenciaTextBox";
            this.horaIncidenciaTextBox.Size = new System.Drawing.Size(319, 22);
            this.horaIncidenciaTextBox.TabIndex = 4;
            // 
            // fechaIncidenciaDateTimePicker
            // 
            this.fechaIncidenciaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaIncidenciaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incidenciaBindingSource, "fechaIncidencia", true));
            this.fechaIncidenciaDateTimePicker.Location = new System.Drawing.Point(256, 144);
            this.fechaIncidenciaDateTimePicker.Name = "fechaIncidenciaDateTimePicker";
            this.fechaIncidenciaDateTimePicker.Size = new System.Drawing.Size(319, 22);
            this.fechaIncidenciaDateTimePicker.TabIndex = 6;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidenciaBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(256, 172);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(319, 22);
            this.descripcionTextBox.TabIndex = 8;
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
            this.pLACAVEHICULOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incidenciaBindingSource, "PLACAVEHICULO", true));
            this.pLACAVEHICULOComboBox.DataSource = this.vEHICULOBindingSource;
            this.pLACAVEHICULOComboBox.DisplayMember = "PLACAVEHICULO";
            this.pLACAVEHICULOComboBox.FormattingEnabled = true;
            this.pLACAVEHICULOComboBox.Location = new System.Drawing.Point(256, 202);
            this.pLACAVEHICULOComboBox.Name = "pLACAVEHICULOComboBox";
            this.pLACAVEHICULOComboBox.Size = new System.Drawing.Size(319, 24);
            this.pLACAVEHICULOComboBox.TabIndex = 12;
            this.pLACAVEHICULOComboBox.ValueMember = "PLACAVEHICULO";
            // 
            // frmIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(pLACAVEHICULOLabel1);
            this.Controls.Add(this.pLACAVEHICULOComboBox);
            this.Controls.Add(incidenciaIDLabel);
            this.Controls.Add(this.incidenciaIDTextBox);
            this.Controls.Add(horaIncidenciaLabel);
            this.Controls.Add(this.horaIncidenciaTextBox);
            this.Controls.Add(fechaIncidenciaLabel);
            this.Controls.Add(this.fechaIncidenciaDateTimePicker);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.incidenciaBindingNavigator);
            this.Name = "frmIncidencia";
            this.Text = "frmIncidencia";
            this.Load += new System.EventHandler(this.frmIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingNavigator)).EndInit();
            this.incidenciaBindingNavigator.ResumeLayout(false);
            this.incidenciaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBase.Ruta ruta;
        private System.Windows.Forms.BindingSource incidenciaBindingSource;
        private DataBase.RutaTableAdapters.incidenciaTableAdapter incidenciaTableAdapter;
        private DataBase.RutaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator incidenciaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton incidenciaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox incidenciaIDTextBox;
        private System.Windows.Forms.TextBox horaIncidenciaTextBox;
        private System.Windows.Forms.DateTimePicker fechaIncidenciaDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private DataBase.RutaTableAdapters.VEHICULOTableAdapter vEHICULOTableAdapter;
        private System.Windows.Forms.BindingSource vEHICULOBindingSource;
        private System.Windows.Forms.ComboBox pLACAVEHICULOComboBox;
    }
}