using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using The7_BackEnd.DAL;
using The7_BackEnd.Models;
using The7_BackEnd.ViewModels;

namespace The7_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.PageIntro = _context.PageIntro.FirstOrDefault();
            homeVM.Service = _context.Service.ToList();
            homeVM.Blog = _context.Blog.ToList();
            homeVM.Team = _context.Team.ToList();

            return View(homeVM);
        }
    }
}
