using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            /* Forma de colocar validação dentro do controller ( Não recomendado )
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "Nome Obrigatorio");
            }

            if(usuario.Senha != usuario.ConfirmarSenha)
            {
                ModelState.AddModelError("", "Senha diferente");
            }
            */

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View();
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Hugo",
                "Freitas",
                "Paulo"
            };

            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}