using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament.Core.Repositories;
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


        public Task<bool> AnyAsync(int id)
        {
            throw new NotImplementedException();
        }


        //############################################################################


        public Task<IEnumerable<Core.Entities.Tournament>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        //############################################################################


        public Task<Core.Entities.Tournament> GetAsync(int id)
        {
            throw new NotImplementedException();
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
