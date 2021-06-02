using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicManagement.Models;
using Microsoft.Extensions.Logging;
using ClinicManagement.Services;

namespace ClinicManagement.Controllers
{
    public class SignInsController : Controller
    {
        private readonly ClinicContext _context;

        public readonly ILogger<SignInsController> _logger;
        public readonly ISignIn<SignIn> _repo;
        public SignInsController(ILogger<SignInsController> logger, ISignIn<SignIn> repo)
        {
            _logger = logger;
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<SignIn> userName = _repo.GetAll().ToList();
            return View(userName);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SignIn signIn)
        {
            _repo.Add(signIn);
            return RedirectToAction("Index");
        }
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SignIn signIn)
        {
            var obj = _repo.SignIn(signIn);
            try
            {
                if (obj != 0)
                {
                    return RedirectToAction("Success");

                }
            }
            catch (Exception e)

            {
                _logger.LogDebug(e.Message);

            }
            return RedirectToAction("Error");
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}

