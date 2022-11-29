using agendaprogran.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaprogran.Formularios
{
    public partial class Menufrn : Form
    {
        private int childFormNumber = 0;

        public Menufrn()
        {
          
            InitializeComponent();
           


        }

        private void Agenda(object sender, EventArgs e)
        {

            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();

            Agendafrm hijoagenda = new Agendafrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();

        }


        private void ShowNewForm(object sender, EventArgs e)
        {
         //   Form childForm = new Form();
         //   childForm.MdiParent = this;
         //   childForm.Text = "Window " + childFormNumber++;
          //  childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

     

        private void Menu_Load(object sender, EventArgs e)
        {



        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip_Click(object sender, EventArgs e)
        {
        

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactoxgeneroparam hijoagenda = new contactoxgeneroparam();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactosxcumplefrm hijoagenda = new contactosxcumplefrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();


        }

        private void telxcontactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefonocontactofrm hijoagenda = new Telefonocontactofrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();
        }

        private void correoxcontactoStripMenuItem_Click(object sender, EventArgs e)
        {
            Correocontactofrm hijoagenda = new Correocontactofrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();

        }

        private void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargofrm hijoagenda = new Cargofrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();
        }

        private void deptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentofrm hijoagenda = new Departamentofrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();

        }

        private void MunicipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Municipiofrm hijoagenda = new Municipiofrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();


        }

        private void tiposectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tiposectorfrm hijoagenda = new Tiposectorfrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();
        }

        private void SectorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sectorfrm hijoagenda = new Sectorfrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();

            
        }

        private void DominioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dominiofrm hijoagenda = new Dominiofrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();
        }

        private void tipocorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipocorreofrm hijoagenda = new tipocorreofrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();
        }

        private void operadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Operadorfrm hijoagenda = new Operadorfrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();
            
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Categoriafrm hijoagenda = new Categoriafrm();
            hijoagenda.MdiParent = this;
            hijoagenda.Show();


        }
    }
}
