using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tournament.Core.Repositories;
using Tournament.Core.Entities;
using Tournament.Data.Data;

namespace Tournament.Data.Repositories
{
    internal class TournamentRepository : ITournamentRepository
    {
        private readonly Context db;

        public TournamentRepository(Context context)
        {
            db = context;
        }


        //############################################################################


        public void Add(Core.Entities.Tournament tournament)
        {
            throw new NotImplementedException();
        }


        //############################################################################


        public Task<bool> AnyAsync(Guid id)
        {
            throw new NotImplementedException();
        }


        //############################################################################


        public async Task<IEnumerable<Core.Entities.Tournament>> GetAllAsync()
        {
            return await db.Tournament.ToListAsync();
        }


        //############################################################################


        public async Task<Core.Entities.Tournament?> GetAsync(Guid id)
        {
            return await db.Tournament.FirstOrDefaultAsync(t => t.Id == id);
        }


        //############################################################################


        public void Remove(Core.Entities.Tournament tournament)
        {
            throw new NotImplementedException();
        }


        //############################################################################


        public void Update(Core.Entities.Tournament tournament)
        {
            throw new NotImplementedException();
        }


        //############################################################################

    }
}
