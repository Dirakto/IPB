using System.Collections.Generic;
using System.Linq;

namespace ipb.Models
{
    public class AppRepository : IAppRepository
    {
        
        private AppDbContext repo;

        public AppRepository(AppDbContext context){
            repo = context;
        }

        public ICollection<List> Listy() => repo.Listy.ToList();
        public void UpdateList(List l) => repo.Listy.Update(l);
        public void AddList(List l) => repo.Listy.Add(l);
        public void Save() => repo.SaveChangesAsync();

    }
}