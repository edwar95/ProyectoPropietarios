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
    public partial class frmIncidencia : Form
    {
        public frmIncidencia()
        {
            InitializeComponent();
        }

        private void incidenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruta);
        }

        private void frmIncidencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ruta.VEHICULO' Puede moverla o quitarla según sea necesario.
            this.vEHICULOTableAdapter.Fill(this.ruta.VEHICULO);
            // TODO: esta línea de código carga datos en la tabla 'ruta.incidencia' Puede moverla o quitarla según sea necesario.
            this.incidenciaTableAdapter.Fill(this.ruta.incidencia);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruta);
        }
    }
}
