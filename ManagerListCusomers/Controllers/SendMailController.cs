using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagerListCusomers.Models;
using System.Web.Helpers;

namespace ManagerListCusomers.Controllers
{
    public class SendMailController : Controller
    {
        // GET: SendMail
        public ActionResult SendMail()
        {
            return View("SendMail");
        }
        //public ActionResult SendEmail(SendMailModel obj)
        //{

        
        //}
    }
}