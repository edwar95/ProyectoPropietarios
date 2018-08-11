using ModuloFormularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloFormularios
{
    public partial class FrmPrincipalChofer : Form
    {
        private string idUsuario;
        private string nombre;
        private Conexion cnx;
        private SqlConnection conn;
        public FrmPrincipalChofer(string idUsuario, string nombre)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.cnx = new Conexion();
        }

       
        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (existeReportes())
            {
                new Form2(idUsuario, nombre,idReservaReporte());

            }
            else {
                MessageBox.Show("NO TIENE REPORTES PENDIENTES");
            }
        }

        
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

       private void FrmPrincipalChofer_Load(object sender, EventArgs e)
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
        public string[] idReservaReporte()
        {

            string sql = "select idReservaAprob from reservaaprobada where idchofer" + idUsuario + " and reporteconductor is null";
            string [] valores = null;
            conn = new SqlConnection(cnx.stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                SqlDataReader reader = comando.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    valores[i] = reader[0] + "";
                    i++;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return valores;
        }

        public bool existeReportes()
        {

            string sql = "select count(*) from reservaaprobada where idchofer=" + idUsuario + " and reporteconductor is null";
            string valor = "";
            MessageBox.Show(sql + "");
            conn = new SqlConnection(cnx.stringConexion);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    valor = reader[0] + "";

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            if (valor == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
