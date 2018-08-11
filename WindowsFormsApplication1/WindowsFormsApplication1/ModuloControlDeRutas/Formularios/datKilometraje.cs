using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class datKilometraje : Form
    {
        public datKilometraje()
        {
            InitializeComponent();
        }

        private void historialKilometrajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historialKilometrajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruta);

        }

        private void datKilometraje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ruta.HistorialKilometraje' Puede moverla o quitarla según sea necesario.
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.historialKilometrajeTableAdapter.Fill(this.ruta.HistorialKilometraje);

      

        }

        private void historialKilometrajeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void historialKilometrajeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
