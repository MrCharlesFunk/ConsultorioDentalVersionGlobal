namespace ConsultorioDental
{
    partial class frmCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            this.txtIdCita = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbDentista = new MaterialSkin.Controls.MaterialComboBox();
            this.txtIdDentista = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbPaciente = new MaterialSkin.Controls.MaterialComboBox();
            this.txtIdPaciente = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbTratamiento = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTratamiento = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtImporte = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbCitas = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidad = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.IdTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.gbDatosCita = new System.Windows.Forms.GroupBox();
            this.dptFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAlergias = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.gbTratamiento = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbHora = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.pbCerrado = new System.Windows.Forms.PictureBox();
            this.pbAlergia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.gbCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbDatosCita.SuspendLayout();
            this.gbTratamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlergia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCita
            // 
            this.txtIdCita.AnimateReadOnly = false;
            this.txtIdCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdCita.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdCita.Depth = 0;
            this.txtIdCita.Enabled = false;
            this.txtIdCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdCita.HideSelection = true;
            this.txtIdCita.LeadingIcon = null;
            this.txtIdCita.Location = new System.Drawing.Point(19, 33);
            this.txtIdCita.MaxLength = 32767;
            this.txtIdCita.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.PasswordChar = '\0';
            this.txtIdCita.PrefixSuffixText = null;
            this.txtIdCita.ReadOnly = false;
            this.txtIdCita.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdCita.SelectedText = "";
            this.txtIdCita.SelectionLength = 0;
            this.txtIdCita.SelectionStart = 0;
            this.txtIdCita.ShortcutsEnabled = true;
            this.txtIdCita.Size = new System.Drawing.Size(110, 36);
            this.txtIdCita.TabIndex = 101;
            this.txtIdCita.TabStop = false;
            this.txtIdCita.Text = "Id Cita";
            this.txtIdCita.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdCita.TrailingIcon = null;
            this.txtIdCita.UseSystemPasswordChar = false;
            this.txtIdCita.UseTallSize = false;
            // 
            // cmbDentista
            // 
            this.cmbDentista.AutoResize = false;
            this.cmbDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDentista.Depth = 0;
            this.cmbDentista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDentista.DropDownHeight = 118;
            this.cmbDentista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDentista.DropDownWidth = 121;
            this.cmbDentista.Enabled = false;
            this.cmbDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDentista.FormattingEnabled = true;
            this.cmbDentista.IntegralHeight = false;
            this.cmbDentista.ItemHeight = 29;
            this.cmbDentista.Location = new System.Drawing.Point(91, 138);
            this.cmbDentista.MaxDropDownItems = 4;
            this.cmbDentista.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDentista.Name = "cmbDentista";
            this.cmbDentista.Size = new System.Drawing.Size(310, 35);
            this.cmbDentista.StartIndex = 0;
            this.cmbDentista.TabIndex = 104;
            this.cmbDentista.UseTallSize = false;
            this.cmbDentista.SelectedIndexChanged += new System.EventHandler(this.cmbDentista_SelectedIndexChanged);
            // 
            // txtIdDentista
            // 
            this.txtIdDentista.AnimateReadOnly = false;
            this.txtIdDentista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdDentista.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdDentista.Depth = 0;
            this.txtIdDentista.Enabled = false;
            this.txtIdDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdDentista.HideSelection = true;
            this.txtIdDentista.LeadingIcon = null;
            this.txtIdDentista.Location = new System.Drawing.Point(430, 138);
            this.txtIdDentista.MaxLength = 32767;
            this.txtIdDentista.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdDentista.Name = "txtIdDentista";
            this.txtIdDentista.PasswordChar = '\0';
            this.txtIdDentista.PrefixSuffixText = null;
            this.txtIdDentista.ReadOnly = false;
            this.txtIdDentista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdDentista.SelectedText = "";
            this.txtIdDentista.SelectionLength = 0;
            this.txtIdDentista.SelectionStart = 0;
            this.txtIdDentista.ShortcutsEnabled = true;
            this.txtIdDentista.Size = new System.Drawing.Size(117, 36);
            this.txtIdDentista.TabIndex = 102;
            this.txtIdDentista.TabStop = false;
            this.txtIdDentista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdDentista.TrailingIcon = null;
            this.txtIdDentista.UseSystemPasswordChar = false;
            this.txtIdDentista.UseTallSize = false;
            this.txtIdDentista.Visible = false;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.AutoResize = false;
            this.cmbPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPaciente.Depth = 0;
            this.cmbPaciente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPaciente.DropDownHeight = 118;
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.DropDownWidth = 121;
            this.cmbPaciente.Enabled = false;
            this.cmbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.IntegralHeight = false;
            this.cmbPaciente.ItemHeight = 29;
            this.cmbPaciente.Location = new System.Drawing.Point(91, 213);
            this.cmbPaciente.MaxDropDownItems = 4;
            this.cmbPaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(310, 35);
            this.cmbPaciente.StartIndex = 0;
            this.cmbPaciente.TabIndex = 107;
            this.cmbPaciente.UseTallSize = false;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.AnimateReadOnly = false;
            this.txtIdPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdPaciente.Depth = 0;
            this.txtIdPaciente.Enabled = false;
            this.txtIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPaciente.HideSelection = true;
            this.txtIdPaciente.LeadingIcon = null;
            this.txtIdPaciente.Location = new System.Drawing.Point(430, 214);
            this.txtIdPaciente.MaxLength = 32767;
            this.txtIdPaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.PasswordChar = '\0';
            this.txtIdPaciente.PrefixSuffixText = null;
            this.txtIdPaciente.ReadOnly = false;
            this.txtIdPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdPaciente.SelectedText = "";
            this.txtIdPaciente.SelectionLength = 0;
            this.txtIdPaciente.SelectionStart = 0;
            this.txtIdPaciente.ShortcutsEnabled = true;
            this.txtIdPaciente.Size = new System.Drawing.Size(117, 36);
            this.txtIdPaciente.TabIndex = 106;
            this.txtIdPaciente.TabStop = false;
            this.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdPaciente.TrailingIcon = null;
            this.txtIdPaciente.UseSystemPasswordChar = false;
            this.txtIdPaciente.UseTallSize = false;
            this.txtIdPaciente.Visible = false;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(7, 59);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.Size = new System.Drawing.Size(562, 169);
            this.dgvCitas.TabIndex = 111;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(135, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 17);
            this.materialLabel1.TabIndex = 113;
            this.materialLabel1.Text = "Fecha:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(19, 147);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 17);
            this.materialLabel2.TabIndex = 114;
            this.materialLabel2.Text = "Dentistas:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel3.Location = new System.Drawing.Point(17, 222);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 17);
            this.materialLabel3.TabIndex = 115;
            this.materialLabel3.Text = "Pacientes:";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(704, 637);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(88, 40);
            this.btnSalir.TabIndex = 119;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.HighEmphasis = true;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(406, 637);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(88, 40);
            this.btnNuevo.TabIndex = 116;
            this.btnNuevo.Text = "    Nuevo     ";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.Location = new System.Drawing.Point(34, 295);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(49, 17);
            this.materialLabel4.TabIndex = 120;
            this.materialLabel4.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoResize = false;
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstado.Depth = 0;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownHeight = 118;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownWidth = 121;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 29;
            this.cmbEstado.Items.AddRange(new object[] {
            "A",
            "P"});
            this.cmbEstado.Location = new System.Drawing.Point(89, 286);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(75, 35);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 121;
            this.cmbEstado.UseTallSize = false;
            // 
            // cmbTratamiento
            // 
            this.cmbTratamiento.AutoResize = false;
            this.cmbTratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTratamiento.Depth = 0;
            this.cmbTratamiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTratamiento.DropDownHeight = 118;
            this.cmbTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTratamiento.DropDownWidth = 121;
            this.cmbTratamiento.Enabled = false;
            this.cmbTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTratamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTratamiento.FormattingEnabled = true;
            this.cmbTratamiento.IntegralHeight = false;
            this.cmbTratamiento.ItemHeight = 29;
            this.cmbTratamiento.Location = new System.Drawing.Point(116, 36);
            this.cmbTratamiento.MaxDropDownItems = 4;
            this.cmbTratamiento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTratamiento.Name = "cmbTratamiento";
            this.cmbTratamiento.Size = new System.Drawing.Size(304, 35);
            this.cmbTratamiento.StartIndex = 0;
            this.cmbTratamiento.TabIndex = 123;
            this.cmbTratamiento.UseTallSize = false;
            this.cmbTratamiento.SelectedIndexChanged += new System.EventHandler(this.cmbTratamiento_SelectedIndexChanged);
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Depth = 0;
            this.lblTratamiento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTratamiento.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lblTratamiento.Location = new System.Drawing.Point(25, 43);
            this.lblTratamiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(85, 17);
            this.lblTratamiento.TabIndex = 122;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(332, 92);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(88, 36);
            this.btnAgregar.TabIndex = 124;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel5.Location = new System.Drawing.Point(55, 103);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 17);
            this.materialLabel5.TabIndex = 125;
            this.materialLabel5.Text = "Importe:";
            // 
            // txtImporte
            // 
            this.txtImporte.AnimateReadOnly = false;
            this.txtImporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtImporte.Depth = 0;
            this.txtImporte.Enabled = false;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImporte.HideSelection = true;
            this.txtImporte.LeadingIcon = null;
            this.txtImporte.Location = new System.Drawing.Point(116, 92);
            this.txtImporte.MaxLength = 32767;
            this.txtImporte.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.PasswordChar = '\0';
            this.txtImporte.PrefixSuffixText = null;
            this.txtImporte.ReadOnly = false;
            this.txtImporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtImporte.SelectedText = "";
            this.txtImporte.SelectionLength = 0;
            this.txtImporte.SelectionStart = 0;
            this.txtImporte.ShortcutsEnabled = true;
            this.txtImporte.Size = new System.Drawing.Size(117, 36);
            this.txtImporte.TabIndex = 126;
            this.txtImporte.TabStop = false;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtImporte.TrailingIcon = null;
            this.txtImporte.UseSystemPasswordChar = false;
            this.txtImporte.UseTallSize = false;
            // 
            // gbCitas
            // 
            this.gbCitas.Controls.Add(this.txtTotal);
            this.gbCitas.Controls.Add(this.materialLabel9);
            this.gbCitas.Controls.Add(this.dgvDetalle);
            this.gbCitas.Controls.Add(this.materialLabel7);
            this.gbCitas.Controls.Add(this.materialLabel6);
            this.gbCitas.Controls.Add(this.dgvCitas);
            this.gbCitas.Location = new System.Drawing.Point(604, 87);
            this.gbCitas.Name = "gbCitas";
            this.gbCitas.Size = new System.Drawing.Size(575, 517);
            this.gbCitas.TabIndex = 127;
            this.gbCitas.TabStop = false;
            this.gbCitas.Text = "Citas";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.AutoResize = false;
            this.cmbEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEspecialidad.Depth = 0;
            this.cmbEspecialidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEspecialidad.DropDownHeight = 118;
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.DropDownWidth = 121;
            this.cmbEspecialidad.Enabled = false;
            this.cmbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.IntegralHeight = false;
            this.cmbEspecialidad.ItemHeight = 29;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Odontólogo General",
            "Anestesiología Dental",
            "Endodoncista",
            "Periodoncista",
            "Ortodoncista",
            "Cirujano Oral y Maxilofacial",
            "Implantólogo Dental"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(101, 88);
            this.cmbEspecialidad.MaxDropDownItems = 4;
            this.cmbEspecialidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(300, 35);
            this.cmbEspecialidad.StartIndex = 0;
            this.cmbEspecialidad.TabIndex = 134;
            this.cmbEspecialidad.UseTallSize = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel10.Location = new System.Drawing.Point(7, 92);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(87, 17);
            this.materialLabel10.TabIndex = 133;
            this.materialLabel10.Text = "Especialidad:";
            // 
            // txtTotal
            // 
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.HideSelection = true;
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(451, 440);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffixText = null;
            this.txtTotal.ReadOnly = false;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(117, 36);
            this.txtTotal.TabIndex = 132;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            this.txtTotal.UseTallSize = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel9.Location = new System.Drawing.Point(390, 451);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(39, 17);
            this.materialLabel9.TabIndex = 131;
            this.materialLabel9.Text = "Total:";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTratamiento,
            this.Tratamiento,
            this.Importe});
            this.dgvDetalle.Location = new System.Drawing.Point(6, 264);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(562, 169);
            this.dgvDetalle.TabIndex = 130;
            // 
            // IdTratamiento
            // 
            this.IdTratamiento.HeaderText = "IdTratamiento";
            this.IdTratamiento.Name = "IdTratamiento";
            this.IdTratamiento.ReadOnly = true;
            this.IdTratamiento.Visible = false;
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(254, 236);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(69, 24);
            this.materialLabel7.TabIndex = 129;
            this.materialLabel7.Text = "Detalle:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(254, 22);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 24);
            this.materialLabel6.TabIndex = 128;
            this.materialLabel6.Text = "Citas:";
            // 
            // gbDatosCita
            // 
            this.gbDatosCita.Controls.Add(this.cmbEspecialidad);
            this.gbDatosCita.Controls.Add(this.materialLabel10);
            this.gbDatosCita.Controls.Add(this.pbCerrado);
            this.gbDatosCita.Controls.Add(this.dptFecha);
            this.gbDatosCita.Controls.Add(this.materialLabel8);
            this.gbDatosCita.Controls.Add(this.txtAlergias);
            this.gbDatosCita.Controls.Add(this.pbAlergia);
            this.gbDatosCita.Controls.Add(this.cmbDentista);
            this.gbDatosCita.Controls.Add(this.cmbPaciente);
            this.gbDatosCita.Controls.Add(this.materialLabel2);
            this.gbDatosCita.Controls.Add(this.materialLabel3);
            this.gbDatosCita.Controls.Add(this.materialLabel4);
            this.gbDatosCita.Controls.Add(this.cmbEstado);
            this.gbDatosCita.Controls.Add(this.txtIdDentista);
            this.gbDatosCita.Controls.Add(this.txtIdPaciente);
            this.gbDatosCita.Controls.Add(this.dtpHora);
            this.gbDatosCita.Controls.Add(this.txtIdCita);
            this.gbDatosCita.Controls.Add(this.materialLabel1);
            this.gbDatosCita.Location = new System.Drawing.Point(17, 87);
            this.gbDatosCita.Name = "gbDatosCita";
            this.gbDatosCita.Size = new System.Drawing.Size(572, 354);
            this.gbDatosCita.TabIndex = 128;
            this.gbDatosCita.TabStop = false;
            this.gbDatosCita.Text = "Datos de la cita";
            // 
            // dptFecha
            // 
            this.dptFecha.Enabled = false;
            this.dptFecha.Location = new System.Drawing.Point(186, 38);
            this.dptFecha.Name = "dptFecha";
            this.dptFecha.Size = new System.Drawing.Size(200, 26);
            this.dptFecha.TabIndex = 126;
            this.dptFecha.ValueChanged += new System.EventHandler(this.dptFecha_ValueChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel8.Location = new System.Drawing.Point(433, 41);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(36, 17);
            this.materialLabel8.TabIndex = 125;
            this.materialLabel8.Text = "Hora:";
            // 
            // txtAlergias
            // 
            this.txtAlergias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAlergias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlergias.Depth = 0;
            this.txtAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlergias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAlergias.Location = new System.Drawing.Point(296, 262);
            this.txtAlergias.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.ReadOnly = true;
            this.txtAlergias.Size = new System.Drawing.Size(251, 76);
            this.txtAlergias.TabIndex = 124;
            this.txtAlergias.Text = "";
            this.txtAlergias.Visible = false;
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm tt";
            this.dtpHora.Enabled = false;
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(475, 38);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(91, 26);
            this.dtpHora.TabIndex = 108;
            this.dtpHora.Value = new System.DateTime(2023, 11, 3, 17, 32, 3, 0);
            // 
            // gbTratamiento
            // 
            this.gbTratamiento.Controls.Add(this.txtImporte);
            this.gbTratamiento.Controls.Add(this.lblTratamiento);
            this.gbTratamiento.Controls.Add(this.cmbTratamiento);
            this.gbTratamiento.Controls.Add(this.btnAgregar);
            this.gbTratamiento.Controls.Add(this.materialLabel5);
            this.gbTratamiento.Location = new System.Drawing.Point(17, 447);
            this.gbTratamiento.Name = "gbTratamiento";
            this.gbTratamiento.Size = new System.Drawing.Size(572, 157);
            this.gbTratamiento.TabIndex = 129;
            this.gbTratamiento.TabStop = false;
            this.gbTratamiento.Text = "Tratamientos";
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Aviso";
            // 
            // cmbHora
            // 
            this.cmbHora.AutoResize = false;
            this.cmbHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbHora.Depth = 0;
            this.cmbHora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbHora.DropDownHeight = 118;
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.DropDownWidth = 121;
            this.cmbHora.Enabled = false;
            this.cmbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.IntegralHeight = false;
            this.cmbHora.ItemHeight = 29;
            this.cmbHora.Location = new System.Drawing.Point(492, 120);
            this.cmbHora.MaxDropDownItems = 4;
            this.cmbHora.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(91, 35);
            this.cmbHora.StartIndex = 0;
            this.cmbHora.TabIndex = 127;
            this.cmbHora.UseTallSize = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.AutoSize = false;
            this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrabar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGrabar.Depth = 0;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.HighEmphasis = true;
            this.btnGrabar.Icon = null;
            this.btnGrabar.Location = new System.Drawing.Point(555, 637);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(88, 40);
            this.btnGrabar.TabIndex = 130;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGrabar.UseAccentColor = false;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // pbCerrado
            // 
            this.pbCerrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCerrado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCerrado.Enabled = false;
            this.pbCerrado.Image = global::ConsultorioDental.Properties.Resources.cerrado;
            this.pbCerrado.Location = new System.Drawing.Point(474, 18);
            this.pbCerrado.Margin = new System.Windows.Forms.Padding(4);
            this.pbCerrado.Name = "pbCerrado";
            this.pbCerrado.Size = new System.Drawing.Size(73, 67);
            this.pbCerrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrado.TabIndex = 127;
            this.pbCerrado.TabStop = false;
            this.pbCerrado.Visible = false;
            // 
            // pbAlergia
            // 
            this.pbAlergia.Enabled = false;
            this.pbAlergia.Image = global::ConsultorioDental.Properties.Resources.sin_medicina;
            this.pbAlergia.Location = new System.Drawing.Point(219, 255);
            this.pbAlergia.Name = "pbAlergia";
            this.pbAlergia.Size = new System.Drawing.Size(71, 81);
            this.pbAlergia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlergia.TabIndex = 123;
            this.pbAlergia.TabStop = false;
            this.pbAlergia.Visible = false;
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1194, 714);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.gbTratamiento);
            this.Controls.Add(this.gbDatosCita);
            this.Controls.Add(this.gbCitas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.DrawerHighlightWithAccent = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCitas";
            this.Padding = new System.Windows.Forms.Padding(3, 71, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.gbCitas.ResumeLayout(false);
            this.gbCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbDatosCita.ResumeLayout(false);
            this.gbDatosCita.PerformLayout();
            this.gbTratamiento.ResumeLayout(false);
            this.gbTratamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlergia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtIdCita;
        private MaterialSkin.Controls.MaterialComboBox cmbDentista;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdDentista;
        private MaterialSkin.Controls.MaterialComboBox cmbPaciente;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdPaciente;
        private System.Windows.Forms.DataGridView dgvCitas;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmbEstado;
        private MaterialSkin.Controls.MaterialComboBox cmbTratamiento;
        private MaterialSkin.Controls.MaterialLabel lblTratamiento;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtImporte;
        private System.Windows.Forms.GroupBox gbCitas;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.GroupBox gbDatosCita;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.GroupBox gbTratamiento;
        private System.Windows.Forms.PictureBox pbAlergia;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtAlergias;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DateTimePicker dptFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private MaterialSkin.Controls.MaterialComboBox cmbHora;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private System.Windows.Forms.PictureBox pbCerrado;
        private MaterialSkin.Controls.MaterialComboBox cmbEspecialidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
    }
}