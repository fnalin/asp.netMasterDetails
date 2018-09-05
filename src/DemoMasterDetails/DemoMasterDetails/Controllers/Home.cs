using DemoMasterDetails.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMasterDetails.Controllers
{
    public class Home:Controller
    {

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Salvar(Cliente cliente)
        {

        }
    }
}
