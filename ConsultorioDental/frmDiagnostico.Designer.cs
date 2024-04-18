namespace ConsultorioDental
{
    partial class frmDiagnostico
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdDiagnostico = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbPaciente = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdPaciente = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSaldo = new MaterialSkin.Controls.MaterialTextBox2();
            this.dptFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNoCitas = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(40, 111);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 17);
            this.materialLabel2.TabIndex = 112;
            this.materialLabel2.Text = "Id Diagnóstico:";
            // 
            // txtIdDiagnostico
            // 
            this.txtIdDiagnostico.AnimateReadOnly = false;
            this.txtIdDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdDiagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdDiagnostico.Depth = 0;
            this.txtIdDiagnostico.Enabled = false;
            this.txtIdDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdDiagnostico.HideSelection = true;
            this.txtIdDiagnostico.Hint = "ID";
            this.txtIdDiagnostico.LeadingIcon = null;
            this.txtIdDiagnostico.Location = new System.Drawing.Point(144, 101);
            this.txtIdDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdDiagnostico.MaxLength = 32767;
            this.txtIdDiagnostico.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdDiagnostico.Name = "txtIdDiagnostico";
            this.txtIdDiagnostico.PasswordChar = '\0';
            this.txtIdDiagnostico.PrefixSuffixText = null;
            this.txtIdDiagnostico.ReadOnly = false;
            this.txtIdDiagnostico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdDiagnostico.SelectedText = "";
            this.txtIdDiagnostico.SelectionLength = 0;
            this.txtIdDiagnostico.SelectionStart = 0;
            this.txtIdDiagnostico.ShortcutsEnabled = true;
            this.txtIdDiagnostico.Size = new System.Drawing.Size(177, 36);
            this.txtIdDiagnostico.TabIndex = 111;
            this.txtIdDiagnostico.TabStop = false;
            this.txtIdDiagnostico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdDiagnostico.TrailingIcon = null;
            this.txtIdDiagnostico.UseSystemPasswordChar = false;
            this.txtIdDiagnostico.UseTallSize = false;
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
            this.cmbPaciente.Location = new System.Drawing.Point(269, 161);
            this.cmbPaciente.MaxDropDownItems = 4;
            this.cmbPaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(310, 35);
            this.cmbPaciente.StartIndex = 0;
            this.cmbPaciente.TabIndex = 117;
            this.cmbPaciente.UseTallSize = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel3.Location = new System.Drawing.Point(195, 170);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(62, 17);
            this.materialLabel3.TabIndex = 118;
            this.materialLabel3.Text = "Paciente:";
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
            this.txtIdPaciente.Location = new System.Drawing.Point(608, 162);
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
            this.txtIdPaciente.Size = new System.Drawing.Size(63, 36);
            this.txtIdPaciente.TabIndex = 116;
            this.txtIdPaciente.TabStop = false;
            this.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdPaciente.TrailingIcon = null;
            this.txtIdPaciente.UseSystemPasswordChar = false;
            this.txtIdPaciente.UseTallSize = false;
            this.txtIdPaciente.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(121, 237);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 17);
            this.materialLabel1.TabIndex = 119;
            this.materialLabel1.Text = "Saldo del tratamiento:";
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
            this.txtSaldo.Location = new System.Drawing.Point(270, 228);
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
            this.txtSaldo.Size = new System.Drawing.Size(309, 36);
            this.txtSaldo.TabIndex = 120;
            this.txtSaldo.TabStop = false;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSaldo.TrailingIcon = null;
            this.txtSaldo.UseSystemPasswordChar = false;
            this.txtSaldo.UseTallSize = false;
            this.txtSaldo.Visible = false;
            // 
            // dptFecha
            // 
            this.dptFecha.Enabled = false;
            this.dptFecha.Location = new System.Drawing.Point(580, 87);
            this.dptFecha.Name = "dptFecha";
            this.dptFecha.Size = new System.Drawing.Size(200, 20);
            this.dptFecha.TabIndex = 128;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.Location = new System.Drawing.Point(471, 89);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(101, 17);
            this.materialLabel4.TabIndex = 127;
            this.materialLabel4.Text = "Fecha de inicio:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel5.Location = new System.Drawing.Point(154, 306);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(109, 17);
            this.materialLabel5.TabIndex = 129;
            this.materialLabel5.Text = "Número de citas:";
            // 
            // txtNoCitas
            // 
            this.txtNoCitas.AnimateReadOnly = false;
            this.txtNoCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNoCitas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNoCitas.Depth = 0;
            this.txtNoCitas.Enabled = false;
            this.txtNoCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoCitas.HideSelection = true;
            this.txtNoCitas.LeadingIcon = null;
            this.txtNoCitas.Location = new System.Drawing.Point(269, 297);
            this.txtNoCitas.MaxLength = 32767;
            this.txtNoCitas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoCitas.Name = "txtNoCitas";
            this.txtNoCitas.PasswordChar = '\0';
            this.txtNoCitas.PrefixSuffixText = null;
            this.txtNoCitas.ReadOnly = false;
            this.txtNoCitas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoCitas.SelectedText = "";
            this.txtNoCitas.SelectionLength = 0;
            this.txtNoCitas.SelectionStart = 0;
            this.txtNoCitas.ShortcutsEnabled = true;
            this.txtNoCitas.Size = new System.Drawing.Size(309, 36);
            this.txtNoCitas.TabIndex = 130;
            this.txtNoCitas.TabStop = false;
            this.txtNoCitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNoCitas.TrailingIcon = null;
            this.txtNoCitas.UseSystemPasswordChar = false;
            this.txtNoCitas.UseTallSize = false;
            this.txtNoCitas.Visible = false;
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTratamientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Location = new System.Drawing.Point(16, 374);
            this.dgvTratamientos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.ReadOnly = true;
            this.dgvTratamientos.Size = new System.Drawing.Size(841, 234);
            this.dgvTratamientos.TabIndex = 133;
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
            this.btnGrabar.Location = new System.Drawing.Point(378, 641);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(104, 44);
            this.btnGrabar.TabIndex = 134;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGrabar.UseAccentColor = false;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(580, 641);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(104, 44);
            this.btnSalir.TabIndex = 132;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.HighEmphasis = true;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(180, 641);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(104, 44);
            this.btnNuevo.TabIndex = 131;
            this.btnNuevo.Text = "    Nuevo     ";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 695);
            this.Controls.Add(this.dgvTratamientos);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtNoCitas);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dptFecha);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtIdDiagnostico);
            this.Name = "frmDiagnostico";
            this.Text = "Diagnóstico";
            this.Load += new System.EventHandler(this.frmDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdDiagnostico;
        private MaterialSkin.Controls.MaterialComboBox cmbPaciente;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdPaciente;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSaldo;
        private System.Windows.Forms.DateTimePicker dptFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtNoCitas;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
    }
}