using Flicks315.Data;
using Flicks315.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flicks315.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexVm iVm = new IndexVm();
            
            using (FlicksDbContext db = new FlicksDbContext())
            {
                iVm.MyMovies = db.Movies.ToList();
            }
            return View(iVm);
        }

        //Details

        public ActionResult Details(int id)
        {
            DetailsVm dVm = new DetailsVm();
            dVm.Greeting = "All About Me";
            using (FlicksDbContext db = new FlicksDbContext())
            {
                var aResults = db.Actors.Where(m => m.MovieId == id).ToList();
                dVm.Actors = aResults;
                var mResults = db.Movies.FirstOrDefault(m => m.MovieId == id);
                dVm.Movie = mResults;
            }
            return View(dVm);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}