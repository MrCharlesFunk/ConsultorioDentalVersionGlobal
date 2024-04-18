namespace ConsultorioDental
{
    partial class frmPacientes
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
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.txtIdPaciente = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbPaciente = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEdad = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSaldo = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtAlergias = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.cbTipoSangre = new MaterialSkin.Controls.MaterialComboBox();
            this.cbTieneRFC = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRFC = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCP = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumeroInterior = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumeroExterior = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtColonia = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.lbRfcConsultado = new MaterialSkin.Controls.MaterialLabel();
            this.txtRfcConsultado = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbMunicipio = new MaterialSkin.Controls.MaterialComboBox();
            this.cbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.cbCFDI = new MaterialSkin.Controls.MaterialComboBox();
            this.cbRegimen = new MaterialSkin.Controls.MaterialComboBox();
            this.cbLocalidad = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Enabled = false;
            this.dtpFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Location = new System.Drawing.Point(277, 178);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNac.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(376, 26);
            this.dtpFechaNac.TabIndex = 95;
            this.dtpFechaNac.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(92, 322);
            this.dgvPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(1005, 258);
            this.dgvPacientes.TabIndex = 93;
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
            this.txtIdPaciente.Location = new System.Drawing.Point(121, 97);
            this.txtIdPaciente.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtIdPaciente.Size = new System.Drawing.Size(136, 36);
            this.txtIdPaciente.TabIndex = 98;
            this.txtIdPaciente.TabStop = false;
            this.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdPaciente.TrailingIcon = null;
            this.txtIdPaciente.UseSystemPasswordChar = false;
            this.txtIdPaciente.UseTallSize = false;
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
            this.cmbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.IntegralHeight = false;
            this.cmbPaciente.ItemHeight = 29;
            this.cmbPaciente.Location = new System.Drawing.Point(364, 98);
            this.cmbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaciente.MaxDropDownItems = 4;
            this.cmbPaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(389, 35);
            this.cmbPaciente.StartIndex = 0;
            this.cmbPaciente.TabIndex = 99;
            this.cmbPaciente.UseTallSize = false;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.AnimateReadOnly = false;
            this.txtEdad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEdad.Depth = 0;
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdad.HideSelection = true;
            this.txtEdad.LeadingIcon = null;
            this.txtEdad.Location = new System.Drawing.Point(720, 172);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.PrefixSuffixText = null;
            this.txtEdad.ReadOnly = false;
            this.txtEdad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEdad.SelectedText = "";
            this.txtEdad.SelectionLength = 0;
            this.txtEdad.SelectionStart = 0;
            this.txtEdad.ShortcutsEnabled = true;
            this.txtEdad.Size = new System.Drawing.Size(155, 36);
            this.txtEdad.TabIndex = 100;
            this.txtEdad.TabStop = false;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEdad.TrailingIcon = null;
            this.txtEdad.UseSystemPasswordChar = false;
            this.txtEdad.UseTallSize = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.HideSelection = true;
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(183, 245);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PrefixSuffixText = null;
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(180, 36);
            this.txtTelefono.TabIndex = 102;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.UseTallSize = false;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.AnimateReadOnly = false;
            this.txtSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSaldo.Depth = 0;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSaldo.HideSelection = true;
            this.txtSaldo.LeadingIcon = null;
            this.txtSaldo.Location = new System.Drawing.Point(965, 172);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.MaxLength = 32767;
            this.txtSaldo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.PasswordChar = '\0';
            this.txtSaldo.PrefixSuffixText = null;
            this.txtSaldo.ReadOnly = false;
            this.txtSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSaldo.SelectedText = "";
            this.txtSaldo.SelectionLength = 0;
            this.txtSaldo.SelectionStart = 0;
            this.txtSaldo.ShortcutsEnabled = true;
            this.txtSaldo.Size = new System.Drawing.Size(132, 36);
            this.txtSaldo.TabIndex = 104;
            this.txtSaldo.TabStop = false;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSaldo.TrailingIcon = null;
            this.txtSaldo.UseSystemPasswordChar = false;
            this.txtSaldo.UseTallSize = false;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(727, 609);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(104, 44);
            this.btnSalir.TabIndex = 108;
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
            this.btnNuevo.Location = new System.Drawing.Point(345, 609);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(104, 44);
            this.btnNuevo.TabIndex = 105;
            this.btnNuevo.Text = "    Nuevo     ";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(273, 110);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 17);
            this.materialLabel2.TabIndex = 110;
            this.materialLabel2.Text = "Paciente:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(83, 185);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(140, 17);
            this.materialLabel1.TabIndex = 111;
            this.materialLabel1.Text = "Fecha de Nacimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(364, 97);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(391, 36);
            this.txtNombre.TabIndex = 112;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.UseTallSize = false;
            this.txtNombre.Visible = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel3.Location = new System.Drawing.Point(91, 256);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 17);
            this.materialLabel3.TabIndex = 113;
            this.materialLabel3.Text = "Teléfono:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.Location = new System.Drawing.Point(888, 183);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 17);
            this.materialLabel4.TabIndex = 114;
            this.materialLabel4.Text = "Saldo:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel5.Location = new System.Drawing.Point(800, 108);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(100, 17);
            this.materialLabel5.TabIndex = 115;
            this.materialLabel5.Text = "Tipo de sangre:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel6.Location = new System.Drawing.Point(663, 185);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(37, 17);
            this.materialLabel6.TabIndex = 116;
            this.materialLabel6.Text = "Edad:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel7.Location = new System.Drawing.Point(83, 110);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(23, 17);
            this.materialLabel7.TabIndex = 117;
            this.materialLabel7.Text = "No:";
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Aviso";
            // 
            // txtAlergias
            // 
            this.txtAlergias.AnimateReadOnly = false;
            this.txtAlergias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAlergias.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAlergias.Depth = 0;
            this.txtAlergias.Enabled = false;
            this.txtAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlergias.HideSelection = true;
            this.txtAlergias.LeadingIcon = null;
            this.txtAlergias.Location = new System.Drawing.Point(457, 245);
            this.txtAlergias.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlergias.MaxLength = 255;
            this.txtAlergias.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.PasswordChar = '\0';
            this.txtAlergias.PrefixSuffixText = null;
            this.txtAlergias.ReadOnly = false;
            this.txtAlergias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlergias.SelectedText = "";
            this.txtAlergias.SelectionLength = 0;
            this.txtAlergias.SelectionStart = 0;
            this.txtAlergias.ShortcutsEnabled = true;
            this.txtAlergias.Size = new System.Drawing.Size(296, 36);
            this.txtAlergias.TabIndex = 118;
            this.txtAlergias.TabStop = false;
            this.txtAlergias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAlergias.TrailingIcon = null;
            this.txtAlergias.UseSystemPasswordChar = false;
            this.txtAlergias.UseTallSize = false;
            this.txtAlergias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlergias_KeyPress);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel8.Location = new System.Drawing.Point(391, 256);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(58, 17);
            this.materialLabel8.TabIndex = 119;
            this.materialLabel8.Text = "Alergias:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::ConsultorioDental.Properties.Resources.alerta__1_;
            this.pictureBox1.Location = new System.Drawing.Point(761, 216);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
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
            this.btnGrabar.Location = new System.Drawing.Point(549, 609);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(104, 44);
            this.btnGrabar.TabIndex = 121;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGrabar.UseAccentColor = false;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cbTipoSangre
            // 
            this.cbTipoSangre.AutoResize = false;
            this.cbTipoSangre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoSangre.Depth = 0;
            this.cbTipoSangre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoSangre.DropDownHeight = 118;
            this.cbTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoSangre.DropDownWidth = 121;
            this.cbTipoSangre.Enabled = false;
            this.cbTipoSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoSangre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoSangre.FormattingEnabled = true;
            this.cbTipoSangre.IntegralHeight = false;
            this.cbTipoSangre.ItemHeight = 29;
            this.cbTipoSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbTipoSangre.Location = new System.Drawing.Point(907, 97);
            this.cbTipoSangre.MaxDropDownItems = 4;
            this.cbTipoSangre.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoSangre.Name = "cbTipoSangre";
            this.cbTipoSangre.Size = new System.Drawing.Size(108, 35);
            this.cbTipoSangre.StartIndex = 0;
            this.cbTipoSangre.TabIndex = 135;
            this.cbTipoSangre.UseTallSize = false;
            // 
            // cbTieneRFC
            // 
            this.cbTieneRFC.AutoSize = true;
            this.cbTieneRFC.Depth = 0;
            this.cbTieneRFC.Enabled = false;
            this.cbTieneRFC.Location = new System.Drawing.Point(983, 244);
            this.cbTieneRFC.Margin = new System.Windows.Forms.Padding(0);
            this.cbTieneRFC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbTieneRFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbTieneRFC.Name = "cbTieneRFC";
            this.cbTieneRFC.ReadOnly = false;
            this.cbTieneRFC.Ripple = true;
            this.cbTieneRFC.Size = new System.Drawing.Size(114, 37);
            this.cbTieneRFC.TabIndex = 136;
            this.cbTieneRFC.Text = "Añadir RFC";
            this.cbTieneRFC.UseVisualStyleBackColor = true;
            this.cbTieneRFC.CheckedChanged += new System.EventHandler(this.cbTieneRFC_CheckedChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel9.Location = new System.Drawing.Point(91, 350);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(31, 17);
            this.materialLabel9.TabIndex = 137;
            this.materialLabel9.Text = "RFC:";
            // 
            // txtRFC
            // 
            this.txtRFC.AnimateReadOnly = false;
            this.txtRFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRFC.Depth = 0;
            this.txtRFC.Enabled = false;
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRFC.HideSelection = true;
            this.txtRFC.LeadingIcon = null;
            this.txtRFC.Location = new System.Drawing.Point(173, 340);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.PasswordChar = '\0';
            this.txtRFC.PrefixSuffixText = null;
            this.txtRFC.ReadOnly = false;
            this.txtRFC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRFC.SelectedText = "";
            this.txtRFC.SelectionLength = 0;
            this.txtRFC.SelectionStart = 0;
            this.txtRFC.ShortcutsEnabled = true;
            this.txtRFC.Size = new System.Drawing.Size(180, 36);
            this.txtRFC.TabIndex = 138;
            this.txtRFC.TabStop = false;
            this.txtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRFC.TrailingIcon = null;
            this.txtRFC.UseSystemPasswordChar = false;
            this.txtRFC.UseTallSize = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AnimateReadOnly = false;
            this.txtRazonSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRazonSocial.Depth = 0;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRazonSocial.HideSelection = true;
            this.txtRazonSocial.LeadingIcon = null;
            this.txtRazonSocial.Location = new System.Drawing.Point(485, 340);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.MaxLength = 255;
            this.txtRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.PrefixSuffixText = null;
            this.txtRazonSocial.ReadOnly = false;
            this.txtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.ShortcutsEnabled = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(202, 36);
            this.txtRazonSocial.TabIndex = 140;
            this.txtRazonSocial.TabStop = false;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazonSocial.TrailingIcon = null;
            this.txtRazonSocial.UseSystemPasswordChar = false;
            this.txtRazonSocial.UseTallSize = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel10.Location = new System.Drawing.Point(391, 350);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(86, 17);
            this.materialLabel10.TabIndex = 139;
            this.materialLabel10.Text = "Razón social:";
            // 
            // txtCP
            // 
            this.txtCP.AnimateReadOnly = false;
            this.txtCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCP.Depth = 0;
            this.txtCP.Enabled = false;
            this.txtCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCP.HideSelection = true;
            this.txtCP.LeadingIcon = null;
            this.txtCP.Location = new System.Drawing.Point(636, 437);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCP.MaxLength = 5;
            this.txtCP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCP.Name = "txtCP";
            this.txtCP.PasswordChar = '\0';
            this.txtCP.PrefixSuffixText = null;
            this.txtCP.ReadOnly = false;
            this.txtCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCP.SelectedText = "";
            this.txtCP.SelectionLength = 0;
            this.txtCP.SelectionStart = 0;
            this.txtCP.ShortcutsEnabled = true;
            this.txtCP.Size = new System.Drawing.Size(99, 36);
            this.txtCP.TabIndex = 142;
            this.txtCP.TabStop = false;
            this.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCP.TrailingIcon = null;
            this.txtCP.UseSystemPasswordChar = false;
            this.txtCP.UseTallSize = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel11.Location = new System.Drawing.Point(599, 447);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(23, 17);
            this.materialLabel11.TabIndex = 141;
            this.materialLabel11.Text = "CP:";
            // 
            // txtCalle
            // 
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCalle.Depth = 0;
            this.txtCalle.Enabled = false;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalle.HideSelection = true;
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(173, 537);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.MaxLength = 40;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.PrefixSuffixText = null;
            this.txtCalle.ReadOnly = false;
            this.txtCalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.ShortcutsEnabled = true;
            this.txtCalle.Size = new System.Drawing.Size(401, 36);
            this.txtCalle.TabIndex = 144;
            this.txtCalle.TabStop = false;
            this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalle.TrailingIcon = null;
            this.txtCalle.UseSystemPasswordChar = false;
            this.txtCalle.UseTallSize = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel12.Location = new System.Drawing.Point(93, 547);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(38, 17);
            this.materialLabel12.TabIndex = 143;
            this.materialLabel12.Text = "Calle:";
            // 
            // txtNumeroInterior
            // 
            this.txtNumeroInterior.AnimateReadOnly = false;
            this.txtNumeroInterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNumeroInterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumeroInterior.Depth = 0;
            this.txtNumeroInterior.Enabled = false;
            this.txtNumeroInterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroInterior.HideSelection = true;
            this.txtNumeroInterior.LeadingIcon = null;
            this.txtNumeroInterior.Location = new System.Drawing.Point(684, 537);
            this.txtNumeroInterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroInterior.MaxLength = 5;
            this.txtNumeroInterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroInterior.Name = "txtNumeroInterior";
            this.txtNumeroInterior.PasswordChar = '\0';
            this.txtNumeroInterior.PrefixSuffixText = null;
            this.txtNumeroInterior.ReadOnly = false;
            this.txtNumeroInterior.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumeroInterior.SelectedText = "";
            this.txtNumeroInterior.SelectionLength = 0;
            this.txtNumeroInterior.SelectionStart = 0;
            this.txtNumeroInterior.ShortcutsEnabled = true;
            this.txtNumeroInterior.Size = new System.Drawing.Size(114, 36);
            this.txtNumeroInterior.TabIndex = 146;
            this.txtNumeroInterior.TabStop = false;
            this.txtNumeroInterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumeroInterior.TrailingIcon = null;
            this.txtNumeroInterior.UseSystemPasswordChar = false;
            this.txtNumeroInterior.UseTallSize = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel13.Location = new System.Drawing.Point(599, 547);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(77, 17);
            this.materialLabel13.TabIndex = 145;
            this.materialLabel13.Text = "No. Interior:";
            // 
            // txtNumeroExterior
            // 
            this.txtNumeroExterior.AnimateReadOnly = false;
            this.txtNumeroExterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNumeroExterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumeroExterior.Depth = 0;
            this.txtNumeroExterior.Enabled = false;
            this.txtNumeroExterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroExterior.HideSelection = true;
            this.txtNumeroExterior.LeadingIcon = null;
            this.txtNumeroExterior.Location = new System.Drawing.Point(966, 537);
            this.txtNumeroExterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroExterior.MaxLength = 5;
            this.txtNumeroExterior.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroExterior.Name = "txtNumeroExterior";
            this.txtNumeroExterior.PasswordChar = '\0';
            this.txtNumeroExterior.PrefixSuffixText = null;
            this.txtNumeroExterior.ReadOnly = false;
            this.txtNumeroExterior.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumeroExterior.SelectedText = "";
            this.txtNumeroExterior.SelectionLength = 0;
            this.txtNumeroExterior.SelectionStart = 0;
            this.txtNumeroExterior.ShortcutsEnabled = true;
            this.txtNumeroExterior.Size = new System.Drawing.Size(114, 36);
            this.txtNumeroExterior.TabIndex = 148;
            this.txtNumeroExterior.TabStop = false;
            this.txtNumeroExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumeroExterior.TrailingIcon = null;
            this.txtNumeroExterior.UseSystemPasswordChar = false;
            this.txtNumeroExterior.UseTallSize = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel14.Location = new System.Drawing.Point(868, 547);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(80, 17);
            this.materialLabel14.TabIndex = 147;
            this.materialLabel14.Text = "No. Exterior:";
            // 
            // txtColonia
            // 
            this.txtColonia.AnimateReadOnly = false;
            this.txtColonia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtColonia.Depth = 0;
            this.txtColonia.Enabled = false;
            this.txtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtColonia.HideSelection = true;
            this.txtColonia.LeadingIcon = null;
            this.txtColonia.Location = new System.Drawing.Point(684, 493);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.MaxLength = 30;
            this.txtColonia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.PasswordChar = '\0';
            this.txtColonia.PrefixSuffixText = null;
            this.txtColonia.ReadOnly = false;
            this.txtColonia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtColonia.SelectedText = "";
            this.txtColonia.SelectionLength = 0;
            this.txtColonia.SelectionStart = 0;
            this.txtColonia.ShortcutsEnabled = true;
            this.txtColonia.Size = new System.Drawing.Size(396, 36);
            this.txtColonia.TabIndex = 150;
            this.txtColonia.TabStop = false;
            this.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtColonia.TrailingIcon = null;
            this.txtColonia.UseSystemPasswordChar = false;
            this.txtColonia.UseTallSize = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel15.Location = new System.Drawing.Point(599, 503);
            this.materialLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(54, 17);
            this.materialLabel15.TabIndex = 149;
            this.materialLabel15.Text = "Colonia:";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel16.Location = new System.Drawing.Point(597, 394);
            this.materialLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(68, 17);
            this.materialLabel16.TabIndex = 151;
            this.materialLabel16.Text = "Municipio:";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel17.Location = new System.Drawing.Point(705, 349);
            this.materialLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(49, 17);
            this.materialLabel17.TabIndex = 153;
            this.materialLabel17.Text = "Estado:";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel18.Location = new System.Drawing.Point(91, 394);
            this.materialLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(35, 17);
            this.materialLabel18.TabIndex = 155;
            this.materialLabel18.Text = "CFDI:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(173, 493);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 70;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PrefixSuffixText = null;
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(401, 36);
            this.txtCorreo.TabIndex = 158;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.UseTallSize = false;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel19.Location = new System.Drawing.Point(91, 503);
            this.materialLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(48, 17);
            this.materialLabel19.TabIndex = 157;
            this.materialLabel19.Text = "Correo:";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel20.Location = new System.Drawing.Point(91, 447);
            this.materialLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(62, 17);
            this.materialLabel20.TabIndex = 159;
            this.materialLabel20.Text = "Regimen:";
            // 
            // lbRfcConsultado
            // 
            this.lbRfcConsultado.AutoSize = true;
            this.lbRfcConsultado.Depth = 0;
            this.lbRfcConsultado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbRfcConsultado.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lbRfcConsultado.Location = new System.Drawing.Point(888, 255);
            this.lbRfcConsultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRfcConsultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbRfcConsultado.Name = "lbRfcConsultado";
            this.lbRfcConsultado.Size = new System.Drawing.Size(31, 17);
            this.lbRfcConsultado.TabIndex = 162;
            this.lbRfcConsultado.Text = "RFC:";
            this.lbRfcConsultado.Visible = false;
            // 
            // txtRfcConsultado
            // 
            this.txtRfcConsultado.AnimateReadOnly = false;
            this.txtRfcConsultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRfcConsultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRfcConsultado.Depth = 0;
            this.txtRfcConsultado.Enabled = false;
            this.txtRfcConsultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRfcConsultado.HideSelection = true;
            this.txtRfcConsultado.LeadingIcon = null;
            this.txtRfcConsultado.Location = new System.Drawing.Point(920, 245);
            this.txtRfcConsultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtRfcConsultado.MaxLength = 255;
            this.txtRfcConsultado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRfcConsultado.Name = "txtRfcConsultado";
            this.txtRfcConsultado.PasswordChar = '\0';
            this.txtRfcConsultado.PrefixSuffixText = null;
            this.txtRfcConsultado.ReadOnly = false;
            this.txtRfcConsultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRfcConsultado.SelectedText = "";
            this.txtRfcConsultado.SelectionLength = 0;
            this.txtRfcConsultado.SelectionStart = 0;
            this.txtRfcConsultado.ShortcutsEnabled = true;
            this.txtRfcConsultado.Size = new System.Drawing.Size(177, 36);
            this.txtRfcConsultado.TabIndex = 161;
            this.txtRfcConsultado.TabStop = false;
            this.txtRfcConsultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRfcConsultado.TrailingIcon = null;
            this.txtRfcConsultado.UseSystemPasswordChar = false;
            this.txtRfcConsultado.UseTallSize = false;
            this.txtRfcConsultado.Visible = false;
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.AutoResize = false;
            this.cbMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMunicipio.Depth = 0;
            this.cbMunicipio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMunicipio.DropDownHeight = 118;
            this.cbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMunicipio.DropDownWidth = 121;
            this.cbMunicipio.Enabled = false;
            this.cbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.IntegralHeight = false;
            this.cbMunicipio.ItemHeight = 29;
            this.cbMunicipio.Location = new System.Drawing.Point(684, 383);
            this.cbMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.cbMunicipio.MaxDropDownItems = 4;
            this.cbMunicipio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(396, 35);
            this.cbMunicipio.StartIndex = 0;
            this.cbMunicipio.TabIndex = 163;
            this.cbMunicipio.UseTallSize = false;
            this.cbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbMunicipio_SelectedIndexChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.AutoResize = false;
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEstado.Depth = 0;
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEstado.DropDownHeight = 118;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.DropDownWidth = 121;
            this.cbEstado.Enabled = false;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.IntegralHeight = false;
            this.cbEstado.ItemHeight = 29;
            this.cbEstado.Items.AddRange(new object[] {
            "Jalisco"});
            this.cbEstado.Location = new System.Drawing.Point(762, 340);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.MaxDropDownItems = 4;
            this.cbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(318, 35);
            this.cbEstado.StartIndex = 0;
            this.cbEstado.TabIndex = 164;
            this.cbEstado.UseTallSize = false;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbCFDI
            // 
            this.cbCFDI.AutoResize = false;
            this.cbCFDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCFDI.Depth = 0;
            this.cbCFDI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCFDI.DropDownHeight = 118;
            this.cbCFDI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCFDI.DropDownWidth = 121;
            this.cbCFDI.Enabled = false;
            this.cbCFDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCFDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCFDI.FormattingEnabled = true;
            this.cbCFDI.IntegralHeight = false;
            this.cbCFDI.ItemHeight = 29;
            this.cbCFDI.Items.AddRange(new object[] {
            "G05: Servicios"});
            this.cbCFDI.Location = new System.Drawing.Point(173, 384);
            this.cbCFDI.Margin = new System.Windows.Forms.Padding(4);
            this.cbCFDI.MaxDropDownItems = 4;
            this.cbCFDI.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCFDI.Name = "cbCFDI";
            this.cbCFDI.Size = new System.Drawing.Size(389, 35);
            this.cbCFDI.StartIndex = 0;
            this.cbCFDI.TabIndex = 165;
            this.cbCFDI.UseTallSize = false;
            // 
            // cbRegimen
            // 
            this.cbRegimen.AutoResize = false;
            this.cbRegimen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbRegimen.Depth = 0;
            this.cbRegimen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbRegimen.DropDownHeight = 118;
            this.cbRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegimen.DropDownWidth = 121;
            this.cbRegimen.Enabled = false;
            this.cbRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbRegimen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbRegimen.FormattingEnabled = true;
            this.cbRegimen.IntegralHeight = false;
            this.cbRegimen.ItemHeight = 29;
            this.cbRegimen.Items.AddRange(new object[] {
            "Régimen Simplificado de Confianza",
            "Régimen de Actividades Empresariales y Profesionales",
            "Régimen de Incorporación Fiscal"});
            this.cbRegimen.Location = new System.Drawing.Point(173, 438);
            this.cbRegimen.Margin = new System.Windows.Forms.Padding(4);
            this.cbRegimen.MaxDropDownItems = 4;
            this.cbRegimen.MouseState = MaterialSkin.MouseState.OUT;
            this.cbRegimen.Name = "cbRegimen";
            this.cbRegimen.Size = new System.Drawing.Size(389, 35);
            this.cbRegimen.StartIndex = 0;
            this.cbRegimen.TabIndex = 166;
            this.cbRegimen.UseTallSize = false;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.AutoResize = false;
            this.cbLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLocalidad.Depth = 0;
            this.cbLocalidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLocalidad.DropDownHeight = 118;
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.DropDownWidth = 121;
            this.cbLocalidad.Enabled = false;
            this.cbLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.IntegralHeight = false;
            this.cbLocalidad.ItemHeight = 29;
            this.cbLocalidad.Location = new System.Drawing.Point(835, 437);
            this.cbLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocalidad.MaxDropDownItems = 4;
            this.cbLocalidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(245, 35);
            this.cbLocalidad.StartIndex = 0;
            this.cbLocalidad.TabIndex = 168;
            this.cbLocalidad.UseTallSize = false;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel21.Location = new System.Drawing.Point(759, 447);
            this.materialLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(68, 17);
            this.materialLabel21.TabIndex = 167;
            this.materialLabel21.Text = "Localidad:";
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1176, 702);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.materialLabel21);
            this.Controls.Add(this.cbRegimen);
            this.Controls.Add(this.cbCFDI);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbMunicipio);
            this.Controls.Add(this.lbRfcConsultado);
            this.Controls.Add(this.txtRfcConsultado);
            this.Controls.Add(this.materialLabel20);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.materialLabel19);
            this.Controls.Add(this.materialLabel18);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.txtNumeroExterior);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.txtNumeroInterior);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.cbTieneRFC);
            this.Controls.Add(this.cbTipoSangre);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtAlergias);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbPaciente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPacientes";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdPaciente;
        private MaterialSkin.Controls.MaterialComboBox cmbPaciente;
        private MaterialSkin.Controls.MaterialTextBox2 txtEdad;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtSaldo;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ToolTip toolTip;
        private MaterialSkin.Controls.MaterialTextBox2 txtAlergias;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private MaterialSkin.Controls.MaterialComboBox cbTipoSangre;
        private MaterialSkin.Controls.MaterialCheckbox cbTieneRFC;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtRFC;
        private MaterialSkin.Controls.MaterialTextBox2 txtRazonSocial;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox2 txtCP;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox2 txtCalle;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox2 txtNumeroInterior;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox2 txtNumeroExterior;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTextBox2 txtColonia;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel lbRfcConsultado;
        private MaterialSkin.Controls.MaterialTextBox2 txtRfcConsultado;
        private MaterialSkin.Controls.MaterialComboBox cbMunicipio;
        private MaterialSkin.Controls.MaterialComboBox cbEstado;
        private MaterialSkin.Controls.MaterialComboBox cbCFDI;
        private MaterialSkin.Controls.MaterialComboBox cbRegimen;
        private MaterialSkin.Controls.MaterialComboBox cbLocalidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
    }
}