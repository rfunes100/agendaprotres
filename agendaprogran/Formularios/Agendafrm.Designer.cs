
namespace agendaprogran.Formularios
{
    partial class Agendafrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btndeltel = new System.Windows.Forms.Button();
            this.btnaddtel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvtelefonos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbtipocorreo = new System.Windows.Forms.ComboBox();
            this.cmbdominio = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btneliminarcorreo = new System.Windows.Forms.Button();
            this.btnaddcorreo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvcorreos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvcontactos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbsector = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsobrenombre = new System.Windows.Forms.TextBox();
            this.cmbcargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.RichTextBox();
            this.txtobservacion = new System.Windows.Forms.RichTextBox();
            this.btneliminarcontacto = new System.Windows.Forms.Button();
            this.dtfechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtnhombre = new System.Windows.Forms.RadioButton();
            this.rbtnfemenino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmboperador = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtelefonos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcorreos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 652);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agenda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmboperador);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.cmbcategoria);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.btndeltel);
            this.groupBox5.Controls.Add(this.btnaddtel);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txttelefono);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(0, 417);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(565, 202);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "telefono";
            // 
            // btndeltel
            // 
            this.btndeltel.Location = new System.Drawing.Point(492, 174);
            this.btndeltel.Name = "btndeltel";
            this.btndeltel.Size = new System.Drawing.Size(64, 20);
            this.btndeltel.TabIndex = 6;
            this.btndeltel.Text = "eliminar";
            this.btndeltel.UseVisualStyleBackColor = true;
            this.btndeltel.Click += new System.EventHandler(this.btndeltel_Click);
            // 
            // btnaddtel
            // 
            this.btnaddtel.Location = new System.Drawing.Point(492, 150);
            this.btnaddtel.Name = "btnaddtel";
            this.btnaddtel.Size = new System.Drawing.Size(64, 20);
            this.btnaddtel.TabIndex = 5;
            this.btnaddtel.Text = "Agregar";
            this.btnaddtel.UseVisualStyleBackColor = true;
            this.btnaddtel.Click += new System.EventHandler(this.btnaddtel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefono:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(61, 154);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(174, 20);
            this.txttelefono.TabIndex = 3;
            this.txttelefono.Leave += new System.EventHandler(this.txttelefono_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvtelefonos);
            this.groupBox6.Location = new System.Drawing.Point(3, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(565, 119);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Listado de Telefonos";
            // 
            // dgvtelefonos
            // 
            this.dgvtelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtelefonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtelefonos.Location = new System.Drawing.Point(3, 16);
            this.dgvtelefonos.Name = "dgvtelefonos";
            this.dgvtelefonos.RowHeadersWidth = 51;
            this.dgvtelefonos.RowTemplate.Height = 25;
            this.dgvtelefonos.Size = new System.Drawing.Size(559, 100);
            this.dgvtelefonos.TabIndex = 0;
            this.dgvtelefonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtelefonos_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbtipocorreo);
            this.groupBox3.Controls.Add(this.cmbdominio);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btneliminarcorreo);
            this.groupBox3.Controls.Add(this.btnaddcorreo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtcorreo);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(3, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Correos";
            // 
            // cmbtipocorreo
            // 
            this.cmbtipocorreo.FormattingEnabled = true;
            this.cmbtipocorreo.Location = new System.Drawing.Point(298, 153);
            this.cmbtipocorreo.Name = "cmbtipocorreo";
            this.cmbtipocorreo.Size = new System.Drawing.Size(191, 21);
            this.cmbtipocorreo.TabIndex = 10;
            // 
            // cmbdominio
            // 
            this.cmbdominio.FormattingEnabled = true;
            this.cmbdominio.Location = new System.Drawing.Point(49, 178);
            this.cmbdominio.Name = "cmbdominio";
            this.cmbdominio.Size = new System.Drawing.Size(191, 21);
            this.cmbdominio.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(252, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 26);
            this.label13.TabIndex = 8;
            this.label13.Text = "Tipo \r\ncorreo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Dominio:";
            // 
            // btneliminarcorreo
            // 
            this.btneliminarcorreo.Location = new System.Drawing.Point(495, 177);
            this.btneliminarcorreo.Name = "btneliminarcorreo";
            this.btneliminarcorreo.Size = new System.Drawing.Size(64, 20);
            this.btneliminarcorreo.TabIndex = 6;
            this.btneliminarcorreo.Text = "eliminar";
            this.btneliminarcorreo.UseVisualStyleBackColor = true;
            this.btneliminarcorreo.Click += new System.EventHandler(this.btneliminarcorreo_Click);
            // 
            // btnaddcorreo
            // 
            this.btnaddcorreo.Location = new System.Drawing.Point(495, 152);
            this.btnaddcorreo.Name = "btnaddcorreo";
            this.btnaddcorreo.Size = new System.Drawing.Size(64, 20);
            this.btnaddcorreo.TabIndex = 5;
            this.btnaddcorreo.Text = "Agregar";
            this.btnaddcorreo.UseVisualStyleBackColor = true;
            this.btnaddcorreo.Click += new System.EventHandler(this.btnaddcorreo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(49, 152);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(191, 20);
            this.txtcorreo.TabIndex = 3;
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvcorreos);
            this.groupBox4.Location = new System.Drawing.Point(3, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 119);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listado de correos";
            // 
            // dgvcorreos
            // 
            this.dgvcorreos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcorreos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcorreos.Location = new System.Drawing.Point(3, 16);
            this.dgvcorreos.Name = "dgvcorreos";
            this.dgvcorreos.RowHeadersWidth = 51;
            this.dgvcorreos.RowTemplate.Height = 25;
            this.dgvcorreos.Size = new System.Drawing.Size(553, 100);
            this.dgvcorreos.TabIndex = 0;
            this.dgvcorreos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcorreos_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvcontactos);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contactos";
            // 
            // dgvcontactos
            // 
            this.dgvcontactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvcontactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcontactos.Location = new System.Drawing.Point(3, 16);
            this.dgvcontactos.Name = "dgvcontactos";
            this.dgvcontactos.RowHeadersWidth = 51;
            this.dgvcontactos.RowTemplate.Height = 25;
            this.dgvcontactos.Size = new System.Drawing.Size(559, 164);
            this.dgvcontactos.TabIndex = 0;
            this.dgvcontactos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcontactos_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "info contactos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbsector);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtsobrenombre);
            this.groupBox1.Controls.Add(this.cmbcargo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtobservacion);
            this.groupBox1.Controls.Add(this.btneliminarcontacto);
            this.groupBox1.Controls.Add(this.dtfechanacimiento);
            this.groupBox1.Controls.Add(this.rbtnhombre);
            this.groupBox1.Controls.Add(this.rbtnfemenino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Location = new System.Drawing.Point(64, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 290);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "informacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Sector:";
            // 
            // cmbsector
            // 
            this.cmbsector.FormattingEnabled = true;
            this.cmbsector.Location = new System.Drawing.Point(74, 210);
            this.cmbsector.Name = "cmbsector";
            this.cmbsector.Size = new System.Drawing.Size(133, 21);
            this.cmbsector.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Apodo:";
            // 
            // txtsobrenombre
            // 
            this.txtsobrenombre.Location = new System.Drawing.Point(276, 176);
            this.txtsobrenombre.Name = "txtsobrenombre";
            this.txtsobrenombre.Size = new System.Drawing.Size(133, 20);
            this.txtsobrenombre.TabIndex = 17;
            // 
            // cmbcargo
            // 
            this.cmbcargo.FormattingEnabled = true;
            this.cmbcargo.Location = new System.Drawing.Point(74, 175);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(133, 21);
            this.cmbcargo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Observacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Direccion:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(276, 108);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(133, 46);
            this.txtdireccion.TabIndex = 13;
            this.txtdireccion.Text = "";
            // 
            // txtobservacion
            // 
            this.txtobservacion.Location = new System.Drawing.Point(74, 108);
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(133, 46);
            this.txtobservacion.TabIndex = 12;
            this.txtobservacion.Text = "";
            // 
            // btneliminarcontacto
            // 
            this.btneliminarcontacto.Location = new System.Drawing.Point(248, 244);
            this.btneliminarcontacto.Name = "btneliminarcontacto";
            this.btneliminarcontacto.Size = new System.Drawing.Size(64, 20);
            this.btneliminarcontacto.TabIndex = 11;
            this.btneliminarcontacto.Text = "Eliminar";
            this.btneliminarcontacto.UseVisualStyleBackColor = true;
            this.btneliminarcontacto.Click += new System.EventHandler(this.btneliminarcontacto_Click);
            // 
            // dtfechanacimiento
            // 
            this.dtfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechanacimiento.Location = new System.Drawing.Point(280, 62);
            this.dtfechanacimiento.Name = "dtfechanacimiento";
            this.dtfechanacimiento.Size = new System.Drawing.Size(129, 20);
            this.dtfechanacimiento.TabIndex = 10;
            // 
            // rbtnhombre
            // 
            this.rbtnhombre.AutoSize = true;
            this.rbtnhombre.Location = new System.Drawing.Point(137, 66);
            this.rbtnhombre.Name = "rbtnhombre";
            this.rbtnhombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnhombre.TabIndex = 9;
            this.rbtnhombre.TabStop = true;
            this.rbtnhombre.Text = "Hombre";
            this.rbtnhombre.UseVisualStyleBackColor = true;
            this.rbtnhombre.CheckedChanged += new System.EventHandler(this.rbtnhombre_CheckedChanged);
            // 
            // rbtnfemenino
            // 
            this.rbtnfemenino.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.rbtnfemenino.AutoSize = true;
            this.rbtnfemenino.Location = new System.Drawing.Point(64, 66);
            this.rbtnfemenino.Name = "rbtnfemenino";
            this.rbtnfemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtnfemenino.TabIndex = 8;
            this.rbtnfemenino.TabStop = true;
            this.rbtnfemenino.Text = "Femenino";
            this.rbtnfemenino.UseVisualStyleBackColor = true;
            this.rbtnfemenino.CheckedChanged += new System.EventHandler(this.rbtnfemenino_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha \r\nNacimiento:";
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(161, 244);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(64, 20);
            this.btneditar.TabIndex = 5;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(64, 244);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(64, 20);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(74, 23);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(133, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(280, 23);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(129, 20);
            this.txtapellido.TabIndex = 0;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(61, 180);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(174, 21);
            this.cmbcategoria.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 10);
            this.label14.TabIndex = 10;
            this.label14.Text = "Categoria:";
            // 
            // cmboperador
            // 
            this.cmboperador.FormattingEnabled = true;
            this.cmboperador.Location = new System.Drawing.Point(301, 154);
            this.cmboperador.Name = "cmboperador";
            this.cmboperador.Size = new System.Drawing.Size(177, 21);
            this.cmboperador.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(241, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Operador:";
            // 
            // Agendafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 663);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Agendafrm";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agendafrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtelefonos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcorreos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvcontactos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.RadioButton rbtnhombre;
        private System.Windows.Forms.RadioButton rbtnfemenino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtfechanacimiento;
        private System.Windows.Forms.Button btneliminarcontacto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvcorreos;
        private System.Windows.Forms.MaskedTextBox txtcorreo;
        private System.Windows.Forms.Button btneliminarcorreo;
        private System.Windows.Forms.Button btnaddcorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btndeltel;
        private System.Windows.Forms.Button btnaddtel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvtelefonos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsobrenombre;
        private System.Windows.Forms.ComboBox cmbcargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtdireccion;
        private System.Windows.Forms.RichTextBox txtobservacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbsector;
        private System.Windows.Forms.ComboBox cmbtipocorreo;
        private System.Windows.Forms.ComboBox cmbdominio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmboperador;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Label label14;
    }
}