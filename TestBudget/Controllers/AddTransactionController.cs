using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBudget.Models;

namespace TestBudget.Controllers
{
    public class AddTransactionController : Controller
    {
        // GET: AddTransaction
        public ActionResult Index(AddTransactionViewModel model)
        {
            return View(model);
        }
    }
}