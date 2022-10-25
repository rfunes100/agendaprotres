using CrystalDecisions.CrystalReports.Engine;
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

namespace agendaprogran.Reportes
{
    public partial class contactosxcumplefrm : Form
    {

        public string conexiondbsql = Properties.Settings.Default.conexion;

        ReportDocument crypt = new ReportDocument();
        //  SqlConnection connection = new
        //     SqlConnection("Data Source=olimposrv;Initial Catalog=agenda;User ID=marcas;Password=marcas ");
        public string genero = "";



        public contactosxcumplefrm()
        {
            InitializeComponent();
        }

        private void contactosxcumplefrm_Load(object sender, EventArgs e)
        {

            string sqlstring = "select * from contactos ";
            SqlDataAdapter da = new
            SqlDataAdapter(sqlstring, conexiondbsql);
            DataSet datasereport = new DataSet();
            da.Fill(datasereport, "contactos");


            ContactosCumplesmes mydatareport = new ContactosCumplesmes();
            //  Contacoxgenero mydatareport = new Contacoxgenero();
            mydatareport.SetDataSource(datasereport);
            crystalReportViewer1.ReportSource = mydatareport;

        }
    }
}
