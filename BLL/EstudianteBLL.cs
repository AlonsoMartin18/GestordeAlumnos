
using System.Transactions;
using DAL;
using Entity;

namespace BLL
{
    public class EstudianteBLL
    {
        private readonly EstudianteDAL estudianteDal;
        private readonly CursoDAL cursoDAL;

        public EstudianteBLL()
        {
            estudianteDal = new EstudianteDAL();
            cursoDAL = new CursoDAL();
        }

        // Validacion correspondiente de todos los estudiantes
        private void ValidarEstudiante(Estudiante estudiante, bool esNuevo)
        {
            // Nombre del Estudiante
            if (string.IsNullOrWhiteSpace(estudiante.Nombre) || estudiante.Nombre.Length < 3)
            {
                throw new Exception("El nombre del estudiante debe tener al menos 3 caracteres.");
            }

            // Edad del Estudiante
            if (estudiante.Edad < 16 || estudiante.Edad > 60)
            {
                throw new Exception("La edad del estudiante debe ser mayor o igual a 16 y menor o igual a 60.");
            }

            // Promedio del Estudiante
            if (esNuevo && estudiante.PromedioActual != 0)
            {
                throw new Exception("El promedio inicial de un nuevo estudiante debe ser cero.");
            }
            else if (!esNuevo && (estudiante.PromedioActual < 0 || estudiante.PromedioActual > 10))
            {
                throw new Exception("El promedio debe estar entre 0 y 10.");
            }

            // Curso del Estudiante
            if (estudiante.Curso == null || cursoDAL.GetById(estudiante.Curso.IdCurso) == null)
            {
                throw new Exception("Debe seleccionar un curso válido.");
            }
        }

        // Agregar un estudiante
        public void AgregarEstudiante(Estudiante estudiante)
        {
            ValidarEstudiante(estudiante, esNuevo: true);

            using (TransactionScope scope = new TransactionScope())
            {
                
                try
                {
                    estudianteDal.AgregarEstudiante(estudiante);
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar el estudiante" + ex.Message);
                }
            }
        }

        // Carga de mas de un estudiantes
        public void CargarEstudiantesMasivos(List<Estudiante> estudiantes)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    foreach (var estudiante in estudiantes)
                    {
                        ValidarEstudiante(estudiante, esNuevo: true);
                        estudianteDal.AgregarEstudiante(estudiante);
                    }
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la carga de mas de un estudiantes: " + ex.Message);
                }
            }
        }

        // Obtener a todos los estudiantes
        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            try
            {
                return estudianteDal.ObtenerTodosLosEstudiantes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener a los estudiantes: " + ex.Message);
            }
        }

        // Actualizar a un estudiante
        public void ActualizarEstudiante(Estudiante estudiante)
        {
            // Validar que el estudiante ya se encuentre en la base de datos
            if (estudianteDal.ObtenerTodosLosEstudiantes().Find(e => e.IdEstudiante == estudiante.IdEstudiante) == null)
            {
                throw new Exception("El estudiante a actualizar no existe.");
            }

            ValidarEstudiante(estudiante, esNuevo: false);

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    estudianteDal.ActualizarEstudiante(estudiante);
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el estudiante." + ex.Message);
                }
            }
        }

        // Eliminar un estudiante
        public void EliminarEstudiante(int idEstudiante)
        {
            if (estudianteDal.ObtenerTodosLosEstudiantes().Find(e => e.IdEstudiante == idEstudiante) == null)
            {
                throw new Exception("El estudiante a eliminar es inexistente.");
            }

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    estudianteDal.EliminarEstudiante(idEstudiante);
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el estudiante." + ex.Message);
                }
            }
        }

        // Obtener todos los cursos.
        public List<Curso> ObtenerCursos()
        {
            try
            {
                return cursoDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los cursos." + ex.Message);
            }
        }
    }
}
