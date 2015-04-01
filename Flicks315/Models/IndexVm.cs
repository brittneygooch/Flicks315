using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flicks315.Data.Models; 

namespace Flicks315.Models
{
    public class IndexVm
    {
        public string Greeting { get; set; }
        public List<Movie> MyMovies { get; set; }
    }
}