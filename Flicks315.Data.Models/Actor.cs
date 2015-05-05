using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flicks315.Data.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public int Awards { get; set; }

        public int MovieId { get; set; }
        [ForeignKey("MovieId")]

        public virtual Movie Movie { get; set; }
    }
}
