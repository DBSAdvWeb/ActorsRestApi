using System;

namespace ActorsRestApi.Models
{
    public class Actor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Guid CreatedBy { get; set; }
    }
}
