namespace TPProgramacion2.Models
{
    public class HistoriaClinica
    {
        public int IdHistoria { get; set; }
        public string Tratamiento { get; set; }
        public string Atencion { get; set; }

        public string MotivoConsulta { get; set; }

        public string Medicamentos { get; set; }

        public DateTime FechaConsuta { get; set; }

        public HistoriaClinica(int idhc, string tratamiento, string atencion, string motivoconsulta, string medicamentos, DateTime fechaconsuta)
        {
            IdHistoria = idhc;
            this.Tratamiento = tratamiento;
            this.Atencion = atencion;
            this.MotivoConsulta = motivoconsulta;
            this.Medicamentos = medicamentos;
            this.FechaConsuta = fechaconsuta;

            if (fechaconsuta > DateTime.Now)
            {
                throw new ArgumentException("La fecha de consulta no puede ser en el futuro.", nameof(fechaconsuta));
            }

            this.FechaConsuta = fechaconsuta;
        }
    }


    
  





}
