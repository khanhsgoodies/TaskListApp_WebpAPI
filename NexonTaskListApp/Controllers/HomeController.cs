using Newtonsoft.Json;
using NexonTaskListApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NexonTaskListApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TaskManager taskManager = new TaskManager();
            return View(taskManager.Tasks);
        }
    }
}
