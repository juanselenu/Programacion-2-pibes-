using Microsoft.AspNetCore.Mvc;
using TPProgramacion2.Models;

namespace TPProgramacion2.Controllers
{
    [ApiController]
    [Route("Api/HistoriaClinica")]
    public class HistoriaclinicaController : ControllerBase
   
    {
        static List<HistoriaClinica> HClist = new List<HistoriaClinica>
        {
            
        };

        [HttpGet]
        public List<HistoriaClinica> conusltaHC()
        {
            return HClist;
        }

        [HttpPost]

        public int CrearHC(HistoriaClinica hc)
        {
            HClist.Add(hc);
            return hc.IdHistoria;
        }

        [HttpPut("{IdHistoria}")]

        public ActionResult ModificarHC(int IdHistoria, HistoriaClinica historiaClinica)
        {
            var modificarhc = HClist.Find(x => x.IdHistoria == IdHistoria);

            if (modificarhc == null)
            {
                return NotFound();
            }

            modificarhc.Tratamiento = historiaClinica.Tratamiento;
            modificarhc.Atencion = historiaClinica.Atencion;
            modificarhc.MotivoConsulta = historiaClinica.MotivoConsulta;
            modificarhc.Medicamentos = historiaClinica.Medicamentos;
            modificarhc.FechaConsuta = historiaClinica.FechaConsuta;

            return Ok();
        }

        [HttpDelete("{IdHistoria}")]

        public ActionResult DeleteHCl(int IdHistoria, HistoriaClinica historiaClinica)

        {
            var delethc = HClist.Find(x => x.IdHistoria == IdHistoria);

            if (delethc == null)
                return NotFound();

            HClist.Remove(delethc);
            return Ok();

        }


    }
}
