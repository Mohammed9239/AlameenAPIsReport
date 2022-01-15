using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlameenAPIsReport.Models;
using AlameenAPIsReport.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlameenAPIsReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly AmeenContext _context;

        public SalesController(AmeenContext context)
        {
            _context = context;
        }


        // To Insert Sales
        [HttpGet("Sale")]
        public JsonResult Sale()
        {

            var Ac = new SalesVm
            {
                cu000 = _context.Cu000.ToList(),
            };

            return new JsonResult(Ac);
        }

    }
}