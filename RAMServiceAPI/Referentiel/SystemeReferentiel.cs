using RAMServiceAPI.Entites;

namespace RAMServiceAPI.Referentiel
{
    public class SystemeReferentiel
    {
        private readonly List<Systemes> SysList = new()
        {
            new Systemes { Id = 1, Nom = "ASF", CAO = "Francine R.", Developpeurs = new() { "Dave", "Jean" } },
            new Systemes
            {
                Id = 2,
                Nom = "ECS",
                CAO = "Dany C.",
                Developpeurs = new() { "ABC", "Pierre" }
            },

            new Systemes
            {
                Id = 3,
                Nom = "MSI",
                CAO = "François T.",
                Developpeurs = new() { "Michel", "Joe" }


            }
        };

        public IEnumerable<Systemes> ObtenirSystemes()
        {
            return SysList;
        }


        public Systemes ObtenirSystemes(int id)
        {
            return SysList.Where(s => s.Id == id).SingleOrDefault();
        }

        public IEnumerable<Systemes> ModifierSysteme(int id, string cao)
        {
            return SysList.Where(s => s.Id == id).Select(s => { s.CAO = cao; return s; }).ToList();
        }


        public IEnumerable<Systemes> SupprimerSysteme(int id)
        {
            SysList.RemoveAll(s => s.Id == id);
            return SysList;
        }

        public IEnumerable<Systemes> AjoutSysteme(Systemes sys)
        {
            SysList.Add(sys);
            return SysList;
        }

    }
}
