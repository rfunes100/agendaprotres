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
    public partial class Dominiofrm : Form
    {

        public string conexiondbsql = Properties.Settings.Default.conexion;
        public string sqlconsulta = "";
        private int idcargo = 0;

        private void refrescar()
        {
            var consulta = "  select iddominio , dominio from dominio ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvdominio.DataSource = ds.Tables[0];

        }

        public Dominiofrm()
        {
            InitializeComponent();
        }

        private void Dominiofrm_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idcargo == 0)
            {
                MessageBox.Show("Debe seleccionar al dominio que se va eliminar.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este dominio", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  dominio where iddominio = {0} "
                        , idcargo);
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrescar();
                    MessageBox.Show("Se borro el dominio de forma exitosa.");
                    conexion.Close();
                }


            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtdominio.Text == "")
            {
                MessageBox.Show("El dominio esta vacio.");
            }
            else
            {


                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" insert into dominio ( dominio  ) values ( '{0}' ) "
                    , txtdominio.Text);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescar();
                txtdominio.Text = "";
                MessageBox.Show("Se agrego dominio de forma exitosa.");
                conexion.Close();
            }


        }

        private void dgvdominio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dgvdominio.Rows[index];
            idcargo = Convert.ToInt32(selectedrow.Cells[0].Value);
        }
    }
}
