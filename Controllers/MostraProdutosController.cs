using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula03_MVC_02.Controllers
{
    public class MostraProdutosController : Controller
    {
        // GET: MostraProdutos
        public ActionResult Index()
        {
            return View();
        }
    }
}