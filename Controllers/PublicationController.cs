using Publication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Publication.Controllers
{
    public class PublicationController : Controller
    {
        // GET: Publication
        public ActionResult Index()
        {
            var publications = DataRepository.GetAllPublications(); //send data from repo to view
            return View(publications);
        }
    }
}