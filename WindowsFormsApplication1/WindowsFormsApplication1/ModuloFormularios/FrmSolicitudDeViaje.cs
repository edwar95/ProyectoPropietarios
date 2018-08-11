using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.ModuloFormularios;

namespace ModuloFormularios
{
    public partial class FrmSolicitudDeViaje : Form
    {
        private Conexion cnx = new Conexion();
        private SqlConnection conn;
        private string idusuario;
        private string idmotivo;
        string destino;
        public FrmSolicitudDeViaje()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            conn = new SqlConnection(cnx.stringConexion);
        }

        public void llenarFormulario(String nombre, string email) {
            txt_ciSolicitante.Text = email;
            txt_nombreSolicitante.Text = nombre;
        }

        public void ponerIDs(String idusuario,string idmotivo,string destino) {
            this.idusuario = idusuario;
            this.idmotivo = idmotivo;
        }
        
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            destino = textBox2.Text + "," + comboBox1.SelectedIndex.ToString() + ",Ecuador";
            //string idUsuario,string idmotivo, string destino, string fechaSalida, string horaSalida, string fechaRetorno, string horaRetorno, int numeroPersonas
            CSSolicitudDeViaje solicitudDeViaje = new CSSolicitudDeViaje(idusuario,idmotivo,destino,dtf_salida.Text, dth_salida.Text, dtf_llegada.Text, dth_llegada.Text, Convert.ToInt32(textBox1.Text));
            solicitudDeViaje.guardarEnBase();
        }
    }
}
