using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Aplication_process
{
    public partial class MDIprincipal : Form
    {
        private int childFormNumber = 0;

        public MDIprincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (menuVeritical2.Width == 250)
            {
                menuVeritical2.Width = 70;
            }
            else {
                menuVeritical2.Width = 250;
            }
        }

        private void icon_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icon_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icon_Restaurar.Visible = true;
            icon_Maximizar.Visible = false;
        }

        private void icon_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icon_Restaurar.Visible = false;
            icon_Maximizar.Visible = true;
        }

        private void icon_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
