using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Core.Repositories
{
    public interface ITournamentRepository
    {
        Task<IEnumerable<Entities.Tournament>> GetAllAsync();
        Task<Entities.Tournament> GetAsync(int id);
        Task<bool> AnyAsync(int id);
        void Add(Entities.Tournament tournament);
        void Update(Entities.Tournament tournament);
        void Remove(Entities.Tournament tournament);
    }
}
