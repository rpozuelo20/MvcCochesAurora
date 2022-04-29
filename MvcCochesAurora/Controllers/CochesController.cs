using Microsoft.AspNetCore.Mvc;
using MvcCochesAurora.Models;
using MvcCochesAurora.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCochesAurora.Controllers
{
    public class CochesController : Controller
    {
        private RepositoryCoches repo;
        public CochesController(RepositoryCoches repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            List<Coche> coches = this.repo.GetCoches();
            return View(coches);
        }
    }
}
