﻿namespace ActorsRestApi.Models
{
    public class ActorMovies
    {
        public int Id { get; set; }

        public int ActorId { get; set; }

        public int MovieId { get; set; }

        public Actor Actor { get; set; }

    }
}
