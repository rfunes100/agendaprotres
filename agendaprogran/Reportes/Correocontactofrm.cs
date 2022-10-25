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
    public partial class Correocontactofrm : Form
    {

        public string conexiondbsql = Properties.Settings.Default.conexion;

     //   ReportDocument crypt = new ReportDocument();

        public Correocontactofrm()
        {
            InitializeComponent();
        }

        private void Correocontactofrm_Load(object sender, EventArgs e)
        {


            string sqlstring =  " select max( Idcontacto) as Idcontacto , max( nombre) as  nombre , max( apellido) as apellido , max( fechaNacimiento ) as fechaNacimiento  "+
                                             " , max( sexo) as sexo , max(idcorreo) as idcorreo ,  correo , contactoid , " +
                                             " ROW_NUMBER() OVER ( partition by contactoid  ORDER BY  contactoid asc ) AS rown "+
                                             " from contactos con inner join correos cor on cor.contactoid = con.Idcontacto " +
                                             " group by contactoid , correo " +
                                             " order by Idcontacto asc ";
            SqlDataAdapter da = new
            SqlDataAdapter(sqlstring, conexiondbsql); 
            DataSet datasereport = new DataSet();
            da.Fill(datasereport, "Correoxcontacto");


            Correocontactorpt mydatareport = new Correocontactorpt();
            //  Contacoxgenero mydatareport = new Contacoxgenero();
            mydatareport.SetDataSource(datasereport);
            crystalReportViewer1.ReportSource = mydatareport;

        }
    }
}
