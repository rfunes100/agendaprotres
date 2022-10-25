using Microsoft.Reporting.WinForms;
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
using CrystalDecisions.CrystalReports.Engine;




namespace agendaprogran.Reportes
{



    public partial class Contactoxsexo : Form
    {
        public string conexiondbsql = Properties.Settings.Default.conexion;

        ReportDocument crypt = new ReportDocument();
      //  SqlConnection connection = new
          //     SqlConnection("Data Source=olimposrv;Initial Catalog=agenda;User ID=marcas;Password=marcas ");
        public string  genero = "";

    


        public Contactoxsexo(string generorecive)
        {
            InitializeComponent();
            genero = generorecive;

        }

        private void Contactoxsexo_Load(object sender, EventArgs e)
        {
            string sqlstring = "select * from contactos where sexo = '" + genero + "'";
            SqlDataAdapter da = new
               SqlDataAdapter(sqlstring, conexiondbsql);
            DataSet datasereport = new DataSet();
            da.Fill(datasereport, "contactos");


            Contactoxsexorpt mydatareport = new Contactoxsexorpt();
          //  Contacoxgenero mydatareport = new Contacoxgenero();
            mydatareport.SetDataSource(datasereport);
            crystalReportViewer1.ReportSource = mydatareport;
      
        }


        private void agendaDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
