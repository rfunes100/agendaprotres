using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace agendaprogran.Formularios
{
    public partial class Agendafrm : Form
    {


        public string conexiondbsql = Properties.Settings.Default.conexion;
        public string sqlconsulta = "";
        public string genero = "";
        public int id = 0;
        public int idcorreo = 0;
        public int idtelefono = 0;
    

        public Agendafrm()
        {
            InitializeComponent();
        }

        private void refrescaragenda()
        {
            var consulta = "select Idcontacto , nombre , apellido , sexo, fechaNacimiento, sobrenombre,  obseervacion, direccion, car.cargo, sec.sector  from contactos " +
                          " inner join cargo car on car.idcargo =  cargoid "+
                          " inner join sector sec on sec.idsector = sectoridcon ";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvcontactos.DataSource = ds.Tables[0];

        }

        private void refrescorreos()
        {
            var consulta = string.Format(" select idcorreo , concat( correo, dom.dominio ) as correo , tipo.tipocorreo from correos corre " +
                " inner join  tipocorreo tipo on tipo.idtipocorreo = corre. tipocorreoid " +
                " inner join  dominio dom on dom.iddominio = corre. dominioid  " +
                " where  contactoid = {0} ", id);
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvcorreos.DataSource = ds.Tables[0];

        }

        private void refrestelefonos()
        {
            var consulta = string.Format(" select idtelefono,	numero , ope.operador, cat.categoria  from telefonos tel " +
                " inner join operador ope on ope.idoperador = tel.operadorid "+
                " inner join catggoria cat on cat.idcategoria = tel.categoriaid "+
                "where  contactoid = {0} ", id);
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvtelefonos.DataSource = ds.Tables[0];

        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            rbtnhombre.Checked = false;
            rbtnfemenino.Checked = false;
            dtfechanacimiento.Text = "";
            txtobservacion.Text = "";
            txtdireccion.Text = "";
            txtsobrenombre.Text = "";
            cmbcargo.Text= "Seleccionar";
      


        }

        private void cargaroperacion()
        {

            var consulta = string.Format(" select idcargo ,	cargo  from cargo ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbcargo.DisplayMember = "cargo";
            cmbcargo.ValueMember = "idcargo";
            cmbcargo.DataSource = ds.Tables[0];


        }


        private void cargarsector()
        {

            var consulta = string.Format(" select idsector ,	sector  from sector ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbsector.DisplayMember = "sector";
            cmbsector.ValueMember = "idsector";
            cmbsector.DataSource = ds.Tables[0];


        }

        private void cargardominio()
        {

            var consulta = string.Format(" select iddominio , dominio from dominio ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbdominio.DisplayMember = "dominio";
            cmbdominio.ValueMember = "iddominio";
            cmbdominio.DataSource = ds.Tables[0];


        }

        private void cargartipocorreo()
        {

            var consulta = string.Format(" select idtipocorreo, tipocorreo  from tipocorreo ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbtipocorreo.DisplayMember = "tipocorreo";
            cmbtipocorreo.ValueMember = "idtipocorreo";
            cmbtipocorreo.DataSource = ds.Tables[0];


        }

        private void cargaroperador()
        {

            var consulta = string.Format(" select idoperador, operador  from operador ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmboperador.DisplayMember = "operador";
            cmboperador.ValueMember = "idoperador";
            cmboperador.DataSource = ds.Tables[0];


        }


        private void cargarcategoria()
        {

            var consulta = string.Format(" select idcategoria, categoria  from catggoria ");
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexiondbsql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbcategoria.DisplayMember = "categoria";
            cmbcategoria.ValueMember = "idcategoria";
            cmbcategoria.DataSource = ds.Tables[0];


        }

        private void Agendafrm_Load(object sender, EventArgs e)
        {
            this.cargaroperador();
            this.cargarcategoria();
            this.cargaroperacion();
            this.cargartipocorreo();
            this.cargardominio();
            this.refrescaragenda();
            this.cargarsector();
          

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if ( txtnombre.Text == ""  || txtapellido.Text == "" || dtfechanacimiento.Text == "" || txtobservacion.Text == "" || txtsobrenombre.Text == "" || txtdireccion.Text == "" )
            {
                MessageBox.Show("Se debe llenar los campos de nombre, apellido, fecha de nacimiento.");
            }
            else
            {
     



            SqlConnection conexion = new SqlConnection(conexiondbsql);
            conexion.Open();
            sqlconsulta = string.Format(" insert into contactos (nombre, apellido, sexo, fechaNacimiento, obseervacion, sobrenombre, direccion, cargoid, sectoridcon  ) " +
                " values ( '{0}','{1}','{2}','{3}','{4}','{5}','{6}', {7}, {8}) "
                , txtnombre.Text , txtapellido.Text, genero, dtfechanacimiento.Text, txtobservacion.Text,
                 txtsobrenombre.Text , txtdireccion.Text , cmbcargo.SelectedValue , cmbsector.SelectedValue);
            SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
            cmd.ExecuteNonQuery();
            this.limpiar();
            this.refrescaragenda();
            MessageBox.Show("Se agrego contacto de forma exitosa.");
            conexion.Close();
            }



        }

        private void rbtnfemenino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "MUJER";

        }

        private void rbtnhombre_CheckedChanged(object sender, EventArgs e)
        {
            genero = "HOMBRE";
        }
      

        private void dgvcontactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
            DataGridViewRow selectedrow = dgvcontactos.Rows[index];
            if(!string.IsNullOrEmpty(selectedrow.Cells[0].Value.ToString() )   )
            { 
            id = Convert.ToInt32( selectedrow.Cells[0].Value );
            }
            txtnombre.Text = selectedrow.Cells[1].Value.ToString();
            txtapellido.Text = selectedrow.Cells[2].Value.ToString();
            genero = selectedrow.Cells[3].Value.ToString();

            if ( genero == "HOMBRE")
            {
                rbtnhombre.Checked = true;
            }
            else
            {
                rbtnfemenino.Checked = true;
            }

            dtfechanacimiento.Text = selectedrow.Cells[4].Value.ToString();
            txtsobrenombre.Text = selectedrow.Cells[5].Value.ToString();
            txtobservacion.Text = selectedrow.Cells[6].Value.ToString();
            txtdireccion.Text = selectedrow.Cells[7].Value.ToString();

            cmbcargo.Text = selectedrow.Cells[8].Value.ToString();
            cmbsector.Text = selectedrow.Cells[9].Value.ToString();

            this.refrescorreos();
            this.refrestelefonos();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarcontacto_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea borrar este contacto", "confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
   
                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" delete from  contactos where Idcontacto  = {0} "
                    , id);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescaragenda();
                MessageBox.Show("Se borro contacto de forma exitosa.");
                conexion.Close();


            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea modificar este contacto", "confirmation",
        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {

                if ((txtnombre.Text == "") || txtapellido.Text == "" || dtfechanacimiento.Text == "")
                {
                    MessageBox.Show("Se debe llenar los campos de nombre, apellido, fecha de nacimiento.");
                }
                else
                {

                  //  cargoid = cmbcargo.SelectedValue
                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" update contactos set nombre = '{0}', apellido = '{1}', sexo = '{2}',  fechaNacimiento ='{3}' , " +
                " obseervacion ='{5}' , sobrenombre ='{6}' , direccion ='{7}' , cargoid = {8}  , sectoridcon = {9}   where Idcontacto = '{4}'  "
                , txtnombre.Text, txtapellido.Text, genero, dtfechanacimiento.Text, id, txtobservacion.Text , txtsobrenombre.Text, txtdireccion.Text, cmbcargo.SelectedValue
                , cmbsector.SelectedValue);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrescaragenda();
                this.limpiar();
                MessageBox.Show("Se modifico el contacto de forma exitosa.");
                conexion.Close();
                }

            }

        }


        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (this.txtcorreo.Text.Contains("@") || this.txtcorreo.Text.Contains("."))
            {
                MessageBox.Show("por favor no ingrese correo valido debe llevar punto . y @ ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnaddcorreo_Click(object sender, EventArgs e)
        {

            if(id == 0)
            {
                MessageBox.Show("Debe seleccionar al contacto que le va agregar el correo.");
            }
            else
            {
     

            SqlConnection conexion = new SqlConnection(conexiondbsql);
            conexion.Open();
            sqlconsulta = string.Format(" insert into correos ( 	correo,	contactoid ,tipocorreoid ,dominioid ) values ( '{0}',{1}, {2}, {3} ) "
                , txtcorreo.Text, id, cmbtipocorreo.SelectedValue, cmbdominio.SelectedValue);
            SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
            cmd.ExecuteNonQuery();
            this.refrescorreos();
                txtcorreo.Text = "";
            MessageBox.Show("Se agrego correo de forma exitosa.");
            conexion.Close();
            }


        }

        private void btneliminarcorreo_Click(object sender, EventArgs e)
        {


            if (idcorreo == 0)
            {
                MessageBox.Show("Debe seleccionar al contacto que le va agregar el correo.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este correo", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  correos where idcorreo = {0} "
                        , idcorreo );
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrescorreos();
                    MessageBox.Show("Se borro el correo de forma exitosa.");
                    conexion.Close();
                }


            }


            }

        private void btnaddtel_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Debe seleccionar al contacto que le va agregar el correo.");
            }
            else
            {




                SqlConnection conexion = new SqlConnection(conexiondbsql);
                conexion.Open();
                sqlconsulta = string.Format(" insert into telefonos ( 	numero ,	contactoid, operadorid, categoriaid  ) values ( '{0}',{1},{2},{3}) "
                    , txttelefono.Text, id, cmboperador.SelectedValue, cmbcategoria.SelectedValue);
                SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                cmd.ExecuteNonQuery();
                this.refrestelefonos();
                txttelefono.Text = "";
                MessageBox.Show("Se agrego telefono de forma exitosa.");
                conexion.Close();
            }
        }

        private void btndeltel_Click(object sender, EventArgs e)
        {
            if (idtelefono == 0)
            {
                MessageBox.Show("Debe seleccionar al contacto que le va agregar el correo.");
            }
            else
            {

                if (MessageBox.Show("Desea eliminar este telefono", "confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {

                    SqlConnection conexion = new SqlConnection(conexiondbsql);
                    conexion.Open();
                    sqlconsulta = string.Format(" delete from  telefonos where idtelefono = {0} "
                        , idtelefono);
                    SqlCommand cmd = new SqlCommand(sqlconsulta, conexion);
                    cmd.ExecuteNonQuery();
                    this.refrestelefonos();
                    MessageBox.Show("Se borro el telefono de forma exitosa.");
                    conexion.Close();
                }


            }

        }

        private void txttelefono_Leave(object sender, EventArgs e)
        {

            int parsedValue;
            if (!int.TryParse(txttelefono.Text, out parsedValue))
            {
                MessageBox.Show("es para numeros unicamente");
                return;
            }


        }

        private void dgvcorreos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedrow = dgvcorreos.Rows[index];
            if (!string.IsNullOrEmpty(selectedrow.Cells[0].Value.ToString()))
            {
                idcorreo = Convert.ToInt32(selectedrow.Cells[0].Value);
            }


        }

        private void dgvtelefonos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;


            DataGridViewRow selectedrow = dgvtelefonos.Rows[index];
            if (!string.IsNullOrEmpty(selectedrow.Cells[0].Value.ToString()))
            {
                idtelefono = Convert.ToInt32(selectedrow.Cells[0].Value);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

