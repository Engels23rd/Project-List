using Listado_de_proyectos.Forms;
using Listado_de_proyectos.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listado_de_proyectos
{
    public partial class Inicio : Form
    {

        private List<Form> formulariosAbiertos = new List<Form>();


        public Inicio()
        {
            InitializeComponent();
        }



        // PARA PONER FORMULARIOS EN UN PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {

            // Cerrar y eliminar todos los formularios abiertos actualmente
            CerrarFormulariosAbiertos();

            // Abrir el formulario requerido
            Form formulario = new MiForm();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formulario);
            formulariosAbiertos.Add(formulario);
            formulario.Show();

            formulario.BringToFront();
        }

        private void CerrarFormulariosAbiertos()
        {
            // Cierra todos los formularios abiertos en el panel y los remueve de la lista
            foreach (Form formulario in formulariosAbiertos)
            {
                formulario.Close();
            }
            formulariosAbiertos.Clear();
        }



        private void bt_agregar_proyecto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Agregar_proyecto>();
        }


        private void bt_historial_Click(object sender, EventArgs e)
        {
            AbrirFormulario<historial_proyectos>();
        }

        private void bt_inicio_Click(object sender, EventArgs e)
        {
            CerrarFormulariosAbiertos();
        }
    }
    
}
