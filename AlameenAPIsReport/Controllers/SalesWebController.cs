using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlameenAPIsReport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlameenAPIsReport.Controllers
{
    public class SalesWebController : Controller
    {
        private readonly AmeenContext _context;

        public SalesWebController(AmeenContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Cu"] = new SelectList(_context.Cu000, "ID", "Name");
            ViewData["my"] = new SelectList(_context.My000, "ID", "Name");


            return View();
        }
    }
}