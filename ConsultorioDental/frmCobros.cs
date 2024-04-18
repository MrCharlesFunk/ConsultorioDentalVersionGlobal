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
    public partial class frmCobros : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection conexion = new SqlConnection("Server=.; DataBase=ConsultorioDentalCare; Integrated Security=SSPI");
        SqlDataAdapter adaptador;
        SqlCommand comando = new SqlCommand();

        decimal totalCitaMemoria = 0, saldoPacienteMemoria = 0;



        public frmCobros()
        {
            InitializeComponent();

        }

        private void frmCobros_Load(object sender, EventArgs e)
        {

            dgvCobros.DataSource = consultaGeneral().Tables["General"];
            cargarPacientesCombo();
            dtpFecha.Value = DateTime.Today;
            cmbIdCita.SelectedIndex = -1;
            cmbPaciente.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdCobro.Text = Convert.ToString(proximaid());
            dtpFecha.Value = DateTime.Today;
           
            btnNuevo.Enabled = false;
            cmbPaciente.Enabled = true;
            cmbPaciente.SelectedIndex = 0;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int insertaReal = 0;
            if (cmbPaciente.SelectedIndex == -1)
            {
                toolTip.Show("Para continuar por favor selecciona un paciente\", \"Paciente no seleccionado", cmbPaciente, 50, 30, 3000);
                insertaReal = 1;
            }
            if (cmbIdCita.SelectedIndex == -1)
            {
                toolTip.Show("Para continuar por favor selecciona una cita\", \"cita no seleccionado", cmbIdCita, 50, 30, 3000);
                insertaReal = 1;
            }
            if (Convert.ToDecimal(txtMonto.Text) < 0)
            {
                toolTip.Show("Para continuar por favor agrega un monto mayor a cero\", \"monto no correcto", txtMonto, 50, 30, 3000);
                insertaReal = 1;
            }
            if (Convert.ToDecimal(txtMonto.Text) > totalCitaMemoria)
            {
                toolTip.Show("Para continuar por favor agrega un monto menor o igual al total de la cita\", \"monto no correcto", txtMonto, 50, 30, 3000);
                insertaReal = 1;
            }
            if (insertaReal == 0)
            {
                DialogResult confirmacion = MessageBox.Show("Estas seguro que quieres guardar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmacion == DialogResult.OK)
                {
                    try
                    {
                        //datos para cita
                        int idcita = Convert.ToInt32(cmbIdCita.Text);
                        string fecha = (dtpFecha.Value).ToString("yyyy-MM-dd");
                        decimal nuevomonto = Math.Round(Convert.ToDecimal(txtMonto.Text), 2);

                        //logica para el saldo de la cita

                        decimal nuevoSaldoCita = Math.Round(totalCitaMemoria - nuevomonto, 2);

                        //logica saldo del paciente
                        int idPaciente = Convert.ToInt32(txtIdPaciente.Text);
                        decimal nuevoSaldoPaciente = Math.Round(saldoPacienteMemoria - nuevomonto, 2);

                        if (nuevoSaldoCita == 0)
                        {
                            insertarCobro(idcita, fecha, nuevomonto, nuevoSaldoCita, 'P', idPaciente, nuevoSaldoPaciente);
                        }
                        else
                        {
                            insertarCobro(idcita, fecha, nuevomonto, nuevoSaldoCita, 'A', idPaciente, nuevoSaldoPaciente);
                        }

                        cmbPaciente.SelectedIndex = -1;
                        cmbPaciente.Enabled = false;
                        cmbIdCita.SelectedIndex = -1;
                        cmbIdCita.Enabled = false;
                        txtMonto.Text = "";
                        txtMonto.Enabled = false;
                        txtTotalCita.Text = "";
                        txtIdPaciente.Text = "";
                        txtIdCobro.Text = "";
                        btnNuevo.Enabled = true;
                        txtSaldoPaciente.Text = "";
                        cargarPacientesCombo();
                        dgvCobros.DataSource = consultaGeneral().Tables["General"];
                        txtIdCobro.Text = "";
                        
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ocurrió un error al insertar, si estas seguro que los datos que ibas a insertar estaban correctos, comunícate con tu diseñador", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex) { }
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedIndex > -1)
            {
                string nombre = cmbPaciente.Text;
                DataTable cargarPaciente = consultaIndividualcobropacientes(nombre).Tables["Paciente"];
                DataRow p = cargarPaciente.Rows[0];
                txtIdPaciente.Text = p["No. Paciente"].ToString();
                saldoPacienteMemoria = Math.Round(Convert.ToDecimal(p["SaldoPaciente"].ToString()), 2);
                txtSaldoPaciente.Text = saldoPacienteMemoria.ToString();
                
                cmbIdCita.DataSource = consultageneralcobrocitas(nombre).Tables["Paciente"];
                cmbIdCita.DisplayMember = "IdCita";
                cmbIdCita.ValueMember = "IdCita";
                
                cmbIdCita.Enabled = true;

                cmbIdCita.SelectedIndex = 0;

            }
            else
            {
                cmbIdCita.Enabled = false;
            }

        }

        private void cmbIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdCita.SelectedIndex > -1)
            {
                int cita = Convert.ToInt32(cmbIdCita.Text);
                DataTable cargarCita = consultaIndividualcobrocitas(cita).Tables["Paciente"];
                DataRow c = cargarCita.Rows[0];

                DateTime fecha = (DateTime)c["Fecha"];
                dtpFechaCita.Value = fecha;
                totalCitaMemoria = Math.Round(Convert.ToDecimal(c["Total"].ToString()), 2);
                txtMonto.Text = totalCitaMemoria.ToString();
                txtTotalCita.Text = totalCitaMemoria.ToString();
                txtMonto.Enabled = true;
                btnGrabar.Enabled = true;

            }
            else
            {
                txtMonto.Enabled = false;
                btnGrabar.Enabled = false;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número, un punto decimal o la tecla de retroceso (backspace).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                toolTip.Show("Ingrese un en valor decimal", txtMonto, 50, 30, 3000);
                e.Handled = true;  // Rechaza el carácter.

            }

            // Asegúrate de que solo haya un punto decimal.
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;  // Rechaza el carácter si ya hay un punto decimal.
            }



        }




        //inician procedimientos y llenado de combos
        public int proximaid()
        {
            using (DataSet data = new DataSet())
            {
                int id;
                adaptador = new SqlDataAdapter("ID_COBROS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                id = Convert.ToInt32(adaptador.SelectCommand.ExecuteScalar());
                conexion.Close();
                return id;
            }
        }
        public DataSet consultaGeneral()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_COBROS", conexion);
                adaptador.Fill(data, "General");

                return data;

            }


        }
        public DataSet consultaGeneralPacientes()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_COBROS_PACIENTES", conexion);
                adaptador.Fill(data, "General");

                return data;

            }


        }



        public DataSet consultaIndividualcobropacientes(String nombre)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_INDIVIDUAL_COBROS_PACIENTE", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@Nombre", SqlDbType.VarChar);
                n.Value = nombre;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "Paciente");

                return data;

            }

        }
        public DataSet consultageneralcobrocitas(String nombre)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_COBROS_CITAS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@Paciente", SqlDbType.VarChar);
                n.Value = nombre;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "Paciente");

                return data;

            }

        }
        public DataSet consultaIndividualcobrocitas(int cita)
        {


            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_INDIVIDUAL_COBROS_CITAS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter n = new SqlParameter("@IdCita", SqlDbType.Int);
                n.Value = cita;
                adaptador.SelectCommand.Parameters.Add(n);
                adaptador.Fill(data, "Paciente");

                return data;

            }

        }

        public void cargarPacientesCombo()
        {
            cmbPaciente.SelectedIndexChanged -= cmbPaciente_SelectedIndexChanged;
            cmbPaciente.DataSource = consultaGeneralPacientes().Tables["General"];
            cmbPaciente.DisplayMember = "Paciente";
            cmbPaciente.ValueMember = "Paciente";
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
        }


        public void insertarCobro(int idCita, string fecha, decimal monto, decimal nuevoSaldo, char estado, int idPaciente, decimal nuevoSaldoPaciente)
        {
            try
            {

                adaptador = new SqlDataAdapter("INSERTAR_COBROS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add("@IdCita", SqlDbType.Int).Value = idCita;
                adaptador.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date).Value = fecha;
                adaptador.SelectCommand.Parameters.Add("@Monto", SqlDbType.Money).Value = monto;

                adaptador.SelectCommand.Parameters.Add("@NuevoSaldoCita", SqlDbType.Money).Value = nuevoSaldo;
                adaptador.SelectCommand.Parameters.Add("@Estado", SqlDbType.Char, 1).Value = estado;


                adaptador.SelectCommand.Parameters.Add("@IdPaciente", SqlDbType.Int).Value = idPaciente;
                adaptador.SelectCommand.Parameters.Add("@NuevoSaldoPaciente", SqlDbType.Money).Value = nuevoSaldoPaciente;
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

    }
}
