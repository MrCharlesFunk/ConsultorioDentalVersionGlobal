namespace ConsultorioDental
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabUtilerias = new System.Windows.Forms.TabPage();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnNuevoUsuario = new FontAwesome.Sharp.IconButton();
            this.BtnGuiaDeUsuario = new FontAwesome.Sharp.IconButton();
            this.btnCambiarContrasena = new FontAwesome.Sharp.IconButton();
            this.btnCambiarUsuario = new FontAwesome.Sharp.IconButton();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.btnCobros = new FontAwesome.Sharp.IconButton();
            this.btnCitas = new FontAwesome.Sharp.IconButton();
            this.tabCatalogos = new System.Windows.Forms.TabPage();
            this.btnTratamiento = new FontAwesome.Sharp.IconButton();
            this.btnDentistas = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tabUtilerias.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.tabMovimientos.SuspendLayout();
            this.tabCatalogos.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "system-solid-8-account.gif");
            this.imageList1.Images.SetKeyName(1, "system-solid-41-home.gif");
            this.imageList1.Images.SetKeyName(2, "dental_checkup_odontology_dentist_dental_treatment_icon_226796.ico");
            this.imageList1.Images.SetKeyName(3, "reports_icon_218114.png");
            this.imageList1.Images.SetKeyName(4, "9165478_unbox_package_icon.png");
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Información";
            // 
            // tabUtilerias
            // 
            this.tabUtilerias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabUtilerias.Controls.Add(this.iconButton1);
            this.tabUtilerias.Controls.Add(this.btnNuevoUsuario);
            this.tabUtilerias.Controls.Add(this.BtnGuiaDeUsuario);
            this.tabUtilerias.Controls.Add(this.btnCambiarContrasena);
            this.tabUtilerias.Controls.Add(this.btnCambiarUsuario);
            this.tabUtilerias.ImageKey = "9165478_unbox_package_icon.png";
            this.tabUtilerias.Location = new System.Drawing.Point(4, 37);
            this.tabUtilerias.Name = "tabUtilerias";
            this.tabUtilerias.Size = new System.Drawing.Size(1039, 430);
            this.tabUtilerias.TabIndex = 4;
            this.tabUtilerias.Text = "Utilerias";
            this.tabUtilerias.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.iconButton1.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(537, 20);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(308, 75);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Restaurar o Respaldar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Enabled = false;
            this.btnNuevoUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnNuevoUsuario.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(190, 221);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(308, 75);
            this.btnNuevoUsuario.TabIndex = 3;
            this.btnNuevoUsuario.Text = "Crear usuario";
            this.btnNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnGuiaDeUsuario
            // 
            this.BtnGuiaDeUsuario.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.BtnGuiaDeUsuario.IconColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuiaDeUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuiaDeUsuario.Location = new System.Drawing.Point(190, 331);
            this.BtnGuiaDeUsuario.Name = "BtnGuiaDeUsuario";
            this.BtnGuiaDeUsuario.Size = new System.Drawing.Size(308, 75);
            this.BtnGuiaDeUsuario.TabIndex = 2;
            this.BtnGuiaDeUsuario.Text = "Guia de usuario";
            this.BtnGuiaDeUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuiaDeUsuario.UseVisualStyleBackColor = true;
            this.BtnGuiaDeUsuario.Click += new System.EventHandler(this.BtnGuiaDeUsuario_Click);
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnCambiarContrasena.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarContrasena.Location = new System.Drawing.Point(190, 110);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(308, 75);
            this.btnCambiarContrasena.TabIndex = 1;
            this.btnCambiarContrasena.Text = "Cambiar contraseña";
            this.btnCambiarContrasena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnCambiarUsuario.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarUsuario.Location = new System.Drawing.Point(190, 20);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(308, 75);
            this.btnCambiarUsuario.TabIndex = 0;
            this.btnCambiarUsuario.Text = "Cambiar de usuario";
            this.btnCambiarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // tabReportes
            // 
            this.tabReportes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabReportes.Controls.Add(this.btnReportes);
            this.tabReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabReportes.ImageKey = "reports_icon_218114.png";
            this.tabReportes.Location = new System.Drawing.Point(4, 37);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportes.Size = new System.Drawing.Size(1039, 430);
            this.tabReportes.TabIndex = 3;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnReportes.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 55;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(438, 176);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(159, 74);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabMovimientos.Controls.Add(this.btnCobros);
            this.tabMovimientos.Controls.Add(this.btnCitas);
            this.tabMovimientos.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMovimientos.ImageKey = "dental_checkup_odontology_dentist_dental_treatment_icon_226796.ico";
            this.tabMovimientos.Location = new System.Drawing.Point(4, 37);
            this.tabMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Padding = new System.Windows.Forms.Padding(4);
            this.tabMovimientos.Size = new System.Drawing.Size(1039, 430);
            this.tabMovimientos.TabIndex = 1;
            this.tabMovimientos.Text = "Movimientos";
            this.tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnCobros
            // 
            this.btnCobros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobros.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnCobros.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnCobros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCobros.IconSize = 55;
            this.btnCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobros.Location = new System.Drawing.Point(569, 176);
            this.btnCobros.Margin = new System.Windows.Forms.Padding(4);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnCobros.Size = new System.Drawing.Size(176, 74);
            this.btnCobros.TabIndex = 7;
            this.btnCobros.Text = "Cobros";
            this.btnCobros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobros.UseVisualStyleBackColor = true;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnCitas.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCitas.IconSize = 55;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(289, 176);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnCitas.Size = new System.Drawing.Size(159, 74);
            this.btnCitas.TabIndex = 6;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // tabCatalogos
            // 
            this.tabCatalogos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCatalogos.Controls.Add(this.btnTratamiento);
            this.tabCatalogos.Controls.Add(this.btnDentistas);
            this.tabCatalogos.Controls.Add(this.btnPacientes);
            this.tabCatalogos.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCatalogos.ImageKey = "system-solid-8-account.gif";
            this.tabCatalogos.Location = new System.Drawing.Point(4, 37);
            this.tabCatalogos.Margin = new System.Windows.Forms.Padding(4);
            this.tabCatalogos.Name = "tabCatalogos";
            this.tabCatalogos.Padding = new System.Windows.Forms.Padding(4);
            this.tabCatalogos.Size = new System.Drawing.Size(1039, 430);
            this.tabCatalogos.TabIndex = 0;
            this.tabCatalogos.Text = "Catálogos";
            this.tabCatalogos.UseVisualStyleBackColor = true;
            // 
            // btnTratamiento
            // 
            this.btnTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTratamiento.IconChar = FontAwesome.Sharp.IconChar.Tooth;
            this.btnTratamiento.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnTratamiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTratamiento.IconSize = 55;
            this.btnTratamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTratamiento.Location = new System.Drawing.Point(396, 244);
            this.btnTratamiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnTratamiento.Name = "btnTratamiento";
            this.btnTratamiento.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnTratamiento.Size = new System.Drawing.Size(233, 74);
            this.btnTratamiento.TabIndex = 6;
            this.btnTratamiento.Text = "Tratamiento";
            this.btnTratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTratamiento.UseVisualStyleBackColor = true;
            this.btnTratamiento.Click += new System.EventHandler(this.btnTratamiento_Click);
            // 
            // btnDentistas
            // 
            this.btnDentistas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDentistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDentistas.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.btnDentistas.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnDentistas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDentistas.IconSize = 55;
            this.btnDentistas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDentistas.Location = new System.Drawing.Point(559, 109);
            this.btnDentistas.Margin = new System.Windows.Forms.Padding(4);
            this.btnDentistas.Name = "btnDentistas";
            this.btnDentistas.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDentistas.Size = new System.Drawing.Size(233, 74);
            this.btnDentistas.TabIndex = 5;
            this.btnDentistas.Text = "Dentistas";
            this.btnDentistas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDentistas.UseVisualStyleBackColor = true;
            this.btnDentistas.Click += new System.EventHandler(this.btnDentistas_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnPacientes.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.IconSize = 55;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(243, 109);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnPacientes.Size = new System.Drawing.Size(233, 74);
            this.btnPacientes.TabIndex = 4;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // tabHome
            // 
            this.tabHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabHome.Controls.Add(this.lbUsuario);
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.ImageKey = "system-solid-41-home.gif";
            this.tabHome.Location = new System.Drawing.Point(4, 37);
            this.tabHome.Margin = new System.Windows.Forms.Padding(4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(1039, 430);
            this.tabHome.TabIndex = 2;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ConsultorioDental.Properties.Resources.cuidado_dental;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Controls.Add(this.tabHome);
            this.tabMenu.Controls.Add(this.tabCatalogos);
            this.tabMenu.Controls.Add(this.tabMovimientos);
            this.tabMenu.Controls.Add(this.tabReportes);
            this.tabMenu.Controls.Add(this.tabUtilerias);
            this.tabMenu.Depth = 0;
            this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.HotTrack = true;
            this.tabMenu.ImageList = this.imageList1;
            this.tabMenu.Location = new System.Drawing.Point(8, 79);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tabMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMenu.Multiline = true;
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1047, 471);
            this.tabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMenu.TabIndex = 0;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(790, 402);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 23);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "label1";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.tabMenu);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabMenu;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio DentalCare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.tabUtilerias.ResumeLayout(false);
            this.tabReportes.ResumeLayout(false);
            this.tabMovimientos.ResumeLayout(false);
            this.tabCatalogos.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabUtilerias;
        private System.Windows.Forms.TabPage tabReportes;
        private FontAwesome.Sharp.IconButton btnReportes;
        private System.Windows.Forms.TabPage tabMovimientos;
        private FontAwesome.Sharp.IconButton btnCobros;
        private FontAwesome.Sharp.IconButton btnCitas;
        private System.Windows.Forms.TabPage tabCatalogos;
        private FontAwesome.Sharp.IconButton btnTratamiento;
        private FontAwesome.Sharp.IconButton btnDentistas;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl tabMenu;
        private FontAwesome.Sharp.IconButton btnCambiarUsuario;
        private FontAwesome.Sharp.IconButton BtnGuiaDeUsuario;
        private FontAwesome.Sharp.IconButton btnCambiarContrasena;
        private FontAwesome.Sharp.IconButton btnNuevoUsuario;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbUsuario;
    }
}

