using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioDental
{
    public partial class MenuUsuer : MaterialSkin.Controls.MaterialForm
    {
        public MenuUsuer()
        {
            InitializeComponent();
        }

        private void MenuUsuer_Load(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.ShowDialog();
        }

        private void btnDentistas_Click(object sender, EventArgs e)
        {
            frmDentistas frmDentistas = new frmDentistas();
            frmDentistas.ShowDialog();
        }

        private void btnTratamiento_Click(object sender, EventArgs e)
        {
            frmTratamientos frmTratamientos = new frmTratamientos();
            frmTratamientos.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            frmCitas frmCitas = new frmCitas();
            frmCitas.ShowDialog();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            frmCobros frmcobros = new frmCobros();
            frmcobros.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmReportes frmReportes = new frmReportes();
            frmReportes.ShowDialog();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Dispose();
        }

        private void BtnGuiaDeUsuario_Click(object sender, EventArgs e)
        {
            Process.Start("MS_Manual_De_Usuario_SIGCO.pdf");
        }

        private void MenuUsuer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            Dispose();
        }
    }
}
