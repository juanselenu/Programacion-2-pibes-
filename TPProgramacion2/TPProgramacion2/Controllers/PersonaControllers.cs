using Microsoft.AspNetCore.Mvc;
using TPProgramacion2.Models;

namespace TPProgramacion2.Controllers
{
    [ApiController]
    [Route("Api/Persona")]
    public class PersonaControllers : ControllerBase
    {
        static List<Persona> Personalist = new List<Persona>
        {
            new Persona (1,"juan" , "perez", 39661206 ),

            new Persona (2,"leo" ," messi", 39660217)


        };


        [HttpGet]
        public List<Persona> conusltapersona()
        {
            return Personalist;
        }

        [HttpPost]

        public int CrearPersona(Persona persona)
        {
            Personalist.Add(persona);
            return persona.ID;
        }

        [HttpPut("{id}")]

        public ActionResult ModificarPersona(int id, Persona persona)
        {
            var modificapersona = Personalist.Find(x => x.ID == id);

            if (modificapersona == null)
            {
                return NotFound();
            }

            modificapersona.Nombre = persona.Nombre;
            modificapersona.Apellido = persona.Apellido;
            modificapersona.DNI = persona.DNI;

            return Ok();
        }

        [HttpDelete("{id}")]

        public ActionResult DeletePersona(int id, Persona persona)

        {
            var deletepersona = Personalist.Find(x => x.ID == id);

            if (deletepersona == null)
                return NotFound();

            Personalist.Remove(deletepersona);
            return Ok();

        }



    }
}
