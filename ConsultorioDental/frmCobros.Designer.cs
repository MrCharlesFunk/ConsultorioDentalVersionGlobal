namespace ConsultorioDental
{
    partial class frmCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobros));
            this.txtIdCobro = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPaciente = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdPaciente = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbIdCita = new MaterialSkin.Controls.MaterialComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalCita = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSaldoPaciente = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCobro
            // 
            this.txtIdCobro.AnimateReadOnly = false;
            this.txtIdCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdCobro.Depth = 0;
            this.txtIdCobro.Enabled = false;
            this.txtIdCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdCobro.HideSelection = true;
            this.txtIdCobro.LeadingIcon = null;
            this.txtIdCobro.Location = new System.Drawing.Point(165, 122);
            this.txtIdCobro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCobro.MaxLength = 32767;
            this.txtIdCobro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdCobro.Name = "txtIdCobro";
            this.txtIdCobro.PasswordChar = '\0';
            this.txtIdCobro.PrefixSuffixText = null;
            this.txtIdCobro.ReadOnly = false;
            this.txtIdCobro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdCobro.SelectedText = "";
            this.txtIdCobro.SelectionLength = 0;
            this.txtIdCobro.SelectionStart = 0;
            this.txtIdCobro.ShortcutsEnabled = true;
            this.txtIdCobro.Size = new System.Drawing.Size(165, 36);
            this.txtIdCobro.TabIndex = 103;
            this.txtIdCobro.TabStop = false;
            this.txtIdCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdCobro.TrailingIcon = null;
            this.txtIdCobro.UseSystemPasswordChar = false;
            this.txtIdCobro.UseTallSize = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(489, 133);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(345, 24);
            this.dtpFecha.TabIndex = 110;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 3, 17, 32, 3, 0);
            // 
            // txtMonto
            // 
            this.txtMonto.AnimateReadOnly = false;
            this.txtMonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMonto.Depth = 0;
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMonto.HideSelection = true;
            this.txtMonto.LeadingIcon = null;
            this.txtMonto.Location = new System.Drawing.Point(546, 353);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.MaxLength = 32767;
            this.txtMonto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.PrefixSuffixText = null;
            this.txtMonto.ReadOnly = false;
            this.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.ShortcutsEnabled = true;
            this.txtMonto.Size = new System.Drawing.Size(138, 36);
            this.txtMonto.TabIndex = 112;
            this.txtMonto.TabStop = false;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonto.TrailingIcon = null;
            this.txtMonto.UseSystemPasswordChar = false;
            this.txtMonto.UseTallSize = false;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // dgvCobros
            // 
            this.dgvCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobros.Location = new System.Drawing.Point(64, 415);
            this.dgvCobros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCobros.Name = "dgvCobros";
            this.dgvCobros.Size = new System.Drawing.Size(771, 208);
            this.dgvCobros.TabIndex = 113;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(489, 647);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(117, 50);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrabar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGrabar.Depth = 0;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.HighEmphasis = true;
            this.btnGrabar.Icon = null;
            this.btnGrabar.Location = new System.Drawing.Point(694, 353);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(141, 36);
            this.btnGrabar.TabIndex = 115;
            this.btnGrabar.Text = "Realizar Cobro";
            this.btnGrabar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGrabar.UseAccentColor = false;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.HighEmphasis = true;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(285, 647);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(117, 50);
            this.btnNuevo.TabIndex = 114;
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
            this.materialLabel2.Location = new System.Drawing.Point(415, 136);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 17);
            this.materialLabel2.TabIndex = 118;
            this.materialLabel2.Text = "Fecha:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(53, 277);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 17);
            this.materialLabel1.TabIndex = 119;
            this.materialLabel1.Text = "No. Cita:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel3.Location = new System.Drawing.Point(54, 136);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 17);
            this.materialLabel3.TabIndex = 120;
            this.materialLabel3.Text = "No. Cobro:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.Location = new System.Drawing.Point(282, 273);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 17);
            this.materialLabel4.TabIndex = 122;
            this.materialLabel4.Text = "Fecha de la cita:";
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
            this.cmbPaciente.Location = new System.Drawing.Point(165, 198);
            this.cmbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaciente.MaxDropDownItems = 4;
            this.cmbPaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(399, 35);
            this.cmbPaciente.StartIndex = 0;
            this.cmbPaciente.TabIndex = 123;
            this.cmbPaciente.UseTallSize = false;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel7.Location = new System.Drawing.Point(577, 211);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(23, 17);
            this.materialLabel7.TabIndex = 125;
            this.materialLabel7.Text = "No:";
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
            this.txtIdPaciente.Location = new System.Drawing.Point(620, 197);
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
            this.txtIdPaciente.Size = new System.Drawing.Size(159, 36);
            this.txtIdPaciente.TabIndex = 124;
            this.txtIdPaciente.TabStop = false;
            this.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdPaciente.TrailingIcon = null;
            this.txtIdPaciente.UseSystemPasswordChar = false;
            this.txtIdPaciente.UseTallSize = false;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Enabled = false;
            this.dtpFechaCita.Location = new System.Drawing.Point(395, 270);
            this.dtpFechaCita.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(345, 24);
            this.dtpFechaCita.TabIndex = 126;
            this.dtpFechaCita.Value = new System.DateTime(2023, 11, 3, 17, 32, 3, 0);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel5.Location = new System.Drawing.Point(483, 364);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 17);
            this.materialLabel5.TabIndex = 127;
            this.materialLabel5.Text = "Importe:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel6.Location = new System.Drawing.Point(54, 211);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(62, 17);
            this.materialLabel6.TabIndex = 128;
            this.materialLabel6.Text = "Paciente:";
            // 
            // cmbIdCita
            // 
            this.cmbIdCita.AutoResize = false;
            this.cmbIdCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbIdCita.Depth = 0;
            this.cmbIdCita.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbIdCita.DropDownHeight = 118;
            this.cmbIdCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdCita.DropDownWidth = 121;
            this.cmbIdCita.Enabled = false;
            this.cmbIdCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbIdCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbIdCita.FormattingEnabled = true;
            this.cmbIdCita.IntegralHeight = false;
            this.cmbIdCita.ItemHeight = 29;
            this.cmbIdCita.Location = new System.Drawing.Point(133, 263);
            this.cmbIdCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdCita.MaxDropDownItems = 4;
            this.cmbIdCita.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbIdCita.Name = "cmbIdCita";
            this.cmbIdCita.Size = new System.Drawing.Size(126, 35);
            this.cmbIdCita.StartIndex = 0;
            this.cmbIdCita.TabIndex = 129;
            this.cmbIdCita.UseTallSize = false;
            this.cmbIdCita.SelectedIndexChanged += new System.EventHandler(this.cmbIdCita_SelectedIndexChanged);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Aviso";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel8.Location = new System.Drawing.Point(280, 364);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(66, 17);
            this.materialLabel8.TabIndex = 131;
            this.materialLabel8.Text = "Total cita:";
            // 
            // txtTotalCita
            // 
            this.txtTotalCita.AnimateReadOnly = false;
            this.txtTotalCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalCita.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalCita.Depth = 0;
            this.txtTotalCita.Enabled = false;
            this.txtTotalCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalCita.HideSelection = true;
            this.txtTotalCita.LeadingIcon = null;
            this.txtTotalCita.Location = new System.Drawing.Point(354, 353);
            this.txtTotalCita.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCita.MaxLength = 32767;
            this.txtTotalCita.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalCita.Name = "txtTotalCita";
            this.txtTotalCita.PasswordChar = '\0';
            this.txtTotalCita.PrefixSuffixText = null;
            this.txtTotalCita.ReadOnly = false;
            this.txtTotalCita.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalCita.SelectedText = "";
            this.txtTotalCita.SelectionLength = 0;
            this.txtTotalCita.SelectionStart = 0;
            this.txtTotalCita.ShortcutsEnabled = true;
            this.txtTotalCita.Size = new System.Drawing.Size(121, 36);
            this.txtTotalCita.TabIndex = 130;
            this.txtTotalCita.TabStop = false;
            this.txtTotalCita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalCita.TrailingIcon = null;
            this.txtTotalCita.UseSystemPasswordChar = false;
            this.txtTotalCita.UseTallSize = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel9.Location = new System.Drawing.Point(53, 364);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(100, 17);
            this.materialLabel9.TabIndex = 132;
            this.materialLabel9.Text = "Saldo paciente:";
            // 
            // txtSaldoPaciente
            // 
            this.txtSaldoPaciente.AnimateReadOnly = false;
            this.txtSaldoPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSaldoPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSaldoPaciente.Depth = 0;
            this.txtSaldoPaciente.Enabled = false;
            this.txtSaldoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSaldoPaciente.HideSelection = true;
            this.txtSaldoPaciente.LeadingIcon = null;
            this.txtSaldoPaciente.Location = new System.Drawing.Point(161, 353);
            this.txtSaldoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoPaciente.MaxLength = 32767;
            this.txtSaldoPaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSaldoPaciente.Name = "txtSaldoPaciente";
            this.txtSaldoPaciente.PasswordChar = '\0';
            this.txtSaldoPaciente.PrefixSuffixText = null;
            this.txtSaldoPaciente.ReadOnly = false;
            this.txtSaldoPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSaldoPaciente.SelectedText = "";
            this.txtSaldoPaciente.SelectionLength = 0;
            this.txtSaldoPaciente.SelectionStart = 0;
            this.txtSaldoPaciente.ShortcutsEnabled = true;
            this.txtSaldoPaciente.Size = new System.Drawing.Size(111, 36);
            this.txtSaldoPaciente.TabIndex = 133;
            this.txtSaldoPaciente.TabStop = false;
            this.txtSaldoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaldoPaciente.TrailingIcon = null;
            this.txtSaldoPaciente.UseSystemPasswordChar = false;
            this.txtSaldoPaciente.UseTallSize = false;
            // 
            // frmCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 709);
            this.Controls.Add(this.txtSaldoPaciente);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtTotalCita);
            this.Controls.Add(this.cmbIdCita);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvCobros);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtIdCobro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCobros";
            this.Padding = new System.Windows.Forms.Padding(4, 89, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.frmCobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtIdCobro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialTextBox2 txtMonto;
        private System.Windows.Forms.DataGridView dgvCobros;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmbPaciente;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdPaciente;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox cmbIdCita;
        private System.Windows.Forms.ToolTip toolTip;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotalCita;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtSaldoPaciente;
    }
}