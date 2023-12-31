﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Core.Entities
{
    public class Game
    {
        public Guid Id { get; set; }
        [MaxLength(30)]
        public string Title { get; set; } = string.Empty;
        public DateTime Time { get; set; }
        public Guid TournamentId { get; set; }
        public Tournament Tournament { get; set; } = default!;
    }
}
