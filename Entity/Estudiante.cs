
namespace Entity
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal PromedioActual { get; set; }
        public Curso Curso { get; set; } 

        // Se utiliza para el calcul de la edad 
        public int Edad
        {
            get
            {
                return DateTime.Today.Year - FechaNacimiento.Year -
                       (FechaNacimiento > DateTime.Today.AddYears(-(DateTime.Today.Year - FechaNacimiento.Year)) ? 1 : 0);
            }
        }
    }
}
