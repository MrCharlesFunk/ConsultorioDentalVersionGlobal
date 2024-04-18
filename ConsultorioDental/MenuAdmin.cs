using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioDental.Utilerias;
using MaterialSkin;

namespace ConsultorioDental
{
    public partial class frmMenu : MaterialSkin.Controls.MaterialForm
    {
        public frmMenu(string usuario)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal400,
                Primary.Teal600,
                Primary.BlueGrey500,
                Accent.Indigo200,
                TextShade.WHITE);
            lbUsuario.Text = "Bienvenido: "+usuario;
        }

        private void frmMenu_Load(object sender, EventArgs e)
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

        private void btnPacientes_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Administra tus pacientes", btnPacientes, 10, 50, 3000);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmReportes frmReportes = new frmReportes();
            frmReportes.ShowDialog();
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Process.Start("MS_Manual_De_Usuario_SIGCO.pdf");
            }
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

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            Dispose();
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            CambiarContraseña cambiarContraseña = new CambiarContraseña();
            cambiarContraseña.ShowDialog();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            frmRestaurar frmRestaurar = new frmRestaurar();
            frmRestaurar.ShowDialog();
        }
    }
}
