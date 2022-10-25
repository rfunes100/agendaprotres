using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaprogran.Reportes
{
    public partial class contactoxgeneroparam : Form
    {
        public contactoxgeneroparam()
        {
            InitializeComponent();
        }

        private void contactoxgeneroparam_Load(object sender, EventArgs e)
        {

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {

            // Form 1
            // inside the button click event
            var valor = cmbgenero.SelectedValue;

            string selected = this.cmbgenero.GetItemText(this.cmbgenero.SelectedItem);

            contactoxgeneroparam frmparam = new contactoxgeneroparam();
            frmparam.Close();
            Contactoxsexo frm2 = new Contactoxsexo(selected);
            frm2.Show();
            
            

          
            

        }
    }
}
