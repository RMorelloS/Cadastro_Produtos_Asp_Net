using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula03_MVC_02.Controllers
{
    public class ShampooController : Controller
    {
        // GET: JogadorFutebol
        public ActionResult Index()
        {
            TempData["id"] = ProcessaProduto.obterIndiceAtual();
            return View();
        }

       public RedirectToRouteResult cadastraShampoo(int id, string nome, string tipoSabao)
        {
            var result = ProcessaProduto.cadastraProduto(id, nome, tipoSabao, "shampoo");
            TempData["result"] = result;
            return RedirectToAction("/");
        }
    }
}