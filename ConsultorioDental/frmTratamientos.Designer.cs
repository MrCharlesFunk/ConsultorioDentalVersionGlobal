namespace ConsultorioDental
{
    partial class frmTratamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTratamientos));
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.cmbTratamiento = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTratamiento = new MaterialSkin.Controls.MaterialTextBox2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImporte = new MaterialSkin.Controls.MaterialTextBox2();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCantidadCitas = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIdTratamiento = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(681, 546);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(104, 44);
            this.btnSalir.TabIndex = 104;
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
            this.btnNuevo.Location = new System.Drawing.Point(281, 546);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(104, 44);
            this.btnNuevo.TabIndex = 101;
            this.btnNuevo.Text = "    Nuevo     ";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.cmbTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTratamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTratamiento.FormattingEnabled = true;
            this.cmbTratamiento.IntegralHeight = false;
            this.cmbTratamiento.ItemHeight = 29;
            this.cmbTratamiento.Location = new System.Drawing.Point(597, 116);
            this.cmbTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTratamiento.MaxDropDownItems = 4;
            this.cmbTratamiento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTratamiento.Name = "cmbTratamiento";
            this.cmbTratamiento.Size = new System.Drawing.Size(389, 35);
            this.cmbTratamiento.StartIndex = 0;
            this.cmbTratamiento.TabIndex = 106;
            this.cmbTratamiento.UseTallSize = false;
            this.cmbTratamiento.SelectedIndexChanged += new System.EventHandler(this.cmbTratamiento_SelectedIndexChanged);
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTratamientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Location = new System.Drawing.Point(25, 16);
            this.dgvTratamientos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.ReadOnly = true;
            this.dgvTratamientos.Size = new System.Drawing.Size(841, 234);
            this.dgvTratamientos.TabIndex = 108;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(476, 126);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 17);
            this.materialLabel1.TabIndex = 109;
            this.materialLabel1.Text = "Tratamiento:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel3.Location = new System.Drawing.Point(475, 178);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 17);
            this.materialLabel3.TabIndex = 111;
            this.materialLabel3.Text = "Presupuesto:";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.AnimateReadOnly = false;
            this.txtTratamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTratamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTratamiento.Depth = 0;
            this.txtTratamiento.Enabled = false;
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTratamiento.HideSelection = true;
            this.txtTratamiento.LeadingIcon = null;
            this.txtTratamiento.Location = new System.Drawing.Point(597, 116);
            this.txtTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTratamiento.MaxLength = 255;
            this.txtTratamiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.PasswordChar = '\0';
            this.txtTratamiento.PrefixSuffixText = null;
            this.txtTratamiento.ReadOnly = false;
            this.txtTratamiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTratamiento.SelectedText = "";
            this.txtTratamiento.SelectionLength = 0;
            this.txtTratamiento.SelectionStart = 0;
            this.txtTratamiento.ShortcutsEnabled = true;
            this.txtTratamiento.Size = new System.Drawing.Size(391, 36);
            this.txtTratamiento.TabIndex = 112;
            this.txtTratamiento.TabStop = false;
            this.txtTratamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTratamiento.TrailingIcon = null;
            this.txtTratamiento.UseSystemPasswordChar = false;
            this.txtTratamiento.UseTallSize = false;
            this.txtTratamiento.Visible = false;
            this.txtTratamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTratamiento_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTratamientos);
            this.groupBox1.Location = new System.Drawing.Point(88, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(891, 267);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
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
            this.txtImporte.Location = new System.Drawing.Point(597, 168);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.MaxLength = 15;
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
            this.txtImporte.Size = new System.Drawing.Size(160, 36);
            this.txtImporte.TabIndex = 114;
            this.txtImporte.TabStop = false;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtImporte.TrailingIcon = null;
            this.txtImporte.UseSystemPasswordChar = false;
            this.txtImporte.UseTallSize = false;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Aviso";
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
            this.btnGrabar.Location = new System.Drawing.Point(479, 546);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(104, 44);
            this.btnGrabar.TabIndex = 122;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGrabar.UseAccentColor = false;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.Location = new System.Drawing.Point(445, 232);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(116, 17);
            this.materialLabel4.TabIndex = 123;
            this.materialLabel4.Text = "Cantidad de citas:";
            // 
            // txtCantidadCitas
            // 
            this.txtCantidadCitas.AnimateReadOnly = false;
            this.txtCantidadCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCantidadCitas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCantidadCitas.Depth = 0;
            this.txtCantidadCitas.Enabled = false;
            this.txtCantidadCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadCitas.HideSelection = true;
            this.txtCantidadCitas.LeadingIcon = null;
            this.txtCantidadCitas.Location = new System.Drawing.Point(597, 221);
            this.txtCantidadCitas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadCitas.MaxLength = 9;
            this.txtCantidadCitas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidadCitas.Name = "txtCantidadCitas";
            this.txtCantidadCitas.PasswordChar = '\0';
            this.txtCantidadCitas.PrefixSuffixText = null;
            this.txtCantidadCitas.ReadOnly = false;
            this.txtCantidadCitas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCantidadCitas.SelectedText = "";
            this.txtCantidadCitas.SelectionLength = 0;
            this.txtCantidadCitas.SelectionStart = 0;
            this.txtCantidadCitas.ShortcutsEnabled = true;
            this.txtCantidadCitas.Size = new System.Drawing.Size(160, 36);
            this.txtCantidadCitas.TabIndex = 124;
            this.txtCantidadCitas.TabStop = false;
            this.txtCantidadCitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidadCitas.TrailingIcon = null;
            this.txtCantidadCitas.UseSystemPasswordChar = false;
            this.txtCantidadCitas.UseTallSize = false;
            this.txtCantidadCitas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadCitas_KeyPress);
            // 
            // txtIdTratamiento
            // 
            this.txtIdTratamiento.AnimateReadOnly = false;
            this.txtIdTratamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdTratamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdTratamiento.Depth = 0;
            this.txtIdTratamiento.Enabled = false;
            this.txtIdTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdTratamiento.HideSelection = true;
            this.txtIdTratamiento.LeadingIcon = null;
            this.txtIdTratamiento.Location = new System.Drawing.Point(228, 116);
            this.txtIdTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdTratamiento.MaxLength = 32767;
            this.txtIdTratamiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdTratamiento.Name = "txtIdTratamiento";
            this.txtIdTratamiento.PasswordChar = '\0';
            this.txtIdTratamiento.PrefixSuffixText = null;
            this.txtIdTratamiento.ReadOnly = false;
            this.txtIdTratamiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdTratamiento.SelectedText = "";
            this.txtIdTratamiento.SelectionLength = 0;
            this.txtIdTratamiento.SelectionStart = 0;
            this.txtIdTratamiento.ShortcutsEnabled = true;
            this.txtIdTratamiento.Size = new System.Drawing.Size(177, 36);
            this.txtIdTratamiento.TabIndex = 100;
            this.txtIdTratamiento.TabStop = false;
            this.txtIdTratamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdTratamiento.TrailingIcon = null;
            this.txtIdTratamiento.UseSystemPasswordChar = false;
            this.txtIdTratamiento.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(79, 126);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 17);
            this.materialLabel2.TabIndex = 110;
            this.materialLabel2.Text = "No Tratamiento:";
            // 
            // frmTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 617);
            this.Controls.Add(this.txtCantidadCitas);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtIdTratamiento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.cmbTratamiento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTratamientos";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamientos";
            this.Load += new System.EventHandler(this.frmTratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialComboBox cmbTratamiento;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtTratamiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtImporte;
        private System.Windows.Forms.ToolTip toolTip;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtCantidadCitas;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdTratamiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}