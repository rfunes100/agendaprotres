using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace agendaprogran.Formularios
{
    public partial class Sectorfrm : Form
    {
        public Sectorfrm()
        {
            InitializeComponent();
        }

        public string conexiondbsql = Properties.Settings.Default.conexion;
        public string sqlconsulta = "";
        private int idmunicipio = 0;


        private void cargarmunicipio()
        {

            var consulta = string.Format(" select idmunicipio ,	municipio from municipio ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbmunicipio.DisplayMember = "municipio";
            cmbmunicipio.ValueMember = "idmunicipio";
            cmbmunicipio.DataSource = ds.Tables[0];


        }



        private void cargartiposector()
        {

            var consulta = string.Format(" select idtipsector,  sector from tiposector  ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbtiposector.DisplayMember = "sector";
            cmbtiposector.ValueMember = "idtipsector";
            cmbtiposector.DataSource = ds.Tables[0];


        }

        private void refrescar()
        {
            var consulta = " select sec.idsector,	sec.sector,  mun.municipio , tipsec.sector  from sector  sec   " +
                   " inner join municipio mun on mun.idmunicipio =  sec.municipioid"+
                   " inner join  tiposector tipsec on tipsec.idtipsector =  sec.tiposectorid ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvsector.DataSource = ds.Tables[0];

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (txtsector.Text == "")
            {
                MessageBox.Show("El sector esta vacio.");
            }
            else
            {


                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" insert into sector ( sector	, municipioid,	tiposectorid  ) values ( '{0}', {1}, {2} ) "
                    , txtsector.Text, cmbmunicipio.SelectedValue, cmbtiposector.SelectedValue);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescar();
                txtsector.Text = "";
                MessageBox.Show("Se agrego sector de forma exitosa.");
                conexion.Close();
            }

        }

        private void Sectorfrm_Load(object sender, EventArgs e)
        {
            this.cargarmunicipio();
            this.cargartiposector();
            this.refrescar();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idmunicipio == 0)
            {
                MessageBox.Show("Debe seleccionar al sector que se va eliminar.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este sector", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  sector where idsector = {0} "
                        , idmunicipio);
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrescar();
                    MessageBox.Show("Se borro el sector de forma exitosa.");
                    conexion.Close();
                }


            }


        }

        private void dgvsector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dgvsector.Rows[index];
            idmunicipio = Convert.ToInt32(selectedrow.Cells[0].Value);


        }
    }
}
