using BlogPost.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            var clients = new List<ClientVM>()
        {
            new ClientVM(){Id=1,Name="John Smith",Phone="0412345678"},
            new ClientVM(){Id=2,Name="David Lee",Phone="0433445566"},
            new ClientVM(){Id=3,Name="Mary Jones",Phone="0444556677"}
        };

            return PartialView("_SearchClient", clients);
        }
    }
}
