using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Home
        public ActionResult Index(long? FabId, long? CatId)
        {
            Home h = new Home();
            h.fabi = context.Fabricantes.OrderBy(f => f.Nome);
            h.categ = context.Categorias.OrderBy(f => f.Nome);
            if (FabId != null) 
            {
                h.filtro = "Fabricante";
                h.produtos = context.Produtos.Where(p => p.FabricanteId == FabId).OrderBy(c => c.Nome);
            }
            if (CatId != null)
            {
                h.filtro = "Categoria";
                h.produtos = context.Produtos.Where(p => p.CategoriaId == CatId).OrderBy(c => c.Nome);
            }
            return View(h);
        }
    }
}