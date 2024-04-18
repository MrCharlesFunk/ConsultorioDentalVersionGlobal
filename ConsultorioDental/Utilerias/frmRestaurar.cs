using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioDental.Utilerias
{
    public partial class frmRestaurar : MaterialSkin.Controls.MaterialForm
    {
        public frmRestaurar()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=Localhost; database=master; integrated security=true");

        SqlCommand comando = new SqlCommand();



        private void frmRestaurar_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmdRespaldar_Click(object sender, EventArgs e)
        {
            String fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            String ruta = @"C:\RespaldosDentalCare";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            saveFileDialog1.FileName = "DentalCare_" + fecha + ".bak";
            saveFileDialog1.Filter = "SQL Backup files | *.bak";
            saveFileDialog1.InitialDirectory = ruta + @"\";

            string rutaArchivo;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = saveFileDialog1.FileName;
                try
                {
                    conexion.Open();
                    comando = conexion.CreateCommand();
                    comando.CommandText = "BACKUP DATABASE ConsultorioDentalCare TO DISK =N'" + rutaArchivo + "'";
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("El respaldo fue exitoso", "Respaldo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception s)
                {
                    MessageBox.Show("El respaldo fallo\nCodigo de error:" + s, "Ocurrio un error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmdRestaurar_Click(object sender, EventArgs e)
        {
            String ruta = @"C:\RespaldosDentalCare";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "SQL Backup files | *.bak";
            openFileDialog1.InitialDirectory = ruta + @"\";
            string rutaArchivo;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog1.FileName;

                try
                {
                    conexion.Open();
                    comando = conexion.CreateCommand();

                    // Verifica si la base de datos existe
                    if (BaseDeDatosExiste(comando, "ConsultorioDentalCare"))
                    {
                        // Si existe, elimínala antes de realizar el respaldo
                        comando.CommandText = "USE master; ALTER DATABASE ConsultorioDentalCare SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE ConsultorioDentalCare;";
                        comando.ExecuteNonQuery();
                    }

                    // Realiza el respaldo
                    comando.CommandText = "RESTORE DATABASE ConsultorioDentalCare FROM DISK = N'" + rutaArchivo + "'";
                    comando.ExecuteNonQuery();

                    conexion.Close();
                    MessageBox.Show("El respaldo fue exitoso", "Respaldo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception s)
                {
                    MessageBox.Show("El respaldo fallo\nCodigo de error:" + s, "Ocurrio un error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool BaseDeDatosExiste(SqlCommand comando, string nombreBaseDatos)
        {
            comando.CommandText = "SELECT COUNT(*) FROM sys.databases WHERE name = @nombre";
            comando.Parameters.AddWithValue("@nombre", nombreBaseDatos);
            int resultado = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            return resultado > 0;
        }
    }
}
