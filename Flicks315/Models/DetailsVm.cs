using Flicks315.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flicks315.Models
{
    public class DetailsVm
    {
        public string Greeting { get; set; }
        public Movie Movie { get; set; }
        public List<Actor> Actors { get; set; }
    }
}