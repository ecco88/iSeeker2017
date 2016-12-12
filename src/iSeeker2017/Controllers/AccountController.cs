using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace iSeeker2017.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //public SignInResult SignIn()
        //{
            
        //}
        [Route("SignIn")]
        [Route("SignOn")]
        public IActionResult SignIn()
        {
            return View();
        }

        [Route("SignOut")]
        [Route("SignOff")]
        public IActionResult SignOut()
        {
            return View();
        }
    }
}
