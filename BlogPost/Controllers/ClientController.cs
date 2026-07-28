using BlogPost.Data;
using BlogPost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BlogPost.Controllers
{
    public class ClientController : Controller
    {
        private readonly AppDbContext _context;

        public ClientController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Search()
        //{
        //    var clients = new List<ClientVM>()
        //{
        //    new ClientVM(){Id=1,Name="John Smith",Phone="0412345678"},
        //    new ClientVM(){Id=2,Name="David Lee",Phone="0433445566"},
        //    new ClientVM(){Id=3,Name="Mary Jones",Phone="0444556677"}
        //};

        //    return PartialView("_SearchClient", clients);
        //}
        [HttpGet]
        public IActionResult SearchClients(string search)
        {
            var clients = _context.Posts
                .Where(x => string.IsNullOrEmpty(search) ||
                            x.Title.Contains(search))
                .Select(x => new
                {
                    id = x.Id,
                    name = x.Title
                   
                })
                .Take(20)
                .ToList();

            return Json(clients);
        }
    }
}
