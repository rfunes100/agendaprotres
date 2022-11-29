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
    public partial class Municipiofrm : Form
    {
        public Municipiofrm()
        {
            InitializeComponent();
        }

        public string conexiondbsql = Properties.Settings.Default.conexion;
        public string sqlconsulta = "";
        private int idmunicipio = 0;


        private void cargardepartamento()
        {

            var consulta = string.Format(" select iddepto ,	departamento  from departamento ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbepartamento.DisplayMember = "departamento";
            cmbepartamento.ValueMember = "iddepto";
            cmbepartamento.DataSource = ds.Tables[0];


        }

        private void refrescarmunicipio()
        {
            var consulta = " select idmunicipio ,	municipio	, depto.departamento  from municipio "+
                   " inner join departamento depto on depto.iddepto = deptoid";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvmunicipio.DataSource = ds.Tables[0];

        }




        private void btnagregar_Click(object sender, EventArgs e)
        {

            if (txtmunicipio.Text == "")
            {
                MessageBox.Show("El municipio esta vacio.");
            }
            else
            {


                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" insert into municipio ( municipio, deptoid  ) values ( '{0}', {1} ) "
                    , txtmunicipio.Text, cmbepartamento.SelectedValue);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescarmunicipio();
                txtmunicipio.Text = "";
                MessageBox.Show("Se agrego municipio de forma exitosa.");
                conexion.Close();
            }


        }

        private void Municipiofrm_Load(object sender, EventArgs e)
        {
            this.cargardepartamento();
            this.refrescarmunicipio();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idmunicipio == 0)
            {
                MessageBox.Show("Debe seleccionar al municipio que se va eliminar.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este municipio", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  municipio where idmunicipio = {0} "
                        , idmunicipio);
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrescarmunicipio();
                    MessageBox.Show("Se borro el municipio de forma exitosa.");
                    conexion.Close();
                }


            }

        }

        private void dgvmunicipio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dgvmunicipio.Rows[index];
            idmunicipio = Convert.ToInt32(selectedrow.Cells[0].Value);

        }
    }
}
