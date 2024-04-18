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
using Microsoft.Reporting.WinForms;

namespace ConsultorioDental
{
    public partial class frmReportes : MaterialSkin.Controls.MaterialForm
    {

        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
        SqlCommand comandocons = new SqlCommand();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            CargarAniosEnComboBox();
            CargarAniosGanancias();

            CargarPacientes();
            CargarDentistas();


            conexion.ConnectionString = "server=localhost; database=ConsultorioDentalCare; Integrated security=true";
            conexion.Open();
            comando = conexion.CreateCommand();
            comandocons = conexion.CreateCommand();
            this.reportViewer1.RefreshReport();
            combomes.Enabled = false;



        }


        private void CargarAniosHistorial()
        {

            string connectionString = "Server=localhost;Database=ConsultorioDentalCare;Integrated Security=SSPI";



            string query = "SELECT DISTINCT YEAR(Fecha) AS Anio FROM Citas C INNER JOIN Pacientes P ON P.IdPaciente=C.IdPaciente WHERE P.Nombre='" + paciente.SelectedItem + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            añopaciente.Items.Add(reader["Anio"]);

                        }
                    }
                }
            }
        }
        private void CargarAniosCitas()
        {

            string connectionString = "Server=localhost;Database=ConsultorioDentalCare;Integrated Security=SSPI";



            string query = "SELECT DISTINCT YEAR(Fecha) AS Anio FROM Citas C INNER JOIN Dentistas D ON D.IdDentista=C.IdDentista WHERE D.Nombre='" + dentistas.SelectedItem + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            añodentista.Items.Add(reader["Anio"]);

                        }
                    }
                }
            }
        }
        private void CargarAniosEnComboBox()
        {

            string connectionString = "Server=localhost;Database=ConsultorioDentalCare;Integrated Security=SSPI";



            string query = "SELECT DISTINCT YEAR(Fecha) AS Anio FROM Citas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            comboyears.Items.Add(reader["Anio"]);
                            cmbyear.Items.Add(reader["Anio"]);
                            cboyear.Items.Add(reader["Anio"]);
                            añorecurrente.Items.Add(reader["Anio"]);
                            añodentistassolicitados.Items.Add(reader["Anio"]);

                        }
                    }
                }
            }
        }
        private void CargarAniosGanancias()
        {

            string connectionString = "Server=localhost;Database=ConsultorioDentalCare;Integrated Security=SSPI";



            string query = "SELECT DISTINCT YEAR(Fecha) AS Anio FROM Cobros";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            gananciasan.Items.Add(reader["Anio"]);
                        }
                    }
                }
            }
        }
        private void CargarPacientes()
        {

            string connectionString = "Server=localhost;Database=ConsultorioDentalCare;Integrated Security=SSPI";



            string query = "SELECT DISTINCT P.Nombre AS Anio FROM Pacientes P ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            paciente.Items.Add(reader["Anio"]);
                        }
                    }
                }
            }
        }
        private void CargarDentistas()
        {

            string connectionString = "Server=localhost;Database=ConsultorioDentalCare;Integrated Security=SSPI";



            string query = "SELECT DISTINCT D.Nombre AS Anio FROM Dentistas D ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            dentistas.Items.Add(reader["Anio"]);
                        }
                    }
                }
            }
        }
        private void CargarmesesEnComboBox()
        {

            string connectionString = "Server=localhost;Database=ConsultorioDentalCare;Integrated Security=SSPI";

            // Verifica si comboyears está seleccionado y llena combomes
            if (comboyears.SelectedItem != null)
            {
                string query = "SELECT DISTINCT MONTH(C.Fecha) AS Anio FROM Citas C INNER JOIN DetalleCita DC ON C.IdCita = DC.IdCita WHERE YEAR(C.Fecha)='" + comboyears.SelectedItem + "' GROUP BY MONTH(C.Fecha)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                combomes.Items.Add(reader["Anio"]);
                            }
                        }
                    }
                }
            }

            // Verifica si cmbyear está seleccionado y llena cmbmes
            if (cmbyear.SelectedItem != null)
            {
                string query = "SELECT DISTINCT MONTH(Fecha) AS Anio FROM Citas WHERE YEAR(Fecha)='" + cmbyear.SelectedItem + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbmes.Items.Add(reader["Anio"]);
                            }
                        }
                    }
                }
            }

            // Verifica si comboyears está seleccionado y llena combomes
            if (cboyear.SelectedItem != null)
            {
                string query = "SELECT DISTINCT MONTH(C.Fecha) AS Anio FROM Citas C INNER JOIN DetalleCita DC ON C.IdCita = DC.IdCita WHERE YEAR(C.Fecha)='" + cboyear.SelectedItem + "' and C.Estado='" + cboestado.SelectedItem + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbomes.Items.Add(reader["Anio"]);
                            }
                        }
                    }
                }
            }
            if (gananciasan.SelectedItem != null)
            {
                string query = "SELECT DISTINCT MONTH(C.Fecha) AS Anio FROM Cobros C WHERE YEAR(C.Fecha)='" + gananciasan.SelectedItem + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                gananciasmes.Items.Add(reader["Anio"]);
                            }
                        }
                    }
                }
            }
            if (añopaciente.SelectedItem != null)
            {
                string query = "SELECT DISTINCT MONTH(C.Fecha) AS Anio FROM Citas C INNER JOIN Pacientes P ON P.IdPaciente=C.IdPaciente WHERE YEAR(C.Fecha)='" + añopaciente.SelectedItem + "' AND P.Nombre='" + paciente.SelectedItem + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mespaciente.Items.Add(reader["Anio"]);
                            }
                        }
                    }
                }
            }
            if (añorecurrente.SelectedItem != null)
            {
                string query = "SELECT DISTINCT MONTH(Fecha) AS Anio FROM Citas WHERE YEAR(Fecha)='" + añorecurrente.SelectedItem + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mesrecurrente.Items.Add(reader["Anio"]);
                            }
                        }
                    }
                }
            }
            if (añodentista.SelectedItem != null)
            {
                string query = "SELECT DISTINCT MONTH(C.Fecha) AS Anio FROM Citas C INNER JOIN Dentistas D ON D.IdDentista=C.IdDentista WHERE YEAR(C.Fecha)='" + añodentista.SelectedItem + "' AND D.Nombre='" + dentistas.SelectedItem + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mesdentista.Items.Add(reader["Anio"]);
                            }
                        }
                    }
                }
            }
            if (añodentistassolicitados.SelectedItem != null)
            {
                string query = "SELECT DISTINCT MONTH(Fecha) AS Anio FROM Citas WHERE YEAR(Fecha)='" + añodentistassolicitados.SelectedItem + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mesdentistassolicitados.Items.Add(reader["Anio"]);
                            }
                        }
                    }
                }
            }

        }

        private void Generar_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();

                if (comboyears.SelectedItem != null)
                {
                    comando.Parameters.Clear();

                    comando.CommandText = "CITASPERIODO";
                    comando.CommandType = CommandType.StoredProcedure;

                    // Validación para asegurarse de que el mes no esté vacío
                    if (!string.IsNullOrEmpty(comboyears.SelectedItem?.ToString()) && string.IsNullOrEmpty(combomes.SelectedItem?.ToString()))
                    {
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@an", comboyears.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", DBNull.Value);
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSet11";

                        ReportDataSource dtsource = new ReportDataSource("DataSet11", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.Reporte_Por_Periodo.rdlc";
                        ReportParameter fi = new ReportParameter("an", comboyears.SelectedItem.ToString());
                        ReportParameter ff = new ReportParameter("mes", Convert.ToString(DBNull.Value));






                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        comboyears.SelectedItem = null;  // o -1 si es un índice válido
                        combomes.SelectedItem = null;







                    }
                    else if (!string.IsNullOrEmpty(combomes.SelectedItem?.ToString()) && !string.IsNullOrEmpty(comboyears.SelectedItem?.ToString()))
                    {


                        comando.Parameters.AddWithValue("@an", comboyears.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", combomes.SelectedItem.ToString());
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSet11";

                        ReportDataSource dtsource = new ReportDataSource("DataSet11", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.Reporte_Por_Periodo.rdlc";
                        ReportParameter fi = new ReportParameter("an", comboyears.SelectedItem.ToString());


                        ReportParameter ff = new ReportParameter("mes", combomes.SelectedItem.ToString());
                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff });



                        this.reportViewer1.RefreshReport();
                        this.Show();

                        comboyears.SelectedItem = null;  // o -1 si es un índice válido
                        combomes.SelectedItem = null;
                    }


                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboyears_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomes.Items.Clear();
            cmbmes.Items.Clear();
            combomes.Enabled = true;
            CargarmesesEnComboBox();

        }

        private void generartratamiento_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();

                if (cmbyear.SelectedItem != null)
                {
                    comando.Parameters.Clear();

                    comando.CommandText = "TRATAMIENTOPERIODO";
                    comando.CommandType = CommandType.StoredProcedure;

                    // Validación para asegurarse de que el mes no esté vacío
                    if (!string.IsNullOrEmpty(cmbyear.SelectedItem?.ToString()) && string.IsNullOrEmpty(cmbmes.SelectedItem?.ToString()))
                    {
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@an", cmbyear.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", DBNull.Value);
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetTratamientoperiodo";

                        ReportDataSource dtsource = new ReportDataSource("DataSetTratamientoperiodo", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.Reporte_tratamiento_periodo.rdlc";
                        ReportParameter fi = new ReportParameter("an", cmbyear.SelectedItem.ToString());
                        ReportParameter ff = new ReportParameter("mes", Convert.ToString(DBNull.Value));






                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        cmbyear.SelectedItem = null;  // o -1 si es un índice válido
                        cmbmes.SelectedItem = null;






                    }
                    else if (!string.IsNullOrEmpty(cmbmes.SelectedItem?.ToString()) && !string.IsNullOrEmpty(cmbyear.SelectedItem?.ToString()))
                    {


                        comando.Parameters.AddWithValue("@an", cmbyear.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", cmbmes.SelectedItem.ToString());
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetTratamientoperiodo";

                        ReportDataSource dtsource = new ReportDataSource("DataSetTratamientoperiodo", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.Reporte_tratamiento_periodo.rdlc";
                        ReportParameter fi = new ReportParameter("an", cmbyear.SelectedItem.ToString());


                        ReportParameter ff = new ReportParameter("mes", cmbmes.SelectedItem.ToString());
                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff });



                        this.reportViewer1.RefreshReport();
                        this.Show();
                        cmbyear.SelectedItem = null;  // o -1 si es un índice válido
                        cmbmes.SelectedItem = null;

                    }


                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomes.Items.Clear();
            cmbmes.Items.Clear();
            cmbmes.Enabled = true;
            CargarmesesEnComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();



                // Validación para asegurarse de que el mes no esté vacío
                if (!string.IsNullOrEmpty(cboyear.SelectedItem?.ToString()) && string.IsNullOrEmpty(cbomes.SelectedItem?.ToString()) && !string.IsNullOrEmpty(cboestado.SelectedItem?.ToString()))
                {
                    comando.Parameters.Clear();

                    comando.CommandText = "DEUDORESONOAN";
                    comando.CommandType = CommandType.StoredProcedure;
                    // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                    comando.Parameters.AddWithValue("@an", cboyear.SelectedItem.ToString());

                    comando.Parameters.AddWithValue("@genap", cboestado.SelectedItem.ToString());
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataSet data = new DataSet();
                    adaptador.Fill(data);

                    data.DataSetName = "DataSetDeudoresAnual";

                    ReportDataSource dtsource = new ReportDataSource("DataSetDeudoresAnual", data.Tables[0]);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDeudoresAnueles.rdlc";
                    ReportParameter fi = new ReportParameter("an", cboyear.SelectedItem.ToString());
                    ReportParameter fif = new ReportParameter("genap", cboestado.SelectedItem.ToString());







                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, fif });


                    this.reportViewer1.RefreshReport();
                    this.Show();


                    cboyear.SelectedItem = null;  // o -1 si es un índice válido
                    cbomes.SelectedItem = null;
                    cboestado.SelectedItem = null;  // o -1 si es un índice válido





                }
                else if (!string.IsNullOrEmpty(cbomes.SelectedItem?.ToString()) && !string.IsNullOrEmpty(cboyear.SelectedItem?.ToString()) && !string.IsNullOrEmpty(cboestado.SelectedItem?.ToString()))
                {
                    comando.Parameters.Clear();

                    comando.CommandText = "DEUDORESONOSEM";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@an", cboyear.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@mes", cbomes.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@genap", cboestado.SelectedItem.ToString());
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataSet data = new DataSet();
                    adaptador.Fill(data);

                    data.DataSetName = "DataSetDeudoresSemanales";

                    ReportDataSource dtsource = new ReportDataSource("DataSetDeudoresSemanales", data.Tables[0]);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDeudoresSem.rdlc";
                    ReportParameter fi = new ReportParameter("an", cboyear.SelectedItem.ToString());


                    ReportParameter ff = new ReportParameter("mes", cbomes.SelectedItem.ToString());
                    ReportParameter fif = new ReportParameter("genap", cboestado.SelectedItem.ToString());
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff, fif });



                    this.reportViewer1.RefreshReport();
                    this.Show();
                    cboyear.SelectedItem = null;  // o -1 si es un índice válido
                    cbomes.SelectedItem = null;
                    cboestado.SelectedItem = null;  // o -1 si es un índice válido

                }
                else if (string.IsNullOrEmpty(cboyear.SelectedItem?.ToString()) && string.IsNullOrEmpty(cbomes.SelectedItem?.ToString()) && !string.IsNullOrEmpty(cboestado.SelectedItem?.ToString()))
                {
                    comando.Parameters.Clear();

                    comando.CommandText = "DEUDORESONO";
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@genap", cboestado.SelectedItem.ToString());
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataSet data = new DataSet();
                    adaptador.Fill(data);

                    data.DataSetName = "DataSetDeudoresono";

                    ReportDataSource dtsource = new ReportDataSource("DataSetDeudoresono", data.Tables[0]);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDeudoresgen.rdlc";

                    ReportParameter fif = new ReportParameter("genap", cboestado.SelectedItem.ToString());







                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fif });


                    this.reportViewer1.RefreshReport();
                    this.Show();
                    cboyear.SelectedItem = null;  // o -1 si es un índice válido
                    cbomes.SelectedItem = null;
                    cboestado.SelectedItem = null;  // o -1 si es un índice válido
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomes.Items.Clear();
            cmbmes.Items.Clear();
            cbomes.Items.Clear();
            cbomes.Enabled = true;
            CargarmesesEnComboBox();
        }

        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboyear.Enabled = true;

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();

                if (gananciasan.SelectedItem != null)
                {

                    // Validación para asegurarse de que el mes no esté vacío
                    if (!string.IsNullOrEmpty(gananciasan.SelectedItem?.ToString()) && string.IsNullOrEmpty(gananciasmes.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "GANACIASAN";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@an", gananciasan.SelectedItem.ToString());

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetGananciasAnuales";

                        ReportDataSource dtsource = new ReportDataSource("DataSetGananciasAnuales", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteGananciasAn.rdlc";
                        ReportParameter fi = new ReportParameter("an", gananciasan.SelectedItem.ToString());








                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi });


                        this.reportViewer1.RefreshReport();
                        this.Show();




                        gananciasan.SelectedItem = null;  // o -1 si es un índice válido
                        gananciasmes.SelectedItem = null;






                    }
                    else if (!string.IsNullOrEmpty(gananciasan.SelectedItem?.ToString()) && !string.IsNullOrEmpty(gananciasmes.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "GANACIASMENSEM";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@an", gananciasan.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", gananciasmes.SelectedItem.ToString());

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetGananciasMensualesSemanales";

                        ReportDataSource dtsource = new ReportDataSource("DataSetGananciasMensualesSemanales", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteGananciasmessem.rdlc";
                        ReportParameter fi = new ReportParameter("an", gananciasan.SelectedItem.ToString());
                        ReportParameter ff = new ReportParameter("mes", gananciasmes.SelectedItem.ToString());








                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        gananciasan.SelectedItem = null;  // o -1 si es un índice válido
                        gananciasmes.SelectedItem = null;







                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gananciasan_SelectedIndexChanged(object sender, EventArgs e)
        {
            gananciasmes.Items.Clear();
            CargarmesesEnComboBox();
            gananciasmes.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            citasdentista.Visible = true;
            dentistassolicitados.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dentistassolicitados.Visible = true;
            citasdentista.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dentistassolicitados.Visible = false;
            citasdentista.Visible = false;


            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();


                comando.Parameters.Clear();

                comando.CommandText = "DENTISTASGENERAL";
                comando.CommandType = CommandType.StoredProcedure;



                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adaptador.Fill(data);

                data.DataSetName = "DataSetDentistasGeneral";

                ReportDataSource dtsource = new ReportDataSource("DataSetDentistasGeneral", data.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDentistasGeneral.rdlc";







                this.reportViewer1.RefreshReport();
                this.Show();





            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnrecurrentes_Click(object sender, EventArgs e)
        {
            gruporecurrente.Visible = true;
            historialgrupo.Visible = false;
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            historialgrupo.Visible = true;
            gruporecurrente.Visible = false;
        }

        private void btngeneral_Click(object sender, EventArgs e)
        {
            historialgrupo.Visible = false;
            gruporecurrente.Visible = false;




            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();


                comando.Parameters.Clear();

                comando.CommandText = "PACIENTESGENERAL";
                comando.CommandType = CommandType.StoredProcedure;



                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adaptador.Fill(data);

                data.DataSetName = "DataSetPacienteGeneral";

                ReportDataSource dtsource = new ReportDataSource("DataSetPacienteGeneral", data.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReportePacientesGeneral.rdlc";







                this.reportViewer1.RefreshReport();
                this.Show();





            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();

                if (paciente.SelectedItem != null)
                {
                    if (!string.IsNullOrEmpty(paciente.SelectedItem?.ToString()) && string.IsNullOrEmpty(añopaciente.SelectedItem?.ToString()) && string.IsNullOrEmpty(mespaciente.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "HISTORIALPACIENTE";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@paciente", paciente.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetHistorialPaci";

                        ReportDataSource dtsource = new ReportDataSource("DataSetHistorialPaci", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteHistorialPaciente.rdlc";
                        ReportParameter fi = new ReportParameter("paciente", paciente.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        paciente.SelectedItem = null;  // o -1 si es un índice válido
                        mespaciente.SelectedItem = null;
                        añopaciente.SelectedItem = null;
                    }
                    else if (!string.IsNullOrEmpty(paciente.SelectedItem?.ToString()) && !string.IsNullOrEmpty(añopaciente.SelectedItem?.ToString()) && string.IsNullOrEmpty(mespaciente.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "HISTORIALPACIENTEAN";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@paciente", paciente.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@an", añopaciente.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetHistorialPacAn";

                        ReportDataSource dtsource = new ReportDataSource("DataSetHistorialPacAn", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteHistorialPacienteAnual.rdlc";
                        ReportParameter fi = new ReportParameter("paciente", paciente.SelectedItem.ToString());
                        ReportParameter ff = new ReportParameter("an", añopaciente.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        paciente.SelectedItem = null;  // o -1 si es un índice válido
                        mespaciente.SelectedItem = null;
                        añopaciente.SelectedItem = null;
                    }
                    else if (!string.IsNullOrEmpty(paciente.SelectedItem?.ToString()) && !string.IsNullOrEmpty(añopaciente.SelectedItem?.ToString()) && !string.IsNullOrEmpty(mespaciente.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "HISTORIALPACIENTEMESSEM";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@paciente", paciente.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@an", añopaciente.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", mespaciente.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetHistorialMesSemanal";

                        ReportDataSource dtsource = new ReportDataSource("DataSetHistorialMesSemanal", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteHistorialMensem.rdlc";
                        ReportParameter fi = new ReportParameter("paciente", paciente.SelectedItem.ToString());
                        ReportParameter ff = new ReportParameter("an", añopaciente.SelectedItem.ToString());
                        ReportParameter fff = new ReportParameter("mes", mespaciente.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff, fff });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        paciente.SelectedItem = null;  // o -1 si es un índice válido
                        mespaciente.SelectedItem = null;
                        añopaciente.SelectedItem = null;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            añopaciente.Items.Clear();
            mespaciente.Items.Clear();
            añopaciente.Enabled = true;
            CargarAniosHistorial();

        }

        private void añopaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            mespaciente.Items.Clear();
            CargarmesesEnComboBox();
            mespaciente.Enabled = true;

        }

        private void añorecurrente_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesrecurrente.Items.Clear();
            CargarmesesEnComboBox();
            mesrecurrente.Enabled = true;
        }

        private void okrecurrente_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();

                if (añorecurrente.SelectedItem != null)
                {
                    if (!string.IsNullOrEmpty(añorecurrente.SelectedItem?.ToString()) && string.IsNullOrEmpty(mesrecurrente.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "PACIENTESRECURRENTESAN";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@an", añorecurrente.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetPacientesRecurrentesAnuales";

                        ReportDataSource dtsource = new ReportDataSource("DataSetPacientesRecurrentesAnuales", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReportePacientesrecurrentesAn.rdlc";
                        ReportParameter fi = new ReportParameter("an", añorecurrente.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        añorecurrente.SelectedItem = null;  // o -1 si es un índice válido
                        mesrecurrente.SelectedItem = null;

                    }
                    else if (!string.IsNullOrEmpty(añorecurrente.SelectedItem?.ToString()) && !string.IsNullOrEmpty(mesrecurrente.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "PACIENTESRECURRENTESMENSEM";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@an", añorecurrente.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", mesrecurrente.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetpacienterecurrentemessem";

                        ReportDataSource dtsource = new ReportDataSource("DataSetpacienterecurrentemessem", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.Reportepacienterecurrentesemmes.rdlc";
                        ReportParameter fi = new ReportParameter("an", añorecurrente.SelectedItem.ToString());
                        ReportParameter ff = new ReportParameter("mes", mesrecurrente.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        añorecurrente.SelectedItem = null;  // o -1 si es un índice válido
                        mesrecurrente.SelectedItem = null;

                    }
                }

                else
                {
                    MessageBox.Show("Por favor, seleccione un año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dentistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            añodentista.Items.Clear();
            mesdentista.Items.Clear();
            diadentista.Items.Clear();
            CargarAniosCitas();
            añodentista.Enabled = true;

        }

        private void añodentista_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesdentista.Items.Clear();
            mesdentista.Enabled = true;
            CargarmesesEnComboBox();
        }
        private void CargardiasCitas()
        {

            string connectionString = "Server=localhost;Database=ConsultorioDentalCare;Integrated Security=SSPI";



            string query = "SELECT DISTINCT day(Fecha) AS Anio FROM Citas C INNER JOIN Dentistas D ON D.IdDentista=C.IdPaciente WHERE YEAR(C.Fecha)='" + añodentista.SelectedItem + "' AND D.Nombre='" + dentistas.SelectedItem + "' AND MONTH(C.Fecha)='" + mesdentista.SelectedItem + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            diadentista.Items.Add(reader["Anio"]);

                        }
                    }
                }
            }
        }
        private void mesdentista_SelectedIndexChanged(object sender, EventArgs e)
        {
            diadentista.Items.Clear();
            diadentista.Enabled = true;
            CargardiasCitas();

        }

        private void btngenerardentistas_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();

                if (dentistas.SelectedItem != null)
                {
                    if (!string.IsNullOrEmpty(dentistas.SelectedItem?.ToString()) && string.IsNullOrEmpty(añodentista.SelectedItem?.ToString()) && string.IsNullOrEmpty(mesdentista.SelectedItem?.ToString()) && string.IsNullOrEmpty(diadentista.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "DENTISTASCITAS";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@dentista", dentistas.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetDentistaCitas";

                        ReportDataSource dtsource = new ReportDataSource("DataSetDentistaCitas", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDentistaCita.rdlc";
                        ReportParameter fi = new ReportParameter("dentista", dentistas.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        dentistas.SelectedItem = null;  // o -1 si es un índice válido
                        añodentista.SelectedItem = null;
                        mesdentista.SelectedItem = null;  // o -1 si es un índice válido
                        diadentista.SelectedItem = null;

                        añodentista.Enabled = false;
                        mesdentista.Enabled = false;
                        diadentista.Enabled = false;

                    }
                    else if (!string.IsNullOrEmpty(dentistas.SelectedItem?.ToString()) && !string.IsNullOrEmpty(añodentista.SelectedItem?.ToString()) && string.IsNullOrEmpty(mesdentista.SelectedItem?.ToString()) && string.IsNullOrEmpty(diadentista.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "DENTISTASCITASAN";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@dentista", dentistas.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@an", añodentista.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetDentistaCitaAnuales";

                        ReportDataSource dtsource = new ReportDataSource("DataSetDentistaCitaAnuales", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDentistasCitaAn.rdlc";
                        ReportParameter fi = new ReportParameter("dentista", dentistas.SelectedItem.ToString());
                         ReportParameter fd= new ReportParameter("an", añodentista.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, fd });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        dentistas.SelectedItem = null;  // o -1 si es un índice válido
                        añodentista.SelectedItem = null;
                        mesdentista.SelectedItem = null;  // o -1 si es un índice válido
                        diadentista.SelectedItem = null;

                        añodentista.Enabled = false;
                        mesdentista.Enabled = false;
                        diadentista.Enabled = false;

                    }
                    else if (!string.IsNullOrEmpty(dentistas.SelectedItem?.ToString()) && !string.IsNullOrEmpty(añodentista.SelectedItem?.ToString()) && !string.IsNullOrEmpty(mesdentista.SelectedItem?.ToString()) && string.IsNullOrEmpty(diadentista.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "DENTISTASCITAMESSEM";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@dentista", dentistas.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@an", añodentista.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", mesdentista.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetDentistaCitasMesSemanal";

                        ReportDataSource dtsource = new ReportDataSource("DataSetDentistaCitasMesSemanal", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDentistaCitasMESSEM.rdlc";
                        ReportParameter fi = new ReportParameter("dentista", dentistas.SelectedItem.ToString());
                        ReportParameter fd = new ReportParameter("an", añodentista.SelectedItem.ToString());
                        ReportParameter fdd = new ReportParameter("mes", mesdentista.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, fd, fdd });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        dentistas.SelectedItem = null;  // o -1 si es un índice válido
                        añodentista.SelectedItem = null;
                        mesdentista.SelectedItem = null;  // o -1 si es un índice válido
                        diadentista.SelectedItem = null;
                        añodentista.Enabled = false;
                        mesdentista.Enabled = false;
                        diadentista.Enabled = false;

                    }
                    else if (!string.IsNullOrEmpty(dentistas.SelectedItem?.ToString()) && !string.IsNullOrEmpty(añodentista.SelectedItem?.ToString()) && !string.IsNullOrEmpty(mesdentista.SelectedItem?.ToString()) && !string.IsNullOrEmpty(diadentista.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "DENTISTASCITADIAS";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@dentista", dentistas.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@an", añodentista.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", mesdentista.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@dia", diadentista.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetDentistaCitasDias";

                        ReportDataSource dtsource = new ReportDataSource("DataSetDentistaCitasDias", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDentistaCitasDias.rdlc";
                        ReportParameter fi = new ReportParameter("dentista", dentistas.SelectedItem.ToString());
                        ReportParameter fd = new ReportParameter("an", añodentista.SelectedItem.ToString());
                        ReportParameter fdd = new ReportParameter("mes", mesdentista.SelectedItem.ToString());
                        ReportParameter fddd = new ReportParameter("dia", diadentista.SelectedItem.ToString());


                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, fd, fdd, fddd });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        dentistas.SelectedItem = null;  // o -1 si es un índice válido
                        añodentista.SelectedItem = null;
                        mesdentista.SelectedItem = null;  // o -1 si es un índice válido
                        diadentista.SelectedItem = null;

                        añodentista.Enabled = false;
                        mesdentista.Enabled = false;
                        diadentista.Enabled = false;

                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un dentista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void añodentistassolicitados_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesdentistassolicitados.Enabled = true;
            mesdentistassolicitados.Items.Clear();
            CargarmesesEnComboBox();
        }

        private void btndentistassolicitados_Click(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.Clear();
                this.reportViewer1.RefreshReport();

                if (añodentistassolicitados.SelectedItem != null)
                {
                    if (!string.IsNullOrEmpty(añodentistassolicitados.SelectedItem?.ToString()) && string.IsNullOrEmpty(mesdentistassolicitados.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "DENTISTASRECURRENTESAN";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@an", añodentistassolicitados.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetDentistaSolicitadoAnual";

                        ReportDataSource dtsource = new ReportDataSource("DataSetDentistaSolicitadoAnual", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDentistaSolicitadoAn.rdlc";
                        ReportParameter fi = new ReportParameter("an", añodentistassolicitados.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        añodentistassolicitados.SelectedItem = null;  // o -1 si es un índice válido
                        mesdentistassolicitados.SelectedItem = null;

                    }
                    else if (!string.IsNullOrEmpty(añodentistassolicitados.SelectedItem?.ToString()) && !string.IsNullOrEmpty(mesdentistassolicitados.SelectedItem?.ToString()))
                    {
                        comando.Parameters.Clear();

                        comando.CommandText = "DENTISTASRECURRENTESMENSEM";
                        comando.CommandType = CommandType.StoredProcedure;
                        // Si el mes está vacío, asignamos DBNull.Value para manejar el parámetro nullable en el procedimiento almacenado
                        comando.Parameters.AddWithValue("@an", añodentistassolicitados.SelectedItem.ToString());
                        comando.Parameters.AddWithValue("@mes", mesdentistassolicitados.SelectedItem.ToString());


                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataSet data = new DataSet();
                        adaptador.Fill(data);

                        data.DataSetName = "DataSetDentistasSolicitadosMenSem";

                        ReportDataSource dtsource = new ReportDataSource("DataSetDentistasSolicitadosMenSem", data.Tables[0]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dtsource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsultorioDental.ReporteDentistasSolicitadosMenSem.rdlc";
                        ReportParameter fi = new ReportParameter("an", añodentistassolicitados.SelectedItem.ToString());
                        ReportParameter ff = new ReportParameter("mes", mesdentistassolicitados.SelectedItem.ToString());



                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff });


                        this.reportViewer1.RefreshReport();
                        this.Show();


                        añodentistassolicitados.SelectedItem = null;  // o -1 si es un índice válido
                        mesdentistassolicitados.SelectedItem = null;

                    }
                }

                else
                {
                    MessageBox.Show("Por favor, seleccione un año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
