using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dijkstra.Formularios
{
    public partial class frmDestino : Form
    {
        public frmDestino()
        {
            InitializeComponent();
        }

        private void lugarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lugarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruta);

        }

        private void frmDestino_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ruta.Lugar' Puede moverla o quitarla según sea necesario.
            this.lugarTableAdapter.Fill(this.ruta.Lugar);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lugarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruta);
        }
    }
}
