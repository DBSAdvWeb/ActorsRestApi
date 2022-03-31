using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ActorsRestApi.Models;

namespace ActorsRestApi.Data
{
    public class ActorsRestApiContext : DbContext
    {
        public ActorsRestApiContext (DbContextOptions<ActorsRestApiContext> options)
            : base(options)
        {
        }

        public DbSet<ActorsRestApi.Models.Actor> Actor { get; set; }
    }
}
