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
    public partial class Departamentofrm : Form
    {


        public string conexiondbsql = Properties.Settings.Default.conexion;
        public string sqlconsulta = "";
        private int iddepto = 0;

        public Departamentofrm()
        {
            InitializeComponent();
        }

        private void refrescardepartamento()
        {
            var consulta = " select iddepto ,	departamento from departamento  ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvdepto.DataSource = ds.Tables[0];

        }


        private void Departamentofrm_Load(object sender, EventArgs e)
        {
            this.refrescardepartamento();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtdepto.Text == "")
            {
                MessageBox.Show("El departamento esta vacio.");
            }
            else
            {


                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" insert into departamento ( departamento  ) values ( '{0}' ) "
                    , txtdepto.Text);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescardepartamento();
                txtdepto.Text = "";
                MessageBox.Show("Se agrego departamento de forma exitosa.");
                conexion.Close();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (iddepto == 0)
            {
                MessageBox.Show("Debe seleccionar al cargo que se va eliminar.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este departamento", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  departamento where iddepto = {0} "
                        , iddepto);
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrescardepartamento();
                    MessageBox.Show("Se borro el departamento de forma exitosa.");
                    conexion.Close();
                }


            }
        }

        private void dgvdepto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dgvdepto.Rows[index];
            iddepto = Convert.ToInt32(selectedrow.Cells[0].Value);
        }
    }
}
