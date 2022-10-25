
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
            this.tabControl1.Size = new System.Drawing.Size(442, 652);
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
            this.tabPage1.Size = new System.Drawing.Size(434, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agenda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btndeltel);
            this.groupBox5.Controls.Add(this.btnaddtel);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txttelefono);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(0, 400);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 186);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "telefono";
            // 
            // btndeltel
            // 
            this.btndeltel.Location = new System.Drawing.Point(339, 151);
            this.btndeltel.Name = "btndeltel";
            this.btndeltel.Size = new System.Drawing.Size(64, 20);
            this.btndeltel.TabIndex = 6;
            this.btndeltel.Text = "eliminar";
            this.btndeltel.UseVisualStyleBackColor = true;
            this.btndeltel.Click += new System.EventHandler(this.btndeltel_Click);
            // 
            // btnaddtel
            // 
            this.btnaddtel.Location = new System.Drawing.Point(258, 153);
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
            this.txttelefono.Size = new System.Drawing.Size(191, 20);
            this.txttelefono.TabIndex = 3;
            this.txttelefono.Leave += new System.EventHandler(this.txttelefono_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvtelefonos);
            this.groupBox6.Location = new System.Drawing.Point(3, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(430, 119);
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
            this.dgvtelefonos.RowTemplate.Height = 25;
            this.dgvtelefonos.Size = new System.Drawing.Size(424, 100);
            this.dgvtelefonos.TabIndex = 0;
            this.dgvtelefonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtelefonos_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btneliminarcorreo);
            this.groupBox3.Controls.Add(this.btnaddcorreo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtcorreo);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(3, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Correos";
            // 
            // btneliminarcorreo
            // 
            this.btneliminarcorreo.Location = new System.Drawing.Point(339, 151);
            this.btneliminarcorreo.Name = "btneliminarcorreo";
            this.btneliminarcorreo.Size = new System.Drawing.Size(64, 20);
            this.btneliminarcorreo.TabIndex = 6;
            this.btneliminarcorreo.Text = "eliminar";
            this.btneliminarcorreo.UseVisualStyleBackColor = true;
            this.btneliminarcorreo.Click += new System.EventHandler(this.btneliminarcorreo_Click);
            // 
            // btnaddcorreo
            // 
            this.btnaddcorreo.Location = new System.Drawing.Point(258, 153);
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
            this.groupBox4.Size = new System.Drawing.Size(430, 119);
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
            this.dgvcorreos.RowTemplate.Height = 25;
            this.dgvcorreos.Size = new System.Drawing.Size(424, 100);
            this.dgvcorreos.TabIndex = 0;
            this.dgvcorreos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcorreos_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvcontactos);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contactos";
            // 
            // dgvcontactos
            // 
            this.dgvcontactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcontactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcontactos.Location = new System.Drawing.Point(3, 16);
            this.dgvcontactos.Name = "dgvcontactos";
            this.dgvcontactos.RowTemplate.Height = 25;
            this.dgvcontactos.Size = new System.Drawing.Size(424, 164);
            this.dgvcontactos.TabIndex = 0;
            this.dgvcontactos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcontactos_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "info contactos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "informacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btneliminarcontacto
            // 
            this.btneliminarcontacto.Location = new System.Drawing.Point(259, 145);
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
            this.dtfechanacimiento.Location = new System.Drawing.Point(267, 62);
            this.dtfechanacimiento.Name = "dtfechanacimiento";
            this.dtfechanacimiento.Size = new System.Drawing.Size(129, 20);
            this.dtfechanacimiento.TabIndex = 10;
            // 
            // rbtnhombre
            // 
            this.rbtnhombre.AutoSize = true;
            this.rbtnhombre.Location = new System.Drawing.Point(130, 66);
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
            this.rbtnfemenino.Location = new System.Drawing.Point(57, 66);
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
            this.label1.Location = new System.Drawing.Point(200, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha \r\nNacimiento:";
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(172, 145);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(64, 20);
            this.btneditar.TabIndex = 5;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(75, 145);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(64, 20);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(57, 23);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(133, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 26);
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
            this.txtapellido.Location = new System.Drawing.Point(267, 23);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(129, 20);
            this.txtapellido.TabIndex = 0;
            // 
            // Agendafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 663);
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
    }
}