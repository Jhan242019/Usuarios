using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Usuarios.Areas.Users.Controllers
{
    [Area("Users")] // especificamos al controlador que esta en la area Users
    public class UsersController : Controller
    {

        public ViewResult Index()
        {
            return View("Index");
        }
        public ViewResult Users()
        {
            return View("Users");
        }

        public ViewResult Registrar()
        {
            return View("Registrar");
        }
    }
}
