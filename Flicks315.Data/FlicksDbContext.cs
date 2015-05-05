using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flicks315.Data.Models;

namespace Flicks315.Data
{
    public class FlicksDbContext: DbContext
    {
        public FlicksDbContext()
            : base("FlicksDb315"){}
        

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}
