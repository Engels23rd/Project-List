namespace Listado_de_proyectos.Forms
{
    partial class Agregar_proyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.dgv_proyecto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_proyecto = new System.Windows.Forms.TextBox();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proyecto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Comical", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(400, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyectos";
            // 
            // bt_agregar
            // 
            this.bt_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.bt_agregar.Font = new System.Drawing.Font("LT Comical", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_agregar.Location = new System.Drawing.Point(92, 619);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(201, 59);
            this.bt_agregar.TabIndex = 10;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.bt_limpiar.Font = new System.Drawing.Font("LT Comical", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_limpiar.Location = new System.Drawing.Point(506, 619);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(201, 59);
            this.bt_limpiar.TabIndex = 11;
            this.bt_limpiar.Text = "Limpiar";
            this.bt_limpiar.UseVisualStyleBackColor = false;
            this.bt_limpiar.Click += new System.EventHandler(this.bt_limpiar_Click);
            // 
            // dgv_proyecto
            // 
            this.dgv_proyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_proyecto.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_proyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proyecto.Location = new System.Drawing.Point(92, 333);
            this.dgv_proyecto.Name = "dgv_proyecto";
            this.dgv_proyecto.Size = new System.Drawing.Size(823, 280);
            this.dgv_proyecto.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txt_tipo);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_proyecto);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("LT Comical", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.groupBox1.Location = new System.Drawing.Point(92, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 197);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de proyectos";
            // 
            // txt_tipo
            // 
            this.txt_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipo.Font = new System.Drawing.Font("LT Comical", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.txt_tipo.Location = new System.Drawing.Point(203, 139);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(331, 32);
            this.txt_tipo.TabIndex = 15;
            // 
            // txt_cliente
            // 
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cliente.Font = new System.Drawing.Font("LT Comical", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.txt_cliente.Location = new System.Drawing.Point(203, 87);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(216, 32);
            this.txt_cliente.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LT Comical", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(38, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de proyecto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LT Comical", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LT Comical", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del proyecto:";
            // 
            // txt_proyecto
            // 
            this.txt_proyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proyecto.Font = new System.Drawing.Font("LT Comical", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.txt_proyecto.Location = new System.Drawing.Point(203, 31);
            this.txt_proyecto.Name = "txt_proyecto";
            this.txt_proyecto.Size = new System.Drawing.Size(403, 32);
            this.txt_proyecto.TabIndex = 10;
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.bt_actualizar.Font = new System.Drawing.Font("LT Comical", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_actualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_actualizar.Location = new System.Drawing.Point(299, 619);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(201, 59);
            this.bt_actualizar.TabIndex = 14;
            this.bt_actualizar.Text = "Actualizar";
            this.bt_actualizar.UseVisualStyleBackColor = false;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.bt_eliminar.Font = new System.Drawing.Font("LT Comical", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_eliminar.Location = new System.Drawing.Point(713, 619);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(201, 59);
            this.bt_eliminar.TabIndex = 15;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.BackColor = System.Drawing.SystemColors.Control;
            this.bt_imprimir.FlatAppearance.BorderSize = 2;
            this.bt_imprimir.Font = new System.Drawing.Font("LT Comical", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_imprimir.Image = global::Listado_de_proyectos.Properties.Resources.txt;
            this.bt_imprimir.Location = new System.Drawing.Point(840, 249);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(75, 70);
            this.bt_imprimir.TabIndex = 16;
            this.bt_imprimir.UseVisualStyleBackColor = false;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // Agregar_proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1012, 690);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_proyecto);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_proyecto";
            this.Text = "Agregar proyecto";
            this.Load += new System.EventHandler(this.Agregar_proyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proyecto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.DataGridView dgv_proyecto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_proyecto;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_imprimir;
    }
}