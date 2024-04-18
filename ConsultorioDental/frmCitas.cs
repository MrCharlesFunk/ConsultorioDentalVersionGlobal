using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ConsultorioDental
{
    public partial class frmCitas : MaterialSkin.Controls.MaterialForm
    {

        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=ConsultorioDentalCare;Integrated Security=SSPI;");
        SqlDataAdapter adaptador;
        SqlCommand comando = new SqlCommand();
        public frmCitas()
        {
            InitializeComponent();
        }
        decimal total, saldoPaciente;
        int idtratamientoMemoria;

        private void frmCitas_Load(object sender, EventArgs e)
        {
            dtpHora.Visible = false;
            dgvCitas.DataSource = consultaGeneral().Tables["General"];
            dptFecha.MinDate = DateTime.Today.AddDays(+1);
            DateTime fechaActual = DateTime.Now;
            DateTime nuevaFechaMaxima = fechaActual.AddYears(+1);
            cargarPacientesCombo();
            cargarDentistasCombo();
            cargarTratamientosCombo();
            cmbPaciente.SelectedIndex = -1;
            cmbDentista.SelectedIndex = -1;
            cmbTratamiento.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            dptFecha.MaxDate = nuevaFechaMaxima;
            
            btnAgregar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            btnNuevo.Enabled = false;

            txtIdCita.Text = Convert.ToString(proximaid());

           
            dptFecha.Enabled = true;
            dtpHora.MinDate = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            dptFecha.Value = DateTime.Today.AddDays(+1);
            dptFecha_ValueChanged(sender, e);
            cmbHora.Enabled = true;

            cmbPaciente.Enabled = true;
            cmbPaciente.SelectedIndex = -1;

            cmbDentista.Enabled = true;
            cmbDentista.SelectedIndex = -1;

            cmbTratamiento.Enabled = true;
            cmbTratamiento.SelectedIndex = -1;

            cmbEstado.Enabled = true;
            cmbEstado.SelectedIndex = 0;

            total = 0;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int insertaReal = 0, idcita = Convert.ToInt32(txtIdCita.Text);

            if (cmbDentista.SelectedIndex == -1)
            {
                toolTip.Show("Para continuar por favor selecciona un dentista\", \"Dentista no seleccionado", txtIdDentista, 50, 30, 3000);
                insertaReal = 1;
            }
            if (cmbPaciente.SelectedIndex == -1)
            {
                toolTip.Show("Para continuar por favor selecciona un paciente\", \"Paciente no seleccionado", txtIdPaciente, 50, 30, 3000);
                insertaReal = 1;
            }

            if (cmbHora.SelectedIndex == -1)
            {
                toolTip.Show("Para continuar por favor selecciona una hora\", \"Hora no seleccionado", cmbHora, 50, 30, 3000);
                insertaReal = 1;
            }

            if (insertaReal == 0)
            {
                int idpaciente = Convert.ToInt32(txtIdPaciente.Text);
                int iddentista = Convert.ToInt32(txtIdDentista.Text);
                string diaseleccionado = (dptFecha.Value).ToString("yyyy-MM-dd");
                string horaseleccionada = cmbHora.Text;
                TimeSpan hora = TimeSpan.Parse(horaseleccionada);
                char estado;

                // Crear DataTable para DetalleCompra
                DataTable detalleCita = new DataTable();

                detalleCita.Columns.Add("IdCita", typeof(int));
                detalleCita.Columns.Add("IdTratamiento", typeof(int));
                detalleCita.Columns.Add("Importe", typeof(decimal));

                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    if (row.Cells["IdTratamiento"].Value != null &&
                        row.Cells["Importe"].Value != null
                       )
                    {
                        int idtratamiento = (int)row.Cells["IdTratamiento"].Value;
                        decimal importe = Math.Round((decimal)row.Cells["Importe"].Value,2);

                        // Agregar fila al DataTable de DetalleCompra
                        detalleCita.Rows.Add(idcita, idtratamiento, importe);

                    }
                }

                DialogResult confirmacion = MessageBox.Show("Estas seguro que quieres guardar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmacion == DialogResult.OK)
                {
                    try
                    {
                        if (cmbEstado.Text == "A")
                        {
                            total = Math.Round(total, 2);
                            estado = 'A';
                            saldoPaciente = Math.Round(saldoPaciente + total,2);
                            insertarCita(iddentista, idpaciente, diaseleccionado, hora, estado, detalleCita, saldoPaciente,total,total);
                        }
                        else if (cmbEstado.Text == "P")
                        {
                            total = Math.Round(total, 2);
                            estado = 'P';
                            insertarCita(iddentista, idpaciente, diaseleccionado, hora, estado, detalleCita, saldoPaciente,total,0);
                        }


                        btnGrabar.Enabled = false;
                        btnNuevo.Enabled = true;

                        txtIdCita.Text = "";

                        dtpHora.Enabled = false;
                        dptFecha.Enabled = false;
                        dtpHora.Value = DateTime.Now;
                        dptFecha.Value = DateTime.Today.AddDays(+1);


                        cmbPaciente.SelectedIndex = -1;
                        cmbPaciente.Enabled = false;

                        cmbDentista.SelectedIndex = -1;
                        cmbDentista.Enabled = false;

                        cmbTratamiento.SelectedIndex = -1;
                        cmbTratamiento.Enabled = false;

                        cmbHora.Enabled = false;
                        cmbHora.Items.Clear();

                        cmbEstado.SelectedIndex = -1;
                        cmbEstado.Enabled = false;
                        txtImporte.Text = "";
                        txtTotal.Text = "";
                        total = 0;
                        saldoPaciente = 0;
                        dgvDetalle.Rows.Clear();
                        dgvCitas.DataSource = consultaGeneral().Tables["General"];


                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ocurrió un error al insertar, si estas seguro que los datos que ibas a insertar estaban correctos, comunícate con tu diseñador", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex) { }
                }
            }
        }

        public DataSet consultaGeneral()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_CITAS", conexion);
                adaptador.Fill(data, "General");

                return data;

            }


        }

        public int proximaid()
        {
            using (DataSet data = new DataSet())
            {
                int id;
                adaptador = new SqlDataAdapter("ID_CITAS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                id = Convert.ToInt32(adaptador.SelectCommand.ExecuteScalar());
                conexion.Close();
                return id;
            }
        }


        public void insertarCita(int idDentista, int idPaciente, string fecha, TimeSpan hora, char estado, DataTable detalleCita, decimal saldoPaciente,decimal total, decimal totalCita)
        {
            try
            {

                adaptador = new SqlDataAdapter("INSERTAR_CITAS", conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add("@IdDentista", SqlDbType.Int).Value = idDentista;
                adaptador.SelectCommand.Parameters.Add("@IdPaciente", SqlDbType.Int).Value = idPaciente;
                adaptador.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date).Value = fecha;
                adaptador.SelectCommand.Parameters.Add("@Hora", SqlDbType.Time).Value = hora;
                adaptador.SelectCommand.Parameters.Add("@Estado", SqlDbType.Char, 1).Value = estado;

                // Asegúrate de que los nombres de las tablas y columnas coincidan con las esperadas por el procedimiento almacenado
                adaptador.SelectCommand.Parameters.Add("@DetalleCita", SqlDbType.Structured).Value = detalleCita;

                adaptador.SelectCommand.Parameters.Add("@SaldoPaciente", SqlDbType.Money).Value = saldoPaciente;
                adaptador.SelectCommand.Parameters.Add("@Total", SqlDbType.Money).Value = total;
                adaptador.SelectCommand.Parameters.Add("@TotalCita", SqlDbType.Money).Value = totalCita;

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



        public DataSet consultaGeneralPacientes()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_PACIENTES", conexion);
                adaptador.Fill(data, "General");

                return data;

            }

        }
        public DataSet consultaGeneralDentistas()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_DENTISTAS", conexion);
                adaptador.Fill(data, "General");

                return data;

            }

        }
        public DataSet consultaGeneralTratamientos()
        {

            using (DataSet data = new DataSet())
            {

                adaptador = new SqlDataAdapter("CONSULTA_GENERAL_TRATAMIENTOS", conexion);
                adaptador.Fill(data, "General");

                return data;

            }

        }

        public void cargarPacientesCombo()
        {
            cmbPaciente.SelectedIndexChanged -= cmbPaciente_SelectedIndexChanged;
            cmbPaciente.DataSource = consultaGeneralPacientes().Tables["General"];
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "Nombre";
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
        }

        public string[] ObtenerHorasOcupadas(DateTime fecha)
        {
            // Conecta a la base de datos y ejecuta el procedimiento almacenado
            using (var comando = new SqlCommand("CONSULTA_INDIVIDUAL_CITAS_FECHAS", conexion))
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Fecha", (fecha).ToString("yyyy-MM-dd"));
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    var horasOcupadas = new System.Collections.Generic.List<string>();

                    while (lector.Read())
                    {
                        horasOcupadas.Add(lector["Hora"].ToString());
                    }
                    conexion.Close();
                    return horasOcupadas.ToArray();
                }
            }
        }

        public DataSet consultaIndividualPacientes(String nombre)
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

        private void LlenarComboHoras()
        {
            // Limpia el ComboBox antes de llenarlo nuevamente
            cmbHora.Items.Clear();

            // Define la hora de inicio y fin
            DateTime horaInicio = DateTime.ParseExact("09:30", "HH:mm", null);
            DateTime horaFin;
            if (dptFecha.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                horaFin = DateTime.ParseExact("13:30", "HH:mm", null);
            }
            else { horaFin= DateTime.ParseExact("19:30", "HH:mm", null); }


            // Obtiene las horas ocupadas del procedimiento almacenado
            var horasOcupadas = ObtenerHorasOcupadas(dptFecha.Value);

            // Llena el ComboBox en intervalos de 1 hora, evitando las horas ocupadas
            while (horaInicio <= horaFin)
            {
                var horaActual = horaInicio.ToString("HH:mm:ss"); // Obtén la hora completa

                // Cambia la comparación para considerar la hora completa
                if (!horasOcupadas.Contains(horaActual))
                {
                    // Agrega solo la hora y minutos al ComboBox
                    cmbHora.Items.Add(horaInicio.ToString("HH:mm"));
                }

                horaInicio = horaInicio.AddHours(1);
            }
        }


        public void cargarDentistasCombo()
        {
            cmbDentista.SelectedIndexChanged -= cmbDentista_SelectedIndexChanged;
            cmbDentista.DataSource = consultaGeneralDentistas().Tables["General"];
            cmbDentista.DisplayMember = "Nombre";
            cmbDentista.ValueMember = "Nombre";
            cmbDentista.SelectedIndexChanged += cmbDentista_SelectedIndexChanged;
        }

        public DataSet consultaIndividualDentistas(String nombre)
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

        public DataSet consultaIndividualTratamientos(String nombre)
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

        public void cargarTratamientosCombo()
        {
            cmbTratamiento.SelectedIndexChanged -= cmbTratamiento_SelectedIndexChanged;
            cmbTratamiento.DataSource = consultaGeneralTratamientos().Tables["General"];
            cmbTratamiento.DisplayMember = "Tratamiento";
            cmbTratamiento.ValueMember = "Tratamiento";
            cmbTratamiento.SelectedIndexChanged += cmbTratamiento_SelectedIndexChanged;
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedIndex > -1)
            {
                string nombre = cmbPaciente.Text;
                DataTable cargarPaciente = consultaIndividualPacientes(nombre).Tables["Paciente"];
                DataRow p = cargarPaciente.Rows[0];

                txtIdPaciente.Text = p["No. Paciente"].ToString();
                txtAlergias.Text = p["Alergias"].ToString();
                saldoPaciente = Convert.ToDecimal(p["Saldo"].ToString());



                if (!txtAlergias.Text.Equals("Ninguna"))
                {
                    txtAlergias.Visible = true;
                    pbAlergia.Enabled = true;
                    pbAlergia.Visible = true;
                }
                else if (txtAlergias.Text.Equals("Ninguna"))
                {
                    txtAlergias.Visible = false;
                    pbAlergia.Enabled = false;
                    pbAlergia.Visible = false;
                }

            }
        }

        private void cmbDentista_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbDentista.SelectedIndex > -1)
            {
                string nombre = cmbDentista.Text;
                DataTable cargarDentista = consultaIndividualDentistas(nombre).Tables["Dentista"];
                DataRow d = cargarDentista.Rows[0];
                txtIdDentista.Text = d["No. Dentista"].ToString();
            }
        }

        private void cmbTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTratamiento.SelectedIndex > -1)
            {
                decimal importeficticio;
                string nombre = cmbTratamiento.Text;
                DataTable cargarTratamiento = consultaIndividualTratamientos(nombre).Tables["Tratamiento"];
                DataRow d = cargarTratamiento.Rows[0];
                idtratamientoMemoria = Convert.ToInt32(d["No. Tratamiento"].ToString());
                importeficticio = Math.Round(Convert.ToDecimal(d["Importe"].ToString()),2);
                txtImporte.Text =Convert.ToString(importeficticio);

                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
                idtratamientoMemoria = 0;
            }
        }

        private void dptFecha_ValueChanged(object sender, EventArgs e)
        {

            if (dptFecha.Value.DayOfWeek == DayOfWeek.Sunday) { 
                cmbHora.Items.Clear();
                cmbHora.Visible = false;
                pbCerrado.Enabled = true;
                pbCerrado.Visible = true;
                
            }
            else
            {
                pbCerrado.Visible = false;
                pbCerrado.Enabled = false;
                cmbHora.Visible = true;
                LlenarComboHoras();
                cmbHora.SelectedIndex = 0;
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            btnGrabar.Enabled = true;
            string tratamiento = cmbTratamiento.Text;
            decimal importeDetalle = Math.Round(Convert.ToDecimal(txtImporte.Text),2);
            Boolean repetido = false;
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (idtratamientoMemoria == Convert.ToInt32(fila.Cells[0].Value))
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                total = Math.Round(Convert.ToDecimal(txtImporte.Text) + total,2);

                txtTotal.Text = Convert.ToString(total);
                dgvDetalle.Rows.Add(idtratamientoMemoria, tratamiento, importeDetalle);

                cmbTratamiento.SelectedIndex = -1;
                txtImporte.Text = "";
            }
            else
            {
                toolTip.Show("Solo puedes agregar tratamientos diferentes", btnAgregar, 50, 30, 3000);
            }
        }
    }
}
