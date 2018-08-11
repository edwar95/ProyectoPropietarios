using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Reserva reserva;
        Conexion coneccion;

        
        public Form1()
        {
            InitializeComponent();
            confirmarBtn.Enabled = false;
            coneccion = new Conexion();
            reserva= new Reserva();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tipoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void reservacion_Click(object sender, EventArgs e)
        {
            

            coneccion.Conectar();
            SqlCommand cmd = new SqlCommand("select * from SolicitudReserva WHERE idSolicitudReserva ="+ numReservaTxt.Text+"and estadoSolicitud = 'aprobada1'", coneccion.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    reserva.IdReserva = reader.GetInt32(0);
                    numReservaTxt.Text = reserva.IdReserva.ToString();

                    reserva.NumeroPersonas = reader.GetInt32(4);
                    numPersonas.Value = reserva.NumeroPersonas;

                    reserva.IdMotivoViaje = reader.GetInt32(2);
                    motivoViajeTxt.Text = reserva.IdMotivoViaje.ToString();

                    reserva.IdCategoriaUsuario = reader.GetInt32(1);
                    tipoUsr.Text = reserva.IdCategoriaUsuario.ToString();

                    reserva.FechaInicio = reader.GetDateTime(5).ToString();
                    fechaIni.Value = Convert.ToDateTime(reserva.FechaInicio);

                    reserva.FechaFin = reader.GetDateTime(6).ToString();
                    fechaFinaliza.Value = Convert.ToDateTime(reserva.FechaFin);

                    reserva.Estado = reader.GetString(7);

                    Console.WriteLine(reserva.FechaInicio);                    

                    confirmarBtn.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("No existe reserva", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numPersonas.Value = 0;
                confirmarBtn.Enabled = false;
            }
            coneccion.Desconectar();

        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            reserva.reservar(this.reserva);

            numReservaTxt.Clear();
            numPersonas.Value = 0;
            motivoViajeTxt.Clear();
            tipoUsr.Clear();
            fechaIni.Value = DateTime.Today;
            fechaFinaliza.Value = DateTime.Today;
            

        }

      
    }
}
