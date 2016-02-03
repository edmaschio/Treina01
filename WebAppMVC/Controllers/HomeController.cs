using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sua página de descrição.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sua página de contato.";

            return View();
        }

        public ActionResult Registro()
        {
            ViewBag.Message = "Suas informações de registro";
            ViewBag.Estados = new SelectList(
                    HelperEstados.Estados, "EstadoId", "Nome"
                );

            return View();
        }

        [HttpPost]
        public ActionResult Registro(Pessoa pessoa)
        {
            ViewBag.Estado = new SelectList(
                HelperEstados.Estados, "EstadoId", "Nome", pessoa.Estado
            );
            if (ModelState.IsValid)
            {
                return View("Obrigado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Obrigado(Pessoa pessoa)
        {
            return View(pessoa);
        }


    }
}