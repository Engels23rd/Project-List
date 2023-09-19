namespace Listado_de_proyectos
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.bt_inicio = new System.Windows.Forms.Button();
            this.bt_historial = new System.Windows.Forms.Button();
            this.bt_agregar_proyecto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.panelmenu.Controls.Add(this.bt_inicio);
            this.panelmenu.Controls.Add(this.bt_historial);
            this.panelmenu.Controls.Add(this.bt_agregar_proyecto);
            this.panelmenu.Controls.Add(this.pictureBox1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(262, 690);
            this.panelmenu.TabIndex = 0;
            // 
            // bt_inicio
            // 
            this.bt_inicio.FlatAppearance.BorderSize = 2;
            this.bt_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_inicio.Font = new System.Drawing.Font("LT Comical", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inicio.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_inicio.Location = new System.Drawing.Point(12, 286);
            this.bt_inicio.Name = "bt_inicio";
            this.bt_inicio.Size = new System.Drawing.Size(240, 59);
            this.bt_inicio.TabIndex = 2;
            this.bt_inicio.Text = "Inicio";
            this.bt_inicio.UseVisualStyleBackColor = true;
            this.bt_inicio.Click += new System.EventHandler(this.bt_inicio_Click);
            // 
            // bt_historial
            // 
            this.bt_historial.FlatAppearance.BorderSize = 2;
            this.bt_historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_historial.Font = new System.Drawing.Font("LT Comical", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_historial.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_historial.Location = new System.Drawing.Point(12, 512);
            this.bt_historial.Name = "bt_historial";
            this.bt_historial.Size = new System.Drawing.Size(240, 59);
            this.bt_historial.TabIndex = 1;
            this.bt_historial.Text = "Historial de proyectos";
            this.bt_historial.UseVisualStyleBackColor = true;
            this.bt_historial.Click += new System.EventHandler(this.bt_historial_Click);
            // 
            // bt_agregar_proyecto
            // 
            this.bt_agregar_proyecto.FlatAppearance.BorderSize = 2;
            this.bt_agregar_proyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_proyecto.Font = new System.Drawing.Font("LT Comical", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar_proyecto.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_agregar_proyecto.Location = new System.Drawing.Point(12, 399);
            this.bt_agregar_proyecto.Name = "bt_agregar_proyecto";
            this.bt_agregar_proyecto.Size = new System.Drawing.Size(240, 59);
            this.bt_agregar_proyecto.TabIndex = 0;
            this.bt_agregar_proyecto.Text = "Proyectos";
            this.bt_agregar_proyecto.UseVisualStyleBackColor = true;
            this.bt_agregar_proyecto.Click += new System.EventHandler(this.bt_agregar_proyecto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Listado_de_proyectos.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.White;
            this.panelFormularios.Controls.Add(this.label1);
            this.panelFormularios.Controls.Add(this.pictureBox2);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(262, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1011, 690);
            this.panelFormularios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Comical", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(163, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 108);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Listado_de_proyectos.Properties.Resources.Logo_en_Azul___blanco1;
            this.pictureBox2.Location = new System.Drawing.Point(69, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(810, 486);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1273, 690);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelmenu);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_agregar_proyecto;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Button bt_historial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_inicio;
        private System.Windows.Forms.Label label1;
    }
}

