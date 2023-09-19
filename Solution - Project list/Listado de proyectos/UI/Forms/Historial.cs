using Listado_de_proyectos.Class;
using Listado_de_proyectos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listado_de_proyectos.UI.Forms
{
    public partial class historial_proyectos : Form
    {
        public historial_proyectos()
        {
            InitializeComponent();
        }



        // Cuando la pestaña de historial cargue llamara lo que esta dentro
        private void historial_proyectos_Load(object sender, EventArgs e)
        {

            //la clase conexion de la base de datos
            Conexion.Conectar();

            // llamando el constructor que hicimos
            dgv_historial.DataSource = datoshistorial();
            dgv_historial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            datoshistorial();
        }

        private void AgregarForm_ProyectoAgregado(object sender, EventArgs e)
        {
            // Refrescar los datos en el DataGridView
            dgv_historial.DataSource = datoshistorial();
        }



        private DataTable datoshistorial()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT id, nombre_proyecto, nombre_cliente, tipo_proyecto, fecha_creacion, estado FROM proyectos";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgv_historial.DataSource;
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, nombre_proyecto, nombre_cliente, tipo_proyecto, fecha_creacion, estado FROM proyectos", Conexion.Conectar());

                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.UpdateCommand = builder.GetUpdateCommand();

                da.Update(dt);

                MessageBox.Show("Datos actualizados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }


        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_historial.SelectedRows.Count > 0) // Verificar si hay filas seleccionadas
            {
                int indexFilaSeleccionada = dgv_historial.SelectedRows[0].Index;

                DataTable dt = (DataTable)dgv_historial.DataSource;

                string nombreProyectoEliminar = dt.Rows[indexFilaSeleccionada]["nombre_proyecto"].ToString();

                // Eliminar el proyecto de la base de datos
                Conexion.Conectar();
                string eliminar = "DELETE FROM proyectos WHERE nombre_proyecto = @nombreProyecto";
                SqlCommand cmdEliminar = new SqlCommand(eliminar, Conexion.Conectar());
                cmdEliminar.Parameters.AddWithValue("@nombreProyecto", nombreProyectoEliminar);
                cmdEliminar.ExecuteNonQuery();

                // Actualizar los datos en el DataGridView
                dgv_historial.DataSource = datoshistorial();

                MessageBox.Show("Proyecto eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar");
            }

        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo de texto|*.txt";
            saveDialog.Title = "Guardar archivo de texto";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        foreach (DataGridViewRow row in dgv_historial.Rows)
                        {
                            string rowData = string.Join("\t", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value));
                            writer.WriteLine(rowData);
                        }
                    }

                    MessageBox.Show("Datos exportados a archivo de texto exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar datos a archivo de texto: " + ex.Message);
                }
            }
        }
    }
}
