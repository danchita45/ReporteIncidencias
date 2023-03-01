namespace IncidenciasAlumnos.Models
{
    public class Reporte
    {
        public int ReporteId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDescription { get; set; }
        public Alumno Alumno { get; set; }
    }
}
