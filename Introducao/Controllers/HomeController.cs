using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                PessoaID = 1,
                Nome = "Carlos",
                Tipo = "Adinistrador"
            };

            /* Formas de trazer os dados - VIEWDATA
            
            ViewBag["PessoaID"] = pessoa.PessoaID;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Adinistrador"] = pessoa.Tipo;
            
            */
            /* Formas de trazer os dados - VIEWBAG 

            ViewBag.Id = pessoa.PessoaID;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Tipo = pessoa.Tipo;
            */

            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }


        /*Forma passando cada parametro individualmente.
         
          [HttpPost]
          public ActionResult Lista(int PessoaID, string Nome, string Tipo)
        {
            //ViewData["PessoaId"] = PessoaID;
            //ViewData["Nome"] = Nome;
            //ViewData["Tipo"] = Tipo;

            ViewBag.Id = PessoaID;
            ViewBag.Nome = Nome;
            ViewBag.Tipo = Tipo;

            return View();
        } */

        /* Forma com FormCollection
        [HttpPost]
        public ActionResult Lista(FormCollection form)
        {
            ViewBag.Id = form["PessoaID"];
            ViewBag.Nome = form["Nome"];
            ViewBag.Tipo = form["Tipo"];

            //ViewData["PessoaId"] = form["PessoaID"];
            //ViewData["Nome"] = form["Nome"];
            //ViewData["Tipo"] = form["Tipo"];
            return View();

        }
        */

        /* Forma com VieW recebendo parametros de forma tipada
        [HttpPost]
        public ActionResult Lista(Pessoa p)
        {
            ViewBag.Id = p.PessoaID;
            ViewBag.Nome = p.Nome;
            ViewBag.Tipo = p.Tipo;
          
            return View();

        } */

        // REcebendo e passando os falares tipados.
        [HttpPost]
        public ActionResult Lista(Pessoa p)
        {
            
            return View(p);

        }
    }
}
 