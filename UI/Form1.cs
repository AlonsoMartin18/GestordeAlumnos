
using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly EstudianteBLL _estudianteBLL;
        private List<Estudiante> _estudiantesEnMemoria;
        public Form1()
        {
            InitializeComponent();
            _estudianteBLL = new EstudianteBLL();
            _estudiantesEnMemoria = new List<Estudiante>();
            CargarCursos();
            CargarEstudiantes();
            txtPromedio.Text = "0";
        }

        private void CargarCursos()
        {
            List<Curso> cursos = _estudianteBLL.ObtenerCursos();
            cmbCurso.DataSource = cursos;
            cmbCurso.DisplayMember = "NombreCurso";
            cmbCurso.ValueMember = "IdCurso";

            cmbNuevoCurso.DataSource = cursos;
            cmbNuevoCurso.DisplayMember = "NombreCurso";
            cmbNuevoCurso.ValueMember = "IdCurso";
        }

        // Cargar los estudiantes en la grilla
        private void CargarEstudiantes()
        {
            List<Estudiante> estudiantes = _estudianteBLL.ObtenerTodosLosEstudiantes();
            dataGridView1.DataSource = estudiantes;


            dataGridView1.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dataGridView1.Columns["PromedioActual"].HeaderText = "Promedio";
            dataGridView1.Columns["Curso"].Visible = false;


            if (!dataGridView1.Columns.Contains("NombreCurso"))
            {
                DataGridViewTextBoxColumn cursoColumn = new DataGridViewTextBoxColumn
                {
                    Name = "NombreCurso",
                    HeaderText = "Curso",
                    ReadOnly = true
                };
                dataGridView1.Columns.Add(cursoColumn);
            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Estudiante estudiante = row.DataBoundItem as Estudiante;
                if (estudiante != null)
                {
                    row.Cells["NombreCurso"].Value = estudiante.Curso.NombreCurso;
                }
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPromedio.Text = "0";
            txtIdEstudiante.Clear();
            txtNuevoNombre.Clear();
            txtNuevoPromedio.Clear();
            txtEliminarEstudiante.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
        }


        private void btnCargarEstudiante_Click_1(object sender, EventArgs e)
        {
            try
            {
                var estudiante = CrearEstudianteDesdeFormulario();
                _estudianteBLL.AgregarEstudiante(estudiante);

                MessageBox.Show("Estudiante cargado exitosamente.");
                LimpiarCampos();
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btnAgregarLista_Click_1(object sender, EventArgs e)
        {
            try
            {
                var estudiante = CrearEstudianteDesdeFormulario();
                _estudiantesEnMemoria.Add(estudiante);
                MessageBox.Show("Estudiante agregado a la lista en memoria.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btnConfirmarLista_Click_1(object sender, EventArgs e)
        {
            try
            {
                _estudianteBLL.CargarEstudiantesMasivos(_estudiantesEnMemoria);
                MessageBox.Show("Carga masiva realizada con éxito.");
                _estudiantesEnMemoria.Clear();
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga masiva: " + ex.Message);
                _estudiantesEnMemoria.Clear();
            }
        }

        private void btnModificarEstudiante_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idEstudiante = int.Parse(txtIdEstudiante.Text);
                var estudiante = CrearEstudianteModificado(idEstudiante);
                _estudianteBLL.ActualizarEstudiante(estudiante);

                MessageBox.Show("Estudiante modificado exitosamente.");
                LimpiarCampos();
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el estudiante: " + ex.Message);
            }
        }

        private void btnEliminarEstudiante_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idEstudiante = int.Parse(txtEliminarEstudiante.Text);
                _estudianteBLL.EliminarEstudiante(idEstudiante);

                MessageBox.Show("Estudiante eliminado exitosamente.");
                LimpiarCampos();
                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el estudiante: " + ex.Message);
            }
        }



        private Estudiante CrearEstudianteDesdeFormulario()
        {
            Curso cursoSeleccionado = (Curso)cmbCurso.SelectedItem;
            return new Estudiante
            {
                Nombre = txtNombre.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                PromedioActual = decimal.Parse(txtPromedio.Text),
                Curso = cursoSeleccionado
            };
        }

        private Estudiante CrearEstudianteModificado(int idEstudiante)
        {

            Estudiante estudianteExistente = _estudianteBLL.ObtenerTodosLosEstudiantes().Find(e => e.IdEstudiante == idEstudiante);
            if (estudianteExistente == null)
            {
                throw new Exception("No se encontró el estudiante.");
            }

            Curso cursoSeleccionado = (Curso)cmbNuevoCurso.SelectedItem;
            return new Estudiante
            {
                IdEstudiante = idEstudiante,
                Nombre = txtNuevoNombre.Text,
                FechaNacimiento = estudianteExistente.FechaNacimiento,
                PromedioActual = decimal.Parse(txtNuevoPromedio.Text),
                Curso = cursoSeleccionado
            };
        }


        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                Estudiante estudianteSeleccionado = filaSeleccionada.DataBoundItem as Estudiante;

                if (estudianteSeleccionado != null)
                {

                    txtEliminarEstudiante.Text = estudianteSeleccionado.IdEstudiante.ToString();


                    txtIdEstudiante.Text = estudianteSeleccionado.IdEstudiante.ToString();
                    txtNuevoNombre.Text = estudianteSeleccionado.Nombre;
                    txtNuevoPromedio.Text = estudianteSeleccionado.PromedioActual.ToString();


                    cmbNuevoCurso.SelectedItem = estudianteSeleccionado.Curso;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
