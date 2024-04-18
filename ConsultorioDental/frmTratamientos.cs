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
    public partial class frmTratamientos : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection conexion = new SqlConnection("Server=.; DataBase=ConsultorioDentalCare; Integrated Security=SSPI");
        SqlDataAdapter adaptador;
        SqlCommand comando = new SqlCommand();



        string tratamiento;
        public frmTratamientos()
        {
            InitializeComponent();
        }

        private void frmTratamientos_Load(object sender, EventArgs e)
        {
            dgvTratamientos.DataSource = consultaGeneral().Tables["General"];

            cargarTratamientosCombo();
            if (cmbTratamiento.Items.Count == 0) cmbTratamiento.Enabled = false;
            cmbTratamiento.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Habilitar botones
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = false;

            //Textos
            txtImporte.Enabled = true;
            txtCantidadCitas.Enabled = true;
            txtImporte.Text = "";
            txtTratamiento.Text = "";
            txtCantidadCitas.Text = "";
            
            txtTratamiento.Enabled = true;
            txtTratamiento.Visible = true;
            txtIdTratamiento.Text = contarId().ToString();

            cmbTratamiento.Visible = false;
            cmbTratamiento.Enabled = false;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int insercion = 0;
            if (txtTratamiento.Text == "" || txtImporte.Text == "" || string.IsNullOrWhiteSpace(txtCantidadCitas.Text))
            {
                MessageBox.Show("Debes de llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtTratamiento.Text.Length <= 3)
                {
                    toolTip.Show("La descripcion debe de ser mayor a 3 caracteres", txtTratamiento, 50, 30, 3000);
                    insercion = 1;
                }
                else if (Convert.ToInt32(txtCantidadCitas.Text)<=0)
                {
                    toolTip.Show("El numero de citas debe de ser mayor a 0 ", txtCantidadCitas, 50, 30, 3000);
                    insercion = 1;
                }
                if (insercion == 0)
                {
                    DialogResult confirmacion = MessageBox.Show("Estas seguro que quieres guardar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (confirmacion == DialogResult.OK)
                    {
                        string trata = txtTratamiento.Text;
                        decimal importe = Math.Round(Convert.ToDecimal(txtImporte.Text), 2);
                        int numCita = Convert.ToInt32(txtCantidadCitas.Text);
                        inserta(importe, trata, numCita);

                        //
                        dgvTratamientos.DataSource = consultaGeneral().Tables["General"];
                        cargarTratamientosCombo();

                        btnGrabar.Enabled = false;
                        btnNuevo.Enabled = true;
                        this.tratamiento = "";
                        txtImporte.Enabled = false;
                        txtCantidadCitas.Enabled = false;
                        txtImporte.Text = "";
                        txtTratamiento.Text = "";
                        txtIdTratamiento.Text = "";
                        txtCantidadCitas.Text = "";
                        txtTratamiento.Enabled = false;
                        txtTratamiento.Visible = false;


                        cmbTratamiento.Visible = true;
                        cmbTratamiento.Enabled = true;
                    }
                }
            }
        }

        private void cmbTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTratamiento.SelectedIndex > -1)
            {
                decimal importememoria;
                string nombre = cmbTratamiento.Text;
                DataTable cargarTratamiento = consultaIndividual(nombre).Tables["Tratamiento"];
                DataRow d = cargarTratamiento.Rows[0];
                txtIdTratamiento.Text = d["No. Tratamiento"].ToString();
                importememoria = Math.Round(Convert.ToDecimal(d["Importe"].ToString()), 2);
                txtImporte.Text = importememoria.ToString();
                txtCantidadCitas.Text = d["CantidadCitas"].ToString();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }



        public void cargarTratamientosCombo()
        {
            cmbTratamiento.SelectedIndexChanged -= cmbTratamiento_SelectedIndexChanged;
            cmbTratamiento.DataSource = consultaGeneral().Tables["General"];
            cmbTratamiento.DisplayMember = "Tratamiento";
            cmbTratamiento.ValueMember = "Tratamiento";
            cmbTratamiento.SelectedIndexChanged += cmbTratamiento_SelectedIndexChanged;
        }


        //Metodos para la insercion
        public DataSet consultaGeneral()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_TRATAMIENTOS", conexion);
                adaptador.Fill(data, "General");

                return data;

            }

        }

        public DataSet consultaIndividual(String nombre)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_INDIVIDUAL_TRATAMIENTOS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@Tratamiento", SqlDbType.VarChar);
                n.Value = nombre;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "Tratamiento");

                return data;

            }

        }

        public int contarId()
        {
            using (DataSet data = new DataSet())
            {
                int id;
                adaptador = new SqlDataAdapter("ID_TRATAMIENTOS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                id = Convert.ToInt32(adaptador.SelectCommand.ExecuteScalar()) + 1;
                conexion.Close();
                return id;
            }
        }

        public void inserta(decimal importe, string trata, int cita)
        {
            try
            {

                adaptador = new SqlDataAdapter("INSERTAR_TRATAMIENTOS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add("@Importe", SqlDbType.Money).Value = importe;
                adaptador.SelectCommand.Parameters.Add("@Tratamiento", SqlDbType.VarChar).Value = trata;
                adaptador.SelectCommand.Parameters.Add("@CantidadCitas", SqlDbType.Int).Value = cita;



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

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número, un punto decimal o la tecla de retroceso (backspace).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                toolTip.Show("Ingrese un en valor decimal", txtImporte, 50, 30, 3000);
                e.Handled = true;  // Rechaza el carácter.

            }





            // Asegúrate de que solo haya un punto decimal.
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;  // Rechaza el carácter si ya hay un punto decimal.
            }

        }

        private void txtTratamiento_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                toolTip.Show("El nombre no debe contener caracteres especiales\", \"nombre no valido.", txtTratamiento, 50, 30, 3000);
            }
        }

        private void txtCantidadCitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número, un punto decimal o la tecla de retroceso (backspace).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                toolTip.Show("Solo valores numéricos", txtCantidadCitas, 50, 30, 3000);
                e.Handled = true;  // Rechaza el carácter.

            }
        }
    }
}
