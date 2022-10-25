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
    public partial class Telefonocontactofrm : Form
    {
        public string conexiondbsql = Properties.Settings.Default.conexion;

        public Telefonocontactofrm()
        {
            InitializeComponent();
        }

        private void Telefonocontactofrm_Load(object sender, EventArgs e)
        {

            string sqlstring = " select max( Idcontacto) as Idcontacto , max( nombre) as  nombre, max( apellido) as apellido , max( fechaNacimiento ) as fechaNacimiento " +
                                            " , max( sexo) as sexo , max(idtelefono) as idtelefono ,  concat( SUBSTRING(numero,1,4), '-', SUBSTRING(numero,5,8) ) as numero , contactoid , " +
                                            " ROW_NUMBER() OVER ( partition by contactoid  ORDER BY  contactoid asc ) AS rown " +
                                            " from contactos con inner join telefonos cor on cor.contactoid = con.Idcontacto " +
                                            " group by contactoid , numero " +
                                            " order by Idcontacto asc ";
            SqlDataAdapter da = new
            SqlDataAdapter(sqlstring, conexiondbsql);
            DataSet datasereport = new DataSet();
            da.Fill(datasereport, "Telefonosxcontacto");


            Telefonocontactorpt mydatareport = new Telefonocontactorpt();
            //  Contacoxgenero mydatareport = new Contacoxgenero();
            mydatareport.SetDataSource(datasereport);
            crystalReportViewer1.ReportSource = mydatareport;

        }
    }
}
