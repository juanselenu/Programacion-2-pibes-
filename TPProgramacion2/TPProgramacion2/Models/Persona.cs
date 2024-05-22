namespace TPProgramacion2.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int DNI { get; set; }


        public Persona(int iD, string nombre, string apellido , int dni)
        {
            ID = iD;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
        }

    }
}
