namespace Listado_de_proyectos.UI.Forms
{
    partial class historial_proyectos
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
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LT Comical", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(272, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Historial de proyectos";
            // 
            // dgv_historial
            // 
            this.dgv_historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historial.Location = new System.Drawing.Point(87, 166);
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.Size = new System.Drawing.Size(842, 370);
            this.dgv_historial.TabIndex = 3;
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(130)))));
            this.bt_actualizar.Font = new System.Drawing.Font("LT Comical", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_actualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_actualizar.Location = new System.Drawing.Point(107, 581);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(201, 59);
            this.bt_actualizar.TabIndex = 15;
            this.bt_actualizar.Text = "Actualizar";
            this.bt_actualizar.UseVisualStyleBackColor = false;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.BackColor = System.Drawing.SystemColors.Control;
            this.bt_imprimir.FlatAppearance.BorderSize = 2;
            this.bt_imprimir.Font = new System.Drawing.Font("LT Comical", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_imprimir.Image = global::Listado_de_proyectos.Properties.Resources.txt;
            this.bt_imprimir.Location = new System.Drawing.Point(814, 574);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(79, 72);
            this.bt_imprimir.TabIndex = 18;
            this.bt_imprimir.UseVisualStyleBackColor = false;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.bt_eliminar.Font = new System.Drawing.Font("LT Comical", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_eliminar.Location = new System.Drawing.Point(458, 581);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(201, 59);
            this.bt_eliminar.TabIndex = 17;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // historial_proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1012, 690);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.dgv_historial);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "historial_proyectos";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.historial_proyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_historial;
        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button bt_eliminar;
    }
}