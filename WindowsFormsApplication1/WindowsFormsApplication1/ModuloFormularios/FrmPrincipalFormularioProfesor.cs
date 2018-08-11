using ModuloFormularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    public partial class FrmPrincipalFormularioProfesor : Form
    {
        Usuario usu;
        public FrmPrincipalFormularioProfesor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            FrmSolicitudDeViaje solicitudDeViaje = new FrmSolicitudDeViaje();
            solicitudDeViaje.llenarFormulario(usu.Nombre,usu.Email);
            solicitudDeViaje.Show();
        }

        public void ponerUsuario(object usu) {
            this.usu = (Usuario) usu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCalificacionServicio calificacionServicio = new FrmCalificacionServicio();
            calificacionServicio.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipalFormularioProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
