namespace ConsultorioDental.Utilerias
{
    partial class frmRestaurar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdRestaurar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdRespaldar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultorioDental.Properties.Resources.respaldo;
            this.pictureBox1.Location = new System.Drawing.Point(321, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdRestaurar
            // 
            this.cmdRestaurar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRestaurar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmdRestaurar.Depth = 0;
            this.cmdRestaurar.HighEmphasis = true;
            this.cmdRestaurar.Icon = null;
            this.cmdRestaurar.Location = new System.Drawing.Point(517, 285);
            this.cmdRestaurar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdRestaurar.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdRestaurar.Name = "cmdRestaurar";
            this.cmdRestaurar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmdRestaurar.Size = new System.Drawing.Size(104, 36);
            this.cmdRestaurar.TabIndex = 26;
            this.cmdRestaurar.Text = "Restaurar";
            this.cmdRestaurar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmdRestaurar.UseAccentColor = false;
            this.cmdRestaurar.UseVisualStyleBackColor = true;
            this.cmdRestaurar.Click += new System.EventHandler(this.cmdRestaurar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ConsultorioDental.Properties.Resources.dupdo;
            this.pictureBox2.Location = new System.Drawing.Point(515, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // cmdRespaldar
            // 
            this.cmdRespaldar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdRespaldar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmdRespaldar.Depth = 0;
            this.cmdRespaldar.HighEmphasis = true;
            this.cmdRespaldar.Icon = null;
            this.cmdRespaldar.Location = new System.Drawing.Point(159, 285);
            this.cmdRespaldar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdRespaldar.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdRespaldar.Name = "cmdRespaldar";
            this.cmdRespaldar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmdRespaldar.Size = new System.Drawing.Size(103, 36);
            this.cmdRespaldar.TabIndex = 28;
            this.cmdRespaldar.Text = "Respaldar";
            this.cmdRespaldar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmdRespaldar.UseAccentColor = false;
            this.cmdRespaldar.UseVisualStyleBackColor = true;
            this.cmdRespaldar.Click += new System.EventHandler(this.cmdRespaldar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ConsultorioDental.Properties.Resources.documento;
            this.pictureBox3.Location = new System.Drawing.Point(156, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(147, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(150, 34);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "Crea un archivo de respaldo de la base de datos";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(496, 110);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(150, 48);
            this.richTextBox2.TabIndex = 31;
            this.richTextBox2.Text = "Restaura la base de datos desde un archivo previo";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(687, 403);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(104, 36);
            this.btnSalir.TabIndex = 119;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmdRestaurar);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.cmdRespaldar);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 326);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmRestaurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestaurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restaurar/Respaldar base de datos";
            this.Load += new System.EventHandler(this.frmRestaurar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton cmdRestaurar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton cmdRespaldar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}