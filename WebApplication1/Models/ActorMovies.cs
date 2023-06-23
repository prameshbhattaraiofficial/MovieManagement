﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ActorMovies
    {

        public int MovieId { get; set; }

        public int ActorId { get; set; }

        public Movie Movie { get; set; }

        public Actor Actor { get; set; }
    }
}
