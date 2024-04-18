namespace ConsultorioDental
{
    partial class MenuUsuer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuer));
            this.tabMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCatalogos = new System.Windows.Forms.TabPage();
            this.btnDentistas = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.btnCobros = new FontAwesome.Sharp.IconButton();
            this.btnCitas = new FontAwesome.Sharp.IconButton();
            this.tabUtilerias = new System.Windows.Forms.TabPage();
            this.BtnGuiaDeUsuario = new FontAwesome.Sharp.IconButton();
            this.btnCambiarUsuario = new FontAwesome.Sharp.IconButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabMenu.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCatalogos.SuspendLayout();
            this.tabMovimientos.SuspendLayout();
            this.tabUtilerias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMenu.Controls.Add(this.tabHome);
            this.tabMenu.Controls.Add(this.tabCatalogos);
            this.tabMenu.Controls.Add(this.tabMovimientos);
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
            this.tabMenu.Size = new System.Drawing.Size(1051, 503);
            this.tabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMenu.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.ImageKey = "system-solid-41-home.gif";
            this.tabHome.Location = new System.Drawing.Point(4, 37);
            this.tabHome.Margin = new System.Windows.Forms.Padding(4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(1043, 462);
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
            this.pictureBox1.Size = new System.Drawing.Size(1039, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabCatalogos
            // 
            this.tabCatalogos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCatalogos.Controls.Add(this.btnDentistas);
            this.tabCatalogos.Controls.Add(this.btnPacientes);
            this.tabCatalogos.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCatalogos.ImageKey = "system-solid-8-account.gif";
            this.tabCatalogos.Location = new System.Drawing.Point(4, 37);
            this.tabCatalogos.Margin = new System.Windows.Forms.Padding(4);
            this.tabCatalogos.Name = "tabCatalogos";
            this.tabCatalogos.Padding = new System.Windows.Forms.Padding(4);
            this.tabCatalogos.Size = new System.Drawing.Size(1043, 462);
            this.tabCatalogos.TabIndex = 0;
            this.tabCatalogos.Text = "Catálogos";
            this.tabCatalogos.UseVisualStyleBackColor = true;
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
            this.btnDentistas.Location = new System.Drawing.Point(559, 178);
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
            this.btnPacientes.Location = new System.Drawing.Point(243, 178);
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
            this.tabMovimientos.Size = new System.Drawing.Size(1043, 462);
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
            this.btnCobros.Location = new System.Drawing.Point(569, 178);
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
            this.btnCitas.Location = new System.Drawing.Point(289, 178);
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
            // tabUtilerias
            // 
            this.tabUtilerias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabUtilerias.Controls.Add(this.BtnGuiaDeUsuario);
            this.tabUtilerias.Controls.Add(this.btnCambiarUsuario);
            this.tabUtilerias.ImageKey = "9165478_unbox_package_icon.png";
            this.tabUtilerias.Location = new System.Drawing.Point(4, 37);
            this.tabUtilerias.Name = "tabUtilerias";
            this.tabUtilerias.Size = new System.Drawing.Size(1043, 462);
            this.tabUtilerias.TabIndex = 4;
            this.tabUtilerias.Text = "Utilerias";
            this.tabUtilerias.UseVisualStyleBackColor = true;
            // 
            // BtnGuiaDeUsuario
            // 
            this.BtnGuiaDeUsuario.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.BtnGuiaDeUsuario.IconColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuiaDeUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuiaDeUsuario.Location = new System.Drawing.Point(365, 239);
            this.BtnGuiaDeUsuario.Name = "BtnGuiaDeUsuario";
            this.BtnGuiaDeUsuario.Size = new System.Drawing.Size(308, 75);
            this.BtnGuiaDeUsuario.TabIndex = 5;
            this.BtnGuiaDeUsuario.Text = "Guia de usuario";
            this.BtnGuiaDeUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuiaDeUsuario.UseVisualStyleBackColor = true;
            this.BtnGuiaDeUsuario.Click += new System.EventHandler(this.BtnGuiaDeUsuario_Click);
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnCambiarUsuario.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarUsuario.Location = new System.Drawing.Point(365, 148);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(308, 75);
            this.btnCambiarUsuario.TabIndex = 3;
            this.btnCambiarUsuario.Text = "Cambiar de usuario";
            this.btnCambiarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "system-solid-41-home.gif");
            this.imageList1.Images.SetKeyName(1, "system-solid-8-account.gif");
            this.imageList1.Images.SetKeyName(2, "dental_checkup_odontology_dentist_dental_treatment_icon_226796.ico");
            this.imageList1.Images.SetKeyName(3, "9165478_unbox_package_icon.png");
            // 
            // MenuUsuer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.tabMenu);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabMenu;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuUsuer";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio DentalCare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuUsuer_FormClosing);
            this.Load += new System.EventHandler(this.MenuUsuer_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCatalogos.ResumeLayout(false);
            this.tabMovimientos.ResumeLayout(false);
            this.tabUtilerias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabMenu;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabCatalogos;
        private FontAwesome.Sharp.IconButton btnDentistas;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private System.Windows.Forms.TabPage tabMovimientos;
        private FontAwesome.Sharp.IconButton btnCobros;
        private FontAwesome.Sharp.IconButton btnCitas;
        private System.Windows.Forms.TabPage tabUtilerias;
        private FontAwesome.Sharp.IconButton BtnGuiaDeUsuario;
        private FontAwesome.Sharp.IconButton btnCambiarUsuario;
        private System.Windows.Forms.ImageList imageList1;
    }
}