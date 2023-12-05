using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Core.Entities
{
    public class Tournament
    {
        public Guid Id { get; set; }
        [MaxLength(30)]
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
