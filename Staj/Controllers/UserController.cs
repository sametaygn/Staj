using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Staj.Hubs;
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
        readonly IHubContext<MonitorHub> _hubContext;
        public UserController(IHubContext<MonitorHub> hubContext, Context context)
        {
           _hubContext = hubContext;
           _context = context;
        }
        public async Task SenddMessage(string type, string id ,string name,string surname,string password,string email)
        {
            await _hubContext.Clients.All.SendAsync("ReciveeMessage", type,id, name, surname, password, email);
        }

        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
        public IActionResult Update(int id)
        {
            var user = _context.Users.Find(id);

            return View(user);
        }
        [HttpPost]
        public async Task <IActionResult> Update(User updated_user)
        {
            if (!ModelState.IsValid)
            {
                return View(updated_user);
            }
            _context.Users.Update(updated_user);
            _context.SaveChanges();
            await SenddMessage("Update",updated_user.Id.ToString(),updated_user.Name,updated_user.Surname,updated_user.Password,updated_user.Email );
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(User deleted_user_id)
        {
            var d_user = _context.Users.Find(deleted_user_id.Id);
            _context.Users.Remove(d_user);
            _context.SaveChanges();
            await SenddMessage("Kullanıcı Silme",d_user.Id.ToString(),d_user.Name, d_user.Surname, d_user.Password, d_user.Email);
            return RedirectToAction("Index");
        }
        public IActionResult Add_User()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add_User(User added_user)
        {
            if (!ModelState.IsValid)
            {
                return View(added_user);
            }
            _context.Users.Add(added_user);
            _context.SaveChanges();
            await SenddMessage("Add User", added_user.Id.ToString(),added_user.Name, added_user.Surname, added_user.Password, added_user.Email);
            return RedirectToAction("Index");
        }
        public IActionResult Monitoring()
        {
            return View();
        }
    }
}
