using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplication_process
{
    public partial class MDIprincipal : Form
    {
        private int childFormNumber = 0;

        public MDIprincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
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
         
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios a = new Usuarios();
            a.MdiParent = this;
            a.Show();
        }

        private void crearProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proyectos a = new Proyectos();
            a.MdiParent = this;
            a.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria_Proceso a = new Categoria_Proceso();
            a.MdiParent = this;
            a.Show();
        }

        private void tipoDePreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_preguntas a = new Tipo_preguntas();
            a.MdiParent = this;
            a.Show();
        }

        private void tipoDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Proyecto a = new Tipo_Proyecto();
            a.MdiParent = this;
            a.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles a = new Roles();
            a.MdiParent = this;
            a.Show();


        }

        private void preguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.MdiParent = this;
            p.Show();
        }
    }
}
