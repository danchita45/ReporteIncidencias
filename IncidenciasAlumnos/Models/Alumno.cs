namespace IncidenciasAlumnos.Models
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public int NumeroCuenta { get; set; }
        public int Incidencias { get; set; }
        public string Nombre { get; set; }
        public DateTime LastIncidence { get; set; }
        public string Contacto { get; set; }
        public Riesgo Riesgo { get; set; }
    }
}
