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
    public partial class Tiposectorfrm : Form
    {
        public Tiposectorfrm()
        {
            InitializeComponent();
        }
        public string conexiondbsql = Properties.Settings.Default.conexion;
        public string sqlconsulta = "";
        private int idtiposector = 0;

        private void refrescar()
        {
            var consulta = " select idtipsector,  sector from tiposector  ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvtiposector.DataSource = ds.Tables[0];

        }



        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtsector.Text == "")
            {
                MessageBox.Show("El municipio esta vacio.");
            }
            else
            {


                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" insert into tiposector ( sector ) values ( '{0}' ) "
                    , txtsector.Text);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescar();
                txtsector.Text = "";
                MessageBox.Show("Se agrego tipo de sector de forma exitosa.");
                conexion.Close();
            }


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idtiposector == 0)
            {
                MessageBox.Show("Debe seleccionar al tipo de sector  que se va eliminar.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este tipo sector", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  tiposector where idtipsector = {0} "
                        , idtiposector);
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrescar();
                    MessageBox.Show("Se borro el tipo de sector de forma exitosa.");
                    conexion.Close();
                }


            }

        }

        private void Tiposectorfrm_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void dgvtiposector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dgvtiposector.Rows[index];
            idtiposector = Convert.ToInt32(selectedrow.Cells[0].Value);


        }
    }
}
