namespace ConsultorioDental
{
    partial class frmHistorial
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
            this.txtIdPaciente = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPadecimientos = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPaciente = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEstudios = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnConsultaGeneral = new MaterialSkin.Controls.MaterialButton();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.AnimateReadOnly = false;
            this.txtIdPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdPaciente.Depth = 0;
            this.txtIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPaciente.HideSelection = true;
            this.txtIdPaciente.LeadingIcon = null;
            this.txtIdPaciente.Location = new System.Drawing.Point(16, 46);
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
            this.txtIdPaciente.Size = new System.Drawing.Size(102, 36);
            this.txtIdPaciente.TabIndex = 99;
            this.txtIdPaciente.TabStop = false;
            this.txtIdPaciente.Text = "IdPaciente";
            this.txtIdPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdPaciente.TrailingIcon = null;
            this.txtIdPaciente.UseSystemPasswordChar = false;
            this.txtIdPaciente.UseTallSize = false;
            // 
            // txtPadecimientos
            // 
            this.txtPadecimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPadecimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPadecimientos.Depth = 0;
            this.txtPadecimientos.Enabled = false;
            this.txtPadecimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPadecimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPadecimientos.Location = new System.Drawing.Point(634, 48);
            this.txtPadecimientos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPadecimientos.Name = "txtPadecimientos";
            this.txtPadecimientos.Size = new System.Drawing.Size(200, 96);
            this.txtPadecimientos.TabIndex = 101;
            this.txtPadecimientos.Text = "";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.materialLabel4);
            this.gbDatos.Controls.Add(this.materialLabel1);
            this.gbDatos.Controls.Add(this.materialLabel2);
            this.gbDatos.Controls.Add(this.cmbPaciente);
            this.gbDatos.Controls.Add(this.txtEstudios);
            this.gbDatos.Controls.Add(this.txtPadecimientos);
            this.gbDatos.Controls.Add(this.txtIdPaciente);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(31, 82);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(852, 285);
            this.gbDatos.TabIndex = 102;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del paciente";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.Location = new System.Drawing.Point(568, 174);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(60, 17);
            this.materialLabel4.TabIndex = 114;
            this.materialLabel4.Text = "Estudios:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(527, 55);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 17);
            this.materialLabel1.TabIndex = 112;
            this.materialLabel1.Text = "Padecimientos:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(170, 55);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 17);
            this.materialLabel2.TabIndex = 111;
            this.materialLabel2.Text = "Paciente:";
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
            this.cmbPaciente.Location = new System.Drawing.Point(238, 47);
            this.cmbPaciente.MaxDropDownItems = 4;
            this.cmbPaciente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(238, 35);
            this.cmbPaciente.StartIndex = 0;
            this.cmbPaciente.TabIndex = 107;
            this.cmbPaciente.UseTallSize = false;
            // 
            // txtEstudios
            // 
            this.txtEstudios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEstudios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstudios.Depth = 0;
            this.txtEstudios.Enabled = false;
            this.txtEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstudios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEstudios.Location = new System.Drawing.Point(634, 168);
            this.txtEstudios.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstudios.Name = "txtEstudios";
            this.txtEstudios.Size = new System.Drawing.Size(200, 96);
            this.txtEstudios.TabIndex = 105;
            this.txtEstudios.Text = "";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(31, 373);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(852, 190);
            this.dgvHistorial.TabIndex = 103;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(735, 596);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(78, 36);
            this.btnSalir.TabIndex = 112;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultaGeneral.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultaGeneral.Depth = 0;
            this.btnConsultaGeneral.HighEmphasis = true;
            this.btnConsultaGeneral.Icon = null;
            this.btnConsultaGeneral.Location = new System.Drawing.Point(445, 596);
            this.btnConsultaGeneral.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultaGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsultaGeneral.Size = new System.Drawing.Size(165, 36);
            this.btnConsultaGeneral.TabIndex = 111;
            this.btnConsultaGeneral.Text = "Consulta General";
            this.btnConsultaGeneral.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultaGeneral.UseAccentColor = false;
            this.btnConsultaGeneral.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrabar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGrabar.Depth = 0;
            this.btnGrabar.Enabled = false;
            this.btnGrabar.HighEmphasis = true;
            this.btnGrabar.Icon = null;
            this.btnGrabar.Location = new System.Drawing.Point(269, 596);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(78, 36);
            this.btnGrabar.TabIndex = 110;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGrabar.UseAccentColor = false;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.HighEmphasis = true;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(108, 596);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(78, 36);
            this.btnNuevo.TabIndex = 109;
            this.btnNuevo.Text = "    Nuevo     ";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 654);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultaGeneral);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmHistorial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtIdPaciente;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtPadecimientos;
        private System.Windows.Forms.GroupBox gbDatos;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtEstudios;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnConsultaGeneral;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialComboBox cmbPaciente;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}