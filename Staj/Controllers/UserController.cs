using Microsoft.AspNetCore.Mvc;
using Staj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj.Controllers
{
    public class UserController : Controller
    {
        readonly Context _context;
        public UserController (Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
