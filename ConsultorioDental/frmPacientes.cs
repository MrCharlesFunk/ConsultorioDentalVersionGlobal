using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ConsultorioDental
{
    public partial class frmPacientes : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection conexion = new SqlConnection("Server=.; DataBase=ConsultorioDentalCare; Integrated Security=SSPI");
        SqlDataAdapter adaptador;
        SqlCommand comando = new SqlCommand();
        //Esta parte sirve para en caso de que este haciendo algun registro y por accidente precione el botón salir le salga una alerta
        int registroActivo = 0;
        //combos
        string telefono;
        string edad;
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            //Cargar Paciente
            dgvPacientes.DataSource = consultaGeneral().Tables["General"];


            //Calcular fechas para los años
            DateTime fechaActual = DateTime.Now;
            DateTime nuevaFechaMaxima = fechaActual.AddYears(-3);
            dtpFechaNac.MaxDate = nuevaFechaMaxima;



            DateTime nuevaFechaMinima = fechaActual.AddYears(-100);
            dtpFechaNac.MinDate = nuevaFechaMinima;
            cargarPacientesCombo();
            cargarMuniciposCombo();

            cmbPaciente.SelectedIndex = -1;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (registroActivo == 1)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro que quieres salir?\nPerderás los datos no guardados", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmacion == DialogResult.OK)
                {
                    Dispose();
                }
            }
            else Dispose();


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int insercion = 0;

            if (txtNombre.Text == "" || cbTipoSangre.SelectedIndex == -1 || txtTelefono.Text == "")
            {
                MessageBox.Show("Debes de llenar todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtNombre.Text.Length <= 1)
                {
                    toolTip.Show("Ingresa un nombre valido", txtNombre, 50, 30, 3000);
                    insercion = 1;
                }
                if (txtTelefono.Text.Length <= 9)
                {

                    toolTip.Show("El teléfono debe contener 10 dígitos\", \"Teléfono no valido.", txtTelefono, 50, 30, 3000);
                    insercion = 1;
                }
                if (cbTieneRFC.Checked == true)
                {
                    if (string.IsNullOrWhiteSpace(txtRFC.Text) || string.IsNullOrWhiteSpace(txtRazonSocial.Text) || string.IsNullOrWhiteSpace(txtCP.Text) || string.IsNullOrWhiteSpace(txtCalle.Text) || string.IsNullOrWhiteSpace(txtColonia.Text) || cbMunicipio.SelectedIndex == -1 || cbLocalidad.SelectedIndex == -1 || cbEstado.SelectedIndex == -1 || cbCFDI.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtNumeroInterior.Text) || cbRegimen.SelectedIndex == -1)
                    {
                        insercion = 1;
                        toolTip.Show("Llena todos los campos del RFC\", \"Debes de llenar todos los campos", cbTieneRFC, 50, 30, 3000);
                    }
                    if (txtRFC.Text.Length < 13 || txtRFC.Text.Length > 13)
                    {
                        toolTip.Show("RFC no valido\nDebe de ser de 13 caracteres\", \"RFC incompleto", txtRFC, 50, 30, 3000);
                    }
                }


                if (insercion == 0)
                {
                    DialogResult confirmacion = MessageBox.Show("Estas seguro que quieres guardar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (confirmacion == DialogResult.OK)
                    {
                        string nombre = txtNombre.Text, edad = txtEdad.Text, fechaNac = dtpFechaNac.Value.ToString("yyyy-MM-dd"), tel = txtTelefono.Text, rfc, padecimientos = txtAlergias.Text;
                        if (padecimientos.Equals("")) { padecimientos = "Ninguna"; }
                        if (cbTieneRFC.Checked == false)
                        {
                            rfc = "XAXX010101000";
                            insertaPaciente(nombre, fechaNac, cbTipoSangre.Text, tel, rfc, padecimientos);
                        }
                        else if (cbTieneRFC.Checked == true)
                        {
                            rfc = txtRFC.Text;
                            rfc.ToUpper();
                            string rZ = txtRazonSocial.Text, cp = txtCP.Text, calle = txtCalle.Text, nI = txtNumeroInterior.Text, nE;
                            if(String.IsNullOrWhiteSpace(txtNumeroExterior.Text)) nE = "N/A";
                            else nE = txtNumeroExterior.Text;
                            string colonia = txtColonia.Text, localidad = cbLocalidad.Text, municipio = cbMunicipio.Text, estado = cbEstado.Text, regimen = cbRegimen.Text, cfdi = cbCFDI.Text;
                            string correo = txtCorreo.Text;
                            insertaPaciente(nombre, fechaNac, cbTipoSangre.Text, tel, rfc, padecimientos);
                            
                            insertaRFC(rfc, rZ, cp, calle, nI, nE, colonia, localidad, municipio, estado, regimen, cfdi, correo);

                        }



                        dgvPacientes.DataSource = consultaGeneral().Tables["General"];
                        cargarPacientesCombo();

                        cmbPaciente.SelectedIndex = -1;

                        //Limpiartextos:
                        this.telefono = "";
                        DateTime fechaActual = DateTime.Now;
                        DateTime nuevaFechaMaxima = fechaActual.AddYears(-3);
                        dtpFechaNac.MaxDate = nuevaFechaMaxima;
                        dtpFechaNac.Value = nuevaFechaMaxima;
                        txtNombre.Text = "";
                        txtEdad.Text = "";
                        txtIdPaciente.Text = "";
                        txtTelefono.Text = "";
                        txtSaldo.Text = "";
                        cbTieneRFC.Checked = false;
                        cbTipoSangre.SelectedIndex = -1;
                        txtAlergias.Text = "";

                        txtNombre.Visible = false;
                        cmbPaciente.Visible = true;
                        cmbPaciente.Enabled = true;
                        txtNombre.Enabled = false;
                        txtEdad.Enabled = false;
                        txtIdPaciente.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtAlergias.Enabled = false;
                        txtSaldo.Enabled = false;
                        cbTipoSangre.Enabled = false;
                        cbTieneRFC.Enabled = false;
                        btnGrabar.Enabled = false;
                        btnNuevo.Enabled = true;
                        registroActivo = 0;




                    }
                }

            }

        }


        //Metodos para la insercion
        public DataSet consultaGeneral()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_PACIENTES", conexion);
                adaptador.Fill(data, "General");

                return data;

            }

        }

        public DataSet consultaIndividual(String nombre)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_INDIVIDUAL_PACIENTE", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@Nombre", SqlDbType.VarChar);
                n.Value = nombre;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "Paciente");

                return data;

            }

        }
        public DataSet consultaIndividualcitas(String nombre)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_INDIVIDUAL_PACIENTE_CITAS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@Nombre", SqlDbType.VarChar);
                n.Value = nombre;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "Paciente");

                return data;

            }

        }
        public int contarId()
        {
            using (DataSet data = new DataSet())
            {
                int id;
                adaptador = new SqlDataAdapter("ID_PACIENTES", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                id = Convert.ToInt32(adaptador.SelectCommand.ExecuteScalar()) + 1;
                conexion.Close();
                return id;
            }
        }

        public void insertaPaciente(string nombre, string fechaNac, string tipoSangre, string tel, string rfc, string pa)
        {
            try
            {

                adaptador = new SqlDataAdapter("INSERTAR_PACIENTES", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;

                adaptador.SelectCommand.Parameters.Add("@FechaNac", SqlDbType.Date).Value = fechaNac;
                adaptador.SelectCommand.Parameters.Add("@TipoSangre", SqlDbType.VarChar).Value = tipoSangre;
                adaptador.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = tel;
                adaptador.SelectCommand.Parameters.Add("@RFC", SqlDbType.VarChar).Value = rfc;
                adaptador.SelectCommand.Parameters.Add("@Padecimientos", SqlDbType.VarChar).Value = pa;


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




        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbPaciente.SelectedIndex > -1)
            {
                string nombre = cmbPaciente.Text;
                DataTable cargarPaciente = consultaIndividual(nombre).Tables["Paciente"];
                DataRow p = cargarPaciente.Rows[0];
                txtIdPaciente.Text = p["No. Paciente"].ToString();
                DateTime fechanac = (DateTime)p["Fecha de nacimiento"];
                dtpFechaNac.Value = fechanac;
                calcularEdad();
                txtTelefono.Text = p["Telefono"].ToString();
                txtRfcConsultado.Text = p["RFC"].ToString();
                lbRfcConsultado.Visible = true;
                txtRfcConsultado.Visible = true;
                cbTieneRFC.Visible = false;
                txtAlergias.Text = p["Alergias"].ToString();
                txtAlergias.Enabled = true;
                txtAlergias.ReadOnly = true;
                txtSaldo.Text = p["Saldo"].ToString();
                cbTipoSangre.Text = p["Tipo Sangre"].ToString();
                dgvPacientes.DataSource = consultaIndividualcitas(nombre).Tables["Paciente"];

                if (!txtAlergias.Text.Equals("Ninguna"))
                {
                    pictureBox1.Enabled = true;
                    pictureBox1.Visible = true;
                }
                else if (txtAlergias.Text.Equals("Ninguna"))
                {
                    pictureBox1.Enabled = false;
                    pictureBox1.Visible = false;
                }


            }
        }




        public void cargarPacientesCombo()
        {
            cmbPaciente.SelectedIndexChanged -= cmbPaciente_SelectedIndexChanged;
            cmbPaciente.DataSource = consultaGeneral().Tables["General"];
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "Nombre";
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            registroActivo = 1;

            txtRfcConsultado.Text = "";
            lbRfcConsultado.Visible = false;
            txtRfcConsultado.Visible = false;
            this.telefono = "";
            cmbPaciente.Visible = false;
            cmbPaciente.Enabled = false;
            txtNombre.Visible = true;
            txtNombre.Enabled = true;
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtIdPaciente.Text = "";
            txtIdPaciente.Text = contarId().ToString();
            DateTime fechaActual = DateTime.Now;
            DateTime nuevaFechaMaxima = fechaActual.AddYears(-3);
            dtpFechaNac.MaxDate = nuevaFechaMaxima;
            dtpFechaNac.Value = nuevaFechaMaxima;
            txtTelefono.Text = "";
            txtAlergias.Text = "";
            txtAlergias.ReadOnly = false;
            txtSaldo.Text = "0.00";
            cbTipoSangre.Text = "";
            cbTieneRFC.Enabled = true;
            cbTieneRFC.Visible = true;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            dtpFechaNac.Enabled = true;
            txtTelefono.Enabled = true;
            txtAlergias.Enabled = true;
            cbTipoSangre.Enabled = true;
            btnNuevo.Enabled = false;
            btnGrabar.Enabled = true;
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

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            calcularEdad();
        }

        //hace el calculo de la edad segun la fecha de nacimiento
        private void calcularEdad()
        {
            DateTime fechaNacimiento = dtpFechaNac.Value;

            // Calcula la edad
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            // Verifica si el cumpleaños ya pasó este año
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
            txtEdad.Text = edad.ToString();
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

        private void txtAlergias_KeyPress(object sender, KeyPressEventArgs e)
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
                toolTip.Show("El padecimiento no debe contener caracteres especiales\", \"padecimiento no valido.", txtAlergias, 50, 30, 3000);
            }
        }


        //Empiezan todos los procedimientos del RFC
        private void cbTieneRFC_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                // Acción si el CheckBox está marcado
                limpiarActivarRFC(0);
            }
            else
            {
                // Acción si el CheckBox está desmarcado
                limpiarActivarRFC(1);
            }
        }

        public void limpiarActivarRFC(int opc)
        {
            if (opc == 0)
            {
                dgvPacientes.Enabled = false;
                dgvPacientes.Visible = false;
                txtRFC.Enabled = true;
                txtRazonSocial.Enabled = true;
                txtCP.Enabled = true;
                txtCalle.Enabled = true;
                txtColonia.Enabled = true;

                cbEstado.Enabled = true;
                cbCFDI.Enabled = true;
                cbRegimen.Enabled = true;
                txtCorreo.Enabled = true;
                txtNumeroInterior.Enabled = true;
                txtNumeroExterior.Enabled = true;
            }
            else if (opc == 1)
            {
                dgvPacientes.Enabled = true;
                dgvPacientes.Visible = true;
                txtRFC.Enabled = false;
                txtRazonSocial.Enabled = false;
                txtCP.Enabled = false;
                txtCalle.Enabled = false;
                txtColonia.Enabled = false;
                cbMunicipio.Enabled = false;
                cbEstado.Enabled = false;
                cbCFDI.Enabled = false;
                cbRegimen.Enabled = false;
                txtCorreo.Enabled = false;
                txtNumeroInterior.Enabled = false;
                txtNumeroExterior.Enabled = false;

                txtRFC.Text = "";
                txtRazonSocial.Text = "";
                txtCP.Text = "";
                txtCalle.Text = "";
                txtColonia.Text = "";

                cbEstado.SelectedIndex = -1;

                cbCFDI.Text = "";
                cbRegimen.Text = "";
                txtCorreo.Text = "";
                txtNumeroInterior.Text = "";
                txtNumeroExterior.Text = "";




            }
        }
        public void insertaRFC(string rfc, string rZ, string cp, string calle, string nI, string nE, string colonia, string localidad, string municipio, string estado, string regimen, string cfdi, string correo)
        {
            try
            {

                adaptador = new SqlDataAdapter("INSERTAR_SITUACIONFISCAL", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add("@RFC", SqlDbType.VarChar).Value = rfc;
                adaptador.SelectCommand.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = rfc;
                adaptador.SelectCommand.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = cp;
                adaptador.SelectCommand.Parameters.Add("@Calle", SqlDbType.VarChar).Value = calle;
                adaptador.SelectCommand.Parameters.Add("@NoInterior", SqlDbType.VarChar).Value = nI;
                adaptador.SelectCommand.Parameters.Add("@NoExterior", SqlDbType.VarChar).Value = nE;
                adaptador.SelectCommand.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = colonia;
                adaptador.SelectCommand.Parameters.Add("@Localidad", SqlDbType.VarChar).Value = localidad;
                adaptador.SelectCommand.Parameters.Add("@Municipio", SqlDbType.VarChar).Value = municipio;
                adaptador.SelectCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = estado;
                adaptador.SelectCommand.Parameters.Add("@Regimen", SqlDbType.VarChar).Value = regimen;
                adaptador.SelectCommand.Parameters.Add("@CFDI", SqlDbType.VarChar).Value = cfdi;
                adaptador.SelectCommand.Parameters.Add("@Correo", SqlDbType.VarChar).Value = correo;




                conexion.Open();
                adaptador.SelectCommand.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error");
            }
            finally
            {

                conexion.Close();

            }
        }
        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbEstado.SelectedIndex==-1)
            {
                //No hacer nada
            }
            if (cbEstado.SelectedIndex > -1)
            {
                cbMunicipio.Enabled = true;
            }
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedIndex > -1)
            {
            
                cbLocalidad.DataSource = consultaIndividualLocalidades(cbMunicipio.Text).Tables["Localidades"];
                cbLocalidad.DisplayMember = "NOM_LOC";
                cbLocalidad.ValueMember = "NOM_LOC";
                cbLocalidad.Enabled = true;
                
            }
        }
        public void cargarMuniciposCombo()
        {
            cbMunicipio.SelectedIndexChanged -= cbMunicipio_SelectedIndexChanged;
            cbMunicipio.DataSource = consultaGeneralMunicipios().Tables["General"];
            cbMunicipio.DisplayMember = "Nom_Municipio";
            cbMunicipio.ValueMember = "Nom_Municipio";
            cbMunicipio.SelectedIndexChanged += cbMunicipio_SelectedIndexChanged;
        }

        public DataSet consultaGeneralMunicipios()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_MUNICIPIO", conexion);
                adaptador.Fill(data, "General");

                return data;

            }

        }

        public DataSet consultaIndividualLocalidades(String nombre)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_INDIVIDUAL_LOCALIDADES", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@Localidad", SqlDbType.VarChar);
                n.Value = nombre;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "Localidades");

                return data;

            }

        }
    }
}
