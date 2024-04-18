namespace ConsultorioDental
{
    partial class frmEspecialidad
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
            this.txtIdEspecialidad = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.txtEspecialidad = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(26, 112);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(102, 17);
            this.materialLabel2.TabIndex = 112;
            this.materialLabel2.Text = "Id Especialidad:";
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.AnimateReadOnly = false;
            this.txtIdEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdEspecialidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdEspecialidad.Depth = 0;
            this.txtIdEspecialidad.Enabled = false;
            this.txtIdEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdEspecialidad.HideSelection = true;
            this.txtIdEspecialidad.LeadingIcon = null;
            this.txtIdEspecialidad.Location = new System.Drawing.Point(136, 103);
            this.txtIdEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEspecialidad.MaxLength = 32767;
            this.txtIdEspecialidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.PasswordChar = '\0';
            this.txtIdEspecialidad.PrefixSuffixText = null;
            this.txtIdEspecialidad.ReadOnly = false;
            this.txtIdEspecialidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdEspecialidad.SelectedText = "";
            this.txtIdEspecialidad.SelectionLength = 0;
            this.txtIdEspecialidad.SelectionStart = 0;
            this.txtIdEspecialidad.ShortcutsEnabled = true;
            this.txtIdEspecialidad.Size = new System.Drawing.Size(177, 36);
            this.txtIdEspecialidad.TabIndex = 111;
            this.txtIdEspecialidad.TabStop = false;
            this.txtIdEspecialidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdEspecialidad.TrailingIcon = null;
            this.txtIdEspecialidad.UseSystemPasswordChar = false;
            this.txtIdEspecialidad.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.Location = new System.Drawing.Point(460, 113);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(87, 17);
            this.materialLabel4.TabIndex = 113;
            this.materialLabel4.Text = "Especialidad:";
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTratamientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Location = new System.Drawing.Point(22, 176);
            this.dgvTratamientos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.ReadOnly = true;
            this.dgvTratamientos.Size = new System.Drawing.Size(841, 234);
            this.dgvTratamientos.TabIndex = 125;
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
            this.btnGrabar.Location = new System.Drawing.Point(392, 446);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(104, 44);
            this.btnGrabar.TabIndex = 126;
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
            this.btnSalir.Location = new System.Drawing.Point(554, 446);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(104, 44);
            this.btnSalir.TabIndex = 124;
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
            this.btnNuevo.Location = new System.Drawing.Point(227, 446);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(104, 44);
            this.btnNuevo.TabIndex = 123;
            this.btnNuevo.Text = "    Nuevo     ";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.AnimateReadOnly = false;
            this.txtEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEspecialidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEspecialidad.Depth = 0;
            this.txtEspecialidad.Enabled = false;
            this.txtEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEspecialidad.HideSelection = true;
            this.txtEspecialidad.LeadingIcon = null;
            this.txtEspecialidad.Location = new System.Drawing.Point(574, 103);
            this.txtEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecialidad.MaxLength = 32767;
            this.txtEspecialidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.PasswordChar = '\0';
            this.txtEspecialidad.PrefixSuffixText = null;
            this.txtEspecialidad.ReadOnly = false;
            this.txtEspecialidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEspecialidad.SelectedText = "";
            this.txtEspecialidad.SelectionLength = 0;
            this.txtEspecialidad.SelectionStart = 0;
            this.txtEspecialidad.ShortcutsEnabled = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(256, 36);
            this.txtEspecialidad.TabIndex = 127;
            this.txtEspecialidad.TabStop = false;
            this.txtEspecialidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEspecialidad.TrailingIcon = null;
            this.txtEspecialidad.UseSystemPasswordChar = false;
            this.txtEspecialidad.UseTallSize = false;
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 527);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.dgvTratamientos);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtIdEspecialidad);
            this.Name = "frmEspecialidad";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.frmEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdEspecialidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialTextBox2 txtEspecialidad;
    }
}