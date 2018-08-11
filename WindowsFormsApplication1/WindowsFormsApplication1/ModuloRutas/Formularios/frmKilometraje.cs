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
    public partial class frmKilometraje : Form
    {
        public frmKilometraje()
        {
            InitializeComponent();
        }
        Form2 fr = new Form2();
        private void historialKilometrajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.historialKilometrajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruta);

        }

        private void frmKilometraje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ruta.VEHICULO' Puede moverla o quitarla según sea necesario.
            this.vEHICULOTableAdapter.Fill(this.ruta.VEHICULO);
            // TODO: esta línea de código carga datos en la tabla 'ruta.HistorialKilometraje' Puede moverla o quitarla según sea necesario.
            this.historialKilometrajeTableAdapter.Fill(this.ruta.HistorialKilometraje);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void kilometrajeTextBox_TextChanged(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();

            //kilometrajeTextBox.Text = formulario.distanciaRecorrida;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historialKilometrajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruta);
        }
    }
}
