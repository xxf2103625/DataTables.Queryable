using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DataTables.Queryable.Samples.Controllers
{
    public class DataTablesController : Controller
    {
        public IActionResult Index()
        {
            Request.QueryString
            return View();
        }
    }
}