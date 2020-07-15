using PortalDeNoticias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDeNoticias.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: Noticias
        public ActionResult Index()
        {
           ViewBag.Mensagem = "Enviando texto da Controller para a View, com ViewBag.";
            return View(RepositorioNoticias.Noticias);
        }

        public  ActionResult Detalhes(int id)
        {
            var noticia = RepositorioNoticias.Noticias.FirstOrDefault(n => n.Id == id);

            return View(noticia);
        }

        public ActionResult Buscar(string textos) {

            var noticias = RepositorioNoticias.Noticias.Where(n => n.Titulo.Contains(textos) || n.Conteudo.Contains(textos));

            return View(noticias);
        }
    }
}