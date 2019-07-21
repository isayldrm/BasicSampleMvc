using PersonelMVC.Models;
using PersonelMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Detay(int id)
        {
            var departman = new Department() { Id = id, Ad = "Bilgi İşlem" };
            var personeller = new List<Personel>()
            {
                new Personel(){Ad="Personel1"},
                new Personel(){Ad="Personel2"},
                new Personel(){Ad="Personel3"}
            };

            var model = new DepartmanDetayViewModel()
            {
                Department = departman,
                Personeller = personeller
            };

            return View(model);
        }
    }
}