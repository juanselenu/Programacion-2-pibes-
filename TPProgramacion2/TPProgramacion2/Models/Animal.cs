namespace TPProgramacion2.Models
{
    public class Animal
    {
        public int IdAnimal { get; set; }
        public string Nombrea { get; set; }
        public string Raza { get; set; }

        public string Sexo { get; set; }

        public int Edad { get; set; }

        //public Persona Persona { get; set; }


        public Animal(int iDa, string nombrea, string raza , string sexo , int edad)
        {
            IdAnimal = iDa;
            this.Nombrea = nombrea;
            this.Raza = raza;
            this.Sexo = sexo;
            this.Edad = edad;   
        }


    }
}
