using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula03_MVC_02.Controllers
{
    public class PerfumeController : Controller
    {
        // GET: JogadorVolei
        public ActionResult Index()
        {
            TempData["id"] = ProcessaProduto.obterIndiceAtual();
            return View();
        }

        public RedirectToRouteResult cadastraPerfume(int id, string nome, string aroma )
        {
            var result = ProcessaProduto.cadastraProduto(id, nome, aroma, "perfume");
            TempData["result"] = result;
            return RedirectToAction("/");
        }
    }
}