using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ModuloReportesEstadisticos
{
    public partial class FrmMenuPrincipalReportes : Form
    {
        FrmReporteHistorialKilometraje frmKilometraje;
        FrmReporteViajes frmViajes;
        public FrmMenuPrincipalReportes()
        {
            InitializeComponent();

            frmKilometraje = new FrmReporteHistorialKilometraje();
            frmKilometraje.AutoScroll = true;
            frmKilometraje.TopLevel = false;
            frmKilometraje.FormBorderStyle = FormBorderStyle.None;
            frmKilometraje.Dock = DockStyle.Fill;
            tabPageKilometraje.Controls.Add(frmKilometraje);
            frmKilometraje.Show();
            frmViajes = new FrmReporteViajes();
            frmViajes.AutoScroll = true;
            frmViajes.TopLevel = false;
            frmViajes.FormBorderStyle = FormBorderStyle.None;
            frmViajes.Dock = DockStyle.Fill;
            tabPageViajes.Controls.Add(frmViajes);
            frmViajes.Show();
        }
    }
}
