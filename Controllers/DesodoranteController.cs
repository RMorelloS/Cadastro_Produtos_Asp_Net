using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula03_MVC_02.Controllers
{
    public class DesodoranteController : Controller
    {
        // GET: Desodorante
        public ActionResult Index()
        {
            TempData["id"] = ProcessaProduto.obterIndiceAtual();
            return View();
        }

        public RedirectToRouteResult cadastraDesodorante(int id, string nome, string tipoAplicacao)
        {
            
            string result = ProcessaProduto.cadastraProduto(id, nome, tipoAplicacao, "desodorante");
            TempData["result"] = result;
            return RedirectToAction("/");
        }
    }
}