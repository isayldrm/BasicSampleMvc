using PersonelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelMVC.ViewModel
{
    public class DepartmanDetayViewModel
    {
        public Department Department { get; set; }

        public List<Personel> Personeller { get; set; }
    }
}