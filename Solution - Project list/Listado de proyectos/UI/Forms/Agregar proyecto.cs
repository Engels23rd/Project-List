using Listado_de_proyectos.Class;
using Listado_de_proyectos.UI.Forms;
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
using System.Xml.Linq;


namespace Listado_de_proyectos.Forms
{
    public partial class Agregar_proyecto : Form
    {
        public Agregar_proyecto()
        {
            InitializeComponent();
        }

        private void Agregar_proyecto_Load(object sender, EventArgs e)
        {


            Conexion.Conectar();

            DataTable dt = Datos();
            dt.Columns.Add("NumeroSecuencial"); // Agregar columna de número secuencial

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["NumeroSecuencial"] = i + 1; // Establecer número secuencial
            }

            // Con esto aplicamos la consulta que hice
            dgv_proyecto.DataSource = Datos();
            dgv_proyecto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Bloquear la edición de la columna 'id'
            dgv_proyecto.Columns["Id"].ReadOnly = true;

            Datos();
        }

        private void HistorialForm_ProyectosActualizados(object sender, EventArgs e)
        {
            // Refrescar los datos en el DataGridView
            dgv_proyecto.DataSource = Datos();
        }

        //Para que se vea la tabla en el DataGridView
        int mesActual = DateTime.Now.Month;
        int añoActual = DateTime.Now.Year;

        public DataTable Datos()
        {
            Conexion.Conectar();

            DataTable dt = new DataTable();
            string consulta = $"SELECT id, nombre_proyecto, nombre_cliente, tipo_proyecto, fecha_creacion, estado FROM proyectos WHERE MONTH(fecha_creacion) = {mesActual} AND YEAR(fecha_creacion) = {añoActual}";

            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            //Llamamos la clase de conexion
            Conexion.Conectar();

            //Comandos SQL para permitirnos agregar
            string insertar = "INSERT INTO proyectos (nombre_proyecto, nombre_cliente, tipo_proyecto)" +
                "VALUES(@proyecto,@cliente,@tipo)";
            SqlCommand code1 = new SqlCommand(insertar, Conexion.Conectar());
            code1.Parameters.AddWithValue("@proyecto", txt_proyecto.Text);
            code1.Parameters.AddWithValue("@cliente", txt_cliente.Text);
            code1.Parameters.AddWithValue("@tipo", txt_tipo.Text);

            code1.ExecuteNonQuery();
            MessageBox.Show("Se agrego exitosamente");

            dgv_proyecto.DataSource = Datos();

        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgv_proyecto.DataSource;
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
            if (dgv_proyecto.SelectedRows.Count > 0) // Verificar si hay filas seleccionadas
            {
                int indexFilaSeleccionada = dgv_proyecto.SelectedRows[0].Index;

                DataTable dt = (DataTable)dgv_proyecto.DataSource;

                string nombreProyectoEliminar = dt.Rows[indexFilaSeleccionada]["nombre_proyecto"].ToString();

                // Eliminar el proyecto de la base de datos
                Conexion.Conectar();
                string eliminar = "DELETE FROM proyectos WHERE nombre_proyecto = @nombreProyecto";
                SqlCommand cmdEliminar = new SqlCommand(eliminar, Conexion.Conectar());
                cmdEliminar.Parameters.AddWithValue("@nombreProyecto", nombreProyectoEliminar);
                cmdEliminar.ExecuteNonQuery();

                // Actualizar los datos en el DataGridView
                dgv_proyecto.DataSource = Datos();

                MessageBox.Show("Proyecto eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar");
            }

        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txt_proyecto.Text = "";
            txt_cliente.Text = "";
            txt_tipo.Text = "";
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
                        foreach (DataGridViewRow row in dgv_proyecto.Rows)
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
