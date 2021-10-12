using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelHistory.DatabaseContext;
using TravelHistory.Models;

namespace TravelHistory.Controllers
{
    public class PassportTypesController : Controller
    {
        TravelHistoryDbContext _db=new TravelHistoryDbContext();
        // GET: PassportTypes
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PassportType passportType)
        {
            if (passportType.Name!="")
            {
                _db.PassportTypes.Add(passportType);
                var isSaved = _db.SaveChanges();
                if (isSaved>0)
                {
                    ViewBag.SMsg = "Successfully Saved";
                }
                else
                {
                    ViewBag.FMsg = "Failed! Please Try Again...";
                }
            }
            return View();
        }
    }
}