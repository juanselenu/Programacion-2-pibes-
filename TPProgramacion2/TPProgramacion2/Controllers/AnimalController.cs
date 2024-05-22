using Microsoft.AspNetCore.Mvc;
using TPProgramacion2.Models;

namespace TPProgramacion2.Controllers
{
    [ApiController]
    [Route("Api/Animal")]
    public class AnimalController : ControllerBase
    {
        static List<Animal> animallist = new List<Animal>
        {
            new Animal (1,"firulai" , "microtoy" , "Manflor" , 32),

            new Animal (2,"tito" , "delmon", "semental", 19 )


        };

        [HttpGet]
        public List<Animal> conusltapersona()
        {
            return animallist;
        }

        [HttpPost]

        public int CrearAnimal(Animal animal)
        {
            animallist.Add(animal);
            return animal.IdAnimal;
        }

        [HttpPut("{iDa}")]

        public ActionResult ModificarAnimal(int iDa, Animal animal)
        {
            var modificaranimal = animallist.Find(x => x.IdAnimal == iDa);

            if (modificaranimal == null)
            {
                return NotFound();
            }

            modificaranimal.Nombrea = animal.Nombrea;
            modificaranimal.Raza = animal.Raza;
            modificaranimal.Sexo = animal.Sexo;
            modificaranimal.Edad = animal.Edad;

            return Ok();
        }

        [HttpDelete("{iDa}")]

        public ActionResult DeleteAnimal(int iDa, Animal animal)

        {
            var deleteanimal = animallist.Find(x => x.IdAnimal == iDa);

            if (deleteanimal == null)
                return NotFound();

            animallist.Remove(deleteanimal);
            return Ok();

        }


    }
}
