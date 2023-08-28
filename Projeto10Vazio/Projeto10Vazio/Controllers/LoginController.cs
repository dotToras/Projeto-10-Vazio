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

            metodoLogin.Verificar(classeLogin);


          
            if (classeLogin.Usuario != null && classeLogin.Senha != null )
            {
                
                Session["usuario"] = classeLogin.Usuario.ToString();
                Session["senha"] = classeLogin.Senha.ToString();

              
                return RedirectToAction("Index", "Home");
            }
            else
            {
             
                return RedirectToAction("Login", "Login");
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