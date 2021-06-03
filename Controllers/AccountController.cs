using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            ViewBag.CountryList = new List<CountryModel> { new CountryModel { CountryCode="IN",Country="India"},
                new CountryModel{CountryCode="US",Country="USA"} };
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            //if (string.IsNullOrEmpty(model.Name))
            //{
            //    ModelState.AddModelError("Name", "Please Enter Name");
            //}
            //if (string.IsNullOrEmpty(model.Password))
            //{
            //    ModelState.AddModelError("Password", "Please Enter Password");
            //}

            if (ModelState.IsValid)
            {
                // TO DO:
                return RedirectToAction("Message");
            }
            ViewBag.CountryList = new List<CountryModel> { new CountryModel { CountryCode="IN",Country="India"},
                new CountryModel{CountryCode="US",Country="USA"} };
            return View();
        }

        [HttpGet]
        public JsonResult GetCities(string CountryCode )
        {
            List<CityModel> Cities = new CityModel().GetCitities().Where(x => x.CountryCode == CountryCode).ToList();
           
            return Json(new SelectList(Cities, "CityCode", "City"));
        }

    }
}
