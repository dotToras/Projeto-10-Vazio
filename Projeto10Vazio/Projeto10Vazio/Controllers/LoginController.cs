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
        public ActionResult Login(modelLogin model)
        {

            metodoLogin.Verificar(model);


          
            if (model.Usuario != null && model.Senha != null )
            {
                
                Session["Usuario"] = model.Usuario.ToString();
                Session["Senha"] = model.Senha.ToString();

              
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
        

            metodoLogin.Cadastrar(classeLogin);
            return View();
        }
        
    }
}