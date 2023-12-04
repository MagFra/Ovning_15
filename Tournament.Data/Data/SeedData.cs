using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament.Core.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Tournament.Data.Data
{
    public class SeedData
    {
        private static Context db = null!;

        public static async Task InitAsync(Context context)
        {
            db = context ?? throw new ArgumentNullException(nameof(context));

            if (await db.Tournament.AnyAsync()) return;

            var turnaments = GenerateTurnaments(5);
            await db.AddRangeAsync(turnaments);
            await db.SaveChangesAsync();
        }

        private static IEnumerable<Core.Entities.Tournament> GenerateTurnaments(int numberOfTurnaments)
        {
            var faker = new Faker<Core.Entities.Tournament>("sv").Rules((f, t) =>
            {
                t.Title = f.Lorem.Word();
                t.StartDate = f.Date.Future();
                t.Games = GenerateGames(f.Random.Int(min: 2, max: 5));
            });

            return faker.Generate(numberOfTurnaments);
        }

        private static ICollection<Game> GenerateGames(int numberOfGames)
        {
            var faker = new Faker<Game>("sv").Rules((f, t) =>
            {
                t.Title = f.Lorem.Word();
                t.Time = f.Date.Future();
            });

            return faker.Generate(numberOfGames);
        }
    }
}
