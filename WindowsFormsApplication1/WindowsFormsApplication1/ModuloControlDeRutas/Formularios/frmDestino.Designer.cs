namespace Dijkstra.Formularios
{
    partial class frmDestino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDestino));
            System.Windows.Forms.Label idLugarLabel;
            System.Windows.Forms.Label nombreLugarLabel;
            System.Windows.Forms.Label fueraProvinciaLabel;
            this.ruta = new Dijkstra.DataBase.Ruta();
            this.lugarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lugarTableAdapter = new Dijkstra.DataBase.RutaTableAdapters.LugarTableAdapter();
            this.tableAdapterManager = new Dijkstra.DataBase.RutaTableAdapters.TableAdapterManager();
            this.lugarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lugarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLugarTextBox = new System.Windows.Forms.TextBox();
            this.nombreLugarTextBox = new System.Windows.Forms.TextBox();
            this.fueraProvinciaTextBox = new System.Windows.Forms.TextBox();
            idLugarLabel = new System.Windows.Forms.Label();
            nombreLugarLabel = new System.Windows.Forms.Label();
            fueraProvinciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugarBindingNavigator)).BeginInit();
            this.lugarBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruta
            // 
            this.ruta.DataSetName = "Ruta";
            this.ruta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lugarBindingSource
            // 
            this.lugarBindingSource.DataMember = "Lugar";
            this.lugarBindingSource.DataSource = this.ruta;
            // 
            // lugarTableAdapter
            // 
            this.lugarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HistorialKilometrajeTableAdapter = null;
            this.tableAdapterManager.incidenciaTableAdapter = null;
            this.tableAdapterManager.LugarTableAdapter = this.lugarTableAdapter;
            this.tableAdapterManager.SolicitudReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dijkstra.DataBase.RutaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            // 
            // lugarBindingNavigator
            // 
            this.lugarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lugarBindingNavigator.BindingSource = this.lugarBindingSource;
            this.lugarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lugarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lugarBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lugarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lugarBindingNavigatorSaveItem});
            this.lugarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lugarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lugarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lugarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lugarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lugarBindingNavigator.Name = "lugarBindingNavigator";
            this.lugarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lugarBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.lugarBindingNavigator.TabIndex = 0;
            this.lugarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // lugarBindingNavigatorSaveItem
            // 
            this.lugarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lugarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lugarBindingNavigatorSaveItem.Image")));
            this.lugarBindingNavigatorSaveItem.Name = "lugarBindingNavigatorSaveItem";
            this.lugarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lugarBindingNavigatorSaveItem.Text = "Guardar datos";
            this.lugarBindingNavigatorSaveItem.Click += new System.EventHandler(this.lugarBindingNavigatorSaveItem_Click);
            // 
            // idLugarLabel
            // 
            idLugarLabel.AutoSize = true;
            idLugarLabel.Location = new System.Drawing.Point(144, 106);
            idLugarLabel.Name = "idLugarLabel";
            idLugarLabel.Size = new System.Drawing.Size(64, 17);
            idLugarLabel.TabIndex = 1;
            idLugarLabel.Text = "id Lugar:";
            // 
            // idLugarTextBox
            // 
            this.idLugarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lugarBindingSource, "idLugar", true));
            this.idLugarTextBox.Location = new System.Drawing.Point(257, 103);
            this.idLugarTextBox.Name = "idLugarTextBox";
            this.idLugarTextBox.Size = new System.Drawing.Size(100, 22);
            this.idLugarTextBox.TabIndex = 2;
            // 
            // nombreLugarLabel
            // 
            nombreLugarLabel.AutoSize = true;
            nombreLugarLabel.Location = new System.Drawing.Point(144, 134);
            nombreLugarLabel.Name = "nombreLugarLabel";
            nombreLugarLabel.Size = new System.Drawing.Size(101, 17);
            nombreLugarLabel.TabIndex = 3;
            nombreLugarLabel.Text = "nombre Lugar:";
            // 
            // nombreLugarTextBox
            // 
            this.nombreLugarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lugarBindingSource, "nombreLugar", true));
            this.nombreLugarTextBox.Location = new System.Drawing.Point(257, 131);
            this.nombreLugarTextBox.Name = "nombreLugarTextBox";
            this.nombreLugarTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreLugarTextBox.TabIndex = 4;
            // 
            // fueraProvinciaLabel
            // 
            fueraProvinciaLabel.AutoSize = true;
            fueraProvinciaLabel.Location = new System.Drawing.Point(144, 162);
            fueraProvinciaLabel.Name = "fueraProvinciaLabel";
            fueraProvinciaLabel.Size = new System.Drawing.Size(107, 17);
            fueraProvinciaLabel.TabIndex = 5;
            fueraProvinciaLabel.Text = "fuera Provincia:";
            // 
            // fueraProvinciaTextBox
            // 
            this.fueraProvinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lugarBindingSource, "fueraProvincia", true));
            this.fueraProvinciaTextBox.Location = new System.Drawing.Point(257, 159);
            this.fueraProvinciaTextBox.Name = "fueraProvinciaTextBox";
            this.fueraProvinciaTextBox.Size = new System.Drawing.Size(100, 22);
            this.fueraProvinciaTextBox.TabIndex = 6;
            // 
            // frmDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idLugarLabel);
            this.Controls.Add(this.idLugarTextBox);
            this.Controls.Add(nombreLugarLabel);
            this.Controls.Add(this.nombreLugarTextBox);
            this.Controls.Add(fueraProvinciaLabel);
            this.Controls.Add(this.fueraProvinciaTextBox);
            this.Controls.Add(this.lugarBindingNavigator);
            this.Name = "frmDestino";
            this.Text = "frmDestino";
            this.Load += new System.EventHandler(this.frmDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugarBindingNavigator)).EndInit();
            this.lugarBindingNavigator.ResumeLayout(false);
            this.lugarBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBase.Ruta ruta;
        private System.Windows.Forms.BindingSource lugarBindingSource;
        private DataBase.RutaTableAdapters.LugarTableAdapter lugarTableAdapter;
        private DataBase.RutaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lugarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lugarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idLugarTextBox;
        private System.Windows.Forms.TextBox nombreLugarTextBox;
        private System.Windows.Forms.TextBox fueraProvinciaTextBox;
    }
}