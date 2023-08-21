using Projeto10Vazio.Acoes;
using Projeto10Vazio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto10Vazio.Controllers
{
    public class LoginController : Controller
    {
        acLogin metodoLogin = new acLogin();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Login(modelLogin classeLogin)
        {

            if(metodoLogin.Verificar(classeLogin) ==1)
            {

              return RedirectToAction("Index", "Home");

            }
        



                return View();
        }

        public ActionResult Cadastro()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(modelLogin classeLogin)
        {
        

            metodoLogin.Logar(classeLogin);
            return View();
        }
        
    }
}