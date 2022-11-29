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
    public partial class Categoriafrm : Form
    {
        public Categoriafrm()
        {
            InitializeComponent();
        }

        public string conexiondbsql = Properties.Settings.Default.conexion;
        public string sqlconsulta = "";
        private int idcargo = 0;

        private void refrescar()
        {
            var consulta = "  select idcategoria , categoria from catggoria ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvcategoria.DataSource = ds.Tables[0];

        }

        private void Categoriafrm_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void dgvcategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dgvcategoria.Rows[index];
            idcargo = Convert.ToInt32(selectedrow.Cells[0].Value);

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcategoria.Text == "")
            {
                MessageBox.Show("El registro esta vacio.");
            }
            else
            {


                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" insert into catggoria ( categoria  ) values ( '{0}' ) "
                    , txtcategoria.Text);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescar();
                txtcategoria.Text = "";
                MessageBox.Show("Se agrego regsitro de forma exitosa.");
                conexion.Close();
            }


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idcargo == 0)
            {
                MessageBox.Show("Debe seleccionar al registro que se va eliminar.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este registro", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  catggoria where idcategoria = {0} "
                        , idcargo);
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrescar();
                    MessageBox.Show("Se borro el registro de forma exitosa.");
                    conexion.Close();
                }


            }

        }
    }
}
