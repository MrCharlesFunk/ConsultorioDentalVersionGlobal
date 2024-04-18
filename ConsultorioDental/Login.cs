using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioDental
{
    public partial class Login : MaterialSkin.Controls.MaterialForm

    {
        SqlConnection conexion = new SqlConnection("Server=.; DataBase=ConsultorioDentalCare; Integrated Security=SSPI");
        SqlDataAdapter adaptador;
        SqlCommand comando = new SqlCommand();
        int contador = 1;
        public Login()
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

           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cargarUsuarioCombo();
        }


        public void cargarUsuarioCombo()
        {
            
            cbUsuario.DataSource = consultaGeneral().Tables["General"];
            cbUsuario.DisplayMember = "Usuario";
            cbUsuario.ValueMember = "Usuario";
            
        }

        public DataSet consultaGeneral()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_USUARIO", conexion);
                adaptador.Fill(data, "General");

                return data;

            }

        }


        private String RevisarContraseña()
        {
            String contraseña= txtContraseña.Text;
            // Convertir la cadena a bytes
            byte[] inputBytes = Encoding.UTF8.GetBytes(contraseña);

            // Crear un objeto de hash MD5
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                // Calcular el hash MD5
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convertir el hash a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public DataSet consultaIndividual(String nombre)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_INDIVIDUAL_USUARIO", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@Nombre", SqlDbType.VarChar);
                n.Value = nombre;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "User");

                return data;

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String contraseña = RevisarContraseña();
            String contraseñaEncriptada, rol;
            string nombre = cbUsuario.Text;
            DataTable cargarUsuario = consultaIndividual(nombre).Tables["User"];
            DataRow d = cargarUsuario.Rows[0];
            contraseñaEncriptada = d["Contraseña"].ToString();
            rol = d["Rol"].ToString();
            if (contraseña.Equals(contraseñaEncriptada))
            {

                contador = 0;
                if (rol.Equals("Administrador"))
                {
                    frmMenu frmMenu = new frmMenu(cbUsuario.Text);
                    Visible = false;
                    frmMenu.ShowDialog();

                }
                else
                {
                    MenuUsuer menuUsuer = new MenuUsuer();
                    Visible = false;
                    menuUsuer.ShowDialog();
                }
            }
            else
            {

                MessageBox.Show("Contraseña incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                // Si es un espacio, se controla el evento y no se escribe el carácter
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;

            }
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
        }
    }


}
