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


namespace ModuloFormularios
{
    public partial class FrmSolicitudDeViaje : Form
    {
        private Conexion cnx = new Conexion();
        private SqlConnection conn;
        private string idusuario;
        private string idmotivo;
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

        public void ponerIDs(String idusuario,string idmotivo) {
            this.idusuario = idusuario;
            this.idmotivo = idmotivo;
        }
        
        private void buttonGuardar_Click(object sender, EventArgs e)
        {

           
            //try
            //{
            //    cnx = new Conexion();
            //    conn = new SqlConnection(cnx.stringConexion);
            //    conn.Open();
            //    String sql = "insert into SolicitudReserva(idMotivoViaje,idCategoriaUsuario,idSolicitante,idLugar,numeroPersonas,fechaSalida,fechaRetorno,estadoSolicitud,fechaReserva) " +
            //        "values(" + (comboBoxMotivos.SelectedIndex + 1) + "," + 1 + "," + idSol + "," + (comboBoxMotivos.SelectedIndex + 1) + "," + 3 + ",'" +
            //        dtf_salida.Text + " " + dth_salida.Text + "','" + dtf_llegada.Text + " " + dth_llegada.Text + "','en espera','" + thisDay.ToString() + "')";
            //    SqlCommand comando = new SqlCommand(sql, conn);
            //    int resultado = comando.ExecuteNonQuery();
            //    MessageBox.Show("" + sql);
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show("Error");
            //    Console.WriteLine(er.ToString());
            //}
        }
    }
}
