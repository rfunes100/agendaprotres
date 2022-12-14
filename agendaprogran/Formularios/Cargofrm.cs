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
    public partial class Cargofrm : Form
    {
        public Cargofrm()
        {
            InitializeComponent();
        }

        public string conexiondbsql = Properties.Settings.Default.conexion;
        public string sqlconsulta = "";
        private  int idcargo = 0;


        private void refrescarcargo()
        {
            var consulta = " select idcargo,	cargo  from cargo  "             ;
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvcargos.DataSource = ds.Tables[0];

        }

        private void Cargofrm_Load(object sender, EventArgs e)
        {
            this.refrescarcargo();
           // dgvcargos.AutoSize = true;
           // dgvcargos.AutoSizeColumnsMode = Fill ;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (txtcargo.Text == "")
            {
                MessageBox.Show("El cargo esta vacio.");
            }
            else
            {


                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" insert into cargo ( cargo  ) values ( '{0}' ) "
                    , txtcargo.Text);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescarcargo();
                txtcargo.Text = "";
                MessageBox.Show("Se agrego Cargo de forma exitosa.");
                conexion.Close();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idcargo == 0)
            {
                MessageBox.Show("Debe seleccionar al cargo que se va eliminar.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este cargo", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  cargo where idcargo = {0} "
                        , idcargo);
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrescarcargo();
                    MessageBox.Show("Se borro el cargo de forma exitosa.");
                    conexion.Close();
                }


            }

        }

        private void dgvcargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dgvcargos.Rows[index];
            idcargo = Convert.ToInt32(selectedrow.Cells[0].Value);

        }
    }
}
