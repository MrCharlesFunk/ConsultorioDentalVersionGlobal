using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioDental
{
    public partial class frmDentistas : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection conexion = new SqlConnection("Server=.; DataBase=ConsultorioDentalCare; Integrated Security=SSPI");
        SqlDataAdapter adaptador;
        SqlCommand comando = new SqlCommand();

        //combos
        string telefono;

        public frmDentistas()
        {
            InitializeComponent();
        }

        private void frmDentistas_Load(object sender, EventArgs e)
        {
            dgvDentistas.DataSource = consultaGeneral().Tables["General"];


            cargarDentistasCombo();
            if(cmbDentista.Items.Count==0) cmbDentista.Enabled = false;
            cmbDentista.SelectedIndex = -1;
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.telefono = "";
            cmbDentista.Enabled = false;
            cmbDentista.Visible = false;
            txtNombre.Visible = true;
            txtNombre.Enabled = true;
            cmbEspecialidad.Enabled = true;
            
            txtTelefono.Enabled = true;
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = false;
            txtIdDentista.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cmbEspecialidad.Text = "";
            txtIdDentista.Text = contarId().ToString();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int insercion = 0;
            if (txtNombre.Text == "" || txtTelefono.Text == "" || cmbEspecialidad.Text == "")
            {
                MessageBox.Show("Debes de llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtNombre.Text.Length <= 1)
                {
                    MessageBox.Show("Ingresa un nombre valido", "Nombre no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    insercion = 1;
                }
                if (txtTelefono.Text.Length <= 9)
                {
                    MessageBox.Show("El telefono debe contener 10 digitos", "Telefono no valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    insercion = 1;
                }
                if (insercion == 0)
                {
                    DialogResult confirmacion = MessageBox.Show("Estas seguro que quieres guardar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (confirmacion == DialogResult.OK)
                    {

                        string nombre = txtNombre.Text, tel = txtTelefono.Text, espe = cmbEspecialidad.Text;
                        inserta(nombre,espe, tel);


                        dgvDentistas.DataSource = consultaGeneral().Tables["General"];
                        cargarDentistasCombo();

                        this.telefono = "";
                        txtTelefono.Text = "";
                        txtIdDentista.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Enabled = false;
                        txtNombre.Enabled = false;
                        cmbDentista.Enabled = true;
                        cmbDentista.Visible = true;
                        cmbEspecialidad.Enabled = false;
                        cmbEspecialidad.Text = "";
                        btnGrabar.Enabled = false;
                        btnNuevo.Enabled = true;
                    }
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbDentista_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbDentista.SelectedIndex > -1)
            {
                string nombre = cmbDentista.Text;
                DataTable cargarDentista = consultaIndividual(nombre).Tables["Dentista"];
                DataRow d = cargarDentista.Rows[0];
                txtIdDentista.Text = d["No. Dentista"].ToString();
                txtTelefono.Text = d["Telefono"].ToString();
                cmbEspecialidad.Text = d["Especialidad"].ToString();

            }
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (Int64.TryParse(txtTelefono.Text, out Int64 numero) || txtTelefono.Text == "")
            {
                telefono = numero.ToString();
            }
            else
            {
                toolTip.Show("El telefono debe ser numerico\", \"Telefono no valido.", txtTelefono, 50, 30, 3000);
                txtTelefono.Text = telefono;
                txtTelefono.SelectionStart = txtTelefono.Text.Length;
            }
        }

        //Metodos estandar
        public void cargarDentistasCombo()
        {
            cmbDentista.SelectedIndexChanged -= cmbDentista_SelectedIndexChanged;
            cmbDentista.DataSource = consultaGeneral().Tables["General"];
            cmbDentista.DisplayMember = "Nombre";
            cmbDentista.ValueMember = "Nombre";
            cmbDentista.SelectedIndexChanged += cmbDentista_SelectedIndexChanged;
        }


        //Metodos para la insercion
        public DataSet consultaGeneral()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_DENTISTAS", conexion);
                adaptador.Fill(data, "General");

                return data;

            }

        }

        public DataSet consultaIndividual(String nombre)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_INDIVIDUAL_DENTISTAS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@Nombre", SqlDbType.VarChar);
                n.Value = nombre;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "Dentista");

                return data;

            }

        }

        public int contarId()
        {
            using (DataSet data = new DataSet())
            {
                int id;
                adaptador = new SqlDataAdapter("ID_DENTISTAS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                id = Convert.ToInt32(adaptador.SelectCommand.ExecuteScalar()) + 1;
                conexion.Close();
                return id;
            }
        }

        public void inserta(string nombre,string espe, string tel)
        {
            try
            {

                adaptador = new SqlDataAdapter("INSERTAR_DENTISTAS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                adaptador.SelectCommand.Parameters.Add("@Especialidad", SqlDbType.VarChar).Value = espe;
                adaptador.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = tel;



                conexion.Open();
                adaptador.SelectCommand.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema");
            }
            finally
            {

                conexion.Close();

            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {


        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                toolTip.Show("El nombre no debe contener caracteres especiales\", \"nombre no valido.", txtNombre, 50, 30, 3000);
            }
        }
    }
}
