using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Data.Data
{
    public class SeedData
    {
        private static Context db = null!;

        public static async Task InitAsync(Context context)
        {
            db = context ?? throw new ArgumentNullException(nameof(context));

            if (await db.Tournament.AnyAsync()) return;


        }
    }
}
