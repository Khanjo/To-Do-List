using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Linq;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ToDoListContext _db;

        public HomeController(ToDoListContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            Category[] cats = _db.Categories.ToArray();
            Item[] items = _db.Items.ToArray();
            Dictionary<string, object[]> model = new Dictionary<string, object[]>();
            model.Add("categories", cats);
            model.Add("items", items);
            ViewBag.PageTitle = "To Do List";
            return View(model);
        }

    }
}