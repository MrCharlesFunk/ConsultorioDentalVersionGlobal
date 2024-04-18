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
    public partial class CambiarContraseña : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection conexion = new SqlConnection("Server=.; DataBase=ConsultorioDentalCare; Integrated Security=SSPI");
        SqlDataAdapter adaptador;
        SqlCommand comando = new SqlCommand();
        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
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
            String contraseña = txtContraseña.Text;
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

        private void btnNuevaContrasena_Click(object sender, EventArgs e)
        {
            
            if (txtContraseña.Text.Length < 8)
            {
                toolTip.Show("La contraseña debe de ser mayor a ocho caracteres\", \"Contraseña muy corta", txtContraseña, 50, 30, 3000);
            }
            else
            {
                String contrasenaNueva = RevisarContraseña();
                String usuario = cbUsuario.Text;
                nuevaContrasena(usuario, contrasenaNueva);
                MessageBox.Show("Contraseña actualizada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContraseña.Clear();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                // Si es un espacio, se controla el evento y no se escribe el carácter
                e.Handled = true;
            }
        }


        public void nuevaContrasena(String usuario, String contrasena)
        {
            try
            {

                adaptador = new SqlDataAdapter("ACTUALIZACION_CONTRASEÑA_USUARIO", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = contrasena;
                adaptador.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;

                conexion.Open();
                adaptador.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un problema: " + ex.Message);
            }
            finally
            {
                conexion.Close();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
