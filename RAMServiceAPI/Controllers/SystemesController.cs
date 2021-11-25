using Microsoft.AspNetCore.Mvc;
using RAMServiceAPI.Entites;
using RAMServiceAPI.Referentiel;

namespace RAMServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SystemesController : Controller
    {
        private readonly SystemeReferentiel referentiel;

        public SystemesController()
        {
            referentiel = new SystemeReferentiel();
        }

        // GET /Systeme
        [HttpGet]
        public IEnumerable<Systemes> ObtenirLesSystemes()
        {
            return referentiel.ObtenirSystemes();
        }

        // Get /systemes/{id}
        [HttpGet("id")]
        public ActionResult<Systemes> ObtenirUnSysteme(int id)
        {
            var sys = referentiel.ObtenirSystemes(id);

            if (sys is null)
                return NotFound();

            return sys;
        }

        // PUT /systeme
        [HttpPut]
        public IEnumerable<Systemes> ModifSysteme(int id, string cao)
        {
            return referentiel.ModifierSysteme(id, cao);
        }

        // POST /systeme
        [HttpPost()]
        public IEnumerable<Systemes> AjoutSysteme(Systemes nSys)
        {
            Systemes nouveauSysteme = new()
            {
                Id = nSys.Id,
                Nom = nSys.Nom,
                CAO = nSys.CAO,
                Developpeurs = nSys.Developpeurs
               
            };

            return referentiel.AjoutSysteme(nouveauSysteme);

        }

        // DELETE /Systemes/{id}
        [HttpDelete("id")]
        public IEnumerable<Systemes> Delete(int id)
        {
            return referentiel.SupprimerSysteme(id);
        }

    }
}
