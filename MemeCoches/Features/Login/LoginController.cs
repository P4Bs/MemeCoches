using MemeCoches.Connect.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MemeCoches.Features.Login
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn([FromBody] LoginDto loginCredentials)
        {

            throw new NotImplementedException();
        }

    }
}
